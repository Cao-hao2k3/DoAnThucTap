using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ThanTai.Models
{
    public class ThuongHieu
    {
        public int ID { get; set; }

<<<<<<< HEAD
        [StringLength(255)]
=======
        [StringLength(50)]
>>>>>>> b07527a (Update2)
        [Required(ErrorMessage = "Tên thương hiệu không được bỏ trống.")]
        [DisplayName("Tên thương hiệu")]
        public string TenThuongHieu { get; set; }

<<<<<<< HEAD
        public ICollection<SanPham> SanPham { get; set; }
=======
        public virtual ICollection<SanPham>? SanPham { get; set; } 
>>>>>>> b07527a (Update2)
    }
}
