namespace Gibberish
{
    partial class enrollment
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
            textBoxSection = new TextBox();
            label5 = new Label();
            textBoxStudentName = new TextBox();
            label3 = new Label();
            textEnrollmentID = new TextBox();
            label2 = new Label();
            label4 = new Label();
            bttnDisplay = new Button();
            bttnDeleted = new Button();
            dataGridView1 = new DataGridView();
            bttnNew = new Button();
            bttnUpdate = new Button();
            bttnSave = new Button();
            panel1 = new Panel();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxSection
            // 
            textBoxSection.Location = new Point(180, 183);
            textBoxSection.Name = "textBoxSection";
            textBoxSection.Size = new Size(252, 23);
            textBoxSection.TabIndex = 55;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 209);
            label5.Name = "label5";
            label5.Size = new Size(162, 20);
            label5.TabIndex = 54;
            label5.Text = "Enrollment Date:";
            // 
            // textBoxStudentName
            // 
            textBoxStudentName.Location = new Point(180, 154);
            textBoxStudentName.Name = "textBoxStudentName";
            textBoxStudentName.Size = new Size(252, 23);
            textBoxStudentName.TabIndex = 53;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 182);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 52;
            label3.Text = "Section:";
            // 
            // textEnrollmentID
            // 
            textEnrollmentID.Location = new Point(180, 120);
            textEnrollmentID.Name = "textEnrollmentID";
            textEnrollmentID.Size = new Size(252, 23);
            textEnrollmentID.TabIndex = 50;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 118);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 49;
            label2.Text = "Enrollment ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 152);
            label4.Name = "label4";
            label4.Size = new Size(134, 20);
            label4.TabIndex = 47;
            label4.Text = "Student Name:";
            // 
            // bttnDisplay
            // 
            bttnDisplay.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bttnDisplay.Location = new Point(118, 314);
            bttnDisplay.Name = "bttnDisplay";
            bttnDisplay.Size = new Size(75, 23);
            bttnDisplay.TabIndex = 41;
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
            bttnDeleted.TabIndex = 45;
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
            dataGridView1.TabIndex = 46;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // bttnNew
            // 
            bttnNew.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bttnNew.Location = new Point(118, 285);
            bttnNew.Name = "bttnNew";
            bttnNew.Size = new Size(75, 23);
            bttnNew.TabIndex = 44;
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
            bttnUpdate.TabIndex = 43;
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
            bttnSave.TabIndex = 42;
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
            panel1.TabIndex = 51;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(257, 40);
            label1.Name = "label1";
            label1.Size = new Size(316, 40);
            label1.TabIndex = 0;
            label1.Text = "ENROLLMENT FORM";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(180, 212);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(252, 23);
            dateTimePicker1.TabIndex = 56;
            // 
            // enrollment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBoxSection);
            Controls.Add(label5);
            Controls.Add(textBoxStudentName);
            Controls.Add(label3);
            Controls.Add(textEnrollmentID);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(bttnDisplay);
            Controls.Add(bttnDeleted);
            Controls.Add(dataGridView1);
            Controls.Add(bttnNew);
            Controls.Add(bttnUpdate);
            Controls.Add(bttnSave);
            Controls.Add(panel1);
            Name = "enrollment";
            Text = "enrollment";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxSection;
        private Label label5;
        private TextBox textBoxStudentName;
        private Label label3;
        private TextBox textEnrollmentID;
        private Label label2;
        private Label label4;
        private Button bttnDisplay;
        private Button bttnDeleted;
        private DataGridView dataGridView1;
        private Button bttnNew;
        private Button bttnUpdate;
        private Button bttnSave;
        private Panel panel1;
        private Label label1;
        private DateTimePicker dateTimePicker1;
    }
}