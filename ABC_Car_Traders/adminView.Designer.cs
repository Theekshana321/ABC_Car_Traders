namespace ABC_Car_Traders
{
    partial class adminView
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
            this.btnAVback = new System.Windows.Forms.Button();
            this.adminDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.adminDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAVback
            // 
            this.btnAVback.BackColor = System.Drawing.Color.Transparent;
            this.btnAVback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAVback.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAVback.Location = new System.Drawing.Point(373, 434);
            this.btnAVback.Margin = new System.Windows.Forms.Padding(4);
            this.btnAVback.Name = "btnAVback";
            this.btnAVback.Size = new System.Drawing.Size(146, 39);
            this.btnAVback.TabIndex = 29;
            this.btnAVback.Text = "Back";
            this.btnAVback.UseVisualStyleBackColor = false;
            // 
            // adminDataGrid
            // 
            this.adminDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminDataGrid.Location = new System.Drawing.Point(214, 113);
            this.adminDataGrid.Name = "adminDataGrid";
            this.adminDataGrid.Size = new System.Drawing.Size(496, 300);
            this.adminDataGrid.TabIndex = 28;
            this.adminDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.adminDataGrid_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 55);
            this.label1.TabIndex = 27;
            this.label1.Text = "Admin Details";
            // 
            // adminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(925, 510);
            this.Controls.Add(this.btnAVback);
            this.Controls.Add(this.adminDataGrid);
            this.Controls.Add(this.label1);
            this.Name = "adminView";
            this.Text = "adminView";
            this.Load += new System.EventHandler(this.adminView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAVback;
        private System.Windows.Forms.DataGridView adminDataGrid;
        private System.Windows.Forms.Label label1;
    }
}