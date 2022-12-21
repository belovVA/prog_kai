namespace lab_2
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_Circle = new System.Windows.Forms.RadioButton();
            this.radioButton_Ellipse = new System.Windows.Forms.RadioButton();
            this.radioButton_Square = new System.Windows.Forms.RadioButton();
            this.radioButton_Rect = new System.Windows.Forms.RadioButton();
            this.groupBox_date = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_h = new System.Windows.Forms.TextBox();
            this.textBox_w = new System.Windows.Forms.TextBox();
            this.textBox_y = new System.Windows.Forms.TextBox();
            this.textBox_x = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.labelFCant = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox_date.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_Circle);
            this.groupBox1.Controls.Add(this.radioButton_Ellipse);
            this.groupBox1.Controls.Add(this.radioButton_Square);
            this.groupBox1.Controls.Add(this.radioButton_Rect);
            this.groupBox1.Location = new System.Drawing.Point(58, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 215);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите фигуру";
            // 
            // radioButton_Circle
            // 
            this.radioButton_Circle.AutoSize = true;
            this.radioButton_Circle.Location = new System.Drawing.Point(19, 149);
            this.radioButton_Circle.Name = "radioButton_Circle";
            this.radioButton_Circle.Size = new System.Drawing.Size(57, 20);
            this.radioButton_Circle.TabIndex = 3;
            this.radioButton_Circle.TabStop = true;
            this.radioButton_Circle.Text = "круг";
            this.radioButton_Circle.UseVisualStyleBackColor = true;
            this.radioButton_Circle.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // radioButton_Ellipse
            // 
            this.radioButton_Ellipse.AutoSize = true;
            this.radioButton_Ellipse.Location = new System.Drawing.Point(19, 113);
            this.radioButton_Ellipse.Name = "radioButton_Ellipse";
            this.radioButton_Ellipse.Size = new System.Drawing.Size(75, 20);
            this.radioButton_Ellipse.TabIndex = 2;
            this.radioButton_Ellipse.TabStop = true;
            this.radioButton_Ellipse.Text = "эллипс";
            this.radioButton_Ellipse.UseVisualStyleBackColor = true;
            this.radioButton_Ellipse.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // radioButton_Square
            // 
            this.radioButton_Square.AutoSize = true;
            this.radioButton_Square.Location = new System.Drawing.Point(19, 72);
            this.radioButton_Square.Name = "radioButton_Square";
            this.radioButton_Square.Size = new System.Drawing.Size(82, 20);
            this.radioButton_Square.TabIndex = 1;
            this.radioButton_Square.TabStop = true;
            this.radioButton_Square.Text = "квадрат";
            this.radioButton_Square.UseVisualStyleBackColor = true;
            this.radioButton_Square.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // radioButton_Rect
            // 
            this.radioButton_Rect.AutoSize = true;
            this.radioButton_Rect.Location = new System.Drawing.Point(19, 32);
            this.radioButton_Rect.Name = "radioButton_Rect";
            this.radioButton_Rect.Size = new System.Drawing.Size(128, 20);
            this.radioButton_Rect.TabIndex = 0;
            this.radioButton_Rect.TabStop = true;
            this.radioButton_Rect.Text = "прямоугольник";
            this.radioButton_Rect.UseVisualStyleBackColor = true;
            this.radioButton_Rect.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // groupBox_date
            // 
            this.groupBox_date.Controls.Add(this.label4);
            this.groupBox_date.Controls.Add(this.label3);
            this.groupBox_date.Controls.Add(this.label2);
            this.groupBox_date.Controls.Add(this.label1);
            this.groupBox_date.Controls.Add(this.textBox_h);
            this.groupBox_date.Controls.Add(this.textBox_w);
            this.groupBox_date.Controls.Add(this.textBox_y);
            this.groupBox_date.Controls.Add(this.textBox_x);
            this.groupBox_date.Location = new System.Drawing.Point(268, 87);
            this.groupBox_date.Name = "groupBox_date";
            this.groupBox_date.Size = new System.Drawing.Size(207, 192);
            this.groupBox_date.TabIndex = 5;
            this.groupBox_date.TabStop = false;
            this.groupBox_date.Text = "Введите данные";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Длина h";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ширина w";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Коорд y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Коорд x";
            // 
            // textBox_h
            // 
            this.textBox_h.Location = new System.Drawing.Point(83, 154);
            this.textBox_h.Name = "textBox_h";
            this.textBox_h.Size = new System.Drawing.Size(100, 22);
            this.textBox_h.TabIndex = 3;
            this.textBox_h.TextChanged += new System.EventHandler(this.textBox_h_TextChanged_1);
            // 
            // textBox_w
            // 
            this.textBox_w.Location = new System.Drawing.Point(83, 116);
            this.textBox_w.Name = "textBox_w";
            this.textBox_w.Size = new System.Drawing.Size(100, 22);
            this.textBox_w.TabIndex = 2;
            this.textBox_w.TextChanged += new System.EventHandler(this.textBox_w_TextChanged);
            // 
            // textBox_y
            // 
            this.textBox_y.Location = new System.Drawing.Point(83, 78);
            this.textBox_y.Name = "textBox_y";
            this.textBox_y.Size = new System.Drawing.Size(100, 22);
            this.textBox_y.TabIndex = 1;
            this.textBox_y.TextChanged += new System.EventHandler(this.textBox_y_TextChanged);
            // 
            // textBox_x
            // 
            this.textBox_x.Location = new System.Drawing.Point(83, 36);
            this.textBox_x.Name = "textBox_x";
            this.textBox_x.Size = new System.Drawing.Size(100, 22);
            this.textBox_x.TabIndex = 0;
            this.textBox_x.TextChanged += new System.EventHandler(this.textBox_x_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(521, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(359, 286);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(158, 16);
            this.labelError.TabIndex = 7;
            this.labelError.Text = "Форат данных неверен";
            this.labelError.Visible = false;
            // 
            // labelFCant
            // 
            this.labelFCant.AutoSize = true;
            this.labelFCant.Location = new System.Drawing.Point(304, 312);
            this.labelFCant.Name = "labelFCant";
            this.labelFCant.Size = new System.Drawing.Size(237, 16);
            this.labelFCant.TabIndex = 12;
            this.labelFCant.Text = "Фигура пересекает границы полей";
            this.labelFCant.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelFCant);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox_date);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Field";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_date.ResumeLayout(false);
            this.groupBox_date.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_Circle;
        private System.Windows.Forms.RadioButton radioButton_Ellipse;
        private System.Windows.Forms.RadioButton radioButton_Square;
        private System.Windows.Forms.RadioButton radioButton_Rect;
        private System.Windows.Forms.GroupBox groupBox_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_h;
        private System.Windows.Forms.TextBox textBox_w;
        private System.Windows.Forms.TextBox textBox_y;
        private System.Windows.Forms.TextBox textBox_x;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelFCant;
    }
}