namespace ABC_Car_Traders
{
    partial class orderCar
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
            this.carImgPB = new System.Windows.Forms.PictureBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.cancelOrderBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.carPriceTxt = new System.Windows.Forms.TextBox();
            this.carYearTxt = new System.Windows.Forms.TextBox();
            this.carModelTxt = new System.Windows.Forms.TextBox();
            this.carMakeTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.carPayBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.carImgPB)).BeginInit();
            this.SuspendLayout();
            // 
            // carImgPB
            // 
            this.carImgPB.Location = new System.Drawing.Point(600, 111);
            this.carImgPB.Name = "carImgPB";
            this.carImgPB.Size = new System.Drawing.Size(240, 205);
            this.carImgPB.TabIndex = 44;
            this.carImgPB.TabStop = false;
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(600, 432);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(194, 29);
            this.backBtn.TabIndex = 41;
            this.backBtn.Text = "BACK";
            this.backBtn.UseVisualStyleBackColor = true;
            // 
            // cancelOrderBtn
            // 
            this.cancelOrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelOrderBtn.Location = new System.Drawing.Point(370, 432);
            this.cancelOrderBtn.Name = "cancelOrderBtn";
            this.cancelOrderBtn.Size = new System.Drawing.Size(194, 29);
            this.cancelOrderBtn.TabIndex = 40;
            this.cancelOrderBtn.Text = "CANCEL";
            this.cancelOrderBtn.UseVisualStyleBackColor = true;
            this.cancelOrderBtn.Click += new System.EventHandler(this.cancelOrderBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 37);
            this.label1.TabIndex = 38;
            this.label1.Text = "Order Car";
            // 
            // carPriceTxt
            // 
            this.carPriceTxt.Location = new System.Drawing.Point(225, 268);
            this.carPriceTxt.Name = "carPriceTxt";
            this.carPriceTxt.Size = new System.Drawing.Size(234, 20);
            this.carPriceTxt.TabIndex = 36;
            // 
            // carYearTxt
            // 
            this.carYearTxt.Location = new System.Drawing.Point(225, 212);
            this.carYearTxt.Name = "carYearTxt";
            this.carYearTxt.Size = new System.Drawing.Size(234, 20);
            this.carYearTxt.TabIndex = 35;
            // 
            // carModelTxt
            // 
            this.carModelTxt.Location = new System.Drawing.Point(225, 162);
            this.carModelTxt.Name = "carModelTxt";
            this.carModelTxt.Size = new System.Drawing.Size(234, 20);
            this.carModelTxt.TabIndex = 34;
            // 
            // carMakeTxt
            // 
            this.carMakeTxt.Location = new System.Drawing.Point(225, 111);
            this.carMakeTxt.Name = "carMakeTxt";
            this.carMakeTxt.Size = new System.Drawing.Size(234, 20);
            this.carMakeTxt.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(59, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Car Model";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Car Make";
            // 
            // carPayBtn
            // 
            this.carPayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carPayBtn.Location = new System.Drawing.Point(141, 432);
            this.carPayBtn.Name = "carPayBtn";
            this.carPayBtn.Size = new System.Drawing.Size(194, 29);
            this.carPayBtn.TabIndex = 39;
            this.carPayBtn.Text = "PAY";
            this.carPayBtn.UseVisualStyleBackColor = true;
            this.carPayBtn.Click += new System.EventHandler(this.carPayBtn_Click);
            // 
            // orderCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 474);
            this.Controls.Add(this.carImgPB);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.cancelOrderBtn);
            this.Controls.Add(this.carPayBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.carPriceTxt);
            this.Controls.Add(this.carYearTxt);
            this.Controls.Add(this.carModelTxt);
            this.Controls.Add(this.carMakeTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "orderCar";
            this.Text = "orderCar";
            this.Load += new System.EventHandler(this.orderCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carImgPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox carImgPB;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button cancelOrderBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox carPriceTxt;
        private System.Windows.Forms.TextBox carYearTxt;
        private System.Windows.Forms.TextBox carModelTxt;
        private System.Windows.Forms.TextBox carMakeTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button carPayBtn;
    }
}