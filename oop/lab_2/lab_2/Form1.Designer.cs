namespace lab_2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelSaveComplete = new System.Windows.Forms.Label();
            this.labelSaveError = new System.Windows.Forms.Label();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonDeleteF = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelNewy = new System.Windows.Forms.Label();
            this.labelNewX = new System.Windows.Forms.Label();
            this.textBoxNewy = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBoxNewx = new System.Windows.Forms.TextBox();
            this.labelErrorNewData = new System.Windows.Forms.Label();
            this.labelFCant = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(45, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(550, 511);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(683, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить фигуру";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelSaveComplete
            // 
            this.labelSaveComplete.AutoSize = true;
            this.labelSaveComplete.Location = new System.Drawing.Point(662, 124);
            this.labelSaveComplete.Name = "labelSaveComplete";
            this.labelSaveComplete.Size = new System.Drawing.Size(187, 16);
            this.labelSaveComplete.TabIndex = 2;
            this.labelSaveComplete.Text = "Фигура успешно сохранена";
            this.labelSaveComplete.Visible = false;
            // 
            // labelSaveError
            // 
            this.labelSaveError.AutoSize = true;
            this.labelSaveError.Location = new System.Drawing.Point(662, 152);
            this.labelSaveError.Name = "labelSaveError";
            this.labelSaveError.Size = new System.Drawing.Size(183, 16);
            this.labelSaveError.TabIndex = 3;
            this.labelSaveError.Text = "Фигура не была сохранена";
            this.labelSaveError.Visible = false;
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Location = new System.Drawing.Point(12, -7);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(72, 40);
            this.buttonClearAll.TabIndex = 4;
            this.buttonClearAll.Text = "Очистить всё";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(641, 182);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(222, 24);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonDeleteF
            // 
            this.buttonDeleteF.BackColor = System.Drawing.Color.Red;
            this.buttonDeleteF.Location = new System.Drawing.Point(665, 221);
            this.buttonDeleteF.Name = "buttonDeleteF";
            this.buttonDeleteF.Size = new System.Drawing.Size(86, 43);
            this.buttonDeleteF.TabIndex = 6;
            this.buttonDeleteF.Text = "Удалить фигуру";
            this.buttonDeleteF.UseVisualStyleBackColor = false;
            this.buttonDeleteF.Click += new System.EventHandler(this.buttonDeleteF_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(757, 221);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 52);
            this.button2.TabIndex = 7;
            this.button2.Text = "Подвинуть фигуру";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelNewy);
            this.groupBox1.Controls.Add(this.labelNewX);
            this.groupBox1.Controls.Add(this.textBoxNewy);
            this.groupBox1.Controls.Add(this.buttonOK);
            this.groupBox1.Controls.Add(this.textBoxNewx);
            this.groupBox1.Location = new System.Drawing.Point(621, 307);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 130);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите новые данные";
            this.groupBox1.Visible = false;
            // 
            // labelNewy
            // 
            this.labelNewy.AutoSize = true;
            this.labelNewy.Location = new System.Drawing.Point(12, 85);
            this.labelNewy.Name = "labelNewy";
            this.labelNewy.Size = new System.Drawing.Size(27, 16);
            this.labelNewy.TabIndex = 3;
            this.labelNewy.Text = "y = ";
            // 
            // labelNewX
            // 
            this.labelNewX.AutoSize = true;
            this.labelNewX.Location = new System.Drawing.Point(7, 39);
            this.labelNewX.Name = "labelNewX";
            this.labelNewX.Size = new System.Drawing.Size(26, 16);
            this.labelNewX.TabIndex = 2;
            this.labelNewX.Text = "х = ";
            // 
            // textBoxNewy
            // 
            this.textBoxNewy.Location = new System.Drawing.Point(62, 80);
            this.textBoxNewy.Name = "textBoxNewy";
            this.textBoxNewy.Size = new System.Drawing.Size(100, 22);
            this.textBoxNewy.TabIndex = 1;
            this.textBoxNewy.TextChanged += new System.EventHandler(this.textBoxNewy_TextChanged);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(181, 61);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(61, 23);
            this.buttonOK.TabIndex = 9;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // textBoxNewx
            // 
            this.textBoxNewx.Location = new System.Drawing.Point(62, 39);
            this.textBoxNewx.Name = "textBoxNewx";
            this.textBoxNewx.Size = new System.Drawing.Size(100, 22);
            this.textBoxNewx.TabIndex = 0;
            this.textBoxNewx.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelErrorNewData
            // 
            this.labelErrorNewData.AutoSize = true;
            this.labelErrorNewData.Location = new System.Drawing.Point(686, 454);
            this.labelErrorNewData.Name = "labelErrorNewData";
            this.labelErrorNewData.Size = new System.Drawing.Size(167, 16);
            this.labelErrorNewData.TabIndex = 10;
            this.labelErrorNewData.Text = "формат данных неверен";
            this.labelErrorNewData.Visible = false;
            // 
            // labelFCant
            // 
            this.labelFCant.AutoSize = true;
            this.labelFCant.Location = new System.Drawing.Point(644, 480);
            this.labelFCant.Name = "labelFCant";
            this.labelFCant.Size = new System.Drawing.Size(237, 16);
            this.labelFCant.TabIndex = 11;
            this.labelFCant.Text = "Фигура пересекает границы полей";
            this.labelFCant.Visible = false;
            this.labelFCant.Click += new System.EventHandler(this.labelFCant_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 562);
            this.Controls.Add(this.labelFCant);
            this.Controls.Add(this.labelErrorNewData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonDeleteF);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonClearAll);
            this.Controls.Add(this.labelSaveError);
            this.Controls.Add(this.labelSaveComplete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelSaveComplete;
        private System.Windows.Forms.Label labelSaveError;
        private System.Windows.Forms.Button buttonClearAll;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonDeleteF;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxNewx;
        private System.Windows.Forms.Label labelNewy;
        private System.Windows.Forms.Label labelNewX;
        private System.Windows.Forms.TextBox textBoxNewy;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelErrorNewData;
        private System.Windows.Forms.Label labelFCant;
    }
}

