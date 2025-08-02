using EFCore.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Core.Domain.Dto
{
    public class ChungTuChiTietDto
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

        public Guid? ChungTuChiTietId { get; set; }

        public int? NamTc { get; set; }

        public Guid? KyBaoCaoId { get; set; }

        public Guid? ChungTuId { get; set; }

        public Guid? LoaiChungTuId { get; set; }

        public DateTime? NgayPhatSinh { get; set; }

        public Guid? NghiepVuId { get; set; }

        public Guid? TaiKhoanIdno { get; set; }

        public Guid? TaiKhoanIdco { get; set; }

        public DateTime? NgayPhanBoBatDauNo { get; set; }

        public DateTime? NgayPhanBoKetThucNo { get; set; }

        public DateTime? NgayPhanBoBatDauCo { get; set; }

        public DateTime? NgayPhanBoKetThucCo { get; set; }

        public string? NoiDungChiTiet { get; set; }

        public decimal? ThanhTienNguyenTe { get; set; }

        public Guid? TienTeId { get; set; }

        public decimal? TyGia { get; set; }

        public decimal? ThanhTienChungTu { get; set; }

        public bool? IsCoThue { get; set; }

        public bool? IsThanhTienCoThue { get; set; }

        public bool? IsHachToanThueGtgt { get; set; }

        public bool? IsKeKhaiThueGtgt { get; set; }

        public Guid? NghiepVuThueId { get; set; }

        public Guid? MucThueSuatId { get; set; }

        public Guid? NhomKeKhaiThueId { get; set; }

        public decimal? ThueSuat { get; set; }

        public decimal? TienThue { get; set; }

        public decimal? ThanhTienChuaThue { get; set; }

        public decimal? ThanhTienCoThue { get; set; }

        public Guid? TaiKhoanIdthueNo { get; set; }

        public Guid? TaiKhoanIdthueCo { get; set; }

        public Guid? SanPhamThueId { get; set; }

        public Guid? DoiTacIdno { get; set; }

        public Guid? DoiTacIdco { get; set; }

        public Guid? TaiKhoanNganHangIdno { get; set; }

        public Guid? TaiKhoanNganHangIdco { get; set; }

        public Guid? KhoIdno { get; set; }

        public Guid? SanPhamIdno { get; set; }

        public Guid? MauSacIdno { get; set; }

        public Guid? KichCoIdno { get; set; }

        public Guid? DonViTinhIdno { get; set; }

        public decimal? SoLuongHachToanNo { get; set; }

        public decimal? DonGiaHachToanNo { get; set; }

        public decimal? SoLuongNo { get; set; }

        public decimal? DonGiaNo { get; set; }

        public Guid? KhoIdco { get; set; }

        public Guid? SanPhamIdco { get; set; }

        public Guid? MauSacIdco { get; set; }

        public Guid? KichCoIdco { get; set; }

        public Guid? DonViTinhIdco { get; set; }

        public decimal? SoLuongHachToanCo { get; set; }

        public decimal? DonGiaHachToanCo { get; set; }

        public decimal? SoLuongCo { get; set; }

        public decimal? DonGiaCo { get; set; }

        public bool? IsGiaVonTuDong { get; set; }

        public int? FlagCompleteGiaVon { get; set; }

        public bool? IsDangKyGiaVonNhap { get; set; }

        public Guid? PhanXuongIdno { get; set; }

        public Guid? PhanXuongIdco { get; set; }

        public Guid? ThanhPhamIdno { get; set; }

        public Guid? ThanhPhamIdco { get; set; }

        public Guid? ChiPhiIdno { get; set; }

        public Guid? ChiPhiIdco { get; set; }

        public Guid? KhoanMucIdno { get; set; }

        public Guid? KhoanMucIdco { get; set; }

        public Guid? VuViecIdno { get; set; }

        public Guid? VuViecIdco { get; set; }

        public Guid? CongTrinhIdno { get; set; }

        public Guid? CongTrinhIdco { get; set; }

        public Guid? HangMucIdno { get; set; }

        public Guid? HangMucIdco { get; set; }

        public Guid? TaiSanIdno { get; set; }

        public Guid? TaiSanIdco { get; set; }

        public Guid? LoSanPhamIdno { get; set; }

        public Guid? LoSanPhamIdco { get; set; }

        public Guid? LoSanPhamIdcoGoc { get; set; }

        public Guid? HoaDonId { get; set; }

        public Guid? HoaDonChiTietId { get; set; }

        public Guid? HopDongId { get; set; }

        public Guid? DonHangMuaId { get; set; }

        public Guid? BaoGiaId { get; set; }

        public string? GhiChu { get; set; }

        public string? Tags { get; set; }

        public int? SubLineNo { get; set; }

        public bool? KhongHachToan { get; set; }

        public int? FlagHachToan { get; set; }

        public Guid? ChungTuChiTietIdref { get; set; }

        public bool? IsAuto { get; set; }

        public int? FlagXuLyNghiepVu { get; set; }

        public bool? NotificationAlert { get; set; }

        public DateTime? NotificationDate { get; set; }

        public string? NotificationMessage { get; set; }

        public Guid? NotificationTypeId { get; set; }

        public string? HoaDonMauSo { get; set; }

        public string? HoaDonSoHieu { get; set; }

        public string? HoaDonKyHieu { get; set; }

        public DateTime? HoaDonNgayPhatSinh { get; set; }

        public string? HoaDonTenPhapNhan { get; set; }

        public string? HoaDonDiaChiPhapNhan { get; set; }

        public string? HoaDonMst { get; set; }

        public bool? HoaDonMuaVao { get; set; }

        public bool? HoaDonBanRa { get; set; }

        public Guid? DoiTuongThcpidno { get; set; }

        public Guid? DoiTuongThcpidco { get; set; }

        public int? Stt { get; set; }

        public bool? IsDraft { get; set; }

        public string? SanPhamXuatXu { get; set; }

        public string? SanPhamChatLuong { get; set; }

        public string? MaHopNhat { get; set; }

        public string? MaSanPham { get; set; }

        public string? TenSanPham { get; set; }

        public string? QuyCachGoi { get; set; }

        public Guid? NhomSanPhamId { get; set; }

        public Guid? LoaiSanPhamId { get; set; }

        public long Id { get; set; }

        public long? IdchungTu { get; set; }

        public long? DoiTuongId { get; set; }

    }
}
