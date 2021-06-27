
namespace Project_UAS_
{
    partial class masterSupplier
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
            System.Windows.Forms.Label p_IDLabel;
            System.Windows.Forms.Label bANKLabel;
            System.Windows.Forms.Label tELP_HPLabel;
            System.Windows.Forms.Label nAMALabel;
            System.Windows.Forms.Label aLAMATLabel;
            System.Windows.Forms.Label nAMA_NPWPLabel;
            System.Windows.Forms.Label nPWPLabel;
            System.Windows.Forms.Label aLAMAT_NPWLabel;
            System.Windows.Forms.Label nOTELabel;
            System.Windows.Forms.Label eMAILLabel;
            System.Windows.Forms.Label kOTALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(masterSupplier));
            this.btn_Browse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.uASDataSet = new Project_UAS_.UASDataSet();
            this.m_supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_supplierTableAdapter = new Project_UAS_.UASDataSetTableAdapters.m_supplierTableAdapter();
            this.tableAdapterManager = new Project_UAS_.UASDataSetTableAdapters.TableAdapterManager();
            this.m_kotaTableAdapter = new Project_UAS_.UASDataSetTableAdapters.m_kotaTableAdapter();
            this.m_supplierBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.m_supplierBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.p_IDTextBox = new System.Windows.Forms.TextBox();
            this.bANKTextBox = new System.Windows.Forms.TextBox();
            this.tELP_HPTextBox = new System.Windows.Forms.TextBox();
            this.nAMATextBox = new System.Windows.Forms.TextBox();
            this.aLAMATTextBox = new System.Windows.Forms.TextBox();
            this.nAMA_NPWPTextBox = new System.Windows.Forms.TextBox();
            this.nPWPTextBox = new System.Windows.Forms.TextBox();
            this.aLAMAT_NPWTextBox = new System.Windows.Forms.TextBox();
            this.nOTETextBox = new System.Windows.Forms.TextBox();
            this.eMAILTextBox = new System.Windows.Forms.TextBox();
            this.kOTAComboBox = new System.Windows.Forms.ComboBox();
            this.mkotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Print = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            p_IDLabel = new System.Windows.Forms.Label();
            bANKLabel = new System.Windows.Forms.Label();
            tELP_HPLabel = new System.Windows.Forms.Label();
            nAMALabel = new System.Windows.Forms.Label();
            aLAMATLabel = new System.Windows.Forms.Label();
            nAMA_NPWPLabel = new System.Windows.Forms.Label();
            nPWPLabel = new System.Windows.Forms.Label();
            aLAMAT_NPWLabel = new System.Windows.Forms.Label();
            nOTELabel = new System.Windows.Forms.Label();
            eMAILLabel = new System.Windows.Forms.Label();
            kOTALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uASDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_supplierBindingNavigator)).BeginInit();
            this.m_supplierBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mkotaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // p_IDLabel
            // 
            p_IDLabel.AutoSize = true;
            p_IDLabel.BackColor = System.Drawing.Color.Transparent;
            p_IDLabel.ForeColor = System.Drawing.Color.White;
            p_IDLabel.Location = new System.Drawing.Point(152, 119);
            p_IDLabel.Name = "p_IDLabel";
            p_IDLabel.Size = new System.Drawing.Size(31, 13);
            p_IDLabel.TabIndex = 51;
            p_IDLabel.Text = "P ID:";
            // 
            // bANKLabel
            // 
            bANKLabel.AutoSize = true;
            bANKLabel.BackColor = System.Drawing.Color.Transparent;
            bANKLabel.ForeColor = System.Drawing.Color.White;
            bANKLabel.Location = new System.Drawing.Point(440, 100);
            bANKLabel.Name = "bANKLabel";
            bANKLabel.Size = new System.Drawing.Size(39, 13);
            bANKLabel.TabIndex = 52;
            bANKLabel.Text = "BANK:";
            // 
            // tELP_HPLabel
            // 
            tELP_HPLabel.AutoSize = true;
            tELP_HPLabel.BackColor = System.Drawing.Color.Transparent;
            tELP_HPLabel.ForeColor = System.Drawing.Color.White;
            tELP_HPLabel.Location = new System.Drawing.Point(668, 119);
            tELP_HPLabel.Name = "tELP_HPLabel";
            tELP_HPLabel.Size = new System.Drawing.Size(55, 13);
            tELP_HPLabel.TabIndex = 53;
            tELP_HPLabel.Text = "TELP HP:";
            // 
            // nAMALabel
            // 
            nAMALabel.AutoSize = true;
            nAMALabel.BackColor = System.Drawing.Color.Transparent;
            nAMALabel.ForeColor = System.Drawing.Color.White;
            nAMALabel.Location = new System.Drawing.Point(142, 158);
            nAMALabel.Name = "nAMALabel";
            nAMALabel.Size = new System.Drawing.Size(41, 13);
            nAMALabel.TabIndex = 54;
            nAMALabel.Text = "NAMA:";
            // 
            // aLAMATLabel
            // 
            aLAMATLabel.AutoSize = true;
            aLAMATLabel.BackColor = System.Drawing.Color.Transparent;
            aLAMATLabel.ForeColor = System.Drawing.Color.White;
            aLAMATLabel.Location = new System.Drawing.Point(334, 158);
            aLAMATLabel.Name = "aLAMATLabel";
            aLAMATLabel.Size = new System.Drawing.Size(53, 13);
            aLAMATLabel.TabIndex = 55;
            aLAMATLabel.Text = "ALAMAT:";
            // 
            // nAMA_NPWPLabel
            // 
            nAMA_NPWPLabel.AutoSize = true;
            nAMA_NPWPLabel.BackColor = System.Drawing.Color.Transparent;
            nAMA_NPWPLabel.ForeColor = System.Drawing.Color.White;
            nAMA_NPWPLabel.Location = new System.Drawing.Point(142, 226);
            nAMA_NPWPLabel.Name = "nAMA_NPWPLabel";
            nAMA_NPWPLabel.Size = new System.Drawing.Size(77, 13);
            nAMA_NPWPLabel.TabIndex = 57;
            nAMA_NPWPLabel.Text = "NAMA NPWP:";
            // 
            // nPWPLabel
            // 
            nPWPLabel.AutoSize = true;
            nPWPLabel.BackColor = System.Drawing.Color.Transparent;
            nPWPLabel.ForeColor = System.Drawing.Color.White;
            nPWPLabel.Location = new System.Drawing.Point(495, 226);
            nPWPLabel.Name = "nPWPLabel";
            nPWPLabel.Size = new System.Drawing.Size(43, 13);
            nPWPLabel.TabIndex = 58;
            nPWPLabel.Text = "NPWP:";
            // 
            // aLAMAT_NPWLabel
            // 
            aLAMAT_NPWLabel.AutoSize = true;
            aLAMAT_NPWLabel.BackColor = System.Drawing.Color.Transparent;
            aLAMAT_NPWLabel.ForeColor = System.Drawing.Color.White;
            aLAMAT_NPWLabel.Location = new System.Drawing.Point(137, 252);
            aLAMAT_NPWLabel.Name = "aLAMAT_NPWLabel";
            aLAMAT_NPWLabel.Size = new System.Drawing.Size(82, 13);
            aLAMAT_NPWLabel.TabIndex = 59;
            aLAMAT_NPWLabel.Text = "ALAMAT NPW:";
            // 
            // nOTELabel
            // 
            nOTELabel.AutoSize = true;
            nOTELabel.BackColor = System.Drawing.Color.Transparent;
            nOTELabel.ForeColor = System.Drawing.Color.White;
            nOTELabel.Location = new System.Drawing.Point(179, 304);
            nOTELabel.Name = "nOTELabel";
            nOTELabel.Size = new System.Drawing.Size(40, 13);
            nOTELabel.TabIndex = 60;
            nOTELabel.Text = "NOTE:";
            // 
            // eMAILLabel
            // 
            eMAILLabel.AutoSize = true;
            eMAILLabel.BackColor = System.Drawing.Color.Transparent;
            eMAILLabel.ForeColor = System.Drawing.Color.White;
            eMAILLabel.Location = new System.Drawing.Point(177, 278);
            eMAILLabel.Name = "eMAILLabel";
            eMAILLabel.Size = new System.Drawing.Size(42, 13);
            eMAILLabel.TabIndex = 61;
            eMAILLabel.Text = "EMAIL:";
            // 
            // kOTALabel
            // 
            kOTALabel.AutoSize = true;
            kOTALabel.BackColor = System.Drawing.Color.Transparent;
            kOTALabel.ForeColor = System.Drawing.Color.White;
            kOTALabel.Location = new System.Drawing.Point(684, 154);
            kOTALabel.Name = "kOTALabel";
            kOTALabel.Size = new System.Drawing.Size(39, 13);
            kOTALabel.TabIndex = 62;
            kOTALabel.Text = "KOTA:";
            // 
            // btn_Browse
            // 
            this.btn_Browse.BackColor = System.Drawing.Color.Orange;
            this.btn_Browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Browse.ForeColor = System.Drawing.Color.White;
            this.btn_Browse.Location = new System.Drawing.Point(296, 366);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(141, 47);
            this.btn_Browse.TabIndex = 50;
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
            this.label1.Location = new System.Drawing.Point(386, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 31);
            this.label1.TabIndex = 49;
            this.label1.Text = "Input Master Supplier";
            // 
            // uASDataSet
            // 
            this.uASDataSet.DataSetName = "UASDataSet";
            this.uASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // m_supplierBindingSource
            // 
            this.m_supplierBindingSource.DataMember = "m_supplier";
            this.m_supplierBindingSource.DataSource = this.uASDataSet;
            // 
            // m_supplierTableAdapter
            // 
            this.m_supplierTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.m_barangTableAdapter = null;
            this.tableAdapterManager.m_groupuserTableAdapter = null;
            this.tableAdapterManager.m_hakaksesgroupuserTableAdapter = null;
            this.tableAdapterManager.m_kotaTableAdapter = this.m_kotaTableAdapter;
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
            this.tableAdapterManager.t_pembelian_headerTableAdapter = null;
            this.tableAdapterManager.t_penawaran_detailTableAdapter = null;
            this.tableAdapterManager.t_penawaran_headerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Project_UAS_.UASDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // m_kotaTableAdapter
            // 
            this.m_kotaTableAdapter.ClearBeforeFill = true;
            // 
            // m_supplierBindingNavigator
            // 
            this.m_supplierBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.m_supplierBindingNavigator.BindingSource = this.m_supplierBindingSource;
            this.m_supplierBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.m_supplierBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.m_supplierBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.m_supplierBindingNavigatorSaveItem});
            this.m_supplierBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.m_supplierBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.m_supplierBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.m_supplierBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.m_supplierBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.m_supplierBindingNavigator.Name = "m_supplierBindingNavigator";
            this.m_supplierBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.m_supplierBindingNavigator.Size = new System.Drawing.Size(1021, 25);
            this.m_supplierBindingNavigator.TabIndex = 51;
            this.m_supplierBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // m_supplierBindingNavigatorSaveItem
            // 
            this.m_supplierBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_supplierBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("m_supplierBindingNavigatorSaveItem.Image")));
            this.m_supplierBindingNavigatorSaveItem.Name = "m_supplierBindingNavigatorSaveItem";
            this.m_supplierBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.m_supplierBindingNavigatorSaveItem.Text = "Save Data";
            this.m_supplierBindingNavigatorSaveItem.Click += new System.EventHandler(this.m_supplierBindingNavigatorSaveItem_Click);
            // 
            // p_IDTextBox
            // 
            this.p_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_supplierBindingSource, "P_ID", true));
            this.p_IDTextBox.Location = new System.Drawing.Point(189, 116);
            this.p_IDTextBox.Name = "p_IDTextBox";
            this.p_IDTextBox.Size = new System.Drawing.Size(67, 20);
            this.p_IDTextBox.TabIndex = 52;
            // 
            // bANKTextBox
            // 
            this.bANKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_supplierBindingSource, "BANK", true));
            this.bANKTextBox.Location = new System.Drawing.Point(262, 116);
            this.bANKTextBox.Name = "bANKTextBox";
            this.bANKTextBox.Size = new System.Drawing.Size(400, 20);
            this.bANKTextBox.TabIndex = 53;
            // 
            // tELP_HPTextBox
            // 
            this.tELP_HPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_supplierBindingSource, "TELP_HP", true));
            this.tELP_HPTextBox.Location = new System.Drawing.Point(729, 116);
            this.tELP_HPTextBox.Name = "tELP_HPTextBox";
            this.tELP_HPTextBox.Size = new System.Drawing.Size(146, 20);
            this.tELP_HPTextBox.TabIndex = 54;
            // 
            // nAMATextBox
            // 
            this.nAMATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_supplierBindingSource, "NAMA", true));
            this.nAMATextBox.Location = new System.Drawing.Point(189, 155);
            this.nAMATextBox.Name = "nAMATextBox";
            this.nAMATextBox.Size = new System.Drawing.Size(139, 20);
            this.nAMATextBox.TabIndex = 55;
            // 
            // aLAMATTextBox
            // 
            this.aLAMATTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_supplierBindingSource, "ALAMAT", true));
            this.aLAMATTextBox.Location = new System.Drawing.Point(393, 155);
            this.aLAMATTextBox.Name = "aLAMATTextBox";
            this.aLAMATTextBox.Size = new System.Drawing.Size(269, 20);
            this.aLAMATTextBox.TabIndex = 56;
            // 
            // nAMA_NPWPTextBox
            // 
            this.nAMA_NPWPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_supplierBindingSource, "NAMA_NPWP", true));
            this.nAMA_NPWPTextBox.Location = new System.Drawing.Point(225, 223);
            this.nAMA_NPWPTextBox.Name = "nAMA_NPWPTextBox";
            this.nAMA_NPWPTextBox.Size = new System.Drawing.Size(232, 20);
            this.nAMA_NPWPTextBox.TabIndex = 58;
            // 
            // nPWPTextBox
            // 
            this.nPWPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_supplierBindingSource, "NPWP", true));
            this.nPWPTextBox.Location = new System.Drawing.Point(544, 223);
            this.nPWPTextBox.Name = "nPWPTextBox";
            this.nPWPTextBox.Size = new System.Drawing.Size(129, 20);
            this.nPWPTextBox.TabIndex = 59;
            // 
            // aLAMAT_NPWTextBox
            // 
            this.aLAMAT_NPWTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_supplierBindingSource, "ALAMAT_NPW", true));
            this.aLAMAT_NPWTextBox.Location = new System.Drawing.Point(225, 249);
            this.aLAMAT_NPWTextBox.Name = "aLAMAT_NPWTextBox";
            this.aLAMAT_NPWTextBox.Size = new System.Drawing.Size(498, 20);
            this.aLAMAT_NPWTextBox.TabIndex = 60;
            // 
            // nOTETextBox
            // 
            this.nOTETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_supplierBindingSource, "NOTE", true));
            this.nOTETextBox.Location = new System.Drawing.Point(225, 301);
            this.nOTETextBox.Name = "nOTETextBox";
            this.nOTETextBox.Size = new System.Drawing.Size(498, 20);
            this.nOTETextBox.TabIndex = 61;
            // 
            // eMAILTextBox
            // 
            this.eMAILTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_supplierBindingSource, "EMAIL", true));
            this.eMAILTextBox.Location = new System.Drawing.Point(225, 275);
            this.eMAILTextBox.Name = "eMAILTextBox";
            this.eMAILTextBox.Size = new System.Drawing.Size(498, 20);
            this.eMAILTextBox.TabIndex = 62;
            // 
            // kOTAComboBox
            // 
            this.kOTAComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_supplierBindingSource, "KOTA", true));
            this.kOTAComboBox.DataSource = this.mkotaBindingSource;
            this.kOTAComboBox.DisplayMember = "NAMAKOTA";
            this.kOTAComboBox.FormattingEnabled = true;
            this.kOTAComboBox.Location = new System.Drawing.Point(729, 154);
            this.kOTAComboBox.Name = "kOTAComboBox";
            this.kOTAComboBox.Size = new System.Drawing.Size(146, 21);
            this.kOTAComboBox.TabIndex = 63;
            this.kOTAComboBox.ValueMember = "NAMAKOTA";
            // 
            // mkotaBindingSource
            // 
            this.mkotaBindingSource.DataMember = "m_kota";
            this.mkotaBindingSource.DataSource = this.uASDataSet;
            // 
            // btn_Print
            // 
            this.btn_Print.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Print.ForeColor = System.Drawing.Color.White;
            this.btn_Print.Location = new System.Drawing.Point(443, 366);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(140, 47);
            this.btn_Print.TabIndex = 71;
            this.btn_Print.Text = "Print";
            this.btn_Print.UseVisualStyleBackColor = false;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Red;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Location = new System.Drawing.Point(589, 367);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(140, 46);
            this.btn_Exit.TabIndex = 108;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // masterSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1021, 450);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(kOTALabel);
            this.Controls.Add(this.kOTAComboBox);
            this.Controls.Add(eMAILLabel);
            this.Controls.Add(this.eMAILTextBox);
            this.Controls.Add(nOTELabel);
            this.Controls.Add(this.nOTETextBox);
            this.Controls.Add(aLAMAT_NPWLabel);
            this.Controls.Add(this.aLAMAT_NPWTextBox);
            this.Controls.Add(nPWPLabel);
            this.Controls.Add(this.nPWPTextBox);
            this.Controls.Add(nAMA_NPWPLabel);
            this.Controls.Add(this.nAMA_NPWPTextBox);
            this.Controls.Add(aLAMATLabel);
            this.Controls.Add(this.aLAMATTextBox);
            this.Controls.Add(nAMALabel);
            this.Controls.Add(this.nAMATextBox);
            this.Controls.Add(tELP_HPLabel);
            this.Controls.Add(this.tELP_HPTextBox);
            this.Controls.Add(bANKLabel);
            this.Controls.Add(this.bANKTextBox);
            this.Controls.Add(p_IDLabel);
            this.Controls.Add(this.p_IDTextBox);
            this.Controls.Add(this.m_supplierBindingNavigator);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.label1);
            this.Name = "masterSupplier";
            this.Text = "Master Supplier";
            this.Load += new System.EventHandler(this.masterSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uASDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_supplierBindingNavigator)).EndInit();
            this.m_supplierBindingNavigator.ResumeLayout(false);
            this.m_supplierBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mkotaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.Label label1;
        private UASDataSet uASDataSet;
        private System.Windows.Forms.BindingSource m_supplierBindingSource;
        private UASDataSetTableAdapters.m_supplierTableAdapter m_supplierTableAdapter;
        private UASDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator m_supplierBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton m_supplierBindingNavigatorSaveItem;
        private UASDataSetTableAdapters.m_kotaTableAdapter m_kotaTableAdapter;
        private System.Windows.Forms.TextBox p_IDTextBox;
        private System.Windows.Forms.TextBox bANKTextBox;
        private System.Windows.Forms.TextBox tELP_HPTextBox;
        private System.Windows.Forms.TextBox nAMATextBox;
        private System.Windows.Forms.TextBox aLAMATTextBox;
        private System.Windows.Forms.TextBox nAMA_NPWPTextBox;
        private System.Windows.Forms.TextBox nPWPTextBox;
        private System.Windows.Forms.TextBox aLAMAT_NPWTextBox;
        private System.Windows.Forms.TextBox nOTETextBox;
        private System.Windows.Forms.TextBox eMAILTextBox;
        private System.Windows.Forms.ComboBox kOTAComboBox;
        private System.Windows.Forms.BindingSource mkotaBindingSource;
        private System.Windows.Forms.Button btn_Print;
        public System.Windows.Forms.Button btn_Exit;
    }
}