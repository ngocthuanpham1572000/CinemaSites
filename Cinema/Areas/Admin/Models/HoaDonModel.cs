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
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime NgayLap { get; set; }

        [Range(1000, 100000000000)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 3)")]
        public decimal TongTien { get; set; }

        

        public int MaThanhVien { get; set; }

        [ForeignKey("MaThanhVien")]
        public virtual ThanhVienModel ThanhVien { get; set; }

        public bool TrangThai { get; set; }
        public ICollection<VeModel> lstVe { get; set; }
    }
}
