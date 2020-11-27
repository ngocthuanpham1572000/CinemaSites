using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Cinema.Areas.Admin.Models
{
    public class LoaiPhimModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string TenLoai { get; set; }
        public int TrangThai { get; set; }
        public ICollection<LoaiPhimModel> lstPhim { get; set; }

    }
}
