namespace ABC_Car_Traders
{
    partial class carPartManagement
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
            this.carPartEdit = new System.Windows.Forms.Button();
            this.carPartView = new System.Windows.Forms.Button();
            this.carPartAdd = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // carPartEdit
            // 
            this.carPartEdit.Location = new System.Drawing.Point(81, 224);
            this.carPartEdit.Name = "carPartEdit";
            this.carPartEdit.Size = new System.Drawing.Size(150, 60);
            this.carPartEdit.TabIndex = 5;
            this.carPartEdit.Text = "Edit";
            this.carPartEdit.UseVisualStyleBackColor = true;
            this.carPartEdit.Click += new System.EventHandler(this.carPartEdit_Click);
            // 
            // carPartView
            // 
            this.carPartView.Location = new System.Drawing.Point(81, 375);
            this.carPartView.Name = "carPartView";
            this.carPartView.Size = new System.Drawing.Size(150, 60);
            this.carPartView.TabIndex = 4;
            this.carPartView.Text = "View";
            this.carPartView.UseVisualStyleBackColor = true;
            this.carPartView.Click += new System.EventHandler(this.carPartView_Click);
            // 
            // carPartAdd
            // 
            this.carPartAdd.Location = new System.Drawing.Point(81, 85);
            this.carPartAdd.Name = "carPartAdd";
            this.carPartAdd.Size = new System.Drawing.Size(150, 60);
            this.carPartAdd.TabIndex = 3;
            this.carPartAdd.Text = "Add ";
            this.carPartAdd.UseVisualStyleBackColor = true;
            this.carPartAdd.Click += new System.EventHandler(this.carPartAdd_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(635, 462);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(234, 31);
            this.backBtn.TabIndex = 6;
            this.backBtn.Text = "BACK";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // carPartManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 505);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.carPartEdit);
            this.Controls.Add(this.carPartView);
            this.Controls.Add(this.carPartAdd);
            this.Name = "carPartManagement";
            this.Text = "carPartManagement";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button carPartEdit;
        private System.Windows.Forms.Button carPartView;
        private System.Windows.Forms.Button carPartAdd;
        private System.Windows.Forms.Button backBtn;
    }
}