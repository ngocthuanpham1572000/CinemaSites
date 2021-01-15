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
       
        public int Id { get; set; }

        [Required]
        public string TenHang { get; set; }

        [Required]
        public int MaPhong { get; set; }

       

        public bool TrangThai { get; set; }

        [ForeignKey("MaPhong")]
        public virtual PhongModel Phong { get; set; }

        public ICollection<GheModel> lstGhe { get; set; }
    }
}
