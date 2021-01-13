using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema.Areas.Admin.Models

{
    public class GheModel
    {
        [Key] public int Id { get; set; }

        [Range(1, 20, ErrorMessage = "Can only 1 to 20")] 
        [Required] public int TenGhe { get; set; }
        
        public bool TrangThai { get; set; }
        public int MaHangGhe { get; set; }
        [ForeignKey("MaHangGhe")] public HangGheModel Hang { get; set; }

         public ICollection<VeModel> lstVe { get; set; }
    }
}