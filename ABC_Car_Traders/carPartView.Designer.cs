namespace ABC_Car_Traders
{
    partial class carPartView
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
            this.carPartSearchBtn = new System.Windows.Forms.Button();
            this.carPartSearchtTxt = new System.Windows.Forms.TextBox();
            this.carPartDGV = new System.Windows.Forms.DataGridView();
            this.carPartAddBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.carPartDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(680, 459);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(125, 23);
            this.backBtn.TabIndex = 7;
            this.backBtn.Text = "BACK";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // carPartSearchBtn
            // 
            this.carPartSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carPartSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carPartSearchBtn.Location = new System.Drawing.Point(751, 27);
            this.carPartSearchBtn.Name = "carPartSearchBtn";
            this.carPartSearchBtn.Size = new System.Drawing.Size(125, 23);
            this.carPartSearchBtn.TabIndex = 6;
            this.carPartSearchBtn.Text = "SEARCH";
            this.carPartSearchBtn.UseVisualStyleBackColor = true;
            // 
            // carPartSearchtTxt
            // 
            this.carPartSearchtTxt.Location = new System.Drawing.Point(478, 29);
            this.carPartSearchtTxt.Name = "carPartSearchtTxt";
            this.carPartSearchtTxt.Size = new System.Drawing.Size(231, 20);
            this.carPartSearchtTxt.TabIndex = 5;
            // 
            // carPartDGV
            // 
            this.carPartDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carPartDGV.Location = new System.Drawing.Point(26, 67);
            this.carPartDGV.Name = "carPartDGV";
            this.carPartDGV.Size = new System.Drawing.Size(800, 346);
            this.carPartDGV.TabIndex = 4;
            this.carPartDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.carPartDGV_CellContentClick);
            // 
            // carPartAddBtn
            // 
            this.carPartAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carPartAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carPartAddBtn.Location = new System.Drawing.Point(396, 459);
            this.carPartAddBtn.Name = "carPartAddBtn";
            this.carPartAddBtn.Size = new System.Drawing.Size(215, 23);
            this.carPartAddBtn.TabIndex = 8;
            this.carPartAddBtn.Text = "ADD";
            this.carPartAddBtn.UseVisualStyleBackColor = true;
            this.carPartAddBtn.Click += new System.EventHandler(this.carPartAddBtn_Click);
            // 
            // carPartView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(902, 509);
            this.Controls.Add(this.carPartAddBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.carPartSearchBtn);
            this.Controls.Add(this.carPartSearchtTxt);
            this.Controls.Add(this.carPartDGV);
            this.Name = "carPartView";
            this.Text = "carPartView";
            this.Load += new System.EventHandler(this.carPartView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carPartDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button carPartSearchBtn;
        private System.Windows.Forms.TextBox carPartSearchtTxt;
        private System.Windows.Forms.DataGridView carPartDGV;
        private System.Windows.Forms.Button carPartAddBtn;
    }
}