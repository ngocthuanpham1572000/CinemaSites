using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema.Areas.Admin.Models
{
    public class ThanhVienModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Ten { get; set; }

        [StringLength(50)]
        public string HinhAnh { get; set; }

        [Required]
        public string GioiTinh { get; set; }

        [Required]
        [StringLength(14)]
        public string SDT { get; set; }

        [Required]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}")]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(300, MinimumLength = 6)]
        public string TaiKhoan { get; set; }


        [Required]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$")]
        [StringLength(300, MinimumLength = 6)]
        public string MatKhau { get; set; }

        public int TrangThai { get; set; }

        public ICollection<ThanhVienModel> list { get; set; }
    }
}
