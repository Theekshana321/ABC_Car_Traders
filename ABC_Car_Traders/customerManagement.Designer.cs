namespace ABC_Car_Traders
{
    partial class customerManagement
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
            this.editCustomerBtn = new System.Windows.Forms.Button();
            this.viewCustomerBtn = new System.Windows.Forms.Button();
            this.registerCustomerBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // editCustomerBtn
            // 
            this.editCustomerBtn.Location = new System.Drawing.Point(84, 211);
            this.editCustomerBtn.Name = "editCustomerBtn";
            this.editCustomerBtn.Size = new System.Drawing.Size(150, 60);
            this.editCustomerBtn.TabIndex = 5;
            this.editCustomerBtn.Text = "EDIT";
            this.editCustomerBtn.UseVisualStyleBackColor = true;
            this.editCustomerBtn.Click += new System.EventHandler(this.editCustomerBtn_Click);
            // 
            // viewCustomerBtn
            // 
            this.viewCustomerBtn.Location = new System.Drawing.Point(84, 362);
            this.viewCustomerBtn.Name = "viewCustomerBtn";
            this.viewCustomerBtn.Size = new System.Drawing.Size(150, 60);
            this.viewCustomerBtn.TabIndex = 4;
            this.viewCustomerBtn.Text = "VIEW";
            this.viewCustomerBtn.UseVisualStyleBackColor = true;
            this.viewCustomerBtn.Click += new System.EventHandler(this.viewCustomerBtn_Click);
            // 
            // registerCustomerBtn
            // 
            this.registerCustomerBtn.Location = new System.Drawing.Point(84, 72);
            this.registerCustomerBtn.Name = "registerCustomerBtn";
            this.registerCustomerBtn.Size = new System.Drawing.Size(150, 60);
            this.registerCustomerBtn.TabIndex = 3;
            this.registerCustomerBtn.Text = "REGISTER";
            this.registerCustomerBtn.UseVisualStyleBackColor = true;
            this.registerCustomerBtn.Click += new System.EventHandler(this.registerCustomerBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(654, 461);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(234, 31);
            this.backBtn.TabIndex = 7;
            this.backBtn.Text = "BACK";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // customerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 504);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.editCustomerBtn);
            this.Controls.Add(this.viewCustomerBtn);
            this.Controls.Add(this.registerCustomerBtn);
            this.Name = "customerManagement";
            this.Text = "customerManagement";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button editCustomerBtn;
        private System.Windows.Forms.Button viewCustomerBtn;
        private System.Windows.Forms.Button registerCustomerBtn;
        private System.Windows.Forms.Button backBtn;
    }
}