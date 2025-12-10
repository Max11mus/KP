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
            frm1.FormClosed += ChildForm_FormClosed;
            this.Hide();
            frm1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Catalogs frm2 = new Catalogs();
            frm2.FormClosed += ChildForm_FormClosed;
            this.Hide();
            frm2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Search frm3 = new Search();
            //frm3.FormClosed += ChildForm_FormClosed;
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
            frm4.FormClosed += ChildForm_FormClosed;
            this.Hide();
            frm4.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            About frm5 = new About();
            frm5.FormClosed += ChildForm_FormClosed;
            this.Hide();
            frm5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            About frm6 = new About();
            frm6.FormClosed += ChildForm_FormClosed;
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

        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Покажемо головну форму, якщо вона не знищується
            if (!this.IsDisposed && !this.Disposing)
            {
                this.Show();
                this.BringToFront();
                try
                {
                    this.Activate();
                }
                catch
                {
                    // Ignore if activation fails (rare on some OS states)
                }
            }
        }
    }
}
