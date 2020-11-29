using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema.Areas.Admin.Models
{
    public class SuatChieuModel
    {
        [Key] 
        public int Id { get; set;}
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
         public DateTime NgayChieu { get; set; }


        [Required]
        [DataType(DataType.Time)]
        public DateTime ThoiGianBatDau { get; set; }

        [Required]
        public int MaPhong { get; set; }
        [Required]
        public int MaPhim { get; set; }
        public int TrangThai { get; set; }

        [ForeignKey("MaPhong")] 
        public virtual PhongModel Phong { get; set; }
        [ForeignKey("MaPhim")]
        public virtual PhimModel Phim { get; set; }

        public ICollection<VeModel> lstVe { get; set; }
    }
}
