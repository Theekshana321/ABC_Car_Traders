namespace ABC_Car_Traders
{
    partial class ViewBill
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.viewtSearchBtn = new System.Windows.Forms.Button();
            this.viewSearchtTxt = new System.Windows.Forms.TextBox();
            this.BillBackBtn = new System.Windows.Forms.Button();
            this.addBillBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "View Bill Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(859, 287);
            this.dataGridView1.TabIndex = 2;
            // 
            // viewtSearchBtn
            // 
            this.viewtSearchBtn.Location = new System.Drawing.Point(763, 41);
            this.viewtSearchBtn.Name = "viewtSearchBtn";
            this.viewtSearchBtn.Size = new System.Drawing.Size(125, 23);
            this.viewtSearchBtn.TabIndex = 12;
            this.viewtSearchBtn.Text = "SEARCH";
            this.viewtSearchBtn.UseVisualStyleBackColor = true;
            // 
            // viewSearchtTxt
            // 
            this.viewSearchtTxt.Location = new System.Drawing.Point(490, 43);
            this.viewSearchtTxt.Name = "viewSearchtTxt";
            this.viewSearchtTxt.Size = new System.Drawing.Size(231, 20);
            this.viewSearchtTxt.TabIndex = 11;
            // 
            // BillBackBtn
            // 
            this.BillBackBtn.Location = new System.Drawing.Point(763, 400);
            this.BillBackBtn.Name = "BillBackBtn";
            this.BillBackBtn.Size = new System.Drawing.Size(125, 23);
            this.BillBackBtn.TabIndex = 13;
            this.BillBackBtn.Text = "BACK";
            this.BillBackBtn.UseVisualStyleBackColor = true;
            this.BillBackBtn.Click += new System.EventHandler(this.BillBackBtn_Click);
            // 
            // addBillBtn
            // 
            this.addBillBtn.Location = new System.Drawing.Point(391, 400);
            this.addBillBtn.Name = "addBillBtn";
            this.addBillBtn.Size = new System.Drawing.Size(228, 23);
            this.addBillBtn.TabIndex = 14;
            this.addBillBtn.Text = "ADD";
            this.addBillBtn.UseVisualStyleBackColor = true;
            this.addBillBtn.Click += new System.EventHandler(this.addBillBtn_Click);
            // 
            // ViewBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 473);
            this.Controls.Add(this.addBillBtn);
            this.Controls.Add(this.BillBackBtn);
            this.Controls.Add(this.viewtSearchBtn);
            this.Controls.Add(this.viewSearchtTxt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "ViewBill";
            this.Text = "ViewBill";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button viewtSearchBtn;
        private System.Windows.Forms.TextBox viewSearchtTxt;
        private System.Windows.Forms.Button BillBackBtn;
        private System.Windows.Forms.Button addBillBtn;
    }
}