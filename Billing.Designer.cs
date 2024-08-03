namespace animal_adoption
{
    partial class Billing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
            label4 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            ProductsDGV = new DataGridView();
            label14 = new Label();
            label11 = new Label();
            label6 = new Label();
            label5 = new Label();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            label12 = new Label();
            label7 = new Label();
            Cust = new Panel();
            label21 = new Label();
            TotalLbl = new Label();
            label20 = new Label();
            dataGridView4 = new DataGridView();
            label19 = new Label();
            button1 = new Button();
            BillDGV = new DataGridView();
            label18 = new Label();
            QtyTb = new TextBox();
            label17 = new Label();
            PrNameTb = new TextBox();
            label16 = new Label();
            label15 = new Label();
            CustNameTb = new TextBox();
            label1 = new Label();
            label13 = new Label();
            CustIdCb = new ComboBox();
            dataGridView2 = new DataGridView();
            PrPriceTb = new TextBox();
            label9 = new Label();
            label10 = new Label();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            label8 = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductsDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            Cust.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BillDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.WindowFrame;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(99, 311);
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
            pictureBox3.Location = new Point(9, 380);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(73, 54);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 55;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 149);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 56;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(103, 237);
            label3.Name = "label3";
            label3.Size = new Size(116, 32);
            label3.TabIndex = 51;
            label3.Text = "Products";
            label3.TextAlign = ContentAlignment.TopCenter;
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(103, 159);
            label2.Name = "label2";
            label2.Size = new Size(82, 32);
            label2.TabIndex = 52;
            label2.Text = "Home";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(9, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(73, 68);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 54;
            pictureBox2.TabStop = false;
            // 
            // ProductsDGV
            // 
            ProductsDGV.BackgroundColor = SystemColors.ActiveCaption;
            ProductsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsDGV.Location = new Point(19, 406);
            ProductsDGV.Name = "ProductsDGV";
            ProductsDGV.RowHeadersWidth = 51;
            ProductsDGV.Size = new Size(410, 153);
            ProductsDGV.TabIndex = 15;
            ProductsDGV.CellContentClick += ProductDGV_CellContentClick;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(47, 47);
            label14.Name = "label14";
            label14.Size = new Size(115, 28);
            label14.TabIndex = 13;
            label14.Text = "Employee :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(52, 56);
            label11.Name = "label11";
            label11.Size = new Size(115, 28);
            label11.TabIndex = 13;
            label11.Text = "Employee :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.WindowText;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(98, 461);
            label6.Name = "label6";
            label6.Size = new Size(87, 32);
            label6.TabIndex = 59;
            label6.Text = "Billing";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.WindowFrame;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(99, 391);
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
            pictureBox7.Location = new Point(9, 523);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(73, 54);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 64;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(9, 450);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(73, 54);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 63;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(9, 225);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(73, 54);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 62;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(9, 300);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(73, 54);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 61;
            pictureBox4.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Stencil", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(118, 382);
            label12.Name = "label12";
            label12.Size = new Size(109, 21);
            label12.TabIndex = 11;
            label12.Text = "Products";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(88, 17);
            label7.Name = "label7";
            label7.Size = new Size(131, 32);
            label7.TabIndex = 53;
            label7.Text = "EmpName";
            // 
            // Cust
            // 
            Cust.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Cust.BackColor = SystemColors.Control;
            Cust.BorderStyle = BorderStyle.FixedSingle;
            Cust.Controls.Add(label21);
            Cust.Controls.Add(TotalLbl);
            Cust.Controls.Add(label20);
            Cust.Controls.Add(dataGridView4);
            Cust.Controls.Add(label19);
            Cust.Controls.Add(button1);
            Cust.Controls.Add(BillDGV);
            Cust.Controls.Add(label18);
            Cust.Controls.Add(QtyTb);
            Cust.Controls.Add(label17);
            Cust.Controls.Add(PrNameTb);
            Cust.Controls.Add(label16);
            Cust.Controls.Add(label15);
            Cust.Controls.Add(CustNameTb);
            Cust.Controls.Add(label1);
            Cust.Controls.Add(label13);
            Cust.Controls.Add(CustIdCb);
            Cust.Controls.Add(dataGridView2);
            Cust.Controls.Add(PrPriceTb);
            Cust.Controls.Add(label9);
            Cust.Controls.Add(label10);
            Cust.Controls.Add(button2);
            Cust.Controls.Add(button3);
            Cust.Controls.Add(dataGridView1);
            Cust.Controls.Add(ProductsDGV);
            Cust.Controls.Add(label14);
            Cust.Controls.Add(label11);
            Cust.Controls.Add(label12);
            Cust.Location = new Point(254, 17);
            Cust.Name = "Cust";
            Cust.Size = new Size(887, 578);
            Cust.TabIndex = 50;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Stencil", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.Location = new Point(570, 25);
            label21.Name = "label21";
            label21.Size = new Size(158, 21);
            label21.TabIndex = 49;
            label21.Text = "Products Bill";
            // 
            // TotalLbl
            // 
            TotalLbl.AutoSize = true;
            TotalLbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalLbl.Location = new Point(685, 328);
            TotalLbl.Name = "TotalLbl";
            TotalLbl.Size = new Size(25, 25);
            TotalLbl.TabIndex = 48;
            TotalLbl.Text = "=";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Stencil", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(585, 373);
            label20.Name = "label20";
            label20.Size = new Size(141, 21);
            label20.TabIndex = 47;
            label20.Text = "Transaction";
            // 
            // dataGridView4
            // 
            dataGridView4.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(435, 406);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.Size = new Size(437, 153);
            dataGridView4.TabIndex = 46;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(615, 328);
            label19.Name = "label19";
            label19.Size = new Size(32, 25);
            label19.TabIndex = 45;
            label19.Text = "Rs";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.WindowFrame;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(496, 322);
            button1.Name = "button1";
            button1.Size = new Size(99, 40);
            button1.TabIndex = 44;
            button1.Text = "Print";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // BillDGV
            // 
            BillDGV.BackgroundColor = SystemColors.ActiveCaption;
            BillDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BillDGV.Location = new Point(435, 56);
            BillDGV.Name = "BillDGV";
            BillDGV.RowHeadersWidth = 51;
            BillDGV.Size = new Size(437, 260);
            BillDGV.TabIndex = 43;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Stencil", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(538, 228);
            label18.Name = "label18";
            label18.Size = new Size(141, 21);
            label18.TabIndex = 42;
            label18.Text = "Transaction";
            // 
            // QtyTb
            // 
            QtyTb.BorderStyle = BorderStyle.FixedSingle;
            QtyTb.Location = new Point(168, 264);
            QtyTb.Multiline = true;
            QtyTb.Name = "QtyTb";
            QtyTb.Size = new Size(123, 28);
            QtyTb.TabIndex = 41;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 11F);
            label17.Location = new Point(168, 236);
            label17.Name = "label17";
            label17.Size = new Size(123, 25);
            label17.TabIndex = 40;
            label17.Text = "Product Qtity";
            // 
            // PrNameTb
            // 
            PrNameTb.BorderStyle = BorderStyle.FixedSingle;
            PrNameTb.Location = new Point(29, 264);
            PrNameTb.Multiline = true;
            PrNameTb.Name = "PrNameTb";
            PrNameTb.Size = new Size(133, 28);
            PrNameTb.TabIndex = 39;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(168, 188);
            label16.Name = "label16";
            label16.Size = new Size(99, 31);
            label16.TabIndex = 38;
            label16.Text = "Product";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(137, 25);
            label15.Name = "label15";
            label15.Size = new Size(117, 31);
            label15.TabIndex = 37;
            label15.Text = "Customer";
            // 
            // CustNameTb
            // 
            CustNameTb.BorderStyle = BorderStyle.FixedSingle;
            CustNameTb.Location = new Point(196, 113);
            CustNameTb.Multiline = true;
            CustNameTb.Name = "CustNameTb";
            CustNameTb.Size = new Size(153, 28);
            CustNameTb.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(196, 84);
            label1.Name = "label1";
            label1.Size = new Size(148, 25);
            label1.TabIndex = 35;
            label1.Text = "Customer Name";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11F);
            label13.Location = new Point(29, 84);
            label13.Name = "label13";
            label13.Size = new Size(114, 25);
            label13.TabIndex = 34;
            label13.Text = "Customer id";
            // 
            // CustIdCb
            // 
            CustIdCb.FormattingEnabled = true;
            CustIdCb.Items.AddRange(new object[] { "Bird", "Dog", "Cat", "Food" });
            CustIdCb.Location = new Point(29, 112);
            CustIdCb.Name = "CustIdCb";
            CustIdCb.Size = new Size(133, 28);
            CustIdCb.TabIndex = 33;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(19, 18);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(410, 153);
            dataGridView2.TabIndex = 29;
            // 
            // PrPriceTb
            // 
            PrPriceTb.BorderStyle = BorderStyle.FixedSingle;
            PrPriceTb.Location = new Point(297, 264);
            PrPriceTb.Multiline = true;
            PrPriceTb.Name = "PrPriceTb";
            PrPriceTb.Size = new Size(125, 28);
            PrPriceTb.TabIndex = 27;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F);
            label9.Location = new Point(297, 236);
            label9.Name = "label9";
            label9.Size = new Size(125, 25);
            label9.TabIndex = 26;
            label9.Text = "Product Price";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F);
            label10.Location = new Point(29, 236);
            label10.Name = "label10";
            label10.Size = new Size(133, 25);
            label10.TabIndex = 25;
            label10.Text = "Product Name";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.WindowFrame;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(225, 298);
            button2.Name = "button2";
            button2.Size = new Size(87, 40);
            button2.TabIndex = 22;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.WindowFrame;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(98, 298);
            button3.Name = "button3";
            button3.Size = new Size(99, 40);
            button3.TabIndex = 21;
            button3.Text = "Add to Bill";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(19, 178);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(410, 192);
            dataGridView1.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(99, 535);
            label8.Name = "label8";
            label8.Size = new Size(105, 32);
            label8.TabIndex = 60;
            label8.Text = "Log Out";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // Billing
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(1153, 616);
            Controls.Add(label4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(label7);
            Controls.Add(Cust);
            Controls.Add(label8);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Billing";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Billing";
            Load += Billing_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductsDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            Cust.ResumeLayout(false);
            Cust.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ((System.ComponentModel.ISupportInitialize)BillDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox2;
        private DataGridView ProductsDGV;
        private Label label14;
        private Label label11;
        private Label label6;
        private Label label5;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private Label label12;
        private Label label7;
        private Panel Cust;
        private Label label8;
        private TextBox CustNameTb;
        private Label label1;
        private Label label13;
        private ComboBox CustIdCb;
        private DataGridView dataGridView2;
        private TextBox PrPriceTb;
        private Label label9;
        private Label label10;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private TextBox QtyTb;
        private Label label17;
        private TextBox PrNameTb;
        private Label label16;
        private Label label15;
        private DataGridView BillDGV;
        private Label label18;
        private Label label19;
        private Button button1;
        private Label label20;
        private DataGridView dataGridView4;
        private Label TotalLbl;
        private Label label21;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}