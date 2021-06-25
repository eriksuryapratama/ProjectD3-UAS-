
namespace Project_UAS_
{
    partial class Penawaran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Penawaran));
            System.Windows.Forms.Label nO_PNWLabel;
            System.Windows.Forms.Label p_IDLabel;
            System.Windows.Forms.Label tGL_PNWLabel;
            System.Windows.Forms.Label tGL_TERIMALabel;
            System.Windows.Forms.Label bATALLabel;
            System.Windows.Forms.Label mODELLabel;
            System.Windows.Forms.Label eNGINELabel;
            System.Windows.Forms.Label sERIAL_NOLabel;
            System.Windows.Forms.Label pOWOLabel;
            System.Windows.Forms.Label aSSYLabel;
            System.Windows.Forms.Label kETERANGANLabel;
            this.uASDataSet = new Project_UAS_.UASDataSet();
            this.t_penawaran_headerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_penawaran_headerTableAdapter = new Project_UAS_.UASDataSetTableAdapters.t_penawaran_headerTableAdapter();
            this.tableAdapterManager = new Project_UAS_.UASDataSetTableAdapters.TableAdapterManager();
            this.t_penawaran_headerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.t_penawaran_headerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nO_PNWTextBox = new System.Windows.Forms.TextBox();
            this.p_IDComboBox = new System.Windows.Forms.ComboBox();
            this.tGL_PNWDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tGL_TERIMADateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bATALCheckBox = new System.Windows.Forms.CheckBox();
            this.mODELTextBox = new System.Windows.Forms.TextBox();
            this.eNGINETextBox = new System.Windows.Forms.TextBox();
            this.sERIAL_NOTextBox = new System.Windows.Forms.TextBox();
            this.pOWOTextBox = new System.Windows.Forms.TextBox();
            this.aSSYTextBox = new System.Windows.Forms.TextBox();
            this.dgv_penawaran = new System.Windows.Forms.DataGridView();
            this.kETERANGANTextBox = new System.Windows.Forms.TextBox();
            this.btn_tambah = new System.Windows.Forms.Button();
            this.btn_hapus = new System.Windows.Forms.Button();
            nO_PNWLabel = new System.Windows.Forms.Label();
            p_IDLabel = new System.Windows.Forms.Label();
            tGL_PNWLabel = new System.Windows.Forms.Label();
            tGL_TERIMALabel = new System.Windows.Forms.Label();
            bATALLabel = new System.Windows.Forms.Label();
            mODELLabel = new System.Windows.Forms.Label();
            eNGINELabel = new System.Windows.Forms.Label();
            sERIAL_NOLabel = new System.Windows.Forms.Label();
            pOWOLabel = new System.Windows.Forms.Label();
            aSSYLabel = new System.Windows.Forms.Label();
            kETERANGANLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uASDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_penawaran_headerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_penawaran_headerBindingNavigator)).BeginInit();
            this.t_penawaran_headerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_penawaran)).BeginInit();
            this.SuspendLayout();
            // 
            // uASDataSet
            // 
            this.uASDataSet.DataSetName = "UASDataSet";
            this.uASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_penawaran_headerBindingSource
            // 
            this.t_penawaran_headerBindingSource.DataMember = "t_penawaran_header";
            this.t_penawaran_headerBindingSource.DataSource = this.uASDataSet;
            // 
            // t_penawaran_headerTableAdapter
            // 
            this.t_penawaran_headerTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.t_penawaran_headerTableAdapter = this.t_penawaran_headerTableAdapter;
            this.tableAdapterManager.UpdateOrder = Project_UAS_.UASDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // t_penawaran_headerBindingNavigator
            // 
            this.t_penawaran_headerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.t_penawaran_headerBindingNavigator.BindingSource = this.t_penawaran_headerBindingSource;
            this.t_penawaran_headerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.t_penawaran_headerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.t_penawaran_headerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.t_penawaran_headerBindingNavigatorSaveItem});
            this.t_penawaran_headerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.t_penawaran_headerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.t_penawaran_headerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.t_penawaran_headerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.t_penawaran_headerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.t_penawaran_headerBindingNavigator.Name = "t_penawaran_headerBindingNavigator";
            this.t_penawaran_headerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.t_penawaran_headerBindingNavigator.Size = new System.Drawing.Size(1042, 25);
            this.t_penawaran_headerBindingNavigator.TabIndex = 0;
            this.t_penawaran_headerBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // t_penawaran_headerBindingNavigatorSaveItem
            // 
            this.t_penawaran_headerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.t_penawaran_headerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("t_penawaran_headerBindingNavigatorSaveItem.Image")));
            this.t_penawaran_headerBindingNavigatorSaveItem.Name = "t_penawaran_headerBindingNavigatorSaveItem";
            this.t_penawaran_headerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.t_penawaran_headerBindingNavigatorSaveItem.Text = "Save Data";
            this.t_penawaran_headerBindingNavigatorSaveItem.Click += new System.EventHandler(this.t_penawaran_headerBindingNavigatorSaveItem_Click);
            // 
            // nO_PNWLabel
            // 
            nO_PNWLabel.AutoSize = true;
            nO_PNWLabel.Location = new System.Drawing.Point(12, 44);
            nO_PNWLabel.Name = "nO_PNWLabel";
            nO_PNWLabel.Size = new System.Drawing.Size(55, 13);
            nO_PNWLabel.TabIndex = 1;
            nO_PNWLabel.Text = "NO PNW:";
            // 
            // nO_PNWTextBox
            // 
            this.nO_PNWTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_penawaran_headerBindingSource, "NO_PNW", true));
            this.nO_PNWTextBox.Location = new System.Drawing.Point(73, 41);
            this.nO_PNWTextBox.Name = "nO_PNWTextBox";
            this.nO_PNWTextBox.Size = new System.Drawing.Size(100, 20);
            this.nO_PNWTextBox.TabIndex = 2;
            // 
            // p_IDLabel
            // 
            p_IDLabel.AutoSize = true;
            p_IDLabel.Location = new System.Drawing.Point(36, 74);
            p_IDLabel.Name = "p_IDLabel";
            p_IDLabel.Size = new System.Drawing.Size(31, 13);
            p_IDLabel.TabIndex = 3;
            p_IDLabel.Text = "P ID:";
            // 
            // p_IDComboBox
            // 
            this.p_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_penawaran_headerBindingSource, "P_ID", true));
            this.p_IDComboBox.FormattingEnabled = true;
            this.p_IDComboBox.Location = new System.Drawing.Point(73, 71);
            this.p_IDComboBox.Name = "p_IDComboBox";
            this.p_IDComboBox.Size = new System.Drawing.Size(121, 21);
            this.p_IDComboBox.TabIndex = 4;
            // 
            // tGL_PNWLabel
            // 
            tGL_PNWLabel.AutoSize = true;
            tGL_PNWLabel.Location = new System.Drawing.Point(532, 41);
            tGL_PNWLabel.Name = "tGL_PNWLabel";
            tGL_PNWLabel.Size = new System.Drawing.Size(60, 13);
            tGL_PNWLabel.TabIndex = 5;
            tGL_PNWLabel.Text = "TGL PNW:";
            // 
            // tGL_PNWDateTimePicker
            // 
            this.tGL_PNWDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.t_penawaran_headerBindingSource, "TGL_PNW", true));
            this.tGL_PNWDateTimePicker.Location = new System.Drawing.Point(598, 35);
            this.tGL_PNWDateTimePicker.Name = "tGL_PNWDateTimePicker";
            this.tGL_PNWDateTimePicker.Size = new System.Drawing.Size(133, 20);
            this.tGL_PNWDateTimePicker.TabIndex = 6;
            // 
            // tGL_TERIMALabel
            // 
            tGL_TERIMALabel.AutoSize = true;
            tGL_TERIMALabel.Location = new System.Drawing.Point(210, 41);
            tGL_TERIMALabel.Name = "tGL_TERIMALabel";
            tGL_TERIMALabel.Size = new System.Drawing.Size(75, 13);
            tGL_TERIMALabel.TabIndex = 7;
            tGL_TERIMALabel.Text = "TGL TERIMA:";
            // 
            // tGL_TERIMADateTimePicker
            // 
            this.tGL_TERIMADateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.t_penawaran_headerBindingSource, "TGL_TERIMA", true));
            this.tGL_TERIMADateTimePicker.Location = new System.Drawing.Point(291, 37);
            this.tGL_TERIMADateTimePicker.Name = "tGL_TERIMADateTimePicker";
            this.tGL_TERIMADateTimePicker.Size = new System.Drawing.Size(153, 20);
            this.tGL_TERIMADateTimePicker.TabIndex = 8;
            // 
            // bATALLabel
            // 
            bATALLabel.AutoSize = true;
            bATALLabel.Location = new System.Drawing.Point(737, 37);
            bATALLabel.Name = "bATALLabel";
            bATALLabel.Size = new System.Drawing.Size(44, 13);
            bATALLabel.TabIndex = 9;
            bATALLabel.Text = "BATAL:";
            // 
            // bATALCheckBox
            // 
            this.bATALCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.t_penawaran_headerBindingSource, "BATAL", true));
            this.bATALCheckBox.Location = new System.Drawing.Point(787, 32);
            this.bATALCheckBox.Name = "bATALCheckBox";
            this.bATALCheckBox.Size = new System.Drawing.Size(104, 24);
            this.bATALCheckBox.TabIndex = 10;
            this.bATALCheckBox.Text = "checkBox1";
            this.bATALCheckBox.UseVisualStyleBackColor = true;
            // 
            // mODELLabel
            // 
            mODELLabel.AutoSize = true;
            mODELLabel.Location = new System.Drawing.Point(19, 184);
            mODELLabel.Name = "mODELLabel";
            mODELLabel.Size = new System.Drawing.Size(48, 13);
            mODELLabel.TabIndex = 11;
            mODELLabel.Text = "MODEL:";
            // 
            // mODELTextBox
            // 
            this.mODELTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_penawaran_headerBindingSource, "MODEL", true));
            this.mODELTextBox.Location = new System.Drawing.Point(73, 181);
            this.mODELTextBox.Name = "mODELTextBox";
            this.mODELTextBox.Size = new System.Drawing.Size(100, 20);
            this.mODELTextBox.TabIndex = 12;
            // 
            // eNGINELabel
            // 
            eNGINELabel.AutoSize = true;
            eNGINELabel.Location = new System.Drawing.Point(189, 184);
            eNGINELabel.Name = "eNGINELabel";
            eNGINELabel.Size = new System.Drawing.Size(51, 13);
            eNGINELabel.TabIndex = 13;
            eNGINELabel.Text = "ENGINE:";
            // 
            // eNGINETextBox
            // 
            this.eNGINETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_penawaran_headerBindingSource, "ENGINE", true));
            this.eNGINETextBox.Location = new System.Drawing.Point(246, 181);
            this.eNGINETextBox.Name = "eNGINETextBox";
            this.eNGINETextBox.Size = new System.Drawing.Size(100, 20);
            this.eNGINETextBox.TabIndex = 14;
            // 
            // sERIAL_NOLabel
            // 
            sERIAL_NOLabel.AutoSize = true;
            sERIAL_NOLabel.Location = new System.Drawing.Point(365, 181);
            sERIAL_NOLabel.Name = "sERIAL_NOLabel";
            sERIAL_NOLabel.Size = new System.Drawing.Size(67, 13);
            sERIAL_NOLabel.TabIndex = 15;
            sERIAL_NOLabel.Text = "SERIAL NO:";
            // 
            // sERIAL_NOTextBox
            // 
            this.sERIAL_NOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_penawaran_headerBindingSource, "SERIAL_NO", true));
            this.sERIAL_NOTextBox.Location = new System.Drawing.Point(438, 178);
            this.sERIAL_NOTextBox.Name = "sERIAL_NOTextBox";
            this.sERIAL_NOTextBox.Size = new System.Drawing.Size(100, 20);
            this.sERIAL_NOTextBox.TabIndex = 16;
            // 
            // pOWOLabel
            // 
            pOWOLabel.AutoSize = true;
            pOWOLabel.Location = new System.Drawing.Point(23, 210);
            pOWOLabel.Name = "pOWOLabel";
            pOWOLabel.Size = new System.Drawing.Size(44, 13);
            pOWOLabel.TabIndex = 17;
            pOWOLabel.Text = "POWO:";
            // 
            // pOWOTextBox
            // 
            this.pOWOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_penawaran_headerBindingSource, "POWO", true));
            this.pOWOTextBox.Location = new System.Drawing.Point(73, 207);
            this.pOWOTextBox.Name = "pOWOTextBox";
            this.pOWOTextBox.Size = new System.Drawing.Size(273, 20);
            this.pOWOTextBox.TabIndex = 18;
            // 
            // aSSYLabel
            // 
            aSSYLabel.AutoSize = true;
            aSSYLabel.Location = new System.Drawing.Point(394, 207);
            aSSYLabel.Name = "aSSYLabel";
            aSSYLabel.Size = new System.Drawing.Size(38, 13);
            aSSYLabel.TabIndex = 19;
            aSSYLabel.Text = "ASSY:";
            // 
            // aSSYTextBox
            // 
            this.aSSYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_penawaran_headerBindingSource, "ASSY", true));
            this.aSSYTextBox.Location = new System.Drawing.Point(438, 204);
            this.aSSYTextBox.Name = "aSSYTextBox";
            this.aSSYTextBox.Size = new System.Drawing.Size(100, 20);
            this.aSSYTextBox.TabIndex = 20;
            // 
            // dgv_penawaran
            // 
            this.dgv_penawaran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_penawaran.Location = new System.Drawing.Point(22, 233);
            this.dgv_penawaran.Name = "dgv_penawaran";
            this.dgv_penawaran.Size = new System.Drawing.Size(926, 235);
            this.dgv_penawaran.TabIndex = 21;
            // 
            // kETERANGANLabel
            // 
            kETERANGANLabel.AutoSize = true;
            kETERANGANLabel.Location = new System.Drawing.Point(19, 521);
            kETERANGANLabel.Name = "kETERANGANLabel";
            kETERANGANLabel.Size = new System.Drawing.Size(84, 13);
            kETERANGANLabel.TabIndex = 22;
            kETERANGANLabel.Text = "KETERANGAN:";
            // 
            // kETERANGANTextBox
            // 
            this.kETERANGANTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_penawaran_headerBindingSource, "KETERANGAN", true));
            this.kETERANGANTextBox.Location = new System.Drawing.Point(109, 518);
            this.kETERANGANTextBox.Name = "kETERANGANTextBox";
            this.kETERANGANTextBox.Size = new System.Drawing.Size(100, 20);
            this.kETERANGANTextBox.TabIndex = 23;
            // 
            // btn_tambah
            // 
            this.btn_tambah.Location = new System.Drawing.Point(26, 555);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(75, 23);
            this.btn_tambah.TabIndex = 24;
            this.btn_tambah.Text = "Tambah Item";
            this.btn_tambah.UseVisualStyleBackColor = true;
            // 
            // btn_hapus
            // 
            this.btn_hapus.Location = new System.Drawing.Point(148, 555);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(75, 23);
            this.btn_hapus.TabIndex = 25;
            this.btn_hapus.Text = "Hapus Item";
            this.btn_hapus.UseVisualStyleBackColor = true;
            // 
            // Penawaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 590);
            this.Controls.Add(this.btn_hapus);
            this.Controls.Add(this.btn_tambah);
            this.Controls.Add(kETERANGANLabel);
            this.Controls.Add(this.kETERANGANTextBox);
            this.Controls.Add(this.dgv_penawaran);
            this.Controls.Add(aSSYLabel);
            this.Controls.Add(this.aSSYTextBox);
            this.Controls.Add(pOWOLabel);
            this.Controls.Add(this.pOWOTextBox);
            this.Controls.Add(sERIAL_NOLabel);
            this.Controls.Add(this.sERIAL_NOTextBox);
            this.Controls.Add(eNGINELabel);
            this.Controls.Add(this.eNGINETextBox);
            this.Controls.Add(mODELLabel);
            this.Controls.Add(this.mODELTextBox);
            this.Controls.Add(bATALLabel);
            this.Controls.Add(this.bATALCheckBox);
            this.Controls.Add(tGL_TERIMALabel);
            this.Controls.Add(this.tGL_TERIMADateTimePicker);
            this.Controls.Add(tGL_PNWLabel);
            this.Controls.Add(this.tGL_PNWDateTimePicker);
            this.Controls.Add(p_IDLabel);
            this.Controls.Add(this.p_IDComboBox);
            this.Controls.Add(nO_PNWLabel);
            this.Controls.Add(this.nO_PNWTextBox);
            this.Controls.Add(this.t_penawaran_headerBindingNavigator);
            this.Name = "Penawaran";
            this.Text = "Penawaran";
            this.Load += new System.EventHandler(this.Penawaran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uASDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_penawaran_headerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_penawaran_headerBindingNavigator)).EndInit();
            this.t_penawaran_headerBindingNavigator.ResumeLayout(false);
            this.t_penawaran_headerBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_penawaran)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UASDataSet uASDataSet;
        private System.Windows.Forms.BindingSource t_penawaran_headerBindingSource;
        private UASDataSetTableAdapters.t_penawaran_headerTableAdapter t_penawaran_headerTableAdapter;
        private UASDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator t_penawaran_headerBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton t_penawaran_headerBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nO_PNWTextBox;
        private System.Windows.Forms.ComboBox p_IDComboBox;
        private System.Windows.Forms.DateTimePicker tGL_PNWDateTimePicker;
        private System.Windows.Forms.DateTimePicker tGL_TERIMADateTimePicker;
        private System.Windows.Forms.CheckBox bATALCheckBox;
        private System.Windows.Forms.TextBox mODELTextBox;
        private System.Windows.Forms.TextBox eNGINETextBox;
        private System.Windows.Forms.TextBox sERIAL_NOTextBox;
        private System.Windows.Forms.TextBox pOWOTextBox;
        private System.Windows.Forms.TextBox aSSYTextBox;
        private System.Windows.Forms.DataGridView dgv_penawaran;
        private System.Windows.Forms.TextBox kETERANGANTextBox;
        private System.Windows.Forms.Button btn_tambah;
        private System.Windows.Forms.Button btn_hapus;
    }
}