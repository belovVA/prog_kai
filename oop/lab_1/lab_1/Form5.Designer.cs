namespace lab_1
{
    partial class Form5
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
            this.closeButton = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMatrB = new System.Windows.Forms.Button();
            this.buttonMatrC = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonMatrA = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelError = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelErrorMAtr = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.DarkRed;
            this.closeButton.Location = new System.Drawing.Point(778, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(23, 25);
            this.closeButton.TabIndex = 11;
            this.closeButton.Text = "x";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(442, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 62);
            this.button1.TabIndex = 12;
            this.button1.Text = "Создать матрицу А";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "24";
            // 
            // buttonMatrB
            // 
            this.buttonMatrB.Location = new System.Drawing.Point(23, 81);
            this.buttonMatrB.Name = "buttonMatrB";
            this.buttonMatrB.Size = new System.Drawing.Size(108, 36);
            this.buttonMatrB.TabIndex = 15;
            this.buttonMatrB.Text = "Матрица B";
            this.buttonMatrB.UseVisualStyleBackColor = true;
            this.buttonMatrB.Click += new System.EventHandler(this.buttonMatrB_Click);
            // 
            // buttonMatrC
            // 
            this.buttonMatrC.Location = new System.Drawing.Point(23, 143);
            this.buttonMatrC.Name = "buttonMatrC";
            this.buttonMatrC.Size = new System.Drawing.Size(108, 30);
            this.buttonMatrC.TabIndex = 16;
            this.buttonMatrC.Text = "Матрица C";
            this.buttonMatrC.UseVisualStyleBackColor = true;
            this.buttonMatrC.Click += new System.EventHandler(this.buttonMatrC_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonMatrA);
            this.groupBox1.Controls.Add(this.buttonMatrB);
            this.groupBox1.Controls.Add(this.buttonMatrC);
            this.groupBox1.Location = new System.Drawing.Point(78, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 193);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // buttonMatrA
            // 
            this.buttonMatrA.Location = new System.Drawing.Point(23, 21);
            this.buttonMatrA.Name = "buttonMatrA";
            this.buttonMatrA.Size = new System.Drawing.Size(108, 36);
            this.buttonMatrA.TabIndex = 17;
            this.buttonMatrA.Text = "Матрица А";
            this.buttonMatrA.UseVisualStyleBackColor = true;
            this.buttonMatrA.Click += new System.EventHandler(this.buttonMatrA_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Введите порядок матрицы ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(291, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 19;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.BackColor = System.Drawing.Color.DarkRed;
            this.labelError.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelError.Location = new System.Drawing.Point(208, 149);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(183, 16);
            this.labelError.TabIndex = 20;
            this.labelError.Text = "Не является целым числом";
            this.labelError.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkRed;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(208, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "порядок должен быть больше 0";
            this.label3.Visible = false;
            // 
            // labelErrorMAtr
            // 
            this.labelErrorMAtr.BackColor = System.Drawing.Color.DarkRed;
            this.labelErrorMAtr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelErrorMAtr.Location = new System.Drawing.Point(480, 163);
            this.labelErrorMAtr.Name = "labelErrorMAtr";
            this.labelErrorMAtr.Size = new System.Drawing.Size(220, 51);
            this.labelErrorMAtr.TabIndex = 22;
            this.labelErrorMAtr.Text = "Некоторые эллементы матрицы не являются числами";
            this.labelErrorMAtr.Visible = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(802, 491);
            this.Controls.Add(this.labelErrorMAtr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.closeButton);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMatrB;
        private System.Windows.Forms.Button buttonMatrC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonMatrA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelErrorMAtr;
    }
}