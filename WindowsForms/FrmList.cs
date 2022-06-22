using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class FrmList : Form
    {
        public FrmList()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand komut;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmList_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=MGY;Initial Catalog=InventoryDatabase;Integrated Security=True");
            con.Open();
            da = new SqlDataAdapter("Select i.name, c.name as category, i.price from Item i inner join category c on i.category_id=c.category_id order by i.item_id", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Items");
            dataGridView1.DataSource = ds.Tables["Items"];
            con.Close();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            con.Open();
            komut = new SqlCommand("Select * From Item where Name like '%" + textBox1.Text + "%'", con);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
    }
}
