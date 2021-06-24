
namespace Project_UAS_
{
    partial class Pembelian
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
            System.Windows.Forms.Label nO_NOTALabel;
            System.Windows.Forms.Label p_IDLabel;
            System.Windows.Forms.Label tGL_PNWLabel;
            System.Windows.Forms.Label kETERANGANLabel;
            System.Windows.Forms.Label fAKTUR_PAJLabel;
            System.Windows.Forms.Label nPWPLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pembelian));
            this.uASDataSet = new Project_UAS_.UASDataSet();
            this.t_pembelian_headerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_pembelian_headerTableAdapter = new Project_UAS_.UASDataSetTableAdapters.t_pembelian_headerTableAdapter();
            this.tableAdapterManager = new Project_UAS_.UASDataSetTableAdapters.TableAdapterManager();
            this.m_supplierTableAdapter = new Project_UAS_.UASDataSetTableAdapters.m_supplierTableAdapter();
            this.t_pembelian_headerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.t_pembelian_headerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nO_PNWTextBox = new System.Windows.Forms.TextBox();
            this.nO_NOTATextBox = new System.Windows.Forms.TextBox();
            this.p_IDComboBox = new System.Windows.Forms.ComboBox();
            this.msupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nAMA_NPWPTextBox = new System.Windows.Forms.TextBox();
            this.aLAMAT_NPWTextBox = new System.Windows.Forms.TextBox();
            this.kOTATextBox = new System.Windows.Forms.TextBox();
            this.tGL_PNWDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tb_NPWP2 = new System.Windows.Forms.TextBox();
            this.tb_Alamat = new System.Windows.Forms.TextBox();
            this.nOTETextBox = new System.Windows.Forms.TextBox();
            this.kETERANGANTextBox = new System.Windows.Forms.TextBox();
            this.fAKTUR_PAJTextBox = new System.Windows.Forms.TextBox();
            this.nPWPTextBox = new System.Windows.Forms.TextBox();
            this.dgv_databeli = new System.Windows.Forms.DataGridView();
            this.tb_qty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_nmbarang = new System.Windows.Forms.ComboBox();
            this.mbarangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.m_barangTableAdapter = new Project_UAS_.UASDataSetTableAdapters.m_barangTableAdapter();
            this.btn_tmbhitem = new System.Windows.Forms.Button();
            this.btn_hpsitem = new System.Windows.Forms.Button();
            nO_PNWLabel = new System.Windows.Forms.Label();
            nO_NOTALabel = new System.Windows.Forms.Label();
            p_IDLabel = new System.Windows.Forms.Label();
            tGL_PNWLabel = new System.Windows.Forms.Label();
            kETERANGANLabel = new System.Windows.Forms.Label();
            fAKTUR_PAJLabel = new System.Windows.Forms.Label();
            nPWPLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uASDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_pembelian_headerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_pembelian_headerBindingNavigator)).BeginInit();
            this.t_pembelian_headerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_databeli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mbarangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nO_PNWLabel
            // 
            nO_PNWLabel.AutoSize = true;
            nO_PNWLabel.Location = new System.Drawing.Point(32, 117);
            nO_PNWLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nO_PNWLabel.Name = "nO_PNWLabel";
            nO_PNWLabel.Size = new System.Drawing.Size(64, 20);
            nO_PNWLabel.TabIndex = 1;
            nO_PNWLabel.Text = "No Urut";
            // 
            // nO_NOTALabel
            // 
            nO_NOTALabel.AutoSize = true;
            nO_NOTALabel.Location = new System.Drawing.Point(248, 118);
            nO_NOTALabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nO_NOTALabel.Name = "nO_NOTALabel";
            nO_NOTALabel.Size = new System.Drawing.Size(71, 20);
            nO_NOTALabel.TabIndex = 3;
            nO_NOTALabel.Text = "No. Nota";
            // 
            // p_IDLabel
            // 
            p_IDLabel.AutoSize = true;
            p_IDLabel.Location = new System.Drawing.Point(68, 178);
            p_IDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            p_IDLabel.Name = "p_IDLabel";
            p_IDLabel.Size = new System.Drawing.Size(44, 20);
            p_IDLabel.TabIndex = 5;
            p_IDLabel.Text = "P ID:";
            // 
            // tGL_PNWLabel
            // 
            tGL_PNWLabel.AutoSize = true;
            tGL_PNWLabel.Location = new System.Drawing.Point(1122, 123);
            tGL_PNWLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tGL_PNWLabel.Name = "tGL_PNWLabel";
            tGL_PNWLabel.Size = new System.Drawing.Size(84, 20);
            tGL_PNWLabel.TabIndex = 10;
            tGL_PNWLabel.Text = "Tgl Invoice";
            // 
            // kETERANGANLabel
            // 
            kETERANGANLabel.AutoSize = true;
            kETERANGANLabel.Location = new System.Drawing.Point(29, 768);
            kETERANGANLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            kETERANGANLabel.Name = "kETERANGANLabel";
            kETERANGANLabel.Size = new System.Drawing.Size(123, 20);
            kETERANGANLabel.TabIndex = 15;
            kETERANGANLabel.Text = "KETERANGAN:";
            // 
            // fAKTUR_PAJLabel
            // 
            fAKTUR_PAJLabel.AutoSize = true;
            fAKTUR_PAJLabel.Location = new System.Drawing.Point(741, 118);
            fAKTUR_PAJLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            fAKTUR_PAJLabel.Name = "fAKTUR_PAJLabel";
            fAKTUR_PAJLabel.Size = new System.Drawing.Size(98, 20);
            fAKTUR_PAJLabel.TabIndex = 17;
            fAKTUR_PAJLabel.Text = "Faktur Pajak";
            // 
            // nPWPLabel
            // 
            nPWPLabel.AutoSize = true;
            nPWPLabel.Location = new System.Drawing.Point(492, 122);
            nPWPLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nPWPLabel.Name = "nPWPLabel";
            nPWPLabel.Size = new System.Drawing.Size(55, 20);
            nPWPLabel.TabIndex = 19;
            nPWPLabel.Text = "NPWP";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(1107, 237);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(52, 20);
            label1.TabIndex = 133;
            label1.Text = "NOTE";
            // 
            // uASDataSet
            // 
            this.uASDataSet.DataSetName = "UASDataSet";
            this.uASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_pembelian_headerBindingSource
            // 
            this.t_pembelian_headerBindingSource.DataMember = "t_pembelian_header";
            this.t_pembelian_headerBindingSource.DataSource = this.uASDataSet;
            // 
            // t_pembelian_headerTableAdapter
            // 
            this.t_pembelian_headerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.m_barangTableAdapter = null;
            this.tableAdapterManager.m_groupuserTableAdapter = null;
            this.tableAdapterManager.m_hakaksesgroupuserTableAdapter = null;
            this.tableAdapterManager.m_kotaTableAdapter = null;
            this.tableAdapterManager.m_merkTableAdapter = null;
            this.tableAdapterManager.m_modelTableAdapter = null;
            this.tableAdapterManager.m_pelangganTableAdapter = null;
            this.tableAdapterManager.m_supplierTableAdapter = this.m_supplierTableAdapter;
            this.tableAdapterManager.m_usersTableAdapter = null;
            this.tableAdapterManager.rework_detailTableAdapter = null;
            this.tableAdapterManager.reworkTableAdapter = null;
            this.tableAdapterManager.stock_historyTableAdapter = null;
            this.tableAdapterManager.stockTableAdapter = null;
            this.tableAdapterManager.t_invoice_detailTableAdapter = null;
            this.tableAdapterManager.t_invoice_headerTableAdapter = null;
            this.tableAdapterManager.t_invoiceppn_detailTableAdapter = null;
            this.tableAdapterManager.t_invoiceppn_headerTableAdapter = null;
            this.tableAdapterManager.t_label_hargaTableAdapter = null;
            this.tableAdapterManager.t_pembelian_detailTableAdapter = null;
            this.tableAdapterManager.t_pembelian_headerTableAdapter = this.t_pembelian_headerTableAdapter;
            this.tableAdapterManager.t_penawaran_detailTableAdapter = null;
            this.tableAdapterManager.t_penawaran_headerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Project_UAS_.UASDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // m_supplierTableAdapter
            // 
            this.m_supplierTableAdapter.ClearBeforeFill = true;
            // 
            // t_pembelian_headerBindingNavigator
            // 
            this.t_pembelian_headerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.t_pembelian_headerBindingNavigator.BindingSource = this.t_pembelian_headerBindingSource;
            this.t_pembelian_headerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.t_pembelian_headerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.t_pembelian_headerBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.t_pembelian_headerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.t_pembelian_headerBindingNavigatorSaveItem});
            this.t_pembelian_headerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.t_pembelian_headerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.t_pembelian_headerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.t_pembelian_headerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.t_pembelian_headerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.t_pembelian_headerBindingNavigator.Name = "t_pembelian_headerBindingNavigator";
            this.t_pembelian_headerBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.t_pembelian_headerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.t_pembelian_headerBindingNavigator.Size = new System.Drawing.Size(1497, 33);
            this.t_pembelian_headerBindingNavigator.TabIndex = 0;
            this.t_pembelian_headerBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.bindingNavigatorMoveFirstItem_Click);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(73, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.bindingNavigatorMoveLastItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // t_pembelian_headerBindingNavigatorSaveItem
            // 
            this.t_pembelian_headerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.t_pembelian_headerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("t_pembelian_headerBindingNavigatorSaveItem.Image")));
            this.t_pembelian_headerBindingNavigatorSaveItem.Name = "t_pembelian_headerBindingNavigatorSaveItem";
            this.t_pembelian_headerBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.t_pembelian_headerBindingNavigatorSaveItem.Text = "Save Data";
            this.t_pembelian_headerBindingNavigatorSaveItem.Click += new System.EventHandler(this.t_pembelian_headerBindingNavigatorSaveItem_Click);
            // 
            // nO_PNWTextBox
            // 
            this.nO_PNWTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_pembelian_headerBindingSource, "NO_PNW", true));
            this.nO_PNWTextBox.Location = new System.Drawing.Point(106, 112);
            this.nO_PNWTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nO_PNWTextBox.Name = "nO_PNWTextBox";
            this.nO_PNWTextBox.Size = new System.Drawing.Size(116, 26);
            this.nO_PNWTextBox.TabIndex = 2;
            // 
            // nO_NOTATextBox
            // 
            this.nO_NOTATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_pembelian_headerBindingSource, "NO_NOTA", true));
            this.nO_NOTATextBox.Location = new System.Drawing.Point(332, 114);
            this.nO_NOTATextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nO_NOTATextBox.Name = "nO_NOTATextBox";
            this.nO_NOTATextBox.Size = new System.Drawing.Size(140, 26);
            this.nO_NOTATextBox.TabIndex = 4;
            this.nO_NOTATextBox.TextChanged += new System.EventHandler(this.nO_NOTATextBox_TextChanged);
            // 
            // p_IDComboBox
            // 
            this.p_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_pembelian_headerBindingSource, "P_ID", true));
            this.p_IDComboBox.DataSource = this.msupplierBindingSource;
            this.p_IDComboBox.DisplayMember = "P_ID";
            this.p_IDComboBox.FormattingEnabled = true;
            this.p_IDComboBox.Location = new System.Drawing.Point(123, 174);
            this.p_IDComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.p_IDComboBox.Name = "p_IDComboBox";
            this.p_IDComboBox.Size = new System.Drawing.Size(148, 28);
            this.p_IDComboBox.TabIndex = 6;
            this.p_IDComboBox.ValueMember = "P_ID";
            // 
            // msupplierBindingSource
            // 
            this.msupplierBindingSource.DataMember = "m_supplier";
            this.msupplierBindingSource.DataSource = this.uASDataSet;
            // 
            // nAMA_NPWPTextBox
            // 
            this.nAMA_NPWPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.msupplierBindingSource, "NAMA_NPWP", true));
            this.nAMA_NPWPTextBox.Enabled = false;
            this.nAMA_NPWPTextBox.Location = new System.Drawing.Point(282, 174);
            this.nAMA_NPWPTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nAMA_NPWPTextBox.Name = "nAMA_NPWPTextBox";
            this.nAMA_NPWPTextBox.Size = new System.Drawing.Size(268, 26);
            this.nAMA_NPWPTextBox.TabIndex = 8;
            // 
            // aLAMAT_NPWTextBox
            // 
            this.aLAMAT_NPWTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.msupplierBindingSource, "ALAMAT_NPW", true));
            this.aLAMAT_NPWTextBox.Enabled = false;
            this.aLAMAT_NPWTextBox.Location = new System.Drawing.Point(561, 174);
            this.aLAMAT_NPWTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aLAMAT_NPWTextBox.Name = "aLAMAT_NPWTextBox";
            this.aLAMAT_NPWTextBox.Size = new System.Drawing.Size(390, 26);
            this.aLAMAT_NPWTextBox.TabIndex = 9;
            // 
            // kOTATextBox
            // 
            this.kOTATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.msupplierBindingSource, "KOTA", true));
            this.kOTATextBox.Enabled = false;
            this.kOTATextBox.Location = new System.Drawing.Point(962, 174);
            this.kOTATextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kOTATextBox.Name = "kOTATextBox";
            this.kOTATextBox.Size = new System.Drawing.Size(496, 26);
            this.kOTATextBox.TabIndex = 10;
            // 
            // tGL_PNWDateTimePicker
            // 
            this.tGL_PNWDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.t_pembelian_headerBindingSource, "TGL_PNW", true));
            this.tGL_PNWDateTimePicker.Location = new System.Drawing.Point(1221, 117);
            this.tGL_PNWDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tGL_PNWDateTimePicker.Name = "tGL_PNWDateTimePicker";
            this.tGL_PNWDateTimePicker.Size = new System.Drawing.Size(236, 26);
            this.tGL_PNWDateTimePicker.TabIndex = 11;
            // 
            // tb_NPWP2
            // 
            this.tb_NPWP2.Enabled = false;
            this.tb_NPWP2.Location = new System.Drawing.Point(36, 232);
            this.tb_NPWP2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_NPWP2.Name = "tb_NPWP2";
            this.tb_NPWP2.Size = new System.Drawing.Size(355, 26);
            this.tb_NPWP2.TabIndex = 12;
            // 
            // tb_Alamat
            // 
            this.tb_Alamat.Enabled = false;
            this.tb_Alamat.Location = new System.Drawing.Point(402, 232);
            this.tb_Alamat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Alamat.Name = "tb_Alamat";
            this.tb_Alamat.Size = new System.Drawing.Size(685, 26);
            this.tb_Alamat.TabIndex = 13;
            // 
            // nOTETextBox
            // 
            this.nOTETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.msupplierBindingSource, "NOTE", true));
            this.nOTETextBox.Enabled = false;
            this.nOTETextBox.Location = new System.Drawing.Point(1172, 232);
            this.nOTETextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nOTETextBox.Name = "nOTETextBox";
            this.nOTETextBox.Size = new System.Drawing.Size(286, 26);
            this.nOTETextBox.TabIndex = 15;
            // 
            // kETERANGANTextBox
            // 
            this.kETERANGANTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_pembelian_headerBindingSource, "KETERANGAN", true));
            this.kETERANGANTextBox.Location = new System.Drawing.Point(174, 763);
            this.kETERANGANTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kETERANGANTextBox.Name = "kETERANGANTextBox";
            this.kETERANGANTextBox.Size = new System.Drawing.Size(208, 26);
            this.kETERANGANTextBox.TabIndex = 16;
            // 
            // fAKTUR_PAJTextBox
            // 
            this.fAKTUR_PAJTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_pembelian_headerBindingSource, "FAKTUR_PAJ", true));
            this.fAKTUR_PAJTextBox.Location = new System.Drawing.Point(850, 117);
            this.fAKTUR_PAJTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fAKTUR_PAJTextBox.Name = "fAKTUR_PAJTextBox";
            this.fAKTUR_PAJTextBox.Size = new System.Drawing.Size(222, 26);
            this.fAKTUR_PAJTextBox.TabIndex = 18;
            // 
            // nPWPTextBox
            // 
            this.nPWPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.msupplierBindingSource, "NPWP", true));
            this.nPWPTextBox.Location = new System.Drawing.Point(561, 114);
            this.nPWPTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nPWPTextBox.Name = "nPWPTextBox";
            this.nPWPTextBox.Size = new System.Drawing.Size(145, 26);
            this.nPWPTextBox.TabIndex = 20;
            // 
            // dgv_databeli
            // 
            this.dgv_databeli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_databeli.BackgroundColor = System.Drawing.Color.White;
            this.dgv_databeli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_databeli.Location = new System.Drawing.Point(33, 312);
            this.dgv_databeli.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_databeli.Name = "dgv_databeli";
            this.dgv_databeli.ReadOnly = true;
            this.dgv_databeli.RowHeadersWidth = 62;
            this.dgv_databeli.Size = new System.Drawing.Size(1424, 364);
            this.dgv_databeli.TabIndex = 135;
            // 
            // tb_qty
            // 
            this.tb_qty.Location = new System.Drawing.Point(174, 907);
            this.tb_qty.Name = "tb_qty";
            this.tb_qty.Size = new System.Drawing.Size(208, 26);
            this.tb_qty.TabIndex = 136;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 910);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 137;
            this.label2.Text = "QTY :";
            // 
            // cb_nmbarang
            // 
            this.cb_nmbarang.DataSource = this.mbarangBindingSource;
            this.cb_nmbarang.DisplayMember = "DESCRIPTION";
            this.cb_nmbarang.FormattingEnabled = true;
            this.cb_nmbarang.Location = new System.Drawing.Point(174, 831);
            this.cb_nmbarang.Name = "cb_nmbarang";
            this.cb_nmbarang.Size = new System.Drawing.Size(208, 28);
            this.cb_nmbarang.TabIndex = 138;
            this.cb_nmbarang.ValueMember = "ID";
            // 
            // mbarangBindingSource
            // 
            this.mbarangBindingSource.DataMember = "m_barang";
            this.mbarangBindingSource.DataSource = this.uASDataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 839);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 139;
            this.label3.Text = "NAMA BARANG :";
            // 
            // m_barangTableAdapter
            // 
            this.m_barangTableAdapter.ClearBeforeFill = true;
            // 
            // btn_tmbhitem
            // 
            this.btn_tmbhitem.Location = new System.Drawing.Point(442, 910);
            this.btn_tmbhitem.Name = "btn_tmbhitem";
            this.btn_tmbhitem.Size = new System.Drawing.Size(140, 45);
            this.btn_tmbhitem.TabIndex = 140;
            this.btn_tmbhitem.Text = "TAMBAH ITEM";
            this.btn_tmbhitem.UseVisualStyleBackColor = true;
            this.btn_tmbhitem.Click += new System.EventHandler(this.btn_tmbhitem_Click);
            // 
            // btn_hpsitem
            // 
            this.btn_hpsitem.Location = new System.Drawing.Point(588, 910);
            this.btn_hpsitem.Name = "btn_hpsitem";
            this.btn_hpsitem.Size = new System.Drawing.Size(140, 45);
            this.btn_hpsitem.TabIndex = 141;
            this.btn_hpsitem.Text = "HAPUS ITEM";
            this.btn_hpsitem.UseVisualStyleBackColor = true;
            // 
            // Pembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1497, 1050);
            this.Controls.Add(this.btn_hpsitem);
            this.Controls.Add(this.btn_tmbhitem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_nmbarang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_qty);
            this.Controls.Add(this.dgv_databeli);
            this.Controls.Add(label1);
            this.Controls.Add(nPWPLabel);
            this.Controls.Add(this.nPWPTextBox);
            this.Controls.Add(fAKTUR_PAJLabel);
            this.Controls.Add(this.fAKTUR_PAJTextBox);
            this.Controls.Add(kETERANGANLabel);
            this.Controls.Add(this.kETERANGANTextBox);
            this.Controls.Add(this.nOTETextBox);
            this.Controls.Add(this.tb_Alamat);
            this.Controls.Add(this.tb_NPWP2);
            this.Controls.Add(tGL_PNWLabel);
            this.Controls.Add(this.tGL_PNWDateTimePicker);
            this.Controls.Add(this.kOTATextBox);
            this.Controls.Add(this.aLAMAT_NPWTextBox);
            this.Controls.Add(this.nAMA_NPWPTextBox);
            this.Controls.Add(p_IDLabel);
            this.Controls.Add(this.p_IDComboBox);
            this.Controls.Add(nO_NOTALabel);
            this.Controls.Add(this.nO_NOTATextBox);
            this.Controls.Add(nO_PNWLabel);
            this.Controls.Add(this.nO_PNWTextBox);
            this.Controls.Add(this.t_pembelian_headerBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Pembelian";
            this.Text = "Pembelian";
            this.Load += new System.EventHandler(this.Pembelian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uASDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_pembelian_headerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_pembelian_headerBindingNavigator)).EndInit();
            this.t_pembelian_headerBindingNavigator.ResumeLayout(false);
            this.t_pembelian_headerBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_databeli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mbarangBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UASDataSet uASDataSet;
        private System.Windows.Forms.BindingSource t_pembelian_headerBindingSource;
        private UASDataSetTableAdapters.t_pembelian_headerTableAdapter t_pembelian_headerTableAdapter;
        private UASDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator t_pembelian_headerBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton t_pembelian_headerBindingNavigatorSaveItem;
        private UASDataSetTableAdapters.m_supplierTableAdapter m_supplierTableAdapter;
        private System.Windows.Forms.TextBox nO_PNWTextBox;
        private System.Windows.Forms.TextBox nO_NOTATextBox;
        private System.Windows.Forms.ComboBox p_IDComboBox;
        private System.Windows.Forms.BindingSource msupplierBindingSource;
        private System.Windows.Forms.TextBox nAMA_NPWPTextBox;
        private System.Windows.Forms.TextBox aLAMAT_NPWTextBox;
        private System.Windows.Forms.TextBox kOTATextBox;
        private System.Windows.Forms.DateTimePicker tGL_PNWDateTimePicker;
        private System.Windows.Forms.TextBox tb_NPWP2;
        private System.Windows.Forms.TextBox tb_Alamat;
        private System.Windows.Forms.TextBox nOTETextBox;
        private System.Windows.Forms.TextBox kETERANGANTextBox;
        private System.Windows.Forms.TextBox fAKTUR_PAJTextBox;
        private System.Windows.Forms.TextBox nPWPTextBox;
        private System.Windows.Forms.DataGridView dgv_databeli;
        private System.Windows.Forms.TextBox tb_qty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_nmbarang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource mbarangBindingSource;
        private UASDataSetTableAdapters.m_barangTableAdapter m_barangTableAdapter;
        private System.Windows.Forms.Button btn_tmbhitem;
        private System.Windows.Forms.Button btn_hpsitem;
    }
}