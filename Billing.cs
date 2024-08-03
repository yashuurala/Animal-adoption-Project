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
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
            GetCustomers();
            DisplayProduct();
        }
        int Key = 0, Stock = 0;
        private void Reset()
        {
            PrNameTb.Text = " ";
            QtyTb.Text = " ";
            Stock = 0;
            Key = 0;
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Documents\AnimalAdop.mdf;Integrated Security=True;Connect Timeout=30");
        private void GetCustomers()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select CustId from CustomerTbl", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();//This line executes the SQL command defined in cmd and initializes the Rdr object with the results.
            DataTable dt = new DataTable();
            dt.Columns.Add("CustId", typeof(int));//adds a column named CustId to the DataTable dt
            dt.Load(Rdr);
            CustIdCb.ValueMember = "CustId";//specifies the value of the ComboBox items that corresponds to the CustId column in the DataTable
            CustIdCb.DataSource = dt;//binds the data in the DataTable to the ComboBox, populating it with the CustId values retrieved from the database.
            Con.Close();
        }
        private void DisplayProduct()
        {
            Con.Open();
            string Query = "Select * from ProductTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            var ds = new DataSet();
            sda.Fill(ds);
            ProductsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void GetCustName()
        {
            Con.Open();
            string Query = "Select * from CustomerTbl where CustId=" + CustIdCb.SelectedValue.ToString();
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)//iterates over each DataRow in the DataTable dt.
            {
                CustNameTb.Text = dr["CustName"].ToString();//assign the value of the "CustName" column of each DataRow (dr) to the Text property of the CustNameTb
            }
            Con.Close();
        }
        private void UpdateStock()
        {
            try
            {
                int NewQty = Stock - Convert.ToInt32(QtyTb.Text);
                Con.Open();
                SqlCommand cmd = new SqlCommand("Update ProductTbl set PrtQty=@PQ where PrId=@PKey", Con);
                cmd.Parameters.AddWithValue("@PQ", NewQty);
                cmd.Parameters.AddWithValue("@PKey", Key);
                cmd.ExecuteNonQuery();
                Con.Close();
                DisplayProduct();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        int n = 0, GrdTotal = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            if (QtyTb.Text == " " || Convert.ToInt32(QtyTb.Text) > Stock)
            {
                MessageBox.Show("No Enough in House");
            }
            else if (QtyTb.Text == " " || Key == 0)
            {
                MessageBox.Show("Missing Info ");
            }
            else
            {
                int total = Convert.ToInt32(QtyTb.Text) * Convert.ToInt32(PrPriceTb.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(BillDGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = PrNameTb.Text;
                newRow.Cells[2].Value = QtyTb.Text;
                newRow.Cells[3].Value = PrPriceTb.Text;
                newRow.Cells[4].Value = total;
                BillDGV.Rows.Add(newRow);
                n++;
                TotalLbl.Text = "Rs" + GrdTotal;
                UpdateStock();
                Reset();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void ProductDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PrNameTb.Text = ProductsDGV.SelectedRows[0].Cells[1].Value.ToString();
            Stock = Convert.ToInt32(ProductsDGV.SelectedRows[0].Cells[3].Value.ToString());
            PrPriceTb.Text = ProductsDGV.SelectedRows[0].Cells[4].Value.ToString();
            if (PrNameTb.Text == " ")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(ProductsDGV.SelectedRows[0].Cells[0].Value.ToString());
            }

        }

        private void Billing_Load(object sender, EventArgs e)
        {

        }
        private void insertBill()
        {

        }
        string prodname;
        private void button1_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
        int prodid, prodqty, prodprice, tottal, pos = 60;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("MyCodespace animal_adoption", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(80));
            e.Graphics.DrawString("ID PRODUCT PRICE QUANTITY TOTAL", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Red, new Point(26, 40));
            foreach (DataGridViewRow row in BillDGV.Rows)
            {
                prodid = Convert.ToInt32(row.Cells["Column1"].Value);
                prodname = " " + row.Cells["Column2"].Value;
                prodprice = Convert.ToInt32(row.Cells["Column3"].Value);
                prodqty = Convert.ToInt32(row.Cells["Column4"].Value);
                tottal = Convert.ToInt32(row.Cells["Column5"].Value);
                e.Graphics.DrawString(" " + prodid, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Red, new Point(26, pos));
                e.Graphics.DrawString(" " + prodname, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Red, new Point(45, pos));
                e.Graphics.DrawString(" " + prodprice, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Red, new Point(120, pos));
                e.Graphics.DrawString(" " + prodqty, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Red, new Point(170, pos));
                e.Graphics.DrawString(" " + tottal, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Red, new Point(235, pos));

            }
            e.Graphics.DrawString("Grand Total Rs " + GrdTotal, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Crimson, new Point(50, pos + 50));
            e.Graphics.DrawString("*****************Animal_Adoption*********************", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Crimson, new Point(10, pos + 85));
            BillDGV.Rows.Clear();
            BillDGV.Refresh();
            pos = 100;
            GrdTotal = 0;
            n = 0;
        }

        private void label3_Click(object sender, EventArgs e)
        {

            Products Obj = new Products();
            Obj.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

            employee Obj = new employee();
            Obj.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

            Customer Obj = new Customer();
            Obj.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

            home Obj = new home();
            Obj.Show();
            this.Hide();
        }
    }
}
