namespace Bai_1
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
            lblUnitPrice = new Label();
            txtUnitPrice = new TextBox();
            lblQuantity = new Label();
            txtQuantity = new TextBox();
            lblDiscount = new Label();
            txtDiscount = new TextBox();
            lblTotal = new Label();
            btnCalculate = new Button();
            btnReset = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Location = new Point(139, 74);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(116, 20);
            lblUnitPrice.TabIndex = 0;
            lblUnitPrice.Text = "Đơn giá dịch vụ:";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(312, 74);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(219, 27);
            txtUnitPrice.TabIndex = 0;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(139, 129);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(114, 20);
            lblQuantity.TabIndex = 2;
            lblQuantity.Text = "Số lượng khách:";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(312, 126);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(219, 27);
            txtQuantity.TabIndex = 1;
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Location = new Point(141, 181);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(122, 20);
            lblDiscount.TabIndex = 4;
            lblDiscount.Text = "Mã giảm giá (%):";
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(312, 178);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(219, 27);
            txtDiscount.TabIndex = 2;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(139, 301);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(122, 20);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "Tổng tiền: 0 VNĐ";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(263, 239);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 29);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "Tính tiền";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(413, 239);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 4;
            btnReset.Text = "Làm mới";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(182, 9);
            label1.Name = "label1";
            label1.Size = new Size(378, 41);
            label1.TabIndex = 9;
            label1.Text = "Service Charge Calculator";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnReset);
            Controls.Add(btnCalculate);
            Controls.Add(lblTotal);
            Controls.Add(txtDiscount);
            Controls.Add(lblDiscount);
            Controls.Add(txtQuantity);
            Controls.Add(lblQuantity);
            Controls.Add(txtUnitPrice);
            Controls.Add(lblUnitPrice);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUnitPrice;
        private TextBox txtUnitPrice;
        private Label lblQuantity;
        private TextBox txtQuantity;
        private Label lblDiscount;
        private TextBox txtDiscount;
        private Label lblTotal;
        private Button btnCalculate;
        private Button btnReset;
        private Label label1;
    }
}
