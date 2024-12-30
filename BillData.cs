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
    public partial class BillData : UserControl
    {
        public BillData()
        {
            InitializeComponent();
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbType.Text == "Name")
            {
                try
                {
                    lblName.Visible = true;
                    cbData.Visible = true;
                    lblMobno.Visible = false;
                    cbData.Items.Clear();
                    string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                    SqlConnection con = new SqlConnection(constring);
                    //DataTable donater = new DataTable();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select custname from tbl_Customer", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        cbData.Items.Add(dr[0].ToString());
                    }
                   
                   
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                try
                {
                    lblName.Visible = false;
                    cbData.Visible = true;
                    lblMobno.Visible = true;
                    cbData.Items.Clear();
                    string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                    SqlConnection con = new SqlConnection(constring);
                    //DataTable donater = new DataTable();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select mobno from tbl_Customer", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        cbData.Items.Add(dr[0].ToString());
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (lblName.Visible == false && lblMobno.Visible == false)
            {
               

                    string msg1 = "Please Select Search Type";
                    string msg2 = "Billing";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    cbType.Focus();
                    return;
                
            }
            else
            {
                try
                {

                    string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                    SqlConnection con = new SqlConnection(constring);
                    string sql = "select ID,saleid,cid,date from Sale_Product where date between'" + dateTimePicker1.Text + "'and'" + dateTimePicker2.Text + "' and cid='" + lblID.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, con);

                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    //  SqlCommand cmd = new SqlCommand(sql, con);
                    int x = cmd.ExecuteNonQuery();
                    SqlDataReader dr = cmd.ExecuteReader();


                    if (dr.Read())
                    {
                        lblID.Text = dr["cid"].ToString();
                        lblSID.Text = dr["saleid"].ToString();



                    }
                    else
                    {
                        MessageBox.Show("Data not Availebel");


                    }
                    if (lbligst.Text == "0")
                    {
                        BillPrintWithOutIGST();
                    }
                    else
                    {
                        BillPrintWithIGST();
                    }
                    con.Close();
                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
           /* try
            {
              
                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);
                DataTable donater = new DataTable();
                con.Open();

               
                SqlDataAdapter sda = new SqlDataAdapter("select ID,saleid,cid,date from Sale_Product where date between'" + dateTimePicker1.Text + "'and'" + dateTimePicker2.Text + "' and cid='"+lblID.Text+"'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewData.DataSource = dt;
                con.Close();
                dataGridViewData.Visible = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            lblDate.Visible = true;
            lblto.Visible = true;
            dateTimePicker1.Visible = true;
            dateTimePicker2.Visible = true;*/
        }
        public void NameData()
        {
            try
            {
                lblDate.Visible = true;
                dateTimePicker1.Visible = true;
                dateTimePicker2.Visible = true;
                if (cbType.Text == "Name")
                {
                    string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                    SqlConnection con = new SqlConnection(constring);
                    //DataTable donater = new DataTable();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select cid from tbl_Customer where custname='" + cbData.Text + "'", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        lblID.Text = dr[0].ToString();
                    }
                    con.Close();
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("select igst from Sale_Product where cid='" + lblID.Text + "'", con);
                    SqlDataReader dr1 = cmd1.ExecuteReader();
                    while (dr1.Read())
                    {
                        lbligst.Text = dr1["igst"].ToString();
                    }
                    con.Close();
                   
                }
                else
                {
                    lblDate.Visible = true;
                    dateTimePicker1.Visible = true;
                    dateTimePicker2.Visible = true;
                
                    
                        string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                        SqlConnection con = new SqlConnection(constring);
                        //DataTable donater = new DataTable();
                        con.Open();
                        SqlCommand cmd = new SqlCommand("select cid from tbl_Customer where mobno='" + cbData.Text + "'", con);
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            lblID.Text = dr[0].ToString();
                        }
                        con.Close();
                        con.Open();
                        SqlCommand cmd1 = new SqlCommand("select igst from Sale_Product where cid='" + lblID.Text + "'", con);
                        SqlDataReader dr1 = cmd1.ExecuteReader();
                        while (dr1.Read())
                        {
                            lbligst.Text = dr1["igst"].ToString();
                        }
                        con.Close();
                    
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void cbData_SelectedIndexChanged(object sender, EventArgs e)
        {
            NameData();
            lblDate.Visible = true;
            lblto.Visible = true;
            dateTimePicker1.Visible = true;
            dateTimePicker2.Visible = true;
            btnSearch.Visible = true;

        }
        string sid;
        private void dataGridViewData_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lblSID.Text = dataGridViewData.Rows[e.RowIndex].Cells[1].Value.ToString();
            lblID.Text=dataGridViewData.Rows[e.RowIndex].Cells[2].Value.ToString();
           /* string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
            SqlConnection con = new SqlConnection(constring);
            //DataTable donater = new DataTable();
            con.Open();
            SqlCommand cmd = new SqlCommand("select custname,mobno from tbl_Customer where cid='" + lblID.Text + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtName.Text = dr["custname"].ToString();
                txtMobno.Text = dr["mobno"].ToString();
            }
            con.Close();
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select saleid from Sale_Product where cid='" + lblID.Text + "'", con);
            SqlDataReader dr1 = cmd.ExecuteReader();
            while (dr1.Read())
            {
               sid = dr1["saleid"].ToString();
            }
            con.Close();

            con.Open();
            SqlCommand cmd2 = new SqlCommand("select total from Sale where ID='" + sid + "'", con);
            SqlDataReader dr2 = cmd.ExecuteReader();
            while (dr2.Read())
            {
                txtTotal.Text = dr2["total"].ToString();
            }
            con.Close();*/
            btnPrintBill.Visible = true;
        }

        private void btnPrintBill_Click(object sender, EventArgs e)
        {
            if (lblSID.Text == "")
            {
                string msg1 = "Please Select Data";
                string msg2 = "Billing";
                MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                
                return;
            }
            if (lbligst.Text == "0")
            {
                BillPrintWithOutIGST();
            }
            else
            {
                BillPrintWithIGST();
            }

        }
        public void BillPrintWithIGST()
        {
            try
            {
                crystalReportViewer1.Visible = true;
                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);

                con.Open();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select * from Sale where ID='" + lblSID.Text + "'", con);
                // SqlCommand cmd = new SqlCommand("select * from Sale where ID='15'", con);
                SqlDataAdapter dr = new SqlDataAdapter(cmd);
                dr.Fill(dt);

                DataTable dt1 = new DataTable();
                SqlCommand cmd1 = new SqlCommand("select * from Sale_Product where saleid='" + lblSID.Text + "'", con);
                //SqlCommand cmd1 = new SqlCommand("select * from Sale_Product where saleid='15'", con);
                dr = new SqlDataAdapter(cmd1);
                dr.Fill(dt1);

                DataTable dt2 = new DataTable();
                SqlCommand cmd2 = new SqlCommand("select * from tbl_Customer where cid='" + lblID.Text + "'", con);
                //SqlCommand cmd2 = new SqlCommand("select * from tbl_Customer where cid='1'", con);
                dr = new SqlDataAdapter(cmd2);
                dr.Fill(dt2);
                con.Close();

                BillReportWithIGST cr = new BillReportWithIGST();
                cr.Database.Tables["Sale"].SetDataSource(dt);
                cr.Database.Tables["Sale_Product"].SetDataSource(dt1);
                cr.Database.Tables["tbl_Customer"].SetDataSource(dt2);
                this.crystalReportViewer1.ReportSource = cr;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void BillPrintWithOutIGST()
        {
            try
            {
                crystalReportViewer1.Visible = true;
                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);

                con.Open();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select * from Sale where ID='" + lblSID.Text + "'", con);
                // SqlCommand cmd = new SqlCommand("select * from Sale where ID='15'", con);
                SqlDataAdapter dr = new SqlDataAdapter(cmd);
                dr.Fill(dt);

                DataTable dt1 = new DataTable();
                SqlCommand cmd1 = new SqlCommand("select * from Sale_Product where saleid='" + lblSID.Text + "'", con);
                //SqlCommand cmd1 = new SqlCommand("select * from Sale_Product where saleid='15'", con);
                dr = new SqlDataAdapter(cmd1);
                dr.Fill(dt1);

                DataTable dt2 = new DataTable();
                SqlCommand cmd2 = new SqlCommand("select * from tbl_Customer where cid='" + lblID.Text + "'", con);
                //SqlCommand cmd2 = new SqlCommand("select * from tbl_Customer where cid='1'", con);
                dr = new SqlDataAdapter(cmd2);
                dr.Fill(dt2);
                con.Close();

                BillReport cr = new BillReport();
                cr.Database.Tables["Sale"].SetDataSource(dt);
                cr.Database.Tables["Sale_Product"].SetDataSource(dt1);
                cr.Database.Tables["tbl_Customer"].SetDataSource(dt2);
                this.crystalReportViewer1.ReportSource = cr;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            try
            {

                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);
                DataTable donater = new DataTable();
                con.Open();


                SqlDataAdapter sda = new SqlDataAdapter("select ID,saleid,cid,date from Sale_Product", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewData.DataSource = dt;
                con.Close();
                dataGridViewData.Visible = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }
        private int rowIndex = 0;
        private void dataGridViewData_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                this.dataGridViewData.Rows[e.RowIndex].Selected = true;

                this.rowIndex = e.RowIndex;

                this.dataGridViewData.CurrentCell = this.dataGridViewData.Rows[e.RowIndex].Cells[1];

                this.contextMenuStrip1.Show(this.dataGridViewData, e.Location);

                contextMenuStrip1.Show(Cursor.Position);

            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void dataGridViewData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (lblID.Text == "")
                {
                    string msg1 = "Please Select Data";
                    string msg2 = "Add Customer";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                   
                    return;
                }
                if (lblSID.Text == "")
                {
                    string msg1 = "Please Select Data";
                    string msg2 = "Add Customer";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);

                    return;
                }
                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);

                string sql = "delete Sale_Product where cid=@cid and saleid=@saleid";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@cid", lblID.Text);
                cmd.Parameters.AddWithValue("@saleid", lblSID.Text);
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                int x = cmd.ExecuteNonQuery();
                con.Close();
                string sql1 = "delete Sale where ID=@ID";
                SqlCommand cmd1 = new SqlCommand(sql1, con);
                
                cmd1.Parameters.AddWithValue("@ID", lblSID.Text);
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                int x1 = cmd1.ExecuteNonQuery();
                con.Close();

                string sql2 = "delete ExcelSheet where bid=@bid";
                SqlCommand cmd2 = new SqlCommand(sql2, con);

                cmd2.Parameters.AddWithValue("@bid", lblSID.Text);
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                int x2 = cmd2.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(x2.ToString() + "Record Deleted");

                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
