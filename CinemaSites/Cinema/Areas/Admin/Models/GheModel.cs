using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema.Areas.Admin.Models

{
    public class GheModel
    {
        [Key] public int Id { get; set; }

        [Required] [Range(1,12, ErrorMessage ="Row has only 1 to 12 seats")] public int TenGhe { get; set; }

        public bool TrangThai { get; set; }
        public int MaHangGhe { get; set; }
        [ForeignKey("MaHangGhe")] public HangGheModel Hang { get; set; }

         public ICollection<VeModel> lstVe { get; set; }
    }
}