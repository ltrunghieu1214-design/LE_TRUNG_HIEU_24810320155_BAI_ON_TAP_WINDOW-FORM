using System.Drawing;
namespace Bai_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtRequester_TextChanged(object sender, EventArgs e)
        {

        }

        private void picError_Click(object sender, EventArgs e)
        {

        }

        private void cboIssueType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboIssueType.Items.Add("Phần cứng");
            cboIssueType.Items.Add("Phần mềm");
            cboIssueType.Items.Add("Mạng");
            cboIssueType.Items.Add("Tài khoản");

            cboIssueType.SelectedIndex = 0;

            rdoMedium.Checked = true;
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Filter = "Image Files|*.jpg;*.png";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                picError.Image = Image.FromFile(openFile.FileName);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string maPhieu = txtTicketId.Text;
            string nguoiYeuCau = txtRequester.Text;

            string ngayGhiNhan = dtpDate.Value.ToString("dd/MM/yyyy");

            string uuTien = "";

            if (rdoLow.Checked)
                uuTien = "Thấp";
            else if (rdoMedium.Checked)
                uuTien = "Trung bình";
            else if (rdoUrgent.Checked)
                uuTien = "Khẩn cấp";

            string loaiSuCo = cboIssueType.Text;

            string thietBi = "";

            if (chkDesktop.Checked)
                thietBi += "Máy tính bàn, ";

            if (chkLaptop.Checked)
                thietBi += "Laptop, ";

            if (chkPrinter.Checked)
                thietBi += "Máy in, ";

            if (chkPhone.Checked)
                thietBi += "Điện thoại";

            MessageBox.Show(
                "THÔNG TIN PHIẾU SỰ CỐ\n\n" +
                "Mã phiếu: " + maPhieu + "\n" +
                "Người yêu cầu: " + nguoiYeuCau + "\n" +
                "Ngày ghi nhận: " + ngayGhiNhan + "\n" +
                "Mức độ ưu tiên: " + uuTien + "\n" +
                "Loại sự cố: " + loaiSuCo + "\n" +
                "Thiết bị ảnh hưởng: " + thietBi,
                "Tóm tắt yêu cầu"
            );
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTicketId.Clear();
            txtRequester.Clear();

            dtpDate.Value = DateTime.Now;

            rdoMedium.Checked = true;

            cboIssueType.SelectedIndex = 0;

            chkDesktop.Checked = false;
            chkLaptop.Checked = false;
            chkPrinter.Checked = false;
            chkPhone.Checked = false;

            picError.Image = null;

            txtTicketId.Focus();
        }

        private void txtTicketId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
