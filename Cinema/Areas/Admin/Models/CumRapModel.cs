using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.ComponentModel;

namespace Cinema.Areas.Admin.Models
{
    public class CumRapModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string TenCum { get; set; }
        
        public bool TrangThai { get; set; }
        public ICollection<RapPhimModel> lstRapPhim { get; set; }

       
        // xong
    }
}