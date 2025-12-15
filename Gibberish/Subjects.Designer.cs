namespace Gibberish
{
    partial class Subjects
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            bttnDisplay = new Button();
            bttnSave = new Button();
            bttnUpdate = new Button();
            bttnNew = new Button();
            bttnDeleted = new Button();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            textBoxSubjectName = new TextBox();
            label2 = new Label();
            textBoxID = new TextBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(95, 39);
            label1.Name = "label1";
            label1.Size = new Size(625, 40);
            label1.TabIndex = 0;
            label1.Text = "STUDENT REGISTRATION/INFORMATION";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-3, -39);
            panel1.Name = "panel1";
            panel1.Size = new Size(806, 125);
            panel1.TabIndex = 22;
            // 
            // bttnDisplay
            // 
            bttnDisplay.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bttnDisplay.Location = new Point(118, 230);
            bttnDisplay.Name = "bttnDisplay";
            bttnDisplay.Size = new Size(75, 23);
            bttnDisplay.TabIndex = 1;
            bttnDisplay.Text = "DISPLAY";
            bttnDisplay.UseVisualStyleBackColor = true;
            bttnDisplay.Click += bttnDisplay_Click;
            // 
            // bttnSave
            // 
            bttnSave.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bttnSave.Location = new Point(73, 201);
            bttnSave.Name = "bttnSave";
            bttnSave.Size = new Size(75, 23);
            bttnSave.TabIndex = 2;
            bttnSave.Text = "SAVE";
            bttnSave.UseVisualStyleBackColor = true;
            bttnSave.Click += bttnSave_Click;
            // 
            // bttnUpdate
            // 
            bttnUpdate.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bttnUpdate.Location = new Point(19, 230);
            bttnUpdate.Name = "bttnUpdate";
            bttnUpdate.Size = new Size(75, 23);
            bttnUpdate.TabIndex = 3;
            bttnUpdate.Text = "UPDATE";
            bttnUpdate.UseVisualStyleBackColor = true;
            bttnUpdate.Click += bttnUpdate_Click;
            // 
            // bttnNew
            // 
            bttnNew.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bttnNew.Location = new Point(118, 259);
            bttnNew.Name = "bttnNew";
            bttnNew.Size = new Size(75, 23);
            bttnNew.TabIndex = 4;
            bttnNew.Text = "NEW";
            bttnNew.UseVisualStyleBackColor = true;
            bttnNew.Click += bttnNew_Click;
            // 
            // bttnDeleted
            // 
            bttnDeleted.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bttnDeleted.Location = new Point(19, 259);
            bttnDeleted.Name = "bttnDeleted";
            bttnDeleted.Size = new Size(75, 23);
            bttnDeleted.TabIndex = 5;
            bttnDeleted.Text = "DELETE";
            bttnDeleted.UseVisualStyleBackColor = true;
            bttnDeleted.Click += bttnDeleted_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(224, 230);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(564, 208);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(19, 122);
            label4.Name = "label4";
            label4.Size = new Size(129, 20);
            label4.TabIndex = 7;
            label4.Text = "Subject Name:";
            // 
            // textBoxSubjectName
            // 
            textBoxSubjectName.Location = new Point(154, 121);
            textBoxSubjectName.Name = "textBoxSubjectName";
            textBoxSubjectName.Size = new Size(252, 23);
            textBoxSubjectName.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 92);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 9;
            label2.Text = "Subject ID:";
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(153, 92);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(252, 23);
            textBoxID.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources._8275ea5e8c59e1f95401a6bd72566d41;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(425, 92);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 132);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Subjects
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxID);
            Controls.Add(label2);
            Controls.Add(textBoxSubjectName);
            Controls.Add(label4);
            Controls.Add(bttnDisplay);
            Controls.Add(bttnDeleted);
            Controls.Add(dataGridView1);
            Controls.Add(bttnNew);
            Controls.Add(bttnUpdate);
            Controls.Add(bttnSave);
            Controls.Add(panel1);
            Name = "Subjects";
            Text = "Subjects";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button bttnDisplay;
        private Button bttnSave;
        private Button bttnUpdate;
        private Button bttnNew;
        private Button bttnDeleted;
        private DataGridView dataGridView1;
        private Label label4;
        private TextBox textBoxSubjectName;
        private Label label2;
        private TextBox textBoxID;
        private PictureBox pictureBox1;
    }
}
