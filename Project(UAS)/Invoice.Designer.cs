
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoice));
            System.Windows.Forms.Label nO_INVLabel;
            System.Windows.Forms.Label nO_PNWLabel;
            System.Windows.Forms.Label tGL_INVLabel;
            System.Windows.Forms.Label p_IDLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            this.uASDataSet = new Project_UAS_.UASDataSet();
            this.t_invoiceppn_headerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_invoiceppn_headerTableAdapter = new Project_UAS_.UASDataSetTableAdapters.t_invoiceppn_headerTableAdapter();
            this.tableAdapterManager = new Project_UAS_.UASDataSetTableAdapters.TableAdapterManager();
            this.t_invoiceppn_headerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.t_invoiceppn_headerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tb_invoice = new System.Windows.Forms.TextBox();
            this.tb_penwrn = new System.Windows.Forms.TextBox();
            this.tgl_in = new System.Windows.Forms.DateTimePicker();
            this.tgl_terima = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_kota = new System.Windows.Forms.TextBox();
            this.tb_customer = new System.Windows.Forms.TextBox();
            this.tb_nmperusahaan = new System.Windows.Forms.TextBox();
            this.tb_alamat = new System.Windows.Forms.TextBox();
            this.tb_namNpwp = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.tb_npwp = new System.Windows.Forms.TextBox();
            this.tb_note = new System.Windows.Forms.TextBox();
            nO_INVLabel = new System.Windows.Forms.Label();
            nO_PNWLabel = new System.Windows.Forms.Label();
            tGL_INVLabel = new System.Windows.Forms.Label();
            p_IDLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uASDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_invoiceppn_headerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_invoiceppn_headerBindingNavigator)).BeginInit();
            this.t_invoiceppn_headerBindingNavigator.SuspendLayout();
            this.SuspendLayout();
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            // nO_INVLabel
            // 
            nO_INVLabel.AutoSize = true;
            nO_INVLabel.Location = new System.Drawing.Point(12, 41);
            nO_INVLabel.Name = "nO_INVLabel";
            nO_INVLabel.Size = new System.Drawing.Size(79, 20);
            nO_INVLabel.TabIndex = 1;
            nO_INVLabel.Text = "INVOICE:";
            // 
            // tb_invoice
            // 
            this.tb_invoice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_invoiceppn_headerBindingSource, "NO_INV", true));
            this.tb_invoice.Location = new System.Drawing.Point(97, 38);
            this.tb_invoice.Name = "tb_invoice";
            this.tb_invoice.Size = new System.Drawing.Size(100, 26);
            this.tb_invoice.TabIndex = 2;
            // 
            // nO_PNWLabel
            // 
            nO_PNWLabel.AutoSize = true;
            nO_PNWLabel.Location = new System.Drawing.Point(217, 41);
            nO_PNWLabel.Name = "nO_PNWLabel";
            nO_PNWLabel.Size = new System.Drawing.Size(57, 20);
            nO_PNWLabel.TabIndex = 3;
            nO_PNWLabel.Text = "Pnwrn:";
            // 
            // tb_penwrn
            // 
            this.tb_penwrn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_invoiceppn_headerBindingSource, "NO_PNW", true));
            this.tb_penwrn.Location = new System.Drawing.Point(299, 38);
            this.tb_penwrn.Name = "tb_penwrn";
            this.tb_penwrn.Size = new System.Drawing.Size(100, 26);
            this.tb_penwrn.TabIndex = 4;
            // 
            // tGL_INVLabel
            // 
            tGL_INVLabel.AutoSize = true;
            tGL_INVLabel.Location = new System.Drawing.Point(410, 39);
            tGL_INVLabel.Name = "tGL_INVLabel";
            tGL_INVLabel.Size = new System.Drawing.Size(49, 20);
            tGL_INVLabel.TabIndex = 5;
            tGL_INVLabel.Text = "TT In:";
            // 
            // tgl_in
            // 
            this.tgl_in.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.t_invoiceppn_headerBindingSource, "TGL_INV", true));
            this.tgl_in.Location = new System.Drawing.Point(465, 36);
            this.tgl_in.Name = "tgl_in";
            this.tgl_in.Size = new System.Drawing.Size(200, 26);
            this.tgl_in.TabIndex = 6;
            // 
            // tgl_terima
            // 
            this.tgl_terima.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.t_invoiceppn_headerBindingSource, "TGL_TERIMA", true));
            this.tgl_terima.Location = new System.Drawing.Point(703, 35);
            this.tgl_terima.Name = "tgl_terima";
            this.tgl_terima.Size = new System.Drawing.Size(200, 26);
            this.tgl_terima.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(937, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "EMAIL:";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(1005, 37);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(166, 26);
            this.tb_email.TabIndex = 10;
            // 
            // tb_kota
            // 
            this.tb_kota.Location = new System.Drawing.Point(1187, 38);
            this.tb_kota.Name = "tb_kota";
            this.tb_kota.Size = new System.Drawing.Size(166, 26);
            this.tb_kota.TabIndex = 11;
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
            // tb_customer
            // 
            this.tb_customer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_invoiceppn_headerBindingSource, "P_ID", true));
            this.tb_customer.Location = new System.Drawing.Point(125, 92);
            this.tb_customer.Name = "tb_customer";
            this.tb_customer.Size = new System.Drawing.Size(129, 26);
            this.tb_customer.TabIndex = 12;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(60, 216);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(59, 20);
            label3.TabIndex = 18;
            label3.Text = "NPWP:";
            // 
            // tb_npwp
            // 
            this.tb_npwp.Location = new System.Drawing.Point(140, 210);
            this.tb_npwp.Name = "tb_npwp";
            this.tb_npwp.Size = new System.Drawing.Size(525, 26);
            this.tb_npwp.TabIndex = 19;
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
            // tb_note
            // 
            this.tb_note.Location = new System.Drawing.Point(761, 210);
            this.tb_note.Name = "tb_note";
            this.tb_note.Size = new System.Drawing.Size(525, 26);
            this.tb_note.TabIndex = 21;
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1552, 485);
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
            this.Controls.Add(this.tb_customer);
            this.Controls.Add(this.tb_kota);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tgl_terima);
            this.Controls.Add(tGL_INVLabel);
            this.Controls.Add(this.tgl_in);
            this.Controls.Add(nO_PNWLabel);
            this.Controls.Add(this.tb_penwrn);
            this.Controls.Add(nO_INVLabel);
            this.Controls.Add(this.tb_invoice);
            this.Controls.Add(this.t_invoiceppn_headerBindingNavigator);
            this.Name = "Invoice";
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.Invoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uASDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_invoiceppn_headerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_invoiceppn_headerBindingNavigator)).EndInit();
            this.t_invoiceppn_headerBindingNavigator.ResumeLayout(false);
            this.t_invoiceppn_headerBindingNavigator.PerformLayout();
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
        private System.Windows.Forms.TextBox tb_invoice;
        private System.Windows.Forms.TextBox tb_penwrn;
        private System.Windows.Forms.DateTimePicker tgl_in;
        private System.Windows.Forms.DateTimePicker tgl_terima;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_kota;
        private System.Windows.Forms.TextBox tb_customer;
        private System.Windows.Forms.TextBox tb_nmperusahaan;
        private System.Windows.Forms.TextBox tb_alamat;
        private System.Windows.Forms.TextBox tb_namNpwp;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox tb_npwp;
        private System.Windows.Forms.TextBox tb_note;
    }
}