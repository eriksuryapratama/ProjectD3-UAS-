
namespace Project_UAS_
{
    partial class Invoice
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nO_PNWLabel;
            System.Windows.Forms.Label tGL_INVLabel;
            System.Windows.Forms.Label p_IDLabel;
            System.Windows.Forms.Label nAMA_NPWPLabel;
            System.Windows.Forms.Label kETERANGANLabel;
            System.Windows.Forms.Label dISCOUNTLabel;
            System.Windows.Forms.Label pPNLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoice));
            this.uASDataSet = new Project_UAS_.UASDataSet();
            this.t_invoice_headerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_invoice_headerTableAdapter = new Project_UAS_.UASDataSetTableAdapters.t_invoice_headerTableAdapter();
            this.tableAdapterManager = new Project_UAS_.UASDataSetTableAdapters.TableAdapterManager();
            this.m_barangTableAdapter = new Project_UAS_.UASDataSetTableAdapters.m_barangTableAdapter();
            this.m_pelangganTableAdapter = new Project_UAS_.UASDataSetTableAdapters.m_pelangganTableAdapter();
            this.t_invoice_headerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.t_invoice_headerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tb_noINV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dt_tglINV = new System.Windows.Forms.DateTimePicker();
            this.dt_tglTerima = new System.Windows.Forms.DateTimePicker();
            this.cb_Customer = new System.Windows.Forms.ComboBox();
            this.mpelangganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_namaNPWP = new System.Windows.Forms.TextBox();
            this.tb_alamatNPWP = new System.Windows.Forms.TextBox();
            this.tb_kotaCustomer = new System.Windows.Forms.TextBox();
            this.tb_namaNPWP2 = new System.Windows.Forms.TextBox();
            this.tb_alamatLengkap = new System.Windows.Forms.TextBox();
            this.dgv_dataInvoice = new System.Windows.Forms.DataGridView();
            this.tb_noteCustomer = new System.Windows.Forms.TextBox();
            this.btn_hpsitem = new System.Windows.Forms.Button();
            this.btn_tmbhitem = new System.Windows.Forms.Button();
            this.mbarangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dISCOUNTTextBox = new System.Windows.Forms.TextBox();
            this.pPNTextBox = new System.Windows.Forms.TextBox();
            this.tb_totalBeli = new System.Windows.Forms.TextBox();
            this.tb_grandTotal = new System.Windows.Forms.TextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.nO_PNWComboBox = new System.Windows.Forms.ComboBox();
            this.tpenawaranheaderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_penawaran_headerTableAdapter = new Project_UAS_.UASDataSetTableAdapters.t_penawaran_headerTableAdapter();
            nO_PNWLabel = new System.Windows.Forms.Label();
            tGL_INVLabel = new System.Windows.Forms.Label();
            p_IDLabel = new System.Windows.Forms.Label();
            nAMA_NPWPLabel = new System.Windows.Forms.Label();
            kETERANGANLabel = new System.Windows.Forms.Label();
            dISCOUNTLabel = new System.Windows.Forms.Label();
            pPNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uASDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_invoice_headerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_invoice_headerBindingNavigator)).BeginInit();
            this.t_invoice_headerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mpelangganBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dataInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mbarangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tpenawaranheaderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nO_PNWLabel
            // 
            nO_PNWLabel.AutoSize = true;
            nO_PNWLabel.BackColor = System.Drawing.Color.Transparent;
            nO_PNWLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nO_PNWLabel.ForeColor = System.Drawing.Color.White;
            nO_PNWLabel.Location = new System.Drawing.Point(232, 38);
            nO_PNWLabel.Name = "nO_PNWLabel";
            nO_PNWLabel.Size = new System.Drawing.Size(44, 16);
            nO_PNWLabel.TabIndex = 3;
            nO_PNWLabel.Text = "Pnwrn";
            // 
            // tGL_INVLabel
            // 
            tGL_INVLabel.AutoSize = true;
            tGL_INVLabel.BackColor = System.Drawing.Color.Transparent;
            tGL_INVLabel.ForeColor = System.Drawing.Color.White;
            tGL_INVLabel.Location = new System.Drawing.Point(435, 41);
            tGL_INVLabel.Name = "tGL_INVLabel";
            tGL_INVLabel.Size = new System.Drawing.Size(52, 13);
            tGL_INVLabel.TabIndex = 5;
            tGL_INVLabel.Text = "TGL INV:";
            // 
            // p_IDLabel
            // 
            p_IDLabel.AutoSize = true;
            p_IDLabel.BackColor = System.Drawing.Color.Transparent;
            p_IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            p_IDLabel.ForeColor = System.Drawing.Color.White;
            p_IDLabel.Location = new System.Drawing.Point(8, 74);
            p_IDLabel.Name = "p_IDLabel";
            p_IDLabel.Size = new System.Drawing.Size(85, 16);
            p_IDLabel.TabIndex = 8;
            p_IDLabel.Text = "CUSTOMER";
            // 
            // nAMA_NPWPLabel
            // 
            nAMA_NPWPLabel.AutoSize = true;
            nAMA_NPWPLabel.BackColor = System.Drawing.Color.Transparent;
            nAMA_NPWPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nAMA_NPWPLabel.ForeColor = System.Drawing.Color.White;
            nAMA_NPWPLabel.Location = new System.Drawing.Point(8, 112);
            nAMA_NPWPLabel.Name = "nAMA_NPWPLabel";
            nAMA_NPWPLabel.Size = new System.Drawing.Size(91, 16);
            nAMA_NPWPLabel.TabIndex = 13;
            nAMA_NPWPLabel.Text = "NAMA NPWP";
            // 
            // kETERANGANLabel
            // 
            kETERANGANLabel.AutoSize = true;
            kETERANGANLabel.BackColor = System.Drawing.Color.Transparent;
            kETERANGANLabel.ForeColor = System.Drawing.Color.White;
            kETERANGANLabel.Location = new System.Drawing.Point(712, 114);
            kETERANGANLabel.Name = "kETERANGANLabel";
            kETERANGANLabel.Size = new System.Drawing.Size(37, 13);
            kETERANGANLabel.TabIndex = 136;
            kETERANGANLabel.Text = "NOTE";
            // 
            // dISCOUNTLabel
            // 
            dISCOUNTLabel.AutoSize = true;
            dISCOUNTLabel.BackColor = System.Drawing.Color.Transparent;
            dISCOUNTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dISCOUNTLabel.ForeColor = System.Drawing.Color.White;
            dISCOUNTLabel.Location = new System.Drawing.Point(717, 549);
            dISCOUNTLabel.Name = "dISCOUNTLabel";
            dISCOUNTLabel.Size = new System.Drawing.Size(78, 16);
            dISCOUNTLabel.TabIndex = 152;
            dISCOUNTLabel.Text = "DISCOUNT";
            dISCOUNTLabel.Click += new System.EventHandler(this.dISCOUNTLabel_Click);
            // 
            // pPNLabel
            // 
            pPNLabel.AutoSize = true;
            pPNLabel.BackColor = System.Drawing.Color.Transparent;
            pPNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pPNLabel.ForeColor = System.Drawing.Color.White;
            pPNLabel.Location = new System.Drawing.Point(759, 575);
            pPNLabel.Name = "pPNLabel";
            pPNLabel.Size = new System.Drawing.Size(36, 16);
            pPNLabel.TabIndex = 155;
            pPNLabel.Text = "PPN";
            pPNLabel.Click += new System.EventHandler(this.pPNLabel_Click);
            // 
            // uASDataSet
            // 
            this.uASDataSet.DataSetName = "UASDataSet";
            this.uASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_invoice_headerBindingSource
            // 
            this.t_invoice_headerBindingSource.DataMember = "t_invoice_header";
            this.t_invoice_headerBindingSource.DataSource = this.uASDataSet;
            // 
            // t_invoice_headerTableAdapter
            // 
            this.t_invoice_headerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.m_barangTableAdapter = this.m_barangTableAdapter;
            this.tableAdapterManager.m_groupuserTableAdapter = null;
            this.tableAdapterManager.m_hakaksesgroupuserTableAdapter = null;
            this.tableAdapterManager.m_kotaTableAdapter = null;
            this.tableAdapterManager.m_merkTableAdapter = null;
            this.tableAdapterManager.m_modelTableAdapter = null;
            this.tableAdapterManager.m_pelangganTableAdapter = this.m_pelangganTableAdapter;
            this.tableAdapterManager.m_supplierTableAdapter = null;
            this.tableAdapterManager.m_usersTableAdapter = null;
            this.tableAdapterManager.rework_detailTableAdapter = null;
            this.tableAdapterManager.reworkTableAdapter = null;
            this.tableAdapterManager.stock_historyTableAdapter = null;
            this.tableAdapterManager.stockTableAdapter = null;
            this.tableAdapterManager.t_invoice_detailTableAdapter = null;
            this.tableAdapterManager.t_invoice_headerTableAdapter = this.t_invoice_headerTableAdapter;
            this.tableAdapterManager.t_invoiceppn_detailTableAdapter = null;
            this.tableAdapterManager.t_invoiceppn_headerTableAdapter = null;
            this.tableAdapterManager.t_label_hargaTableAdapter = null;
            this.tableAdapterManager.t_pembelian_detailTableAdapter = null;
            this.tableAdapterManager.t_pembelian_headerTableAdapter = null;
            this.tableAdapterManager.t_penawaran_detailTableAdapter = null;
            this.tableAdapterManager.t_penawaran_headerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Project_UAS_.UASDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // m_barangTableAdapter
            // 
            this.m_barangTableAdapter.ClearBeforeFill = true;
            // 
            // m_pelangganTableAdapter
            // 
            this.m_pelangganTableAdapter.ClearBeforeFill = true;
            // 
            // t_invoice_headerBindingNavigator
            // 
            this.t_invoice_headerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.t_invoice_headerBindingNavigator.BindingSource = this.t_invoice_headerBindingSource;
            this.t_invoice_headerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.t_invoice_headerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.t_invoice_headerBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.t_invoice_headerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.t_invoice_headerBindingNavigatorSaveItem});
            this.t_invoice_headerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.t_invoice_headerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.t_invoice_headerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.t_invoice_headerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.t_invoice_headerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.t_invoice_headerBindingNavigator.Name = "t_invoice_headerBindingNavigator";
            this.t_invoice_headerBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.t_invoice_headerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.t_invoice_headerBindingNavigator.Size = new System.Drawing.Size(964, 31);
            this.t_invoice_headerBindingNavigator.TabIndex = 0;
            this.t_invoice_headerBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.bindingNavigatorMoveFirstItem_Click);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.bindingNavigatorMoveLastItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // t_invoice_headerBindingNavigatorSaveItem
            // 
            this.t_invoice_headerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.t_invoice_headerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("t_invoice_headerBindingNavigatorSaveItem.Image")));
            this.t_invoice_headerBindingNavigatorSaveItem.Name = "t_invoice_headerBindingNavigatorSaveItem";
            this.t_invoice_headerBindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 28);
            this.t_invoice_headerBindingNavigatorSaveItem.Text = "Save Data";
            this.t_invoice_headerBindingNavigatorSaveItem.Click += new System.EventHandler(this.t_invoice_headerBindingNavigatorSaveItem_Click);
            // 
            // tb_noINV
            // 
            this.tb_noINV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_invoice_headerBindingSource, "NO_INV", true));
            this.tb_noINV.Location = new System.Drawing.Point(112, 37);
            this.tb_noINV.Name = "tb_noINV";
            this.tb_noINV.Size = new System.Drawing.Size(117, 20);
            this.tb_noINV.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "INVOICE";
            // 
            // dt_tglINV
            // 
            this.dt_tglINV.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.t_invoice_headerBindingSource, "TGL_INV", true));
            this.dt_tglINV.Location = new System.Drawing.Point(493, 37);
            this.dt_tglINV.Name = "dt_tglINV";
            this.dt_tglINV.Size = new System.Drawing.Size(154, 20);
            this.dt_tglINV.TabIndex = 6;
            // 
            // dt_tglTerima
            // 
            this.dt_tglTerima.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.t_invoice_headerBindingSource, "TGL_TERIMA", true));
            this.dt_tglTerima.Location = new System.Drawing.Point(653, 38);
            this.dt_tglTerima.Name = "dt_tglTerima";
            this.dt_tglTerima.Size = new System.Drawing.Size(154, 20);
            this.dt_tglTerima.TabIndex = 8;
            // 
            // cb_Customer
            // 
            this.cb_Customer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_invoice_headerBindingSource, "P_ID", true));
            this.cb_Customer.DataSource = this.mpelangganBindingSource;
            this.cb_Customer.DisplayMember = "P_CODE";
            this.cb_Customer.FormattingEnabled = true;
            this.cb_Customer.Location = new System.Drawing.Point(105, 73);
            this.cb_Customer.Name = "cb_Customer";
            this.cb_Customer.Size = new System.Drawing.Size(124, 21);
            this.cb_Customer.TabIndex = 9;
            this.cb_Customer.ValueMember = "ID";
            // 
            // mpelangganBindingSource
            // 
            this.mpelangganBindingSource.DataMember = "m_pelanggan";
            this.mpelangganBindingSource.DataSource = this.uASDataSet;
            // 
            // tb_namaNPWP
            // 
            this.tb_namaNPWP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mpelangganBindingSource, "NAMA_NPWP", true));
            this.tb_namaNPWP.Location = new System.Drawing.Point(235, 74);
            this.tb_namaNPWP.Name = "tb_namaNPWP";
            this.tb_namaNPWP.Size = new System.Drawing.Size(302, 20);
            this.tb_namaNPWP.TabIndex = 11;
            // 
            // tb_alamatNPWP
            // 
            this.tb_alamatNPWP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mpelangganBindingSource, "ALAMAT_NPWP", true));
            this.tb_alamatNPWP.Location = new System.Drawing.Point(543, 74);
            this.tb_alamatNPWP.Name = "tb_alamatNPWP";
            this.tb_alamatNPWP.Size = new System.Drawing.Size(401, 20);
            this.tb_alamatNPWP.TabIndex = 12;
            // 
            // tb_kotaCustomer
            // 
            this.tb_kotaCustomer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mpelangganBindingSource, "KOTA", true));
            this.tb_kotaCustomer.Location = new System.Drawing.Point(813, 37);
            this.tb_kotaCustomer.Name = "tb_kotaCustomer";
            this.tb_kotaCustomer.Size = new System.Drawing.Size(131, 20);
            this.tb_kotaCustomer.TabIndex = 13;
            // 
            // tb_namaNPWP2
            // 
            this.tb_namaNPWP2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mpelangganBindingSource, "NAMA_NPWP", true));
            this.tb_namaNPWP2.Location = new System.Drawing.Point(105, 111);
            this.tb_namaNPWP2.Name = "tb_namaNPWP2";
            this.tb_namaNPWP2.Size = new System.Drawing.Size(286, 20);
            this.tb_namaNPWP2.TabIndex = 14;
            // 
            // tb_alamatLengkap
            // 
            this.tb_alamatLengkap.Location = new System.Drawing.Point(397, 111);
            this.tb_alamatLengkap.Name = "tb_alamatLengkap";
            this.tb_alamatLengkap.Size = new System.Drawing.Size(309, 20);
            this.tb_alamatLengkap.TabIndex = 15;
            // 
            // dgv_dataInvoice
            // 
            this.dgv_dataInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_dataInvoice.BackgroundColor = System.Drawing.Color.White;
            this.dgv_dataInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dataInvoice.Location = new System.Drawing.Point(11, 150);
            this.dgv_dataInvoice.Name = "dgv_dataInvoice";
            this.dgv_dataInvoice.ReadOnly = true;
            this.dgv_dataInvoice.RowHeadersWidth = 62;
            this.dgv_dataInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_dataInvoice.Size = new System.Drawing.Size(933, 342);
            this.dgv_dataInvoice.TabIndex = 136;
            this.dgv_dataInvoice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dataInvoice_CellContentClick);
            // 
            // tb_noteCustomer
            // 
            this.tb_noteCustomer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mpelangganBindingSource, "KETERANGAN", true));
            this.tb_noteCustomer.Location = new System.Drawing.Point(755, 111);
            this.tb_noteCustomer.Name = "tb_noteCustomer";
            this.tb_noteCustomer.Size = new System.Drawing.Size(189, 20);
            this.tb_noteCustomer.TabIndex = 137;
            // 
            // btn_hpsitem
            // 
            this.btn_hpsitem.BackColor = System.Drawing.Color.Red;
            this.btn_hpsitem.ForeColor = System.Drawing.Color.White;
            this.btn_hpsitem.Location = new System.Drawing.Point(278, 567);
            this.btn_hpsitem.Margin = new System.Windows.Forms.Padding(2);
            this.btn_hpsitem.Name = "btn_hpsitem";
            this.btn_hpsitem.Size = new System.Drawing.Size(93, 29);
            this.btn_hpsitem.TabIndex = 149;
            this.btn_hpsitem.Text = "Hapus Item";
            this.btn_hpsitem.UseVisualStyleBackColor = false;
            this.btn_hpsitem.Click += new System.EventHandler(this.btn_hpsitem_Click);
            // 
            // btn_tmbhitem
            // 
            this.btn_tmbhitem.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_tmbhitem.ForeColor = System.Drawing.Color.White;
            this.btn_tmbhitem.Location = new System.Drawing.Point(278, 526);
            this.btn_tmbhitem.Margin = new System.Windows.Forms.Padding(2);
            this.btn_tmbhitem.Name = "btn_tmbhitem";
            this.btn_tmbhitem.Size = new System.Drawing.Size(93, 29);
            this.btn_tmbhitem.TabIndex = 148;
            this.btn_tmbhitem.Text = "Tambah Item";
            this.btn_tmbhitem.UseVisualStyleBackColor = false;
            this.btn_tmbhitem.Click += new System.EventHandler(this.btn_tmbhitem_Click);
            // 
            // mbarangBindingSource
            // 
            this.mbarangBindingSource.DataMember = "m_barang";
            this.mbarangBindingSource.DataSource = this.uASDataSet;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(717, 603);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 154;
            this.label6.Text = "Grand Total";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(688, 523);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 153;
            this.label5.Text = "Total Pembelian";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dISCOUNTTextBox
            // 
            this.dISCOUNTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_invoice_headerBindingSource, "DISCOUNT", true));
            this.dISCOUNTTextBox.Enabled = false;
            this.dISCOUNTTextBox.Location = new System.Drawing.Point(801, 548);
            this.dISCOUNTTextBox.Name = "dISCOUNTTextBox";
            this.dISCOUNTTextBox.Size = new System.Drawing.Size(143, 20);
            this.dISCOUNTTextBox.TabIndex = 156;
            this.dISCOUNTTextBox.Text = "0";
            this.dISCOUNTTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dISCOUNTTextBox.TextChanged += new System.EventHandler(this.dISCOUNTTextBox_TextChanged);
            // 
            // pPNTextBox
            // 
            this.pPNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_invoice_headerBindingSource, "PPN", true));
            this.pPNTextBox.Enabled = false;
            this.pPNTextBox.Location = new System.Drawing.Point(801, 574);
            this.pPNTextBox.Name = "pPNTextBox";
            this.pPNTextBox.Size = new System.Drawing.Size(143, 20);
            this.pPNTextBox.TabIndex = 157;
            this.pPNTextBox.Text = "0";
            this.pPNTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.pPNTextBox.TextChanged += new System.EventHandler(this.pPNTextBox_TextChanged);
            // 
            // tb_totalBeli
            // 
            this.tb_totalBeli.Location = new System.Drawing.Point(801, 522);
            this.tb_totalBeli.Name = "tb_totalBeli";
            this.tb_totalBeli.Size = new System.Drawing.Size(143, 20);
            this.tb_totalBeli.TabIndex = 159;
            this.tb_totalBeli.TextChanged += new System.EventHandler(this.tb_totalBeli_TextChanged);
            // 
            // tb_grandTotal
            // 
            this.tb_grandTotal.Location = new System.Drawing.Point(802, 600);
            this.tb_grandTotal.Name = "tb_grandTotal";
            this.tb_grandTotal.Size = new System.Drawing.Size(142, 20);
            this.tb_grandTotal.TabIndex = 158;
            this.tb_grandTotal.TextChanged += new System.EventHandler(this.tb_grandTotal_TextChanged);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Red;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Location = new System.Drawing.Point(376, 567);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(109, 29);
            this.btn_Exit.TabIndex = 161;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Print.ForeColor = System.Drawing.Color.White;
            this.btn_Print.Location = new System.Drawing.Point(376, 526);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(109, 29);
            this.btn_Print.TabIndex = 160;
            this.btn_Print.Text = "Print";
            this.btn_Print.UseVisualStyleBackColor = false;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // nO_PNWComboBox
            // 
            this.nO_PNWComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_invoice_headerBindingSource, "NO_PNW", true));
            this.nO_PNWComboBox.DataSource = this.tpenawaranheaderBindingSource;
            this.nO_PNWComboBox.DisplayMember = "NO_PNW";
            this.nO_PNWComboBox.FormattingEnabled = true;
            this.nO_PNWComboBox.Location = new System.Drawing.Point(282, 38);
            this.nO_PNWComboBox.Name = "nO_PNWComboBox";
            this.nO_PNWComboBox.Size = new System.Drawing.Size(147, 21);
            this.nO_PNWComboBox.TabIndex = 162;
            this.nO_PNWComboBox.ValueMember = "NO_PNW";
            // 
            // tpenawaranheaderBindingSource
            // 
            this.tpenawaranheaderBindingSource.DataMember = "t_penawaran_header";
            this.tpenawaranheaderBindingSource.DataSource = this.uASDataSet;
            // 
            // t_penawaran_headerTableAdapter
            // 
            this.t_penawaran_headerTableAdapter.ClearBeforeFill = true;
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(964, 660);
            this.Controls.Add(this.nO_PNWComboBox);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.tb_totalBeli);
            this.Controls.Add(this.tb_grandTotal);
            this.Controls.Add(this.pPNTextBox);
            this.Controls.Add(this.dISCOUNTTextBox);
            this.Controls.Add(pPNLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(dISCOUNTLabel);
            this.Controls.Add(this.btn_hpsitem);
            this.Controls.Add(this.btn_tmbhitem);
            this.Controls.Add(kETERANGANLabel);
            this.Controls.Add(this.tb_noteCustomer);
            this.Controls.Add(this.dgv_dataInvoice);
            this.Controls.Add(this.tb_alamatLengkap);
            this.Controls.Add(nAMA_NPWPLabel);
            this.Controls.Add(this.tb_namaNPWP2);
            this.Controls.Add(this.tb_kotaCustomer);
            this.Controls.Add(this.tb_alamatNPWP);
            this.Controls.Add(this.tb_namaNPWP);
            this.Controls.Add(p_IDLabel);
            this.Controls.Add(this.cb_Customer);
            this.Controls.Add(this.dt_tglTerima);
            this.Controls.Add(tGL_INVLabel);
            this.Controls.Add(this.dt_tglINV);
            this.Controls.Add(nO_PNWLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_noINV);
            this.Controls.Add(this.t_invoice_headerBindingNavigator);
            this.Name = "Invoice";
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.Invoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uASDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_invoice_headerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_invoice_headerBindingNavigator)).EndInit();
            this.t_invoice_headerBindingNavigator.ResumeLayout(false);
            this.t_invoice_headerBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mpelangganBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dataInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mbarangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tpenawaranheaderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UASDataSet uASDataSet;
        private System.Windows.Forms.BindingSource t_invoice_headerBindingSource;
        private UASDataSetTableAdapters.t_invoice_headerTableAdapter t_invoice_headerTableAdapter;
        private UASDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator t_invoice_headerBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton t_invoice_headerBindingNavigatorSaveItem;
        private UASDataSetTableAdapters.m_pelangganTableAdapter m_pelangganTableAdapter;
        private System.Windows.Forms.TextBox tb_noINV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dt_tglINV;
        private System.Windows.Forms.DateTimePicker dt_tglTerima;
        private System.Windows.Forms.ComboBox cb_Customer;
        private System.Windows.Forms.BindingSource mpelangganBindingSource;
        private System.Windows.Forms.TextBox tb_namaNPWP;
        private System.Windows.Forms.TextBox tb_alamatNPWP;
        private System.Windows.Forms.TextBox tb_kotaCustomer;
        private System.Windows.Forms.TextBox tb_namaNPWP2;
        private System.Windows.Forms.TextBox tb_alamatLengkap;
        private System.Windows.Forms.DataGridView dgv_dataInvoice;
        private System.Windows.Forms.TextBox tb_noteCustomer;
        private System.Windows.Forms.Button btn_hpsitem;
        private System.Windows.Forms.Button btn_tmbhitem;
        private UASDataSetTableAdapters.m_barangTableAdapter m_barangTableAdapter;
        private System.Windows.Forms.BindingSource mbarangBindingSource;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dISCOUNTTextBox;
        private System.Windows.Forms.TextBox pPNTextBox;
        private System.Windows.Forms.TextBox tb_totalBeli;
        private System.Windows.Forms.TextBox tb_grandTotal;
        public System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.ComboBox nO_PNWComboBox;
        private System.Windows.Forms.BindingSource tpenawaranheaderBindingSource;
        private UASDataSetTableAdapters.t_penawaran_headerTableAdapter t_penawaran_headerTableAdapter;
    }
}