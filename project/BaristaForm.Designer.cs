
namespace project
{
    partial class BaristaForm
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
            this.coffeeView = new System.Windows.Forms.DataGridView();
            this.orderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reloadBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.coffeeReceipt = new System.Windows.Forms.Label();
            this.coffeeAmount = new System.Windows.Forms.Label();
            this.coffeeName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.storeView = new System.Windows.Forms.DataGridView();
            this.makeCoffeeBtn = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storeView)).BeginInit();
            this.SuspendLayout();
            // 
            // coffeeView
            // 
            this.coffeeView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coffeeView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderId,
            this.name,
            this.amount,
            this.state});
            this.coffeeView.Location = new System.Drawing.Point(35, 66);
            this.coffeeView.Name = "coffeeView";
            this.coffeeView.RowHeadersWidth = 51;
            this.coffeeView.RowTemplate.Height = 24;
            this.coffeeView.Size = new System.Drawing.Size(559, 317);
            this.coffeeView.TabIndex = 0;
            this.coffeeView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.coffeeView_CellClick);
            this.coffeeView.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.coffeeView_RowPrePaint);
            // 
            // orderId
            // 
            this.orderId.DataPropertyName = "orderId";
            this.orderId.HeaderText = "Mã đơn";
            this.orderId.MinimumWidth = 6;
            this.orderId.Name = "orderId";
            this.orderId.Width = 125;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Món";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 125;
            // 
            // amount
            // 
            this.amount.DataPropertyName = "amount";
            this.amount.HeaderText = "Số lượng";
            this.amount.MinimumWidth = 6;
            this.amount.Name = "amount";
            this.amount.Width = 125;
            // 
            // state
            // 
            this.state.DataPropertyName = "state";
            this.state.HeaderText = "Trạng thái";
            this.state.MinimumWidth = 6;
            this.state.Name = "state";
            this.state.Width = 125;
            // 
            // reloadBtn
            // 
            this.reloadBtn.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.reloadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reloadBtn.Location = new System.Drawing.Point(35, 398);
            this.reloadBtn.Name = "reloadBtn";
            this.reloadBtn.Size = new System.Drawing.Size(110, 35);
            this.reloadBtn.TabIndex = 1;
            this.reloadBtn.Text = "Reload";
            this.reloadBtn.UseVisualStyleBackColor = false;
            this.reloadBtn.Click += new System.EventHandler(this.reloadBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đơn cần làm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.coffeeReceipt);
            this.groupBox1.Controls.Add(this.coffeeAmount);
            this.groupBox1.Controls.Add(this.coffeeName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(614, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 145);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin món";
            // 
            // coffeeReceipt
            // 
            this.coffeeReceipt.AutoSize = true;
            this.coffeeReceipt.Location = new System.Drawing.Point(127, 109);
            this.coffeeReceipt.Name = "coffeeReceipt";
            this.coffeeReceipt.Size = new System.Drawing.Size(90, 20);
            this.coffeeReceipt.TabIndex = 5;
            this.coffeeReceipt.Text = "Công thức:";
            // 
            // coffeeAmount
            // 
            this.coffeeAmount.AutoSize = true;
            this.coffeeAmount.Location = new System.Drawing.Point(127, 71);
            this.coffeeAmount.Name = "coffeeAmount";
            this.coffeeAmount.Size = new System.Drawing.Size(79, 20);
            this.coffeeAmount.TabIndex = 4;
            this.coffeeAmount.Text = "Số lượng:";
            // 
            // coffeeName
            // 
            this.coffeeName.AutoSize = true;
            this.coffeeName.Location = new System.Drawing.Point(125, 36);
            this.coffeeName.Name = "coffeeName";
            this.coffeeName.Size = new System.Drawing.Size(42, 20);
            this.coffeeName.TabIndex = 3;
            this.coffeeName.Text = "Tên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Công thức:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số lượng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.storeView);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(614, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(587, 166);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kho nguyên liệu";
            // 
            // storeView
            // 
            this.storeView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storeView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.material,
            this.stock,
            this.unit});
            this.storeView.Location = new System.Drawing.Point(6, 26);
            this.storeView.Name = "storeView";
            this.storeView.RowHeadersWidth = 51;
            this.storeView.RowTemplate.Height = 24;
            this.storeView.Size = new System.Drawing.Size(572, 134);
            this.storeView.TabIndex = 0;
            // 
            // makeCoffeeBtn
            // 
            this.makeCoffeeBtn.BackColor = System.Drawing.Color.YellowGreen;
            this.makeCoffeeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeCoffeeBtn.Location = new System.Drawing.Point(1082, 398);
            this.makeCoffeeBtn.Name = "makeCoffeeBtn";
            this.makeCoffeeBtn.Size = new System.Drawing.Size(110, 35);
            this.makeCoffeeBtn.TabIndex = 5;
            this.makeCoffeeBtn.Text = "Pha chế";
            this.makeCoffeeBtn.UseVisualStyleBackColor = false;
            this.makeCoffeeBtn.Click += new System.EventHandler(this.makeCoffeeBtn_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Mã NL";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // material
            // 
            this.material.DataPropertyName = "name";
            this.material.HeaderText = "Nguyên liệu";
            this.material.MinimumWidth = 6;
            this.material.Name = "material";
            this.material.Width = 125;
            // 
            // stock
            // 
            this.stock.DataPropertyName = "count";
            this.stock.HeaderText = "Số lượng";
            this.stock.MinimumWidth = 6;
            this.stock.Name = "stock";
            this.stock.Width = 125;
            // 
            // unit
            // 
            this.unit.DataPropertyName = "unit";
            this.unit.HeaderText = "Đơn vị";
            this.unit.MinimumWidth = 6;
            this.unit.Name = "unit";
            this.unit.Width = 125;
            // 
            // BaristaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 464);
            this.Controls.Add(this.makeCoffeeBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reloadBtn);
            this.Controls.Add(this.coffeeView);
            this.Name = "BaristaForm";
            this.Text = "BaristaForm";
            ((System.ComponentModel.ISupportInitialize)(this.coffeeView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.storeView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView coffeeView;
        private System.Windows.Forms.Button reloadBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView storeView;
        private System.Windows.Forms.Button makeCoffeeBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.Label coffeeReceipt;
        private System.Windows.Forms.Label coffeeAmount;
        private System.Windows.Forms.Label coffeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn material;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
    }
}