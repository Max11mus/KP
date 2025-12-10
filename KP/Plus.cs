using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KP
{
    public partial class Plus : Form
    {
        public Plus()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu frm = new Menu();
            this.Close();
            frm.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox2.Text, out int god))
            {
                MessageBox.Show("Рік - лише ціле число", "Помилка !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(textBox3.Text, out int page))
            {
                MessageBox.Show("Кількість сторінок - лише ціле число", "Помилка !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Book newBook = new Book
            {
                Nazva = textBox1.Text,
                Avtor = comboBox1.Text,
                God = god,
                Janr = comboBox2.Text,
                Mova = comboBox3.Text,
                Age = comboBox4.Text,
                Strn = page,
                ISBN = comboBox5.Text
            };
            try
            {
                string fileName = "books.txt";

                List<Book> books = BookDataService.LoadBooksFromTxt(fileName);

                books.Add(newBook);

                BookDataService.SaveBooksToTxt(books, fileName);

                Catalogs frm2 = new Catalogs();
                this.Hide();
                frm2.Show();

                MessageBox.Show("Книгу збережено до каталогу та до books.txt!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            catch
            {
                MessageBox.Show($"Сбротуйте ще раз.", "Помилка збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Clear()
        {
            textBox1.Text = "";
            comboBox1.Text = "";
            textBox2.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            textBox3.Text = "";
            comboBox5.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Catalogs frm2 = new Catalogs();
            this.Hide();
            frm2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Search frm3 = new Search();
            //this.Hide();
            //frm3.Show();
        }

        private void Plus_Load(object sender, EventArgs e)
        {

        }
    }
}
