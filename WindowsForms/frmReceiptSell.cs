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
    public partial class frmReceiptSell : Form
    {
        public frmReceiptSell()
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
            da = new SqlDataAdapter("Select SellReceipt_id as id, transactionSell_id as Sell_id, date as Date from ReceiptSell", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        public void Item2()
        {
            baglanti = new SqlConnection("Data Source=MGY;Initial Catalog=InventoryDatabase;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("Select TransactionSell_id as Sell_id , quantity as Quantity, company.name as Name FROM transactionSell INNER JOIN company ON transactionSell.TransactionSell_id=company.company_id ", baglanti);
            DataTable tablo2 = new DataTable();
            da.Fill(tablo2);
            dataGridView2.DataSource = tablo2;
            baglanti.Close();
        }
        private void frmReceiptSell_Load(object sender, EventArgs e)
        {
            ItemBul();
            Item2();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO ReceiptSell (transactionSell_id,date) VALUES (@transactionSell_id , @date)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@transactionSell_id", txttid.Text);
            komut.Parameters.AddWithValue("@date", dtime.Value);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            ItemBul();
            MessageBox.Show("Added..");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sorgu = "Delete From ReceiptSell Where SellReceipt_id=@SellReceipt_id";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@SellReceipt_id", Convert.ToInt32(txtid.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            ItemBul();
            MessageBox.Show("Deleted..");
        }

        private void bntUpdate_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE ReceiptSell SET TransactionSell_id=@TransactionSell_id, date=@date WHERE SellReceipt_id=@SellReceipt_id";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@SellReceipt_id", Convert.ToInt32(txtid.Text));
            komut.Parameters.AddWithValue("@TransactionSell_id", txttid.Text);
            komut.Parameters.AddWithValue("@date", dtime.Value);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            ItemBul();
            MessageBox.Show("Updated..");
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

    }
}
