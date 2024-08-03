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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace animal_adoption
{
    public partial class Form2 : Form
    {
        public static String s = " ";
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Documents\AnimalAdop.mdf;Integrated Security=True;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text == " " || textBox2.Text == " ")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString() == "Admin")
                {
                    Con.Open();
                    string querry = "Select * from AdminTbl where Username = '" + textBox1.Text + "'Password='" + textBox2.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(querry, Con);

                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        //Admin Home form
                    }

                }
                else if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString() == "Staff")
                {
                    string querry = "Select * from StaffTbl where Username = '" + textBox1.Text + "'Password='" + textBox2.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(querry, Con);

                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        //Staff Home form
                    }
                }
                else if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString() == "Customer")
                {
                   
                    try
                    {
                        s = $"User: {textBox1.Text}, Pass: {textBox2.Text}";
                        string querry = "Select * from SignTbl where Un = '" + textBox1.Text + "'and Ps='" + textBox2.Text + "'";
                        SqlDataAdapter sda = new SqlDataAdapter(querry, Con);

                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            Form3 f3 = new Form3();
                            f3.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Inavalid details", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                        }
                    }
                    catch
                    {
                        MessageBox.Show("error");
                    }
                    finally
                    {
                        Con.Close();
                    }

                }
                else
                {
                    MessageBox.Show(" Select User ");
                }

            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !checkBox1.Checked;
        }
    }
}
