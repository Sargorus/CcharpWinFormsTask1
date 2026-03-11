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
            textBoxHourArrivalTrain = new TextBox();
            label1 = new Label();
            textBoxMinuteArrivalTrain = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBoxDepartureMinuteTrain = new TextBox();
            textBoxDepartureHourTrain = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            textBoxPassengerMinute = new TextBox();
            textBoxPassengerHour = new TextBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxHourArrivalTrain
            // 
            textBoxHourArrivalTrain.Location = new Point(296, 66);
            textBoxHourArrivalTrain.Multiline = true;
            textBoxHourArrivalTrain.Name = "textBoxHourArrivalTrain";
            textBoxHourArrivalTrain.Size = new Size(75, 31);
            textBoxHourArrivalTrain.TabIndex = 0;
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
            // textBoxMinuteArrivalTrain
            // 
            textBoxMinuteArrivalTrain.Location = new Point(403, 66);
            textBoxMinuteArrivalTrain.Multiline = true;
            textBoxMinuteArrivalTrain.Name = "textBoxMinuteArrivalTrain";
            textBoxMinuteArrivalTrain.Size = new Size(75, 31);
            textBoxMinuteArrivalTrain.TabIndex = 2;
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
            // textBoxDepartureMinuteTrain
            // 
            textBoxDepartureMinuteTrain.Location = new Point(403, 112);
            textBoxDepartureMinuteTrain.Multiline = true;
            textBoxDepartureMinuteTrain.Name = "textBoxDepartureMinuteTrain";
            textBoxDepartureMinuteTrain.Size = new Size(75, 31);
            textBoxDepartureMinuteTrain.TabIndex = 7;
            // 
            // textBoxDepartureHourTrain
            // 
            textBoxDepartureHourTrain.Location = new Point(296, 112);
            textBoxDepartureHourTrain.Multiline = true;
            textBoxDepartureHourTrain.Name = "textBoxDepartureHourTrain";
            textBoxDepartureHourTrain.Size = new Size(75, 31);
            textBoxDepartureHourTrain.TabIndex = 6;
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
            // textBoxPassengerMinute
            // 
            textBoxPassengerMinute.Location = new Point(403, 158);
            textBoxPassengerMinute.Multiline = true;
            textBoxPassengerMinute.Name = "textBoxPassengerMinute";
            textBoxPassengerMinute.Size = new Size(75, 31);
            textBoxPassengerMinute.TabIndex = 13;
            // 
            // textBoxPassengerHour
            // 
            textBoxPassengerHour.Location = new Point(296, 158);
            textBoxPassengerHour.Multiline = true;
            textBoxPassengerHour.Name = "textBoxPassengerHour";
            textBoxPassengerHour.Size = new Size(75, 31);
            textBoxPassengerHour.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(484, 192);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(330, 232);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 425);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(textBoxPassengerMinute);
            Controls.Add(textBoxPassengerHour);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(textBoxDepartureMinuteTrain);
            Controls.Add(textBoxDepartureHourTrain);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxMinuteArrivalTrain);
            Controls.Add(label1);
            Controls.Add(textBoxHourArrivalTrain);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxHourArrivalTrain;
        private Label label1;
        private TextBox textBoxMinuteArrivalTrain;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBoxDepartureMinuteTrain;
        private TextBox textBoxDepartureHourTrain;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox textBoxPassengerMinute;
        private TextBox textBoxPassengerHour;
        private PictureBox pictureBox1;
        private Button button1;
    }
}
