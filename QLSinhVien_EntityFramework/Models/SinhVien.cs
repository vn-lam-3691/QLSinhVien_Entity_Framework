using System;
using System.Collections.Generic;

namespace QLSinhVien_DatabaseFirst.Models;

public partial class SinhVien
{
    public string MaSv { get; set; } = null!;

    public string? Hoten { get; set; }

    public string? DiaChi { get; set; }

    public string? MaLop { get; set; }

    public virtual Lop? MaLopNavigation { get; set; }
}
