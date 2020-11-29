using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Cinema.Areas.Admin.Models
{
    public class RapPhimModel
    {
        public int Id { get; set; }
       
        [StringLength(50, MinimumLength = 3)]
        [Required]
        public string TenRap { get; set; }

        [StringLength(200, MinimumLength = 3)]
        [Required]
        public string DiaChi { get; set; }
        [Required]
        public string HinhAnh { get; set; }
        [Required]
        public int MaCumRap { get; set; }
        [ForeignKey("MaCumRap")]
        public virtual CumRapModel CumRap { get; set; }

        [Required]
        public int TrangThai { get; set; }

        public ICollection<PhongModel> lstPhong { get; set; }
        
       

        
    }
}
