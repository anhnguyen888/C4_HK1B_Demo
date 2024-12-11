using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PhanMemBanHang.EntitiesDb
{
    public partial class PhanMemBanHangModel : DbContext
    {
        public PhanMemBanHangModel()
            : base("name=PhanMemBanHangModel")
        {
        }

        public virtual DbSet<Ban> Ban { get; set; }
        public virtual DbSet<ChiTietHoaDon> ChiTietHoaDon { get; set; }
        public virtual DbSet<DanhMuc> DanhMuc { get; set; }
        public virtual DbSet<HoaDon> HoaDon { get; set; }
        public virtual DbSet<MonAn> MonAn { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietHoaDon>()
                .Property(e => e.ThanhTien)
                .HasPrecision(29, 2);
        }
    }
}
