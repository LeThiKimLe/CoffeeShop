
namespace project
{
    partial class PaymentForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.totalTxt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.payMethodTxt = new System.Windows.Forms.TextBox();
            this.paymentBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thanh toán đơn hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số tiền";
            // 
            // totalTxt
            // 
            this.totalTxt.AutoSize = true;
            this.totalTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTxt.Location = new System.Drawing.Point(128, 59);
            this.totalTxt.Name = "totalTxt";
            this.totalTxt.Size = new System.Drawing.Size(68, 24);
            this.totalTxt.TabIndex = 2;
            this.totalTxt.Text = "Số tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhập PT Thanh toán";
            // 
            // payMethodTxt
            // 
            this.payMethodTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payMethodTxt.Location = new System.Drawing.Point(222, 92);
            this.payMethodTxt.Name = "payMethodTxt";
            this.payMethodTxt.Size = new System.Drawing.Size(153, 27);
            this.payMethodTxt.TabIndex = 4;
            // 
            // paymentBtn
            // 
            this.paymentBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.paymentBtn.Location = new System.Drawing.Point(318, 139);
            this.paymentBtn.Name = "paymentBtn";
            this.paymentBtn.Size = new System.Drawing.Size(149, 31);
            this.paymentBtn.TabIndex = 5;
            this.paymentBtn.Text = "Thanh toán";
            this.paymentBtn.UseVisualStyleBackColor = false;
            this.paymentBtn.Click += new System.EventHandler(this.paymentBtn_Click);
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 182);
            this.Controls.Add(this.paymentBtn);
            this.Controls.Add(this.payMethodTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.totalTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox payMethodTxt;
        private System.Windows.Forms.Button paymentBtn;
    }
}