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
        public int CumRap { get; set; }
        [ForeignKey("CumRap")]
        public virtual CumRapModel MaCumRap { get; set; }

        [Required]
        public int TrangThai { get; set; }

        public ICollection<PhongModel> LstPhong { get; set; }
        
       

        
    }
}
