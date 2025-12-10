using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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

            // Налаштування DataGridView (один раз)
            dataGridViewBooks.AutoGenerateColumns = true;
            dataGridViewBooks.DataSource = _bindingSource;
            dataGridViewBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBooks.MultiSelect = false;
            dataGridViewBooks.ReadOnly = true;
            dataGridViewBooks.SelectionChanged += DataGridViewBooks_SelectionChanged;
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

                // Заповнюємо DataGridView через BindingList
                var bindList = new BindingList<Book>(_books);
                _bindingSource.DataSource = bindList;
                                
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

        private void DisplayBookAtIndex(int index)
        {
            if (index < 0 || _books == null || index >= _books.Count)
            {
                ClearBookDetails();
                return;
            }

            var book = _books[index];

            
            // Якщо є місця для деталізації (наприклад, groupBox1), можна тут оновити текст/зображення.
            // Залишимо лише оновлення зображення, якщо воно є.
            try
            {
                // Якщо у Book буде шлях до обкладинки, тут можна завантажити pictureBox1.Image.
                // Зараз нічого не змінюємо — залишаємо існуюче зображення за замовчуванням.
            }
            catch
            {
                // ігноруємо помилки при відображенні зображення
            }

            UpdateNavigationButtons();
        }

        private void ClearBookDetails()
        {
            // Якщо були текстові поля для деталей, очистіть їх тут.
            UpdateNavigationButtons();
        }

        private void UpdateNavigationButtons()
        {
            // Якщо в UI є кнопки навігації для книг, можна ввімкнути/вимкнути їх тут.
            // У вашому дизайні btnPrevious виконує перехід до головної, тому не чіпаємо його.
            // Приклад для кнопок Next/Prev якщо вони використовуються для навігації по списку:
            // btnNext.Enabled = _books != null && _currentIndex < _books.Count - 1;
            // btnPrevious.Enabled = _books != null && _currentIndex > 0;
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

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtShortDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
    }
}
