namespace animal_adoption
{
    partial class login
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            EmpNameTb = new TextBox();
            EmpPassTb = new TextBox();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(785, 125);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(208, 42);
            label1.Name = "label1";
            label1.Size = new Size(361, 41);
            label1.TabIndex = 2;
            label1.Text = "Animal Adoption Center";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label2.Location = new Point(475, 137);
            label2.Name = "label2";
            label2.Size = new Size(145, 37);
            label2.TabIndex = 3;
            label2.Text = "UserName";
            label2.Click += label2_Click;
            // 
            // EmpNameTb
            // 
            EmpNameTb.BorderStyle = BorderStyle.FixedSingle;
            EmpNameTb.Location = new Point(458, 189);
            EmpNameTb.Multiline = true;
            EmpNameTb.Name = "EmpNameTb";
            EmpNameTb.Size = new Size(235, 47);
            EmpNameTb.TabIndex = 4;
            // 
            // EmpPassTb
            // 
            EmpPassTb.BorderStyle = BorderStyle.FixedSingle;
            EmpPassTb.Location = new Point(458, 290);
            EmpPassTb.Multiline = true;
            EmpPassTb.Name = "EmpPassTb";
            EmpPassTb.Size = new Size(235, 47);
            EmpPassTb.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label3.Location = new Point(488, 250);
            label3.Name = "label3";
            label3.Size = new Size(132, 37);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(458, 371);
            button1.Name = "button1";
            button1.Size = new Size(235, 50);
            button1.TabIndex = 7;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.Location = new Point(562, 448);
            label4.Name = "label4";
            label4.Size = new Size(58, 28);
            label4.TabIndex = 8;
            label4.Text = "Reset";
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(785, 607);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(EmpPassTb);
            Controls.Add(EmpNameTb);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login";
            Load += login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox EmpNameTb;
        private TextBox EmpPassTb;
        private Label label3;
        private Button button1;
        private Label label4;
    }
}