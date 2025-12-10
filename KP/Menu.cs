using Ivavaan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KP
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

            // Wire FormClosing so clicking the window "X" terminates the application.
            this.FormClosing += Menu_FormClosing;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Plus frm1 = new Plus();
            this.Hide();
            frm1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Catalogs frm2 = new Catalogs();
            this.Hide();
            frm2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Search frm3 = new Search();
            //this.Hide();
            //frm3.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void STAR1_Click(object sender, EventArgs e)
        {

        }

        private void STAR2_Click(object sender, EventArgs e)
        {

        }

        private void STAR3_Click(object sender, EventArgs e)
        {

        }

        private void STAR4_Click(object sender, EventArgs e)
        {

        }

        private void STAR5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Help frm4 = new Help();
            this.Hide();
            frm4.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            About frm5 = new About();
            this.Hide();
            frm5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            About frm6 = new About();
            this.Hide();
            frm6.Show();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            // If the user clicked the window close button, request application shutdown.
            // This ensures the whole process terminates even if other forms were shown/hidden.
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

    }
}
