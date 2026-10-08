namespace Bai_4
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
            tableLayoutPanel1 = new TableLayoutPanel();
            lblSelected = new Label();
            lblTotal = new Label();
            cboTime = new ComboBox();
            btnConfirm = new Button();
            btnCancel = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.58621F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.41379F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 139F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 143F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            tableLayoutPanel1.Location = new Point(31, 49);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 52.9411774F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 47.0588226F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanel1.Size = new Size(713, 234);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblSelected
            // 
            lblSelected.AutoSize = true;
            lblSelected.Location = new Point(20, 286);
            lblSelected.Name = "lblSelected";
            lblSelected.Size = new Size(148, 20);
            lblSelected.TabIndex = 0;
            lblSelected.Text = "Số vị trí đang chọn: 0";
            lblSelected.Click += lblSelected_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(22, 320);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(146, 20);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "Tạm tính tiền: 0 VNĐ";
            // 
            // cboTime
            // 
            cboTime.FormattingEnabled = true;
            cboTime.Location = new Point(19, 358);
            cboTime.Name = "cboTime";
            cboTime.Size = new Size(151, 28);
            cboTime.TabIndex = 2;
            cboTime.SelectedIndexChanged += cboTime_SelectedIndexChanged;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(159, 392);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(140, 29);
            btnConfirm.TabIndex = 3;
            btnConfirm.Text = "Xác nhận đặt";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(346, 392);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(140, 29);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Hủy chọn tất ";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(93, -2);
            label1.Name = "label1";
            label1.Size = new Size(597, 38);
            label1.TabIndex = 5;
            label1.Text = "Sơ đồ chọn vị trí chỗ ngồi / Đặt bàn hẹn giờ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 450);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(cboTime);
            Controls.Add(lblTotal);
            Controls.Add(lblSelected);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblSelected;
        private Label lblTotal;
        private ComboBox cboTime;
        private Button btnConfirm;
        private Button btnCancel;
        private Label label1;
    }
}
