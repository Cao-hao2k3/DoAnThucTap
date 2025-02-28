using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ThanTai.Models
{
    public class ThuongHieu
    {
        public int ID { get; set; }

        [StringLength(255)]
        [Required(ErrorMessage = "Tên thương hiệu không được bỏ trống.")]
        [DisplayName("Tên thương hiệu")]
        public string TenThuongHieu { get; set; }

        public ICollection<SanPham> SanPham { get; set; }
    }
}
