
namespace project
{
    partial class CustomerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuTableAdapter1 = new project.CafeManagementDataSetTableAdapters.MenuTableAdapter();
            this.menuTableAdapter2 = new project.CafeManagementDataSetTableAdapters.MenuTableAdapter();
            this.menu = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.choose = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.currentOrder = new System.Windows.Forms.GroupBox();
            this.orderDesc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalTxt = new System.Windows.Forms.Label();
            this.orderBtn = new System.Windows.Forms.Button();
            this.viewOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).BeginInit();
            this.currentOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuTableAdapter1
            // 
            this.menuTableAdapter1.ClearBeforeFill = true;
            // 
            // menuTableAdapter2
            // 
            this.menuTableAdapter2.ClearBeforeFill = true;
            // 
            // menu
            // 
            this.menu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.price,
            this.choose});
            this.menu.Location = new System.Drawing.Point(38, 74);
            this.menu.Name = "menu";
            this.menu.RowHeadersWidth = 51;
            this.menu.RowTemplate.Height = 24;
            this.menu.Size = new System.Drawing.Size(321, 349);
            this.menu.TabIndex = 0;
            this.menu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.menu_CellClick);
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Món";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 64;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Giá";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.price.Width = 59;
            // 
            // choose
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.choose.DefaultCellStyle = dataGridViewCellStyle2;
            this.choose.HeaderText = "Chọn";
            this.choose.MinimumWidth = 6;
            this.choose.Name = "choose";
            this.choose.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.choose.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.choose.Text = "Chọn";
            this.choose.ToolTipText = "Chọn món";
            this.choose.UseColumnTextForButtonValue = true;
            this.choose.Width = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "MENU";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // currentOrder
            // 
            this.currentOrder.Controls.Add(this.orderDesc);
            this.currentOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentOrder.Location = new System.Drawing.Point(421, 71);
            this.currentOrder.Name = "currentOrder";
            this.currentOrder.Size = new System.Drawing.Size(343, 204);
            this.currentOrder.TabIndex = 3;
            this.currentOrder.TabStop = false;
            this.currentOrder.Text = "Đơn hàng của bạn";
            // 
            // orderDesc
            // 
            this.orderDesc.AutoSize = true;
            this.orderDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDesc.Location = new System.Drawing.Point(23, 43);
            this.orderDesc.Name = "orderDesc";
            this.orderDesc.Size = new System.Drawing.Size(41, 20);
            this.orderDesc.TabIndex = 7;
            this.orderDesc.Text = "Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(417, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tổng cộng: ";
            // 
            // totalTxt
            // 
            this.totalTxt.AutoSize = true;
            this.totalTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTxt.Location = new System.Drawing.Point(658, 295);
            this.totalTxt.Name = "totalTxt";
            this.totalTxt.Size = new System.Drawing.Size(35, 20);
            this.totalTxt.TabIndex = 5;
            this.totalTxt.Text = "0 đ";
            // 
            // orderBtn
            // 
            this.orderBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderBtn.BackColor = System.Drawing.Color.Chartreuse;
            this.orderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.orderBtn.Location = new System.Drawing.Point(659, 320);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(105, 38);
            this.orderBtn.TabIndex = 6;
            this.orderBtn.Text = "Đặt hàng";
            this.orderBtn.UseVisualStyleBackColor = false;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // viewOrder
            // 
            this.viewOrder.BackColor = System.Drawing.SystemColors.Info;
            this.viewOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewOrder.Location = new System.Drawing.Point(421, 383);
            this.viewOrder.Name = "viewOrder";
            this.viewOrder.Size = new System.Drawing.Size(343, 40);
            this.viewOrder.TabIndex = 7;
            this.viewOrder.Text = "Xem đơn hàng";
            this.viewOrder.UseVisualStyleBackColor = false;
            this.viewOrder.Click += new System.EventHandler(this.viewOrder_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewOrder);
            this.Controls.Add(this.orderBtn);
            this.Controls.Add(this.totalTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.currentOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            ((System.ComponentModel.ISupportInitialize)(this.menu)).EndInit();
            this.currentOrder.ResumeLayout(false);
            this.currentOrder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CafeManagementDataSetTableAdapters.MenuTableAdapter menuTableAdapter1;
        private CafeManagementDataSetTableAdapters.MenuTableAdapter menuTableAdapter2;
        private System.Windows.Forms.DataGridView menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewButtonColumn choose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox currentOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalTxt;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.Label orderDesc;
        private System.Windows.Forms.Button viewOrder;
    }
}