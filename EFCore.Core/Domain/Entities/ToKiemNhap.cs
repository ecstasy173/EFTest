using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class ToKiemNhap
{
    public long Id { get; set; }

    public int? Nam { get; set; }

    public Guid? DonViId { get; set; }

    public string? QuyetDinh { get; set; }

    public string? ToTruong { get; set; }

    public string? NhanVienVatTu { get; set; }

    public string? UyVien1 { get; set; }

    public string? ChucVuUyVien1 { get; set; }

    public string? UyVien2 { get; set; }

    public string? ChucVuUyVien2 { get; set; }

    public string? UyVien3 { get; set; }

    public string? ChucVuUyVien3 { get; set; }

    public string? UyVien4 { get; set; }

    public string? ChucVuUyVien4 { get; set; }

    public string? UyVien5 { get; set; }

    public string? ChucVuUyVien5 { get; set; }
}
