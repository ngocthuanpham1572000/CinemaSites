using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace Cinema.Areas.Admin.Models
{
    public class CumRapModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string TenCum { get; set; }
        
        public int TrangThai { get; set; }
        public ICollection<RapPhimModel> lstRapPhim { get; set; }

       
        // xong
    }
}