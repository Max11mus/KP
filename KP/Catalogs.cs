using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KP
{
    public partial class Catalogs : Form
    {
        public readonly string BooksFileName = "books.txt";
        private List<Book> _books;
        private int _currentIndex = -1; // Поточний індекс у списку книг

        // BindingSource і BindingList для зв'язування з DataGridView
        private readonly BindingSource _bindingSource = new BindingSource();
        private BindingList<Book> _bindingList;

        public Catalogs()
        {
            InitializeComponent();

            // Покажемо тільки потрібні колонки — вимикаємо авто-генерацію колонок
            dataGridViewBooks.AutoGenerateColumns = false;
            SetupGridColumns();

            dataGridViewBooks.DataSource = _bindingSource;
            dataGridViewBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBooks.MultiSelect = false;
            dataGridViewBooks.ReadOnly = true;
            dataGridViewBooks.SelectionChanged += DataGridViewBooks_SelectionChanged;

            // Включаємо double buffering для зменшення артефактів перерисовки (непублічне API)
            try
            {
                typeof(DataGridView).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic)
                    ?.SetValue(dataGridViewBooks, true, null);
            }
            catch
            {
                // ігноруємо якщо не вдалось (не критично)
            }
        }

        private void SetupGridColumns()
        {
            dataGridViewBooks.Columns.Clear();

            var colNazva = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nazva",
                HeaderText = "Назва",
                Name = "colNazva",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };

            var colAvtor = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Avtor",
                HeaderText = "Автор",
                Name = "colAvtor",
                Width = 200,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            };

            var colISBN = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ISBN",
                HeaderText = "ISBN",
                Name = "colISBN",
                Width = 140,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            };

            dataGridViewBooks.Columns.AddRange(new DataGridViewColumn[] { colNazva, colAvtor, colISBN });
        }

        private void Catalogs_Load(object sender, EventArgs e)
        {
            // Старий підписник (залишаємо для сумісності)
            LoadBooksData();
        }

        private void Catalogs_Load_1(object sender, EventArgs e)
        {
            // Дизайнер підписав саме цей метод на подію Load
            LoadBooksData();
        }

        public void LoadBooksData()
        {
            try
            {
                // Завантажуємо список з файлу (відносний шлях до робочої директорії процесу)
                _books = BookDataService.LoadBooksFromTxt(BooksFileName) ?? new List<Book>();

                // Використовуємо поле _bindingList щоб зберегти прив'язки при рефреші
                if (_binding_list_is_null())
                {
                    _bindingList = new BindingList<Book>(_books);
                    _bindingSource.DataSource = _bindingList;
                }
                else
                {
                    _binding_list_refresh(_books);
                }

                // ГАРАНТОВАНИЙ рефреш UI — скинемо биндинги і перерисуємо грід
                try
                {
                    _bindingSource.ResetBindings(false);

                    // Автопідгонка колонок, щоб текст відображався відразу
                    dataGridViewBooks.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                    // Очищуємо вибір і змушуємо перерисувати грід
                    dataGridViewBooks.ClearSelection();
                    dataGridViewBooks.Refresh();
                    dataGridViewBooks.Invalidate();
                }
                catch
                {
                    // ігноруємо проблеми з перерисовкою, але вони малоймовірні
                }

                if (_books.Count > 0)
                {
                    _currentIndex = 0;
                    SelectRowInGrid(_currentIndex);
                    DisplayBookAtIndex(_currentIndex);
                }
                else
                {
                    _currentIndex = -1;
                    ClearBookDetails();
                }

                UpdateNavigationButtons();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при завантаженні книг: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Виніс оновлення _bindingList в окремий метод, щоб код чистіший
        private void _binding_list_refresh(List<Book> books)
        {
            _bindingList.RaiseListChangedEvents = false;
            _bindingList.Clear();
            foreach (var b in books)
            {
                _bindingList.Add(b);
            }
            _bindingList.RaiseListChangedEvents = true;
            _bindingSource.ResetBindings(false);
        }

        private bool _binding_list_is_null()
        {
            return _bindingList == null;
        }

        // Виконуємо додатковий гарантований рефреш коли форма стає видимою
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            // Виконуємо через BeginInvoke, щоб завершити поточний цикл подій і дозволити UI відмалюватись
            BeginInvoke((Action)(() =>
            {
                try
                {
                    // Якщо джерело є — оновити прив'язки і перерисувати
                    _bindingSource.ResetBindings(false);
                    dataGridViewBooks.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                    dataGridViewBooks.ClearSelection();
                    dataGridViewBooks.Refresh();
                    this.Refresh();
                }
                catch
                {
                    // ігноруємо помилки під час рефрешу
                }
            }));
        }

        private void DisplayBookAtIndex(int index)
        {
            if (index < 0 || _books == null || index >= _books.Count)
            {
                ClearBookDetails();
                return;
            }

            var book = _books[index];

            // Оновлюємо UI детального блоку — записуємо в текстбокси, якщо вони є на формі.
            // Імена контролів припущені стандартні: txtNazva, txtAvtor, txtGod, txtJanr, txtMova, txtAge, txtStrn, txtISBN
            SetTextBoxIfExists("txtNazva", book?.Nazva);
            SetTextBoxIfExists("txtAvtor", book?.Avtor);
            SetTextBoxIfExists("txtGod", book != null ? book.God.ToString() : string.Empty);
            SetTextBoxIfExists("txtJanr", book?.Janr);
            SetTextBoxIfExists("txtMova", book?.Mova);
            SetTextBoxIfExists("txtAge", book?.Age);
            SetTextBoxIfExists("txtStrn", book != null ? book.Strn.ToString() : string.Empty);
            SetTextBoxIfExists("txtISBN", book?.ISBN);

            // Якщо у вас інші імена полів — можна додати додаткові SetTextBoxIfExists виклики з цими іменами.

            UpdateNavigationButtons();
        }

        // Універсальна допоміжна функція: знайти TextBox по імені (рекурсивно) і заповнити текст
        private void SetTextBoxIfExists(string controlName, string text)
        {
            try
            {
                var found = this.Controls.Find(controlName, true);
                if (found != null && found.Length > 0 && found[0] is TextBox tb)
                {
                    tb.Text = text ?? string.Empty;
                }
            }
            catch
            {
                // ігноруємо помилки — відсутність контролу не критична
            }
        }
            
        private void ClearBookDetails()
        {
            // Очищуємо стандартні текстбокси, якщо вони є
            SetTextBoxIfExists("txtNazva", string.Empty);
            SetTextBoxIfExists("txtAvtor", string.Empty);
            SetTextBoxIfExists("txtGod", string.Empty);
            SetTextBoxIfExists("txtJanr", string.Empty);
            SetTextBoxIfExists("txtMova", string.Empty);
            SetTextBoxIfExists("txtAge", string.Empty);
            SetTextBoxIfExists("txtStrn", string.Empty);
            SetTextBoxIfExists("txtISBN", string.Empty);

            // Якщо потрібне скидання pictureBox1 до дефолтного зображення:
            try
            {
                var pics = this.Controls.Find("pictureBox1", true);
                if (pics != null && pics.Length > 0 && pics[0] is PictureBox pb)
                {
                    // Якщо у ресурсах є дефолтне зображення — можна встановити його:
                    // pb.BackgroundImage = Properties.Resources.Безымянный;
                }
            }
            catch
            {
                // ігноруємо
            }

            UpdateNavigationButtons();
        }

        private void UpdateNavigationButtons()
        {
            // Якщо в UI є кнопки навігації для книг, можна ввімкнути/вимкнути їх тут.
        }

        private void DataGridViewBooks_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewBooks.CurrentRow == null) return;
            var book = dataGridViewBooks.CurrentRow.DataBoundItem as Book;
            if (book == null) return;

            _currentIndex = _books.IndexOf(book);
            DisplayBookAtIndex(_currentIndex);
        }

        private void SelectRowInGrid(int index)
        {
            if (index < 0 || dataGridViewBooks.Rows.Count == 0) return;
            if (index >= dataGridViewBooks.Rows.Count) return;

            dataGridViewBooks.ClearSelection();
            dataGridViewBooks.Rows[index].Selected = true;
            // Встановимо CurrentCell, якщо колонок більше нуля
            if (dataGridViewBooks.Columns.Count > 0)
            {
                dataGridViewBooks.CurrentCell = dataGridViewBooks.Rows[index].Cells[0];
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            // У вашому дизайнері ця кнопка веде назад на головну — тому залишаємо існуючу поведінку
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // У дизайнері ця кнопка призначена для пошуку — залишаємо порожньою або реалізуємо навігацію за потреби
        }

        private void pbBookCover_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu frm1 = new Menu();
            this.Hide();
            frm1.Show();
        }

        // ---------- NEW: видалення вибраної книги з гриду і збереження у файл ----------
        // Припускаю, що саме ця подія викликається для кнопки "button2" (детальніше/видалити).
        private void button2_Click(object sender, EventArgs e)
        {
            // Перевіримо чи є вибрана строка
            if (dataGridViewBooks.CurrentRow == null)
            {
                MessageBox.Show("Нічого не вибрано для видалення.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Поточна книга
            var book = dataGridViewBooks.CurrentRow.DataBoundItem as Book;
            if (book == null)
            {
                MessageBox.Show("Не вдалося визначити вибрану книгу.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Підтвердження від користувача
            var result = MessageBox.Show($"Ви впевнені, що хочете видалити книгу:\n\"{book.Nazva}\" від {book.Avtor}?", "Підтвердження видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes) return;

            try
            {
                // Видаляємо з _bindingList (UI) і з _books (джерело для збереження)
                if (_bindingList != null && _bindingList.Contains(book))
                {
                    _bindingList.Remove(book);
                }

                if (_books != null && _books.Contains(book))
                {
                    _books.Remove(book);
                }

                // Зберігаємо оновлений список у файл
                try
                {
                    BookDataService.SaveBooksToTxt(_books ?? new List<Book>(), BooksFileName);
                }
                catch (Exception saveEx)
                {
                    MessageBox.Show($"Помилка збереження файлу: {saveEx.Message}", "Помилка збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Можна продовжити, але користувача повідомлено
                }

                // Оновимо UI: биндинги, список назв, виділення
                _bindingSource.ResetBindings(false);

                // Оновити listBox1 якщо він використовується для назв
                try
                {
                    listBox1.Items.Clear();
                    if (_books != null)
                    {
                        foreach (var b in _books)
                        {
                            listBox1.Items.Add(b.Nazva);
                        }
                    }
                }
                catch
                {
                    // ігноруємо, якщо listBox1 нема або інша помилка
                }

                // Визначимо новий індекс виділення
                if (_books != null && _books.Count > 0)
                {
                    _currentIndex = Math.Min(_currentIndex, _books.Count - 1);
                    SelectRowInGrid(_currentIndex);
                    DisplayBookAtIndex(_currentIndex);
                }
                else
                {
                    _currentIndex = -1;
                    ClearBookDetails();
                }

                MessageBox.Show("Книга успішно видалена.", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при видаленні: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // ---------------------------------------------------------------------------

        private void button2_Click_1(object sender, EventArgs e)
        {
            // Можна використовувати інший обробник, якщо Designer підключений до цього методу.
            // Покликаємо основний обробник, щоб поведінка була однаковою.
            button2_Click(sender, e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e, bool placeholder)
        {
            // Непотрібний перевантажений став на місці для уникнення помилок, не використовується.
        }

        private void txtShortDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNoInfo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Plus frm2 = new Plus();
            this.Hide();
            frm2.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e, int stub)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void YearBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {

        }

        private void dataGridViewBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
