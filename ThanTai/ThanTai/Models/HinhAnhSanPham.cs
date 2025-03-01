using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ThanTai.Models
{
    public class HinhAnhSanPham
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [DisplayName("Mã sản phẩm")]
        public int SanPhamID { get; set; }

        [Required]
        [StringLength(500)]
        [DisplayName("Ảnh sản phẩm")]
        public string AnhSanPham { get; set; }

        [StringLength(500)]
        [DisplayName("Ảnh thông số sản phẩm")]
        public string AnhThongSo { get; set; }

        [ForeignKey("SanPhamID")]
<<<<<<< HEAD
        public SanPham SanPham { get; set; }
=======
        public virtual SanPham? SanPham { get; set; }
>>>>>>> b07527a (Update2)
    }
}
