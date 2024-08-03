using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace animal_adoption
{
    public partial class Form3 : Form
    {
        public static string ans1 = " ";
        public static string ans2 = " ";
        public static string ans3 = " ";
        public Form3()
        {
            InitializeComponent();
            label1.Text = " ";
            label1.Text = Form1.concStringDON1;
            label2.Text = " ";
            label2.Text = Form1.concStringDON2;
            label3.Text = " ";
            label3.Text = Form1.concStringDON3;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {
            ans1 = "ques" + Form1.concStringDON1 + "ans" + textBox1.Text;
           
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ans2 = "ques" + Form1.concStringDON2 + "ans" + textBox2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ans3 = "ques" + Form1.concStringDON3 + "ans" + textBox3.Text;

        }
    }
}
