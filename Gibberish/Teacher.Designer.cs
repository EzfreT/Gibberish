namespace Gibberish
{
    partial class Teacher
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
            label1 = new Label();
            textBoxID = new TextBox();
            label2 = new Label();
            textBoxPhone = new TextBox();
            label4 = new Label();
            bttnDisplay = new Button();
            bttnDeleted = new Button();
            dataGridView1 = new DataGridView();
            bttnNew = new Button();
            bttnUpdate = new Button();
            bttnSave = new Button();
            panel1 = new Panel();
            label3 = new Label();
            textBoxTeacherName = new TextBox();
            label5 = new Label();
            textBoxgGender = new TextBox();
            label6 = new Label();
            textBoxSubDep = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(257, 40);
            label1.Name = "label1";
            label1.Size = new Size(296, 40);
            label1.TabIndex = 0;
            label1.Text = "SUBJECT TEACHER";
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(153, 120);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(252, 23);
            textBoxID.TabIndex = 32;
            textBoxID.TextChanged += textBoxTeacherID_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 118);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 31;
            label2.Text = "Teacher ID:";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(153, 213);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(252, 23);
            textBoxPhone.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 152);
            label4.Name = "label4";
            label4.Size = new Size(133, 20);
            label4.TabIndex = 29;
            label4.Text = "Teacher Name:";
            // 
            // bttnDisplay
            // 
            bttnDisplay.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bttnDisplay.Location = new Point(118, 314);
            bttnDisplay.Name = "bttnDisplay";
            bttnDisplay.Size = new Size(75, 23);
            bttnDisplay.TabIndex = 23;
            bttnDisplay.Text = "DISPLAY";
            bttnDisplay.UseVisualStyleBackColor = true;
            bttnDisplay.Click += bttnDisplay_Click;
            // 
            // bttnDeleted
            // 
            bttnDeleted.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bttnDeleted.Location = new Point(19, 314);
            bttnDeleted.Name = "bttnDeleted";
            bttnDeleted.Size = new Size(75, 23);
            bttnDeleted.TabIndex = 27;
            bttnDeleted.Text = "DELETE";
            bttnDeleted.UseVisualStyleBackColor = true;
            bttnDeleted.Click += bttnDeleted_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(224, 256);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(564, 208);
            dataGridView1.TabIndex = 28;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // bttnNew
            // 
            bttnNew.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bttnNew.Location = new Point(118, 285);
            bttnNew.Name = "bttnNew";
            bttnNew.Size = new Size(75, 23);
            bttnNew.TabIndex = 26;
            bttnNew.Text = "NEW";
            bttnNew.UseVisualStyleBackColor = true;
            bttnNew.Click += bttnNew_Click;
            // 
            // bttnUpdate
            // 
            bttnUpdate.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bttnUpdate.Location = new Point(19, 285);
            bttnUpdate.Name = "bttnUpdate";
            bttnUpdate.Size = new Size(75, 23);
            bttnUpdate.TabIndex = 25;
            bttnUpdate.Text = "UPDATE";
            bttnUpdate.UseVisualStyleBackColor = true;
            bttnUpdate.Click += bttnUpdate_Click;
            // 
            // bttnSave
            // 
            bttnSave.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bttnSave.Location = new Point(70, 256);
            bttnSave.Name = "bttnSave";
            bttnSave.Size = new Size(75, 23);
            bttnSave.TabIndex = 24;
            bttnSave.Text = "SAVE";
            bttnSave.UseVisualStyleBackColor = true;
            bttnSave.Click += bttnSave_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-3, -13);
            panel1.Name = "panel1";
            panel1.Size = new Size(806, 125);
            panel1.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 182);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 35;
            label3.Text = "Gender:";
            // 
            // textBoxTeacherName
            // 
            textBoxTeacherName.Location = new Point(153, 154);
            textBoxTeacherName.Name = "textBoxTeacherName";
            textBoxTeacherName.Size = new Size(252, 23);
            textBoxTeacherName.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(29, 211);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 37;
            label5.Text = "Phone:";
            // 
            // textBoxgGender
            // 
            textBoxgGender.Location = new Point(153, 182);
            textBoxgGender.Name = "textBoxgGender";
            textBoxgGender.Size = new Size(252, 23);
            textBoxgGender.TabIndex = 38;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(431, 118);
            label6.Name = "label6";
            label6.Size = new Size(196, 20);
            label6.TabIndex = 39;
            label6.Text = "Subject/Department:";
            // 
            // textBoxSubDep
            // 
            textBoxSubDep.Location = new Point(631, 118);
            textBoxSubDep.Name = "textBoxSubDep";
            textBoxSubDep.Size = new Size(157, 23);
            textBoxSubDep.TabIndex = 40;
            // 
            // Teacher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxSubDep);
            Controls.Add(label6);
            Controls.Add(textBoxgGender);
            Controls.Add(label5);
            Controls.Add(textBoxTeacherName);
            Controls.Add(label3);
            Controls.Add(textBoxID);
            Controls.Add(label2);
            Controls.Add(textBoxPhone);
            Controls.Add(label4);
            Controls.Add(bttnDisplay);
            Controls.Add(bttnDeleted);
            Controls.Add(dataGridView1);
            Controls.Add(bttnNew);
            Controls.Add(bttnUpdate);
            Controls.Add(bttnSave);
            Controls.Add(panel1);
            Name = "Teacher";
            Text = "Teacher";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxID;
        private Label label2;
        private TextBox textBoxPhone;
        private Label label4;
        private Button bttnDisplay;
        private Button bttnDeleted;
        private DataGridView dataGridView1;
        private Button bttnNew;
        private Button bttnUpdate;
        private Button bttnSave;
        private Panel panel1;
        private Label label3;
        private TextBox textBoxTeacherName;
        private Label label5;
        private TextBox textBoxgGender;
        private Label label6;
        private TextBox textBoxSubDep;
    }
}