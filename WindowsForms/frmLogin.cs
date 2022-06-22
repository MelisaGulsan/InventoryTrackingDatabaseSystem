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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            Init_Data();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUserNam.Text=="admin" && txtPass.Text=="123")
            {
                Save_Data();
                Main frm = new Main();
                this.Hide();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("UserName or Password warning!","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void Init_Data()
        {
            if (Properties.Settings.Default.UserName!=string.Empty)
            {
                if (Properties.Settings.Default.Remember==true)
                {
                    txtUserNam.Text = Properties.Settings.Default.UserName;
                    txtPass.Text = Properties.Settings.Default.Password;
                    checkBox1.Checked = true;
                }
                else
                {
                    txtUserNam.Text = Properties.Settings.Default.UserName;
                }
            }
        }
        private void Save_Data()
        {
            if (checkBox1.Checked)
            {
                Properties.Settings.Default.UserName = txtUserNam.Text;
                Properties.Settings.Default.Password = txtPass.Text;
                Properties.Settings.Default.Remember = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Remember = false;
                Properties.Settings.Default.Save();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtUserNam_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
