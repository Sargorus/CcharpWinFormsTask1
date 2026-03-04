namespace CcharpWinFormsTask1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(296, 66);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(75, 31);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoEllipsis = true;
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(644, 40);
            label1.TabIndex = 1;
            label1.Text = "Задача: Поезд прибывает на станцию в a часов b минут и отправляется в c часов d минут. \r\nПассажир пришел на платформу в n часов m минут. Будет ли поезд стоять на платформе?\r\n";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(403, 66);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(75, 31);
            textBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(377, 77);
            label2.Name = "label2";
            label2.Size = new Size(20, 20);
            label2.TabIndex = 3;
            label2.Text = "ч.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(484, 77);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 4;
            label3.Text = "мин.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 77);
            label4.Name = "label4";
            label4.Size = new Size(237, 20);
            label4.TabIndex = 5;
            label4.Text = "Поезд прибывает на станцию в: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 123);
            label5.Name = "label5";
            label5.Size = new Size(221, 20);
            label5.TabIndex = 10;
            label5.Text = "Поезд отбывает со станции в: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(484, 123);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 9;
            label6.Text = "мин.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(377, 123);
            label7.Name = "label7";
            label7.Size = new Size(20, 20);
            label7.TabIndex = 8;
            label7.Text = "ч.";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(403, 112);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(75, 31);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(296, 112);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(75, 31);
            textBox4.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 169);
            label8.Name = "label8";
            label8.Size = new Size(245, 20);
            label8.TabIndex = 11;
            label8.Text = "Пассажир прийдет на станцию в: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(484, 169);
            label9.Name = "label9";
            label9.Size = new Size(41, 20);
            label9.TabIndex = 15;
            label9.Text = "мин.";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(377, 169);
            label10.Name = "label10";
            label10.Size = new Size(20, 20);
            label10.TabIndex = 14;
            label10.Text = "ч.";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(403, 158);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(75, 31);
            textBox5.TabIndex = 13;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(296, 158);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(75, 31);
            textBox6.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(434, 195);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(366, 257);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(79, 192);
            button1.Name = "button1";
            button1.Size = new Size(154, 48);
            button1.TabIndex = 17;
            button1.Text = "Узнать, будет ли поезд на станции в то время, когда пришел пассажир";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(34, 243);
            label11.Name = "label11";
            label11.Size = new Size(245, 20);
            label11.TabIndex = 18;
            label11.Text = "Пассажир прийдет на станцию в: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label11);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(textBox5);
            Controls.Add(textBox6);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox textBox5;
        private TextBox textBox6;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label11;
    }
}
