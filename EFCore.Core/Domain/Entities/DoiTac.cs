using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class DoiTac
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

    public Guid DoiTacId { get; set; }

    public string? MaSo { get; set; }

    public string? TenDoiTac { get; set; }

    public string? Email { get; set; }

    public string? DienThoai { get; set; }

    public string? DiaChi { get; set; }

    public Guid? TinhChatDoiTacId { get; set; }

    public Guid? NhomDoiTacId { get; set; }

    public string? Cmnd { get; set; }

    public string? TenPhapNhan { get; set; }

    public string? DiaChiPhapNhan { get; set; }

    public string? MaSoThue { get; set; }

    public string? MoTa { get; set; }

    public int? LineNo { get; set; }

    public DateTime? ValidTo { get; set; }

    public int? LevelNo { get; set; }

    public bool? KhongSuDung { get; set; }

    public byte[]? AnhDaiDien { get; set; }

    public string? TenNguoiGiaoDich { get; set; }

    public string? EmailNguoiGiaoDich { get; set; }

    public string? DienThoaiNguoiGiaoDich { get; set; }

    public string? DiaChiNguoiGiaoDich { get; set; }

    public Guid? TuyenGiaoHangId { get; set; }

    public Guid? ChucVuId { get; set; }

    public Guid? UserId { get; set; }

    public Guid? XaPhuongId { get; set; }

    public int? WebId { get; set; }

    public string? AnhDaiDienUrl { get; set; }

    public bool? IsDataLink { get; set; }

    public Guid? HinhThucThanhToanMuaId { get; set; }

    public Guid? HinhThucThanhToanBanId { get; set; }

    public Guid? NhomThuocTinhId { get; set; }

    public string? GhiChu { get; set; }

    public string? TagList { get; set; }

    public string? SoTaiKhoanNganHang { get; set; }

    public Guid? NganHangId { get; set; }

    public Guid? ChiNhanhNganHangId { get; set; }

    public Guid? NopVaoTaiKhoanNganHangId { get; set; }

    public Guid? ParentId { get; set; }

    public string? MaSoThueNoiCap { get; set; }

    public DateTime? MaSoThueNgayCap { get; set; }

    public string? CmndnoiCap { get; set; }

    public DateTime? CmndngayCap { get; set; }

    public Guid? LoaiDoiTacId { get; set; }

    public Guid? DataContactId { get; set; }

    public Guid? BoPhanId { get; set; }

    public bool? BaoHiemTheoHeThong { get; set; }

    public decimal? LuongTinhBaoHiem { get; set; }

    public decimal? HeSoBaoHiem { get; set; }

    public decimal? LuongThoaThuan { get; set; }

    public bool? CoLuongDoanhSo { get; set; }

    public string? TenChuTaiKhoanNganHang { get; set; }

    public Guid? DonViId { get; set; }

    public string? NguoiDaiDienPhapLuat { get; set; }

    public string? NguoiDaiDienChucVu { get; set; }

    public string? NguoiDaiDienCmnd { get; set; }

    public DateTime? NgaySinh { get; set; }

    public Guid? KenhBanHangId { get; set; }

    public Guid? TinhThanhId { get; set; }

    public Guid? QuanHuyenId { get; set; }

    public string? Gpslongitude { get; set; }

    public string? Gpsname { get; set; }

    public string? Gpsaddress { get; set; }

    public string? Gpslatitude { get; set; }

    public Guid? KhuVucBanHangId { get; set; }

    public string? ThongTinNganHang { get; set; }

    public string? HopDongHopTac { get; set; }

    public DateTime? NgayKyHopTac { get; set; }

    public Guid? HinhThucGiaoNhanId { get; set; }

    public string? DiaChiNhanHang { get; set; }

    public Guid? KhoXuatHangId { get; set; }

    public Guid? KhoNhapHangId { get; set; }
}
