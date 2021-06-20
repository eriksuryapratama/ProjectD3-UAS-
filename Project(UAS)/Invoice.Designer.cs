
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
            System.Windows.Forms.Label p_IDLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoice));
            System.Windows.Forms.Label nO_INVLabel;
            System.Windows.Forms.Label nO_PNWLabel;
            System.Windows.Forms.Label tGL_INVLabel;
            System.Windows.Forms.Label tGL_TERIMALabel;
            this.uASDataSet = new Project_UAS_.UASDataSet();
            this.t_invoiceppn_headerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_invoiceppn_headerTableAdapter = new Project_UAS_.UASDataSetTableAdapters.t_invoiceppn_headerTableAdapter();
            this.tableAdapterManager = new Project_UAS_.UASDataSetTableAdapters.TableAdapterManager();
            this.t_invoiceppn_headerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.t_invoiceppn_headerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_kota = new System.Windows.Forms.TextBox();
            this.tb_nmperusahaan = new System.Windows.Forms.TextBox();
            this.tb_alamat = new System.Windows.Forms.TextBox();
            this.tb_namNpwp = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.tb_npwp = new System.Windows.Forms.TextBox();
            this.tb_note = new System.Windows.Forms.TextBox();
            this.dgv_data = new System.Windows.Forms.DataGridView();
            this.t_invoice_headerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_invoice_headerTableAdapter = new Project_UAS_.UASDataSetTableAdapters.t_invoice_headerTableAdapter();
            this.nO_INVTextBox = new System.Windows.Forms.TextBox();
            this.nO_PNWTextBox = new System.Windows.Forms.TextBox();
            this.tGL_INVDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tGL_TERIMADateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tb_customer = new System.Windows.Forms.TextBox();
            p_IDLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            nO_INVLabel = new System.Windows.Forms.Label();
            nO_PNWLabel = new System.Windows.Forms.Label();
            tGL_INVLabel = new System.Windows.Forms.Label();
            tGL_TERIMALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uASDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_invoiceppn_headerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_invoiceppn_headerBindingNavigator)).BeginInit();
            this.t_invoiceppn_headerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_invoice_headerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // p_IDLabel
            // 
            p_IDLabel.AutoSize = true;
            p_IDLabel.Location = new System.Drawing.Point(15, 95);
            p_IDLabel.Name = "p_IDLabel";
            p_IDLabel.Size = new System.Drawing.Size(104, 20);
            p_IDLabel.TabIndex = 11;
            p_IDLabel.Text = "CUSTOMER:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(15, 158);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(109, 20);
            label2.TabIndex = 15;
            label2.Text = "NAMA NPWP:";
            label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(60, 216);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(59, 20);
            label3.TabIndex = 18;
            label3.Text = "NPWP:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(699, 216);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(56, 20);
            label4.TabIndex = 20;
            label4.Text = "NOTE:";
            // 
            // uASDataSet
            // 
            this.uASDataSet.DataSetName = "UASDataSet";
            this.uASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_invoiceppn_headerBindingSource
            // 
            this.t_invoiceppn_headerBindingSource.DataMember = "t_invoiceppn_header";
            this.t_invoiceppn_headerBindingSource.DataSource = this.uASDataSet;
            // 
            // t_invoiceppn_headerTableAdapter
            // 
            this.t_invoiceppn_headerTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.t_invoiceppn_headerTableAdapter = this.t_invoiceppn_headerTableAdapter;
            this.tableAdapterManager.t_label_hargaTableAdapter = null;
            this.tableAdapterManager.t_pembelian_detailTableAdapter = null;
            this.tableAdapterManager.t_pembelian_headerTableAdapter = null;
            this.tableAdapterManager.t_penawaran_detailTableAdapter = null;
            this.tableAdapterManager.t_penawaran_headerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Project_UAS_.UASDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // t_invoiceppn_headerBindingNavigator
            // 
            this.t_invoiceppn_headerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.t_invoiceppn_headerBindingNavigator.BindingSource = this.t_invoiceppn_headerBindingSource;
            this.t_invoiceppn_headerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.t_invoiceppn_headerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.t_invoiceppn_headerBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.t_invoiceppn_headerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.t_invoiceppn_headerBindingNavigatorSaveItem});
            this.t_invoiceppn_headerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.t_invoiceppn_headerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.t_invoiceppn_headerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.t_invoiceppn_headerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.t_invoiceppn_headerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.t_invoiceppn_headerBindingNavigator.Name = "t_invoiceppn_headerBindingNavigator";
            this.t_invoiceppn_headerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.t_invoiceppn_headerBindingNavigator.Size = new System.Drawing.Size(1552, 33);
            this.t_invoiceppn_headerBindingNavigator.TabIndex = 0;
            this.t_invoiceppn_headerBindingNavigator.Text = "bindingNavigator1";
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
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
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
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // t_invoiceppn_headerBindingNavigatorSaveItem
            // 
            this.t_invoiceppn_headerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.t_invoiceppn_headerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("t_invoiceppn_headerBindingNavigatorSaveItem.Image")));
            this.t_invoiceppn_headerBindingNavigatorSaveItem.Name = "t_invoiceppn_headerBindingNavigatorSaveItem";
            this.t_invoiceppn_headerBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.t_invoiceppn_headerBindingNavigatorSaveItem.Text = "Save Data";
            this.t_invoiceppn_headerBindingNavigatorSaveItem.Click += new System.EventHandler(this.t_invoiceppn_headerBindingNavigatorSaveItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1096, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "EMAIL:";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(1164, 34);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(166, 26);
            this.tb_email.TabIndex = 10;
            // 
            // tb_kota
            // 
            this.tb_kota.Location = new System.Drawing.Point(1346, 35);
            this.tb_kota.Name = "tb_kota";
            this.tb_kota.Size = new System.Drawing.Size(166, 26);
            this.tb_kota.TabIndex = 11;
            // 
            // tb_nmperusahaan
            // 
            this.tb_nmperusahaan.Location = new System.Drawing.Point(282, 92);
            this.tb_nmperusahaan.Name = "tb_nmperusahaan";
            this.tb_nmperusahaan.Size = new System.Drawing.Size(393, 26);
            this.tb_nmperusahaan.TabIndex = 13;
            // 
            // tb_alamat
            // 
            this.tb_alamat.Location = new System.Drawing.Point(732, 92);
            this.tb_alamat.Name = "tb_alamat";
            this.tb_alamat.Size = new System.Drawing.Size(393, 26);
            this.tb_alamat.TabIndex = 14;
            // 
            // tb_namNpwp
            // 
            this.tb_namNpwp.Location = new System.Drawing.Point(140, 151);
            this.tb_namNpwp.Name = "tb_namNpwp";
            this.tb_namNpwp.Size = new System.Drawing.Size(525, 26);
            this.tb_namNpwp.TabIndex = 16;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(703, 151);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(468, 26);
            this.textBox6.TabIndex = 17;
            // 
            // tb_npwp
            // 
            this.tb_npwp.Location = new System.Drawing.Point(140, 210);
            this.tb_npwp.Name = "tb_npwp";
            this.tb_npwp.Size = new System.Drawing.Size(525, 26);
            this.tb_npwp.TabIndex = 19;
            // 
            // tb_note
            // 
            this.tb_note.Location = new System.Drawing.Point(761, 210);
            this.tb_note.Name = "tb_note";
            this.tb_note.Size = new System.Drawing.Size(525, 26);
            this.tb_note.TabIndex = 21;
            // 
            // dgv_data
            // 
            this.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_data.Location = new System.Drawing.Point(12, 278);
            this.dgv_data.Name = "dgv_data";
            this.dgv_data.RowHeadersWidth = 62;
            this.dgv_data.RowTemplate.Height = 28;
            this.dgv_data.Size = new System.Drawing.Size(1159, 246);
            this.dgv_data.TabIndex = 22;
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
            // nO_INVLabel
            // 
            nO_INVLabel.AutoSize = true;
            nO_INVLabel.Location = new System.Drawing.Point(16, 42);
            nO_INVLabel.Name = "nO_INVLabel";
            nO_INVLabel.Size = new System.Drawing.Size(67, 20);
            nO_INVLabel.TabIndex = 22;
            nO_INVLabel.Text = "NO INV:";
            // 
            // nO_INVTextBox
            // 
            this.nO_INVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_invoice_headerBindingSource, "NO_INV", true));
            this.nO_INVTextBox.Location = new System.Drawing.Point(89, 39);
            this.nO_INVTextBox.Name = "nO_INVTextBox";
            this.nO_INVTextBox.Size = new System.Drawing.Size(100, 26);
            this.nO_INVTextBox.TabIndex = 23;
            // 
            // nO_PNWLabel
            // 
            nO_PNWLabel.AutoSize = true;
            nO_PNWLabel.Location = new System.Drawing.Point(213, 42);
            nO_PNWLabel.Name = "nO_PNWLabel";
            nO_PNWLabel.Size = new System.Drawing.Size(76, 20);
            nO_PNWLabel.TabIndex = 23;
            nO_PNWLabel.Text = "NO PNW:";
            // 
            // nO_PNWTextBox
            // 
            this.nO_PNWTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_invoice_headerBindingSource, "NO_PNW", true));
            this.nO_PNWTextBox.Location = new System.Drawing.Point(295, 39);
            this.nO_PNWTextBox.Name = "nO_PNWTextBox";
            this.nO_PNWTextBox.Size = new System.Drawing.Size(100, 26);
            this.nO_PNWTextBox.TabIndex = 24;
            // 
            // tGL_INVLabel
            // 
            tGL_INVLabel.AutoSize = true;
            tGL_INVLabel.Location = new System.Drawing.Point(431, 40);
            tGL_INVLabel.Name = "tGL_INVLabel";
            tGL_INVLabel.Size = new System.Drawing.Size(75, 20);
            tGL_INVLabel.TabIndex = 24;
            tGL_INVLabel.Text = "TGL INV:";
            // 
            // tGL_INVDateTimePicker
            // 
            this.tGL_INVDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.t_invoice_headerBindingSource, "TGL_INV", true));
            this.tGL_INVDateTimePicker.Location = new System.Drawing.Point(512, 36);
            this.tGL_INVDateTimePicker.Name = "tGL_INVDateTimePicker";
            this.tGL_INVDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.tGL_INVDateTimePicker.TabIndex = 25;
            // 
            // tGL_TERIMALabel
            // 
            tGL_TERIMALabel.AutoSize = true;
            tGL_TERIMALabel.Location = new System.Drawing.Point(743, 36);
            tGL_TERIMALabel.Name = "tGL_TERIMALabel";
            tGL_TERIMALabel.Size = new System.Drawing.Size(109, 20);
            tGL_TERIMALabel.TabIndex = 25;
            tGL_TERIMALabel.Text = "TGL TERIMA:";
            // 
            // tGL_TERIMADateTimePicker
            // 
            this.tGL_TERIMADateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.t_invoice_headerBindingSource, "TGL_TERIMA", true));
            this.tGL_TERIMADateTimePicker.Location = new System.Drawing.Point(858, 32);
            this.tGL_TERIMADateTimePicker.Name = "tGL_TERIMADateTimePicker";
            this.tGL_TERIMADateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.tGL_TERIMADateTimePicker.TabIndex = 26;
            // 
            // tb_customer
            // 
            this.tb_customer.Location = new System.Drawing.Point(125, 92);
            this.tb_customer.Name = "tb_customer";
            this.tb_customer.Size = new System.Drawing.Size(150, 26);
            this.tb_customer.TabIndex = 27;
            this.tb_customer.Text = "1";
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1552, 544);
            this.Controls.Add(this.tb_customer);
            this.Controls.Add(tGL_TERIMALabel);
            this.Controls.Add(this.tGL_TERIMADateTimePicker);
            this.Controls.Add(tGL_INVLabel);
            this.Controls.Add(this.tGL_INVDateTimePicker);
            this.Controls.Add(nO_PNWLabel);
            this.Controls.Add(this.nO_PNWTextBox);
            this.Controls.Add(nO_INVLabel);
            this.Controls.Add(this.nO_INVTextBox);
            this.Controls.Add(this.dgv_data);
            this.Controls.Add(this.tb_note);
            this.Controls.Add(label4);
            this.Controls.Add(this.tb_npwp);
            this.Controls.Add(label3);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.tb_namNpwp);
            this.Controls.Add(label2);
            this.Controls.Add(this.tb_alamat);
            this.Controls.Add(this.tb_nmperusahaan);
            this.Controls.Add(p_IDLabel);
            this.Controls.Add(this.tb_kota);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.t_invoiceppn_headerBindingNavigator);
            this.Name = "Invoice";
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.Invoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uASDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_invoiceppn_headerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_invoiceppn_headerBindingNavigator)).EndInit();
            this.t_invoiceppn_headerBindingNavigator.ResumeLayout(false);
            this.t_invoiceppn_headerBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_invoice_headerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UASDataSet uASDataSet;
        private System.Windows.Forms.BindingSource t_invoiceppn_headerBindingSource;
        private UASDataSetTableAdapters.t_invoiceppn_headerTableAdapter t_invoiceppn_headerTableAdapter;
        private UASDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator t_invoiceppn_headerBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton t_invoiceppn_headerBindingNavigatorSaveItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_kota;
        private System.Windows.Forms.TextBox tb_nmperusahaan;
        private System.Windows.Forms.TextBox tb_alamat;
        private System.Windows.Forms.TextBox tb_namNpwp;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox tb_npwp;
        private System.Windows.Forms.TextBox tb_note;
        private System.Windows.Forms.DataGridView dgv_data;
        private System.Windows.Forms.BindingSource t_invoice_headerBindingSource;
        private UASDataSetTableAdapters.t_invoice_headerTableAdapter t_invoice_headerTableAdapter;
        private System.Windows.Forms.TextBox nO_INVTextBox;
        private System.Windows.Forms.TextBox nO_PNWTextBox;
        private System.Windows.Forms.DateTimePicker tGL_INVDateTimePicker;
        private System.Windows.Forms.DateTimePicker tGL_TERIMADateTimePicker;
        private System.Windows.Forms.TextBox tb_customer;
    }
}