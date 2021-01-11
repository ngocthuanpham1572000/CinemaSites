using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Areas.Admin.Models
{
    public class AdminModel
    {
        [Key] public int Id { get; set; }

        [Required] [StringLength(50)] public string TaiKhoan { get; set; }

        [Required]  [StringLength(300)] public string MatKhau { get; set; }

        public bool TrangThai { get; set; }
    }
}
