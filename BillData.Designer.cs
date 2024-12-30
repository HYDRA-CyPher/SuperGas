namespace MainFile
{
    partial class BillData
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbligst = new System.Windows.Forms.Label();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.lblto = new System.Windows.Forms.Label();
            this.btnPrintBill = new System.Windows.Forms.Button();
            this.lblSID = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lblID = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.cbData = new System.Windows.Forms.ComboBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblMobno = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.lbligst);
            this.panel1.Controls.Add(this.btnShowAll);
            this.panel1.Controls.Add(this.lblto);
            this.panel1.Controls.Add(this.btnPrintBill);
            this.panel1.Controls.Add(this.lblSID);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.cbData);
            this.panel1.Controls.Add(this.cbType);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.lblMobno);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1467, 162);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbligst
            // 
            this.lbligst.AutoSize = true;
            this.lbligst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbligst.ForeColor = System.Drawing.Color.Gray;
            this.lbligst.Location = new System.Drawing.Point(262, 12);
            this.lbligst.Name = "lbligst";
            this.lbligst.Size = new System.Drawing.Size(52, 24);
            this.lbligst.TabIndex = 57;
            this.lbligst.Text = "IGST";
            this.lbligst.Visible = false;
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            this.btnShowAll.FlatAppearance.BorderSize = 0;
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnShowAll.ForeColor = System.Drawing.Color.White;
            this.btnShowAll.Location = new System.Drawing.Point(1154, 61);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(150, 43);
            this.btnShowAll.TabIndex = 56;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Visible = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // lblto
            // 
            this.lblto.AutoSize = true;
            this.lblto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblto.ForeColor = System.Drawing.Color.Black;
            this.lblto.Location = new System.Drawing.Point(760, 115);
            this.lblto.Name = "lblto";
            this.lblto.Size = new System.Drawing.Size(37, 24);
            this.lblto.TabIndex = 55;
            this.lblto.Text = "TO";
            // 
            // btnPrintBill
            // 
            this.btnPrintBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            this.btnPrintBill.FlatAppearance.BorderSize = 0;
            this.btnPrintBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnPrintBill.ForeColor = System.Drawing.Color.White;
            this.btnPrintBill.Location = new System.Drawing.Point(1154, 110);
            this.btnPrintBill.Name = "btnPrintBill";
            this.btnPrintBill.Size = new System.Drawing.Size(150, 43);
            this.btnPrintBill.TabIndex = 54;
            this.btnPrintBill.Text = "Print Bill";
            this.btnPrintBill.UseVisualStyleBackColor = false;
            this.btnPrintBill.Visible = false;
            this.btnPrintBill.Click += new System.EventHandler(this.btnPrintBill_Click);
            // 
            // lblSID
            // 
            this.lblSID.AutoSize = true;
            this.lblSID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSID.ForeColor = System.Drawing.Color.Gray;
            this.lblSID.Location = new System.Drawing.Point(441, 12);
            this.lblSID.Name = "lblSID";
            this.lblSID.Size = new System.Drawing.Size(27, 24);
            this.lblSID.TabIndex = 53;
            this.lblSID.Text = "ID";
            this.lblSID.Visible = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(803, 115);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(149, 28);
            this.dateTimePicker2.TabIndex = 52;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.Gray;
            this.lblID.Location = new System.Drawing.Point(396, 12);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(27, 24);
            this.lblID.TabIndex = 51;
            this.lblID.Text = "ID";
            this.lblID.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(602, 113);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(149, 28);
            this.dateTimePicker1.TabIndex = 50;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(482, 113);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(105, 24);
            this.lblDate.TabIndex = 49;
            this.lblDate.Text = "Select Date";
            // 
            // cbData
            // 
            this.cbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.cbData.FormattingEnabled = true;
            this.cbData.Items.AddRange(new object[] {
            "Name",
            "Mobile No."});
            this.cbData.Location = new System.Drawing.Point(207, 107);
            this.cbData.Name = "cbData";
            this.cbData.Size = new System.Drawing.Size(261, 30);
            this.cbData.TabIndex = 48;
            this.cbData.Visible = false;
            this.cbData.SelectedIndexChanged += new System.EventHandler(this.cbData_SelectedIndexChanged);
            // 
            // cbType
            // 
            this.cbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Name",
            "Mobile No."});
            this.cbType.Location = new System.Drawing.Point(207, 39);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(261, 30);
            this.cbType.TabIndex = 47;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(978, 110);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 43);
            this.btnSearch.TabIndex = 42;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblMobno
            // 
            this.lblMobno.AutoSize = true;
            this.lblMobno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobno.ForeColor = System.Drawing.Color.Black;
            this.lblMobno.Location = new System.Drawing.Point(27, 110);
            this.lblMobno.Name = "lblMobno";
            this.lblMobno.Size = new System.Drawing.Size(159, 24);
            this.lblMobno.TabIndex = 23;
            this.lblMobno.Text = "Select Mobile No.";
            this.lblMobno.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(27, 113);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(149, 24);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "Select the Name";
            this.lblName.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(27, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(175, 24);
            this.label12.TabIndex = 17;
            this.label12.Text = "Select Search Type";
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Location = new System.Drawing.Point(3, 217);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.RowTemplate.Height = 24;
            this.dataGridViewData.Size = new System.Drawing.Size(719, 257);
            this.dataGridViewData.TabIndex = 17;
            this.dataGridViewData.Visible = false;
            this.dataGridViewData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewData_CellContentClick);
            this.dataGridViewData.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewData_CellMouseUp);
            this.dataGridViewData.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewData_RowHeaderMouseClick);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.DisplayStatusBar = false;
            this.crystalReportViewer1.ForeColor = System.Drawing.Color.White;
            this.crystalReportViewer1.Location = new System.Drawing.Point(3, 217);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1309, 501);
            this.crystalReportViewer1.TabIndex = 18;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer1.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteDataToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(159, 28);
            // 
            // deleteDataToolStripMenuItem
            // 
            this.deleteDataToolStripMenuItem.Name = "deleteDataToolStripMenuItem";
            this.deleteDataToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.deleteDataToolStripMenuItem.Text = "Delete Data";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(978, 42);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 43);
            this.btnDelete.TabIndex = 58;
            this.btnDelete.Text = "Delete Bill";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // BillData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.dataGridViewData);
            this.Controls.Add(this.panel1);
            this.Name = "BillData";
            this.Size = new System.Drawing.Size(1467, 767);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblMobno;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.ComboBox cbData;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lblSID;
        private System.Windows.Forms.Button btnPrintBill;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label lblto;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Label lbligst;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteDataToolStripMenuItem;
        private System.Windows.Forms.Button btnDelete;
    }
}
