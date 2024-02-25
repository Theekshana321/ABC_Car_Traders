namespace ABC_Car_Traders
{
    partial class viewReport
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
            this.btnRepVback = new System.Windows.Forms.Button();
            this.addRepBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 31);
            this.label1.TabIndex = 180;
            this.label1.Text = "View Report Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(875, 275);
            this.dataGridView1.TabIndex = 181;
            // 
            // btnRepVback
            // 
            this.btnRepVback.BackColor = System.Drawing.Color.Transparent;
            this.btnRepVback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRepVback.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepVback.Location = new System.Drawing.Point(712, 395);
            this.btnRepVback.Margin = new System.Windows.Forms.Padding(4);
            this.btnRepVback.Name = "btnRepVback";
            this.btnRepVback.Size = new System.Drawing.Size(146, 39);
            this.btnRepVback.TabIndex = 182;
            this.btnRepVback.Text = "Back";
            this.btnRepVback.UseVisualStyleBackColor = false;
            this.btnRepVback.Click += new System.EventHandler(this.btnRepVback_Click);
            // 
            // addRepBtn
            // 
            this.addRepBtn.BackColor = System.Drawing.Color.Transparent;
            this.addRepBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addRepBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRepBtn.Location = new System.Drawing.Point(511, 395);
            this.addRepBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addRepBtn.Name = "addRepBtn";
            this.addRepBtn.Size = new System.Drawing.Size(146, 39);
            this.addRepBtn.TabIndex = 183;
            this.addRepBtn.Text = "ADD";
            this.addRepBtn.UseVisualStyleBackColor = false;
            this.addRepBtn.Click += new System.EventHandler(this.addRepBtn_Click);
            // 
            // viewReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 472);
            this.Controls.Add(this.addRepBtn);
            this.Controls.Add(this.btnRepVback);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "viewReport";
            this.Text = "viewReport";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRepVback;
        private System.Windows.Forms.Button addRepBtn;
    }
}