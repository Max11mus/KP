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
        public Catalogs()
        {
            InitializeComponent();
        }

        private void Catalogs_Load(object sender, EventArgs e)
        {
            LoadBooksData();
        }

        public void LoadBooksData()
        {

        }

        private void DisplayBookAtIndex(int index)
        {

        }
        private void ClearBookDetails()
        {

        }

        private void UpdateNavigationButtons()
        {

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

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

        private void Catalogs_Load_1(object sender, EventArgs e)
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
