namespace ABC_Car_Traders
{
    partial class carView
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
            this.carDataGrid = new System.Windows.Forms.DataGridView();
            this.searchbarcartxt = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.addCarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.carDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // carDataGrid
            // 
            this.carDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carDataGrid.Location = new System.Drawing.Point(33, 62);
            this.carDataGrid.Name = "carDataGrid";
            this.carDataGrid.Size = new System.Drawing.Size(800, 346);
            this.carDataGrid.TabIndex = 0;
            this.carDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.carDataGrid_CellContentClick);
            // 
            // searchbarcartxt
            // 
            this.searchbarcartxt.Location = new System.Drawing.Point(485, 24);
            this.searchbarcartxt.Name = "searchbarcartxt";
            this.searchbarcartxt.Size = new System.Drawing.Size(231, 20);
            this.searchbarcartxt.TabIndex = 1;
            // 
            // searchBtn
            // 
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(758, 22);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(127, 22);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "SEARCH";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(708, 445);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(125, 23);
            this.backBtn.TabIndex = 3;
            this.backBtn.Text = "BACK";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // addCarBtn
            // 
            this.addCarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCarBtn.Location = new System.Drawing.Point(309, 445);
            this.addCarBtn.Name = "addCarBtn";
            this.addCarBtn.Size = new System.Drawing.Size(242, 23);
            this.addCarBtn.TabIndex = 4;
            this.addCarBtn.Text = "ADD";
            this.addCarBtn.UseVisualStyleBackColor = true;
            this.addCarBtn.Click += new System.EventHandler(this.addCarBtn_Click);
            // 
            // carView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(927, 505);
            this.Controls.Add(this.addCarBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchbarcartxt);
            this.Controls.Add(this.carDataGrid);
            this.Name = "carView";
            this.Text = "carView";
            this.Load += new System.EventHandler(this.carView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView carDataGrid;
        private System.Windows.Forms.TextBox searchbarcartxt;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button addCarBtn;
    }
}