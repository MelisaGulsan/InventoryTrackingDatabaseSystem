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
    public partial class frmReceiptBuy : Form
    {
        public frmReceiptBuy()
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
            da = new SqlDataAdapter("Select BuyReceipt_id as id, transactionBuy_id as Buy_id, date as Date from ReceiptBuy", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        public void Item2()
        {
            baglanti = new SqlConnection("Data Source=MGY;Initial Catalog=InventoryDatabase;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("Select transactionBuy_id as Buy_id, quantity as Quantity, producer.city as City from transactionBuy LEFT JOIN producer ON transactionBuy.producer_id=producer.producer_id ORDER BY transactionBuy_id", baglanti);
            DataTable tablo2 = new DataTable();
            da.Fill(tablo2);
            dataGridView2.DataSource = tablo2;
            baglanti.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO ReceiptBuy (transactionBuy_id,date) VALUES (@transactionBuy_id , @date)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@transactionBuy_id", txttid.Text);
            komut.Parameters.AddWithValue("@date", dtime.Value);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            ItemBul();
            MessageBox.Show("Added..");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sorgu = "Delete From ReceiptBuy Where BuyReceipt_id=@BuyReceipt_id";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@BuyReceipt_id", Convert.ToInt32(txtid.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            ItemBul();
            MessageBox.Show("Deleted..");
        }

        private void bntUpdate_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE ReceiptBuy SET transactionBuy_id=@transactionBuy_id, date=@date WHERE BuyReceipt_id=@BuyReceipt_id";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@BuyReceipt_id", Convert.ToInt32(txtid.Text));
            komut.Parameters.AddWithValue("@transactionBuy_id",txttid.Text);
            komut.Parameters.AddWithValue("@date", dtime.Value);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            ItemBul();
            MessageBox.Show("Updated..");
        }

        private void frmReceiptBuy_Load(object sender, EventArgs e)
        {
            ItemBul();
            Item2();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txttid.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dtime.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void txtstockid_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            
        }
    }
}
