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
    public partial class frmTBuy : Form
    {
        public frmTBuy()
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
            da = new SqlDataAdapter("Select transactionBuy_id as Id, quantity as Quantity, producer_id as Producer from transactionBuy", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        public void Item2()
        {
            baglanti = new SqlConnection("Data Source=MGY;Initial Catalog=InventoryDatabase;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("Select producer_id as Producer, city as City, i.name from producer as p Inner Join Item as i On p.producer_id=i.item_id ", baglanti);
            DataTable tablo2 = new DataTable();
            da.Fill(tablo2);
            dataGridView2.DataSource = tablo2;
            baglanti.Close();
        }
        private void frmTBuy_Load(object sender, EventArgs e)
        {
            ItemBul();
            Item2();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtquantity.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtpid.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO transactionBuy (quantity,producer_id) VALUES (@quantity, @producer_id)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@quantity", txtquantity.Text);
            komut.Parameters.AddWithValue("@producer_id", txtpid.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            ItemBul();
            MessageBox.Show("Added..");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sorgu = "Delete From transactionBuy Where transactionBuy_id=@transactionBuy_id";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@transactionBuy_id", Convert.ToInt32(txtid.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            ItemBul();
            MessageBox.Show("Deleted..");
        }

        private void bntUpdate_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE transactionBuy SET quantity=@quantity, producer_id=@producer_id WHERE transactionBuy_id=@transactionBuy_id";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@transactionBuy_id", Convert.ToInt32(txtid.Text));
            komut.Parameters.AddWithValue("@quantity", txtquantity.Text);
            komut.Parameters.AddWithValue("@producer_id", txtpid.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            ItemBul();
            MessageBox.Show("Updated..");
        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
