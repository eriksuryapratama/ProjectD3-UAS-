
namespace Project_UAS_
{
    partial class viewModel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_addData = new System.Windows.Forms.Button();
            this.dgv_Model = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Model)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tb_Search);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 52);
            this.panel1.TabIndex = 131;
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(882, 5);
            this.tb_Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(254, 26);
            this.tb_Search.TabIndex = 125;
            this.tb_Search.TextChanged += new System.EventHandler(this.tb_Search_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(812, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 126;
            this.label3.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(580, 642);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 26);
            this.textBox1.TabIndex = 135;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Red;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Delete.Location = new System.Drawing.Point(882, 629);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(188, 54);
            this.btn_Delete.TabIndex = 134;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_addData
            // 
            this.btn_addData.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_addData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addData.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_addData.Location = new System.Drawing.Point(18, 629);
            this.btn_addData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_addData.Name = "btn_addData";
            this.btn_addData.Size = new System.Drawing.Size(192, 54);
            this.btn_addData.TabIndex = 133;
            this.btn_addData.UseVisualStyleBackColor = false;
            this.btn_addData.Click += new System.EventHandler(this.btn_addData_Click);
            // 
            // dgv_Model
            // 
            this.dgv_Model.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Model.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_Model.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Model.Location = new System.Drawing.Point(0, 62);
            this.dgv_Model.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_Model.Name = "dgv_Model";
            this.dgv_Model.ReadOnly = true;
            this.dgv_Model.RowHeadersWidth = 62;
            this.dgv_Model.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Model.Size = new System.Drawing.Size(1182, 532);
            this.dgv_Model.TabIndex = 132;
            this.dgv_Model.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Model_CellContentClick);
            // 
            // viewModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_addData);
            this.Controls.Add(this.dgv_Model);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "viewModel";
            this.Text = "viewModel";
            this.Load += new System.EventHandler(this.viewModel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Model)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_addData;
        private System.Windows.Forms.DataGridView dgv_Model;
    }
}