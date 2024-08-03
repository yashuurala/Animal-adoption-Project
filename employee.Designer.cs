namespace animal_adoption
{
    partial class employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employee));
            panel1 = new Panel();
            EmployeeDGV = new DataGridView();
            label14 = new Label();
            EmpPasswordTb = new TextBox();
            label13 = new Label();
            EmpAddTb = new TextBox();
            label12 = new Label();
            Deletebtn = new Button();
            Editbtn = new Button();
            Savebtn = new Button();
            EmpDOB = new DateTimePicker();
            label11 = new Label();
            EmpPhoneTb = new TextBox();
            label10 = new Label();
            label9 = new Label();
            EmpNameTb = new TextBox();
            label1 = new Label();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EmployeeDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(EmployeeDGV);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(EmpPasswordTb);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(EmpAddTb);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(Deletebtn);
            panel1.Controls.Add(Editbtn);
            panel1.Controls.Add(Savebtn);
            panel1.Controls.Add(EmpDOB);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(EmpPhoneTb);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(EmpNameTb);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(288, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(864, 578);
            panel1.TabIndex = 19;
            // 
            // EmployeeDGV
            // 
            EmployeeDGV.BackgroundColor = SystemColors.ActiveCaption;
            EmployeeDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmployeeDGV.Location = new Point(26, 300);
            EmployeeDGV.Name = "EmployeeDGV";
            EmployeeDGV.RowHeadersWidth = 51;
            EmployeeDGV.Size = new Size(822, 252);
            EmployeeDGV.TabIndex = 17;
            EmployeeDGV.CellContentClick += EmployeeDGV_CellContentClick;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11F);
            label14.Location = new Point(644, 51);
            label14.Name = "label14";
            label14.Size = new Size(91, 25);
            label14.TabIndex = 16;
            label14.Text = "Password";
            // 
            // EmpPasswordTb
            // 
            EmpPasswordTb.BorderStyle = BorderStyle.FixedSingle;
            EmpPasswordTb.Location = new Point(644, 79);
            EmpPasswordTb.Multiline = true;
            EmpPasswordTb.Name = "EmpPasswordTb";
            EmpPasswordTb.Size = new Size(164, 34);
            EmpPasswordTb.TabIndex = 15;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(26, 12);
            label13.Name = "label13";
            label13.Size = new Size(115, 28);
            label13.TabIndex = 14;
            label13.Text = "Employee :";
            // 
            // EmpAddTb
            // 
            EmpAddTb.Location = new Point(199, 79);
            EmpAddTb.Multiline = true;
            EmpAddTb.Name = "EmpAddTb";
            EmpAddTb.Size = new Size(227, 69);
            EmpAddTb.TabIndex = 13;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Stencil", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(338, 256);
            label12.Name = "label12";
            label12.Size = new Size(167, 21);
            label12.TabIndex = 11;
            label12.Text = "Employees List";
            // 
            // Deletebtn
            // 
            Deletebtn.BackColor = SystemColors.WindowFrame;
            Deletebtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Deletebtn.ForeColor = SystemColors.ButtonHighlight;
            Deletebtn.Location = new Point(388, 192);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(117, 40);
            Deletebtn.TabIndex = 10;
            Deletebtn.Text = "Delete";
            Deletebtn.UseVisualStyleBackColor = false;
            Deletebtn.Click += Deletebtn_Click;
            // 
            // Editbtn
            // 
            Editbtn.BackColor = SystemColors.WindowFrame;
            Editbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Editbtn.ForeColor = SystemColors.ButtonHighlight;
            Editbtn.Location = new Point(229, 192);
            Editbtn.Name = "Editbtn";
            Editbtn.Size = new Size(117, 40);
            Editbtn.TabIndex = 9;
            Editbtn.Text = "Edit";
            Editbtn.UseVisualStyleBackColor = false;
            Editbtn.Click += Editbtn_Click;
            // 
            // Savebtn
            // 
            Savebtn.BackColor = SystemColors.WindowFrame;
            Savebtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Savebtn.ForeColor = SystemColors.ButtonHighlight;
            Savebtn.Location = new Point(77, 192);
            Savebtn.Name = "Savebtn";
            Savebtn.Size = new Size(117, 40);
            Savebtn.TabIndex = 8;
            Savebtn.Text = "Save";
            Savebtn.UseVisualStyleBackColor = false;
            Savebtn.Click += Savebtn_Click;
            // 
            // EmpDOB
            // 
            EmpDOB.Location = new Point(518, 159);
            EmpDOB.Name = "EmpDOB";
            EmpDOB.Size = new Size(222, 27);
            EmpDOB.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F);
            label11.Location = new Point(521, 123);
            label11.Name = "label11";
            label11.Size = new Size(118, 25);
            label11.TabIndex = 6;
            label11.Text = "Date of Birth";
            // 
            // EmpPhoneTb
            // 
            EmpPhoneTb.BorderStyle = BorderStyle.FixedSingle;
            EmpPhoneTb.Location = new Point(456, 79);
            EmpPhoneTb.Multiline = true;
            EmpPhoneTb.Name = "EmpPhoneTb";
            EmpPhoneTb.Size = new Size(164, 34);
            EmpPhoneTb.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F);
            label10.Location = new Point(472, 51);
            label10.Name = "label10";
            label10.Size = new Size(66, 25);
            label10.TabIndex = 4;
            label10.Text = "Phone";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F);
            label9.Location = new Point(218, 51);
            label9.Name = "label9";
            label9.Size = new Size(79, 25);
            label9.TabIndex = 2;
            label9.Text = "Address";
            // 
            // EmpNameTb
            // 
            EmpNameTb.BorderStyle = BorderStyle.FixedSingle;
            EmpNameTb.Location = new Point(26, 80);
            EmpNameTb.Multiline = true;
            EmpNameTb.Name = "EmpNameTb";
            EmpNameTb.Size = new Size(144, 34);
            EmpNameTb.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(48, 51);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(108, 565);
            label8.Name = "label8";
            label8.Size = new Size(105, 32);
            label8.TabIndex = 30;
            label8.Text = "Log Out";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(107, 491);
            label6.Name = "label6";
            label6.Size = new Size(87, 32);
            label6.TabIndex = 29;
            label6.Text = "Billing";
            label6.TextAlign = ContentAlignment.TopCenter;
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(108, 421);
            label5.Name = "label5";
            label5.Size = new Size(135, 32);
            label5.TabIndex = 28;
            label5.Text = "Customers";
            label5.TextAlign = ContentAlignment.TopCenter;
            label5.Click += label5_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(18, 553);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(73, 54);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 34;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(18, 480);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(73, 54);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 33;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(18, 255);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(73, 54);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 32;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(18, 330);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(73, 54);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 31;
            pictureBox4.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.MenuText;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(108, 341);
            label4.Name = "label4";
            label4.Size = new Size(149, 32);
            label4.TabIndex = 27;
            label4.Text = "Employeees";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(18, 410);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(73, 54);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 25;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(18, 179);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(112, 267);
            label3.Name = "label3";
            label3.Size = new Size(116, 32);
            label3.TabIndex = 21;
            label3.Text = "Products";
            label3.TextAlign = ContentAlignment.TopCenter;
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(112, 189);
            label2.Name = "label2";
            label2.Size = new Size(82, 32);
            label2.TabIndex = 22;
            label2.Text = "Home";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(18, 19);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(73, 68);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(97, 47);
            label7.Name = "label7";
            label7.Size = new Size(131, 32);
            label7.TabIndex = 23;
            label7.Text = "EmpName";
            // 
            // employee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(1171, 614);
            Controls.Add(panel1);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(label4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(label7);
            FormBorderStyle = FormBorderStyle.None;
            Name = "employee";
            Text = "employee";
            Load += employee_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EmployeeDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label8;
        private Label label6;
        private Label label5;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private Label label4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label7;
        private TextBox EmpNameTb;
        private Label label1;
        private TextBox EmpPhoneTb;
        private Label label10;
        private Label label9;
        private Label label12;
        private Button Deletebtn;
        private Button Editbtn;
        private Button Savebtn;
        private DateTimePicker EmpDOB;
        private Label label11;
        private TextBox EmpAddTb;
        private Label label14;
        private TextBox EmpPasswordTb;
        private Label label13;
        private DataGridView EmployeeDGV;
    }
}