namespace lab_3
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelErrorNewData = new System.Windows.Forms.Label();
            this.labelNewy = new System.Windows.Forms.Label();
            this.labelNewX = new System.Windows.Forms.Label();
            this.textBoxNewy = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBoxNewx = new System.Windows.Forms.TextBox();
            this.labelFCant = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonDeleteF = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.labelSaveError = new System.Windows.Forms.Label();
            this.labelSaveComplete = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(552, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Фигура пересекает границы полей";
            this.label1.Visible = false;
            // 
            // labelErrorNewData
            // 
            this.labelErrorNewData.AutoSize = true;
            this.labelErrorNewData.Location = new System.Drawing.Point(574, 450);
            this.labelErrorNewData.Name = "labelErrorNewData";
            this.labelErrorNewData.Size = new System.Drawing.Size(167, 16);
            this.labelErrorNewData.TabIndex = 23;
            this.labelErrorNewData.Text = "формат данных неверен";
            this.labelErrorNewData.Visible = false;
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
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(181, 61);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(61, 23);
            this.buttonOK.TabIndex = 9;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // textBoxNewx
            // 
            this.textBoxNewx.Location = new System.Drawing.Point(62, 39);
            this.textBoxNewx.Name = "textBoxNewx";
            this.textBoxNewx.Size = new System.Drawing.Size(100, 22);
            this.textBoxNewx.TabIndex = 0;
            // 
            // labelFCant
            // 
            this.labelFCant.AutoSize = true;
            this.labelFCant.Location = new System.Drawing.Point(568, 476);
            this.labelFCant.Name = "labelFCant";
            this.labelFCant.Size = new System.Drawing.Size(237, 16);
            this.labelFCant.TabIndex = 24;
            this.labelFCant.Text = "Фигура пересекает границы полей";
            this.labelFCant.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelNewy);
            this.groupBox1.Controls.Add(this.labelNewX);
            this.groupBox1.Controls.Add(this.textBoxNewy);
            this.groupBox1.Controls.Add(this.buttonOK);
            this.groupBox1.Controls.Add(this.textBoxNewx);
            this.groupBox1.Location = new System.Drawing.Point(567, 317);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 130);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите новые данные";
            this.groupBox1.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(661, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 52);
            this.button2.TabIndex = 21;
            this.button2.Text = "Подвинуть фигуру";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteF
            // 
            this.buttonDeleteF.BackColor = System.Drawing.Color.Red;
            this.buttonDeleteF.Location = new System.Drawing.Point(567, 199);
            this.buttonDeleteF.Name = "buttonDeleteF";
            this.buttonDeleteF.Size = new System.Drawing.Size(86, 43);
            this.buttonDeleteF.TabIndex = 20;
            this.buttonDeleteF.Text = "Удалить фигуру";
            this.buttonDeleteF.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(567, 157);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(222, 24);
            this.comboBox1.TabIndex = 19;
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Location = new System.Drawing.Point(13, 3);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(72, 40);
            this.buttonClearAll.TabIndex = 18;
            this.buttonClearAll.Text = "Очистить всё";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            // 
            // labelSaveError
            // 
            this.labelSaveError.AutoSize = true;
            this.labelSaveError.Location = new System.Drawing.Point(574, 113);
            this.labelSaveError.Name = "labelSaveError";
            this.labelSaveError.Size = new System.Drawing.Size(183, 16);
            this.labelSaveError.TabIndex = 17;
            this.labelSaveError.Text = "Фигура не была сохранена";
            this.labelSaveError.Visible = false;
            // 
            // labelSaveComplete
            // 
            this.labelSaveComplete.AutoSize = true;
            this.labelSaveComplete.Location = new System.Drawing.Point(568, 86);
            this.labelSaveComplete.Name = "labelSaveComplete";
            this.labelSaveComplete.Size = new System.Drawing.Size(187, 16);
            this.labelSaveComplete.TabIndex = 16;
            this.labelSaveComplete.Text = "Фигура успешно сохранена";
            this.labelSaveComplete.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(605, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 51);
            this.button1.TabIndex = 15;
            this.button1.Text = "Добавить фигуру";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(39, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(501, 378);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 501);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelErrorNewData);
            this.Controls.Add(this.labelFCant);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelErrorNewData;
        private System.Windows.Forms.Label labelNewy;
        private System.Windows.Forms.Label labelNewX;
        private System.Windows.Forms.TextBox textBoxNewy;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textBoxNewx;
        private System.Windows.Forms.Label labelFCant;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonDeleteF;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonClearAll;
        private System.Windows.Forms.Label labelSaveError;
        private System.Windows.Forms.Label labelSaveComplete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

