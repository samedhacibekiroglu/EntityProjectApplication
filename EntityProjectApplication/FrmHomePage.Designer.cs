
namespace EntityProjectApplication
{
    partial class FrmHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHomePage));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.LblHomePageCategoryOptions = new System.Windows.Forms.Label();
            this.LblHomePageProductOptions = new System.Windows.Forms.Label();
            this.LblHomePageStatistic = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(-4, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 145);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(256, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 145);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(502, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(244, 145);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // LblHomePageCategoryOptions
            // 
            this.LblHomePageCategoryOptions.AutoSize = true;
            this.LblHomePageCategoryOptions.Font = new System.Drawing.Font("Ravie", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHomePageCategoryOptions.Location = new System.Drawing.Point(12, 185);
            this.LblHomePageCategoryOptions.Name = "LblHomePageCategoryOptions";
            this.LblHomePageCategoryOptions.Size = new System.Drawing.Size(212, 22);
            this.LblHomePageCategoryOptions.TabIndex = 3;
            this.LblHomePageCategoryOptions.Text = "Category Options";
            // 
            // LblHomePageProductOptions
            // 
            this.LblHomePageProductOptions.AutoSize = true;
            this.LblHomePageProductOptions.Font = new System.Drawing.Font("Ravie", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHomePageProductOptions.Location = new System.Drawing.Point(270, 185);
            this.LblHomePageProductOptions.Name = "LblHomePageProductOptions";
            this.LblHomePageProductOptions.Size = new System.Drawing.Size(211, 22);
            this.LblHomePageProductOptions.TabIndex = 4;
            this.LblHomePageProductOptions.Text = "Products Options";
            // 
            // LblHomePageStatistic
            // 
            this.LblHomePageStatistic.AutoSize = true;
            this.LblHomePageStatistic.Font = new System.Drawing.Font("Ravie", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHomePageStatistic.Location = new System.Drawing.Point(565, 185);
            this.LblHomePageStatistic.Name = "LblHomePageStatistic";
            this.LblHomePageStatistic.Size = new System.Drawing.Size(137, 22);
            this.LblHomePageStatistic.TabIndex = 5;
            this.LblHomePageStatistic.Text = "Statistics";
            // 
            // FrmHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 436);
            this.Controls.Add(this.LblHomePageStatistic);
            this.Controls.Add(this.LblHomePageProductOptions);
            this.Controls.Add(this.LblHomePageCategoryOptions);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmHomePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label LblHomePageCategoryOptions;
        private System.Windows.Forms.Label LblHomePageProductOptions;
        private System.Windows.Forms.Label LblHomePageStatistic;
    }
}