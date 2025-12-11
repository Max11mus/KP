using System;
using System.Drawing;
using System.Windows.Forms;

namespace KP
{
    public class EditBookForm : Form
    {
        private TextBox txtNazva, txtAvtor, txtGod, txtJanr, txtMova, txtAge, txtStrn, txtISBN;
        private Button btnOk, btnCancel;

        public Book EditedBook { get; private set; }

        public EditBookForm(Book book)
        {
            this.Text = "Редагувати книгу";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.ClientSize = new Size(420, 360);
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Create controls
            const int leftLabel = 12;
            const int leftBox = 140;
            const int topStart = 12;
            const int vGap = 32;

            void AddLabel(string text, int top)
            {
                var lbl = new Label { Text = text, Location = new Point(leftLabel, top + 3), AutoSize = true };
                this.Controls.Add(lbl);
            }

            txtNazva = new TextBox { Location = new Point(leftBox, topStart), Width = 260 };
            AddLabel("Назва:", topStart);
            txtAvtor = new TextBox { Location = new Point(leftBox, topStart + vGap), Width = 260 };
            AddLabel("Автор:", topStart + vGap);
            txtGod = new TextBox { Location = new Point(leftBox, topStart + vGap * 2), Width = 260 };
            AddLabel("Рік:", topStart + vGap * 2);
            txtJanr = new TextBox { Location = new Point(leftBox, topStart + vGap * 3), Width = 260 };
            AddLabel("Жанр:", topStart + vGap * 3);
            txtMova = new TextBox { Location = new Point(leftBox, topStart + vGap * 4), Width = 260 };
            AddLabel("Мова:", topStart + vGap * 4);
            txtAge = new TextBox { Location = new Point(leftBox, topStart + vGap * 5), Width = 260 };
            AddLabel("Вікові обмеження:", topStart + vGap * 5);
            txtStrn = new TextBox { Location = new Point(leftBox, topStart + vGap * 6), Width = 260 };
            AddLabel("Кількість сторінок:", topStart + vGap * 6);
            txtISBN = new TextBox { Location = new Point(leftBox, topStart + vGap * 7), Width = 260 };
            AddLabel("ISBN:", topStart + vGap * 7);

            this.Controls.AddRange(new Control[] { txtNazva, txtAvtor, txtGod, txtJanr, txtMova, txtAge, txtStrn, txtISBN });

            btnOk = new Button { Text = "OK", DialogResult = DialogResult.OK, Location = new Point(220, 300), Width = 90 };
            btnCancel = new Button { Text = "Скасувати", DialogResult = DialogResult.Cancel, Location = new Point(320, 300), Width = 90 };
            this.Controls.AddRange(new Control[] { btnOk, btnCancel });

            this.AcceptButton = btnOk;
            this.CancelButton = btnCancel;

            // Initialize values from provided book (safety: allow null)
            if (book != null)
            {
                txtNazva.Text = book.Nazva;
                txtAvtor.Text = book.Avtor;
                txtGod.Text = book.God.ToString();
                txtJanr.Text = book.Janr;
                txtMova.Text = book.Mova;
                txtAge.Text = book.Age;
                txtStrn.Text = book.Strn.ToString();
                txtISBN.Text = book.ISBN;
            }

            btnOk.Click += BtnOk_Click;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            // Validate numeric fields
            if (!int.TryParse(txtGod.Text.Trim(), out int god))
            {
                MessageBox.Show("Рік має бути цілим числом.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.None;
                return;
            }

            if (!int.TryParse(txtStrn.Text.Trim(), out int pages))
            {
                MessageBox.Show("Кількість сторінок має бути цілим числом.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.None;
                return;
            }

            EditedBook = new Book
            {
                Nazva = txtNazva.Text.Trim(),
                Avtor = txtAvtor.Text.Trim(),
                God = god,
                Janr = txtJanr.Text.Trim(),
                Mova = txtMova.Text.Trim(),
                Age = txtAge.Text.Trim(),
                Strn = pages,
                ISBN = txtISBN.Text.Trim()
            };

            // Allow dialog to close with OK
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
