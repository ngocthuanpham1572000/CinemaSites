using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace Cinema.Areas.Admin.Models
{
    public class CumRapModel
    {
        public int Id { get; set; }
        [StringLength(50, MinimumLength = 3)]
        [Required]
        public string TenCum { get; set; }
        [Required]
        public int TrangThai { get; set; }
        public ICollection<RapPhimModel> LstRapPhim { get; set; }

    }
}