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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDashBord_Click(object sender, EventArgs e)
        {
            panelMini.Height = btnDashBord.Height;
            panelMini.Top = btnDashBord.Top;
            dashBord1.BringToFront();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            panelMini.Height = btnProduct.Height;
            panelMini.Top = btnProduct.Top;
            product1.BringToFront();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            panelMini.Height = btnCustomer.Height;
            panelMini.Top = btnCustomer.Top;
           customer1.BringToFront();
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            panelMini.Height = btnCreateBill.Height;
            panelMini.Top = btnCreateBill.Top;
            bill1.BringToFront();
        }

        private void btnBillDatas_Click(object sender, EventArgs e)
        {
            panelMini.Height = btnBillDatas.Height;
            panelMini.Top = btnBillDatas.Top;
           billData1.BringToFront();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            panelMini.Height = btnAbout.Height;
            panelMini.Top = btnAbout.Top;
            developerInfo1.BringToFront();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string msg1 = "Conform to Exit this System";
            string msg2 = "LOGOUT";
            MessageBoxButtons btn = MessageBoxButtons.OKCancel;
            DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Information);
            this.Hide();
            LogIn ob = new LogIn();
            ob.Show();
        }

        private void btnExcelSheet_Click(object sender, EventArgs e)
        {
            panelMini.Height = btnBillDatas.Height;
            panelMini.Top = btnBillDatas.Top;
           excelsheet1.BringToFront();
        }
    }
}
