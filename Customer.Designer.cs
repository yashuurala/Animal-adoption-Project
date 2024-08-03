namespace animal_adoption
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            label12 = new Label();
            Deletebtn = new Button();
            Editbtn = new Button();
            Savebtn = new Button();
            CustPhoneTb = new TextBox();
            Cust = new Panel();
            CustomerDGV = new DataGridView();
            CustAddTb = new TextBox();
            label14 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            CustNameTb = new TextBox();
            label13 = new Label();
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
            label7 = new Label();
            pictureBox2 = new PictureBox();
            Cust.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomerDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Stencil", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(338, 268);
            label12.Name = "label12";
            label12.Size = new Size(159, 21);
            label12.TabIndex = 11;
            label12.Text = "Customer List";
            // 
            // Deletebtn
            // 
            Deletebtn.BackColor = SystemColors.WindowFrame;
            Deletebtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Deletebtn.ForeColor = SystemColors.ButtonHighlight;
            Deletebtn.Location = new Point(497, 209);
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
            Editbtn.Location = new Point(348, 209);
            Editbtn.Name = "Editbtn";
            Editbtn.Size = new Size(117, 40);
            Editbtn.TabIndex = 9;
            Editbtn.Text = "Edit";
            Editbtn.UseVisualStyleBackColor = false;
            // 
            // Savebtn
            // 
            Savebtn.BackColor = SystemColors.WindowFrame;
            Savebtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Savebtn.ForeColor = SystemColors.ButtonHighlight;
            Savebtn.Location = new Point(207, 209);
            Savebtn.Name = "Savebtn";
            Savebtn.Size = new Size(117, 40);
            Savebtn.TabIndex = 8;
            Savebtn.Text = "Save";
            Savebtn.UseVisualStyleBackColor = false;
            Savebtn.Click += Savebtn_Click;
            // 
            // CustPhoneTb
            // 
            CustPhoneTb.BorderStyle = BorderStyle.FixedSingle;
            CustPhoneTb.Location = new Point(561, 84);
            CustPhoneTb.Multiline = true;
            CustPhoneTb.Name = "CustPhoneTb";
            CustPhoneTb.Size = new Size(239, 34);
            CustPhoneTb.TabIndex = 5;
            // 
            // Cust
            // 
            Cust.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Cust.BackColor = SystemColors.Control;
            Cust.BorderStyle = BorderStyle.FixedSingle;
            Cust.Controls.Add(CustomerDGV);
            Cust.Controls.Add(CustAddTb);
            Cust.Controls.Add(label14);
            Cust.Controls.Add(label11);
            Cust.Controls.Add(label12);
            Cust.Controls.Add(Deletebtn);
            Cust.Controls.Add(Editbtn);
            Cust.Controls.Add(Savebtn);
            Cust.Controls.Add(CustPhoneTb);
            Cust.Controls.Add(label10);
            Cust.Controls.Add(label9);
            Cust.Controls.Add(CustNameTb);
            Cust.Controls.Add(label13);
            Cust.Controls.Add(label1);
            Cust.Location = new Point(288, 13);
            Cust.Name = "Cust";
            Cust.Size = new Size(864, 578);
            Cust.TabIndex = 35;
            Cust.Paint += panel1_Paint;
            // 
            // CustomerDGV
            // 
            CustomerDGV.BackgroundColor = SystemColors.ActiveCaption;
            CustomerDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomerDGV.Location = new Point(47, 321);
            CustomerDGV.Name = "CustomerDGV";
            CustomerDGV.RowHeadersWidth = 51;
            CustomerDGV.Size = new Size(790, 233);
            CustomerDGV.TabIndex = 15;
            CustomerDGV.CellContentClick += CustomerDGV_CellContentClick;
            // 
            // CustAddTb
            // 
            CustAddTb.Location = new Point(316, 84);
            CustAddTb.Multiline = true;
            CustAddTb.Name = "CustAddTb";
            CustAddTb.Size = new Size(227, 69);
            CustAddTb.TabIndex = 14;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(29, 16);
            label14.Name = "label14";
            label14.Size = new Size(113, 28);
            label14.TabIndex = 13;
            label14.Text = "Customer :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(29, 16);
            label11.Name = "label11";
            label11.Size = new Size(115, 28);
            label11.TabIndex = 13;
            label11.Text = "Employee :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F);
            label10.Location = new Point(629, 56);
            label10.Name = "label10";
            label10.Size = new Size(66, 25);
            label10.TabIndex = 4;
            label10.Text = "Phone";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F);
            label9.Location = new Point(367, 56);
            label9.Name = "label9";
            label9.Size = new Size(79, 25);
            label9.TabIndex = 2;
            label9.Text = "Address";
            // 
            // CustNameTb
            // 
            CustNameTb.BorderStyle = BorderStyle.FixedSingle;
            CustNameTb.Location = new Point(99, 84);
            CustNameTb.Multiline = true;
            CustNameTb.Name = "CustNameTb";
            CustNameTb.Size = new Size(190, 34);
            CustNameTb.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11F);
            label13.Location = new Point(150, 56);
            label13.Name = "label13";
            label13.Size = new Size(62, 25);
            label13.TabIndex = 0;
            label13.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(150, 56);
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
            label8.Location = new Point(108, 559);
            label8.Name = "label8";
            label8.Size = new Size(105, 32);
            label8.TabIndex = 45;
            label8.Text = "Log Out";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(107, 485);
            label6.Name = "label6";
            label6.Size = new Size(87, 32);
            label6.TabIndex = 44;
            label6.Text = "Billing";
            label6.TextAlign = ContentAlignment.TopCenter;
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.MenuText;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(108, 415);
            label5.Name = "label5";
            label5.Size = new Size(135, 32);
            label5.TabIndex = 43;
            label5.Text = "Customers";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(18, 547);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(73, 54);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 49;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(18, 474);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(73, 54);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 48;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(18, 249);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(73, 54);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 47;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(18, 324);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(73, 54);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 46;
            pictureBox4.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.WindowFrame;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(108, 335);
            label4.Name = "label4";
            label4.Size = new Size(149, 32);
            label4.TabIndex = 42;
            label4.Text = "Employeees";
            label4.TextAlign = ContentAlignment.TopCenter;
            label4.Click += label4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(18, 404);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(73, 54);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 40;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(18, 173);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(112, 261);
            label3.Name = "label3";
            label3.Size = new Size(116, 32);
            label3.TabIndex = 36;
            label3.Text = "Products";
            label3.TextAlign = ContentAlignment.TopCenter;
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(112, 183);
            label2.Name = "label2";
            label2.Size = new Size(82, 32);
            label2.TabIndex = 37;
            label2.Text = "Home";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(97, 41);
            label7.Name = "label7";
            label7.Size = new Size(131, 32);
            label7.TabIndex = 38;
            label7.Text = "EmpName";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(18, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(73, 68);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 39;
            pictureBox2.TabStop = false;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(1171, 614);
            Controls.Add(Cust);
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
            Controls.Add(label7);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Customer";
            Text = "Customer";
            Load += Customer_Load;
            Cust.ResumeLayout(false);
            Cust.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CustomerDGV).EndInit();
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

        private Label label12;
        private Button Deletebtn;
        private Button Editbtn;
        private Button Savebtn;
        private TextBox CustPhoneTb;
        private Panel Cust;
        private Label label10;
        private Label label9;
        private TextBox CustNameTb;
        private Label label1;
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
        private Label label7;
        private PictureBox pictureBox2;
        private Label label11;
        private Label label14;
        private Label label13;
        private TextBox CustAddTb;
        private DataGridView CustomerDGV;
    }
}