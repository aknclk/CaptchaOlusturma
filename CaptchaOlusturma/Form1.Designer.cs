namespace CaptchaOlusturma
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            kontrolcu = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(135, 122);
            button1.Name = "button1";
            button1.Size = new Size(70, 34);
            button1.TabIndex = 0;
            button1.Text = "Değiştir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Script", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(240, 55);
            label5.Name = "label5";
            label5.Size = new Size(25, 42);
            label5.TabIndex = 1;
            label5.Text = ".";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Script", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(198, 55);
            label4.Name = "label4";
            label4.Size = new Size(25, 42);
            label4.TabIndex = 1;
            label4.Text = ".";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Script", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(156, 55);
            label3.Name = "label3";
            label3.Size = new Size(25, 42);
            label3.TabIndex = 1;
            label3.Text = ".";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Script", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(114, 55);
            label2.Name = "label2";
            label2.Size = new Size(25, 42);
            label2.TabIndex = 1;
            label2.Text = ".";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(72, 55);
            label1.Name = "label1";
            label1.Size = new Size(25, 42);
            label1.TabIndex = 1;
            label1.Text = ".";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(72, 192);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(193, 43);
            textBox1.TabIndex = 2;
            // 
            // kontrolcu
            // 
            kontrolcu.AutoSize = true;
            kontrolcu.Location = new Point(72, 238);
            kontrolcu.Name = "kontrolcu";
            kontrolcu.Size = new Size(10, 15);
            kontrolcu.TabIndex = 3;
            kontrolcu.Text = " ";
            kontrolcu.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(135, 263);
            button2.Name = "button2";
            button2.Size = new Size(70, 34);
            button2.TabIndex = 4;
            button2.Text = "Kontrol Et";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 341);
            Controls.Add(button2);
            Controls.Add(kontrolcu);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Captcha";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Label kontrolcu;
        private Button button2;
    }
}