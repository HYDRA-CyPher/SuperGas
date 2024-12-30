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

namespace SuperGas
{
    public partial class Product : UserControl
    {
        public Product()
        {
            InitializeComponent();
        }
        public void ClearData()
        {
            lblid.Text = "";
            txtProName.Text = "";
            txtPrice.Text = "";
            txtHSN.Text = "0";
        }
        public void LoadData()
        {
            try
            {
                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);
                DataTable donater = new DataTable();
                con.Open();


                SqlDataAdapter sda = new SqlDataAdapter("select * from tbl_Product ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewAddProduct.DataSource = dt;
                con.Close();
                dataGridViewAddProduct.Visible = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProName.Text == "")
                {
                    string msg1 = "Please Insert Product Name";
                    string msg2 = "Add Product";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    txtProName.Focus();
                    return;
                }
                if (txtPrice.Text == "")
                {
                    string msg1 = "Please Insert Product Price";
                    string msg2 = "Add Product";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    txtPrice.Focus();
                    return;
                }
                if (txtHSN.Text == "")
                {
                    string msg1 = "Please Insert HSN/SAN Number or Set '0'";
                    string msg2 = "Add Product";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    txtHSN.Focus();
                    return;
                }

                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);

                string sql = "insert into tbl_Product values(@name,@price,@hsn)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@name", txtProName.Text);
                cmd.Parameters.AddWithValue("@price", txtPrice.Text);
                cmd.Parameters.AddWithValue("@hsn", txtHSN.Text);


                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                int x = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(x.ToString() + "Record Insrted");
                ClearData();
                LoadData();
                dataGridViewAddProduct.Update();
                dataGridViewAddProduct.Refresh();

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
                    string msg1 = "Please select Product";
                    string msg2 = "Add Product";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);

                    return;
                }
                if (txtProName.Text == "")
                {
                    string msg1 = "Please Insert Product Name";
                    string msg2 = "Add Product";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    txtProName.Focus();
                    return;
                }
                if (txtPrice.Text == "")
                {
                    string msg1 = "Please Insert Product Price";
                    string msg2 = "Add Product";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    txtPrice.Focus();
                    return;
                }
                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);

                string sql = "update tbl_Product set name=@name,price=@price,hsn=@hsn where pid=@pid";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@pid", lblid.Text);
                cmd.Parameters.AddWithValue("@name", txtProName.Text);

                cmd.Parameters.AddWithValue("@price", txtPrice.Text);
                cmd.Parameters.AddWithValue("@hsn", txtHSN.Text);

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                int x = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(x.ToString() + "Record Updated");
                ClearData();
                LoadData();
                dataGridViewAddProduct.Update();
                dataGridViewAddProduct.Refresh();

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
                    string msg1 = "Please select Product";
                    string msg2 = "Add Product";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);

                    return;
                }

                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);

                string sql = "delete tbl_Product where pid=@pid";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@pid", lblid.Text);

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                int x = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(x.ToString() + "Record Deleted");
                ClearData();
                LoadData();
                dataGridViewAddProduct.Update();
                dataGridViewAddProduct.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnNewEntry_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProName.Text == "")
                {
                    string msg1 = "Please select Product";
                    string msg2 = "Add Product";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    txtProName.Focus();
                    return;
                }
                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);
                DataTable donater = new DataTable();
                con.Open();


                SqlDataAdapter sda = new SqlDataAdapter("select * from tbl_Product where name='"+txtProName.Text+"'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewAddProduct.DataSource = dt;
                con.Close();
                dataGridViewAddProduct.Visible = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridViewAddProduct_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lblid.Text = dataGridViewAddProduct.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtProName.Text = dataGridViewAddProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
            // txtqt.Text = DGAddtoCard.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPrice.Text = dataGridViewAddProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtHSN.Text = dataGridViewAddProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtHSN_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
