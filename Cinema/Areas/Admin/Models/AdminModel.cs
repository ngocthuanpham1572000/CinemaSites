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

<<<<<<< HEAD
        public int TrangThai { get; set; }

        internal object SelectToken(string v)
        {
            throw new NotImplementedException();
        }
=======
        public bool TrangThai { get; set; }
>>>>>>> 6d05d023997803238f2f2e7c3458518a4f16f206
    }
}
