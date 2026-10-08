namespace Bai_2
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
            lblTicketId = new Label();
            txtTicketId = new TextBox();
            lblRequester = new Label();
            txtRequester = new TextBox();
            lblDate = new Label();
            dtpDate = new DateTimePicker();
            lblPriority = new Label();
            rdoLow = new RadioButton();
            rdoMedium = new RadioButton();
            rdoUrgent = new RadioButton();
            lblType = new Label();
            cboIssueType = new ComboBox();
            chkDesktop = new CheckBox();
            chkLaptop = new CheckBox();
            chkPrinter = new CheckBox();
            chkPhone = new CheckBox();
            picError = new PictureBox();
            btnLoadImage = new Button();
            btnSubmit = new Button();
            btnReset = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)picError).BeginInit();
            SuspendLayout();
            // 
            // lblTicketId
            // 
            lblTicketId.AutoSize = true;
            lblTicketId.Location = new Point(77, 49);
            lblTicketId.Name = "lblTicketId";
            lblTicketId.Size = new Size(74, 20);
            lblTicketId.TabIndex = 0;
            lblTicketId.Text = "Mã phiếu:";
            // 
            // txtTicketId
            // 
            txtTicketId.Location = new Point(255, 49);
            txtTicketId.Name = "txtTicketId";
            txtTicketId.Size = new Size(236, 27);
            txtTicketId.TabIndex = 1;
            txtTicketId.TextChanged += txtTicketId_TextChanged;
            // 
            // lblRequester
            // 
            lblRequester.AutoSize = true;
            lblRequester.Location = new Point(77, 97);
            lblRequester.Name = "lblRequester";
            lblRequester.Size = new Size(108, 20);
            lblRequester.TabIndex = 2;
            lblRequester.Text = "Người yêu cầu:";
            // 
            // txtRequester
            // 
            txtRequester.Location = new Point(255, 94);
            txtRequester.Name = "txtRequester";
            txtRequester.Size = new Size(236, 27);
            txtRequester.TabIndex = 3;
            txtRequester.TextChanged += txtRequester_TextChanged;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(77, 141);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(108, 20);
            lblDate.TabIndex = 4;
            lblDate.Text = "Ngày ghi nhận:";
            lblDate.Click += label1_Click;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(255, 141);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(216, 27);
            dtpDate.TabIndex = 5;
            // 
            // lblPriority
            // 
            lblPriority.AutoSize = true;
            lblPriority.Location = new Point(77, 180);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(113, 20);
            lblPriority.TabIndex = 6;
            lblPriority.Text = "Mức độ ưu tiên:";
            // 
            // rdoLow
            // 
            rdoLow.AutoSize = true;
            rdoLow.Location = new Point(214, 180);
            rdoLow.Name = "rdoLow";
            rdoLow.Size = new Size(63, 24);
            rdoLow.TabIndex = 7;
            rdoLow.TabStop = true;
            rdoLow.Text = "Thấp";
            rdoLow.UseVisualStyleBackColor = true;
            // 
            // rdoMedium
            // 
            rdoMedium.AutoSize = true;
            rdoMedium.Location = new Point(294, 180);
            rdoMedium.Name = "rdoMedium";
            rdoMedium.Size = new Size(100, 24);
            rdoMedium.TabIndex = 8;
            rdoMedium.TabStop = true;
            rdoMedium.Text = "Trung bình";
            rdoMedium.UseVisualStyleBackColor = true;
            // 
            // rdoUrgent
            // 
            rdoUrgent.AutoSize = true;
            rdoUrgent.Location = new Point(400, 180);
            rdoUrgent.Name = "rdoUrgent";
            rdoUrgent.Size = new Size(91, 24);
            rdoUrgent.TabIndex = 9;
            rdoUrgent.TabStop = true;
            rdoUrgent.Text = "Khẩn cấp";
            rdoUrgent.UseVisualStyleBackColor = true;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(77, 220);
            lblType.Name = "lblType";
            lblType.Size = new Size(76, 20);
            lblType.TabIndex = 10;
            lblType.Text = "Loại sự cố";
            // 
            // cboIssueType
            // 
            cboIssueType.FormattingEnabled = true;
            cboIssueType.Location = new Point(255, 217);
            cboIssueType.Name = "cboIssueType";
            cboIssueType.Size = new Size(151, 28);
            cboIssueType.TabIndex = 11;
            cboIssueType.SelectedIndexChanged += cboIssueType_SelectedIndexChanged;
            // 
            // chkDesktop
            // 
            chkDesktop.AutoSize = true;
            chkDesktop.Location = new Point(115, 266);
            chkDesktop.Name = "chkDesktop";
            chkDesktop.Size = new Size(117, 24);
            chkDesktop.TabIndex = 12;
            chkDesktop.Text = "Máy tính bàn";
            chkDesktop.UseVisualStyleBackColor = true;
            // 
            // chkLaptop
            // 
            chkLaptop.AutoSize = true;
            chkLaptop.Location = new Point(261, 266);
            chkLaptop.Name = "chkLaptop";
            chkLaptop.Size = new Size(78, 24);
            chkLaptop.TabIndex = 13;
            chkLaptop.Text = "Laptop";
            chkLaptop.UseVisualStyleBackColor = true;
            // 
            // chkPrinter
            // 
            chkPrinter.AutoSize = true;
            chkPrinter.Location = new Point(359, 266);
            chkPrinter.Name = "chkPrinter";
            chkPrinter.Size = new Size(75, 24);
            chkPrinter.TabIndex = 14;
            chkPrinter.Text = "Máy in";
            chkPrinter.UseVisualStyleBackColor = true;
            // 
            // chkPhone
            // 
            chkPhone.AutoSize = true;
            chkPhone.Location = new Point(467, 266);
            chkPhone.Name = "chkPhone";
            chkPhone.Size = new Size(100, 24);
            chkPhone.TabIndex = 15;
            chkPhone.Text = "Điện thoại";
            chkPhone.UseVisualStyleBackColor = true;
            // 
            // picError
            // 
            picError.BorderStyle = BorderStyle.FixedSingle;
            picError.Location = new Point(245, 296);
            picError.Name = "picError";
            picError.Size = new Size(201, 96);
            picError.SizeMode = PictureBoxSizeMode.StretchImage;
            picError.TabIndex = 16;
            picError.TabStop = false;
            picError.Click += picError_Click;
            // 
            // btnLoadImage
            // 
            btnLoadImage.Location = new Point(145, 363);
            btnLoadImage.Name = "btnLoadImage";
            btnLoadImage.Size = new Size(94, 29);
            btnLoadImage.TabIndex = 17;
            btnLoadImage.Text = "Tải ảnh lỗi";
            btnLoadImage.UseVisualStyleBackColor = true;
            btnLoadImage.Click += btnLoadImage_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(245, 409);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 18;
            btnSubmit.Text = "Gửi yêu cầu";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(377, 409);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 19;
            btnReset.Text = "Nhập lại";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(185, 9);
            label1.Name = "label1";
            label1.Size = new Size(382, 31);
            label1.TabIndex = 20;
            label1.Text = "Form Tiếp nhận & Phân loại sự cố IT";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnReset);
            Controls.Add(btnSubmit);
            Controls.Add(btnLoadImage);
            Controls.Add(picError);
            Controls.Add(chkPhone);
            Controls.Add(chkPrinter);
            Controls.Add(chkLaptop);
            Controls.Add(chkDesktop);
            Controls.Add(cboIssueType);
            Controls.Add(lblType);
            Controls.Add(rdoUrgent);
            Controls.Add(rdoMedium);
            Controls.Add(rdoLow);
            Controls.Add(lblPriority);
            Controls.Add(dtpDate);
            Controls.Add(lblDate);
            Controls.Add(txtRequester);
            Controls.Add(lblRequester);
            Controls.Add(txtTicketId);
            Controls.Add(lblTicketId);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picError).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTicketId;
        private TextBox txtTicketId;
        private Label lblRequester;
        private TextBox txtRequester;
        private Label lblDate;
        private DateTimePicker dtpDate;
        private Label lblPriority;
        private RadioButton rdoLow;
        private RadioButton rdoMedium;
        private RadioButton rdoUrgent;
        private Label lblType;
        private ComboBox cboIssueType;
        private CheckBox chkDesktop;
        private CheckBox chkLaptop;
        private CheckBox chkPrinter;
        private CheckBox chkPhone;
        private PictureBox picError;
        private Button btnLoadImage;
        private Button btnSubmit;
        private Button btnReset;
        private Label label1;
    }
}
