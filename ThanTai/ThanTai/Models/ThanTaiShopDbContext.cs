using Microsoft.EntityFrameworkCore;
<<<<<<< HEAD
=======
using ThanTai.Models;
>>>>>>> b07527a (Update2)

namespace ThanTai.Models
{
    public class ThanTaiShopDbContext : DbContext
    {
       public ThanTaiShopDbContext(DbContextOptions<ThanTaiShopDbContext> options) : base(options) { }

        public DbSet<LoaiSanPham> LoaiSanPham { get; set; }
        public DbSet<SanPham> SanPham { get; set; }

        public DbSet<DatHang> DatHang { get; set; }

        public DbSet<TinhTrang> TinhTrang { get; set; }

        public DbSet<DatHangChiTiet> DatHangChiTiet { get; set; }

        public DbSet<NguoiDung> NguoiDung { get; set; }

        public DbSet<ThuocTinh> ThuocTinh { get; set; }
        public DbSet<GiaTriThuocTinh> GiaTriThuocTinh { get; set; }
        
        public DbSet<ThuongHieu> ThuongHieu { get; set; }
<<<<<<< HEAD
=======
        public DbSet<ThanTai.Models.HinhAnhSanPham> HinhAnhSanPham { get; set; } = default!;
>>>>>>> b07527a (Update2)
    }
}
