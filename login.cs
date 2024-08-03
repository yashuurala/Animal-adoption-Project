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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Documents\AnimalAdop.mdf;Integrated Security=True;Connect Timeout=30");
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                

                string querry = "Select * from EmployeeTbl where EmpName = '" + EmpNameTb.Text + "'and EmpPass='" + EmpPassTb.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, Con);

                DataTable dt = new DataTable();// creates a new DataTable object to hold the results of the SQL query
                sda.Fill(dt);//executes the SQL query and fills the DataTable dt with the results returned by the database
                if (dt.Rows.Count > 0)
                {
                    home n = new home();
                    n.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Inavalid details", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    EmpNameTb.Clear();
                    EmpPassTb.Clear();
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
     }
}


     
