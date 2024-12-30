using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MainFile
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUName.Text == "super gas" && txtPass.Text == "8149179070")
            {
                string msg1 = "Successful Done!!!";
                string msg2 = "LogIn";
                MessageBoxButtons btn = MessageBoxButtons.OK;
                DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Information);
                Form1 ob = new Form1();
                ob.Show();
                this.Hide();
            }
            else
            {
                string msg1 = "Please Check User Name and Password!!!";
                string msg2 = "LogIn";
                MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Information);
                txtUName.Text = "";
                txtPass.Text = "";
                txtUName.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg1 = "Conform to Exit this System";
            string msg2 = "LOGOUT";
            MessageBoxButtons btn = MessageBoxButtons.OKCancel;
            DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
