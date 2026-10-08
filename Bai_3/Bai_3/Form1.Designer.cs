namespace Bai_3
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
            grpInput = new GroupBox();
            cboUnit = new ComboBox();
            btnDeleteAll = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtPrice = new TextBox();
            lblPrice = new Label();
            lblUnit = new Label();
            txtItemName = new TextBox();
            lblItemName = new Label();
            txtItemId = new TextBox();
            lblItemId = new Label();
            grpList = new GroupBox();
            lvItems = new ListView();
            colItemId = new ColumnHeader();
            colItemName = new ColumnHeader();
            colUnit = new ColumnHeader();
            colPrice = new ColumnHeader();
            label1 = new Label();
            grpInput.SuspendLayout();
            grpList.SuspendLayout();
            SuspendLayout();
            // 
            // grpInput
            // 
            grpInput.Controls.Add(cboUnit);
            grpInput.Controls.Add(btnDeleteAll);
            grpInput.Controls.Add(btnDelete);
            grpInput.Controls.Add(btnUpdate);
            grpInput.Controls.Add(btnAdd);
            grpInput.Controls.Add(txtPrice);
            grpInput.Controls.Add(lblPrice);
            grpInput.Controls.Add(lblUnit);
            grpInput.Controls.Add(txtItemName);
            grpInput.Controls.Add(lblItemName);
            grpInput.Controls.Add(txtItemId);
            grpInput.Controls.Add(lblItemId);
            grpInput.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpInput.Location = new Point(12, 51);
            grpInput.Name = "grpInput";
            grpInput.Size = new Size(320, 372);
            grpInput.TabIndex = 0;
            grpInput.TabStop = false;
            grpInput.Text = "Thông tin vật tư";
            // 
            // cboUnit
            // 
            cboUnit.FormattingEnabled = true;
            cboUnit.Location = new Point(135, 148);
            cboUnit.Name = "cboUnit";
            cboUnit.Size = new Size(161, 28);
            cboUnit.TabIndex = 12;
            // 
            // btnDeleteAll
            // 
            btnDeleteAll.Location = new Point(159, 301);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Size = new Size(117, 29);
            btnDeleteAll.TabIndex = 11;
            btnDeleteAll.Text = "Xóa toàn bộ";
            btnDeleteAll.UseVisualStyleBackColor = true;
            btnDeleteAll.Click += btnDeleteAll_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(22, 301);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Xóa dòng";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(159, 250);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(22, 250);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Thêm mới";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(135, 195);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(161, 27);
            txtPrice.TabIndex = 7;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(22, 202);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(106, 20);
            lblPrice.TabIndex = 6;
            lblPrice.Text = "Đơn giá nhập:";
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Location = new Point(27, 148);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(89, 20);
            lblUnit.TabIndex = 4;
            lblUnit.Text = "Đơn vị tính:";
            lblUnit.Click += lblUnit_Click;
            // 
            // txtItemName
            // 
            txtItemName.Location = new Point(135, 96);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(161, 27);
            txtItemName.TabIndex = 3;
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.Location = new Point(29, 96);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(80, 20);
            lblItemName.TabIndex = 2;
            lblItemName.Text = "Tên vật tư:";
            lblItemName.Click += lblItemName_Click;
            // 
            // txtItemId
            // 
            txtItemId.Location = new Point(135, 44);
            txtItemId.Name = "txtItemId";
            txtItemId.Size = new Size(161, 27);
            txtItemId.TabIndex = 1;
            // 
            // lblItemId
            // 
            lblItemId.AutoSize = true;
            lblItemId.Location = new Point(29, 44);
            lblItemId.Name = "lblItemId";
            lblItemId.Size = new Size(78, 20);
            lblItemId.TabIndex = 0;
            lblItemId.Text = "Mã vật tư:";
            // 
            // grpList
            // 
            grpList.Controls.Add(lvItems);
            grpList.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpList.Location = new Point(338, 51);
            grpList.Name = "grpList";
            grpList.Size = new Size(564, 387);
            grpList.TabIndex = 1;
            grpList.TabStop = false;
            grpList.Text = "Danh sách vật tư";
            // 
            // lvItems
            // 
            lvItems.Columns.AddRange(new ColumnHeader[] { colItemId, colItemName, colUnit, colPrice });
            lvItems.FullRowSelect = true;
            lvItems.GridLines = true;
            lvItems.Location = new Point(25, 26);
            lvItems.MultiSelect = false;
            lvItems.Name = "lvItems";
            lvItems.Size = new Size(521, 355);
            lvItems.TabIndex = 0;
            lvItems.UseCompatibleStateImageBehavior = false;
            lvItems.View = View.Details;
            lvItems.SelectedIndexChanged += lvItems_SelectedIndexChanged;
            // 
            // colItemId
            // 
            colItemId.Text = "Mã TV";
            colItemId.Width = 100;
            // 
            // colItemName
            // 
            colItemName.Text = "Tên TV";
            colItemName.Width = 180;
            // 
            // colUnit
            // 
            colUnit.Text = "Đơn vị tính";
            colUnit.Width = 120;
            // 
            // colPrice
            // 
            colPrice.Text = "Đơn giá";
            colPrice.Width = 120;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(185, 9);
            label1.Name = "label1";
            label1.Size = new Size(495, 38);
            label1.TabIndex = 2;
            label1.Text = "Quản lý danh mục Vật tư / Linh kiện";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 450);
            Controls.Add(label1);
            Controls.Add(grpList);
            Controls.Add(grpInput);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grpInput.ResumeLayout(false);
            grpInput.PerformLayout();
            grpList.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpInput;
        private Label lblUnit;
        private TextBox txtItemName;
        private Label lblItemName;
        private TextBox txtItemId;
        private Label lblItemId;
        private Label lblPrice;
        private TextBox txtPrice;
        private GroupBox grpList;
        private ListView lvItems;
        private ColumnHeader colItemId;
        private ColumnHeader colItemName;
        private ColumnHeader colUnit;
        private ColumnHeader colPrice;
        private Button btnDeleteAll;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private ComboBox cboUnit;
        private Label label1;
    }
}
