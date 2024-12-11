using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySinhVienUI.Entities;

namespace QuanLySinhVienUI
{
    public partial class FrmQuanLySinhVien : Form
    {
        List<Khoa> danhSachKhoa = new List<Khoa>();
        List<SinhVien> danhSachSinhVien = new List<SinhVien>();
        SinhVien sinhVien = null;

        public FrmQuanLySinhVien()
        {
            InitializeComponent();
            // Thiết lập cấu hình hiển thị cho ComboBox cmbKhoa
            cmbKhoa.DisplayMember = "TenKhoa";
            cmbKhoa.ValueMember = "MaKhoa";
        }

        private void FrmQuanLySinhVien_Load(object sender, EventArgs e)
        {
            // Thêm dữ liệu mẫu cho danh sách khoa
            danhSachKhoa.Add(new Khoa("CNTT", "Công nghệ thông tin"));
            danhSachKhoa.Add(new Khoa("KT", "Kinh tế"));
            danhSachKhoa.Add(new Khoa("NN", "Ngoại ngữ"));
            // Hiển thị dữ liệu lên ComboBox cmbKhoa
            cmbKhoa.DataSource = danhSachKhoa;
        }

        private void btnThemSua_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các điều khiển trên form
            string maSo = txtMaSoSinhVien.Text;
            string hoTen = txtHoTen.Text;
            string gioiTinh = rboNam.Checked ? "Nam" : "Nữ";
            double diem = double.Parse(txtDiem.Text);
            string maKhoa = cmbKhoa.SelectedValue.ToString();

            // Kiểm tra xem sinh viên đã tồn tại trong danh sách chưa?
            SinhVien sinhVien = danhSachSinhVien.FirstOrDefault(x => x.MaSo == maSo);
            if (sinhVien == null)
            {
                // Nếu chưa tồn tại thì thêm mới
                danhSachSinhVien.Add(new SinhVien(maSo, hoTen, gioiTinh, diem, maKhoa));
            }
            else
            {
                // Nếu đã tồn tại thì cập nhật thông tin
                sinhVien.HoTen = hoTen;
                sinhVien.GioiTinh = gioiTinh;
                sinhVien.Diem = diem;
                sinhVien.MaKhoa = maKhoa;
            }
            // Hiển thị danh sách sinh viên lên DataGridView
            HienThiDanhSachSinhVien();
            // Thống kê số lượng sinh viên theo giới tính 
            int soLuongSinhVienNam = danhSachSinhVien.Count(x => x.GioiTinh == "Nam");
            int soLuongSinhVienNu = danhSachSinhVien.Count(x => x.GioiTinh == "Nữ");
            // Hiển thị thông tin thống kê lên form 
            txtSoLuongNam.Text = soLuongSinhVienNam.ToString();
            txtSoLuongNu.Text = soLuongSinhVienNu.ToString();
            // Reset các điều khiển trên form
            txtMaSoSinhVien.Text = "";
            txtHoTen.Text = "";
            rboNam.Checked = true;
            txtDiem.Text = "";
            cmbKhoa.SelectedIndex = 0;
        }

        private void HienThiDanhSachSinhVien()
        {
            // Xóa dữ liệu cũ trên DataGridView
            dgvDanhSachSinhVien.Rows.Clear();
            // Hiển thị dữ liệu mới lên DataGridView
            foreach (SinhVien sv in danhSachSinhVien)
            {
                dgvDanhSachSinhVien.Rows.Add(sv.MaSo, sv.HoTen, sv.GioiTinh, sv.Diem, sv.MaKhoa);
            }
        }

        private void dgvDanhSachSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn dòng nào chưa
            if (e.RowIndex >= 0)
            {
                // Lấy thông tin sinh viên từ dòng được chọn
                string maSo = dgvDanhSachSinhVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                sinhVien = danhSachSinhVien.FirstOrDefault(x => x.MaSo == maSo);
                // Hiển thị thông tin sinh viên lên form
                txtMaSoSinhVien.Text = sinhVien.MaSo;
                txtHoTen.Text = sinhVien.HoTen;
                rboNam.Checked = sinhVien.GioiTinh == "Nam";
                rboNu.Checked = sinhVien.GioiTinh == "Nữ";
                txtDiem.Text = sinhVien.Diem.ToString();
                cmbKhoa.SelectedValue = sinhVien.MaKhoa;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn sinh viên cần xóa chưa
            if (sinhVien != null)
            {
                // Xóa sinh viên khỏi danh sách
                danhSachSinhVien.Remove(sinhVien);
                // Hiển thị lại danh sách sinh viên lên DataGridView
                HienThiDanhSachSinhVien();
                // Thống kê số lượng sinh viên theo giới tính 
                int soLuongSinhVienNam = danhSachSinhVien.Count(x => x.GioiTinh == "Nam");
                int soLuongSinhVienNu = danhSachSinhVien.Count(x => x.GioiTinh == "Nữ");
                // Hiển thị thông tin thống kê lên form 
                txtSoLuongNam.Text = soLuongSinhVienNam.ToString();
                txtSoLuongNu.Text = soLuongSinhVienNu.ToString();
                // Reset các điều khiển trên form
                txtMaSoSinhVien.Text = "";
                txtHoTen.Text = "";
                rboNam.Checked = true;
                txtDiem.Text = "";
                cmbKhoa.SelectedIndex = 0;

                // Reset biến sinhVien
                sinhVien = null;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!");
            }
        }
    }
}
