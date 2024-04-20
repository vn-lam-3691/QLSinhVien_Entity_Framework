using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLSinhVien_CodeFirst.Models
{
    public class SinhVien
    {
        public string MaSV { get; set; }
        public string Hoten { get; set; }
        public string Diachi { get; set; }
        public string MaLop { get; set; }
        [ForeignKey(nameof(MaLop))]
        public Lop Lop { get; set; }
    }
}
