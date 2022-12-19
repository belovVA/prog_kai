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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_chel = new System.Windows.Forms.RadioButton();
            this.radioButton_Line = new System.Windows.Forms.RadioButton();
            this.radioButton_Triangle = new System.Windows.Forms.RadioButton();
            this.radioButton_Polygon = new System.Windows.Forms.RadioButton();
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
            this.groupBox_poygonDate = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_n = new System.Windows.Forms.Button();
            this.textBox_n = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.groupBox_chel = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox_date.SuspendLayout();
            this.groupBox_poygonDate.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox_chel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_chel);
            this.groupBox1.Controls.Add(this.radioButton_Line);
            this.groupBox1.Controls.Add(this.radioButton_Triangle);
            this.groupBox1.Controls.Add(this.radioButton_Polygon);
            this.groupBox1.Controls.Add(this.radioButton_Circle);
            this.groupBox1.Controls.Add(this.radioButton_Ellipse);
            this.groupBox1.Controls.Add(this.radioButton_Square);
            this.groupBox1.Controls.Add(this.radioButton_Rect);
            this.groupBox1.Location = new System.Drawing.Point(58, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 296);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите фигуру";
            // 
            // radioButton_chel
            // 
            this.radioButton_chel.AutoSize = true;
            this.radioButton_chel.Location = new System.Drawing.Point(19, 272);
            this.radioButton_chel.Name = "radioButton_chel";
            this.radioButton_chel.Size = new System.Drawing.Size(83, 20);
            this.radioButton_chel.TabIndex = 7;
            this.radioButton_chel.TabStop = true;
            this.radioButton_chel.Text = "человек";
            this.radioButton_chel.UseVisualStyleBackColor = true;
            this.radioButton_chel.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // radioButton_Line
            // 
            this.radioButton_Line.AutoSize = true;
            this.radioButton_Line.Location = new System.Drawing.Point(19, 243);
            this.radioButton_Line.Name = "radioButton_Line";
            this.radioButton_Line.Size = new System.Drawing.Size(67, 20);
            this.radioButton_Line.TabIndex = 6;
            this.radioButton_Line.TabStop = true;
            this.radioButton_Line.Text = "линия";
            this.radioButton_Line.UseVisualStyleBackColor = true;
            this.radioButton_Line.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // radioButton_Triangle
            // 
            this.radioButton_Triangle.AutoSize = true;
            this.radioButton_Triangle.Location = new System.Drawing.Point(19, 216);
            this.radioButton_Triangle.Name = "radioButton_Triangle";
            this.radioButton_Triangle.Size = new System.Drawing.Size(111, 20);
            this.radioButton_Triangle.TabIndex = 5;
            this.radioButton_Triangle.TabStop = true;
            this.radioButton_Triangle.Text = "треугольник";
            this.radioButton_Triangle.UseVisualStyleBackColor = true;
            this.radioButton_Triangle.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // radioButton_Polygon
            // 
            this.radioButton_Polygon.AutoSize = true;
            this.radioButton_Polygon.Location = new System.Drawing.Point(19, 184);
            this.radioButton_Polygon.Name = "radioButton_Polygon";
            this.radioButton_Polygon.Size = new System.Drawing.Size(127, 20);
            this.radioButton_Polygon.TabIndex = 4;
            this.radioButton_Polygon.TabStop = true;
            this.radioButton_Polygon.Text = "многоугольник";
            this.radioButton_Polygon.UseVisualStyleBackColor = true;
            this.radioButton_Polygon.CheckedChanged += new System.EventHandler(this.CheckedChanged);
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
            this.groupBox_date.Location = new System.Drawing.Point(256, 110);
            this.groupBox_date.Name = "groupBox_date";
            this.groupBox_date.Size = new System.Drawing.Size(216, 204);
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
            this.button1.Location = new System.Drawing.Point(578, 189);
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
            this.labelError.Location = new System.Drawing.Point(360, 312);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(158, 16);
            this.labelError.TabIndex = 7;
            this.labelError.Text = "Форат данных неверен";
            this.labelError.Visible = false;
            // 
            // labelFCant
            // 
            this.labelFCant.AutoSize = true;
            this.labelFCant.Location = new System.Drawing.Point(303, 328);
            this.labelFCant.Name = "labelFCant";
            this.labelFCant.Size = new System.Drawing.Size(237, 16);
            this.labelFCant.TabIndex = 12;
            this.labelFCant.Text = "Фигура пересекает границы полей";
            this.labelFCant.Visible = false;
            // 
            // groupBox_poygonDate
            // 
            this.groupBox_poygonDate.Controls.Add(this.groupBox2);
            this.groupBox_poygonDate.Controls.Add(this.button_n);
            this.groupBox_poygonDate.Controls.Add(this.textBox_n);
            this.groupBox_poygonDate.Controls.Add(this.label5);
            this.groupBox_poygonDate.Location = new System.Drawing.Point(256, 110);
            this.groupBox_poygonDate.Name = "groupBox_poygonDate";
            this.groupBox_poygonDate.Size = new System.Drawing.Size(231, 213);
            this.groupBox_poygonDate.TabIndex = 13;
            this.groupBox_poygonDate.TabStop = false;
            this.groupBox_poygonDate.Text = "Введите данные";
            this.groupBox_poygonDate.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(0, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 131);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Введите координаты точек";
            this.groupBox2.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(38, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(157, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(59, 45);
            this.button3.TabIndex = 7;
            this.button3.Text = "ok";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(38, 75);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "x=";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "y=";
            // 
            // button_n
            // 
            this.button_n.Location = new System.Drawing.Point(126, 53);
            this.button_n.Name = "button_n";
            this.button_n.Size = new System.Drawing.Size(75, 23);
            this.button_n.TabIndex = 6;
            this.button_n.Text = "ok";
            this.button_n.UseVisualStyleBackColor = true;
            this.button_n.Click += new System.EventHandler(this.button_n_Click);
            // 
            // textBox_n
            // 
            this.textBox_n.Location = new System.Drawing.Point(13, 53);
            this.textBox_n.Name = "textBox_n";
            this.textBox_n.Size = new System.Drawing.Size(100, 22);
            this.textBox_n.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Кол-во вершин";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(297, 359);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "вершина добавлена";
            this.label8.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(249, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(291, 22);
            this.textBox1.TabIndex = 15;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(249, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(238, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Координаты точек многоугольника";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "имя";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(113, 24);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 22);
            this.textBox_name.TabIndex = 2;
            // 
            // groupBox_chel
            // 
            this.groupBox_chel.Controls.Add(this.textBox_name);
            this.groupBox_chel.Controls.Add(this.label10);
            this.groupBox_chel.Location = new System.Drawing.Point(265, 327);
            this.groupBox_chel.Name = "groupBox_chel";
            this.groupBox_chel.Size = new System.Drawing.Size(219, 56);
            this.groupBox_chel.TabIndex = 8;
            this.groupBox_chel.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 524);
            this.Controls.Add(this.groupBox_chel);
            this.Controls.Add(this.groupBox_date);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelFCant);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_poygonDate);
            this.Name = "Form2";
            this.Text = "Field";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_date.ResumeLayout(false);
            this.groupBox_date.PerformLayout();
            this.groupBox_poygonDate.ResumeLayout(false);
            this.groupBox_poygonDate.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox_chel.ResumeLayout(false);
            this.groupBox_chel.PerformLayout();
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
        private System.Windows.Forms.RadioButton radioButton_Polygon;
        private System.Windows.Forms.GroupBox groupBox_poygonDate;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button_n;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox_n;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioButton_Triangle;
        private System.Windows.Forms.RadioButton radioButton_chel;
        private System.Windows.Forms.RadioButton radioButton_Line;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.GroupBox groupBox_chel;
    }
}