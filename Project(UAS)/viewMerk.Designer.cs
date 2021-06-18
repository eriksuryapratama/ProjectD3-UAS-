
namespace Project_UAS_
{
    partial class viewMerk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewMerk));
            this.dgv_masterBarang = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_addData = new System.Windows.Forms.Button();
            this.column_deleted = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_masterBarang)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_masterBarang
            // 
            this.dgv_masterBarang.AllowUserToAddRows = false;
            this.dgv_masterBarang.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_masterBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_masterBarang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column14,
            this.Column1,
            this.Column13,
            this.column_deleted});
            this.dgv_masterBarang.Location = new System.Drawing.Point(3, 33);
            this.dgv_masterBarang.Name = "dgv_masterBarang";
            this.dgv_masterBarang.ReadOnly = true;
            this.dgv_masterBarang.RowHeadersVisible = false;
            this.dgv_masterBarang.RowHeadersWidth = 62;
            this.dgv_masterBarang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_masterBarang.Size = new System.Drawing.Size(405, 414);
            this.dgv_masterBarang.TabIndex = 9;
            this.dgv_masterBarang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_masterBarang_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_addData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 34);
            this.panel1.TabIndex = 8;
            // 
            // btn_addData
            // 
            this.btn_addData.Location = new System.Drawing.Point(3, 4);
            this.btn_addData.Name = "btn_addData";
            this.btn_addData.Size = new System.Drawing.Size(128, 23);
            this.btn_addData.TabIndex = 1;
            this.btn_addData.Text = "Add Data";
            this.btn_addData.UseVisualStyleBackColor = true;
            this.btn_addData.Click += new System.EventHandler(this.btn_addData_Click);
            // 
            // column_deleted
            // 
            this.column_deleted.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.column_deleted.HeaderText = "";
            this.column_deleted.Image = ((System.Drawing.Image)(resources.GetObject("column_deleted.Image")));
            this.column_deleted.MinimumWidth = 8;
            this.column_deleted.Name = "column_deleted";
            this.column_deleted.ReadOnly = true;
            this.column_deleted.Width = 8;
            // 
            // Column13
            // 
            this.Column13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column13.HeaderText = "MERK DESCRIPTION";
            this.Column13.MinimumWidth = 8;
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "MERK CODE";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 96;
            // 
            // Column14
            // 
            this.Column14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column14.HeaderText = "#";
            this.Column14.MinimumWidth = 8;
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Width = 39;
            // 
            // viewMerk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(408, 450);
            this.Controls.Add(this.dgv_masterBarang);
            this.Controls.Add(this.panel1);
            this.Name = "viewMerk";
            this.Text = "viewMerk";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_masterBarang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_masterBarang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_addData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewImageColumn column_deleted;
    }
}