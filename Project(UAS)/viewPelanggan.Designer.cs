
namespace Project_UAS_
{
    partial class viewPelanggan
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
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.dgv_Pelanggan = new System.Windows.Forms.DataGridView();
            this.btn_addData = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pelanggan)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(822, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 123;
            this.label3.Text = "Search";
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(892, 11);
            this.tb_Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(254, 26);
            this.tb_Search.TabIndex = 122;
            this.tb_Search.TextChanged += new System.EventHandler(this.tb_Search_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(660, 637);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 26);
            this.textBox1.TabIndex = 126;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Red;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Delete.Location = new System.Drawing.Point(962, 625);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(188, 54);
            this.btn_Delete.TabIndex = 125;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // dgv_Pelanggan
            // 
            this.dgv_Pelanggan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Pelanggan.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_Pelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Pelanggan.Location = new System.Drawing.Point(4, 76);
            this.dgv_Pelanggan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_Pelanggan.Name = "dgv_Pelanggan";
            this.dgv_Pelanggan.ReadOnly = true;
            this.dgv_Pelanggan.RowHeadersWidth = 62;
            this.dgv_Pelanggan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Pelanggan.Size = new System.Drawing.Size(1788, 532);
            this.dgv_Pelanggan.TabIndex = 124;
            this.dgv_Pelanggan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Pelanggan_CellContentClick);
            // 
            // btn_addData
            // 
            this.btn_addData.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_addData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addData.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_addData.Location = new System.Drawing.Point(18, 625);
            this.btn_addData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_addData.Name = "btn_addData";
            this.btn_addData.Size = new System.Drawing.Size(192, 54);
            this.btn_addData.TabIndex = 122;
            this.btn_addData.Text = "Add Data";
            this.btn_addData.UseVisualStyleBackColor = false;
            this.btn_addData.Click += new System.EventHandler(this.btn_addData_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_Search);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 52);
            this.panel1.TabIndex = 123;
            // 
            // viewPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 692);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.dgv_Pelanggan);
            this.Controls.Add(this.btn_addData);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "viewPelanggan";
            this.Text = "viewPelanggan";
            this.Load += new System.EventHandler(this.viewPelanggan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pelanggan)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.DataGridView dgv_Pelanggan;
        private System.Windows.Forms.Button btn_addData;
        private System.Windows.Forms.Panel panel1;
    }
}