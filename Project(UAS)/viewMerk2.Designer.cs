
namespace Project_UAS_
{
    partial class viewMerk2
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
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.dgv_Model = new System.Windows.Forms.DataGridView();
            this.btn_addData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Model)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(594, 5);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(171, 20);
            this.tb_Search.TabIndex = 136;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(547, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 137;
            this.label3.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(393, 419);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 20);
            this.textBox1.TabIndex = 140;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Red;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Delete.Location = new System.Drawing.Point(594, 411);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(125, 35);
            this.btn_Delete.TabIndex = 139;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            // 
            // dgv_Model
            // 
            this.dgv_Model.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Model.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_Model.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Model.Location = new System.Drawing.Point(6, 42);
            this.dgv_Model.Name = "dgv_Model";
            this.dgv_Model.ReadOnly = true;
            this.dgv_Model.RowHeadersWidth = 62;
            this.dgv_Model.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Model.Size = new System.Drawing.Size(788, 346);
            this.dgv_Model.TabIndex = 138;
            // 
            // btn_addData
            // 
            this.btn_addData.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_addData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addData.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_addData.Location = new System.Drawing.Point(36, 411);
            this.btn_addData.Name = "btn_addData";
            this.btn_addData.Size = new System.Drawing.Size(128, 35);
            this.btn_addData.TabIndex = 141;
            this.btn_addData.Text = "Add Data";
            this.btn_addData.UseVisualStyleBackColor = false;
            // 
            // viewMerk2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_addData);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.dgv_Model);
            this.Name = "viewMerk2";
            this.Text = "viewMerk2";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Model)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.DataGridView dgv_Model;
        private System.Windows.Forms.Button btn_addData;
    }
}