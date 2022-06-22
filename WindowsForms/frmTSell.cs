using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsForms
{
    public partial class frmTSell : Form
    {
        public frmTSell()
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
            da = new SqlDataAdapter("Select* from transactionSell ", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            
            baglanti.Close();
        }
        public void Item2()
        {
            baglanti = new SqlConnection("Data Source=MGY;Initial Catalog=InventoryDatabase;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("Select company_id as id, name as Name From company", baglanti);
            DataTable tablo2 = new DataTable();
            da.Fill(tablo2);
            dataGridView2.DataSource = tablo2;
            baglanti.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO transactionSell (stock_id, quantity,company_id) VALUES (@stock_id, @quantity, @company_id)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@stock_id", txtstockid.Text);
            komut.Parameters.AddWithValue("@quantity", txtquantity.Text);
            komut.Parameters.AddWithValue("@company_id", txtcompany.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            ItemBul();
            MessageBox.Show("Added..");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sorgu = "Delete From transactionSell Where TransactionSell_id=@TransactionSell_id ";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@TransactionSell_id", Convert.ToInt32(txtid.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            ItemBul();
            MessageBox.Show("Deleted..");
        }

        private void bntUpdate_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE transactionSell SET stock_id=@stock_id, quantity=@quantity, company_id=@company_id WHERE TransactionSell_id=@TransactionSell_id";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@TransactionSell_id", Convert.ToInt32(txtid.Text));
            komut.Parameters.AddWithValue("@stock_id", txtstockid.Text);
            komut.Parameters.AddWithValue("@quantity", txtquantity.Text);
            komut.Parameters.AddWithValue("@company_id", txtcompany.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            ItemBul();
            MessageBox.Show("Updated..");
        }

        private void frmTSell_Load(object sender, EventArgs e)
        {
            ItemBul();
            Item2();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtstockid.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtquantity.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtcompany.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
