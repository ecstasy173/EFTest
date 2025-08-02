using EFCore.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Core.Domain.Dto
{
    public class ChungTuDto
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

        public Guid? ChungTuId { get; set; }

        public long? Stt { get; set; }

        public int? NamTc { get; set; }

        public Guid? KyBaoCaoId { get; set; }

        public string? DataId { get; set; }

        public string? InputId { get; set; }

        public Guid? NghiepVuId { get; set; }

        public Guid? LoaiChungTuId { get; set; }

        public string? SoChungTu { get; set; }

        public decimal? SttchungTu { get; set; }

        public bool? SoHieuTuDong { get; set; }

        public DateTime? NgayPhatSinh { get; set; }

        public DateTime? NgayHachToan { get; set; }

        public string? NoiDungPhatSinh { get; set; }

        public Guid? NguoiGiaoDichId { get; set; }

        public string? TenNguoiGiaoDich { get; set; }

        public string? DienThoaiNguoiGiaoDich { get; set; }

        public string? DiaChiNguoiGiaoDich { get; set; }

        public string? KemTheoChungTu { get; set; }

        public Guid? KhoGiaoDichId { get; set; }

        public Guid? KhoNhapDieuChuyenId { get; set; }

        public Guid? CanBoThucHienId { get; set; }

        public Guid? CanBoPhuTrachId { get; set; }

        public Guid? CanBoGiamSatId { get; set; }

        public Guid? DoiTuongThcpid { get; set; }

        public Guid? TienTeId { get; set; }

        public decimal? TyGia { get; set; }

        public decimal? GiaTriTienNguyenTe { get; set; }

        public decimal? GiaTriTien { get; set; }

        public decimal? TienThue { get; set; }

        public decimal? TongTienChuaThue { get; set; }

        public decimal? TongTienCoThue { get; set; }

        public string? GhiChu { get; set; }

        public string? GiaTriTienBangChu { get; set; }

        public string? KyTenGiamDoc { get; set; }

        public string? KyTenKeToanTruong { get; set; }

        public string? KyTenThuQuy { get; set; }

        public string? KyTenNguoiLapPhieu { get; set; }

        public Guid? VuViecId { get; set; }

        public Guid? HoaDonId { get; set; }

        public Guid? HopDongId { get; set; }

        public Guid? DonHangMuaId { get; set; }

        public Guid? BaoGiaId { get; set; }

        public Guid? DataContactId { get; set; }

        public Guid? TrangThaiChungTuId { get; set; }

        public int? FlagXuLyGiaNhap { get; set; }

        public int? FlagDangKyGiaNhap { get; set; }

        public Guid? ChungTuIdref { get; set; }

        public string? MoTa { get; set; }

        public int? LineNo { get; set; }

        public bool? KhongHachToan { get; set; }

        public bool? IsDraft { get; set; }

        public bool? IsAuto { get; set; }

        public int? FlagApprove { get; set; }

        public int? FlagDataContact { get; set; }

        public bool? CoFileDinhKem { get; set; }

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

        public Guid? SanPhamId { get; set; }

        public Guid? PhanXuongId { get; set; }

        public bool? DaIn { get; set; }

        public DateTime? NgayInChungTu { get; set; }

        public string? SoHopDong { get; set; }

        public DateTime? NgayHopDong { get; set; }

        public Guid? CaLamViecId { get; set; }

        public string? DiaChiBoPhan { get; set; }

        public string? ChucVuNguoiNhan { get; set; }

        public string? KyTenThuKho { get; set; }

        public string? KyTenPhanXuongCoDien { get; set; }

        public long Id { get; set; }

        public long? DoiTuongId { get; set; }
        public virtual ICollection<ChungTuChiTietDto> ChungTuChiTiets { get; set; } = new List<ChungTuChiTietDto>();

    }
}
