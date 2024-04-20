using System;
using System.Collections.Generic;

namespace QLSinhVien_DatabaseFirst.Models;

public partial class Khoa
{
    public int MaKhoa { get; set; }

    public string? TenKhoa { get; set; }

    public virtual ICollection<Lop> Lops { get; set; } = new List<Lop>();
}
