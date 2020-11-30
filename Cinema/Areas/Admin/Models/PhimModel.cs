using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Cinema.Areas.Admin.Models
{
    public class PhimModel
    {
        
        public int Id { get; set; }
        [Required]
        [StringLength(50,MinimumLength =3)]
        public string TenPhim { get; set; }
        [Required]
        public int ThoiLuong { get; set; }
        [StringLength(50, MinimumLength = 3)]
        public string DaoDien { get; set; }
        [StringLength(50, MinimumLength = 3)]
        public string DienVien { get; set; }
        [StringLength(50, MinimumLength = 2)]
        public string QuocGia { get; set; }
        [StringLength(1000, MinimumLength = 3)]
        public string Mota { get; set; }
        [Required]
        public string HinhAnh { get; set; }

        public string Trailer { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime NgayPhatHanh { get; set; }
        [Required]
        public int MaLoai { get; set; }
        [ForeignKey("MaLoai")]
        public virtual LoaiPhimModel Loai { get; set; }
        public ICollection<SuatChieuModel> lstSuatChieu { get; set; }

    }
}
