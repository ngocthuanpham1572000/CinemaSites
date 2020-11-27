using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema.Areas.Admin.Models

{
    public class GheModel
    {
        [Key] public int ID { get; set; }

        [Required] public int TenGhe { get; set; }

        public int TrangThai { get; set; }

        public int IDHang { get; set; }
        [ForeignKey("Hang")] public HangGheModel Hang { get; set; }

        public ICollection<VeModel> listVe { get; set; }
    }
}