namespace Gibberish
{
    partial class Student
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.download__8_;
            pictureBox1.Location = new Point(-20, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(808, 449);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-5, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(811, 83);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 81);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 371);
            panel2.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(111, 22);
            label1.Name = "label1";
            label1.Size = new Size(585, 46);
            label1.TabIndex = 0;
            label1.Text = "Student Management System ";
            label1.Click += label1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Info;
            panel3.Controls.Add(button6);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Location = new Point(1, 87);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 365);
            panel3.TabIndex = 8;
            // 
            // button6
            // 
            button6.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(32, 305);
            button6.Name = "button6";
            button6.Size = new Size(130, 33);
            button6.TabIndex = 14;
            button6.Text = "Attendance";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(32, 247);
            button5.Name = "button5";
            button5.Size = new Size(130, 39);
            button5.TabIndex = 13;
            button5.Text = "Enrollment";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(32, 200);
            button4.Name = "button4";
            button4.Size = new Size(130, 28);
            button4.TabIndex = 12;
            button4.Text = "Section";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(32, 140);
            button3.Name = "button3";
            button3.Size = new Size(130, 41);
            button3.TabIndex = 11;
            button3.Text = "Teacher";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(32, 77);
            button2.Name = "button2";
            button2.Size = new Size(130, 44);
            button2.TabIndex = 10;
            button2.Text = "Subject";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(32, 31);
            button1.Name = "button1";
            button1.Size = new Size(130, 27);
            button1.TabIndex = 9;
            button1.Text = "Student";
            button1.UseVisualStyleBackColor = true;
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "Student";
            Text = "Student";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}