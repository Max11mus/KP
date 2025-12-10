namespace KP
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.fileSystemWatcher2 = new System.IO.FileSystemWatcher();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.Label();
            this.autor = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.STAR1 = new System.Windows.Forms.Label();
            this.STAR2 = new System.Windows.Forms.Label();
            this.STAR3 = new System.Windows.Forms.Label();
            this.STAR4 = new System.Windows.Forms.Label();
            this.STAR5 = new System.Windows.Forms.Label();
            this.Rating = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button1.Location = new System.Drawing.Point(3, 216);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(176, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "➕ Додати книгу";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // fileSystemWatcher2
            // 
            this.fileSystemWatcher2.EnableRaisingEvents = true;
            this.fileSystemWatcher2.SynchronizingObject = this;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button2.Location = new System.Drawing.Point(3, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 70);
            this.button2.TabIndex = 4;
            this.button2.Text = "📚 Католог";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(87, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Автор  - ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Ivory;
            this.label2.Location = new System.Drawing.Point(84, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Рік        - ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label4.Location = new System.Drawing.Point(188, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(289, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "Пропозиція переглянути";
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.year.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.year.ForeColor = System.Drawing.Color.Ivory;
            this.year.Location = new System.Drawing.Point(183, 29);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(64, 25);
            this.year.TabIndex = 11;
            this.year.Text = "Автор";
            // 
            // autor
            // 
            this.autor.AutoSize = true;
            this.autor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.autor.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.autor.ForeColor = System.Drawing.Color.Ivory;
            this.autor.Location = new System.Drawing.Point(183, 3);
            this.autor.Name = "autor";
            this.autor.Size = new System.Drawing.Size(64, 25);
            this.autor.TabIndex = 12;
            this.autor.Text = "Автор";
            this.autor.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 572);
            this.panel1.TabIndex = 15;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button6.Location = new System.Drawing.Point(3, 110);
            this.button6.Name = "button6";
            this.button6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button6.Size = new System.Drawing.Size(176, 70);
            this.button6.TabIndex = 8;
            this.button6.Text = "Зареєструватися";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.PaleGreen;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.Color.DarkGreen;
            this.button5.Location = new System.Drawing.Point(3, 423);
            this.button5.Name = "button5";
            this.button5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button5.Size = new System.Drawing.Size(176, 70);
            this.button5.TabIndex = 7;
            this.button5.Text = "Допомога";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PaleGreen;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.DarkGreen;
            this.button3.Location = new System.Drawing.Point(3, 499);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button3.Size = new System.Drawing.Size(176, 70);
            this.button3.TabIndex = 6;
            this.button3.Text = "Довідка";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(3, 34);
            this.button4.Name = "button4";
            this.button4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button4.Size = new System.Drawing.Size(176, 70);
            this.button4.TabIndex = 5;
            this.button4.Text = "Закрити";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(162)))), ((int)(((byte)(148)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.autor);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.year);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(182, 516);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(432, 56);
            this.panel2.TabIndex = 16;
            // 
            // STAR1
            // 
            this.STAR1.AutoSize = true;
            this.STAR1.BackColor = System.Drawing.Color.LightYellow;
            this.STAR1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.STAR1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.STAR1.Location = new System.Drawing.Point(577, 309);
            this.STAR1.Name = "STAR1";
            this.STAR1.Size = new System.Drawing.Size(26, 25);
            this.STAR1.TabIndex = 17;
            this.STAR1.Text = "☆";
            this.STAR1.Click += new System.EventHandler(this.STAR1_Click);
            // 
            // STAR2
            // 
            this.STAR2.AutoSize = true;
            this.STAR2.BackColor = System.Drawing.Color.LightYellow;
            this.STAR2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.STAR2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.STAR2.Location = new System.Drawing.Point(577, 334);
            this.STAR2.Name = "STAR2";
            this.STAR2.Size = new System.Drawing.Size(26, 25);
            this.STAR2.TabIndex = 18;
            this.STAR2.Text = "☆";
            this.STAR2.Click += new System.EventHandler(this.STAR2_Click);
            // 
            // STAR3
            // 
            this.STAR3.AutoSize = true;
            this.STAR3.BackColor = System.Drawing.Color.LightYellow;
            this.STAR3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.STAR3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.STAR3.Location = new System.Drawing.Point(577, 359);
            this.STAR3.Name = "STAR3";
            this.STAR3.Size = new System.Drawing.Size(26, 25);
            this.STAR3.TabIndex = 19;
            this.STAR3.Text = "☆";
            this.STAR3.Click += new System.EventHandler(this.STAR3_Click);
            // 
            // STAR4
            // 
            this.STAR4.AutoSize = true;
            this.STAR4.BackColor = System.Drawing.Color.LightYellow;
            this.STAR4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.STAR4.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.STAR4.Location = new System.Drawing.Point(577, 384);
            this.STAR4.Name = "STAR4";
            this.STAR4.Size = new System.Drawing.Size(26, 25);
            this.STAR4.TabIndex = 20;
            this.STAR4.Text = "☆";
            this.STAR4.Click += new System.EventHandler(this.STAR4_Click);
            // 
            // STAR5
            // 
            this.STAR5.AutoSize = true;
            this.STAR5.BackColor = System.Drawing.Color.LightYellow;
            this.STAR5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.STAR5.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.STAR5.Location = new System.Drawing.Point(577, 409);
            this.STAR5.Name = "STAR5";
            this.STAR5.Size = new System.Drawing.Size(26, 25);
            this.STAR5.TabIndex = 21;
            this.STAR5.Text = "☆";
            this.STAR5.Click += new System.EventHandler(this.STAR5_Click);
            // 
            // Rating
            // 
            this.Rating.AutoSize = true;
            this.Rating.BackColor = System.Drawing.Color.LightYellow;
            this.Rating.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rating.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.Rating.Location = new System.Drawing.Point(577, 434);
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(28, 32);
            this.Rating.TabIndex = 22;
            this.Rating.Text = "R";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::KP.Properties.Resources.Безымянный;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(203, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(368, 432);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(614, 572);
            this.Controls.Add(this.Rating);
            this.Controls.Add(this.STAR5);
            this.Controls.Add(this.STAR4);
            this.Controls.Add(this.STAR3);
            this.Controls.Add(this.STAR2);
            this.Controls.Add(this.STAR1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.Text = "Головна сторінка";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button button2;
        private System.IO.FileSystemWatcher fileSystemWatcher2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label autor;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label STAR5;
        private System.Windows.Forms.Label STAR4;
        private System.Windows.Forms.Label STAR3;
        private System.Windows.Forms.Label STAR2;
        private System.Windows.Forms.Label STAR1;
        private System.Windows.Forms.Label Rating;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

