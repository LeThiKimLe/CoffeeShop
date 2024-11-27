
namespace project
{
    partial class QuantityDialog
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
            this.coffee = new System.Windows.Forms.Label();
            this.quantityTxt = new System.Windows.Forms.TextBox();
            this.quantityLb = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // coffee
            // 
            this.coffee.AutoSize = true;
            this.coffee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coffee.Location = new System.Drawing.Point(21, 18);
            this.coffee.Name = "coffee";
            this.coffee.Size = new System.Drawing.Size(126, 20);
            this.coffee.TabIndex = 1;
            this.coffee.Text = "Bạn đã chọn: ";
            // 
            // quantityTxt
            // 
            this.quantityTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTxt.Location = new System.Drawing.Point(141, 58);
            this.quantityTxt.Name = "quantityTxt";
            this.quantityTxt.Size = new System.Drawing.Size(201, 28);
            this.quantityTxt.TabIndex = 2;
            // 
            // quantityLb
            // 
            this.quantityLb.AutoSize = true;
            this.quantityLb.Location = new System.Drawing.Point(23, 63);
            this.quantityLb.Name = "quantityLb";
            this.quantityLb.Size = new System.Drawing.Size(100, 17);
            this.quantityLb.TabIndex = 3;
            this.quantityLb.Text = "Nhập số lượng";
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.saveBtn.Location = new System.Drawing.Point(329, 96);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 32);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "OK";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // QuantityDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 136);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.quantityLb);
            this.Controls.Add(this.quantityTxt);
            this.Controls.Add(this.coffee);
            this.Name = "QuantityDialog";
            this.Text = "QuantityDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label coffee;
        private System.Windows.Forms.TextBox quantityTxt;
        private System.Windows.Forms.Label quantityLb;
        private System.Windows.Forms.Button saveBtn;
    }
}