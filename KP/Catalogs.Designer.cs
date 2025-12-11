namespace KP
{
    partial class Catalogs
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
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ISBNBox = new System.Windows.Forms.TextBox();
            this.VikObmecgenya = new System.Windows.Forms.TextBox();
            this.MovaBox = new System.Windows.Forms.TextBox();
            this.JanrBox = new System.Windows.Forms.TextBox();
            this.AutorBox = new System.Windows.Forms.TextBox();
            this.KillkStorinok = new System.Windows.Forms.TextBox();
            this.YearBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtMova = new System.Windows.Forms.TextBox();
            this.txtJanr = new System.Windows.Forms.TextBox();
            this.txtAvtor = new System.Windows.Forms.TextBox();
            this.txtStrn = new System.Windows.Forms.TextBox();
            this.txtGod = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNazva = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Bisque;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPrevious.Location = new System.Drawing.Point(12, 12);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(137, 31);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.Text = "Головна";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Bisque;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNext.Location = new System.Drawing.Point(155, 12);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(137, 31);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Пошук";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Bisque;
            this.groupBox1.Controls.Add(this.ISBNBox);
            this.groupBox1.Controls.Add(this.VikObmecgenya);
            this.groupBox1.Controls.Add(this.MovaBox);
            this.groupBox1.Controls.Add(this.JanrBox);
            this.groupBox1.Controls.Add(this.AutorBox);
            this.groupBox1.Controls.Add(this.KillkStorinok);
            this.groupBox1.Controls.Add(this.YearBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.NameBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 332);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Філтьр";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ISBNBox
            // 
            this.ISBNBox.BackColor = System.Drawing.Color.Linen;
            this.ISBNBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ISBNBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ISBNBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ISBNBox.Location = new System.Drawing.Point(141, 298);
            this.ISBNBox.Name = "ISBNBox";
            this.ISBNBox.Size = new System.Drawing.Size(117, 22);
            this.ISBNBox.TabIndex = 45;
            // 
            // VikObmecgenya
            // 
            this.VikObmecgenya.BackColor = System.Drawing.Color.Linen;
            this.VikObmecgenya.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VikObmecgenya.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VikObmecgenya.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.VikObmecgenya.Location = new System.Drawing.Point(141, 216);
            this.VikObmecgenya.Name = "VikObmecgenya";
            this.VikObmecgenya.Size = new System.Drawing.Size(117, 22);
            this.VikObmecgenya.TabIndex = 44;
            // 
            // MovaBox
            // 
            this.MovaBox.BackColor = System.Drawing.Color.Linen;
            this.MovaBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MovaBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MovaBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.MovaBox.Location = new System.Drawing.Point(141, 169);
            this.MovaBox.Name = "MovaBox";
            this.MovaBox.Size = new System.Drawing.Size(117, 22);
            this.MovaBox.TabIndex = 43;
            // 
            // JanrBox
            // 
            this.JanrBox.BackColor = System.Drawing.Color.Linen;
            this.JanrBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.JanrBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.JanrBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.JanrBox.Location = new System.Drawing.Point(141, 132);
            this.JanrBox.Name = "JanrBox";
            this.JanrBox.Size = new System.Drawing.Size(117, 22);
            this.JanrBox.TabIndex = 42;
            // 
            // AutorBox
            // 
            this.AutorBox.BackColor = System.Drawing.Color.Linen;
            this.AutorBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AutorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AutorBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.AutorBox.Location = new System.Drawing.Point(141, 72);
            this.AutorBox.Name = "AutorBox";
            this.AutorBox.Size = new System.Drawing.Size(117, 22);
            this.AutorBox.TabIndex = 41;
            // 
            // KillkStorinok
            // 
            this.KillkStorinok.BackColor = System.Drawing.Color.Linen;
            this.KillkStorinok.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KillkStorinok.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KillkStorinok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.KillkStorinok.Location = new System.Drawing.Point(143, 263);
            this.KillkStorinok.Name = "KillkStorinok";
            this.KillkStorinok.Size = new System.Drawing.Size(117, 22);
            this.KillkStorinok.TabIndex = 40;
            // 
            // YearBox
            // 
            this.YearBox.BackColor = System.Drawing.Color.Linen;
            this.YearBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.YearBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YearBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.YearBox.Location = new System.Drawing.Point(141, 101);
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(117, 22);
            this.YearBox.TabIndex = 38;
            this.YearBox.TextChanged += new System.EventHandler(this.YearBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(14, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 25);
            this.label8.TabIndex = 34;
            this.label8.Text = "мова";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(16, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 50);
            this.label7.TabIndex = 33;
            this.label7.Text = "Кількість \r\nсторінок";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(14, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 50);
            this.label6.TabIndex = 32;
            this.label6.Text = "Вікові \r\nобмеження";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.Color.Linen;
            this.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.NameBox.Location = new System.Drawing.Point(141, 42);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(117, 22);
            this.NameBox.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(21, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 25);
            this.label5.TabIndex = 29;
            this.label5.Text = "ISBN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(14, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 28;
            this.label4.Text = "Жанр";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "Рік";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Автор / и";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(14, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 25);
            this.label9.TabIndex = 25;
            this.label9.Text = "Назва";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(486, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "КАТАЛОГ КНИГ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.NavajoWhite;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(18, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "Додати до каталогу";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewBooks.Location = new System.Drawing.Point(312, 41);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.ReadOnly = true;
            this.dataGridViewBooks.Size = new System.Drawing.Size(601, 117);
            this.dataGridViewBooks.TabIndex = 8;
            this.dataGridViewBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBooks_CellContentClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.NavajoWhite;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(18, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(267, 31);
            this.button2.TabIndex = 9;
            this.button2.Text = "Удалити з  каталогу";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Bisque;
            this.groupBox2.Controls.Add(this.txtISBN);
            this.groupBox2.Controls.Add(this.txtAge);
            this.groupBox2.Controls.Add(this.txtMova);
            this.groupBox2.Controls.Add(this.txtJanr);
            this.groupBox2.Controls.Add(this.txtAvtor);
            this.groupBox2.Controls.Add(this.txtStrn);
            this.groupBox2.Controls.Add(this.txtGod);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtNazva);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(312, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(601, 332);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Подробніше";
            // 
            // txtISBN
            // 
            this.txtISBN.BackColor = System.Drawing.Color.Linen;
            this.txtISBN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtISBN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtISBN.Location = new System.Drawing.Point(141, 298);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.ReadOnly = true;
            this.txtISBN.Size = new System.Drawing.Size(442, 22);
            this.txtISBN.TabIndex = 45;
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.Linen;
            this.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtAge.Location = new System.Drawing.Point(141, 216);
            this.txtAge.Name = "txtAge";
            this.txtAge.ReadOnly = true;
            this.txtAge.Size = new System.Drawing.Size(442, 22);
            this.txtAge.TabIndex = 44;
            // 
            // txtMova
            // 
            this.txtMova.BackColor = System.Drawing.Color.Linen;
            this.txtMova.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMova.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMova.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtMova.Location = new System.Drawing.Point(141, 169);
            this.txtMova.Name = "txtMova";
            this.txtMova.ReadOnly = true;
            this.txtMova.Size = new System.Drawing.Size(442, 22);
            this.txtMova.TabIndex = 43;
            this.txtMova.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtJanr
            // 
            this.txtJanr.BackColor = System.Drawing.Color.Linen;
            this.txtJanr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtJanr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtJanr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtJanr.Location = new System.Drawing.Point(141, 132);
            this.txtJanr.Name = "txtJanr";
            this.txtJanr.ReadOnly = true;
            this.txtJanr.Size = new System.Drawing.Size(442, 22);
            this.txtJanr.TabIndex = 42;
            this.txtJanr.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtAvtor
            // 
            this.txtAvtor.BackColor = System.Drawing.Color.Linen;
            this.txtAvtor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAvtor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAvtor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtAvtor.Location = new System.Drawing.Point(141, 72);
            this.txtAvtor.Name = "txtAvtor";
            this.txtAvtor.ReadOnly = true;
            this.txtAvtor.Size = new System.Drawing.Size(442, 22);
            this.txtAvtor.TabIndex = 41;
            // 
            // txtStrn
            // 
            this.txtStrn.BackColor = System.Drawing.Color.Linen;
            this.txtStrn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStrn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtStrn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtStrn.Location = new System.Drawing.Point(143, 263);
            this.txtStrn.Name = "txtStrn";
            this.txtStrn.ReadOnly = true;
            this.txtStrn.Size = new System.Drawing.Size(442, 22);
            this.txtStrn.TabIndex = 40;
            // 
            // txtGod
            // 
            this.txtGod.BackColor = System.Drawing.Color.Linen;
            this.txtGod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtGod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtGod.Location = new System.Drawing.Point(141, 101);
            this.txtGod.Name = "txtGod";
            this.txtGod.ReadOnly = true;
            this.txtGod.Size = new System.Drawing.Size(442, 22);
            this.txtGod.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(14, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 25);
            this.label10.TabIndex = 34;
            this.label10.Text = "мова";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(16, 249);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 50);
            this.label11.TabIndex = 33;
            this.label11.Text = "Кількість \r\nсторінок";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(14, 199);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 50);
            this.label12.TabIndex = 32;
            this.label12.Text = "Вікові \r\nобмеження";
            // 
            // txtNazva
            // 
            this.txtNazva.BackColor = System.Drawing.Color.Linen;
            this.txtNazva.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNazva.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNazva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtNazva.Location = new System.Drawing.Point(141, 42);
            this.txtNazva.Name = "txtNazva";
            this.txtNazva.ReadOnly = true;
            this.txtNazva.Size = new System.Drawing.Size(442, 22);
            this.txtNazva.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(21, 299);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 25);
            this.label13.TabIndex = 29;
            this.label13.Text = "ISBN";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(14, 131);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 25);
            this.label14.TabIndex = 28;
            this.label14.Text = "Жанр";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(14, 103);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 25);
            this.label15.TabIndex = 27;
            this.label15.Text = "Рік";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(14, 73);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 25);
            this.label16.TabIndex = 26;
            this.label16.Text = "Автор / и";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(14, 39);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 25);
            this.label17.TabIndex = 25;
            this.label17.Text = "Назва";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(18, 87);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(267, 34);
            this.button3.TabIndex = 11;
            this.button3.Text = "Редагувати книгу";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Catalogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(939, 734);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridViewBooks);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Name = "Catalogs";
            this.Text = "Каталог";
            this.Load += new System.EventHandler(this.Catalogs_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.TextBox KillkStorinok;
        private System.Windows.Forms.TextBox YearBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ISBNBox;
        private System.Windows.Forms.TextBox VikObmecgenya;
        private System.Windows.Forms.TextBox MovaBox;
        private System.Windows.Forms.TextBox JanrBox;
        private System.Windows.Forms.TextBox AutorBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtMova;
        private System.Windows.Forms.TextBox txtJanr;
        private System.Windows.Forms.TextBox txtAvtor;
        private System.Windows.Forms.TextBox txtStrn;
        private System.Windows.Forms.TextBox txtGod;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNazva;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button3;
    }
}