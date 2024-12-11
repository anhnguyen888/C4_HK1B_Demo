using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MayTinhCaNhan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPhepTinh_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ 2 ô textbox
            double a = double.Parse(txtSoA.Text);
            double b = double.Parse(txtSoB.Text);
            double ketQua = 0;
            // Kiểm tra phép toán được chọn dựa vào sender của sự kiện
            // sender là nút button được click
            string phepTinh = ((System.Windows.Forms.Button)sender).Name;
            switch (phepTinh)
            {
                case "btnCong":
                    ketQua = a + b;
                    break;
                case "btnTru":
                    ketQua = a - b;
                    break;
                case "btnNhan":
                    ketQua = a * b;
                    break;
                case "btnChia":
                    // Kiểm tra mẫu số khác 0
                    if (b == 0)
                    {
                        MessageBox.Show("Mẫu số phải khác 0");
                        return;
                    }
                    ketQua = a / b;
                    break;
            }
            // Hiển thị kết quả
            txtKetQua.Text = ketQua.ToString();
        }

        private void txtSoA_Validating(object sender, CancelEventArgs e)
        {
            if (!double.TryParse(txtSoA.Text, out _)) // Kiểm tra nếu không phải số
            {
                errorProvider1.SetError(txtSoA, "Chỉ được nhập số.");
                e.Cancel = true; // Ngăn không cho rời khỏi TextBox nếu không hợp lệ
            }
            else
            {
                errorProvider1.SetError(txtSoA, string.Empty); // Xóa lỗi nếu hợp lệ
            }
        }
    }
}
