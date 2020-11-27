using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Areas.Admin.Models
{
    public class HangGheModel
    {
        [Key] public int ID { get; set; }

        public int IDPhong { get; set; }

        [Required][StringLength(1)] public string TenHang { get; set; }

        public int TrangThai { get; set; }

        [ForeignKey("IDPhong")] public virtual PhongModel Phong { get; set; }

        public ICollection<GheModel> listGhe { get; set; }
    }
}
