
namespace EntityProjectApplication
{
    partial class FrmCategory
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
            this.LblCategoryCategoryId = new System.Windows.Forms.Label();
            this.LblCategoryCategoryName = new System.Windows.Forms.Label();
            this.TxtCategoryCategoryId = new System.Windows.Forms.TextBox();
            this.TxtCategoryCategoryName = new System.Windows.Forms.TextBox();
            this.BtnCategoryList = new System.Windows.Forms.Button();
            this.BtnCategoryUpdate = new System.Windows.Forms.Button();
            this.BtnCategoryDelete = new System.Windows.Forms.Button();
            this.BtnCategoryAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCategoryCategoryId
            // 
            this.LblCategoryCategoryId.AutoSize = true;
            this.LblCategoryCategoryId.Location = new System.Drawing.Point(40, 9);
            this.LblCategoryCategoryId.Name = "LblCategoryCategoryId";
            this.LblCategoryCategoryId.Size = new System.Drawing.Size(95, 20);
            this.LblCategoryCategoryId.TabIndex = 0;
            this.LblCategoryCategoryId.Text = "Category Id:";
            // 
            // LblCategoryCategoryName
            // 
            this.LblCategoryCategoryName.AutoSize = true;
            this.LblCategoryCategoryName.Location = new System.Drawing.Point(12, 54);
            this.LblCategoryCategoryName.Name = "LblCategoryCategoryName";
            this.LblCategoryCategoryName.Size = new System.Drawing.Size(123, 20);
            this.LblCategoryCategoryName.TabIndex = 1;
            this.LblCategoryCategoryName.Text = "Category Name:";
            // 
            // TxtCategoryCategoryId
            // 
            this.TxtCategoryCategoryId.Location = new System.Drawing.Point(135, 6);
            this.TxtCategoryCategoryId.Name = "TxtCategoryCategoryId";
            this.TxtCategoryCategoryId.Size = new System.Drawing.Size(123, 26);
            this.TxtCategoryCategoryId.TabIndex = 2;
            // 
            // TxtCategoryCategoryName
            // 
            this.TxtCategoryCategoryName.Location = new System.Drawing.Point(135, 54);
            this.TxtCategoryCategoryName.Name = "TxtCategoryCategoryName";
            this.TxtCategoryCategoryName.Size = new System.Drawing.Size(123, 26);
            this.TxtCategoryCategoryName.TabIndex = 3;
            // 
            // BtnCategoryList
            // 
            this.BtnCategoryList.Location = new System.Drawing.Point(16, 100);
            this.BtnCategoryList.Name = "BtnCategoryList";
            this.BtnCategoryList.Size = new System.Drawing.Size(112, 32);
            this.BtnCategoryList.TabIndex = 4;
            this.BtnCategoryList.Text = "LIST";
            this.BtnCategoryList.UseVisualStyleBackColor = true;
            this.BtnCategoryList.Click += new System.EventHandler(this.BtnCategoryList_Click);
            // 
            // BtnCategoryUpdate
            // 
            this.BtnCategoryUpdate.Location = new System.Drawing.Point(16, 168);
            this.BtnCategoryUpdate.Name = "BtnCategoryUpdate";
            this.BtnCategoryUpdate.Size = new System.Drawing.Size(112, 32);
            this.BtnCategoryUpdate.TabIndex = 5;
            this.BtnCategoryUpdate.Text = "Update";
            this.BtnCategoryUpdate.UseVisualStyleBackColor = true;
            this.BtnCategoryUpdate.Click += new System.EventHandler(this.BtnCategoryUpdate_Click);
            // 
            // BtnCategoryDelete
            // 
            this.BtnCategoryDelete.Location = new System.Drawing.Point(146, 100);
            this.BtnCategoryDelete.Name = "BtnCategoryDelete";
            this.BtnCategoryDelete.Size = new System.Drawing.Size(112, 32);
            this.BtnCategoryDelete.TabIndex = 6;
            this.BtnCategoryDelete.Text = "DELETE";
            this.BtnCategoryDelete.UseVisualStyleBackColor = true;
            this.BtnCategoryDelete.Click += new System.EventHandler(this.BtnCategoryDelete_Click);
            // 
            // BtnCategoryAdd
            // 
            this.BtnCategoryAdd.Location = new System.Drawing.Point(146, 168);
            this.BtnCategoryAdd.Name = "BtnCategoryAdd";
            this.BtnCategoryAdd.Size = new System.Drawing.Size(112, 32);
            this.BtnCategoryAdd.TabIndex = 7;
            this.BtnCategoryAdd.Text = "ADD";
            this.BtnCategoryAdd.UseVisualStyleBackColor = true;
            this.BtnCategoryAdd.Click += new System.EventHandler(this.BtnCategoryAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(276, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(395, 194);
            this.dataGridView1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 206);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnCategoryAdd);
            this.Controls.Add(this.BtnCategoryDelete);
            this.Controls.Add(this.BtnCategoryUpdate);
            this.Controls.Add(this.BtnCategoryList);
            this.Controls.Add(this.TxtCategoryCategoryName);
            this.Controls.Add(this.TxtCategoryCategoryId);
            this.Controls.Add(this.LblCategoryCategoryName);
            this.Controls.Add(this.LblCategoryCategoryId);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "FrmCategory";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCategoryCategoryId;
        private System.Windows.Forms.Label LblCategoryCategoryName;
        private System.Windows.Forms.TextBox TxtCategoryCategoryId;
        private System.Windows.Forms.TextBox TxtCategoryCategoryName;
        private System.Windows.Forms.Button BtnCategoryList;
        private System.Windows.Forms.Button BtnCategoryUpdate;
        private System.Windows.Forms.Button BtnCategoryDelete;
        private System.Windows.Forms.Button BtnCategoryAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

