using System.Drawing;
namespace Bai_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboUnit.Items.Add("Cái");
            cboUnit.Items.Add("Bộ");
            cboUnit.Items.Add("Kg");
            cboUnit.Items.Add("Mét");

            cboUnit.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtItemId.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã vật tư!");
                txtItemId.Focus();
                return;
            }

            if (txtItemName.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên vật tư!");
                txtItemName.Focus();
                return;
            }

            double price;

            if (!double.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("Đơn giá phải là số!");
                txtPrice.Focus();
                return;
            }

            // Kiểm tra mã đã tồn tại
            foreach (ListViewItem item in lvItems.Items)
            {
                if (item.Text == txtItemId.Text.Trim())
                {
                    MessageBox.Show("Mã vật tư đã tồn tại!");
                    txtItemId.Focus();
                    return;
                }
            }

            // Thêm dòng
            ListViewItem newItem = new ListViewItem(txtItemId.Text.Trim());

            newItem.SubItems.Add(txtItemName.Text.Trim());
            newItem.SubItems.Add(cboUnit.Text);
            newItem.SubItems.Add(price.ToString("N0"));

            lvItems.Items.Add(newItem);

            MessageBox.Show("Thêm vật tư thành công!");
        }

        private void lvItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvItems.SelectedItems.Count == 0)
                return;

            ListViewItem item = lvItems.SelectedItems[0];

            txtItemId.Text = item.SubItems[0].Text;
            txtItemName.Text = item.SubItems[1].Text;
            cboUnit.Text = item.SubItems[2].Text;
            txtPrice.Text = item.SubItems[3].Text.Replace(",", "");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lvItems.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn vật tư cần cập nhật!");
                return;
            }

            double price;

            if (!double.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("Đơn giá phải là số!");
                return;
            }

            ListViewItem item = lvItems.SelectedItems[0];

            item.SubItems[0].Text = txtItemId.Text.Trim();
            item.SubItems[1].Text = txtItemName.Text.Trim();
            item.SubItems[2].Text = cboUnit.Text;
            item.SubItems[3].Text = price.ToString("N0");

            MessageBox.Show("Cập nhật thành công!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvItems.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa vật tư này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                lvItems.Items.Remove(lvItems.SelectedItems[0]);

                MessageBox.Show("Đã xóa!");
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (lvItems.Items.Count == 0)
                return;

            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa toàn bộ vật tư không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                lvItems.Items.Clear();

                txtItemId.Clear();
                txtItemName.Clear();
                txtPrice.Clear();
                cboUnit.SelectedIndex = 0;
            }
        }

        private void lblItemName_Click(object sender, EventArgs e)
        {

        }

        private void lblUnit_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
