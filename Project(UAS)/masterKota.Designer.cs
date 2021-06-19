
namespace Project_UAS_
{
    partial class masterKota
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
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Find = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.dgv_Kota = new System.Windows.Forms.DataGridView();
            this.tb_Kota = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Kota)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(92, 189);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(100, 23);
            this.btn_Edit.TabIndex = 108;
            this.btn_Edit.Text = "Update";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(92, 160);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(100, 23);
            this.btn_Add.TabIndex = 107;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 31);
            this.label1.TabIndex = 109;
            this.label1.Text = "Input Master Kota";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 111;
            this.label2.Text = "Kota";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(92, 218);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(100, 23);
            this.btn_Delete.TabIndex = 113;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Find
            // 
            this.btn_Find.Location = new System.Drawing.Point(92, 276);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(100, 23);
            this.btn_Find.TabIndex = 117;
            this.btn_Find.Text = "Find";
            this.btn_Find.UseVisualStyleBackColor = true;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(92, 305);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(100, 23);
            this.btn_Exit.TabIndex = 116;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(92, 247);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(100, 23);
            this.btn_Print.TabIndex = 115;
            this.btn_Print.Text = "Print";
            this.btn_Print.UseVisualStyleBackColor = true;
            // 
            // dgv_Kota
            // 
            this.dgv_Kota.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Kota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Kota.Location = new System.Drawing.Point(208, 108);
            this.dgv_Kota.Name = "dgv_Kota";
            this.dgv_Kota.ReadOnly = true;
            this.dgv_Kota.Size = new System.Drawing.Size(158, 220);
            this.dgv_Kota.TabIndex = 118;
            this.dgv_Kota.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Kota_CellContentClick);
            this.dgv_Kota.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Kota_RowHeaderMouseClick);
            // 
            // tb_Kota
            // 
            this.tb_Kota.Location = new System.Drawing.Point(92, 108);
            this.tb_Kota.Name = "tb_Kota";
            this.tb_Kota.Size = new System.Drawing.Size(100, 20);
            this.tb_Kota.TabIndex = 119;
            // 
            // masterKota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(396, 355);
            this.Controls.Add(this.tb_Kota);
            this.Controls.Add(this.dgv_Kota);
            this.Controls.Add(this.btn_Find);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.Name = "masterKota";
            this.Text = "masterKota";
            this.Load += new System.EventHandler(this.masterKota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Kota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_Edit;
        public System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btn_Delete;
        public System.Windows.Forms.Button btn_Find;
        public System.Windows.Forms.Button btn_Exit;
        public System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.DataGridView dgv_Kota;
        private System.Windows.Forms.TextBox tb_Kota;
    }
}