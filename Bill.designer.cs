namespace SuperGas
{
    partial class Bill
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCustID = new System.Windows.Forms.Label();
            this.btnCustRefresh = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtcustmobno = new System.Windows.Forms.TextBox();
            this.cbCustName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTCNo = new System.Windows.Forms.Button();
            this.btnAddTC = new System.Windows.Forms.Button();
            this.lblProID = new System.Windows.Forms.Label();
            this.btnProRefresh = new System.Windows.Forms.Button();
            this.txtTrasportation = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnAddToCard = new System.Windows.Forms.Button();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtHSN = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Calender = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewAddToCard = new System.Windows.Forms.DataGridView();
            this.pid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hsn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtIGST = new System.Windows.Forms.TextBox();
            this.lbligst = new System.Windows.Forms.Label();
            this.txtFinalTotal = new System.Windows.Forms.TextBox();
            this.txtsgst = new System.Windows.Forms.TextBox();
            this.txtcgst = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblsgst = new System.Windows.Forms.Label();
            this.lblcgst = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewInventory = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbBillType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddToCard)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCustID);
            this.groupBox1.Controls.Add(this.btnCustRefresh);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtcustmobno);
            this.groupBox1.Controls.Add(this.cbCustName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(742, 141);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Information";
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustID.Location = new System.Drawing.Point(543, 147);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(0, 24);
            this.lblCustID.TabIndex = 24;
            this.lblCustID.Visible = false;
            // 
            // btnCustRefresh
            // 
            this.btnCustRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            this.btnCustRefresh.FlatAppearance.BorderSize = 0;
            this.btnCustRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustRefresh.ForeColor = System.Drawing.Color.White;
            this.btnCustRefresh.Location = new System.Drawing.Point(357, 26);
            this.btnCustRefresh.Name = "btnCustRefresh";
            this.btnCustRefresh.Size = new System.Drawing.Size(115, 30);
            this.btnCustRefresh.TabIndex = 23;
            this.btnCustRefresh.Text = "Refresh";
            this.btnCustRefresh.UseVisualStyleBackColor = false;
            this.btnCustRefresh.Click += new System.EventHandler(this.btnCustRefresh_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtAddress.Location = new System.Drawing.Point(446, 60);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(276, 68);
            this.txtAddress.TabIndex = 14;
            // 
            // txtcustmobno
            // 
            this.txtcustmobno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtcustmobno.Location = new System.Drawing.Point(133, 73);
            this.txtcustmobno.Multiline = true;
            this.txtcustmobno.Name = "txtcustmobno";
            this.txtcustmobno.ReadOnly = true;
            this.txtcustmobno.Size = new System.Drawing.Size(200, 24);
            this.txtcustmobno.TabIndex = 13;
            // 
            // cbCustName
            // 
            this.cbCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.cbCustName.FormattingEnabled = true;
            this.cbCustName.Location = new System.Drawing.Point(133, 26);
            this.cbCustName.Name = "cbCustName";
            this.cbCustName.Size = new System.Drawing.Size(200, 30);
            this.cbCustName.TabIndex = 12;
            this.cbCustName.SelectedIndexChanged += new System.EventHandler(this.cbCustName_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(353, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mobile No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1074, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTCNo);
            this.groupBox2.Controls.Add(this.btnAddTC);
            this.groupBox2.Controls.Add(this.lblProID);
            this.groupBox2.Controls.Add(this.btnProRefresh);
            this.groupBox2.Controls.Add(this.txtTrasportation);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.btnAddToCard);
            this.groupBox2.Controls.Add(this.txtQty);
            this.groupBox2.Controls.Add(this.txtHSN);
            this.groupBox2.Controls.Add(this.txtPrice);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cbProduct);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(12, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(742, 231);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product Information";
            this.groupBox2.TextChanged += new System.EventHandler(this.s);
            // 
            // btnTCNo
            // 
            this.btnTCNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            this.btnTCNo.Enabled = false;
            this.btnTCNo.FlatAppearance.BorderSize = 0;
            this.btnTCNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTCNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnTCNo.ForeColor = System.Drawing.Color.White;
            this.btnTCNo.Location = new System.Drawing.Point(618, 166);
            this.btnTCNo.Name = "btnTCNo";
            this.btnTCNo.Size = new System.Drawing.Size(69, 31);
            this.btnTCNo.TabIndex = 27;
            this.btnTCNo.Text = "No";
            this.btnTCNo.UseVisualStyleBackColor = false;
            this.btnTCNo.Click += new System.EventHandler(this.btnTCNo_Click);
            // 
            // btnAddTC
            // 
            this.btnAddTC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            this.btnAddTC.FlatAppearance.BorderSize = 0;
            this.btnAddTC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnAddTC.ForeColor = System.Drawing.Color.White;
            this.btnAddTC.Location = new System.Drawing.Point(530, 166);
            this.btnAddTC.Name = "btnAddTC";
            this.btnAddTC.Size = new System.Drawing.Size(69, 31);
            this.btnAddTC.TabIndex = 26;
            this.btnAddTC.Text = "Add";
            this.btnAddTC.UseVisualStyleBackColor = false;
            this.btnAddTC.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblProID
            // 
            this.lblProID.AutoSize = true;
            this.lblProID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProID.Location = new System.Drawing.Point(35, 181);
            this.lblProID.Name = "lblProID";
            this.lblProID.Size = new System.Drawing.Size(0, 24);
            this.lblProID.TabIndex = 25;
            this.lblProID.Visible = false;
            // 
            // btnProRefresh
            // 
            this.btnProRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            this.btnProRefresh.FlatAppearance.BorderSize = 0;
            this.btnProRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProRefresh.ForeColor = System.Drawing.Color.White;
            this.btnProRefresh.Location = new System.Drawing.Point(376, 27);
            this.btnProRefresh.Name = "btnProRefresh";
            this.btnProRefresh.Size = new System.Drawing.Size(115, 30);
            this.btnProRefresh.TabIndex = 24;
            this.btnProRefresh.Text = "Refresh";
            this.btnProRefresh.UseVisualStyleBackColor = false;
            this.btnProRefresh.Click += new System.EventHandler(this.btnProRefresh_Click);
            // 
            // txtTrasportation
            // 
            this.txtTrasportation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtTrasportation.Location = new System.Drawing.Point(518, 124);
            this.txtTrasportation.Multiline = true;
            this.txtTrasportation.Name = "txtTrasportation";
            this.txtTrasportation.Size = new System.Drawing.Size(200, 24);
            this.txtTrasportation.TabIndex = 22;
            this.txtTrasportation.Text = "0";
            this.txtTrasportation.TextChanged += new System.EventHandler(this.txtTrasportation_TextChanged);
            this.txtTrasportation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTrasportation_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(388, 115);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 48);
            this.label14.TabIndex = 21;
            this.label14.Text = "Trasportation \r\nCharges";
            // 
            // btnAddToCard
            // 
            this.btnAddToCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            this.btnAddToCard.FlatAppearance.BorderSize = 0;
            this.btnAddToCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnAddToCard.ForeColor = System.Drawing.Color.White;
            this.btnAddToCard.Location = new System.Drawing.Point(187, 183);
            this.btnAddToCard.Name = "btnAddToCard";
            this.btnAddToCard.Size = new System.Drawing.Size(226, 43);
            this.btnAddToCard.TabIndex = 20;
            this.btnAddToCard.Text = "Add To Card";
            this.btnAddToCard.UseVisualStyleBackColor = false;
            this.btnAddToCard.Click += new System.EventHandler(this.btnAddToCard_Click);
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtQty.Location = new System.Drawing.Point(157, 122);
            this.txtQty.Multiline = true;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(200, 24);
            this.txtQty.TabIndex = 17;
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            this.txtQty.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQty_KeyUp);
            // 
            // txtHSN
            // 
            this.txtHSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtHSN.Location = new System.Drawing.Point(518, 73);
            this.txtHSN.Multiline = true;
            this.txtHSN.Name = "txtHSN";
            this.txtHSN.ReadOnly = true;
            this.txtHSN.Size = new System.Drawing.Size(200, 24);
            this.txtHSN.TabIndex = 16;
            this.txtHSN.Text = "0";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtPrice.Location = new System.Drawing.Point(157, 74);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(200, 24);
            this.txtPrice.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(407, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 24);
            this.label9.TabIndex = 11;
            this.label9.Text = "HSN/SAC";
            // 
            // cbProduct
            // 
            this.cbProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(157, 27);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(200, 30);
            this.cbProduct.TabIndex = 9;
            this.cbProduct.SelectedIndexChanged += new System.EventHandler(this.cbProduct_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Quntity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 24);
            this.label8.TabIndex = 4;
            this.label8.Text = "Product Name ";
            // 
            // Calender
            // 
            this.Calender.CustomFormat = "dd-MM-yyyy";
            this.Calender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.Calender.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Calender.Location = new System.Drawing.Point(1141, 3);
            this.Calender.Name = "Calender";
            this.Calender.Size = new System.Drawing.Size(141, 28);
            this.Calender.TabIndex = 10;
            // 
            // dataGridViewAddToCard
            // 
            this.dataGridViewAddToCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddToCard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pid,
            this.proname,
            this.price,
            this.qt,
            this.total,
            this.hsn});
            this.dataGridViewAddToCard.Location = new System.Drawing.Point(17, 515);
            this.dataGridViewAddToCard.Name = "dataGridViewAddToCard";
            this.dataGridViewAddToCard.RowTemplate.Height = 24;
            this.dataGridViewAddToCard.Size = new System.Drawing.Size(601, 230);
            this.dataGridViewAddToCard.TabIndex = 37;
            this.dataGridViewAddToCard.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewAddToCard_CellMouseUp);
            this.dataGridViewAddToCard.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewAddToCard_RowHeaderMouseClick);
            // 
            // pid
            // 
            this.pid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pid.HeaderText = "PID";
            this.pid.Name = "pid";
            // 
            // proname
            // 
            this.proname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.proname.HeaderText = "Product Name";
            this.proname.Name = "proname";
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            // 
            // qt
            // 
            this.qt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.qt.HeaderText = "Qt\'s";
            this.qt.Name = "qt";
            // 
            // total
            // 
            this.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            // 
            // hsn
            // 
            this.hsn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hsn.HeaderText = "HSN/SAC";
            this.hsn.Name = "hsn";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtIGST);
            this.groupBox3.Controls.Add(this.lbligst);
            this.groupBox3.Controls.Add(this.txtFinalTotal);
            this.groupBox3.Controls.Add(this.txtsgst);
            this.groupBox3.Controls.Add(this.txtcgst);
            this.groupBox3.Controls.Add(this.txtSubTotal);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.lblsgst);
            this.groupBox3.Controls.Add(this.lblcgst);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Location = new System.Drawing.Point(785, 60);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(503, 377);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Calculation Section";
            // 
            // txtIGST
            // 
            this.txtIGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtIGST.Location = new System.Drawing.Point(153, 131);
            this.txtIGST.Multiline = true;
            this.txtIGST.Name = "txtIGST";
            this.txtIGST.ReadOnly = true;
            this.txtIGST.Size = new System.Drawing.Size(200, 24);
            this.txtIGST.TabIndex = 29;
            this.txtIGST.Text = "0";
            this.txtIGST.Visible = false;
            // 
            // lbligst
            // 
            this.lbligst.AutoSize = true;
            this.lbligst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbligst.Location = new System.Drawing.Point(18, 131);
            this.lbligst.Name = "lbligst";
            this.lbligst.Size = new System.Drawing.Size(99, 24);
            this.lbligst.TabIndex = 28;
            this.lbligst.Text = "IGST(18%)";
            this.lbligst.Visible = false;
            // 
            // txtFinalTotal
            // 
            this.txtFinalTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinalTotal.Location = new System.Drawing.Point(153, 274);
            this.txtFinalTotal.Multiline = true;
            this.txtFinalTotal.Name = "txtFinalTotal";
            this.txtFinalTotal.ReadOnly = true;
            this.txtFinalTotal.Size = new System.Drawing.Size(200, 69);
            this.txtFinalTotal.TabIndex = 27;
            this.txtFinalTotal.Text = "0";
            // 
            // txtsgst
            // 
            this.txtsgst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtsgst.Location = new System.Drawing.Point(153, 155);
            this.txtsgst.Multiline = true;
            this.txtsgst.Name = "txtsgst";
            this.txtsgst.ReadOnly = true;
            this.txtsgst.Size = new System.Drawing.Size(200, 24);
            this.txtsgst.TabIndex = 26;
            this.txtsgst.Text = "0";
            // 
            // txtcgst
            // 
            this.txtcgst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtcgst.Location = new System.Drawing.Point(153, 90);
            this.txtcgst.Multiline = true;
            this.txtcgst.Name = "txtcgst";
            this.txtcgst.ReadOnly = true;
            this.txtcgst.Size = new System.Drawing.Size(200, 24);
            this.txtcgst.TabIndex = 25;
            this.txtcgst.Text = "0";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtSubTotal.Location = new System.Drawing.Point(153, 36);
            this.txtSubTotal.Multiline = true;
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(200, 24);
            this.txtSubTotal.TabIndex = 21;
            this.txtSubTotal.Text = "0";
            this.txtSubTotal.TextChanged += new System.EventHandler(this.txtSubTotal_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(9, 277);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 29);
            this.label13.TabIndex = 24;
            this.label13.Text = "Final Total";
            // 
            // lblsgst
            // 
            this.lblsgst.AutoSize = true;
            this.lblsgst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsgst.Location = new System.Drawing.Point(18, 155);
            this.lblsgst.Name = "lblsgst";
            this.lblsgst.Size = new System.Drawing.Size(102, 24);
            this.lblsgst.TabIndex = 23;
            this.lblsgst.Text = "SGST (9%)";
            // 
            // lblcgst
            // 
            this.lblcgst.AutoSize = true;
            this.lblcgst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcgst.Location = new System.Drawing.Point(20, 90);
            this.lblcgst.Name = "lblcgst";
            this.lblcgst.Size = new System.Drawing.Size(103, 24);
            this.lblcgst.TabIndex = 22;
            this.lblcgst.Text = "CGST (9%)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 24);
            this.label10.TabIndex = 21;
            this.label10.Text = "Sub Total";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.textBox2.Location = new System.Drawing.Point(515, 68);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 24);
            this.textBox2.TabIndex = 16;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(815, 447);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(184, 55);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteDataToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(159, 28);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            this.contextMenuStrip1.Click += new System.EventHandler(this.contextMenuStrip1_Click);
            // 
            // deleteDataToolStripMenuItem
            // 
            this.deleteDataToolStripMenuItem.Name = "deleteDataToolStripMenuItem";
            this.deleteDataToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.deleteDataToolStripMenuItem.Text = "Delete Data";
            this.deleteDataToolStripMenuItem.Click += new System.EventHandler(this.deleteDataToolStripMenuItem_Click);
            // 
            // btnNewInventory
            // 
            this.btnNewInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            this.btnNewInventory.FlatAppearance.BorderSize = 0;
            this.btnNewInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnNewInventory.ForeColor = System.Drawing.Color.White;
            this.btnNewInventory.Location = new System.Drawing.Point(1010, 449);
            this.btnNewInventory.Name = "btnNewInventory";
            this.btnNewInventory.Size = new System.Drawing.Size(178, 51);
            this.btnNewInventory.TabIndex = 39;
            this.btnNewInventory.Text = "New Inventory";
            this.btnNewInventory.UseVisualStyleBackColor = false;
            this.btnNewInventory.Click += new System.EventHandler(this.btnNewInventory_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.DisplayStatusBar = false;
            this.crystalReportViewer1.Location = new System.Drawing.Point(651, 515);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(660, 215);
            this.crystalReportViewer1.TabIndex = 40;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer1.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbBillType);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(27, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(485, 69);
            this.groupBox4.TabIndex = 41;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bill Type";
            // 
            // cbBillType
            // 
            this.cbBillType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.cbBillType.FormattingEnabled = true;
            this.cbBillType.Items.AddRange(new object[] {
            "Without IGST",
            "With IGST"});
            this.cbBillType.Location = new System.Drawing.Point(183, 26);
            this.cbBillType.Name = "cbBillType";
            this.cbBillType.Size = new System.Drawing.Size(200, 30);
            this.cbBillType.TabIndex = 25;
            this.cbBillType.SelectedIndexChanged += new System.EventHandler(this.cbBillType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Select Bill Type ";
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.btnNewInventory);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridViewAddToCard);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Calender);
            this.Name = "Bill";
            this.Size = new System.Drawing.Size(1467, 767);
            this.Load += new System.EventHandler(this.Bill_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddToCard)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtcustmobno;
        private System.Windows.Forms.ComboBox cbCustName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtHSN;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker Calender;
        private System.Windows.Forms.TextBox txtTrasportation;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnAddToCard;
        private System.Windows.Forms.DataGridView dataGridViewAddToCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn pid;
        private System.Windows.Forms.DataGridViewTextBoxColumn proname;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn qt;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn hsn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtFinalTotal;
        private System.Windows.Forms.TextBox txtsgst;
        private System.Windows.Forms.TextBox txtcgst;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblsgst;
        private System.Windows.Forms.Label lblcgst;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCustRefresh;
        private System.Windows.Forms.Button btnProRefresh;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.Label lblProID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteDataToolStripMenuItem;
        private System.Windows.Forms.Button btnNewInventory;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button btnAddTC;
        private System.Windows.Forms.TextBox txtIGST;
        private System.Windows.Forms.Label lbligst;
        private System.Windows.Forms.Button btnTCNo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbBillType;
        private System.Windows.Forms.Label label1;
    }
}
