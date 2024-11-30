
namespace project
{
    partial class OrderForm
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
            this.orderView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sumTxt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.itemDesc = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.paymentBtn = new System.Windows.Forms.Button();
            this.paidLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderView
            // 
            this.orderView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.date,
            this.total,
            this.state,
            this.payment});
            this.orderView.Location = new System.Drawing.Point(41, 67);
            this.orderView.Name = "orderView";
            this.orderView.RowHeadersWidth = 51;
            this.orderView.RowTemplate.Height = 24;
            this.orderView.Size = new System.Drawing.Size(869, 222);
            this.orderView.TabIndex = 0;
            this.orderView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đơn hàng của bạn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.paidLabel);
            this.groupBox1.Controls.Add(this.paymentBtn);
            this.groupBox1.Controls.Add(this.cancelBtn);
            this.groupBox1.Controls.Add(this.sumTxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.itemDesc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(41, 295);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(869, 127);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết đơn";
            // 
            // sumTxt
            // 
            this.sumTxt.AutoSize = true;
            this.sumTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumTxt.ForeColor = System.Drawing.Color.Red;
            this.sumTxt.Location = new System.Drawing.Point(727, 34);
            this.sumTxt.Name = "sumTxt";
            this.sumTxt.Size = new System.Drawing.Size(96, 20);
            this.sumTxt.TabIndex = 5;
            this.sumTxt.Text = "Tổng cộng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(545, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tổng cộng";
            // 
            // itemDesc
            // 
            this.itemDesc.AutoSize = true;
            this.itemDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemDesc.Location = new System.Drawing.Point(52, 34);
            this.itemDesc.Name = "itemDesc";
            this.itemDesc.Size = new System.Drawing.Size(128, 18);
            this.itemDesc.TabIndex = 3;
            this.itemDesc.Text = "Đơn hàng của bạn";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "STT";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Thời gian";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.Width = 125;
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            this.total.HeaderText = "Tổng tiền";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.Width = 125;
            // 
            // state
            // 
            this.state.DataPropertyName = "state";
            this.state.HeaderText = "Trạng thái";
            this.state.MinimumWidth = 6;
            this.state.Name = "state";
            this.state.Width = 125;
            // 
            // payment
            // 
            this.payment.DataPropertyName = "payment";
            this.payment.HeaderText = "PT Thanh toán";
            this.payment.MinimumWidth = 6;
            this.payment.Name = "payment";
            this.payment.Width = 125;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.MistyRose;
            this.cancelBtn.ForeColor = System.Drawing.Color.Black;
            this.cancelBtn.Location = new System.Drawing.Point(724, 68);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(120, 53);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Hủy đơn";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Visible = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // paymentBtn
            // 
            this.paymentBtn.BackColor = System.Drawing.Color.GreenYellow;
            this.paymentBtn.ForeColor = System.Drawing.Color.Black;
            this.paymentBtn.Location = new System.Drawing.Point(548, 68);
            this.paymentBtn.Name = "paymentBtn";
            this.paymentBtn.Size = new System.Drawing.Size(166, 53);
            this.paymentBtn.TabIndex = 7;
            this.paymentBtn.Text = "Thanh toán";
            this.paymentBtn.UseVisualStyleBackColor = false;
            this.paymentBtn.Visible = false;
            this.paymentBtn.Click += new System.EventHandler(this.paymentBtn_Click);
            // 
            // paidLabel
            // 
            this.paidLabel.AutoSize = true;
            this.paidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paidLabel.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.paidLabel.Location = new System.Drawing.Point(720, 68);
            this.paidLabel.Name = "paidLabel";
            this.paidLabel.Size = new System.Drawing.Size(126, 24);
            this.paidLabel.TabIndex = 8;
            this.paidLabel.Text = "Đã thanh toán";
            this.paidLabel.Visible = false;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderView);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView orderView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label sumTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label itemDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.DataGridViewTextBoxColumn payment;
        private System.Windows.Forms.Button paymentBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label paidLabel;
    }
}