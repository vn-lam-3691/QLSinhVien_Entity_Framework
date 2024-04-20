using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLSinhVien_CodeFirst.Models
{
    public class Lop
    {
        public string MaLop { get; set; }
        public string GVCN { get; set;}
        public int Siso { get; set;}
        public int MaKhoa { get; set; }
        [ForeignKey(nameof(MaKhoa))]
        public Khoa Khoa { get; set; }
    }
}
