namespace ABC_Car_Traders
{
    partial class trackOrder
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
            this.backBtn = new System.Windows.Forms.Button();
            this.viewtSearchBtn = new System.Windows.Forms.Button();
            this.viewSearchtTxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(676, 445);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(125, 23);
            this.backBtn.TabIndex = 15;
            this.backBtn.Text = "BACK";
            this.backBtn.UseVisualStyleBackColor = true;
            // 
            // viewtSearchBtn
            // 
            this.viewtSearchBtn.Location = new System.Drawing.Point(747, 13);
            this.viewtSearchBtn.Name = "viewtSearchBtn";
            this.viewtSearchBtn.Size = new System.Drawing.Size(125, 23);
            this.viewtSearchBtn.TabIndex = 14;
            this.viewtSearchBtn.Text = "SEARCH";
            this.viewtSearchBtn.UseVisualStyleBackColor = true;
            // 
            // viewSearchtTxt
            // 
            this.viewSearchtTxt.Location = new System.Drawing.Point(474, 15);
            this.viewSearchtTxt.Name = "viewSearchtTxt";
            this.viewSearchtTxt.Size = new System.Drawing.Size(231, 20);
            this.viewSearchtTxt.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 346);
            this.dataGridView1.TabIndex = 12;
            // 
            // trackOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 480);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.viewtSearchBtn);
            this.Controls.Add(this.viewSearchtTxt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "trackOrder";
            this.Text = "trackOrder";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button viewtSearchBtn;
        private System.Windows.Forms.TextBox viewSearchtTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}