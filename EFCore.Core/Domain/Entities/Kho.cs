using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class Kho
{
    public bool? SsIsLocked { get; set; }

    public bool? SsIsDeleted { get; set; }

    public Guid? SsClientId { get; set; }

    public Guid? SsLocationId { get; set; }

    public Guid? SsCreatedBy { get; set; }

    public DateTime? SsCreatedAt { get; set; }

    public Guid? SsUpdatedBy { get; set; }

    public DateTime? SsUpdatedAt { get; set; }

    public Guid? DraftId { get; set; }

    public Guid KhoId { get; set; }

    public string? MaSo { get; set; }

    public string? TenKho { get; set; }

    public Guid? ParentId { get; set; }

    public string? DiaChi { get; set; }

    public string? DienThoai { get; set; }

    public string? Email { get; set; }

    public string? NguoiLienHe { get; set; }

    public Guid? KhachHangId { get; set; }

    public Guid? TaiKhoanKhoId { get; set; }

    public int? SttgiaVon { get; set; }

    public int? LineNo { get; set; }

    public string? MoTa { get; set; }

    public DateTime? ValidTo { get; set; }

    public int? LevelNo { get; set; }

    public bool? KhongSuDung { get; set; }

    public bool? AllUser { get; set; }

    public Guid? TaiKhoanDoanhThuId { get; set; }

    public Guid? TaiKhoanGiaVonId { get; set; }

    public Guid? TaiKhoanChietKhauId { get; set; }

    public Guid? TaiKhoanDoanhThuNoiBoId { get; set; }

    public Guid? TaiKhoanTienMatId { get; set; }

    public Guid? TaiKhoanDoanhThuTraLaiId { get; set; }

    public Guid? TaiKhoanPhanBoNhapId { get; set; }

    public Guid? DonViId { get; set; }

    public bool? IsLeaf { get; set; }

    public string? Gpslongitude { get; set; }

    public string? Gpsname { get; set; }

    public string? Gpsaddress { get; set; }

    public string? Gpslatitude { get; set; }

    public Guid? ThuKhoId { get; set; }

    public bool? IsInternalExport { get; set; }
}
