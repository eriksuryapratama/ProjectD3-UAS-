
namespace Project_UAS_
{
    partial class masterBarang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(masterBarang));
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label kODELabel;
            System.Windows.Forms.Label mERK1Label;
            System.Windows.Forms.Label mERK2Label;
            System.Windows.Forms.Label mERK3Label;
            System.Windows.Forms.Label dESCRIPTIONLabel;
            this.uASDataSet = new Project_UAS_.UASDataSet();
            this.m_barangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_barangTableAdapter = new Project_UAS_.UASDataSetTableAdapters.m_barangTableAdapter();
            this.tableAdapterManager = new Project_UAS_.UASDataSetTableAdapters.TableAdapterManager();
            this.m_barangBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.m_barangBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.kODETextBox = new System.Windows.Forms.TextBox();
            this.mERK1ComboBox = new System.Windows.Forms.ComboBox();
            this.mERK2ComboBox = new System.Windows.Forms.ComboBox();
            this.mERK3ComboBox = new System.Windows.Forms.ComboBox();
            this.dESCRIPTIONTextBox = new System.Windows.Forms.TextBox();
            iDLabel = new System.Windows.Forms.Label();
            kODELabel = new System.Windows.Forms.Label();
            mERK1Label = new System.Windows.Forms.Label();
            mERK2Label = new System.Windows.Forms.Label();
            mERK3Label = new System.Windows.Forms.Label();
            dESCRIPTIONLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uASDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_barangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_barangBindingNavigator)).BeginInit();
            this.m_barangBindingNavigator.SuspendLayout();
            this.SuspendLayout();
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
            this.tableAdapterManager.t_penawaran_headerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Project_UAS_.UASDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // m_barangBindingNavigator
            // 
            this.m_barangBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.m_barangBindingNavigator.BindingSource = this.m_barangBindingSource;
            this.m_barangBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.m_barangBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
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
            this.m_barangBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.m_barangBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.m_barangBindingNavigator.TabIndex = 0;
            this.m_barangBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // m_barangBindingNavigatorSaveItem
            // 
            this.m_barangBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_barangBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("m_barangBindingNavigatorSaveItem.Image")));
            this.m_barangBindingNavigatorSaveItem.Name = "m_barangBindingNavigatorSaveItem";
            this.m_barangBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.m_barangBindingNavigatorSaveItem.Text = "Save Data";
            this.m_barangBindingNavigatorSaveItem.Click += new System.EventHandler(this.m_barangBindingNavigatorSaveItem_Click);
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(140, 88);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(167, 85);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDTextBox.TabIndex = 2;
            // 
            // kODELabel
            // 
            kODELabel.AutoSize = true;
            kODELabel.Location = new System.Drawing.Point(121, 125);
            kODELabel.Name = "kODELabel";
            kODELabel.Size = new System.Drawing.Size(40, 13);
            kODELabel.TabIndex = 3;
            kODELabel.Text = "KODE:";
            // 
            // kODETextBox
            // 
            this.kODETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "KODE", true));
            this.kODETextBox.Location = new System.Drawing.Point(167, 122);
            this.kODETextBox.Name = "kODETextBox";
            this.kODETextBox.Size = new System.Drawing.Size(100, 20);
            this.kODETextBox.TabIndex = 4;
            // 
            // mERK1Label
            // 
            mERK1Label.AutoSize = true;
            mERK1Label.Location = new System.Drawing.Point(114, 171);
            mERK1Label.Name = "mERK1Label";
            mERK1Label.Size = new System.Drawing.Size(47, 13);
            mERK1Label.TabIndex = 5;
            mERK1Label.Text = "MERK1:";
            // 
            // mERK1ComboBox
            // 
            this.mERK1ComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "MERK1", true));
            this.mERK1ComboBox.FormattingEnabled = true;
            this.mERK1ComboBox.Location = new System.Drawing.Point(167, 168);
            this.mERK1ComboBox.Name = "mERK1ComboBox";
            this.mERK1ComboBox.Size = new System.Drawing.Size(121, 21);
            this.mERK1ComboBox.TabIndex = 6;
            // 
            // mERK2Label
            // 
            mERK2Label.AutoSize = true;
            mERK2Label.Location = new System.Drawing.Point(319, 171);
            mERK2Label.Name = "mERK2Label";
            mERK2Label.Size = new System.Drawing.Size(47, 13);
            mERK2Label.TabIndex = 7;
            mERK2Label.Text = "MERK2:";
            // 
            // mERK2ComboBox
            // 
            this.mERK2ComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "MERK2", true));
            this.mERK2ComboBox.FormattingEnabled = true;
            this.mERK2ComboBox.Location = new System.Drawing.Point(372, 168);
            this.mERK2ComboBox.Name = "mERK2ComboBox";
            this.mERK2ComboBox.Size = new System.Drawing.Size(121, 21);
            this.mERK2ComboBox.TabIndex = 8;
            // 
            // mERK3Label
            // 
            mERK3Label.AutoSize = true;
            mERK3Label.Location = new System.Drawing.Point(527, 171);
            mERK3Label.Name = "mERK3Label";
            mERK3Label.Size = new System.Drawing.Size(47, 13);
            mERK3Label.TabIndex = 9;
            mERK3Label.Text = "MERK3:";
            // 
            // mERK3ComboBox
            // 
            this.mERK3ComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "MERK3", true));
            this.mERK3ComboBox.FormattingEnabled = true;
            this.mERK3ComboBox.Location = new System.Drawing.Point(580, 168);
            this.mERK3ComboBox.Name = "mERK3ComboBox";
            this.mERK3ComboBox.Size = new System.Drawing.Size(121, 21);
            this.mERK3ComboBox.TabIndex = 10;
            // 
            // dESCRIPTIONLabel
            // 
            dESCRIPTIONLabel.AutoSize = true;
            dESCRIPTIONLabel.Location = new System.Drawing.Point(310, 111);
            dESCRIPTIONLabel.Name = "dESCRIPTIONLabel";
            dESCRIPTIONLabel.Size = new System.Drawing.Size(83, 13);
            dESCRIPTIONLabel.TabIndex = 11;
            dESCRIPTIONLabel.Text = "DESCRIPTION:";
            // 
            // dESCRIPTIONTextBox
            // 
            this.dESCRIPTIONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "DESCRIPTION", true));
            this.dESCRIPTIONTextBox.Location = new System.Drawing.Point(399, 108);
            this.dESCRIPTIONTextBox.Name = "dESCRIPTIONTextBox";
            this.dESCRIPTIONTextBox.Size = new System.Drawing.Size(100, 20);
            this.dESCRIPTIONTextBox.TabIndex = 12;
            // 
            // masterBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(dESCRIPTIONLabel);
            this.Controls.Add(this.dESCRIPTIONTextBox);
            this.Controls.Add(mERK3Label);
            this.Controls.Add(this.mERK3ComboBox);
            this.Controls.Add(mERK2Label);
            this.Controls.Add(this.mERK2ComboBox);
            this.Controls.Add(mERK1Label);
            this.Controls.Add(this.mERK1ComboBox);
            this.Controls.Add(kODELabel);
            this.Controls.Add(this.kODETextBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(this.m_barangBindingNavigator);
            this.Name = "masterBarang";
            this.Text = "masterBarang";
            this.Load += new System.EventHandler(this.masterBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uASDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_barangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_barangBindingNavigator)).EndInit();
            this.m_barangBindingNavigator.ResumeLayout(false);
            this.m_barangBindingNavigator.PerformLayout();
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
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox kODETextBox;
        private System.Windows.Forms.ComboBox mERK1ComboBox;
        private System.Windows.Forms.ComboBox mERK2ComboBox;
        private System.Windows.Forms.ComboBox mERK3ComboBox;
        private System.Windows.Forms.TextBox dESCRIPTIONTextBox;
    }
}