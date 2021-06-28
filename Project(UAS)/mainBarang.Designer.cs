
namespace Project_UAS_
{
    partial class mainBarang
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
            System.Windows.Forms.Label kODELabel;
            System.Windows.Forms.Label dESCRIPTIONLabel;
            System.Windows.Forms.Label pART_NOLabel;
            System.Windows.Forms.Label pN1Label;
            System.Windows.Forms.Label uNIT_PRICELabel;
            System.Windows.Forms.Label uNITLabel;
            System.Windows.Forms.Label sTAMPINGLabel;
            System.Windows.Forms.Label dATA_FISIKLabel;
            System.Windows.Forms.Label pERSAMAANLabel;
            System.Windows.Forms.Label kETERANGANLabel;
            System.Windows.Forms.Label mERK1Label;
            System.Windows.Forms.Label mERK2Label;
            System.Windows.Forms.Label mERK3Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainBarang));
            this.uASDataSet = new Project_UAS_.UASDataSet();
            this.m_barangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_barangTableAdapter = new Project_UAS_.UASDataSetTableAdapters.m_barangTableAdapter();
            this.tableAdapterManager = new Project_UAS_.UASDataSetTableAdapters.TableAdapterManager();
            this.m_merkTableAdapter = new Project_UAS_.UASDataSetTableAdapters.m_merkTableAdapter();
            this.m_barangBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.m_barangBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.kODETextBox = new System.Windows.Forms.TextBox();
            this.dESCRIPTIONTextBox = new System.Windows.Forms.TextBox();
            this.pART_NOTextBox = new System.Windows.Forms.TextBox();
            this.pN1TextBox = new System.Windows.Forms.TextBox();
            this.uNIT_PRICETextBox = new System.Windows.Forms.TextBox();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.uNITTextBox = new System.Windows.Forms.TextBox();
            this.sTAMPINGTextBox = new System.Windows.Forms.TextBox();
            this.dATA_FISIKTextBox = new System.Windows.Forms.TextBox();
            this.pERSAMAANTextBox = new System.Windows.Forms.TextBox();
            this.kETERANGANTextBox = new System.Windows.Forms.TextBox();
            this.mERK1ComboBox = new System.Windows.Forms.ComboBox();
            this.mmerkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mERK2ComboBox = new System.Windows.Forms.ComboBox();
            this.mmerkBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mERK3ComboBox = new System.Windows.Forms.ComboBox();
            this.mmerkBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Print = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            kODELabel = new System.Windows.Forms.Label();
            dESCRIPTIONLabel = new System.Windows.Forms.Label();
            pART_NOLabel = new System.Windows.Forms.Label();
            pN1Label = new System.Windows.Forms.Label();
            uNIT_PRICELabel = new System.Windows.Forms.Label();
            uNITLabel = new System.Windows.Forms.Label();
            sTAMPINGLabel = new System.Windows.Forms.Label();
            dATA_FISIKLabel = new System.Windows.Forms.Label();
            pERSAMAANLabel = new System.Windows.Forms.Label();
            kETERANGANLabel = new System.Windows.Forms.Label();
            mERK1Label = new System.Windows.Forms.Label();
            mERK2Label = new System.Windows.Forms.Label();
            mERK3Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uASDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_barangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_barangBindingNavigator)).BeginInit();
            this.m_barangBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mmerkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmerkBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmerkBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // kODELabel
            // 
            kODELabel.AutoSize = true;
            kODELabel.BackColor = System.Drawing.Color.Transparent;
            kODELabel.ForeColor = System.Drawing.Color.White;
            kODELabel.Location = new System.Drawing.Point(40, 163);
            kODELabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            kODELabel.Name = "kODELabel";
            kODELabel.Size = new System.Drawing.Size(110, 20);
            kODELabel.TabIndex = 1;
            kODELabel.Text = "Kode Barang :";
            // 
            // dESCRIPTIONLabel
            // 
            dESCRIPTIONLabel.AutoSize = true;
            dESCRIPTIONLabel.BackColor = System.Drawing.Color.Transparent;
            dESCRIPTIONLabel.ForeColor = System.Drawing.Color.White;
            dESCRIPTIONLabel.Location = new System.Drawing.Point(36, 214);
            dESCRIPTIONLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dESCRIPTIONLabel.Name = "dESCRIPTIONLabel";
            dESCRIPTIONLabel.Size = new System.Drawing.Size(115, 20);
            dESCRIPTIONLabel.TabIndex = 3;
            dESCRIPTIONLabel.Text = "Nama Barang :";
            // 
            // pART_NOLabel
            // 
            pART_NOLabel.AutoSize = true;
            pART_NOLabel.BackColor = System.Drawing.Color.Transparent;
            pART_NOLabel.ForeColor = System.Drawing.Color.White;
            pART_NOLabel.Location = new System.Drawing.Point(388, 163);
            pART_NOLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pART_NOLabel.Name = "pART_NOLabel";
            pART_NOLabel.Size = new System.Drawing.Size(106, 20);
            pART_NOLabel.TabIndex = 5;
            pART_NOLabel.Text = "Part Number :";
            // 
            // pN1Label
            // 
            pN1Label.AutoSize = true;
            pN1Label.BackColor = System.Drawing.Color.Transparent;
            pN1Label.ForeColor = System.Drawing.Color.White;
            pN1Label.Location = new System.Drawing.Point(772, 163);
            pN1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pN1Label.Name = "pN1Label";
            pN1Label.Size = new System.Drawing.Size(59, 20);
            pN1Label.TabIndex = 7;
            pN1Label.Text = "P / N 1:";
            // 
            // uNIT_PRICELabel
            // 
            uNIT_PRICELabel.AutoSize = true;
            uNIT_PRICELabel.BackColor = System.Drawing.Color.Transparent;
            uNIT_PRICELabel.ForeColor = System.Drawing.Color.White;
            uNIT_PRICELabel.Location = new System.Drawing.Point(1078, 163);
            uNIT_PRICELabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            uNIT_PRICELabel.Name = "uNIT_PRICELabel";
            uNIT_PRICELabel.Size = new System.Drawing.Size(117, 20);
            uNIT_PRICELabel.TabIndex = 9;
            uNIT_PRICELabel.Text = "Harga Satuan :";
            // 
            // uNITLabel
            // 
            uNITLabel.AutoSize = true;
            uNITLabel.BackColor = System.Drawing.Color.Transparent;
            uNITLabel.ForeColor = System.Drawing.Color.White;
            uNITLabel.Location = new System.Drawing.Point(448, 214);
            uNITLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            uNITLabel.Name = "uNITLabel";
            uNITLabel.Size = new System.Drawing.Size(46, 20);
            uNITLabel.TabIndex = 68;
            uNITLabel.Text = "Unit :";
            // 
            // sTAMPINGLabel
            // 
            sTAMPINGLabel.AutoSize = true;
            sTAMPINGLabel.BackColor = System.Drawing.Color.Transparent;
            sTAMPINGLabel.ForeColor = System.Drawing.Color.White;
            sTAMPINGLabel.Location = new System.Drawing.Point(68, 266);
            sTAMPINGLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sTAMPINGLabel.Name = "sTAMPINGLabel";
            sTAMPINGLabel.Size = new System.Drawing.Size(85, 20);
            sTAMPINGLabel.TabIndex = 69;
            sTAMPINGLabel.Text = "Stamping :";
            // 
            // dATA_FISIKLabel
            // 
            dATA_FISIKLabel.AutoSize = true;
            dATA_FISIKLabel.BackColor = System.Drawing.Color.Transparent;
            dATA_FISIKLabel.ForeColor = System.Drawing.Color.White;
            dATA_FISIKLabel.Location = new System.Drawing.Point(406, 266);
            dATA_FISIKLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dATA_FISIKLabel.Name = "dATA_FISIKLabel";
            dATA_FISIKLabel.Size = new System.Drawing.Size(88, 20);
            dATA_FISIKLabel.TabIndex = 70;
            dATA_FISIKLabel.Text = "Data Fisik :";
            // 
            // pERSAMAANLabel
            // 
            pERSAMAANLabel.AutoSize = true;
            pERSAMAANLabel.BackColor = System.Drawing.Color.Transparent;
            pERSAMAANLabel.ForeColor = System.Drawing.Color.White;
            pERSAMAANLabel.Location = new System.Drawing.Point(741, 266);
            pERSAMAANLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pERSAMAANLabel.Name = "pERSAMAANLabel";
            pERSAMAANLabel.Size = new System.Drawing.Size(98, 20);
            pERSAMAANLabel.TabIndex = 71;
            pERSAMAANLabel.Text = "Persamaan :";
            // 
            // kETERANGANLabel
            // 
            kETERANGANLabel.AutoSize = true;
            kETERANGANLabel.BackColor = System.Drawing.Color.Transparent;
            kETERANGANLabel.ForeColor = System.Drawing.Color.White;
            kETERANGANLabel.Location = new System.Drawing.Point(51, 405);
            kETERANGANLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            kETERANGANLabel.Name = "kETERANGANLabel";
            kETERANGANLabel.Size = new System.Drawing.Size(100, 20);
            kETERANGANLabel.TabIndex = 75;
            kETERANGANLabel.Text = "Keterangan :";
            // 
            // mERK1Label
            // 
            mERK1Label.AutoSize = true;
            mERK1Label.BackColor = System.Drawing.Color.Transparent;
            mERK1Label.ForeColor = System.Drawing.Color.White;
            mERK1Label.Location = new System.Drawing.Point(84, 322);
            mERK1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mERK1Label.Name = "mERK1Label";
            mERK1Label.Size = new System.Drawing.Size(65, 20);
            mERK1Label.TabIndex = 76;
            mERK1Label.Text = "Merk 1 :";
            // 
            // mERK2Label
            // 
            mERK2Label.AutoSize = true;
            mERK2Label.BackColor = System.Drawing.Color.Transparent;
            mERK2Label.ForeColor = System.Drawing.Color.White;
            mERK2Label.Location = new System.Drawing.Point(428, 322);
            mERK2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mERK2Label.Name = "mERK2Label";
            mERK2Label.Size = new System.Drawing.Size(65, 20);
            mERK2Label.TabIndex = 77;
            mERK2Label.Text = "Merk 2 :";
            // 
            // mERK3Label
            // 
            mERK3Label.AutoSize = true;
            mERK3Label.BackColor = System.Drawing.Color.Transparent;
            mERK3Label.ForeColor = System.Drawing.Color.White;
            mERK3Label.Location = new System.Drawing.Point(771, 322);
            mERK3Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mERK3Label.Name = "mERK3Label";
            mERK3Label.Size = new System.Drawing.Size(65, 20);
            mERK3Label.TabIndex = 78;
            mERK3Label.Text = "Merk 3 :";
            // 
            // uASDataSet
            // 
            this.uASDataSet.DataSetName = "UASDataSet";
            this.uASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // m_barangBindingSource
            // 
            this.m_barangBindingSource.DataMember = "m_barang";
            this.m_barangBindingSource.DataSource = this.uASDataSet;
            // 
            // m_barangTableAdapter
            // 
            this.m_barangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.m_barangTableAdapter = this.m_barangTableAdapter;
            this.tableAdapterManager.m_groupuserTableAdapter = null;
            this.tableAdapterManager.m_hakaksesgroupuserTableAdapter = null;
            this.tableAdapterManager.m_kotaTableAdapter = null;
            this.tableAdapterManager.m_merkTableAdapter = this.m_merkTableAdapter;
            this.tableAdapterManager.m_modelTableAdapter = null;
            this.tableAdapterManager.m_pelangganTableAdapter = null;
            this.tableAdapterManager.m_supplierTableAdapter = null;
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
            this.tableAdapterManager.t_pembelian_headerTableAdapter = null;
            this.tableAdapterManager.t_penawaran_detailTableAdapter = null;
            this.tableAdapterManager.t_penawaran_headerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Project_UAS_.UASDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // m_merkTableAdapter
            // 
            this.m_merkTableAdapter.ClearBeforeFill = true;
            // 
            // m_barangBindingNavigator
            // 
            this.m_barangBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.m_barangBindingNavigator.BindingSource = this.m_barangBindingSource;
            this.m_barangBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.m_barangBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.m_barangBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.m_barangBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.m_barangBindingNavigatorSaveItem});
            this.m_barangBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.m_barangBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.m_barangBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.m_barangBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.m_barangBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.m_barangBindingNavigator.Name = "m_barangBindingNavigator";
            this.m_barangBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.m_barangBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.m_barangBindingNavigator.Size = new System.Drawing.Size(1454, 38);
            this.m_barangBindingNavigator.TabIndex = 0;
            this.m_barangBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 33);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 38);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // m_barangBindingNavigatorSaveItem
            // 
            this.m_barangBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_barangBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("m_barangBindingNavigatorSaveItem.Image")));
            this.m_barangBindingNavigatorSaveItem.Name = "m_barangBindingNavigatorSaveItem";
            this.m_barangBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 33);
            this.m_barangBindingNavigatorSaveItem.Text = "Save Data";
            this.m_barangBindingNavigatorSaveItem.Click += new System.EventHandler(this.m_barangBindingNavigatorSaveItem_Click);
            // 
            // kODETextBox
            // 
            this.kODETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "KODE", true));
            this.kODETextBox.Location = new System.Drawing.Point(162, 158);
            this.kODETextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kODETextBox.Name = "kODETextBox";
            this.kODETextBox.Size = new System.Drawing.Size(188, 26);
            this.kODETextBox.TabIndex = 2;
            // 
            // dESCRIPTIONTextBox
            // 
            this.dESCRIPTIONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "DESCRIPTION", true));
            this.dESCRIPTIONTextBox.Location = new System.Drawing.Point(162, 209);
            this.dESCRIPTIONTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dESCRIPTIONTextBox.Name = "dESCRIPTIONTextBox";
            this.dESCRIPTIONTextBox.Size = new System.Drawing.Size(188, 26);
            this.dESCRIPTIONTextBox.TabIndex = 4;
            // 
            // pART_NOTextBox
            // 
            this.pART_NOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "PART_NO", true));
            this.pART_NOTextBox.Location = new System.Drawing.Point(506, 158);
            this.pART_NOTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pART_NOTextBox.Name = "pART_NOTextBox";
            this.pART_NOTextBox.Size = new System.Drawing.Size(188, 26);
            this.pART_NOTextBox.TabIndex = 6;
            // 
            // pN1TextBox
            // 
            this.pN1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "PN1", true));
            this.pN1TextBox.Location = new System.Drawing.Point(849, 158);
            this.pN1TextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pN1TextBox.Name = "pN1TextBox";
            this.pN1TextBox.Size = new System.Drawing.Size(188, 26);
            this.pN1TextBox.TabIndex = 8;
            // 
            // uNIT_PRICETextBox
            // 
            this.uNIT_PRICETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "UNIT_PRICE", true));
            this.uNIT_PRICETextBox.Location = new System.Drawing.Point(1206, 158);
            this.uNIT_PRICETextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uNIT_PRICETextBox.Name = "uNIT_PRICETextBox";
            this.uNIT_PRICETextBox.Size = new System.Drawing.Size(188, 26);
            this.uNIT_PRICETextBox.TabIndex = 10;
            // 
            // btn_Browse
            // 
            this.btn_Browse.BackColor = System.Drawing.Color.Orange;
            this.btn_Browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Browse.ForeColor = System.Drawing.Color.White;
            this.btn_Browse.Location = new System.Drawing.Point(388, 494);
            this.btn_Browse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(212, 71);
            this.btn_Browse.TabIndex = 68;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.UseVisualStyleBackColor = false;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(537, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 47);
            this.label1.TabIndex = 67;
            this.label1.Text = "Input Master Barang";
            // 
            // uNITTextBox
            // 
            this.uNITTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "UNIT", true));
            this.uNITTextBox.Location = new System.Drawing.Point(506, 209);
            this.uNITTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uNITTextBox.Name = "uNITTextBox";
            this.uNITTextBox.Size = new System.Drawing.Size(188, 26);
            this.uNITTextBox.TabIndex = 69;
            // 
            // sTAMPINGTextBox
            // 
            this.sTAMPINGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "STAMPING", true));
            this.sTAMPINGTextBox.Location = new System.Drawing.Point(162, 262);
            this.sTAMPINGTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sTAMPINGTextBox.Name = "sTAMPINGTextBox";
            this.sTAMPINGTextBox.Size = new System.Drawing.Size(188, 26);
            this.sTAMPINGTextBox.TabIndex = 70;
            // 
            // dATA_FISIKTextBox
            // 
            this.dATA_FISIKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "DATA_FISIK", true));
            this.dATA_FISIKTextBox.Location = new System.Drawing.Point(506, 262);
            this.dATA_FISIKTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dATA_FISIKTextBox.Name = "dATA_FISIKTextBox";
            this.dATA_FISIKTextBox.Size = new System.Drawing.Size(188, 26);
            this.dATA_FISIKTextBox.TabIndex = 71;
            // 
            // pERSAMAANTextBox
            // 
            this.pERSAMAANTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "PERSAMAAN", true));
            this.pERSAMAANTextBox.Location = new System.Drawing.Point(849, 262);
            this.pERSAMAANTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pERSAMAANTextBox.Name = "pERSAMAANTextBox";
            this.pERSAMAANTextBox.Size = new System.Drawing.Size(188, 26);
            this.pERSAMAANTextBox.TabIndex = 72;
            // 
            // kETERANGANTextBox
            // 
            this.kETERANGANTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "KETERANGAN", true));
            this.kETERANGANTextBox.Location = new System.Drawing.Point(162, 400);
            this.kETERANGANTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kETERANGANTextBox.Name = "kETERANGANTextBox";
            this.kETERANGANTextBox.Size = new System.Drawing.Size(1232, 26);
            this.kETERANGANTextBox.TabIndex = 76;
            // 
            // mERK1ComboBox
            // 
            this.mERK1ComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "MERK1", true));
            this.mERK1ComboBox.DataSource = this.mmerkBindingSource;
            this.mERK1ComboBox.DisplayMember = "MERK_DESC";
            this.mERK1ComboBox.FormattingEnabled = true;
            this.mERK1ComboBox.Location = new System.Drawing.Point(162, 317);
            this.mERK1ComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mERK1ComboBox.Name = "mERK1ComboBox";
            this.mERK1ComboBox.Size = new System.Drawing.Size(188, 28);
            this.mERK1ComboBox.TabIndex = 77;
            this.mERK1ComboBox.ValueMember = "ID";
            // 
            // mmerkBindingSource
            // 
            this.mmerkBindingSource.DataMember = "m_merk";
            this.mmerkBindingSource.DataSource = this.uASDataSet;
            // 
            // mERK2ComboBox
            // 
            this.mERK2ComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "MERK2", true));
            this.mERK2ComboBox.DataSource = this.mmerkBindingSource1;
            this.mERK2ComboBox.DisplayMember = "MERK_DESC";
            this.mERK2ComboBox.FormattingEnabled = true;
            this.mERK2ComboBox.Location = new System.Drawing.Point(506, 317);
            this.mERK2ComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mERK2ComboBox.Name = "mERK2ComboBox";
            this.mERK2ComboBox.Size = new System.Drawing.Size(188, 28);
            this.mERK2ComboBox.TabIndex = 78;
            this.mERK2ComboBox.ValueMember = "ID";
            // 
            // mmerkBindingSource1
            // 
            this.mmerkBindingSource1.DataMember = "m_merk";
            this.mmerkBindingSource1.DataSource = this.uASDataSet;
            // 
            // mERK3ComboBox
            // 
            this.mERK3ComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "MERK3", true));
            this.mERK3ComboBox.DataSource = this.mmerkBindingSource2;
            this.mERK3ComboBox.DisplayMember = "MERK_DESC";
            this.mERK3ComboBox.FormattingEnabled = true;
            this.mERK3ComboBox.Location = new System.Drawing.Point(849, 317);
            this.mERK3ComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mERK3ComboBox.Name = "mERK3ComboBox";
            this.mERK3ComboBox.Size = new System.Drawing.Size(188, 28);
            this.mERK3ComboBox.TabIndex = 79;
            this.mERK3ComboBox.ValueMember = "ID";
            // 
            // mmerkBindingSource2
            // 
            this.mmerkBindingSource2.DataMember = "m_merk";
            this.mmerkBindingSource2.DataSource = this.uASDataSet;
            // 
            // btn_Print
            // 
            this.btn_Print.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Print.ForeColor = System.Drawing.Color.White;
            this.btn_Print.Location = new System.Drawing.Point(609, 494);
            this.btn_Print.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(212, 71);
            this.btn_Print.TabIndex = 80;
            this.btn_Print.Text = "Print";
            this.btn_Print.UseVisualStyleBackColor = false;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Red;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Location = new System.Drawing.Point(830, 494);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(212, 71);
            this.btn_Exit.TabIndex = 108;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // mainBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1454, 600);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(mERK3Label);
            this.Controls.Add(this.mERK3ComboBox);
            this.Controls.Add(mERK2Label);
            this.Controls.Add(this.mERK2ComboBox);
            this.Controls.Add(mERK1Label);
            this.Controls.Add(this.mERK1ComboBox);
            this.Controls.Add(kETERANGANLabel);
            this.Controls.Add(this.kETERANGANTextBox);
            this.Controls.Add(pERSAMAANLabel);
            this.Controls.Add(this.pERSAMAANTextBox);
            this.Controls.Add(dATA_FISIKLabel);
            this.Controls.Add(this.dATA_FISIKTextBox);
            this.Controls.Add(sTAMPINGLabel);
            this.Controls.Add(this.sTAMPINGTextBox);
            this.Controls.Add(uNITLabel);
            this.Controls.Add(this.uNITTextBox);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.label1);
            this.Controls.Add(uNIT_PRICELabel);
            this.Controls.Add(this.uNIT_PRICETextBox);
            this.Controls.Add(pN1Label);
            this.Controls.Add(this.pN1TextBox);
            this.Controls.Add(pART_NOLabel);
            this.Controls.Add(this.pART_NOTextBox);
            this.Controls.Add(dESCRIPTIONLabel);
            this.Controls.Add(this.dESCRIPTIONTextBox);
            this.Controls.Add(kODELabel);
            this.Controls.Add(this.kODETextBox);
            this.Controls.Add(this.m_barangBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "mainBarang";
            this.Text = "Master Barang";
            this.Load += new System.EventHandler(this.mainBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uASDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_barangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_barangBindingNavigator)).EndInit();
            this.m_barangBindingNavigator.ResumeLayout(false);
            this.m_barangBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mmerkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmerkBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmerkBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UASDataSet uASDataSet;
        private System.Windows.Forms.BindingSource m_barangBindingSource;
        private UASDataSetTableAdapters.m_barangTableAdapter m_barangTableAdapter;
        private UASDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator m_barangBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton m_barangBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox kODETextBox;
        private System.Windows.Forms.TextBox dESCRIPTIONTextBox;
        private System.Windows.Forms.TextBox pART_NOTextBox;
        private System.Windows.Forms.TextBox pN1TextBox;
        private System.Windows.Forms.TextBox uNIT_PRICETextBox;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uNITTextBox;
        private System.Windows.Forms.TextBox sTAMPINGTextBox;
        private System.Windows.Forms.TextBox dATA_FISIKTextBox;
        private System.Windows.Forms.TextBox pERSAMAANTextBox;
        private System.Windows.Forms.TextBox kETERANGANTextBox;
        private UASDataSetTableAdapters.m_merkTableAdapter m_merkTableAdapter;
        private System.Windows.Forms.ComboBox mERK1ComboBox;
        private System.Windows.Forms.ComboBox mERK2ComboBox;
        private System.Windows.Forms.ComboBox mERK3ComboBox;
        private System.Windows.Forms.BindingSource mmerkBindingSource;
        private System.Windows.Forms.BindingSource mmerkBindingSource1;
        private System.Windows.Forms.BindingSource mmerkBindingSource2;
        private System.Windows.Forms.Button btn_Print;
        public System.Windows.Forms.Button btn_Exit;
    }
}