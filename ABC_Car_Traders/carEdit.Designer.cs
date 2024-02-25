namespace ABC_Car_Traders
{
    partial class carEdit
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
            this.carQuantityTxt = new System.Windows.Forms.TextBox();
            this.carPriceTxt = new System.Windows.Forms.TextBox();
            this.carYearTxt = new System.Windows.Forms.TextBox();
            this.carModelTxt = new System.Windows.Forms.TextBox();
            this.carMakeTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.carIdTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.carImgPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.carImgPB)).BeginInit();
            this.SuspendLayout();
            // 
            // carQuantityTxt
            // 
            this.carQuantityTxt.Location = new System.Drawing.Point(251, 366);
            this.carQuantityTxt.Name = "carQuantityTxt";
            this.carQuantityTxt.Size = new System.Drawing.Size(234, 20);
            this.carQuantityTxt.TabIndex = 20;
            // 
            // carPriceTxt
            // 
            this.carPriceTxt.Location = new System.Drawing.Point(251, 305);
            this.carPriceTxt.Name = "carPriceTxt";
            this.carPriceTxt.Size = new System.Drawing.Size(234, 20);
            this.carPriceTxt.TabIndex = 19;
            // 
            // carYearTxt
            // 
            this.carYearTxt.Location = new System.Drawing.Point(251, 249);
            this.carYearTxt.Name = "carYearTxt";
            this.carYearTxt.Size = new System.Drawing.Size(234, 20);
            this.carYearTxt.TabIndex = 18;
            // 
            // carModelTxt
            // 
            this.carModelTxt.Location = new System.Drawing.Point(251, 199);
            this.carModelTxt.Name = "carModelTxt";
            this.carModelTxt.Size = new System.Drawing.Size(234, 20);
            this.carModelTxt.TabIndex = 17;
            // 
            // carMakeTxt
            // 
            this.carMakeTxt.Location = new System.Drawing.Point(251, 149);
            this.carMakeTxt.Name = "carMakeTxt";
            this.carMakeTxt.Size = new System.Drawing.Size(234, 20);
            this.carMakeTxt.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(85, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Car Model";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(85, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Car Make";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 37);
            this.label1.TabIndex = 21;
            this.label1.Text = "Car Edit Form";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // backBtn
            // 
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(626, 441);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(194, 29);
            this.backBtn.TabIndex = 24;
            this.backBtn.Text = "BACK";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(396, 441);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(194, 29);
            this.deleteBtn.TabIndex = 23;
            this.deleteBtn.Text = "DELETE";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(167, 441);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(194, 29);
            this.updateBtn.TabIndex = 22;
            this.updateBtn.Text = "UPDATE";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // carIdTxt
            // 
            this.carIdTxt.Location = new System.Drawing.Point(251, 94);
            this.carIdTxt.Name = "carIdTxt";
            this.carIdTxt.Size = new System.Drawing.Size(234, 20);
            this.carIdTxt.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(85, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Car ID";
            // 
            // carImgPB
            // 
            this.carImgPB.Location = new System.Drawing.Point(626, 120);
            this.carImgPB.Name = "carImgPB";
            this.carImgPB.Size = new System.Drawing.Size(240, 205);
            this.carImgPB.TabIndex = 27;
            this.carImgPB.TabStop = false;
            // 
            // carEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(897, 511);
            this.Controls.Add(this.carImgPB);
            this.Controls.Add(this.carIdTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.carQuantityTxt);
            this.Controls.Add(this.carPriceTxt);
            this.Controls.Add(this.carYearTxt);
            this.Controls.Add(this.carModelTxt);
            this.Controls.Add(this.carMakeTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "carEdit";
            this.Text = "carEdit";
            this.Load += new System.EventHandler(this.carEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carImgPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox carQuantityTxt;
        private System.Windows.Forms.TextBox carPriceTxt;
        private System.Windows.Forms.TextBox carYearTxt;
        private System.Windows.Forms.TextBox carModelTxt;
        private System.Windows.Forms.TextBox carMakeTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.TextBox carIdTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox carImgPB;
    }
}