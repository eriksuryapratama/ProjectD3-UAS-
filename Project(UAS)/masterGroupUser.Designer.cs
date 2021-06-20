
namespace Project_UAS_
{
    partial class masterGroupUser
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
            this.tb_Groupuser = new System.Windows.Forms.TextBox();
            this.dgv_Group = new System.Windows.Forms.DataGridView();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Group)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 132;
            this.label3.Text = "Search";
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(324, 116);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(171, 20);
            this.tb_Search.TabIndex = 131;
            this.tb_Search.TextChanged += new System.EventHandler(this.tb_Search_TextChanged);
            // 
            // tb_Groupuser
            // 
            this.tb_Groupuser.Location = new System.Drawing.Point(123, 119);
            this.tb_Groupuser.Name = "tb_Groupuser";
            this.tb_Groupuser.Size = new System.Drawing.Size(100, 20);
            this.tb_Groupuser.TabIndex = 130;
            // 
            // dgv_Group
            // 
            this.dgv_Group.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Group.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Group.Location = new System.Drawing.Point(280, 151);
            this.dgv_Group.Name = "dgv_Group";
            this.dgv_Group.ReadOnly = true;
            this.dgv_Group.Size = new System.Drawing.Size(215, 114);
            this.dgv_Group.TabIndex = 129;
            this.dgv_Group.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Group_CellContentClick);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(395, 284);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(100, 23);
            this.btn_Exit.TabIndex = 128;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(280, 284);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(100, 23);
            this.btn_Print.TabIndex = 127;
            this.btn_Print.Text = "Print";
            this.btn_Print.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(123, 190);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(100, 23);
            this.btn_Delete.TabIndex = 126;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 125;
            this.label2.Text = "Group User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 31);
            this.label1.TabIndex = 124;
            this.label1.Text = "Input Master Group User";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(123, 219);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(100, 23);
            this.btn_Edit.TabIndex = 123;
            this.btn_Edit.Text = "Update";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(123, 161);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(100, 23);
            this.btn_Add.TabIndex = 122;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // masterGroupUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(574, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.tb_Groupuser);
            this.Controls.Add(this.dgv_Group);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.Name = "masterGroupUser";
            this.Text = "masterGroupUser";
            this.Load += new System.EventHandler(this.masterGroupUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Group)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.TextBox tb_Groupuser;
        private System.Windows.Forms.DataGridView dgv_Group;
        public System.Windows.Forms.Button btn_Exit;
        public System.Windows.Forms.Button btn_Print;
        public System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btn_Edit;
        public System.Windows.Forms.Button btn_Add;
    }
}