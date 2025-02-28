using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ThanTai.Models
{
    public class NguoiDung
    {
        [DisplayName("Mã người dùng")]
        public int ID { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Họ và tên không được bỏ trống.")]
        [DisplayName("Họ và tên")]
        public string HoVaTen { get; set; }

        [StringLength(255)]
        [Required(ErrorMessage = "Email không được bỏ trống.")]
        [DisplayName("Email")]
        public string Email { get; set; }

        [StringLength(20)]
        [Required(ErrorMessage = "Số điện thoại không được bỏ trống.")]
        [DisplayName("Số điện thoại")]
        public string DienThoai { get; set; }

        [StringLength(255)]
        [Required(ErrorMessage = "Địa chỉ không được bỏ trống.")]
        [DisplayName("Địa chỉ người dùng")]
        public string DiaChi { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Tên đăng nhập không được bỏ trống.")]
        [DisplayName("Tên đăng nhập")]
        public string TenDangNhap { get; set; }

        [StringLength(255)]
        [Required(ErrorMessage = "Mật khẩu không được bỏ trống.")]
        [DisplayName("Mật khâu")]
        public string MatKhau { get; set; }

        [DisplayName("Quyền hạn admin")]
        public bool Quyen { get; set; }

        [DisplayName("Ảnh tài khoản")]
        public string? Anh { get; set; }

        public ICollection<DatHang>? DatHang { get; set; }

        public ICollection<GioHang>? GioHang { get; set; }
    }
}
