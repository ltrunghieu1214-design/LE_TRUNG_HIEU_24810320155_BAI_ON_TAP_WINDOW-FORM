using System;
using System.Drawing;
using System.Windows.Forms;
namespace Bai_4
{
    public partial class Form1 : Form
    {
        int soViTriDangChon = 0;
        int giaTien = 100000;
        public Form1()
        {
            InitializeComponent();
        }

        private void lblSelected_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Thêm khung giờ
            cboTime.Items.Add("Sáng - 100.000đ");
            cboTime.Items.Add("Tối - 150.000đ");

            cboTime.SelectedIndex = 0;

            // Tạo 20 nút bằng vòng lặp
            for (int i = 1; i <= 20; i++)
            {
                Button btn = new Button();

                btn.Text = "Vị trí " + i;
                btn.Name = "btnViTri" + i;

                btn.Dock = DockStyle.Fill;
                btn.Margin = new Padding(5);

                // Màu ban đầu: trống
                btn.BackColor = Color.WhiteSmoke;

                // Gán chung sự kiện Click
                btn.Click += ViTri_Click;

                // Thêm vào TableLayoutPanel
                tableLayoutPanel1.Controls.Add(btn);
            }
        }

        // Hàm dùng chung cho 20 nút
        private void ViTri_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            // Nếu đang trống thì chọn
            if (btn.BackColor == Color.WhiteSmoke)
            {
                btn.BackColor = Color.LightGreen;
                soViTriDangChon++;
            }
            // Nếu đang chọn thì bỏ chọn
            else if (btn.BackColor == Color.LightGreen)
            {
                btn.BackColor = Color.WhiteSmoke;
                soViTriDangChon--;
            }

            CapNhatThongTin();
        }

        // Cập nhật số lượng và tiền
        private void CapNhatThongTin()
        {
            int tongTien = soViTriDangChon * giaTien;

            lblSelected.Text = "Số vị trí đang chọn: " + soViTriDangChon;

            lblTotal.Text = "Tạm tính tiền: " + tongTien.ToString("N0") + " VNĐ";
        }

        // Đổi khung giờ
        private void cboTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTime.SelectedIndex == 0)
                giaTien = 100000;
            else
                giaTien = 150000;

            CapNhatThongTin();
        }

        // Hủy chọn tất cả
        private void btnCancel_Click(object sender, EventArgs e)
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Button btn = control as Button;

                if (btn != null)
                {
                    // Chỉ bỏ những vị trí đang chọn
                    if (btn.BackColor == Color.LightGreen)
                    {
                        btn.BackColor = Color.WhiteSmoke;
                    }
                }
            }

            soViTriDangChon = 0;

            CapNhatThongTin();
        }

        // Xác nhận đặt
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (soViTriDangChon == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một vị trí!");
                return;
            }

            MessageBox.Show(
                "Đặt vị trí thành công!\n\n" +
                "Số vị trí: " + soViTriDangChon + "\n" +
                "Khung giờ: " + cboTime.Text + "\n" +
                "Tổng tiền: " + (soViTriDangChon * giaTien).ToString("N0") + " VNĐ"
            );
        }
    }
}
