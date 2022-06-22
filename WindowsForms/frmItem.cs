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
    public partial class frmItem : Form
    {
        public frmItem()
        {
            InitializeComponent();
        }
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        public void ItemBul()
        {
            baglanti = new SqlConnection("Data Source=MGY;Initial Catalog=InventoryDatabase;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("Select * from Item", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        public void Item2()
        {
            baglanti = new SqlConnection("Data Source=MGY;Initial Catalog=InventoryDatabase;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("Select * from category", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView2.DataSource = tablo;
            baglanti.Close();
        }
        private void frmItem_Load(object sender, EventArgs e)
        {
            ItemBul();
            Item2();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO Item (name,price,category_id, stock_id) VALUES (@name, @price, @category_id , @stock_id)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@stock_id", txtstockid.Text);
            komut.Parameters.AddWithValue("@name", txtname.Text);
            komut.Parameters.AddWithValue("@price", txtprice.Text);
            komut.Parameters.AddWithValue("@category_id", txtcatid.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            ItemBul();
            MessageBox.Show("Added..");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sorgu = "Delete From Item Where item_id=@item_id";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@item_id", Convert.ToInt32(txtid.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            ItemBul();
            MessageBox.Show("Deleted..");
           
        }

        

        private void bntUpdate_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE Item SET name=@name, price=@price, category_id=@category_id, stock_id=@stock_id WHERE item_id=@item_id";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@item_id", Convert.ToInt32(txtid.Text));
            komut.Parameters.AddWithValue("@name", txtname.Text);
            komut.Parameters.AddWithValue("@price", txtprice.Text);
            komut.Parameters.AddWithValue("@category_id", txtcatid.Text);
            komut.Parameters.AddWithValue("@stock_id", txtstockid.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            ItemBul();
            MessageBox.Show("Updated..");

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtprice.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtcatid.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtstockid.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtstockid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcatid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) => Close();

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
