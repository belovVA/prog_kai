namespace lab_1
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            this.closeButton = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.label_count = new System.Windows.Forms.Label();
            this.label_numb = new System.Windows.Forms.Label();
            this.label_cost = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_cost = new System.Windows.Forms.TextBox();
            this.textBox_count = new System.Windows.Forms.TextBox();
            this.groupBox_create = new System.Windows.Forms.GroupBox();
            this.labelErrorDate = new System.Windows.Forms.Label();
            this.textBox_numb = new System.Windows.Forms.MaskedTextBox();
            this.labelErrorName = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_date = new System.Windows.Forms.MaskedTextBox();
            this.labelErrorNumb = new System.Windows.Forms.Label();
            this.labelErrorCount = new System.Windows.Forms.Label();
            this.labelErrorCost = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.labelErrorDid = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelErrorNewcount = new System.Windows.Forms.Label();
            this.labelErrorNewcost = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxNewcount = new System.Windows.Forms.TextBox();
            this.textBoxNewcost = new System.Windows.Forms.TextBox();
            this.labelNewcount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxnamed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelNotFound = new System.Windows.Forms.Label();
            this.buttonAll = new System.Windows.Forms.Button();
            this.textBox_nameall = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelErrorNotFaunded = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxall = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxk = new System.Windows.Forms.TextBox();
            this.textBoxc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelCreated = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelErrorCreate = new System.Windows.Forms.Label();
            this.labelEditedComplited = new System.Windows.Forms.Label();
            this.groupBox_create.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.DarkRed;
            this.closeButton.Location = new System.Drawing.Point(1099, 9);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(23, 25);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "x";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(6, 44);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(156, 16);
            this.label_name.TabIndex = 2;
            this.label_name.Text = "Наименование товара";
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Location = new System.Drawing.Point(6, 83);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(125, 16);
            this.label_date.TabIndex = 3;
            this.label_date.Text = "Дата оформления";
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.Location = new System.Drawing.Point(6, 166);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(101, 16);
            this.label_count.TabIndex = 4;
            this.label_count.Text = "Кол-во товара";
            // 
            // label_numb
            // 
            this.label_numb.AutoSize = true;
            this.label_numb.Location = new System.Drawing.Point(7, 224);
            this.label_numb.Name = "label_numb";
            this.label_numb.Size = new System.Drawing.Size(124, 16);
            this.label_numb.TabIndex = 5;
            this.label_numb.Text = "Номер накладной";
            // 
            // label_cost
            // 
            this.label_cost.AutoSize = true;
            this.label_cost.Location = new System.Drawing.Point(6, 116);
            this.label_cost.Name = "label_cost";
            this.label_cost.Size = new System.Drawing.Size(141, 16);
            this.label_cost.TabIndex = 6;
            this.label_cost.Text = "Цена за 1 ед. товара";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(219, 38);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 22);
            this.textBox_name.TabIndex = 7;
            this.textBox_name.TextChanged += new System.EventHandler(this.textBox_name_TextChanged);
            // 
            // textBox_cost
            // 
            this.textBox_cost.Location = new System.Drawing.Point(219, 116);
            this.textBox_cost.Name = "textBox_cost";
            this.textBox_cost.Size = new System.Drawing.Size(100, 22);
            this.textBox_cost.TabIndex = 9;
            this.textBox_cost.TextChanged += new System.EventHandler(this.textBox_cost_TextChanged);
            // 
            // textBox_count
            // 
            this.textBox_count.Location = new System.Drawing.Point(219, 163);
            this.textBox_count.Name = "textBox_count";
            this.textBox_count.Size = new System.Drawing.Size(100, 22);
            this.textBox_count.TabIndex = 10;
            this.textBox_count.TextChanged += new System.EventHandler(this.textBox_count_TextChanged);
            // 
            // groupBox_create
            // 
            this.groupBox_create.Controls.Add(this.labelErrorDate);
            this.groupBox_create.Controls.Add(this.textBox_numb);
            this.groupBox_create.Controls.Add(this.labelErrorName);
            this.groupBox_create.Controls.Add(this.label11);
            this.groupBox_create.Controls.Add(this.label10);
            this.groupBox_create.Controls.Add(this.textBox_date);
            this.groupBox_create.Controls.Add(this.labelErrorNumb);
            this.groupBox_create.Controls.Add(this.labelErrorCount);
            this.groupBox_create.Controls.Add(this.labelErrorCost);
            this.groupBox_create.Controls.Add(this.label_name);
            this.groupBox_create.Controls.Add(this.label_date);
            this.groupBox_create.Controls.Add(this.textBox_count);
            this.groupBox_create.Controls.Add(this.label_cost);
            this.groupBox_create.Controls.Add(this.textBox_cost);
            this.groupBox_create.Controls.Add(this.label_count);
            this.groupBox_create.Controls.Add(this.label_numb);
            this.groupBox_create.Controls.Add(this.textBox_name);
            this.groupBox_create.Location = new System.Drawing.Point(12, 72);
            this.groupBox_create.Name = "groupBox_create";
            this.groupBox_create.Size = new System.Drawing.Size(354, 279);
            this.groupBox_create.TabIndex = 12;
            this.groupBox_create.TabStop = false;
            this.groupBox_create.Text = "Добавить товар";
            // 
            // labelErrorDate
            // 
            this.labelErrorDate.AutoSize = true;
            this.labelErrorDate.BackColor = System.Drawing.Color.DarkRed;
            this.labelErrorDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelErrorDate.Location = new System.Drawing.Point(92, 100);
            this.labelErrorDate.Name = "labelErrorDate";
            this.labelErrorDate.Size = new System.Drawing.Size(157, 16);
            this.labelErrorDate.TabIndex = 22;
            this.labelErrorDate.Text = "Неверно указана дата";
            this.labelErrorDate.Visible = false;
            // 
            // textBox_numb
            // 
            this.textBox_numb.Location = new System.Drawing.Point(219, 221);
            this.textBox_numb.Mask = "0000";
            this.textBox_numb.Name = "textBox_numb";
            this.textBox_numb.Size = new System.Drawing.Size(100, 22);
            this.textBox_numb.TabIndex = 21;
            // 
            // labelErrorName
            // 
            this.labelErrorName.AutoSize = true;
            this.labelErrorName.BackColor = System.Drawing.Color.DarkRed;
            this.labelErrorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelErrorName.Location = new System.Drawing.Point(92, 63);
            this.labelErrorName.Name = "labelErrorName";
            this.labelErrorName.Size = new System.Drawing.Size(189, 16);
            this.labelErrorName.TabIndex = 20;
            this.labelErrorName.Text = "Имя не должно быть пустым";
            this.labelErrorName.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label11.Location = new System.Drawing.Point(9, 244);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 16);
            this.label11.TabIndex = 19;
            this.label11.Text = "(Пример ввода: 3774)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label10.Location = new System.Drawing.Point(7, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "(Пример ввода: 27,44)";
            // 
            // textBox_date
            // 
            this.textBox_date.Location = new System.Drawing.Point(219, 80);
            this.textBox_date.Mask = "00/00/0000";
            this.textBox_date.Name = "textBox_date";
            this.textBox_date.Size = new System.Drawing.Size(100, 22);
            this.textBox_date.TabIndex = 15;
            this.textBox_date.ValidatingType = typeof(System.DateTime);
            this.textBox_date.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.textBox_date_MaskInputRejected);
            // 
            // labelErrorNumb
            // 
            this.labelErrorNumb.AutoSize = true;
            this.labelErrorNumb.BackColor = System.Drawing.Color.DarkRed;
            this.labelErrorNumb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelErrorNumb.Location = new System.Drawing.Point(54, 260);
            this.labelErrorNumb.Name = "labelErrorNumb";
            this.labelErrorNumb.Size = new System.Drawing.Size(212, 16);
            this.labelErrorNumb.TabIndex = 14;
            this.labelErrorNumb.Text = "Номер не соответствует маске";
            this.labelErrorNumb.Visible = false;
            // 
            // labelErrorCount
            // 
            this.labelErrorCount.AutoSize = true;
            this.labelErrorCount.BackColor = System.Drawing.Color.DarkRed;
            this.labelErrorCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelErrorCount.Location = new System.Drawing.Point(17, 188);
            this.labelErrorCount.Name = "labelErrorCount";
            this.labelErrorCount.Size = new System.Drawing.Size(288, 16);
            this.labelErrorCount.TabIndex = 13;
            this.labelErrorCount.Text = "Кол-во должно быть целым и быть больше 0";
            this.labelErrorCount.Visible = false;
            // 
            // labelErrorCost
            // 
            this.labelErrorCost.AutoSize = true;
            this.labelErrorCost.BackColor = System.Drawing.Color.DarkRed;
            this.labelErrorCost.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelErrorCost.Location = new System.Drawing.Point(159, 144);
            this.labelErrorCost.Name = "labelErrorCost";
            this.labelErrorCost.Size = new System.Drawing.Size(187, 16);
            this.labelErrorCost.TabIndex = 12;
            this.labelErrorCost.Text = "Цена должна быть больше 0";
            this.labelErrorCost.Visible = false;
            // 
            // buttonCreate
            // 
            this.buttonCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreate.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCreate.Location = new System.Drawing.Point(99, 375);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(103, 61);
            this.buttonCreate.TabIndex = 12;
            this.buttonCreate.Text = "Добавить товар";
            this.buttonCreate.UseVisualStyleBackColor = false;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // labelErrorDid
            // 
            this.labelErrorDid.AutoSize = true;
            this.labelErrorDid.BackColor = System.Drawing.Color.DarkRed;
            this.labelErrorDid.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelErrorDid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelErrorDid.Location = new System.Drawing.Point(65, 438);
            this.labelErrorDid.Name = "labelErrorDid";
            this.labelErrorDid.Size = new System.Drawing.Size(163, 19);
            this.labelErrorDid.TabIndex = 14;
            this.labelErrorDid.Text = "Товар уже существует";
            this.labelErrorDid.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(519, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 55);
            this.button1.TabIndex = 15;
            this.button1.Text = "Изменить данные товара";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelErrorNewcount);
            this.groupBox1.Controls.Add(this.labelErrorNewcost);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.textBoxNewcount);
            this.groupBox1.Controls.Add(this.textBoxNewcost);
            this.groupBox1.Controls.Add(this.labelNewcount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxnamed);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(437, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 260);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите данные";
            // 
            // labelErrorNewcount
            // 
            this.labelErrorNewcount.AutoSize = true;
            this.labelErrorNewcount.BackColor = System.Drawing.Color.DarkRed;
            this.labelErrorNewcount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelErrorNewcount.Location = new System.Drawing.Point(11, 203);
            this.labelErrorNewcount.Name = "labelErrorNewcount";
            this.labelErrorNewcount.Size = new System.Drawing.Size(288, 16);
            this.labelErrorNewcount.TabIndex = 23;
            this.labelErrorNewcount.Text = "Кол-во должно быть целым и быть больше 0";
            this.labelErrorNewcount.Visible = false;
            // 
            // labelErrorNewcost
            // 
            this.labelErrorNewcost.AutoSize = true;
            this.labelErrorNewcost.BackColor = System.Drawing.Color.DarkRed;
            this.labelErrorNewcost.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelErrorNewcost.Location = new System.Drawing.Point(96, 122);
            this.labelErrorNewcost.Name = "labelErrorNewcost";
            this.labelErrorNewcost.Size = new System.Drawing.Size(187, 16);
            this.labelErrorNewcost.TabIndex = 19;
            this.labelErrorNewcost.Text = "Цена должна быть больше 0";
            this.labelErrorNewcost.Visible = false;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label9.Location = new System.Drawing.Point(18, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(262, 50);
            this.label9.TabIndex = 18;
            this.label9.Text = "Оставьте поле пустым,если не хотите вносить изменения";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label14.Location = new System.Drawing.Point(21, 196);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(262, 50);
            this.label14.TabIndex = 17;
            this.label14.Text = "Оставьте поле пустым,если не хотите вносить изменения";
            // 
            // textBoxNewcount
            // 
            this.textBoxNewcount.Location = new System.Drawing.Point(183, 166);
            this.textBoxNewcount.Name = "textBoxNewcount";
            this.textBoxNewcount.Size = new System.Drawing.Size(100, 22);
            this.textBoxNewcount.TabIndex = 12;
            this.textBoxNewcount.TextChanged += new System.EventHandler(this.textBoxNewcount_TextChanged);
            // 
            // textBoxNewcost
            // 
            this.textBoxNewcost.Location = new System.Drawing.Point(180, 82);
            this.textBoxNewcost.Name = "textBoxNewcost";
            this.textBoxNewcost.Size = new System.Drawing.Size(100, 22);
            this.textBoxNewcost.TabIndex = 11;
            this.textBoxNewcost.TextChanged += new System.EventHandler(this.textBoxNewcost_TextChanged);
            // 
            // labelNewcount
            // 
            this.labelNewcount.AutoSize = true;
            this.labelNewcount.Location = new System.Drawing.Point(18, 166);
            this.labelNewcount.Name = "labelNewcount";
            this.labelNewcount.Size = new System.Drawing.Size(145, 16);
            this.labelNewcount.TabIndex = 10;
            this.labelNewcount.Text = "Новое кол-во товара";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Новая цена товара";
            // 
            // textBoxnamed
            // 
            this.textBoxnamed.Location = new System.Drawing.Point(180, 34);
            this.textBoxnamed.Name = "textBoxnamed";
            this.textBoxnamed.Size = new System.Drawing.Size(100, 22);
            this.textBoxnamed.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Наименование товара";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelNotFound);
            this.groupBox2.Controls.Add(this.buttonAll);
            this.groupBox2.Controls.Add(this.textBox_nameall);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(851, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 182);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вычислить стоимость товара";
            // 
            // labelNotFound
            // 
            this.labelNotFound.AutoSize = true;
            this.labelNotFound.BackColor = System.Drawing.Color.DarkRed;
            this.labelNotFound.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNotFound.Location = new System.Drawing.Point(38, 147);
            this.labelNotFound.Name = "labelNotFound";
            this.labelNotFound.Size = new System.Drawing.Size(118, 16);
            this.labelNotFound.TabIndex = 11;
            this.labelNotFound.Text = "Товар не найден";
            this.labelNotFound.Visible = false;
            // 
            // buttonAll
            // 
            this.buttonAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonAll.Location = new System.Drawing.Point(61, 115);
            this.buttonAll.Name = "buttonAll";
            this.buttonAll.Size = new System.Drawing.Size(108, 29);
            this.buttonAll.TabIndex = 10;
            this.buttonAll.Text = "вычислить";
            this.buttonAll.UseVisualStyleBackColor = false;
            this.buttonAll.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_nameall
            // 
            this.textBox_nameall.Location = new System.Drawing.Point(41, 48);
            this.textBox_nameall.Name = "textBox_nameall";
            this.textBox_nameall.Size = new System.Drawing.Size(100, 22);
            this.textBox_nameall.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Наименование товара";
            // 
            // labelErrorNotFaunded
            // 
            this.labelErrorNotFaunded.AutoSize = true;
            this.labelErrorNotFaunded.BackColor = System.Drawing.Color.DarkRed;
            this.labelErrorNotFaunded.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelErrorNotFaunded.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelErrorNotFaunded.Location = new System.Drawing.Point(503, 396);
            this.labelErrorNotFaunded.Name = "labelErrorNotFaunded";
            this.labelErrorNotFaunded.Size = new System.Drawing.Size(128, 19);
            this.labelErrorNotFaunded.TabIndex = 18;
            this.labelErrorNotFaunded.Text = "Товар не найден";
            this.labelErrorNotFaunded.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxall);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBoxk);
            this.groupBox3.Controls.Add(this.textBoxc);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBoxn);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(783, 275);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(299, 182);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Visible = false;
            // 
            // textBoxall
            // 
            this.textBoxall.Location = new System.Drawing.Point(180, 137);
            this.textBoxall.Name = "textBoxall";
            this.textBoxall.ReadOnly = true;
            this.textBoxall.Size = new System.Drawing.Size(100, 22);
            this.textBoxall.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Общая стоимость";
            // 
            // textBoxk
            // 
            this.textBoxk.Location = new System.Drawing.Point(180, 100);
            this.textBoxk.Name = "textBoxk";
            this.textBoxk.ReadOnly = true;
            this.textBoxk.Size = new System.Drawing.Size(100, 22);
            this.textBoxk.TabIndex = 12;
            // 
            // textBoxc
            // 
            this.textBoxc.Location = new System.Drawing.Point(180, 62);
            this.textBoxc.Name = "textBoxc";
            this.textBoxc.ReadOnly = true;
            this.textBoxc.Size = new System.Drawing.Size(100, 22);
            this.textBoxc.TabIndex = 11;
            this.textBoxc.TextChanged += new System.EventHandler(this.textBoxc_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "кол-во товара";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "цена за 1 ед.";
            // 
            // textBoxn
            // 
            this.textBoxn.Location = new System.Drawing.Point(180, 21);
            this.textBoxn.Name = "textBoxn";
            this.textBoxn.ReadOnly = true;
            this.textBoxn.Size = new System.Drawing.Size(100, 22);
            this.textBoxn.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Наименование товара";
            // 
            // labelCreated
            // 
            this.labelCreated.BackColor = System.Drawing.Color.Lime;
            this.labelCreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCreated.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCreated.Location = new System.Drawing.Point(258, 375);
            this.labelCreated.Name = "labelCreated";
            this.labelCreated.Size = new System.Drawing.Size(100, 50);
            this.labelCreated.TabIndex = 20;
            this.labelCreated.Text = "Товар Успешно добавлен";
            this.labelCreated.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCreated.Visible = false;
            // 
            // labelErrorCreate
            // 
            this.labelErrorCreate.AutoSize = true;
            this.labelErrorCreate.BackColor = System.Drawing.Color.DarkRed;
            this.labelErrorCreate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelErrorCreate.Location = new System.Drawing.Point(231, 352);
            this.labelErrorCreate.Name = "labelErrorCreate";
            this.labelErrorCreate.Size = new System.Drawing.Size(217, 16);
            this.labelErrorCreate.TabIndex = 21;
            this.labelErrorCreate.Text = "Проверьте правильность ввода";
            this.labelErrorCreate.Visible = false;
            // 
            // labelEditedComplited
            // 
            this.labelEditedComplited.BackColor = System.Drawing.Color.Lime;
            this.labelEditedComplited.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEditedComplited.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelEditedComplited.Location = new System.Drawing.Point(659, 335);
            this.labelEditedComplited.Name = "labelEditedComplited";
            this.labelEditedComplited.Size = new System.Drawing.Size(100, 50);
            this.labelEditedComplited.TabIndex = 22;
            this.labelEditedComplited.Text = "Товар Успешно изменен";
            this.labelEditedComplited.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelEditedComplited.Visible = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1134, 480);
            this.Controls.Add(this.labelEditedComplited);
            this.Controls.Add(this.labelErrorCreate);
            this.Controls.Add(this.labelCreated);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.labelErrorNotFaunded);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelErrorDid);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.groupBox_create);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox_create.ResumeLayout(false);
            this.groupBox_create.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_count;
        private System.Windows.Forms.Label label_numb;
        private System.Windows.Forms.Label label_cost;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_cost;
        private System.Windows.Forms.TextBox textBox_count;
        private System.Windows.Forms.GroupBox groupBox_create;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Label labelErrorDid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxNewcount;
        private System.Windows.Forms.TextBox textBoxNewcost;
        private System.Windows.Forms.Label labelNewcount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxnamed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonAll;
        private System.Windows.Forms.TextBox textBox_nameall;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelErrorNotFaunded;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxall;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxk;
        private System.Windows.Forms.TextBox textBoxc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelErrorCost;
        private System.Windows.Forms.Label labelErrorNumb;
        private System.Windows.Forms.Label labelErrorCount;
        private System.Windows.Forms.MaskedTextBox textBox_date;
        private System.Windows.Forms.Label labelCreated;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelErrorName;
        private System.Windows.Forms.Label labelErrorCreate;
        private System.Windows.Forms.MaskedTextBox textBox_numb;
        private System.Windows.Forms.Label labelErrorDate;
        private System.Windows.Forms.Label labelErrorNewcount;
        private System.Windows.Forms.Label labelErrorNewcost;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelEditedComplited;
        private System.Windows.Forms.Label labelNotFound;
    }
}