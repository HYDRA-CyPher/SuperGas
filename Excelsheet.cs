using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace MainFile
{
    public partial class Excelsheet : UserControl
    {
        public Excelsheet()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                crystalReportViewer1.Visible = true;
                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);

                con.Open();
                DataTable dt1 = new DataTable();
                SqlCommand cmd1 = new SqlCommand("select * from Sale", con);
                // SqlCommand cmd = new SqlCommand("select * from Sale where ID='15'", con);
                SqlDataAdapter dr1 = new SqlDataAdapter(cmd1);
                dr1.Fill(dt1);

                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select * from ExcelSheet where date between'" + dateTimePicker1.Text + "'and'" + dateTimePicker2.Text + "'", con);
                // SqlCommand cmd = new SqlCommand("select * from Sale where ID='15'", con);
                SqlDataAdapter dr = new SqlDataAdapter(cmd);
                dr.Fill(dt);



                Sheet cr = new Sheet();
                cr.Database.Tables["Sale"].SetDataSource(dt1);
                cr.Database.Tables["Sale_Product"].SetDataSource(dt);
                cr.Database.Tables["tbl_Customer"].SetDataSource(dt);
                cr.Database.Tables["ExcelSheet"].SetDataSource(dt);
                this.crystalReportViewer1.ReportSource = cr;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                crystalReportViewer1.Visible = true;
                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);

                con.Open();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select * from ExcelSheet", con);
                // SqlCommand cmd = new SqlCommand("select * from Sale where ID='15'", con);
                SqlDataAdapter dr = new SqlDataAdapter(cmd);
                dr.Fill(dt);



                Sheet cr = new Sheet();
                cr.Database.Tables["Sale"].SetDataSource(dt);
                cr.Database.Tables["Sale_Product"].SetDataSource(dt);
                cr.Database.Tables["tbl_Customer"].SetDataSource(dt);
                cr.Database.Tables["ExcelSheet"].SetDataSource(dt);
                this.crystalReportViewer1.ReportSource = cr;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnPrintBill_Click(object sender, EventArgs e)
        {
           
        }
    }
}
