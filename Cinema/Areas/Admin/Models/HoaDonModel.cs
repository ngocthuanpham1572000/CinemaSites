using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema.Areas.Admin.Models
{
    public class HoaDonModel
    {
        public int Id { get; set; }

        [Required]
        public DateTime NgayLap { get; set; }

        [Range(1000, 100000000000)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 3)")]
        public decimal TongTien { get; set; }

        

        public int MaThanhVien { get; set; }

        [ForeignKey("MaThanhVien")]
        public virtual ThanhVienModel ThanhVien { get; set; }

        public int TrangThai { get; set; }
    }
}
