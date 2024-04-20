using System;
using System.Collections.Generic;

namespace QLSinhVien_DatabaseFirst.Models;

public partial class Lop
{
    public string MaLop { get; set; } = null!;

    public string? Gvcn { get; set; }

    public int? Siso { get; set; }

    public int? MaKhoa { get; set; }

    public virtual Khoa? MaKhoaNavigation { get; set; }

    public virtual ICollection<SinhVien> SinhViens { get; set; } = new List<SinhVien>();
}
