namespace animal_adoption
{
    partial class Products
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            PriceTb = new TextBox();
            label9 = new Label();
            panel1 = new Panel();
            QtyTb = new TextBox();
            ProductsDGV = new DataGridView();
            label1 = new Label();
            CatCb = new ComboBox();
            label14 = new Label();
            label11 = new Label();
            label12 = new Label();
            Deletebtn = new Button();
            Editbtn = new Button();
            Savebtn = new Button();
            label10 = new Label();
            PrNameTb = new TextBox();
            label13 = new Label();
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
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductsDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // PriceTb
            // 
            PriceTb.BorderStyle = BorderStyle.FixedSingle;
            PriceTb.Location = new Point(638, 96);
            PriceTb.Multiline = true;
            PriceTb.Name = "PriceTb";
            PriceTb.Size = new Size(212, 34);
            PriceTb.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F);
            label9.Location = new Point(447, 68);
            label9.Name = "label9";
            label9.Size = new Size(84, 25);
            label9.TabIndex = 2;
            label9.Text = "Quantity";
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(QtyTb);
            panel1.Controls.Add(ProductsDGV);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(CatCb);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(Deletebtn);
            panel1.Controls.Add(Editbtn);
            panel1.Controls.Add(Savebtn);
            panel1.Controls.Add(PriceTb);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(PrNameTb);
            panel1.Controls.Add(label13);
            panel1.Location = new Point(288, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(864, 578);
            panel1.TabIndex = 50;
            // 
            // QtyTb
            // 
            QtyTb.Location = new Point(434, 96);
            QtyTb.Multiline = true;
            QtyTb.Name = "QtyTb";
            QtyTb.Size = new Size(169, 34);
            QtyTb.TabIndex = 19;
            // 
            // ProductsDGV
            // 
            ProductsDGV.BackgroundColor = SystemColors.ActiveCaption;
            ProductsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsDGV.Location = new Point(22, 310);
            ProductsDGV.Name = "ProductsDGV";
            ProductsDGV.RowHeadersWidth = 51;
            ProductsDGV.Size = new Size(822, 252);
            ProductsDGV.TabIndex = 18;
            ProductsDGV.CellContentClick += ProductsDGV_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(235, 68);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 15;
            label1.Text = "Category";
            // 
            // CatCb
            // 
            CatCb.FormattingEnabled = true;
            CatCb.Items.AddRange(new object[] { "Bird", "Dog", "Cat", "Food" });
            CatCb.Location = new Point(207, 102);
            CatCb.Name = "CatCb";
            CatCb.Size = new Size(178, 28);
            CatCb.TabIndex = 14;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(29, 16);
            label14.Name = "label14";
            label14.Size = new Size(97, 28);
            label14.TabIndex = 13;
            label14.Text = "Product :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(29, 16);
            label11.Name = "label11";
            label11.Size = new Size(110, 28);
            label11.TabIndex = 13;
            label11.Text = "Employee ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Stencil", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(338, 268);
            label12.Name = "label12";
            label12.Size = new Size(146, 21);
            label12.TabIndex = 11;
            label12.Text = "Product List";
            // 
            // Deletebtn
            // 
            Deletebtn.BackColor = SystemColors.WindowFrame;
            Deletebtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Deletebtn.ForeColor = SystemColors.ButtonHighlight;
            Deletebtn.Location = new Point(497, 161);
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
            Editbtn.Location = new Point(349, 159);
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
            Savebtn.Location = new Point(207, 161);
            Savebtn.Name = "Savebtn";
            Savebtn.Size = new Size(117, 40);
            Savebtn.TabIndex = 8;
            Savebtn.Text = "Save";
            Savebtn.UseVisualStyleBackColor = false;
            Savebtn.Click += Savebtn_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F);
            label10.Location = new Point(658, 68);
            label10.Name = "label10";
            label10.Size = new Size(54, 25);
            label10.TabIndex = 4;
            label10.Text = "Price";
            // 
            // PrNameTb
            // 
            PrNameTb.BorderStyle = BorderStyle.FixedSingle;
            PrNameTb.Location = new Point(22, 96);
            PrNameTb.Multiline = true;
            PrNameTb.Name = "PrNameTb";
            PrNameTb.Size = new Size(157, 34);
            PrNameTb.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11F);
            label13.Location = new Point(29, 68);
            label13.Name = "label13";
            label13.Size = new Size(62, 25);
            label13.TabIndex = 0;
            label13.Text = "Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(108, 559);
            label8.Name = "label8";
            label8.Size = new Size(105, 32);
            label8.TabIndex = 60;
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
            label6.Size = new Size(121, 32);
            label6.TabIndex = 59;
            label6.Text = "Donation";
            label6.TextAlign = ContentAlignment.TopCenter;
           // label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.WindowFrame;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(108, 415);
            label5.Name = "label5";
            label5.Size = new Size(135, 32);
            label5.TabIndex = 58;
            label5.Text = "Customers";
            label5.TextAlign = ContentAlignment.TopCenter;
            label5.Click += label5_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(18, 547);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(73, 54);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 64;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(18, 474);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(73, 54);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 63;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(18, 249);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(73, 54);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 62;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(18, 324);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(73, 54);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 61;
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
            label4.TabIndex = 57;
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
            pictureBox3.TabIndex = 55;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(18, 173);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 56;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.MenuText;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(112, 261);
            label3.Name = "label3";
            label3.Size = new Size(116, 32);
            label3.TabIndex = 51;
            label3.Text = "Products";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(112, 183);
            label2.Name = "label2";
            label2.Size = new Size(82, 32);
            label2.TabIndex = 52;
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
            label7.TabIndex = 53;
            label7.Text = "EmpName";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(18, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(73, 68);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 54;
            pictureBox2.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Products
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
            Controls.Add(label7);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Products";
            Text = "Products";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProductsDGV).EndInit();
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

        private TextBox PriceTb;
        private Label label9;
        private Panel panel1;
        private Label label14;
        private Label label11;
        private Label label12;
        private Button Deletebtn;
        private Button Editbtn;
        private Button Savebtn;
        private Label label10;
        private TextBox PrNameTb;
        private Label label13;
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
        private ComboBox CatCb;
        private Label label1;
        private DataGridView ProductsDGV;
        private TextBox QtyTb;
        private ContextMenuStrip contextMenuStrip1;
    }
}