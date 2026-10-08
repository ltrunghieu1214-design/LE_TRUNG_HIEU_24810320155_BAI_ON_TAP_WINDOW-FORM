using System;
using System.Windows.Forms;
namespace Bai_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboShipping.Items.Add("Giao thường");
            cboShipping.Items.Add("Giao nhanh");
            cboShipping.Items.Add("Hỏa tốc");

            cboShipping.SelectedIndex = 0;

            timer1.Start();

            CapNhatTongTien();
        }
        private void dgvOrders_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 1 ||
                e.ColumnIndex == 2 ||
                e.ColumnIndex == 3)
            {
                DataGridViewRow row = dgvOrders.Rows[e.RowIndex];

                double soLuong = 0;
                double donGia = 0;

                double.TryParse(Convert.ToString(row.Cells[1].Value), out soLuong);
                double.TryParse(Convert.ToString(row.Cells[3].Value), out donGia);

                double thanhTien = soLuong * donGia;

                row.Cells[4].Value = thanhTien;

                CapNhatTongTien();
            }
        }
        private void CapNhatTongTien()
        {
            double tongSoLuong = 0;
            double tongTrongLuong = 0;
            double tongTien = 0;

            foreach (DataGridViewRow row in dgvOrders.Rows)
            {
                if (row.IsNewRow)
                    continue;

                double soLuong = 0;
                double trongLuong = 0;
                double thanhTien = 0;

                double.TryParse(Convert.ToString(row.Cells[1].Value), out soLuong);
                double.TryParse(Convert.ToString(row.Cells[2].Value), out trongLuong);
                double.TryParse(Convert.ToString(row.Cells[4].Value), out thanhTien);

                tongSoLuong += soLuong;
                tongTrongLuong += trongLuong;
                tongTien += thanhTien;
            }

            lblQuantity.Text = "Tổng số lượng: " + tongSoLuong;
            lblWeight.Text = "Tổng trọng lượng: " +
                             tongTrongLuong.ToString("N2") + " kg";

            lblMoney.Text = "Tổng tiền: " +
                            tongTien.ToString("N0") + " VNĐ";
        }
        //Số lượng hoặc Trọng lượng ≤ 0 thì báo lỗi.
        private void dgvOrders_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 1)
            {
                double soLuong;

                if (!double.TryParse(e.FormattedValue.ToString(), out soLuong) ||
                    soLuong <= 0)
                {
                    errorProvider1.SetError(
                        dgvOrders,
                        "Số lượng phải lớn hơn 0!"
                    );
                }
                else
                {
                    errorProvider1.Clear();
                }
            }

            if (e.ColumnIndex == 2)
            {
                double trongLuong;

                if (!double.TryParse(e.FormattedValue.ToString(), out trongLuong) ||
                    trongLuong <= 0)
                {
                    errorProvider1.SetError(
                        dgvOrders,
                        "Trọng lượng phải lớn hơn 0!"
                    );
                }
                else
                {
                    errorProvider1.Clear();
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // F2: thêm dòng
            if (e.KeyCode == Keys.F2)
            {
                dgvOrders.Rows.Add();

                int dongMoi = dgvOrders.Rows.Count - 2;

                if (dongMoi >= 0)
                {
                    dgvOrders.CurrentCell =
                        dgvOrders.Rows[dongMoi].Cells[0];
                }

                e.SuppressKeyPress = true;
            }

            // Delete: xóa dòng
            if (e.KeyCode == Keys.Delete)
            {
                if (dgvOrders.CurrentRow != null &&
                    !dgvOrders.CurrentRow.IsNewRow)
                {
                    dgvOrders.Rows.Remove(dgvOrders.CurrentRow);

                    CapNhatTongTien();
                }

                e.SuppressKeyPress = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = "Thời gian: " +
                   DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cboShipping_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
