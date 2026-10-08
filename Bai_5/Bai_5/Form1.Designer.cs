namespace Bai_5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            grpCustomer = new GroupBox();
            lblShipping = new Label();
            cboShipping = new ComboBox();
            txtPhone = new TextBox();
            lblPhone = new Label();
            txtCustomer = new TextBox();
            lblCustomer = new Label();
            dgvOrders = new DataGridView();
            colProductName = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colWeight = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            statusStrip1 = new StatusStrip();
            lblTime = new ToolStripStatusLabel();
            lblQuantity = new ToolStripStatusLabel();
            lblWeight = new ToolStripStatusLabel();
            lblMoney = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            grpCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(0, 47);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(grpCustomer);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvOrders);
            splitContainer1.Size = new Size(1078, 387);
            splitContainer1.SplitterDistance = 358;
            splitContainer1.TabIndex = 0;
            // 
            // grpCustomer
            // 
            grpCustomer.Controls.Add(lblShipping);
            grpCustomer.Controls.Add(cboShipping);
            grpCustomer.Controls.Add(txtPhone);
            grpCustomer.Controls.Add(lblPhone);
            grpCustomer.Controls.Add(txtCustomer);
            grpCustomer.Controls.Add(lblCustomer);
            grpCustomer.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpCustomer.Location = new Point(3, 3);
            grpCustomer.Name = "grpCustomer";
            grpCustomer.Size = new Size(342, 379);
            grpCustomer.TabIndex = 0;
            grpCustomer.TabStop = false;
            grpCustomer.Text = "Thông tin đơn hàng";
            // 
            // lblShipping
            // 
            lblShipping.AutoSize = true;
            lblShipping.Location = new Point(6, 124);
            lblShipping.Name = "lblShipping";
            lblShipping.Size = new Size(120, 20);
            lblShipping.TabIndex = 5;
            lblShipping.Text = "Loại vận chuyển";
            // 
            // cboShipping
            // 
            cboShipping.FormattingEnabled = true;
            cboShipping.Location = new Point(129, 124);
            cboShipping.Name = "cboShipping";
            cboShipping.Size = new Size(207, 28);
            cboShipping.TabIndex = 4;
            cboShipping.SelectedIndexChanged += cboShipping_SelectedIndexChanged;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(129, 78);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(207, 27);
            txtPhone.TabIndex = 3;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(6, 78);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(99, 20);
            lblPhone.TabIndex = 2;
            lblPhone.Text = "Số điện thoại";
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new Point(129, 33);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(207, 27);
            txtCustomer.TabIndex = 1;
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new Point(6, 40);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(117, 20);
            lblCustomer.TabIndex = 0;
            lblCustomer.Text = "Tên khách hàng";
            // 
            // dgvOrders
            // 
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Columns.AddRange(new DataGridViewColumn[] { colProductName, colQuantity, colWeight, colPrice, colTotal });
            dgvOrders.Location = new Point(3, 0);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new Size(680, 382);
            dgvOrders.TabIndex = 0;
            dgvOrders.CellValidating += dgvOrders_CellValidating;
            dgvOrders.CellValueChanged += dgvOrders_CellValueChanged;
            // 
            // colProductName
            // 
            colProductName.HeaderText = "Tên hàng";
            colProductName.MinimumWidth = 6;
            colProductName.Name = "colProductName";
            colProductName.Width = 125;
            // 
            // colQuantity
            // 
            colQuantity.HeaderText = "Số lượng";
            colQuantity.MinimumWidth = 6;
            colQuantity.Name = "colQuantity";
            colQuantity.Width = 125;
            // 
            // colWeight
            // 
            colWeight.HeaderText = "Trọng lượng (kg)";
            colWeight.MinimumWidth = 6;
            colWeight.Name = "colWeight";
            colWeight.Width = 125;
            // 
            // colPrice
            // 
            colPrice.HeaderText = "Đơn giá";
            colPrice.MinimumWidth = 6;
            colPrice.Name = "colPrice";
            colPrice.Width = 125;
            // 
            // colTotal
            // 
            colTotal.HeaderText = "Thành tiền";
            colTotal.MinimumWidth = 6;
            colTotal.Name = "colTotal";
            colTotal.ReadOnly = true;
            colTotal.Width = 125;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblTime, lblQuantity, lblWeight, lblMoney });
            statusStrip1.Location = new Point(0, 433);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1090, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblTime
            // 
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(74, 20);
            lblTime.Text = "Thời gian:";
            // 
            // lblQuantity
            // 
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(120, 20);
            lblQuantity.Text = "Tổng số lượng: 0";
            // 
            // lblWeight
            // 
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(161, 20);
            lblWeight.Text = "Tổng trọng lượng: 0 kg";
            // 
            // lblMoney
            // 
            lblMoney.Name = "lblMoney";
            lblMoney.Size = new Size(122, 20);
            lblMoney.Text = "Tổng tiền: 0 VNĐ";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(296, 9);
            label1.Name = "label1";
            label1.Size = new Size(441, 31);
            label1.TabIndex = 2;
            label1.Text = "Bảng điều khiển Quản lý Đơn giao hàng";
            label1.Click += label1_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 459);
            Controls.Add(label1);
            Controls.Add(statusStrip1);
            Controls.Add(splitContainer1);
            KeyPreview = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            grpCustomer.ResumeLayout(false);
            grpCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SplitContainer splitContainer1;
        private GroupBox grpCustomer;
        private TextBox txtCustomer;
        private Label lblCustomer;
        private Label lblShipping;
        private ComboBox cboShipping;
        private TextBox txtPhone;
        private Label lblPhone;
        private DataGridView dgvOrders;
        private DataGridViewTextBoxColumn colProductName;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewTextBoxColumn colWeight;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colTotal;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblTime;
        private ToolStripStatusLabel lblQuantity;
        private ToolStripStatusLabel lblWeight;
        private ToolStripStatusLabel lblMoney;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private ErrorProvider errorProvider1;
    }
}
