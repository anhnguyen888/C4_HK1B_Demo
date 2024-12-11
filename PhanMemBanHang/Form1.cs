using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhanMemBanHang.EntitiesDb;

namespace PhanMemBanHang
{
    public partial class Form1 : Form
    {
        // Khởi tạo một đối tượng để trỏ tới bàn đang chọn
        private Button btnBanDangChon = null;

        // Định nghĩa một đối tượng của lớp PhanMemBanHangModel để thao tác với cơ sở dữ liệu
        private PhanMemBanHangModel db = new PhanMemBanHangModel();
        public Form1()
        {
            InitializeComponent();
            // Đăng ký sự kiện Load của Form1
            this.Load += Form1_Load;

            // Cài đặt thông tin cho comboBox
            cmbDanhMuc.DisplayMember = "TenDanhMuc";
            cmbDanhMuc.ValueMember = "DanhMucID";

            cmbMon.DisplayMember = "TenMon";
            cmbMon.ValueMember = "MonAnID";

            // Combobox không thay đổi giá trị khi chọn
            cmbDanhMuc.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMon.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Kiểm tra trạng thái đặt bàn
            KiemTraTrangThaiBan();
            // Load danh sách danh mục vào comboBox
            LoadDanhMuc();
        }

        private void LoadDanhMuc()
        {
            cmbDanhMuc.DataSource = db.DanhMuc.ToList();
        }

        private void KiemTraTrangThaiBan()
        {
            // Lấy danh sách các bàn từ cơ sở dữ liệu
            var listBan = db.Ban.ToList();
            //  Duyệt danh sách bàn ở trong pnlBan
            foreach (Button ban in pnlBan.Controls.OfType<Button>())
            {
                // kiểm tra bàn có trong danh sách trạng thái như thế nào? 
                if (listBan.Find(x => x.TenBan == ban.Text).TrangThai == true)
                {
                    // Nếu bàn đang có khách ngồi thì đổi màu bàn
                    ban.BackColor = Color.Yellow;
                }
            }
        }

        private void cmbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy danh sách món ăn theo danh mục
            var danhMucID = (int)cmbDanhMuc.SelectedValue;
            var listMon = db.MonAn.Where(x => x.DanhMucID == danhMucID).ToList();
            cmbMon.DataSource = listMon;
        }

        private void btnChonBan_Click(object sender, EventArgs e)
        {
            Button btnBan = (Button)sender;

            if (btnBanDangChon != null)
                btnBanDangChon.BackColor = Color.White;

            btnBanDangChon = btnBan;
            btnBanDangChon.BackColor = Color.Blue;

            KiemTraTrangThaiBan();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra đã chọn bàn chưa
            if (btnBanDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn bàn trước khi thêm món ăn");
                return;
            }
            // kiểm tra số lượng món ăn
            if (numSoLuong.Value == 0)
            {
                MessageBox.Show("Vui lòng chọn số lượng món ăn");
                return;
            }
            // lấy thông tin món ăn
            var monAnID = (int)cmbMon.SelectedValue;
            var monAn = db.MonAn.Find(monAnID);
            // lấy thông tin bàn
            var ban = db.Ban.FirstOrDefault(x => x.TenBan == btnBanDangChon.Text);
            // lấy số lượng món ăn
            var soLuong = (int)numSoLuong.Value;
            // lấy hóa đơn của bàn đó
            var hoaDon = db.HoaDon.FirstOrDefault(x => x.BanID == ban.BanID && x.TrangThai == false);
            // kiểm tra hóa đơn có tồn tại không
            if (hoaDon == null)
            {
                hoaDon = new HoaDon();
                hoaDon.BanID = ban.BanID;
                hoaDon.NgayLap = DateTime.Now;
                hoaDon.TrangThai = false;
                db.HoaDon.Add(hoaDon);
                db.SaveChanges();
            }
            // kiểm tra món ăn đã tồn tại trong hóa đơn chưa
            var chiTietHoaDon = db.ChiTietHoaDon.FirstOrDefault(x => x.HoaDonID == hoaDon.HoaDonID && x.MonAnID == monAnID);
            if (chiTietHoaDon == null)
            {
                chiTietHoaDon = new ChiTietHoaDon();
                chiTietHoaDon.HoaDonID = hoaDon.HoaDonID;
                chiTietHoaDon.MonAnID = monAnID;
                chiTietHoaDon.SoLuong = soLuong;
                chiTietHoaDon.DonGia = monAn.DonGia;
                db.ChiTietHoaDon.Add(chiTietHoaDon);
            }
            else
            {
                chiTietHoaDon.SoLuong += soLuong;
            }
            ban.TrangThai = true;
            db.SaveChanges();
            KiemTraTrangThaiBan();
            LoadDanhSachDatMonTheoBan(ban.BanID);
        }

        private void LoadDanhSachDatMonTheoBan(int banID)
        {
            // lấy hóa đơn của bàn đó
            var hoaDon = db.HoaDon.FirstOrDefault(x => x.BanID == banID && x.TrangThai == false);
            // lấy danh sách chi tiết hóa đơn
            var listChiTietHoaDon = db.ChiTietHoaDon.Where(x => x.HoaDonID == hoaDon.HoaDonID).ToList();
            // xóa dữ liệu cũ
            dgvDanhSachDatMon.Rows.Clear();
            // thêm dữ liệu mới
            foreach (var item in listChiTietHoaDon)
            {
                var monAn = db.MonAn.Find(item.MonAnID);
                dgvDanhSachDatMon.Rows.Add(monAn.TenMon, item.SoLuong, monAn.DonGia, item.ThanhTien);
            }
        }
    }
}
