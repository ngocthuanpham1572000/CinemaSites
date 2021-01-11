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

        [Required] [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$")] [StringLength(300)] public string MatKhau { get; set; }

        public int TrangThai { get; set; }

        internal object SelectToken(string v)
        {
            throw new NotImplementedException();
        }
    }
}
