using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace SuperGas
{
    public partial class Customer : UserControl
    {
        public Customer()
        {
            InitializeComponent();
           // LoadData();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
           
        }
        public void ClearData()
        {
            lblid.Text = "";
            txtCustName.Text = "";
            txtMobno.Text = "";
            txtAddress.Text = "";
            txtGST.Text = "";
        }
        public void LoadData()
        {
            try
            {
                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);
                DataTable donater = new DataTable();
                con.Open();


                SqlDataAdapter sda = new SqlDataAdapter("select * from tbl_Customer ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewAddCustomer.DataSource = dt;
                con.Close();
                dataGridViewAddCustomer.Visible = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCustName.Text == "")
                {
                    string msg1 = "Please Insert Customer Name";
                    string msg2 = "Add Customer";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    txtCustName.Focus();
                    return;
                }
                if (txtMobno.Text == "")
                {
                    string msg1 = "Please Insert Customer Mobile no.";
                    string msg2 = "Add Customer";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    txtMobno.Focus();
                    return;
                }
                if (txtAddress.Text == "")
                {
                    string msg1 = "Please Insert Customer Address";
                    string msg2 = "Add Customer";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    txtAddress.Focus();
                    return;
                }
                if (txtGST.Text == "")
                {
                    string msg1 = "Please Insert GST No.";
                    string msg2 = "Add Customer";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    txtAddress.Focus();
                    return;
                }

                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);

                string sql = "insert into tbl_Customer values(@custname,@mobno,@address,@gst)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@custname", txtCustName.Text);
                cmd.Parameters.AddWithValue("@mobno", txtMobno.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@gst", txtGST.Text);

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                int x = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(x.ToString() + "Record Insrted");
               ClearData();
                LoadData();
                dataGridViewAddCustomer.Update();
                dataGridViewAddCustomer.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblid.Text == "")
                {
                    string msg1 = "Please Select Customer";
                    string msg2 = "Add Customer";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    lblid.Focus();
                    return;
                }
                if (txtCustName.Text == "")
                {
                    string msg1 = "Please Insert Customer Name";
                    string msg2 = "Add Customer";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    txtCustName.Focus();
                    return;
                }
                if (txtMobno.Text == "")
                {
                    string msg1 = "Please Insert Customer Mobile no.";
                    string msg2 = "Add Customer";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    txtMobno.Focus();
                    return;
                }
                if (txtAddress.Text == "")
                {
                    string msg1 = "Please Insert Customer Address";
                    string msg2 = "Add Customer";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    txtAddress.Focus();
                    return;
                }

                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);

                string sql = "update tbl_Customer set custname=@custname,mobno=@mobno,address=@address,gst=@gst where cid=@cid";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@cid", lblid.Text);
                cmd.Parameters.AddWithValue("@custname", txtCustName.Text);

                cmd.Parameters.AddWithValue("@mobno", txtMobno.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@gst", txtGST.Text);

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                int x = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(x.ToString() + "Record Updated");
                ClearData();
                LoadData();
                dataGridViewAddCustomer.Update();
                dataGridViewAddCustomer.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblid.Text == "")
                {
                    string msg1 = "Please Select Customer";
                    string msg2 = "Add Customer";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    txtCustName.Focus();
                    return;
                }

                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);

                string sql = "delete tbl_Customer where cid=@cid";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@cid", lblid.Text);

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                int x = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(x.ToString() + "Record Deleted");
                ClearData();
                LoadData();
                dataGridViewAddCustomer.Update();
                dataGridViewAddCustomer.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridViewAddCustomer_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lblid.Text = dataGridViewAddCustomer.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtCustName.Text = dataGridViewAddCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
            // txtqt.Text = DGAddtoCard.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtMobno.Text = dataGridViewAddCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtAddress.Text = dataGridViewAddCustomer.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnNewEntry_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCustName.Text == "")
                {
                    string msg1 = "Please Insert Customer Name";
                    string msg2 = "Add Customer";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    txtCustName.Focus();
                    return;
                }
                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);
                DataTable donater = new DataTable();
                con.Open();


                SqlDataAdapter sda = new SqlDataAdapter("select * from tbl_Customer where custname='"+txtCustName.Text+"'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewAddCustomer.DataSource = dt;
                con.Close();
                dataGridViewAddCustomer.Visible = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtMobno_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtGST_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }
    }
}
