using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace animal_adoption
{
    public partial class Form1 : Form
    {
        public static string concStringDON1 = " ";
        public static string concStringDON2 = " ";
        public static string concStringDON3 = " ";
        public static int c = 0;
        public Form1()
        {
            InitializeComponent();
            label1.Text = Form3.ans1;
            label2.Text = Form3.ans2;
            label3.Text = Form3.ans3;
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Documents\AnimalAdop.mdf;Integrated Security=True;Connect Timeout=30");
        private void Clear()
        {

            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox1.Text = " ";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            c++;
            if (c > 3)
            {
                MessageBox.Show("only 3 donation at a time");
                Clear();
            }
            else if (textBox1.Text == " " || textBox2.Text == " " || textBox3.Text == " " || textBox4.Text == " ")
            {
                MessageBox.Show("Missing Information");
            }
            else

            {
                if (c == 1)
                {
                    concStringDON1 = $"Username: {textBox1.Text}, Amount: {textBox2.Text}, Name: {textBox3.Text},Phone :{textBox4.Text}";
                    //notificatin at Admin end
                    Clear();
                }
                else if (c == 2)
                {
                    concStringDON2 = $"Username: {textBox1.Text}, Amount: {textBox2.Text}, Name: {textBox3.Text},Phone :{textBox4.Text}";
                }
                else if (c == 3)
                {
                    concStringDON3 = $"Username: {textBox1.Text}, Amount: {textBox2.Text}, Name: {textBox3.Text},Phone :{textBox4.Text}";
                }


            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3= new Form3();
            f3.ShowDialog();
            this.Show();
        }
    }
}
