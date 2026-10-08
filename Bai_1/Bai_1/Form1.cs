namespace Bai_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double donGia;
            int soLuong;
            double giamGia;

            if (!double.TryParse(txtUnitPrice.Text, out donGia))
            {
                MessageBox.Show("Đơn giá phải là số!");
                txtUnitPrice.Focus();
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out soLuong))
            {
                MessageBox.Show("Số lượng phải là số!");
                txtQuantity.Focus();
                return;
            }

            if (!double.TryParse(txtDiscount.Text, out giamGia))
            {
                MessageBox.Show("Mã giảm giá phải là số!");
                txtDiscount.Focus();
                return;
            }

            if (donGia < 0 || soLuong < 0 || giamGia < 0 || giamGia > 100)
            {
                MessageBox.Show("Dữ liệu không hợp lệ!");
                return;
            }

            double tongTien = (donGia * soLuong) * (100 - giamGia) / 100;

            lblTotal.Text = "Tổng tiền: " + tongTien.ToString("N0") + " VNĐ";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUnitPrice.Clear();
            txtQuantity.Clear();
            txtDiscount.Clear();

            lblTotal.Text = "Tổng tiền: 0 VNĐ";

            txtUnitPrice.Focus();
        }
    }
}
