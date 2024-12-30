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
using MainFile;

namespace SuperGas
{
    public partial class Bill : UserControl
    {
        public Bill()
        {
            InitializeComponent();
            //CustData();
            //ProData();
        }
        public void CustData()
        {
            try
            {
                cbCustName.Items.Clear();
                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);
                //DataTable donater = new DataTable();
                con.Open();
                SqlCommand cmd = new SqlCommand("select custname from tbl_Customer ", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbCustName.Items.Add(dr[0].ToString());
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void ProData()
        {
            try
            {
                cbProduct.Items.Clear();
                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);
                //DataTable donater = new DataTable();
                con.Open();
                SqlCommand cmd = new SqlCommand("select name from tbl_Product ", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbProduct.Items.Add(dr[0].ToString());
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnCustRefresh_Click(object sender, EventArgs e)
        {
            CustData();
        }

        private void btnProRefresh_Click(object sender, EventArgs e)
        {
            ProData();
        }

        private void cbCustName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);
                string sql = "select * from tbl_Customer where custname='" + cbCustName.Text + "'";
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
                    lblCustID.Text = dr[0].ToString();
                    cbCustName.Text = dr[1].ToString();
                    txtcustmobno.Text = dr[2].ToString();
                    txtAddress.Text = dr[3].ToString();



                }
                else
                {
                    MessageBox.Show("Data not Availebel");


                }
                con.Close();
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);
                string sql = "select * from tbl_Product where name='" + cbProduct.Text + "'";
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
                    lblProID.Text = dr[0].ToString();
                    cbProduct.Text = dr[1].ToString();
                    txtPrice.Text = dr[2].ToString();
                    txtHSN.Text = dr[3].ToString();



                }
                else
                {
                    MessageBox.Show("Data not Availebel");


                }
                con.Close();
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAddToCard_Click(object sender, EventArgs e)
        {

            if (txtQty.Text == "")
            {
                string msg1 = "Please Insert Product quntity";
                string msg2 = "Billing";
                MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                txtQty.Focus();
                return;
            }
            if (cbBillType.Text == "With IGST")
            {
                int n = dataGridViewAddToCard.Rows.Add();
                dataGridViewAddToCard.Rows[n].Cells[0].Value = lblProID.Text;
                dataGridViewAddToCard.Rows[n].Cells[1].Value = cbProduct.Text;
                dataGridViewAddToCard.Rows[n].Cells[2].Value = txtPrice.Text;
                dataGridViewAddToCard.Rows[n].Cells[3].Value = txtQty.Text;
                dataGridViewAddToCard.Rows[n].Cells[5].Value = txtHSN.Text;

                int p, q, temp, total, cg, sg, ig, final;
                p = Convert.ToInt32(txtPrice.Text);
                q = Convert.ToInt32(txtQty.Text);

                temp = p * q;
                dataGridViewAddToCard.Rows[n].Cells[4].Value = temp.ToString();
                total = Convert.ToInt32(txtSubTotal.Text);
                total = total + temp;
                txtSubTotal.Text = total.ToString();
                cg = (total * 9) / 100;
                sg = (total * 9) / 100;
                ig = (total * 18) / 100;
                txtcgst.Text = cg.ToString();
                txtsgst.Text = sg.ToString();
                txtIGST.Text = ig.ToString();
                final = total + ig;
                txtFinalTotal.Text = final.ToString();

            }
            else
            {
                int n = dataGridViewAddToCard.Rows.Add();
                dataGridViewAddToCard.Rows[n].Cells[0].Value = lblProID.Text;
                dataGridViewAddToCard.Rows[n].Cells[1].Value = cbProduct.Text;
                dataGridViewAddToCard.Rows[n].Cells[2].Value = txtPrice.Text;
                dataGridViewAddToCard.Rows[n].Cells[3].Value = txtQty.Text;
                dataGridViewAddToCard.Rows[n].Cells[5].Value = txtHSN.Text;

                int p, q, temp, total, cg, sg, ig, final;
                p = Convert.ToInt32(txtPrice.Text);
                q = Convert.ToInt32(txtQty.Text);

                temp = p * q;
                dataGridViewAddToCard.Rows[n].Cells[4].Value = temp.ToString();
                total = Convert.ToInt32(txtSubTotal.Text);
                total = total + temp;
                txtSubTotal.Text = total.ToString();
                cg = (total * 9) / 100;
                sg = (total * 9) / 100;
                ig = (total * 18) / 100;
                txtcgst.Text = cg.ToString();
                txtsgst.Text = sg.ToString();
                txtIGST.Text = ig.ToString();
                final = total + cg + sg;

                txtFinalTotal.Text = final.ToString();
                
            }
        }
        

        private void dataGridViewAddToCard_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lblProID.Text = dataGridViewAddToCard.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbProduct.Text = dataGridViewAddToCard.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtQty.Text = dataGridViewAddToCard.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtPrice.Text = dataGridViewAddToCard.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtHSN.Text = dataGridViewAddToCard.Rows[e.RowIndex].Cells[5].Value.ToString();  
            
        }
        private int rowIndex = 0;
        private void dataGridViewAddToCard_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                this.dataGridViewAddToCard.Rows[e.RowIndex].Selected = true;

                this.rowIndex = e.RowIndex;

                this.dataGridViewAddToCard.CurrentCell = this.dataGridViewAddToCard.Rows[e.RowIndex].Cells[1];

                this.contextMenuStrip1.Show(this.dataGridViewAddToCard, e.Location);

                contextMenuStrip1.Show(Cursor.Position);

            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            if (!this.dataGridViewAddToCard.Rows[this.rowIndex].IsNewRow)
            {

                this.dataGridViewAddToCard.Rows.RemoveAt(this.rowIndex);
                int p, q, temp, total, cg, sg,ig, final;
                p = Convert.ToInt32(txtPrice.Text);
                q = Convert.ToInt32(txtQty.Text);
                temp = p * q;
                total = Convert.ToInt32(txtSubTotal.Text);
                total = total - temp;
                txtSubTotal.Text = total.ToString();
                cg = (total * 9) / 100;
                sg = (total * 9) / 100;
                ig = (total * 18) / 100;

                txtcgst.Text = cg.ToString();
                txtsgst.Text = sg.ToString();
                txtIGST.Text = ig.ToString();
                final = total + cg + sg;
                txtFinalTotal.Text = final.ToString();

            }
        }
        int lastid;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbBillType.Text == "With IGST")
            {
                    
                try
                {

                    string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                    SqlConnection con = new SqlConnection(constring);

                    con.Open();

                    SqlCommand cmd = new SqlCommand("insert into Sale(total)values(@total) select @@identity;", con);

                    cmd.Parameters.AddWithValue("@total", txtFinalTotal.Text);
                    lastid = int.Parse(cmd.ExecuteScalar().ToString());

                    string IName;
                    int price = 0;
                    int qty = 0;
                    int tot = 0;
                    int hsn = 0;
                    int cid = Convert.ToInt32((lblCustID.Text).ToString());
                    for (int row = 0; row < dataGridViewAddToCard.Rows.Count - 1; row++)
                    {
                        IName = dataGridViewAddToCard.Rows[row].Cells[1].Value.ToString();
                        price = Convert.ToInt32(dataGridViewAddToCard.Rows[row].Cells[2].Value.ToString());
                        qty = int.Parse(dataGridViewAddToCard.Rows[row].Cells[3].Value.ToString());
                        tot = int.Parse(dataGridViewAddToCard.Rows[row].Cells[4].Value.ToString());
                        hsn = int.Parse(dataGridViewAddToCard.Rows[row].Cells[5].Value.ToString());
                        SqlCommand cmd1 = new SqlCommand("insert into Sale_Product(saleid,cid,IName,price,qty,total,cgst,sgst,igst,date,hsn,transport)values(@saleid,@cid,@IName,@price,@qty,@total,@cgst,@sgst,@igst,@date,@hsn,@transport)", con);
                        cmd1.Parameters.AddWithValue("@saleid", lastid);
                        cmd1.Parameters.AddWithValue("@cid", cid);
                        cmd1.Parameters.AddWithValue("@IName", IName);
                        cmd1.Parameters.AddWithValue("@price", price);
                        cmd1.Parameters.AddWithValue("@qty", qty);
                        cmd1.Parameters.AddWithValue("@total", tot);
                        cmd1.Parameters.AddWithValue("@cgst", '0');
                        cmd1.Parameters.AddWithValue("@sgst", '0');
                        cmd1.Parameters.AddWithValue("@igst", txtIGST.Text);
                        cmd1.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));
                        cmd1.Parameters.AddWithValue("@hsn", hsn);
                        cmd1.Parameters.AddWithValue("@transport", txtTrasportation.Text);
                        cmd1.ExecuteNonQuery();
                    }


                    SqlCommand cmd2 = new SqlCommand("insert into ExcelSheet(date,subtotal,cgst,sgst,igst,total)values(@date,@subtotal,@cgst,@sgst,@igst,@total)", con);

                    cmd2.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));

                    cmd2.Parameters.AddWithValue("@subtotal", txtSubTotal.Text);
                    cmd2.Parameters.AddWithValue("@cgst", '0');
                    cmd2.Parameters.AddWithValue("@sgst", '0');
                    cmd2.Parameters.AddWithValue("@igst", txtIGST.Text);
                    cmd2.Parameters.AddWithValue("@total", txtFinalTotal.Text);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Record inserted");
                    /*BillPrint p = new BillPrint();
                     p.Saleid = lastid;
                     p.Cid = cid;
                     p.Show();*/



                    dataGridViewAddToCard.Rows.Clear();
                    con.Close();
                    NewInventory();
                    BillPrintWitIGST();

                }



                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else {
                try
                {

                    string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                    SqlConnection con = new SqlConnection(constring);

                    con.Open();

                    SqlCommand cmd = new SqlCommand("insert into Sale(total)values(@total) select @@identity;", con);

                    cmd.Parameters.AddWithValue("@total", txtFinalTotal.Text);
                    lastid = int.Parse(cmd.ExecuteScalar().ToString());

                    string IName;
                    int price = 0;
                    int qty = 0;
                    int tot = 0;
                    int hsn = 0;
                    int cid = Convert.ToInt32((lblCustID.Text).ToString());
                    for (int row = 0; row < dataGridViewAddToCard.Rows.Count - 1; row++)
                    {
                        IName = dataGridViewAddToCard.Rows[row].Cells[1].Value.ToString();
                        price = Convert.ToInt32(dataGridViewAddToCard.Rows[row].Cells[2].Value.ToString());
                        qty = int.Parse(dataGridViewAddToCard.Rows[row].Cells[3].Value.ToString());
                        tot = int.Parse(dataGridViewAddToCard.Rows[row].Cells[4].Value.ToString());
                        hsn = int.Parse(dataGridViewAddToCard.Rows[row].Cells[5].Value.ToString());
                        SqlCommand cmd1 = new SqlCommand("insert into Sale_Product(saleid,cid,IName,price,qty,total,cgst,sgst,igst,date,hsn,transport)values(@saleid,@cid,@IName,@price,@qty,@total,@cgst,@sgst,@igst,@date,@hsn,@transport)", con);
                        cmd1.Parameters.AddWithValue("@saleid", lastid);
                        cmd1.Parameters.AddWithValue("@cid", cid);
                        cmd1.Parameters.AddWithValue("@IName", IName);
                        cmd1.Parameters.AddWithValue("@price", price);
                        cmd1.Parameters.AddWithValue("@qty", qty);
                        cmd1.Parameters.AddWithValue("@total", tot);
                        cmd1.Parameters.AddWithValue("@cgst", txtcgst.Text);
                        cmd1.Parameters.AddWithValue("@sgst", txtsgst.Text);
                        cmd1.Parameters.AddWithValue("@igst", '0');
                        cmd1.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));
                        cmd1.Parameters.AddWithValue("@hsn", hsn);
                        cmd1.Parameters.AddWithValue("@transport", txtTrasportation.Text);
                        cmd1.ExecuteNonQuery();
                    }


                    SqlCommand cmd2 = new SqlCommand("insert into ExcelSheet(date,subtotal,cgst,sgst,igst,total)values(@date,@subtotal,@cgst,@sgst,@igst,@total)", con);

                    cmd2.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));

                    cmd2.Parameters.AddWithValue("@subtotal", txtSubTotal.Text);
                    cmd2.Parameters.AddWithValue("@cgst", txtcgst.Text);
                    cmd2.Parameters.AddWithValue("@sgst", txtsgst.Text);
                    cmd2.Parameters.AddWithValue("@igst", '0');
                    cmd2.Parameters.AddWithValue("@total", txtFinalTotal.Text);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Record inserted");
                    /*BillPrint p = new BillPrint();
                     p.Saleid = lastid;
                     p.Cid = cid;
                     p.Show();*/



                    dataGridViewAddToCard.Rows.Clear();
                    con.Close();
                    NewInventory();
                    BillPrintWithoutIGST();

                }



                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        public void BillPrintWithoutIGST()
        {
            try
            {
                crystalReportViewer1.Visible = true;
                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);

                con.Open();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select * from Sale where ID='" + lastid + "'", con);
                // SqlCommand cmd = new SqlCommand("select * from Sale where ID='15'", con);
                SqlDataAdapter dr = new SqlDataAdapter(cmd);
                dr.Fill(dt);

                DataTable dt1 = new DataTable();
                SqlCommand cmd1 = new SqlCommand("select * from Sale_Product where saleid='" + lastid + "'", con);
                //SqlCommand cmd1 = new SqlCommand("select * from Sale_Product where saleid='15'", con);
                dr = new SqlDataAdapter(cmd1);
                dr.Fill(dt1);

                DataTable dt2 = new DataTable();
                SqlCommand cmd2 = new SqlCommand("select * from tbl_Customer where cid='" + lblCustID.Text + "'", con);
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
        public void BillPrintWitIGST()
        {
            try
            {
                crystalReportViewer1.Visible = true;
                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);

                con.Open();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select * from Sale where ID='" + lastid + "'", con);
                // SqlCommand cmd = new SqlCommand("select * from Sale where ID='15'", con);
                SqlDataAdapter dr = new SqlDataAdapter(cmd);
                dr.Fill(dt);

                DataTable dt1 = new DataTable();
                SqlCommand cmd1 = new SqlCommand("select * from Sale_Product where saleid='" + lastid + "'", con);
                //SqlCommand cmd1 = new SqlCommand("select * from Sale_Product where saleid='15'", con);
                dr = new SqlDataAdapter(cmd1);
                dr.Fill(dt1);

                DataTable dt2 = new DataTable();
                SqlCommand cmd2 = new SqlCommand("select * from tbl_Customer where cid='" + lblCustID.Text + "'", con);
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

        public void NewInventory()
        {
            cbCustName.Text = "";
            txtcustmobno.Text = "";
            txtAddress.Text = "";
            cbProduct.Text = "";
            txtQty.Text = "";
            txtPrice.Text = "";
            txtHSN.Text = "";
            txtTrasportation.Text = "0";
            btnAddTC.Enabled = true;
            btnTCNo.Enabled = false;
            txtSubTotal.Text = "0";
            txtcgst.Text = "0";
            txtsgst.Text = "0";
            txtIGST.Text = "0";
           
            txtFinalTotal.Text = "0";
            dataGridViewAddToCard.Rows.Clear(); 
        }
        private void btnNewInventory_Click(object sender, EventArgs e)
        {
            NewInventory();
            crystalReportViewer1.Visible = false;
            btnAddTC.Enabled = true;
            txtTrasportation.ReadOnly = false;
            
        }

        private void txtQty_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtTrasportation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void s(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tc, f1, f2;
            tc = Convert.ToInt32(txtTrasportation.Text);
            f1 = Convert.ToInt32(txtSubTotal.Text);
            f2 = f1 + tc;
            txtSubTotal.Text = f2.ToString();
            btnAddTC.Enabled = false;
            txtTrasportation.ReadOnly = true;
            btnTCNo.Enabled = true;
        }

        private void txtTrasportation_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bill_Load(object sender, EventArgs e)
        {

        }

        private void deleteDataToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnIGST_Click(object sender, EventArgs e)
        {
           /* int ig, f1, f2;
            ig = Convert.ToInt32(txtIGST.Text);
            f1 = Convert.ToInt32(txtFinalTotal.Text);
            f2 = f1 + ig;
            txtFinalTotal.Text = f2.ToString();
            btnIGST.Enabled = false;
            txtIGST.ReadOnly = true;
            btnIGSTNo.Enabled = true;*/
        }

        private void btnTCNo_Click(object sender, EventArgs e)
        {

            int tc, f1, f2;
            tc = Convert.ToInt32(txtTrasportation.Text);
            f1 = Convert.ToInt32(txtSubTotal.Text);
            f2 = f1 - tc;
            txtSubTotal.Text = f2.ToString();
            btnAddTC.Enabled = true;
            txtTrasportation.ReadOnly = false;
            btnTCNo.Enabled = false;
            txtTrasportation.Text = "0";
        }

        private void btnIGSTNo_Click(object sender, EventArgs e)
        {
            /*int ig, f1, f2;
            ig = Convert.ToInt32(txtIGST.Text);
            f1 = Convert.ToInt32(txtFinalTotal.Text);
            f2 = f1 - ig;
            txtFinalTotal.Text = f2.ToString();
            btnIGST.Enabled = true;
            txtIGST.ReadOnly = false;
            btnIGSTNo.Enabled = false;*/
        }

        private void cbBillType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBillType.Text == "With IGST")
            {
                lbligst.Visible = true;
                txtIGST.Visible = true;
                lblcgst.Visible = false;
                txtcgst.Visible = false;
                lblsgst.Visible = false;
                txtsgst.Visible = false;
            }
            else {
                lbligst.Visible = false;
                txtIGST.Visible = false;
                lblcgst.Visible = true;
                txtcgst.Visible = true;
                lblsgst.Visible = true;
                txtsgst.Visible = true;
            }
           
        }
        int temp;
        private void txtSubTotal_TextChanged(object sender, EventArgs e)
        {
            if (cbBillType.Text == "With IGST")
            {
            int total, cg, sg, ig,final;
            total = Convert.ToInt32(txtSubTotal.Text);
           // total = total + temp;
            txtSubTotal.Text = total.ToString();
            cg = (total * 9) / 100;
            sg = (total * 9) / 100;
            ig = (total * 18) / 100;
            txtcgst.Text = cg.ToString();
            txtsgst.Text = sg.ToString();
            txtIGST.Text = ig.ToString();
            final = total + ig;
            txtFinalTotal.Text = final.ToString();
            }
        else{
            int total, cg, sg, ig, final;
            total = Convert.ToInt32(txtSubTotal.Text);
            total = total + temp;
            txtSubTotal.Text = total.ToString();
            cg = (total * 9) / 100;
            sg = (total * 9) / 100;
            ig = (total * 18) / 100;
            txtcgst.Text = cg.ToString();
            txtsgst.Text = sg.ToString();
            txtIGST.Text = ig.ToString();
            final = total + cg+sg;
            txtFinalTotal.Text = final.ToString();
         }
        }
    }
}
