using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void FrmGetir(Form frm)
        {
            panel1.Controls.Clear();
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(frm);
            frm.Show();
        }
        private void btn_Click(object sender, EventArgs e)
        {
            frmItem item = new frmItem();
            FrmGetir(item);
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            frmTBuy item = new frmTBuy();
            FrmGetir(item);
        }

        private void btntt_Click(object sender, EventArgs e)
        {
            frmTSell item = new frmTSell();
            FrmGetir(item);
        }

        private void btnReS_Click(object sender, EventArgs e)
        {
            frmReceiptSell item = new frmReceiptSell();
            FrmGetir(item);
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            frmReceiptBuy item = new frmReceiptBuy();
            FrmGetir(item);
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmList list = new FrmList();
            FrmGetir(list);
        }

        private void btnbox_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
