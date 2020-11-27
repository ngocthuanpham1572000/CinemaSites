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
        [Key] public int ID { get; set;}

        [Required] public DateTime NgayChieu { get; set; }

        [Required] public DateTime ThoiGianBatDau { get; set; } 
        public int TrangThai { get; set; }

        public int IDPhong { get; set; }

        public int IDPhim { get; set; }

        [ForeignKey("IDPhong")] public virtual PhongModel Phong { get; set; }
        [ForeignKey("IDPhim")] public virtual PhimModel Phim { get; set; }

        public ICollection<VeModel> listVe { get; set; }
    }
}
