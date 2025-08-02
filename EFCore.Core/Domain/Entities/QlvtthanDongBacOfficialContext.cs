using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Core.Domain.Entities;

public partial class QlvtthanDongBacOfficialContext : DbContext
{
    public QlvtthanDongBacOfficialContext()
    {
    }

    public QlvtthanDongBacOfficialContext(DbContextOptions<QlvtthanDongBacOfficialContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BookLocking> BookLockings { get; set; }

    public virtual DbSet<CaLamViec> CaLamViecs { get; set; }

    public virtual DbSet<ChiPhi> ChiPhis { get; set; }

    public virtual DbSet<ChietKhau> ChietKhaus { get; set; }

    public virtual DbSet<ChietKhauChiTiet> ChietKhauChiTiets { get; set; }

    public virtual DbSet<ChucVu> ChucVus { get; set; }

    public virtual DbSet<ChungTu> ChungTus { get; set; }

    public virtual DbSet<ChungTuChiTiet> ChungTuChiTiets { get; set; }

    public virtual DbSet<ChungTuConfig> ChungTuConfigs { get; set; }

    public virtual DbSet<ChungTuNum> ChungTuNums { get; set; }

    public virtual DbSet<ChungTuNumWait> ChungTuNumWaits { get; set; }

    public virtual DbSet<ChungTuPhatSinh> ChungTuPhatSinhs { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<Config> Configs { get; set; }

    public virtual DbSet<DataLogging> DataLoggings { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<DepartmentConfig> DepartmentConfigs { get; set; }

    public virtual DbSet<DinhMucKho> DinhMucKhos { get; set; }

    public virtual DbSet<DinhMucKhoChiTiet> DinhMucKhoChiTiets { get; set; }

    public virtual DbSet<DinhMucNguyenVatLieu> DinhMucNguyenVatLieus { get; set; }

    public virtual DbSet<DinhMucTieuHao> DinhMucTieuHaos { get; set; }

    public virtual DbSet<DinhMucTieuHaoChiTiet> DinhMucTieuHaoChiTiets { get; set; }

    public virtual DbSet<DinhMucTonKho> DinhMucTonKhos { get; set; }

    public virtual DbSet<DoiTac> DoiTacs { get; set; }

    public virtual DbSet<DoiTacDinhMuc> DoiTacDinhMucs { get; set; }

    public virtual DbSet<DoiTacImage> DoiTacImages { get; set; }

    public virtual DbSet<DoiTacThanhToan> DoiTacThanhToans { get; set; }

    public virtual DbSet<DoiTuongThcp> DoiTuongThcps { get; set; }

    public virtual DbSet<DonViTinh> DonViTinhs { get; set; }

    public virtual DbSet<ErrorLogging> ErrorLoggings { get; set; }

    public virtual DbSet<FileDinhKem> FileDinhKems { get; set; }

    public virtual DbSet<HopDong> HopDongs { get; set; }

    public virtual DbSet<HopDongDoiTac> HopDongDoiTacs { get; set; }

    public virtual DbSet<InternalExport> InternalExports { get; set; }

    public virtual DbSet<InternalExportDetail> InternalExportDetails { get; set; }

    public virtual DbSet<Kho> Khos { get; set; }

    public virtual DbSet<KhoSanPham> KhoSanPhams { get; set; }

    public virtual DbSet<KhoSanPhamBackup> KhoSanPhamBackups { get; set; }

    public virtual DbSet<KhoSanPhamBackup2021> KhoSanPhamBackup2021s { get; set; }

    public virtual DbSet<KhoSanPhamC45> KhoSanPhamC45s { get; set; }

    public virtual DbSet<KhoSanPhamC790> KhoSanPhamC790s { get; set; }

    public virtual DbSet<KhoSanPhamCca> KhoSanPhamCcas { get; set; }

    public virtual DbSet<KhoSanPhamCnm> KhoSanPhamCnms { get; set; }

    public virtual DbSet<KhoSanPhamCvt> KhoSanPhamCvts { get; set; }

    public virtual DbSet<KhoSanPhamK> KhoSanPhamKs { get; set; }

    public virtual DbSet<KhoSanPhamKtk> KhoSanPhamKtks { get; set; }

    public virtual DbSet<KhoanMuc> KhoanMucs { get; set; }

    public virtual DbSet<KichCo> KichCos { get; set; }

    public virtual DbSet<KiemKeKho> KiemKeKhos { get; set; }

    public virtual DbSet<KiemKeKhoChiTiet> KiemKeKhoChiTiets { get; set; }

    public virtual DbSet<LoSanPham> LoSanPhams { get; set; }

    public virtual DbSet<LoSanPhamBackup> LoSanPhamBackups { get; set; }

    public virtual DbSet<LoSanPhamBackup2021> LoSanPhamBackup2021s { get; set; }

    public virtual DbSet<LoSanPhamC45> LoSanPhamC45s { get; set; }

    public virtual DbSet<LoSanPhamC790> LoSanPhamC790s { get; set; }

    public virtual DbSet<LoSanPhamCca> LoSanPhamCcas { get; set; }

    public virtual DbSet<LoSanPhamCnm> LoSanPhamCnms { get; set; }

    public virtual DbSet<LoSanPhamCvt> LoSanPhamCvts { get; set; }

    public virtual DbSet<LoSanPhamK> LoSanPhamKs { get; set; }

    public virtual DbSet<LoSanPhamKtk> LoSanPhamKtks { get; set; }

    public virtual DbSet<LoaiChungTu> LoaiChungTus { get; set; }

    public virtual DbSet<LoaiDoiTac> LoaiDoiTacs { get; set; }

    public virtual DbSet<LoaiPhuongTien> LoaiPhuongTiens { get; set; }

    public virtual DbSet<LoaiSanPham> LoaiSanPhams { get; set; }

    public virtual DbSet<LoaiSanPhamTempNum> LoaiSanPhamTempNums { get; set; }

    public virtual DbSet<LoaiTaiKhoan> LoaiTaiKhoans { get; set; }

    public virtual DbSet<LoaiThue> LoaiThues { get; set; }

    public virtual DbSet<MauSac> MauSacs { get; set; }

    public virtual DbSet<MaxDataNumber> MaxDataNumbers { get; set; }

    public virtual DbSet<NghiepVu> NghiepVus { get; set; }

    public virtual DbSet<NguoiGiao> NguoiGiaos { get; set; }

    public virtual DbSet<NguoiNhan> NguoiNhans { get; set; }

    public virtual DbSet<NhatKyChietKhau> NhatKyChietKhaus { get; set; }

    public virtual DbSet<NhatKyChung> NhatKyChungs { get; set; }

    public virtual DbSet<NhatKyKho> NhatKyKhos { get; set; }

    public virtual DbSet<NhomDoiTac> NhomDoiTacs { get; set; }

    public virtual DbSet<NhomDonViTinh> NhomDonViTinhs { get; set; }

    public virtual DbSet<NhomKichCo> NhomKichCos { get; set; }

    public virtual DbSet<NhomLoaiChungTu> NhomLoaiChungTus { get; set; }

    public virtual DbSet<NhomMauSac> NhomMauSacs { get; set; }

    public virtual DbSet<NhomNghiepVu> NhomNghiepVus { get; set; }

    public virtual DbSet<NhomNghiepVuHopDong> NhomNghiepVuHopDongs { get; set; }

    public virtual DbSet<NhomSanPham> NhomSanPhams { get; set; }

    public virtual DbSet<NhomThuocTinh> NhomThuocTinhs { get; set; }

    public virtual DbSet<NoiDungPhieu> NoiDungPhieus { get; set; }

    public virtual DbSet<NotificationType> NotificationTypes { get; set; }

    public virtual DbSet<Permission> Permissions { get; set; }

    public virtual DbSet<Permissiongroup> Permissiongroups { get; set; }

    public virtual DbSet<PhanXuong> PhanXuongs { get; set; }

    public virtual DbSet<PhiGiaoHang> PhiGiaoHangs { get; set; }

    public virtual DbSet<PhuongTien> PhuongTiens { get; set; }

    public virtual DbSet<ReportRecord> ReportRecords { get; set; }

    public virtual DbSet<ReportTemplate> ReportTemplates { get; set; }

    public virtual DbSet<ReportType> ReportTypes { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<RolePermission> RolePermissions { get; set; }

    public virtual DbSet<SanPham> SanPhams { get; set; }

    public virtual DbSet<SanPhamChatLuong> SanPhamChatLuongs { get; set; }

    public virtual DbSet<SanPhamDinhMuc> SanPhamDinhMucs { get; set; }

    public virtual DbSet<SanPhamDonViTinh> SanPhamDonViTinhs { get; set; }

    public virtual DbSet<SanPhamImage> SanPhamImages { get; set; }

    public virtual DbSet<SanPhamKichCo> SanPhamKichCos { get; set; }

    public virtual DbSet<SanPhamMauSac> SanPhamMauSacs { get; set; }

    public virtual DbSet<SanPhamNum> SanPhamNums { get; set; }

    public virtual DbSet<SanPhamUnion> SanPhamUnions { get; set; }

    public virtual DbSet<SanPhamXuatXu> SanPhamXuatXus { get; set; }

    public virtual DbSet<Staff> Staff { get; set; }

    public virtual DbSet<StaffKho> StaffKhos { get; set; }

    public virtual DbSet<SyncConfig> SyncConfigs { get; set; }

    public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }

    public virtual DbSet<ToKiemNhap> ToKiemNhaps { get; set; }

    public virtual DbSet<TongHopKho> TongHopKhos { get; set; }

    public virtual DbSet<TongHopLoSanPham> TongHopLoSanPhams { get; set; }

    public virtual DbSet<TongHopLoSanPhamChiTiet> TongHopLoSanPhamChiTiets { get; set; }

    public virtual DbSet<TongHopLoSanPhamChiTietBackup> TongHopLoSanPhamChiTietBackups { get; set; }

    public virtual DbSet<TongHopLoSanPhamChiTietBackup2021> TongHopLoSanPhamChiTietBackup2021s { get; set; }

    public virtual DbSet<TongHopLoSanPhamChiTietC45> TongHopLoSanPhamChiTietC45s { get; set; }

    public virtual DbSet<TongHopLoSanPhamChiTietC790> TongHopLoSanPhamChiTietC790s { get; set; }

    public virtual DbSet<TongHopLoSanPhamChiTietCca> TongHopLoSanPhamChiTietCcas { get; set; }

    public virtual DbSet<TongHopLoSanPhamChiTietCnm> TongHopLoSanPhamChiTietCnms { get; set; }

    public virtual DbSet<TongHopLoSanPhamChiTietCvt> TongHopLoSanPhamChiTietCvts { get; set; }

    public virtual DbSet<TongHopLoSanPhamChiTietK> TongHopLoSanPhamChiTietKs { get; set; }

    public virtual DbSet<TongHopLoSanPhamChiTietKtk> TongHopLoSanPhamChiTietKtks { get; set; }

    public virtual DbSet<TransactionDatum> TransactionData { get; set; }

    public virtual DbSet<UserRole> UserRoles { get; set; }

    public virtual DbSet<Userdatum> Userdata { get; set; }

    public virtual DbSet<WarehouseConfig> WarehouseConfigs { get; set; }

    public virtual DbSet<XuLyKiemKe> XuLyKiemKes { get; set; }

    public virtual DbSet<XuLyKiemKeChiTiet> XuLyKiemKeChiTiets { get; set; }

    public virtual DbSet<YeuToChiPhi> YeuToChiPhis { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DuongDepTrai\\MSSQLSERVER01;Database=QLVTThanDongBacOfficial;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BookLocking>(entity =>
        {
            entity.ToTable("BookLocking");

            entity.Property(e => e.BookLockingId)
                .ValueGeneratedNever()
                .HasColumnName("BookLockingID");
            entity.Property(e => e.DonViId).HasColumnName("DonViID");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.GhiChu).HasMaxLength(500);
            entity.Property(e => e.KhoId).HasColumnName("KhoID");
            entity.Property(e => e.LockingEndDay).HasColumnType("datetime");
            entity.Property(e => e.LockingStartDay).HasColumnType("datetime");
            entity.Property(e => e.NgayThucHien).HasColumnType("datetime");
            entity.Property(e => e.NguoiKhoaSoId).HasColumnName("NguoiKhoaSoID");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
        });

        modelBuilder.Entity<CaLamViec>(entity =>
        {
            entity.ToTable("CaLamViec");

            entity.HasIndex(e => new { e.MaSo, e.SsClientId }, "IX_CaLamViec_UI1").IsUnique();

            entity.Property(e => e.CaLamViecId)
                .ValueGeneratedNever()
                .HasColumnName("CaLamViecID");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.MaSo).HasMaxLength(50);
            entity.Property(e => e.PhanXuongId).HasColumnName("PhanXuongID");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TenCaLamViec).HasMaxLength(300);
            entity.Property(e => e.ValidTo).HasColumnType("datetime");
        });

        modelBuilder.Entity<ChiPhi>(entity =>
        {
            entity.ToTable("ChiPhi");

            entity.HasIndex(e => new { e.DraftId, e.MaSo }, "IX_ChiPhi_UI1").IsUnique();

            entity.HasIndex(e => new { e.DraftId, e.TenChiPhi, e.DonViId }, "IX_ChiPhi_UI2").IsUnique();

            entity.Property(e => e.ChiPhiId)
                .ValueGeneratedNever()
                .HasColumnName("ChiPhiID");
            entity.Property(e => e.DonViId).HasColumnName("DonViID");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.MaSo).HasMaxLength(50);
            entity.Property(e => e.ParentId).HasColumnName("ParentID");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TenChiPhi).HasMaxLength(300);
            entity.Property(e => e.TinhChatChiPhiId).HasColumnName("TinhChatChiPhiID");
            entity.Property(e => e.ValidTo).HasColumnType("datetime");
        });

        modelBuilder.Entity<ChietKhau>(entity =>
        {
            entity.ToTable("ChietKhau");

            entity.Property(e => e.ChietKhauId).HasColumnName("ChietKhauID");
            entity.Property(e => e.DoiTacId).HasColumnName("DoiTacID");
            entity.Property(e => e.DonViId).HasColumnName("DonViID");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.GhiChu).HasMaxLength(512);
            entity.Property(e => e.HoaDonKyHieu).HasMaxLength(50);
            entity.Property(e => e.HoaDonMauSo).HasMaxLength(50);
            entity.Property(e => e.HoaDonNgayPhatSinh).HasColumnType("datetime");
            entity.Property(e => e.HoaDonSoHieu).HasMaxLength(50);
            entity.Property(e => e.KemTheoChungTu).HasMaxLength(150);
            entity.Property(e => e.KhoGiaoDichId).HasColumnName("KhoGiaoDichID");
            entity.Property(e => e.KyTenNguoiLapPhieu).HasMaxLength(150);
            entity.Property(e => e.NgayHopDong).HasColumnType("datetime");
            entity.Property(e => e.NgayPhatSinh).HasColumnType("datetime");
            entity.Property(e => e.NoiDungPhatSinh).HasMaxLength(512);
            entity.Property(e => e.SoChungTu).HasMaxLength(50);
            entity.Property(e => e.SoHopDong).HasMaxLength(50);
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TenNguoiGiaoDich).HasMaxLength(150);
            entity.Property(e => e.TienThue).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TongTienChuaThue).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TongTienCoThue).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<ChietKhauChiTiet>(entity =>
        {
            entity.ToTable("ChietKhauChiTiet");

            entity.Property(e => e.ChietKhauChiTietId).HasColumnName("ChietKhauChiTietID");
            entity.Property(e => e.ChietKhauId).HasColumnName("ChietKhauID");
            entity.Property(e => e.DonGiaLo).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DonViId).HasColumnName("DonViID");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.GiaTriTon).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.KhoGiaoDichId).HasColumnName("KhoGiaoDichID");
            entity.Property(e => e.KhoSanPhamId).HasColumnName("KhoSanPhamID");
            entity.Property(e => e.NgayPhatSinh).HasColumnType("datetime");
            entity.Property(e => e.NoiDungChiTiet).HasMaxLength(512);
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.SoLuongTon).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.ThanhTienChuaThue).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ThanhTienCoThue).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<ChucVu>(entity =>
        {
            entity.ToTable("ChucVu");

            entity.HasIndex(e => new { e.DraftId, e.MaSo }, "IX_ChucVu_UI1").IsUnique();

            entity.HasIndex(e => new { e.DraftId, e.TenChucVu }, "IX_ChucVu_UI2").IsUnique();

            entity.Property(e => e.ChucVuId)
                .ValueGeneratedNever()
                .HasColumnName("ChucVuID");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.MaSo).HasMaxLength(50);
            entity.Property(e => e.ParentId).HasColumnName("ParentID");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TenChucVu).HasMaxLength(300);
            entity.Property(e => e.ValidTo).HasColumnType("datetime");
        });

        modelBuilder.Entity<ChungTu>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.ToTable("ChungTu");

            entity.HasIndex(e => new { e.SsClientId, e.LoaiChungTuId, e.KhoGiaoDichId, e.DoiTuongThcpid, e.NgayPhatSinh }, "IDX_DoiTuongCP").IsDescending(false, false, false, false, true);

            entity.HasIndex(e => new { e.NgayPhatSinh, e.DoiTuongId }, "IDX_DoiTuongID");

            entity.HasIndex(e => e.NgayPhatSinh, "IX_ChungTu_NgayPhatSinh").IsClustered();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BaoGiaId).HasColumnName("BaoGiaID");
            entity.Property(e => e.CaLamViecId).HasColumnName("CaLamViecID");
            entity.Property(e => e.CanBoGiamSatId).HasColumnName("CanBoGiamSatID");
            entity.Property(e => e.CanBoPhuTrachId).HasColumnName("CanBoPhuTrachID");
            entity.Property(e => e.CanBoThucHienId).HasColumnName("CanBoThucHienID");
            entity.Property(e => e.ChucVuNguoiNhan).HasMaxLength(150);
            entity.Property(e => e.ChungTuId).HasColumnName("ChungTuID");
            entity.Property(e => e.ChungTuIdref).HasColumnName("ChungTuIDRef");
            entity.Property(e => e.DataContactId).HasColumnName("DataContactID");
            entity.Property(e => e.DataId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DataID");
            entity.Property(e => e.DiaChiBoPhan).HasMaxLength(150);
            entity.Property(e => e.DiaChiNguoiGiaoDich).HasMaxLength(200);
            entity.Property(e => e.DienThoaiNguoiGiaoDich).HasMaxLength(200);
            entity.Property(e => e.DoiTuongId).HasColumnName("DoiTuongID");
            entity.Property(e => e.DoiTuongThcpid).HasColumnName("DoiTuongTHCPID");
            entity.Property(e => e.DonHangMuaId).HasColumnName("DonHangMuaID");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.GhiChu).HasMaxLength(500);
            entity.Property(e => e.GiaTriTien).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GiaTriTienBangChu).HasMaxLength(500);
            entity.Property(e => e.GiaTriTienNguyenTe).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.HoaDonDiaChiPhapNhan).HasMaxLength(300);
            entity.Property(e => e.HoaDonId).HasColumnName("HoaDonID");
            entity.Property(e => e.HoaDonKyHieu).HasMaxLength(50);
            entity.Property(e => e.HoaDonMauSo).HasMaxLength(50);
            entity.Property(e => e.HoaDonMst)
                .HasMaxLength(50)
                .HasColumnName("HoaDonMST");
            entity.Property(e => e.HoaDonNgayPhatSinh).HasColumnType("datetime");
            entity.Property(e => e.HoaDonSoHieu).HasMaxLength(100);
            entity.Property(e => e.HoaDonTenPhapNhan).HasMaxLength(300);
            entity.Property(e => e.HopDongId).HasColumnName("HopDongID");
            entity.Property(e => e.InputId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("InputID");
            entity.Property(e => e.KemTheoChungTu).HasMaxLength(500);
            entity.Property(e => e.KhoGiaoDichId).HasColumnName("KhoGiaoDichID");
            entity.Property(e => e.KhoNhapDieuChuyenId).HasColumnName("KhoNhapDieuChuyenID");
            entity.Property(e => e.KyBaoCaoId).HasColumnName("KyBaoCaoID");
            entity.Property(e => e.KyTenGiamDoc).HasMaxLength(300);
            entity.Property(e => e.KyTenKeToanTruong).HasMaxLength(300);
            entity.Property(e => e.KyTenNguoiLapPhieu).HasMaxLength(300);
            entity.Property(e => e.KyTenPhanXuongCoDien).HasMaxLength(150);
            entity.Property(e => e.KyTenThuKho).HasMaxLength(150);
            entity.Property(e => e.KyTenThuQuy).HasMaxLength(300);
            entity.Property(e => e.LoaiChungTuId).HasColumnName("LoaiChungTuID");
            entity.Property(e => e.NamTc).HasColumnName("NamTC");
            entity.Property(e => e.NgayHachToan).HasColumnType("datetime");
            entity.Property(e => e.NgayHopDong).HasColumnType("datetime");
            entity.Property(e => e.NgayInChungTu).HasColumnType("datetime");
            entity.Property(e => e.NgayPhatSinh).HasColumnType("datetime");
            entity.Property(e => e.NghiepVuId).HasColumnName("NghiepVuID");
            entity.Property(e => e.NguoiGiaoDichId).HasColumnName("NguoiGiaoDichID");
            entity.Property(e => e.NoiDungPhatSinh).HasMaxLength(500);
            entity.Property(e => e.NotificationDate).HasColumnType("datetime");
            entity.Property(e => e.NotificationTypeId).HasColumnName("NotificationTypeID");
            entity.Property(e => e.PhanXuongId).HasColumnName("PhanXuongID");
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.SoChungTu).HasMaxLength(100);
            entity.Property(e => e.SoHopDong).HasMaxLength(200);
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.Stt).HasColumnName("STT");
            entity.Property(e => e.SttchungTu)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("STTChungTu");
            entity.Property(e => e.TenNguoiGiaoDich).HasMaxLength(200);
            entity.Property(e => e.TienTeId).HasColumnName("TienTeID");
            entity.Property(e => e.TienThue).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.TongTienChuaThue).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.TongTienCoThue).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.TrangThaiChungTuId).HasColumnName("TrangThaiChungTuID");
            entity.Property(e => e.TyGia).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.VuViecId).HasColumnName("VuViecID");
        });

        modelBuilder.Entity<ChungTuChiTiet>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.ToTable("ChungTuChiTiet");

            entity.HasIndex(e => new { e.NgayPhatSinh, e.IdchungTu }, "IDX_ChungTuID");

            entity.HasIndex(e => new { e.NgayPhatSinh, e.ChungTuId, e.DoiTuongThcpidco }, "IDX_DoiTuongCP");

            entity.HasIndex(e => new { e.NgayPhatSinh, e.SanPhamIdco }, "IDX_SanPhamCo");

            entity.HasIndex(e => new { e.NgayPhatSinh, e.SanPhamIdno }, "IDX_SanPhamIDNo");

            entity.HasIndex(e => e.NgayPhatSinh, "IX_ChungTuChiTiet_NgayPhatSinh").IsClustered();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BaoGiaId).HasColumnName("BaoGiaID");
            entity.Property(e => e.ChiPhiIdco).HasColumnName("ChiPhiIDCo");
            entity.Property(e => e.ChiPhiIdno).HasColumnName("ChiPhiIDNo");
            entity.Property(e => e.ChungTuChiTietId).HasColumnName("ChungTuChiTietID");
            entity.Property(e => e.ChungTuChiTietIdref).HasColumnName("ChungTuChiTietIDRef");
            entity.Property(e => e.ChungTuId).HasColumnName("ChungTuID");
            entity.Property(e => e.CongTrinhIdco).HasColumnName("CongTrinhIDCo");
            entity.Property(e => e.CongTrinhIdno).HasColumnName("CongTrinhIDNo");
            entity.Property(e => e.DoiTacIdco).HasColumnName("DoiTacIDCo");
            entity.Property(e => e.DoiTacIdno).HasColumnName("DoiTacIDNo");
            entity.Property(e => e.DoiTuongId).HasColumnName("DoiTuongID");
            entity.Property(e => e.DoiTuongThcpidco).HasColumnName("DoiTuongTHCPIDCo");
            entity.Property(e => e.DoiTuongThcpidno).HasColumnName("DoiTuongTHCPIDNo");
            entity.Property(e => e.DonGiaCo).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DonGiaHachToanCo).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DonGiaHachToanNo).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DonGiaNo).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DonHangMuaId).HasColumnName("DonHangMuaID");
            entity.Property(e => e.DonViTinhIdco).HasColumnName("DonViTinhIDCo");
            entity.Property(e => e.DonViTinhIdno).HasColumnName("DonViTinhIDNo");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.GhiChu).HasMaxLength(200);
            entity.Property(e => e.HangMucIdco).HasColumnName("HangMucIDCo");
            entity.Property(e => e.HangMucIdno).HasColumnName("HangMucIDNo");
            entity.Property(e => e.HoaDonChiTietId).HasColumnName("HoaDonChiTietID");
            entity.Property(e => e.HoaDonDiaChiPhapNhan).HasMaxLength(300);
            entity.Property(e => e.HoaDonId).HasColumnName("HoaDonID");
            entity.Property(e => e.HoaDonKyHieu).HasMaxLength(50);
            entity.Property(e => e.HoaDonMauSo).HasMaxLength(50);
            entity.Property(e => e.HoaDonMst)
                .HasMaxLength(50)
                .HasColumnName("HoaDonMST");
            entity.Property(e => e.HoaDonNgayPhatSinh).HasColumnType("datetime");
            entity.Property(e => e.HoaDonSoHieu).HasMaxLength(50);
            entity.Property(e => e.HoaDonTenPhapNhan).HasMaxLength(300);
            entity.Property(e => e.HopDongId).HasColumnName("HopDongID");
            entity.Property(e => e.IdchungTu).HasColumnName("IDChungTu");
            entity.Property(e => e.IsHachToanThueGtgt).HasColumnName("IsHachToanThueGTGT");
            entity.Property(e => e.IsKeKhaiThueGtgt).HasColumnName("IsKeKhaiThueGTGT");
            entity.Property(e => e.KhoIdco).HasColumnName("KhoIDCo");
            entity.Property(e => e.KhoIdno).HasColumnName("KhoIDNo");
            entity.Property(e => e.KhoanMucIdco).HasColumnName("KhoanMucIDCo");
            entity.Property(e => e.KhoanMucIdno).HasColumnName("KhoanMucIDNo");
            entity.Property(e => e.KichCoIdco).HasColumnName("KichCoIDCo");
            entity.Property(e => e.KichCoIdno).HasColumnName("KichCoIDNo");
            entity.Property(e => e.KyBaoCaoId).HasColumnName("KyBaoCaoID");
            entity.Property(e => e.LoSanPhamIdco).HasColumnName("LoSanPhamIDCo");
            entity.Property(e => e.LoSanPhamIdcoGoc).HasColumnName("LoSanPhamIDCoGoc");
            entity.Property(e => e.LoSanPhamIdno).HasColumnName("LoSanPhamIDNo");
            entity.Property(e => e.LoaiChungTuId).HasColumnName("LoaiChungTuID");
            entity.Property(e => e.LoaiSanPhamId).HasColumnName("LoaiSanPhamID");
            entity.Property(e => e.MaHopNhat).HasMaxLength(50);
            entity.Property(e => e.MaSanPham).HasMaxLength(50);
            entity.Property(e => e.MauSacIdco).HasColumnName("MauSacIDCo");
            entity.Property(e => e.MauSacIdno).HasColumnName("MauSacIDNo");
            entity.Property(e => e.MucThueSuatId).HasColumnName("MucThueSuatID");
            entity.Property(e => e.NamTc).HasColumnName("NamTC");
            entity.Property(e => e.NgayPhanBoBatDauCo).HasColumnType("datetime");
            entity.Property(e => e.NgayPhanBoBatDauNo).HasColumnType("datetime");
            entity.Property(e => e.NgayPhanBoKetThucCo).HasColumnType("datetime");
            entity.Property(e => e.NgayPhanBoKetThucNo).HasColumnType("datetime");
            entity.Property(e => e.NgayPhatSinh).HasColumnType("datetime");
            entity.Property(e => e.NghiepVuId).HasColumnName("NghiepVuID");
            entity.Property(e => e.NghiepVuThueId).HasColumnName("NghiepVuThueID");
            entity.Property(e => e.NhomKeKhaiThueId).HasColumnName("NhomKeKhaiThueID");
            entity.Property(e => e.NhomSanPhamId).HasColumnName("NhomSanPhamID");
            entity.Property(e => e.NoiDungChiTiet).HasMaxLength(1000);
            entity.Property(e => e.NotificationDate).HasColumnType("datetime");
            entity.Property(e => e.NotificationTypeId).HasColumnName("NotificationTypeID");
            entity.Property(e => e.PhanXuongIdco).HasColumnName("PhanXuongIDCo");
            entity.Property(e => e.PhanXuongIdno).HasColumnName("PhanXuongIDNo");
            entity.Property(e => e.QuyCachGoi).HasMaxLength(50);
            entity.Property(e => e.SanPhamChatLuong).HasMaxLength(250);
            entity.Property(e => e.SanPhamIdco).HasColumnName("SanPhamIDCo");
            entity.Property(e => e.SanPhamIdno).HasColumnName("SanPhamIDNo");
            entity.Property(e => e.SanPhamThueId).HasColumnName("SanPhamThueID");
            entity.Property(e => e.SanPhamXuatXu).HasMaxLength(250);
            entity.Property(e => e.SoLuongCo).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongHachToanCo).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongHachToanNo).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongNo).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.Stt).HasColumnName("STT");
            entity.Property(e => e.TaiKhoanIdco).HasColumnName("TaiKhoanIDCo");
            entity.Property(e => e.TaiKhoanIdno).HasColumnName("TaiKhoanIDNo");
            entity.Property(e => e.TaiKhoanIdthueCo).HasColumnName("TaiKhoanIDThueCo");
            entity.Property(e => e.TaiKhoanIdthueNo).HasColumnName("TaiKhoanIDThueNo");
            entity.Property(e => e.TaiKhoanNganHangIdco).HasColumnName("TaiKhoanNganHangIDCo");
            entity.Property(e => e.TaiKhoanNganHangIdno).HasColumnName("TaiKhoanNganHangIDNo");
            entity.Property(e => e.TaiSanIdco).HasColumnName("TaiSanIDCo");
            entity.Property(e => e.TaiSanIdno).HasColumnName("TaiSanIDNo");
            entity.Property(e => e.TenSanPham).HasMaxLength(500);
            entity.Property(e => e.ThanhPhamIdco).HasColumnName("ThanhPhamIDCo");
            entity.Property(e => e.ThanhPhamIdno).HasColumnName("ThanhPhamIDNo");
            entity.Property(e => e.ThanhTienChuaThue).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.ThanhTienChungTu).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.ThanhTienCoThue).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.ThanhTienNguyenTe).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.ThueSuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.TienTeId).HasColumnName("TienTeID");
            entity.Property(e => e.TienThue).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.TyGia).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.VuViecIdco).HasColumnName("VuViecIDCo");
            entity.Property(e => e.VuViecIdno).HasColumnName("VuViecIDNo");
            entity.HasOne(ctct => ctct.ChungTu)
          .WithMany(ct => ct.ChungTuChiTiets)
          .HasForeignKey(ctct => ctct.IdchungTu);
        });

        modelBuilder.Entity<ChungTuConfig>(entity =>
        {
            entity.ToTable("ChungTuConfig");

            entity.HasIndex(e => e.LoaiChungTuId, "IX_ChungTuConfig_UI1").IsUnique();

            entity.Property(e => e.ChungTuConfigId)
                .ValueGeneratedNever()
                .HasColumnName("ChungTuConfigID");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.InputId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("InputID");
            entity.Property(e => e.LoaiChungTuId).HasColumnName("LoaiChungTuID");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.ValidTo).HasColumnType("datetime");
        });

        modelBuilder.Entity<ChungTuNum>(entity =>
        {
            entity.ToTable("ChungTuNum");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CurrentNum).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DonViId).HasColumnName("DonViID");
            entity.Property(e => e.Format).HasMaxLength(20);
            entity.Property(e => e.KhoId).HasColumnName("KhoID");
            entity.Property(e => e.LoaiChungTu).HasMaxLength(100);
            entity.Property(e => e.LoaiChungTuId).HasColumnName("LoaiChungTuID");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.StartNum).HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<ChungTuNumWait>(entity =>
        {
            entity.ToTable("ChungTuNumWait");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.KhoId).HasColumnName("KhoID");
            entity.Property(e => e.LoaiChungTuId).HasColumnName("LoaiChungTuID");
            entity.Property(e => e.SoChungTu).HasMaxLength(100);
            entity.Property(e => e.SttChungTu).HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<ChungTuPhatSinh>(entity =>
        {
            entity.ToTable("ChungTuPhatSinh");

            entity.HasIndex(e => new { e.DraftId, e.NamTc, e.LoaiChungTuId, e.SoChungTu }, "IX_ChungTuPhatSinh_UI1").IsUnique();

            entity.Property(e => e.ChungTuPhatSinhId)
                .ValueGeneratedNever()
                .HasColumnName("ChungTuPhatSinhID");
            entity.Property(e => e.DataId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DataID");
            entity.Property(e => e.DiaChiNguoiGiaoDich).HasMaxLength(200);
            entity.Property(e => e.DienThoaiNguoiGiaoDich).HasMaxLength(200);
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.GhiChu).HasMaxLength(500);
            entity.Property(e => e.GiaTriTienBangChu).HasMaxLength(500);
            entity.Property(e => e.GiaTriTienNguyenTe).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.HinhThucThanhToanId).HasColumnName("HinhThucThanhToanID");
            entity.Property(e => e.HoaDonId).HasColumnName("HoaDonID");
            entity.Property(e => e.InputId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("InputID");
            entity.Property(e => e.KemTheoChungTu).HasMaxLength(500);
            entity.Property(e => e.LoaiChungTuId).HasColumnName("LoaiChungTuID");
            entity.Property(e => e.NamTc).HasColumnName("NamTC");
            entity.Property(e => e.NgayHachToan).HasColumnType("datetime");
            entity.Property(e => e.NgayPhatSinh).HasColumnType("datetime");
            entity.Property(e => e.NguoiGiaoDichId).HasColumnName("NguoiGiaoDichID");
            entity.Property(e => e.NoiDungPhatSinh).HasMaxLength(500);
            entity.Property(e => e.SoChungTu).HasMaxLength(100);
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TenNguoiGiaoDich).HasMaxLength(200);
            entity.Property(e => e.TienChuaThue).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TienCoThue).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TienTeId).HasColumnName("TienTeID");
            entity.Property(e => e.TienThue).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TrangThaiId).HasColumnName("TrangThaiID");
        });

        modelBuilder.Entity<Company>(entity =>
        {
            entity.ToTable("Company");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountName).HasMaxLength(64);
            entity.Property(e => e.Address).HasMaxLength(250);
            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.Domain).HasMaxLength(250);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Fax).HasMaxLength(50);
            entity.Property(e => e.Fkey)
                .HasMaxLength(64)
                .HasColumnName("FKey");
            entity.Property(e => e.Name).HasMaxLength(150);
            entity.Property(e => e.ParentId).HasColumnName("ParentID");
            entity.Property(e => e.ParentName).HasMaxLength(150);
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.TaxCode).HasMaxLength(150);
        });

        modelBuilder.Entity<Config>(entity =>
        {
            entity.ToTable("Config");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.ComId).HasColumnName("ComID");
            entity.Property(e => e.Name).HasMaxLength(150);
            entity.Property(e => e.Value).HasColumnType("ntext");
        });

        modelBuilder.Entity<DataLogging>(entity =>
        {
            entity.ToTable("DataLogging");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ActionType).HasMaxLength(500);
            entity.Property(e => e.ComputerIp).HasColumnName("ComputerIP");
            entity.Property(e => e.ComputerName).HasMaxLength(100);
            entity.Property(e => e.DataLoggingCode).HasMaxLength(100);
            entity.Property(e => e.DataRecordId).HasColumnName("DataRecordID");
            entity.Property(e => e.DataTypeId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DataTypeID");
            entity.Property(e => e.NgayUpdate).HasColumnType("datetime");
            entity.Property(e => e.PositionGps).HasColumnName("PositionGPS");
            entity.Property(e => e.SourceType).HasMaxLength(100);
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.UserId)
                .HasMaxLength(100)
                .HasColumnName("UserID");
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.ToTable("Department");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Address).HasMaxLength(250);
            entity.Property(e => e.ChungTuNhieuDtcp).HasColumnName("ChungTuNhieuDTCP");
            entity.Property(e => e.Code).HasMaxLength(64);
            entity.Property(e => e.ComId).HasColumnName("ComID");
            entity.Property(e => e.DoiTuongChiPhiKhongTheoPx).HasColumnName("DoiTuongChiPhiKhongTheoPX");
            entity.Property(e => e.Email).HasMaxLength(150);
            entity.Property(e => e.Manager).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(150);
            entity.Property(e => e.ParentId).HasColumnName("ParentID");
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.Policy).HasMaxLength(512);
            entity.Property(e => e.RootId).HasColumnName("RootID");
        });

        modelBuilder.Entity<DepartmentConfig>(entity =>
        {
            entity.ToTable("DepartmentConfig");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.DeptId).HasColumnName("DeptID");
            entity.Property(e => e.KhoId).HasColumnName("KhoID");
            entity.Property(e => e.Name).HasMaxLength(150);
            entity.Property(e => e.Value).HasMaxLength(1024);
        });

        modelBuilder.Entity<DinhMucKho>(entity =>
        {
            entity.ToTable("DinhMucKho");

            entity.HasIndex(e => new { e.DraftId, e.NamPs, e.SoHieu }, "IX_DinhMucKho_UI1").IsUnique();

            entity.Property(e => e.DinhMucKhoId)
                .ValueGeneratedNever()
                .HasColumnName("DinhMucKhoID");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.GhiChu).HasMaxLength(200);
            entity.Property(e => e.InputId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("InputID");
            entity.Property(e => e.KhoId).HasColumnName("KhoID");
            entity.Property(e => e.NamPs).HasColumnName("NamPS");
            entity.Property(e => e.NgayHieuLucBatDau).HasColumnType("datetime");
            entity.Property(e => e.NgayHieuLucKetThuc).HasColumnType("datetime");
            entity.Property(e => e.NgayPhatSinh).HasColumnType("datetime");
            entity.Property(e => e.SoHieu).HasMaxLength(50);
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TaiKhoanKhoId).HasColumnName("TaiKhoanKhoID");
        });

        modelBuilder.Entity<DinhMucKhoChiTiet>(entity =>
        {
            entity.ToTable("DinhMucKhoChiTiet");

            entity.Property(e => e.DinhMucKhoChiTietId)
                .ValueGeneratedNever()
                .HasColumnName("DinhMucKhoChiTietID");
            entity.Property(e => e.BienCanhBaoSoLuongToiDa).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.BienCanhBaoSoLuongToiThieu).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.BienCanhBaoTyLeToiDa).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.BienCanhBaoTyLeToiThieu).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DinhMucKhoId).HasColumnName("DinhMucKhoID");
            entity.Property(e => e.DonGia).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.GhiChu).HasMaxLength(500);
            entity.Property(e => e.GiaTriToiDa).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.GiaTriToiThieu).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.KhoId).HasColumnName("KhoID");
            entity.Property(e => e.NamPs).HasColumnName("NamPS");
            entity.Property(e => e.NgayPhatSinh).HasColumnType("datetime");
            entity.Property(e => e.SanPhamDonViTinhId).HasColumnName("SanPhamDonViTinhID");
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.SoLuongToiDa).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongToiThieu).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TaiKhoanKhoId).HasColumnName("TaiKhoanKhoID");
        });

        modelBuilder.Entity<DinhMucNguyenVatLieu>(entity =>
        {
            entity.ToTable("DinhMucNguyenVatLieu");

            entity.HasIndex(e => new { e.DraftId, e.ThanhPhamId, e.ChiPhiId, e.NguyenVatLieuId }, "IX_DinhMucNguyenVatLieu_UI1").IsUnique();

            entity.Property(e => e.DinhMucNguyenVatLieuId)
                .ValueGeneratedNever()
                .HasColumnName("DinhMucNguyenVatLieuID");
            entity.Property(e => e.ChiPhiId).HasColumnName("ChiPhiID");
            entity.Property(e => e.DonGia).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.GiaTriTien).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.NamPs).HasColumnName("NamPS");
            entity.Property(e => e.NguyenVatLieuId).HasColumnName("NguyenVatLieuID");
            entity.Property(e => e.SoLuong).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.ThanhPhamId).HasColumnName("ThanhPhamID");
        });

        modelBuilder.Entity<DinhMucTieuHao>(entity =>
        {
            entity.ToTable("DinhMucTieuHao");

            entity.Property(e => e.DinhMucTieuHaoId)
                .ValueGeneratedNever()
                .HasColumnName("DinhMucTieuHaoID");
            entity.Property(e => e.DoiTuongThcpid).HasColumnName("DoiTuongTHCPID");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.GhiChu).HasMaxLength(200);
            entity.Property(e => e.KeHoachNamId).HasColumnName("KeHoachNamID");
            entity.Property(e => e.NamPs).HasColumnName("NamPS");
            entity.Property(e => e.NgayHieuLucBatDau).HasColumnType("datetime");
            entity.Property(e => e.NgayHieuLucKetThuc).HasColumnType("datetime");
            entity.Property(e => e.NgayPhatSinh).HasColumnType("datetime");
            entity.Property(e => e.PhanXuongId).HasColumnName("PhanXuongID");
            entity.Property(e => e.SoHieu).HasMaxLength(50);
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.ThangPs).HasColumnName("ThangPS");
        });

        modelBuilder.Entity<DinhMucTieuHaoChiTiet>(entity =>
        {
            entity.ToTable("DinhMucTieuHaoChiTiet");

            entity.Property(e => e.DinhMucTieuHaoChiTietId)
                .ValueGeneratedNever()
                .HasColumnName("DinhMucTieuHaoChiTietID");
            entity.Property(e => e.DinhMuc).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DinhMucTieuHaoId).HasColumnName("DinhMucTieuHaoID");
            entity.Property(e => e.DoiTuongId).HasColumnName("DoiTuongID");
            entity.Property(e => e.DoiTuongThcpid).HasColumnName("DoiTuongTHCPID");
            entity.Property(e => e.DonGia).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DonGiaTk)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("DonGiaTK");
            entity.Property(e => e.DonViTinh).HasMaxLength(50);
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.GhiChu).HasMaxLength(500);
            entity.Property(e => e.KhoId).HasColumnName("KhoID");
            entity.Property(e => e.KhoiLuongCongViec).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.KhoiLuongTk)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("KhoiLuongTK");
            entity.Property(e => e.LoaiSanPhamId).HasColumnName("LoaiSanPhamID");
            entity.Property(e => e.NamPs).HasColumnName("NamPS");
            entity.Property(e => e.NgayPhatSinh).HasColumnType("datetime");
            entity.Property(e => e.NhomSanPhamId).HasColumnName("NhomSanPhamID");
            entity.Property(e => e.NhuCau).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.PhanXuongId).HasColumnName("PhanXuongID");
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.ThangPs).HasColumnName("ThangPS");
            entity.Property(e => e.ThanhTien).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.YeuToChiPhi).HasMaxLength(250);
            entity.Property(e => e.YeuToChiPhiId).HasColumnName("YeuToChiPhiID");
        });

        modelBuilder.Entity<DinhMucTonKho>(entity =>
        {
            entity.ToTable("DinhMucTonKho");

            entity.HasIndex(e => new { e.TaiKhoanId, e.KhoId, e.SanPhamId }, "IX_DinhMucTonKho_UI1").IsUnique();

            entity.Property(e => e.DinhMucTonKhoId)
                .ValueGeneratedNever()
                .HasColumnName("DinhMucTonKhoID");
            entity.Property(e => e.DonGia).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.GhiChu).HasMaxLength(500);
            entity.Property(e => e.GiaTriToiDa).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.GiaTriToiThieu).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.KhoId).HasColumnName("KhoID");
            entity.Property(e => e.KhoSanPhamId).HasColumnName("KhoSanPhamID");
            entity.Property(e => e.KichCoId).HasColumnName("KichCoID");
            entity.Property(e => e.KyBaoCaoId).HasColumnName("KyBaoCaoID");
            entity.Property(e => e.MauSacId).HasColumnName("MauSacID");
            entity.Property(e => e.NamTc).HasColumnName("NamTC");
            entity.Property(e => e.NgayThietLap).HasColumnType("datetime");
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.SoLuongToiDa).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongToiThieu).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TaiKhoanId).HasColumnName("TaiKhoanID");
        });

        modelBuilder.Entity<DoiTac>(entity =>
        {
            entity.ToTable("DoiTac");

            entity.Property(e => e.DoiTacId)
                .ValueGeneratedNever()
                .HasColumnName("DoiTacID");
            entity.Property(e => e.BoPhanId).HasColumnName("BoPhanID");
            entity.Property(e => e.ChiNhanhNganHangId).HasColumnName("ChiNhanhNganHangID");
            entity.Property(e => e.ChucVuId).HasColumnName("ChucVuID");
            entity.Property(e => e.Cmnd)
                .HasMaxLength(100)
                .HasColumnName("CMND");
            entity.Property(e => e.CmndngayCap)
                .HasColumnType("datetime")
                .HasColumnName("CMNDNgayCap");
            entity.Property(e => e.CmndnoiCap)
                .HasMaxLength(100)
                .HasColumnName("CMNDNoiCap");
            entity.Property(e => e.DataContactId).HasColumnName("DataContactID");
            entity.Property(e => e.DiaChi).HasMaxLength(500);
            entity.Property(e => e.DiaChiNguoiGiaoDich).HasMaxLength(500);
            entity.Property(e => e.DiaChiNhanHang).HasMaxLength(600);
            entity.Property(e => e.DiaChiPhapNhan).HasMaxLength(2000);
            entity.Property(e => e.DienThoai).HasMaxLength(100);
            entity.Property(e => e.DienThoaiNguoiGiaoDich).HasMaxLength(100);
            entity.Property(e => e.DonViId).HasColumnName("DonViID");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.EmailNguoiGiaoDich).HasMaxLength(100);
            entity.Property(e => e.GhiChu).HasMaxLength(300);
            entity.Property(e => e.Gpsaddress)
                .HasMaxLength(600)
                .HasColumnName("GPSAddress");
            entity.Property(e => e.Gpslatitude)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GPSLatitude");
            entity.Property(e => e.Gpslongitude)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GPSLongitude");
            entity.Property(e => e.Gpsname)
                .HasMaxLength(200)
                .HasColumnName("GPSName");
            entity.Property(e => e.HeSoBaoHiem).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.HinhThucGiaoNhanId).HasColumnName("HinhThucGiaoNhanID");
            entity.Property(e => e.HinhThucThanhToanBanId).HasColumnName("HinhThucThanhToanBanID");
            entity.Property(e => e.HinhThucThanhToanMuaId).HasColumnName("HinhThucThanhToanMuaID");
            entity.Property(e => e.HopDongHopTac).HasMaxLength(200);
            entity.Property(e => e.KenhBanHangId).HasColumnName("KenhBanHangID");
            entity.Property(e => e.KhoNhapHangId).HasColumnName("KhoNhapHangID");
            entity.Property(e => e.KhoXuatHangId).HasColumnName("KhoXuatHangID");
            entity.Property(e => e.KhuVucBanHangId).HasColumnName("KhuVucBanHangID");
            entity.Property(e => e.LoaiDoiTacId).HasColumnName("LoaiDoiTacID");
            entity.Property(e => e.LuongThoaThuan).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.LuongTinhBaoHiem).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MaSo).HasMaxLength(50);
            entity.Property(e => e.MaSoThue).HasMaxLength(100);
            entity.Property(e => e.MaSoThueNgayCap).HasColumnType("datetime");
            entity.Property(e => e.MaSoThueNoiCap).HasMaxLength(100);
            entity.Property(e => e.NganHangId).HasColumnName("NganHangID");
            entity.Property(e => e.NgayKyHopTac).HasColumnType("datetime");
            entity.Property(e => e.NgaySinh).HasColumnType("datetime");
            entity.Property(e => e.NguoiDaiDienChucVu).HasMaxLength(100);
            entity.Property(e => e.NguoiDaiDienCmnd)
                .HasMaxLength(100)
                .HasColumnName("NguoiDaiDienCMND");
            entity.Property(e => e.NguoiDaiDienPhapLuat).HasMaxLength(100);
            entity.Property(e => e.NhomDoiTacId).HasColumnName("NhomDoiTacID");
            entity.Property(e => e.NhomThuocTinhId).HasColumnName("NhomThuocTinhID");
            entity.Property(e => e.NopVaoTaiKhoanNganHangId).HasColumnName("NopVaoTaiKhoanNganHangID");
            entity.Property(e => e.ParentId).HasColumnName("ParentID");
            entity.Property(e => e.QuanHuyenId).HasColumnName("QuanHuyenID");
            entity.Property(e => e.SoTaiKhoanNganHang).HasMaxLength(500);
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TenChuTaiKhoanNganHang).HasMaxLength(500);
            entity.Property(e => e.TenDoiTac).HasMaxLength(300);
            entity.Property(e => e.TenNguoiGiaoDich).HasMaxLength(300);
            entity.Property(e => e.TenPhapNhan).HasMaxLength(2000);
            entity.Property(e => e.ThongTinNganHang).HasMaxLength(500);
            entity.Property(e => e.TinhChatDoiTacId).HasColumnName("TinhChatDoiTacID");
            entity.Property(e => e.TinhThanhId).HasColumnName("TinhThanhID");
            entity.Property(e => e.TuyenGiaoHangId).HasColumnName("TuyenGiaoHangID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.ValidTo).HasColumnType("datetime");
            entity.Property(e => e.WebId).HasColumnName("WebID");
            entity.Property(e => e.XaPhuongId).HasColumnName("XaPhuongID");
        });

        modelBuilder.Entity<DoiTacDinhMuc>(entity =>
        {
            entity.ToTable("DoiTacDinhMuc");

            entity.HasIndex(e => new { e.DoiTacId, e.TaiKhoanId }, "IX_DoiTacDinhMuc_UI1").IsUnique();

            entity.Property(e => e.DoiTacDinhMucId)
                .ValueGeneratedNever()
                .HasColumnName("DoiTacDinhMucID");
            entity.Property(e => e.DoiTacId).HasColumnName("DoiTacID");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.DuCoMax).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DuCoMin).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DuNoMax).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DuNoMin).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.GhiChu).HasMaxLength(200);
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TaiKhoanId).HasColumnName("TaiKhoanID");
        });

        modelBuilder.Entity<DoiTacImage>(entity =>
        {
            entity.ToTable("DoiTacImage");

            entity.Property(e => e.DoiTacImageId)
                .ValueGeneratedNever()
                .HasColumnName("DoiTacImageID");
            entity.Property(e => e.DoiTacId).HasColumnName("DoiTacID");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
        });

        modelBuilder.Entity<DoiTacThanhToan>(entity =>
        {
            entity.ToTable("DoiTacThanhToan");

            entity.HasIndex(e => e.DoiTacId, "IX_DoiTacThanhToan_UI1").IsUnique();

            entity.Property(e => e.DoiTacThanhToanId)
                .ValueGeneratedNever()
                .HasColumnName("DoiTacThanhToanID");
            entity.Property(e => e.DoiTacId).HasColumnName("DoiTacID");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.DuCoMax).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DuCoMin).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DuNoMax).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DuNoMin).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.GhiChu).HasMaxLength(200);
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
        });

        modelBuilder.Entity<DoiTuongThcp>(entity =>
        {
            entity.HasKey(e => e.DoiTuongId).HasName("PK__DoiTuong__2D458BC1C6CBD7C6");

            entity.ToTable("DoiTuongTHCP");

            entity.HasIndex(e => new { e.DraftId, e.MaSo, e.DonViId }, "IX_DoiTuongTHCP_UI1").IsUnique();

            entity.HasIndex(e => new { e.DraftId, e.TenDoiTuongThcp, e.DonViId }, "IX_DoiTuongTHCP_UI2").IsUnique();

            entity.Property(e => e.DoiTuongId).HasColumnName("DoiTuongID");
            entity.Property(e => e.ChiPhiId).HasColumnName("ChiPhiID");
            entity.Property(e => e.DoiTuongChaId).HasColumnName("DoiTuongChaID");
            entity.Property(e => e.DoiTuongThcpid).HasColumnName("DoiTuongTHCPID");
            entity.Property(e => e.DonViId).HasColumnName("DonViID");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.GroupId)
                .HasMaxLength(512)
                .HasColumnName("GroupID");
            entity.Property(e => e.KhoId).HasColumnName("KhoID");
            entity.Property(e => e.MaSo).HasMaxLength(50);
            entity.Property(e => e.NguoiChuQuan).HasMaxLength(250);
            entity.Property(e => e.ParentId).HasColumnName("ParentID");
            entity.Property(e => e.PhanXuongId).HasColumnName("PhanXuongID");
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TaiKhoanId).HasColumnName("TaiKhoanID");
            entity.Property(e => e.TenDoiTuongThcp)
                .HasMaxLength(200)
                .HasColumnName("TenDoiTuongTHCP");
            entity.Property(e => e.ThanhPhamId).HasColumnName("ThanhPhamID");
            entity.Property(e => e.ValidTo).HasColumnType("datetime");
            entity.Property(e => e.VuViecId).HasColumnName("VuViecID");
        });

        modelBuilder.Entity<DonViTinh>(entity =>
        {
            entity.ToTable("DonViTinh");

            entity.HasIndex(e => new { e.DraftId, e.MaSo }, "IX_DonViTinh_UI1").IsUnique();

            entity.HasIndex(e => new { e.DraftId, e.TenDonViTinh }, "IX_DonViTinh_UI2").IsUnique();

            entity.Property(e => e.DonViTinhId)
                .ValueGeneratedNever()
                .HasColumnName("DonViTinhID");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.KyHieu).HasMaxLength(50);
            entity.Property(e => e.MaSo).HasMaxLength(50);
            entity.Property(e => e.NhomDonViTinhId).HasColumnName("NhomDonViTinhID");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TenDonViTinh).HasMaxLength(300);
            entity.Property(e => e.TyLeQuyDoi).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.ValidTo).HasColumnType("datetime");
        });

        modelBuilder.Entity<ErrorLogging>(entity =>
        {
            entity.ToTable("ErrorLogging");

            entity.Property(e => e.ErrorLoggingId)
                .ValueGeneratedNever()
                .HasColumnName("ErrorLoggingID");
            entity.Property(e => e.ActionType).HasMaxLength(500);
            entity.Property(e => e.ComputerIp)
                .HasMaxLength(500)
                .HasColumnName("ComputerIP");
            entity.Property(e => e.ComputerName).HasMaxLength(100);
            entity.Property(e => e.DataRecordId).HasColumnName("DataRecordID");
            entity.Property(e => e.DataTypeId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DataTypeID");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.NgayUpdate).HasColumnType("datetime");
            entity.Property(e => e.PositionGps)
                .HasMaxLength(500)
                .HasColumnName("PositionGPS");
            entity.Property(e => e.SourceType).HasMaxLength(100);
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.UserId)
                .HasMaxLength(100)
                .HasColumnName("UserID");
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<FileDinhKem>(entity =>
        {
            entity.ToTable("FileDinhKem");

            entity.Property(e => e.FileDinhKemId)
                .ValueGeneratedNever()
                .HasColumnName("FileDinhKemID");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.FileExtention).HasMaxLength(50);
            entity.Property(e => e.FileName).HasMaxLength(150);
            entity.Property(e => e.FileOverview).HasMaxLength(500);
            entity.Property(e => e.FileSize).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.FileType).HasMaxLength(50);
            entity.Property(e => e.ModelName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RecordId).HasColumnName("RecordID");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TableName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HopDong>(entity =>
        {
            entity.ToTable("HopDong");

            entity.Property(e => e.HopDongId)
                .ValueGeneratedNever()
                .HasColumnName("HopDongID");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.GhiChu).HasMaxLength(500);
            entity.Property(e => e.NgayKy).HasColumnType("datetime");
            entity.Property(e => e.SoHopDong).HasMaxLength(50);
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.ValidTo).HasColumnType("datetime");
        });

        modelBuilder.Entity<HopDongDoiTac>(entity =>
        {
            entity.HasKey(e => e.HopDongId);

            entity.ToTable("HopDongDoiTac");

            entity.Property(e => e.HopDongId)
                .ValueGeneratedNever()
                .HasColumnName("HopDongID");
            entity.Property(e => e.DoiTacId).HasColumnName("DoiTacID");
            entity.Property(e => e.DonViId).HasColumnName("DonViID");
            entity.Property(e => e.MoTa).HasMaxLength(500);
            entity.Property(e => e.NgayHopDong).HasColumnType("datetime");
            entity.Property(e => e.SoHopDong).HasMaxLength(100);
        });

        modelBuilder.Entity<InternalExport>(entity =>
        {
            entity.ToTable("InternalExport");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DoiTuongCp)
                .HasMaxLength(250)
                .HasColumnName("DoiTuongCP");
            entity.Property(e => e.DoiTuongCpid).HasColumnName("DoiTuongCPID");
            entity.Property(e => e.DoiTuongId).HasColumnName("DoiTuongID");
            entity.Property(e => e.DonViId).HasColumnName("DonViID");
            entity.Property(e => e.KhoGiaoDichId).HasColumnName("KhoGiaoDichID");
            entity.Property(e => e.LyDoXuat).HasMaxLength(250);
            entity.Property(e => e.NgayPhatSinh).HasColumnType("datetime");
            entity.Property(e => e.NguoiNhan).HasMaxLength(250);
            entity.Property(e => e.PhanXuong).HasMaxLength(250);
            entity.Property(e => e.PhanXuongId).HasColumnName("PhanXuongID");
            entity.Property(e => e.SoChungTu).HasMaxLength(100);
            entity.Property(e => e.TenKtvatTu)
                .HasMaxLength(150)
                .HasColumnName("TenKTVatTu");
            entity.Property(e => e.TenNguoiNhan).HasMaxLength(150);
            entity.Property(e => e.TenQuanDoc).HasMaxLength(150);
            entity.Property(e => e.TenThuKho).HasMaxLength(150);
            entity.Property(e => e.TongCong).HasColumnType("decimal(18, 6)");
        });

        modelBuilder.Entity<InternalExportDetail>(entity =>
        {
            entity.ToTable("InternalExportDetail");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DoiTuongCpid).HasColumnName("DoiTuongCPID");
            entity.Property(e => e.DoiTuongId).HasColumnName("DoiTuongID");
            entity.Property(e => e.DonViId).HasColumnName("DonViID");
            entity.Property(e => e.DonViTinh).HasMaxLength(100);
            entity.Property(e => e.GhiChu).HasMaxLength(500);
            entity.Property(e => e.InternalExportId).HasColumnName("InternalExportID");
            entity.Property(e => e.KhoGiaoDichId).HasColumnName("KhoGiaoDichID");
            entity.Property(e => e.LyDoXuat).HasMaxLength(250);
            entity.Property(e => e.MaSanPham).HasMaxLength(100);
            entity.Property(e => e.NgayPhatSinh).HasColumnType("datetime");
            entity.Property(e => e.PhanXuongId).HasColumnName("PhanXuongID");
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.SoLuong).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.TenSanPham).HasMaxLength(200);
            entity.Property(e => e.XuatXu).HasMaxLength(100);
        });

        modelBuilder.Entity<Kho>(entity =>
        {
            entity.ToTable("Kho");

            entity.HasIndex(e => new { e.DraftId, e.MaSo, e.DonViId }, "IX_Kho_UI1").IsUnique();

            entity.Property(e => e.KhoId)
                .ValueGeneratedNever()
                .HasColumnName("KhoID");
            entity.Property(e => e.DiaChi).HasMaxLength(300);
            entity.Property(e => e.DienThoai).HasMaxLength(300);
            entity.Property(e => e.DonViId).HasColumnName("DonViID");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.Email).HasMaxLength(300);
            entity.Property(e => e.Gpsaddress)
                .HasMaxLength(600)
                .HasColumnName("GPSAddress");
            entity.Property(e => e.Gpslatitude)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GPSLatitude");
            entity.Property(e => e.Gpslongitude)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GPSLongitude");
            entity.Property(e => e.Gpsname)
                .HasMaxLength(200)
                .HasColumnName("GPSName");
            entity.Property(e => e.KhachHangId).HasColumnName("KhachHangID");
            entity.Property(e => e.MaSo).HasMaxLength(50);
            entity.Property(e => e.NguoiLienHe).HasMaxLength(300);
            entity.Property(e => e.ParentId).HasColumnName("ParentID");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.SttgiaVon).HasColumnName("STTGiaVon");
            entity.Property(e => e.TaiKhoanChietKhauId).HasColumnName("TaiKhoanChietKhauID");
            entity.Property(e => e.TaiKhoanDoanhThuId).HasColumnName("TaiKhoanDoanhThuID");
            entity.Property(e => e.TaiKhoanDoanhThuNoiBoId).HasColumnName("TaiKhoanDoanhThuNoiBoID");
            entity.Property(e => e.TaiKhoanDoanhThuTraLaiId).HasColumnName("TaiKhoanDoanhThuTraLaiID");
            entity.Property(e => e.TaiKhoanGiaVonId).HasColumnName("TaiKhoanGiaVonID");
            entity.Property(e => e.TaiKhoanKhoId).HasColumnName("TaiKhoanKhoID");
            entity.Property(e => e.TaiKhoanPhanBoNhapId).HasColumnName("TaiKhoanPhanBoNhapID");
            entity.Property(e => e.TaiKhoanTienMatId).HasColumnName("TaiKhoanTienMatID");
            entity.Property(e => e.TenKho).HasMaxLength(300);
            entity.Property(e => e.ThuKhoId).HasColumnName("ThuKhoID");
            entity.Property(e => e.ValidTo).HasColumnType("datetime");
        });

        modelBuilder.Entity<KhoSanPham>(entity =>
        {
            entity.ToTable("KhoSanPham");

            entity.HasIndex(e => new { e.SsClientId, e.KhoId }, "IX_KhoSanPham_KhoID");

            entity.Property(e => e.KhoSanPhamId)
                .ValueGeneratedNever()
                .HasColumnName("KhoSanPhamID");
            entity.Property(e => e.DieuChinhSoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DieuChinhSoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DieuChinhTienNhap).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.DieuChinhTienXuat).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GhiChu).HasMaxLength(500);
            entity.Property(e => e.GiaTriCk)
                .HasColumnType("decimal(21, 6)")
                .HasColumnName("GiaTriCK");
            entity.Property(e => e.GiaTriDk)
                .HasColumnType("decimal(21, 6)")
                .HasColumnName("GiaTriDK");
            entity.Property(e => e.GiaTriNhap).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GiaTriXuat).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.KhoId).HasColumnName("KhoID");
            entity.Property(e => e.LoaiSanPhamId).HasColumnName("LoaiSanPhamID");
            entity.Property(e => e.MaHopNhat).HasMaxLength(150);
            entity.Property(e => e.MaSanPham).HasMaxLength(50);
            entity.Property(e => e.NgayDangKy).HasColumnType("datetime");
            entity.Property(e => e.NhomSanPhamId).HasColumnName("NhomSanPhamID");
            entity.Property(e => e.QuyCachGoi).HasMaxLength(50);
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.SoLuongCk)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("SoLuongCK");
            entity.Property(e => e.SoLuongDk)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("SoLuongDK");
            entity.Property(e => e.SoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TaiKhoanId).HasColumnName("TaiKhoanID");
            entity.Property(e => e.TenSanPham).HasMaxLength(300);
        });

        modelBuilder.Entity<KhoSanPhamBackup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("KhoSanPham_Backup");

            entity.Property(e => e.DieuChinhSoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DieuChinhSoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DieuChinhTienNhap).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.DieuChinhTienXuat).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.GhiChu).HasMaxLength(500);
            entity.Property(e => e.GiaTriCk)
                .HasColumnType("decimal(21, 6)")
                .HasColumnName("GiaTriCK");
            entity.Property(e => e.GiaTriDk)
                .HasColumnType("decimal(21, 6)")
                .HasColumnName("GiaTriDK");
            entity.Property(e => e.GiaTriNhap).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GiaTriXuat).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.KhoId).HasColumnName("KhoID");
            entity.Property(e => e.KhoSanPhamId).HasColumnName("KhoSanPhamID");
            entity.Property(e => e.KichCoId).HasColumnName("KichCoID");
            entity.Property(e => e.KyBaoCaoId).HasColumnName("KyBaoCaoID");
            entity.Property(e => e.LoaiSanPhamId).HasColumnName("LoaiSanPhamID");
            entity.Property(e => e.MaHopNhat).HasMaxLength(150);
            entity.Property(e => e.MaSanPham).HasMaxLength(50);
            entity.Property(e => e.MaSo).HasMaxLength(150);
            entity.Property(e => e.MauSacId).HasColumnName("MauSacID");
            entity.Property(e => e.NamTc).HasColumnName("NamTC");
            entity.Property(e => e.NgayDangKy).HasColumnType("datetime");
            entity.Property(e => e.NhomSanPhamId).HasColumnName("NhomSanPhamID");
            entity.Property(e => e.QuyCachGoi).HasMaxLength(50);
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.SoLuongCk)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("SoLuongCK");
            entity.Property(e => e.SoLuongDk)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("SoLuongDK");
            entity.Property(e => e.SoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TaiKhoanId).HasColumnName("TaiKhoanID");
            entity.Property(e => e.TenSanPham).HasMaxLength(300);
            entity.Property(e => e.TenSanPhamTheoKho).HasMaxLength(600);
        });

        modelBuilder.Entity<KhoSanPhamBackup2021>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("KhoSanPham_Backup2021");

            entity.Property(e => e.DieuChinhSoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DieuChinhSoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DieuChinhTienNhap).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.DieuChinhTienXuat).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.GhiChu).HasMaxLength(500);
            entity.Property(e => e.GiaTriCk)
                .HasColumnType("decimal(21, 6)")
                .HasColumnName("GiaTriCK");
            entity.Property(e => e.GiaTriDk)
                .HasColumnType("decimal(21, 6)")
                .HasColumnName("GiaTriDK");
            entity.Property(e => e.GiaTriNhap).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GiaTriXuat).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.KhoId).HasColumnName("KhoID");
            entity.Property(e => e.KhoSanPhamId).HasColumnName("KhoSanPhamID");
            entity.Property(e => e.KichCoId).HasColumnName("KichCoID");
            entity.Property(e => e.KyBaoCaoId).HasColumnName("KyBaoCaoID");
            entity.Property(e => e.LoaiSanPhamId).HasColumnName("LoaiSanPhamID");
            entity.Property(e => e.MaHopNhat).HasMaxLength(150);
            entity.Property(e => e.MaSanPham).HasMaxLength(50);
            entity.Property(e => e.MaSo).HasMaxLength(150);
            entity.Property(e => e.MauSacId).HasColumnName("MauSacID");
            entity.Property(e => e.NamTc).HasColumnName("NamTC");
            entity.Property(e => e.NgayDangKy).HasColumnType("datetime");
            entity.Property(e => e.NhomSanPhamId).HasColumnName("NhomSanPhamID");
            entity.Property(e => e.QuyCachGoi).HasMaxLength(50);
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.SoLuongCk)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("SoLuongCK");
            entity.Property(e => e.SoLuongDk)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("SoLuongDK");
            entity.Property(e => e.SoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TaiKhoanId).HasColumnName("TaiKhoanID");
            entity.Property(e => e.TenSanPham).HasMaxLength(300);
            entity.Property(e => e.TenSanPhamTheoKho).HasMaxLength(600);
        });

        modelBuilder.Entity<KhoSanPhamC45>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("KhoSanPhamC45");

            entity.Property(e => e.DieuChinhSoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DieuChinhSoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DieuChinhTienNhap).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.DieuChinhTienXuat).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GhiChu).HasMaxLength(500);
            entity.Property(e => e.GiaTriCk)
                .HasColumnType("decimal(21, 6)")
                .HasColumnName("GiaTriCK");
            entity.Property(e => e.GiaTriDk)
                .HasColumnType("decimal(21, 6)")
                .HasColumnName("GiaTriDK");
            entity.Property(e => e.GiaTriNhap).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GiaTriXuat).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.KhoId).HasColumnName("KhoID");
            entity.Property(e => e.KhoSanPhamId).HasColumnName("KhoSanPhamID");
            entity.Property(e => e.LoaiSanPhamId).HasColumnName("LoaiSanPhamID");
            entity.Property(e => e.MaHopNhat).HasMaxLength(150);
            entity.Property(e => e.MaSanPham).HasMaxLength(50);
            entity.Property(e => e.NgayDangKy).HasColumnType("datetime");
            entity.Property(e => e.NhomSanPhamId).HasColumnName("NhomSanPhamID");
            entity.Property(e => e.QuyCachGoi).HasMaxLength(50);
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.SoLuongCk)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("SoLuongCK");
            entity.Property(e => e.SoLuongDk)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("SoLuongDK");
            entity.Property(e => e.SoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TaiKhoanId).HasColumnName("TaiKhoanID");
            entity.Property(e => e.TenSanPham).HasMaxLength(300);
        });

        modelBuilder.Entity<KhoSanPhamC790>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("KhoSanPhamC790");

            entity.Property(e => e.DieuChinhSoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DieuChinhSoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DieuChinhTienNhap).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.DieuChinhTienXuat).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.GhiChu).HasMaxLength(500);
            entity.Property(e => e.GiaTriCk)
                .HasColumnType("decimal(21, 6)")
                .HasColumnName("GiaTriCK");
            entity.Property(e => e.GiaTriDk)
                .HasColumnType("decimal(21, 6)")
                .HasColumnName("GiaTriDK");
            entity.Property(e => e.GiaTriNhap).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GiaTriXuat).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.KhoId).HasColumnName("KhoID");
            entity.Property(e => e.KhoSanPhamId).HasColumnName("KhoSanPhamID");
            entity.Property(e => e.KichCoId).HasColumnName("KichCoID");
            entity.Property(e => e.KyBaoCaoId).HasColumnName("KyBaoCaoID");
            entity.Property(e => e.LoaiSanPhamId).HasColumnName("LoaiSanPhamID");
            entity.Property(e => e.MaHopNhat).HasMaxLength(150);
            entity.Property(e => e.MaSanPham).HasMaxLength(50);
            entity.Property(e => e.MaSo).HasMaxLength(150);
            entity.Property(e => e.MauSacId).HasColumnName("MauSacID");
            entity.Property(e => e.NamTc).HasColumnName("NamTC");
            entity.Property(e => e.NgayDangKy).HasColumnType("datetime");
            entity.Property(e => e.NhomSanPhamId).HasColumnName("NhomSanPhamID");
            entity.Property(e => e.QuyCachGoi).HasMaxLength(50);
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.SoLuongCk)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("SoLuongCK");
            entity.Property(e => e.SoLuongDk)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("SoLuongDK");
            entity.Property(e => e.SoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TaiKhoanId).HasColumnName("TaiKhoanID");
            entity.Property(e => e.TenSanPham).HasMaxLength(300);
            entity.Property(e => e.TenSanPhamTheoKho).HasMaxLength(600);
        });

        modelBuilder.Entity<KhoSanPhamCca>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("KhoSanPhamCCA");

            entity.Property(e => e.DieuChinhSoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DieuChinhSoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DieuChinhTienNhap).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.DieuChinhTienXuat).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GhiChu).HasMaxLength(500);
            entity.Property(e => e.GiaTriCk)
                .HasColumnType("decimal(21, 6)")
                .HasColumnName("GiaTriCK");
            entity.Property(e => e.GiaTriDk)
                .HasColumnType("decimal(21, 6)")
                .HasColumnName("GiaTriDK");
            entity.Property(e => e.GiaTriNhap).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GiaTriXuat).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.KhoId).HasColumnName("KhoID");
            entity.Property(e => e.KhoSanPhamId).HasColumnName("KhoSanPhamID");
            entity.Property(e => e.LoaiSanPhamId).HasColumnName("LoaiSanPhamID");
            entity.Property(e => e.MaHopNhat).HasMaxLength(150);
            entity.Property(e => e.MaSanPham).HasMaxLength(50);
            entity.Property(e => e.NgayDangKy).HasColumnType("datetime");
            entity.Property(e => e.NhomSanPhamId).HasColumnName("NhomSanPhamID");
            entity.Property(e => e.QuyCachGoi).HasMaxLength(50);
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.SoLuongCk)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("SoLuongCK");
            entity.Property(e => e.SoLuongDk)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("SoLuongDK");
            entity.Property(e => e.SoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TaiKhoanId).HasColumnName("TaiKhoanID");
            entity.Property(e => e.TenSanPham).HasMaxLength(300);
        });

        modelBuilder.Entity<KhoSanPhamCnm>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("KhoSanPhamCNM");

            entity.Property(e => e.DieuChinhSoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DieuChinhSoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DieuChinhTienNhap).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.DieuChinhTienXuat).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GhiChu).HasMaxLength(500);
            entity.Property(e => e.GiaTriCk)
                .HasColumnType("decimal(21, 6)")
                .HasColumnName("GiaTriCK");
            entity.Property(e => e.GiaTriDk)
                .HasColumnType("decimal(21, 6)")
                .HasColumnName("GiaTriDK");
            entity.Property(e => e.GiaTriNhap).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GiaTriXuat).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.KhoId).HasColumnName("KhoID");
            entity.Property(e => e.KhoSanPhamId).HasColumnName("KhoSanPhamID");
            entity.Property(e => e.LoaiSanPhamId).HasColumnName("LoaiSanPhamID");
            entity.Property(e => e.MaHopNhat).HasMaxLength(150);
            entity.Property(e => e.MaSanPham).HasMaxLength(50);
            entity.Property(e => e.NgayDangKy).HasColumnType("datetime");
            entity.Property(e => e.NhomSanPhamId).HasColumnName("NhomSanPhamID");
            entity.Property(e => e.QuyCachGoi).HasMaxLength(50);
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.SoLuongCk)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("SoLuongCK");
            entity.Property(e => e.SoLuongDk)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("SoLuongDK");
            entity.Property(e => e.SoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TaiKhoanId).HasColumnName("TaiKhoanID");
            entity.Property(e => e.TenSanPham).HasMaxLength(300);
        });

        modelBuilder.Entity<KhoSanPhamCvt>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("KhoSanPhamCVT");

            entity.Property(e => e.DieuChinhSoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DieuChinhSoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DieuChinhTienNhap).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.DieuChinhTienXuat).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GhiChu).HasMaxLength(500);
            entity.Property(e => e.GiaTriCk)
                .HasColumnType("decimal(21, 6)")
                .HasColumnName("GiaTriCK");
            entity.Property(e => e.GiaTriDk)
                .HasColumnType("decimal(21, 6)")
                .HasColumnName("GiaTriDK");
            entity.Property(e => e.GiaTriNhap).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GiaTriXuat).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.KhoId).HasColumnName("KhoID");
            entity.Property(e => e.KhoSanPhamId).HasColumnName("KhoSanPhamID");
            entity.Property(e => e.LoaiSanPhamId).HasColumnName("LoaiSanPhamID");
            entity.Property(e => e.MaHopNhat).HasMaxLength(150);
            entity.Property(e => e.MaSanPham).HasMaxLength(50);
            entity.Property(e => e.MaSo).HasMaxLength(150);
            entity.Property(e => e.NgayDangKy).HasColumnType("datetime");
            entity.Property(e => e.NhomSanPhamId).HasColumnName("NhomSanPhamID");
            entity.Property(e => e.QuyCachGoi).HasMaxLength(50);
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.SoLuongCk)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("SoLuongCK");
            entity.Property(e => e.SoLuongDk)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("SoLuongDK");
            entity.Property(e => e.SoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TaiKhoanId).HasColumnName("TaiKhoanID");
            entity.Property(e => e.TenSanPham).HasMaxLength(300);
        });

        modelBuilder.Entity<KhoSanPhamK>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("KhoSanPhamKS");

            entity.Property(e => e.DieuChinhSoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DieuChinhSoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DieuChinhTienNhap).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.DieuChinhTienXuat).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GhiChu).HasMaxLength(500);
            entity.Property(e => e.GiaTriCk)
                .HasColumnType("decimal(21, 6)")
                .HasColumnName("GiaTriCK");
            entity.Property(e => e.GiaTriDk)
                .HasColumnType("decimal(21, 6)")
                .HasColumnName("GiaTriDK");
            entity.Property(e => e.GiaTriNhap).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GiaTriXuat).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.KhoId).HasColumnName("KhoID");
            entity.Property(e => e.KhoSanPhamId).HasColumnName("KhoSanPhamID");
            entity.Property(e => e.LoaiSanPhamId).HasColumnName("LoaiSanPhamID");
            entity.Property(e => e.MaHopNhat).HasMaxLength(150);
            entity.Property(e => e.MaSanPham).HasMaxLength(50);
            entity.Property(e => e.MaSo).HasMaxLength(150);
            entity.Property(e => e.NgayDangKy).HasColumnType("datetime");
            entity.Property(e => e.NhomSanPhamId).HasColumnName("NhomSanPhamID");
            entity.Property(e => e.QuyCachGoi).HasMaxLength(50);
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.SoLuongCk)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("SoLuongCK");
            entity.Property(e => e.SoLuongDk)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("SoLuongDK");
            entity.Property(e => e.SoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TaiKhoanId).HasColumnName("TaiKhoanID");
            entity.Property(e => e.TenSanPham).HasMaxLength(300);
        });

        modelBuilder.Entity<KhoSanPhamKtk>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("KhoSanPhamKTKS");

            entity.Property(e => e.DieuChinhSoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DieuChinhSoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DieuChinhTienNhap).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.DieuChinhTienXuat).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GhiChu).HasMaxLength(500);
            entity.Property(e => e.GiaTriCk)
                .HasColumnType("decimal(21, 6)")
                .HasColumnName("GiaTriCK");
            entity.Property(e => e.GiaTriDk)
                .HasColumnType("decimal(21, 6)")
                .HasColumnName("GiaTriDK");
            entity.Property(e => e.GiaTriNhap).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GiaTriXuat).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.KhoId).HasColumnName("KhoID");
            entity.Property(e => e.KhoSanPhamId).HasColumnName("KhoSanPhamID");
            entity.Property(e => e.LoaiSanPhamId).HasColumnName("LoaiSanPhamID");
            entity.Property(e => e.MaHopNhat).HasMaxLength(150);
            entity.Property(e => e.MaSanPham).HasMaxLength(50);
            entity.Property(e => e.MaSo).HasMaxLength(150);
            entity.Property(e => e.NgayDangKy).HasColumnType("datetime");
            entity.Property(e => e.NhomSanPhamId).HasColumnName("NhomSanPhamID");
            entity.Property(e => e.QuyCachGoi).HasMaxLength(50);
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.SoLuongCk)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("SoLuongCK");
            entity.Property(e => e.SoLuongDk)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("SoLuongDK");
            entity.Property(e => e.SoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TaiKhoanId).HasColumnName("TaiKhoanID");
            entity.Property(e => e.TenSanPham).HasMaxLength(300);
        });

        modelBuilder.Entity<KhoanMuc>(entity =>
        {
            entity.ToTable("KhoanMuc");

            entity.HasIndex(e => new { e.DraftId, e.MaSo }, "IX_KhoanMuc_UI1").IsUnique();

            entity.HasIndex(e => new { e.DraftId, e.TenKhoanMuc }, "IX_KhoanMuc_UI2").IsUnique();

            entity.Property(e => e.KhoanMucId)
                .ValueGeneratedNever()
                .HasColumnName("KhoanMucID");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.MaSo).HasMaxLength(50);
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TaiKhoanChiPhiId).HasColumnName("TaiKhoanChiPhiID");
            entity.Property(e => e.TenKhoanMuc).HasMaxLength(300);
            entity.Property(e => e.TinhChatKhoanMucId).HasColumnName("TinhChatKhoanMucID");
            entity.Property(e => e.ValidTo).HasColumnType("datetime");
        });

        modelBuilder.Entity<KichCo>(entity =>
        {
            entity.ToTable("KichCo");

            entity.HasIndex(e => new { e.DraftId, e.MaSo }, "IX_KichCo_UI1").IsUnique();

            entity.HasIndex(e => new { e.DraftId, e.TenKichCo }, "IX_KichCo_UI2").IsUnique();

            entity.Property(e => e.KichCoId)
                .ValueGeneratedNever()
                .HasColumnName("KichCoID");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.KyHieu)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MaSo).HasMaxLength(50);
            entity.Property(e => e.NhomKichCoId).HasColumnName("NhomKichCoID");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TenKichCo).HasMaxLength(300);
            entity.Property(e => e.ValidTo).HasColumnType("datetime");
        });

        modelBuilder.Entity<KiemKeKho>(entity =>
        {
            entity.ToTable("KiemKeKho");

            entity.Property(e => e.KiemKeKhoId)
                .ValueGeneratedNever()
                .HasColumnName("KiemKeKhoID");
            entity.Property(e => e.ChuTichHoiDong).HasMaxLength(500);
            entity.Property(e => e.ChucVuChuTichHoiDong).HasMaxLength(500);
            entity.Property(e => e.ChucVuUyVien1).HasMaxLength(500);
            entity.Property(e => e.ChucVuUyVien10).HasMaxLength(500);
            entity.Property(e => e.ChucVuUyVien2).HasMaxLength(500);
            entity.Property(e => e.ChucVuUyVien3).HasMaxLength(500);
            entity.Property(e => e.ChucVuUyVien4).HasMaxLength(500);
            entity.Property(e => e.ChucVuUyVien5).HasMaxLength(500);
            entity.Property(e => e.ChucVuUyVien6).HasMaxLength(500);
            entity.Property(e => e.ChucVuUyVien7).HasMaxLength(500);
            entity.Property(e => e.ChucVuUyVien8).HasMaxLength(500);
            entity.Property(e => e.ChucVuUyVien9).HasMaxLength(500);
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.GhiChu).HasMaxLength(200);
            entity.Property(e => e.InputId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("InputID");
            entity.Property(e => e.KhoKiemKeId).HasColumnName("KhoKiemKeID");
            entity.Property(e => e.LoaiChungTuId).HasColumnName("LoaiChungTuID");
            entity.Property(e => e.LyDoChungTuId).HasColumnName("LyDoChungTuID");
            entity.Property(e => e.NamPs).HasColumnName("NamPS");
            entity.Property(e => e.NgayPhatSinh).HasColumnType("datetime");
            entity.Property(e => e.NhanVienGiamSatId).HasColumnName("NhanVienGiamSatID");
            entity.Property(e => e.NhanVienKeToanId).HasColumnName("NhanVienKeToanID");
            entity.Property(e => e.NhanVienKiemKeId).HasColumnName("NhanVienKiemKeID");
            entity.Property(e => e.NoiDungKiemKe).HasMaxLength(500);
            entity.Property(e => e.SoHieu).HasMaxLength(50);
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TaiKhoanKhoId).HasColumnName("TaiKhoanKhoID");
            entity.Property(e => e.ThoiDiemPhatSinh).HasColumnType("datetime");
            entity.Property(e => e.ThongTinNhanVienGiamSat).HasMaxLength(500);
            entity.Property(e => e.ThongTinNhanVienKeToan).HasMaxLength(500);
            entity.Property(e => e.ThongTinNhanVienKiemKe).HasMaxLength(500);
            entity.Property(e => e.ThongTinThuKho).HasMaxLength(500);
            entity.Property(e => e.ThuKhoId).HasColumnName("ThuKhoID");
            entity.Property(e => e.TrangThaiId).HasColumnName("TrangThaiID");
            entity.Property(e => e.UyVien1).HasMaxLength(500);
            entity.Property(e => e.UyVien10).HasMaxLength(500);
            entity.Property(e => e.UyVien2).HasMaxLength(500);
            entity.Property(e => e.UyVien3).HasMaxLength(500);
            entity.Property(e => e.UyVien4).HasMaxLength(500);
            entity.Property(e => e.UyVien5).HasMaxLength(500);
            entity.Property(e => e.UyVien6).HasMaxLength(500);
            entity.Property(e => e.UyVien7).HasMaxLength(500);
            entity.Property(e => e.UyVien8).HasMaxLength(500);
            entity.Property(e => e.UyVien9).HasMaxLength(500);
            entity.Property(e => e.XuLyKiemKeId).HasColumnName("XuLyKiemKeID");
        });

        modelBuilder.Entity<KiemKeKhoChiTiet>(entity =>
        {
            entity.ToTable("KiemKeKhoChiTiet");

            entity.Property(e => e.KiemKeKhoChiTietId)
                .ValueGeneratedNever()
                .HasColumnName("KiemKeKhoChiTietID");
            entity.Property(e => e.BarCodeRaw).HasMaxLength(50);
            entity.Property(e => e.DonGiaKiemKe).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.GhiChu).HasMaxLength(500);
            entity.Property(e => e.GiaTriKiemKe).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.KhoKiemKeId).HasColumnName("KhoKiemKeID");
            entity.Property(e => e.KhoiLuong).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.KichCoId).HasColumnName("KichCoID");
            entity.Property(e => e.KiemKeKhoId).HasColumnName("KiemKeKhoID");
            entity.Property(e => e.LoSanPhamId).HasColumnName("LoSanPhamID");
            entity.Property(e => e.LoaiChungTuId).HasColumnName("LoaiChungTuID");
            entity.Property(e => e.MauSacId).HasColumnName("MauSacID");
            entity.Property(e => e.NamPs).HasColumnName("NamPS");
            entity.Property(e => e.NgayPhatSinh).HasColumnType("datetime");
            entity.Property(e => e.NhomSanPhamId).HasColumnName("NhomSanPhamID");
            entity.Property(e => e.SanPhamDonViTinhId).HasColumnName("SanPhamDonViTinhID");
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.SanPhamWebId).HasColumnName("SanPhamWebID");
            entity.Property(e => e.SoLuong).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongHachToan).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TaiKhoanKhoId).HasColumnName("TaiKhoanKhoID");
        });

        modelBuilder.Entity<LoSanPham>(entity =>
        {
            entity.ToTable("LoSanPham");

            entity.HasIndex(e => new { e.KhoSanPhamId, e.KhoId }, "IDX_LoSanPham_KhoID");

            entity.Property(e => e.LoSanPhamId)
                .ValueGeneratedNever()
                .HasColumnName("LoSanPhamID");
            entity.Property(e => e.BizChungTuId).HasColumnName("BizChungTuID");
            entity.Property(e => e.DonGia).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DonViId).HasColumnName("DonViID");
            entity.Property(e => e.DonViTinhId).HasColumnName("DonViTinhID");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.GhiChu).HasMaxLength(300);
            entity.Property(e => e.GiaTriDk)
                .HasColumnType("decimal(21, 6)")
                .HasColumnName("GiaTriDK");
            entity.Property(e => e.GiaTriNhap).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GiaTriTon).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GiaTriXuat).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.HanSuDung).HasColumnType("datetime");
            entity.Property(e => e.KhoId).HasColumnName("KhoID");
            entity.Property(e => e.KhoSanPhamId).HasColumnName("KhoSanPhamID");
            entity.Property(e => e.LoaiChungTuId).HasColumnName("LoaiChungTuID");
            entity.Property(e => e.LoaiSanPhamId).HasColumnName("LoaiSanPhamID");
            entity.Property(e => e.MaHopNhat).HasMaxLength(150);
            entity.Property(e => e.MaSanPham).HasMaxLength(50);
            entity.Property(e => e.MaSo).HasMaxLength(250);
            entity.Property(e => e.NgayNhapTon).HasColumnType("datetime");
            entity.Property(e => e.NgayPhatSinh).HasColumnType("datetime");
            entity.Property(e => e.NgaySanXuat).HasColumnType("datetime");
            entity.Property(e => e.NhomSanPhamId).HasColumnName("NhomSanPhamID");
            entity.Property(e => e.PhanXuongId).HasColumnName("PhanXuongID");
            entity.Property(e => e.QuyCachGoi).HasMaxLength(50);
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.SoLuongDk)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("SoLuongDK");
            entity.Property(e => e.SoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongTon).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TaiKhoanId).HasColumnName("TaiKhoanID");
            entity.Property(e => e.TenLoSanPham).HasMaxLength(200);
            entity.Property(e => e.TenSanPham).HasMaxLength(300);
        });

        modelBuilder.Entity<LoSanPhamBackup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LoSanPham_Backup");

            entity.Property(e => e.BizChungTuId).HasColumnName("BizChungTuID");
            entity.Property(e => e.DonGia).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DonViId).HasColumnName("DonViID");
            entity.Property(e => e.DonViTinhId).HasColumnName("DonViTinhID");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.GhiChu).HasMaxLength(300);
            entity.Property(e => e.GiaTriDk)
                .HasColumnType("decimal(21, 6)")
                .HasColumnName("GiaTriDK");
            entity.Property(e => e.GiaTriNhap).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GiaTriTon).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GiaTriXuat).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.HanSuDung).HasColumnType("datetime");
            entity.Property(e => e.KhoId).HasColumnName("KhoID");
            entity.Property(e => e.KhoSanPhamId).HasColumnName("KhoSanPhamID");
            entity.Property(e => e.LoSanPhamId).HasColumnName("LoSanPhamID");
            entity.Property(e => e.LoaiChungTuId).HasColumnName("LoaiChungTuID");
            entity.Property(e => e.LoaiSanPhamId).HasColumnName("LoaiSanPhamID");
            entity.Property(e => e.MaHopNhat).HasMaxLength(150);
            entity.Property(e => e.MaSanPham).HasMaxLength(50);
            entity.Property(e => e.MaSo).HasMaxLength(250);
            entity.Property(e => e.NgayNhapTon).HasColumnType("datetime");
            entity.Property(e => e.NgayPhatSinh).HasColumnType("datetime");
            entity.Property(e => e.NgaySanXuat).HasColumnType("datetime");
            entity.Property(e => e.NhomSanPhamId).HasColumnName("NhomSanPhamID");
            entity.Property(e => e.PhanXuongId).HasColumnName("PhanXuongID");
            entity.Property(e => e.QuyCachGoi).HasMaxLength(50);
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.SoLuongDk)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("SoLuongDK");
            entity.Property(e => e.SoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongTon).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TaiKhoanId).HasColumnName("TaiKhoanID");
            entity.Property(e => e.TenLoSanPham).HasMaxLength(200);
            entity.Property(e => e.TenSanPham).HasMaxLength(300);
        });

        modelBuilder.Entity<LoSanPhamBackup2021>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LoSanPham_Backup2021");

            entity.Property(e => e.BizChungTuId).HasColumnName("BizChungTuID");
            entity.Property(e => e.DonGia).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DonViId).HasColumnName("DonViID");
            entity.Property(e => e.DonViTinhId).HasColumnName("DonViTinhID");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.GhiChu).HasMaxLength(300);
            entity.Property(e => e.GiaTriDk)
                .HasColumnType("decimal(21, 6)")
                .HasColumnName("GiaTriDK");
            entity.Property(e => e.GiaTriNhap).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GiaTriTon).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GiaTriXuat).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.HanSuDung).HasColumnType("datetime");
            entity.Property(e => e.KhoId).HasColumnName("KhoID");
            entity.Property(e => e.KhoSanPhamId).HasColumnName("KhoSanPhamID");
            entity.Property(e => e.LoSanPhamId).HasColumnName("LoSanPhamID");
            entity.Property(e => e.LoaiChungTuId).HasColumnName("LoaiChungTuID");
            entity.Property(e => e.LoaiSanPhamId).HasColumnName("LoaiSanPhamID");
            entity.Property(e => e.MaHopNhat).HasMaxLength(150);
            entity.Property(e => e.MaSanPham).HasMaxLength(50);
            entity.Property(e => e.MaSo).HasMaxLength(250);
            entity.Property(e => e.NgayNhapTon).HasColumnType("datetime");
            entity.Property(e => e.NgayPhatSinh).HasColumnType("datetime");
            entity.Property(e => e.NgaySanXuat).HasColumnType("datetime");
            entity.Property(e => e.NhomSanPhamId).HasColumnName("NhomSanPhamID");
            entity.Property(e => e.PhanXuongId).HasColumnName("PhanXuongID");
            entity.Property(e => e.QuyCachGoi).HasMaxLength(50);
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.SoLuongDk)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("SoLuongDK");
            entity.Property(e => e.SoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongTon).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TaiKhoanId).HasColumnName("TaiKhoanID");
            entity.Property(e => e.TenLoSanPham).HasMaxLength(200);
            entity.Property(e => e.TenSanPham).HasMaxLength(300);
        });

        modelBuilder.Entity<LoSanPhamC45>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LoSanPhamC45");

            entity.Property(e => e.BizChungTuId).HasColumnName("BizChungTuID");
            entity.Property(e => e.DonGia).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DonViId).HasColumnName("DonViID");
            entity.Property(e => e.DonViTinhId).HasColumnName("DonViTinhID");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.GhiChu).HasMaxLength(300);
            entity.Property(e => e.GiaTriDk)
                .HasColumnType("decimal(21, 6)")
                .HasColumnName("GiaTriDK");
            entity.Property(e => e.GiaTriNhap).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GiaTriTon).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GiaTriXuat).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.HanSuDung).HasColumnType("datetime");
            entity.Property(e => e.KhoId).HasColumnName("KhoID");
            entity.Property(e => e.KhoSanPhamId).HasColumnName("KhoSanPhamID");
            entity.Property(e => e.LoSanPhamId).HasColumnName("LoSanPhamID");
            entity.Property(e => e.LoaiChungTuId).HasColumnName("LoaiChungTuID");
            entity.Property(e => e.LoaiSanPhamId).HasColumnName("LoaiSanPhamID");
            entity.Property(e => e.MaHopNhat).HasMaxLength(150);
            entity.Property(e => e.MaSanPham).HasMaxLength(50);
            entity.Property(e => e.MaSo).HasMaxLength(250);
            entity.Property(e => e.NgayNhapTon).HasColumnType("datetime");
            entity.Property(e => e.NgayPhatSinh).HasColumnType("datetime");
            entity.Property(e => e.NgaySanXuat).HasColumnType("datetime");
            entity.Property(e => e.NhomSanPhamId).HasColumnName("NhomSanPhamID");
            entity.Property(e => e.PhanXuongId).HasColumnName("PhanXuongID");
            entity.Property(e => e.QuyCachGoi).HasMaxLength(50);
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.SoLuongDk)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("SoLuongDK");
            entity.Property(e => e.SoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongTon).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TaiKhoanId).HasColumnName("TaiKhoanID");
            entity.Property(e => e.TenLoSanPham).HasMaxLength(200);
            entity.Property(e => e.TenSanPham).HasMaxLength(300);
        });

        modelBuilder.Entity<LoSanPhamC790>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LoSanPhamC790");

            entity.Property(e => e.BizChungTuId).HasColumnName("BizChungTuID");
            entity.Property(e => e.DonGia).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DonViId).HasColumnName("DonViID");
            entity.Property(e => e.DonViTinhId).HasColumnName("DonViTinhID");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.GhiChu).HasMaxLength(300);
            entity.Property(e => e.GiaTriDk)
                .HasColumnType("decimal(21, 6)")
                .HasColumnName("GiaTriDK");
            entity.Property(e => e.GiaTriNhap).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GiaTriTon).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GiaTriXuat).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.HanSuDung).HasColumnType("datetime");
            entity.Property(e => e.KhoId).HasColumnName("KhoID");
            entity.Property(e => e.KhoSanPhamId).HasColumnName("KhoSanPhamID");
            entity.Property(e => e.LoSanPhamId).HasColumnName("LoSanPhamID");
            entity.Property(e => e.LoaiChungTuId).HasColumnName("LoaiChungTuID");
            entity.Property(e => e.LoaiSanPhamId).HasColumnName("LoaiSanPhamID");
            entity.Property(e => e.MaHopNhat).HasMaxLength(150);
            entity.Property(e => e.MaSanPham).HasMaxLength(50);
            entity.Property(e => e.MaSo).HasMaxLength(250);
            entity.Property(e => e.NgayNhapTon).HasColumnType("datetime");
            entity.Property(e => e.NgayPhatSinh).HasColumnType("datetime");
            entity.Property(e => e.NgaySanXuat).HasColumnType("datetime");
            entity.Property(e => e.NhomSanPhamId).HasColumnName("NhomSanPhamID");
            entity.Property(e => e.PhanXuongId).HasColumnName("PhanXuongID");
            entity.Property(e => e.QuyCachGoi).HasMaxLength(50);
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.SoLuongDk)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("SoLuongDK");
            entity.Property(e => e.SoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongTon).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TaiKhoanId).HasColumnName("TaiKhoanID");
            entity.Property(e => e.TenLoSanPham).HasMaxLength(200);
            entity.Property(e => e.TenSanPham).HasMaxLength(300);
        });

        modelBuilder.Entity<LoSanPhamCca>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LoSanPhamCCA");

            entity.Property(e => e.BizChungTuId).HasColumnName("BizChungTuID");
            entity.Property(e => e.DonGia).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DonViId).HasColumnName("DonViID");
            entity.Property(e => e.DonViTinhId).HasColumnName("DonViTinhID");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.GhiChu).HasMaxLength(300);
            entity.Property(e => e.GiaTriDk)
                .HasColumnType("decimal(21, 6)")
                .HasColumnName("GiaTriDK");
            entity.Property(e => e.GiaTriNhap).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GiaTriTon).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GiaTriXuat).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.HanSuDung).HasColumnType("datetime");
            entity.Property(e => e.KhoId).HasColumnName("KhoID");
            entity.Property(e => e.KhoSanPhamId).HasColumnName("KhoSanPhamID");
            entity.Property(e => e.LoSanPhamId).HasColumnName("LoSanPhamID");
            entity.Property(e => e.LoaiChungTuId).HasColumnName("LoaiChungTuID");
            entity.Property(e => e.LoaiSanPhamId).HasColumnName("LoaiSanPhamID");
            entity.Property(e => e.MaHopNhat).HasMaxLength(150);
            entity.Property(e => e.MaSanPham).HasMaxLength(50);
            entity.Property(e => e.MaSo).HasMaxLength(250);
            entity.Property(e => e.NgayNhapTon).HasColumnType("datetime");
            entity.Property(e => e.NgayPhatSinh).HasColumnType("datetime");
            entity.Property(e => e.NgaySanXuat).HasColumnType("datetime");
            entity.Property(e => e.NhomSanPhamId).HasColumnName("NhomSanPhamID");
            entity.Property(e => e.PhanXuongId).HasColumnName("PhanXuongID");
            entity.Property(e => e.QuyCachGoi).HasMaxLength(50);
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.SoLuongDk)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("SoLuongDK");
            entity.Property(e => e.SoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongTon).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TaiKhoanId).HasColumnName("TaiKhoanID");
            entity.Property(e => e.TenLoSanPham).HasMaxLength(200);
            entity.Property(e => e.TenSanPham).HasMaxLength(300);
        });

        modelBuilder.Entity<LoSanPhamCnm>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LoSanPhamCNM");

            entity.Property(e => e.BizChungTuId).HasColumnName("BizChungTuID");
            entity.Property(e => e.DonGia).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DonViId).HasColumnName("DonViID");
            entity.Property(e => e.DonViTinhId).HasColumnName("DonViTinhID");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.GhiChu).HasMaxLength(300);
            entity.Property(e => e.GiaTriDk)
                .HasColumnType("decimal(21, 6)")
                .HasColumnName("GiaTriDK");
            entity.Property(e => e.GiaTriNhap).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GiaTriTon).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GiaTriXuat).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.HanSuDung).HasColumnType("datetime");
            entity.Property(e => e.KhoId).HasColumnName("KhoID");
            entity.Property(e => e.KhoSanPhamId).HasColumnName("KhoSanPhamID");
            entity.Property(e => e.LoSanPhamId).HasColumnName("LoSanPhamID");
            entity.Property(e => e.LoaiChungTuId).HasColumnName("LoaiChungTuID");
            entity.Property(e => e.LoaiSanPhamId).HasColumnName("LoaiSanPhamID");
            entity.Property(e => e.MaHopNhat).HasMaxLength(150);
            entity.Property(e => e.MaSanPham).HasMaxLength(50);
            entity.Property(e => e.MaSo).HasMaxLength(250);
            entity.Property(e => e.NgayNhapTon).HasColumnType("datetime");
            entity.Property(e => e.NgayPhatSinh).HasColumnType("datetime");
            entity.Property(e => e.NgaySanXuat).HasColumnType("datetime");
            entity.Property(e => e.NhomSanPhamId).HasColumnName("NhomSanPhamID");
            entity.Property(e => e.PhanXuongId).HasColumnName("PhanXuongID");
            entity.Property(e => e.QuyCachGoi).HasMaxLength(50);
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.SoLuongDk)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("SoLuongDK");
            entity.Property(e => e.SoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongTon).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TaiKhoanId).HasColumnName("TaiKhoanID");
            entity.Property(e => e.TenLoSanPham).HasMaxLength(200);
            entity.Property(e => e.TenSanPham).HasMaxLength(300);
        });

        modelBuilder.Entity<LoSanPhamCvt>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LoSanPhamCVT");

            entity.Property(e => e.BizChungTuId).HasColumnName("BizChungTuID");
            entity.Property(e => e.DonGia).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DonViId).HasColumnName("DonViID");
            entity.Property(e => e.DonViTinhId).HasColumnName("DonViTinhID");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.GhiChu).HasMaxLength(300);
            entity.Property(e => e.GiaTriDk)
                .HasColumnType("decimal(21, 6)")
                .HasColumnName("GiaTriDK");
            entity.Property(e => e.GiaTriNhap).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GiaTriTon).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GiaTriXuat).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.HanSuDung).HasColumnType("datetime");
            entity.Property(e => e.KhoId).HasColumnName("KhoID");
            entity.Property(e => e.KhoSanPhamId).HasColumnName("KhoSanPhamID");
            entity.Property(e => e.LoSanPhamId).HasColumnName("LoSanPhamID");
            entity.Property(e => e.LoaiChungTuId).HasColumnName("LoaiChungTuID");
            entity.Property(e => e.LoaiSanPhamId).HasColumnName("LoaiSanPhamID");
            entity.Property(e => e.MaHopNhat).HasMaxLength(150);
            entity.Property(e => e.MaSanPham).HasMaxLength(50);
            entity.Property(e => e.MaSo).HasMaxLength(250);
            entity.Property(e => e.NgayNhapTon).HasColumnType("datetime");
            entity.Property(e => e.NgayPhatSinh).HasColumnType("datetime");
            entity.Property(e => e.NgaySanXuat).HasColumnType("datetime");
            entity.Property(e => e.NhomSanPhamId).HasColumnName("NhomSanPhamID");
            entity.Property(e => e.PhanXuongId).HasColumnName("PhanXuongID");
            entity.Property(e => e.QuyCachGoi).HasMaxLength(50);
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.SoLuongDk)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("SoLuongDK");
            entity.Property(e => e.SoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongTon).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TaiKhoanId).HasColumnName("TaiKhoanID");
            entity.Property(e => e.TenLoSanPham).HasMaxLength(200);
            entity.Property(e => e.TenSanPham).HasMaxLength(300);
        });

        modelBuilder.Entity<LoSanPhamK>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LoSanPhamKS");

            entity.Property(e => e.BizChungTuId).HasColumnName("BizChungTuID");
            entity.Property(e => e.DonGia).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DonViId).HasColumnName("DonViID");
            entity.Property(e => e.DonViTinhId).HasColumnName("DonViTinhID");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.GhiChu).HasMaxLength(300);
            entity.Property(e => e.GiaTriDk)
                .HasColumnType("decimal(21, 6)")
                .HasColumnName("GiaTriDK");
            entity.Property(e => e.GiaTriNhap).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GiaTriTon).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GiaTriXuat).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.HanSuDung).HasColumnType("datetime");
            entity.Property(e => e.KhoId).HasColumnName("KhoID");
            entity.Property(e => e.KhoSanPhamId).HasColumnName("KhoSanPhamID");
            entity.Property(e => e.LoSanPhamId).HasColumnName("LoSanPhamID");
            entity.Property(e => e.LoaiChungTuId).HasColumnName("LoaiChungTuID");
            entity.Property(e => e.LoaiSanPhamId).HasColumnName("LoaiSanPhamID");
            entity.Property(e => e.MaHopNhat).HasMaxLength(150);
            entity.Property(e => e.MaSanPham).HasMaxLength(50);
            entity.Property(e => e.MaSo).HasMaxLength(250);
            entity.Property(e => e.NgayNhapTon).HasColumnType("datetime");
            entity.Property(e => e.NgayPhatSinh).HasColumnType("datetime");
            entity.Property(e => e.NgaySanXuat).HasColumnType("datetime");
            entity.Property(e => e.NhomSanPhamId).HasColumnName("NhomSanPhamID");
            entity.Property(e => e.PhanXuongId).HasColumnName("PhanXuongID");
            entity.Property(e => e.QuyCachGoi).HasMaxLength(50);
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.SoLuongDk)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("SoLuongDK");
            entity.Property(e => e.SoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongTon).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TaiKhoanId).HasColumnName("TaiKhoanID");
            entity.Property(e => e.TenLoSanPham).HasMaxLength(200);
            entity.Property(e => e.TenSanPham).HasMaxLength(300);
        });

        modelBuilder.Entity<LoSanPhamKtk>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LoSanPhamKTKS");

            entity.Property(e => e.BizChungTuId).HasColumnName("BizChungTuID");
            entity.Property(e => e.DonGia).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DonViId).HasColumnName("DonViID");
            entity.Property(e => e.DonViTinhId).HasColumnName("DonViTinhID");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.GhiChu).HasMaxLength(300);
            entity.Property(e => e.GiaTriDk)
                .HasColumnType("decimal(21, 6)")
                .HasColumnName("GiaTriDK");
            entity.Property(e => e.GiaTriNhap).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GiaTriTon).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GiaTriXuat).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.HanSuDung).HasColumnType("datetime");
            entity.Property(e => e.KhoId).HasColumnName("KhoID");
            entity.Property(e => e.KhoSanPhamId).HasColumnName("KhoSanPhamID");
            entity.Property(e => e.LoSanPhamId).HasColumnName("LoSanPhamID");
            entity.Property(e => e.LoaiChungTuId).HasColumnName("LoaiChungTuID");
            entity.Property(e => e.LoaiSanPhamId).HasColumnName("LoaiSanPhamID");
            entity.Property(e => e.MaHopNhat).HasMaxLength(150);
            entity.Property(e => e.MaSanPham).HasMaxLength(50);
            entity.Property(e => e.MaSo).HasMaxLength(250);
            entity.Property(e => e.NgayNhapTon).HasColumnType("datetime");
            entity.Property(e => e.NgayPhatSinh).HasColumnType("datetime");
            entity.Property(e => e.NgaySanXuat).HasColumnType("datetime");
            entity.Property(e => e.NhomSanPhamId).HasColumnName("NhomSanPhamID");
            entity.Property(e => e.PhanXuongId).HasColumnName("PhanXuongID");
            entity.Property(e => e.QuyCachGoi).HasMaxLength(50);
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.SoLuongDk)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("SoLuongDK");
            entity.Property(e => e.SoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongTon).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TaiKhoanId).HasColumnName("TaiKhoanID");
            entity.Property(e => e.TenLoSanPham).HasMaxLength(200);
            entity.Property(e => e.TenSanPham).HasMaxLength(300);
        });

        modelBuilder.Entity<LoaiChungTu>(entity =>
        {
            entity.ToTable("LoaiChungTu");

            entity.HasIndex(e => new { e.DraftId, e.MaSo }, "IX_LoaiChungTu_UI1").IsUnique();

            entity.HasIndex(e => new { e.DraftId, e.TenLoaiChungTu }, "IX_LoaiChungTu_UI2").IsUnique();

            entity.Property(e => e.LoaiChungTuId)
                .ValueGeneratedNever()
                .HasColumnName("LoaiChungTuID");
            entity.Property(e => e.CommandCode).HasMaxLength(50);
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.FldName).HasMaxLength(100);
            entity.Property(e => e.FormId).HasColumnName("FormID");
            entity.Property(e => e.KhoIdco).HasColumnName("KhoIDCo");
            entity.Property(e => e.KhoIdno).HasColumnName("KhoIDNo");
            entity.Property(e => e.KyHieu).HasMaxLength(50);
            entity.Property(e => e.MaSo).HasMaxLength(50);
            entity.Property(e => e.NhomLoaiChungTuId).HasColumnName("NhomLoaiChungTuID");
            entity.Property(e => e.PhanXuongIdco).HasColumnName("PhanXuongIDCo");
            entity.Property(e => e.PhanXuongIdno).HasColumnName("PhanXuongIDNo");
            entity.Property(e => e.PostFixAutoCode).HasMaxLength(50);
            entity.Property(e => e.PreFixAutoCode).HasMaxLength(50);
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TaiKhoanIdco).HasColumnName("TaiKhoanIDCo");
            entity.Property(e => e.TaiKhoanIdno).HasColumnName("TaiKhoanIDNo");
            entity.Property(e => e.TenBuildin).HasMaxLength(300);
            entity.Property(e => e.TenLoaiChungTu).HasMaxLength(300);
            entity.Property(e => e.TenReport).HasMaxLength(300);
            entity.Property(e => e.TenShortCut).HasMaxLength(50);
            entity.Property(e => e.TinhChatChungTuId).HasColumnName("TinhChatChungTuID");
            entity.Property(e => e.ValidTo).HasColumnType("datetime");
        });

        modelBuilder.Entity<LoaiDoiTac>(entity =>
        {
            entity.ToTable("LoaiDoiTac");

            entity.HasIndex(e => new { e.DraftId, e.MaSo }, "IX_LoaiDoiTac_UI1").IsUnique();

            entity.HasIndex(e => new { e.DraftId, e.TenLoaiDoiTac, e.DonViId }, "IX_LoaiDoiTac_UI2").IsUnique();

            entity.Property(e => e.LoaiDoiTacId)
                .ValueGeneratedNever()
                .HasColumnName("LoaiDoiTacID");
            entity.Property(e => e.DonViId).HasColumnName("DonViID");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.MaSo).HasMaxLength(50);
            entity.Property(e => e.ParentId).HasColumnName("ParentID");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TenLoaiDoiTac).HasMaxLength(300);
            entity.Property(e => e.TinhChatDoiTacId).HasColumnName("TinhChatDoiTacID");
            entity.Property(e => e.ValidTo).HasColumnType("datetime");
        });

        modelBuilder.Entity<LoaiPhuongTien>(entity =>
        {
            entity.ToTable("LoaiPhuongTien");

            entity.HasIndex(e => new { e.DraftId, e.MaSo }, "IX_LoaiPhuongTien_UI1").IsUnique();

            entity.HasIndex(e => new { e.DraftId, e.TenLoaiPhuongTien }, "IX_LoaiPhuongTien_UI2").IsUnique();

            entity.Property(e => e.LoaiPhuongTienId)
                .ValueGeneratedNever()
                .HasColumnName("LoaiPhuongTienID");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.MaSo).HasMaxLength(50);
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TenLoaiPhuongTien).HasMaxLength(300);
            entity.Property(e => e.ValidTo).HasColumnType("datetime");
        });

        modelBuilder.Entity<LoaiSanPham>(entity =>
        {
            entity.ToTable("LoaiSanPham");

            entity.Property(e => e.LoaiSanPhamId)
                .ValueGeneratedNever()
                .HasColumnName("LoaiSanPhamID");
            entity.Property(e => e.DonViId).HasColumnName("DonViID");
            entity.Property(e => e.DonViTinh).HasMaxLength(100);
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.MaSo).HasMaxLength(50);
            entity.Property(e => e.ParentId).HasColumnName("ParentID");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TenLoaiSanPham).HasMaxLength(300);
            entity.Property(e => e.TinhChatSanPhamId).HasColumnName("TinhChatSanPhamID");
            entity.Property(e => e.ValidTo).HasColumnType("datetime");
            entity.Property(e => e.WebId).HasColumnName("WebID");
        });

        modelBuilder.Entity<LoaiSanPhamTempNum>(entity =>
        {
            entity.ToTable("LoaiSanPhamTempNum");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CurrentNum).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.LoaiChungTuId).HasColumnName("LoaiChungTuID");
        });

        modelBuilder.Entity<LoaiTaiKhoan>(entity =>
        {
            entity.ToTable("LoaiTaiKhoan");

            entity.HasIndex(e => new { e.DraftId, e.MaSo }, "IX_LoaiTaiKhoan_UI1").IsUnique();

            entity.HasIndex(e => new { e.DraftId, e.TenLoaiTaiKhoan }, "IX_LoaiTaiKhoan_UI2").IsUnique();

            entity.Property(e => e.LoaiTaiKhoanId)
                .ValueGeneratedNever()
                .HasColumnName("LoaiTaiKhoanID");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.MaSo).HasMaxLength(50);
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TenLoaiTaiKhoan).HasMaxLength(300);
            entity.Property(e => e.ValidTo).HasColumnType("datetime");
        });

        modelBuilder.Entity<LoaiThue>(entity =>
        {
            entity.ToTable("LoaiThue");

            entity.HasIndex(e => new { e.DraftId, e.MaSo }, "IX_LoaiThue_UI1").IsUnique();

            entity.HasIndex(e => new { e.DraftId, e.TenLoaiThue }, "IX_LoaiThue_UI2").IsUnique();

            entity.Property(e => e.LoaiThueId)
                .ValueGeneratedNever()
                .HasColumnName("LoaiThueID");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.MaSo).HasMaxLength(50);
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TenLoaiThue).HasMaxLength(300);
            entity.Property(e => e.ValidTo).HasColumnType("datetime");
        });

        modelBuilder.Entity<MauSac>(entity =>
        {
            entity.ToTable("MauSac");

            entity.HasIndex(e => new { e.DraftId, e.MaSo }, "IX_MauSac_UI1").IsUnique();

            entity.HasIndex(e => new { e.DraftId, e.TenMauSac }, "IX_MauSac_UI2").IsUnique();

            entity.Property(e => e.MauSacId)
                .ValueGeneratedNever()
                .HasColumnName("MauSacID");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.Hexcolor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HEXColor");
            entity.Property(e => e.KyHieu)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MaSo).HasMaxLength(50);
            entity.Property(e => e.NhomMauSacId).HasColumnName("NhomMauSacID");
            entity.Property(e => e.Rgbcolor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RGBColor");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TenMauSac).HasMaxLength(300);
            entity.Property(e => e.ValidTo).HasColumnType("datetime");
        });

        modelBuilder.Entity<MaxDataNumber>(entity =>
        {
            entity.ToTable("MaxDataNumber");

            entity.HasIndex(e => new { e.DataType, e.DataCode }, "IX_MaxDataNumber_UI1").IsUnique();

            entity.Property(e => e.MaxDataNumberId)
                .ValueGeneratedNever()
                .HasColumnName("MaxDataNumberID");
            entity.Property(e => e.DataCode).HasMaxLength(100);
            entity.Property(e => e.DataType).HasMaxLength(100);
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
        });

        modelBuilder.Entity<NghiepVu>(entity =>
        {
            entity.ToTable("NghiepVu");

            entity.Property(e => e.NghiepVuId)
                .ValueGeneratedNever()
                .HasColumnName("NghiepVuID");
            entity.Property(e => e.ChiPhiId).HasColumnName("ChiPhiID");
            entity.Property(e => e.ComId).HasColumnName("ComID");
            entity.Property(e => e.DoiTuongId).HasColumnName("DoiTuongID");
            entity.Property(e => e.DoiTuongThcpid).HasColumnName("DoiTuongTHCPID");
            entity.Property(e => e.DonViId).HasColumnName("DonViID");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.KhoId).HasColumnName("KhoID");
            entity.Property(e => e.KhoanMucId).HasColumnName("KhoanMucID");
            entity.Property(e => e.MaNhom).HasMaxLength(50);
            entity.Property(e => e.MaSo).HasMaxLength(50);
            entity.Property(e => e.NhomNghiepVuId).HasColumnName("NhomNghiepVuID");
            entity.Property(e => e.PhanXuongId).HasColumnName("PhanXuongID");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TaiKhoanIdco).HasColumnName("TaiKhoanIDCo");
            entity.Property(e => e.TaiKhoanIdno).HasColumnName("TaiKhoanIDNo");
            entity.Property(e => e.TenNghiepVu).HasMaxLength(200);
            entity.Property(e => e.ValidTo).HasColumnType("datetime");
        });

        modelBuilder.Entity<NguoiGiao>(entity =>
        {
            entity.ToTable("NguoiGiao");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Address).HasMaxLength(250);
            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.DoiTacId).HasColumnName("DoiTacID");
            entity.Property(e => e.DonViId).HasColumnName("DonViID");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(150);
            entity.Property(e => e.NgayPhatSinh).HasColumnType("datetime");
            entity.Property(e => e.Phone).HasMaxLength(50);
        });

        modelBuilder.Entity<NguoiNhan>(entity =>
        {
            entity.ToTable("NguoiNhan");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Address).HasMaxLength(250);
            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.DonViId).HasColumnName("DonViID");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(150);
            entity.Property(e => e.NgayPhatSinh).HasColumnType("datetime");
            entity.Property(e => e.PhanXuongId).HasColumnName("PhanXuongID");
            entity.Property(e => e.Phone).HasMaxLength(50);
        });

        modelBuilder.Entity<NhatKyChietKhau>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("NhatKyChietKhau");

            entity.Property(e => e.ChietKhauChiTietId).HasColumnName("ChietKhauChiTietID");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.KhoSanPhamId).HasColumnName("KhoSanPhamID");
            entity.Property(e => e.LoSanPhamCuId).HasColumnName("LoSanPhamCuID");
            entity.Property(e => e.LoSanPhamMoiId).HasColumnName("LoSanPhamMoiID");
            entity.Property(e => e.SoTonLoCu).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
        });

        modelBuilder.Entity<NhatKyChung>(entity =>
        {
            entity.ToTable("NhatKyChung");

            entity.HasIndex(e => e.ChungTuChiTietId, "IX_NhatKyChung_ChungTuChiTietID");

            entity.HasIndex(e => e.ChungTuId, "IX_NhatKyChung_ChungTuID");

            entity.HasIndex(e => e.LoaiChungTuId, "IX_NhatKyChung_LoaiChungTuID");

            entity.HasIndex(e => e.NgayPhatSinh, "IX_NhatKyChung_NgayPhatSinh");

            entity.HasIndex(e => e.TaiKhoanIdco, "IX_NhatKyChung_TaiKhoanIDCo");

            entity.HasIndex(e => e.TaiKhoanIdno, "IX_NhatKyChung_TaiKhoanIDNo");

            entity.Property(e => e.NhatKyChungId)
                .ValueGeneratedNever()
                .HasColumnName("NhatKyChungID");
            entity.Property(e => e.AsemblyName).HasMaxLength(500);
            entity.Property(e => e.ChungTuChiTietId).HasColumnName("ChungTuChiTietID");
            entity.Property(e => e.ChungTuId).HasColumnName("ChungTuID");
            entity.Property(e => e.DataId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DataID");
            entity.Property(e => e.DataName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.DataNameParent)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.DienGiaiChungTu).HasMaxLength(1000);
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.GhiChu).HasMaxLength(500);
            entity.Property(e => e.GiaTriTien).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.HoaDonId).HasColumnName("HoaDonID");
            entity.Property(e => e.HopDongId).HasColumnName("HopDongID");
            entity.Property(e => e.IdchungTu).HasColumnName("IDChungTu");
            entity.Property(e => e.KhoanMucIdco).HasColumnName("KhoanMucIDCo");
            entity.Property(e => e.KhoanMucIdno).HasColumnName("KhoanMucIDNo");
            entity.Property(e => e.KyBaoCaoId).HasColumnName("KyBaoCaoID");
            entity.Property(e => e.KyHieuHoaDon).HasMaxLength(100);
            entity.Property(e => e.LoaiChungTuId).HasColumnName("LoaiChungTuID");
            entity.Property(e => e.NamTc).HasColumnName("NamTC");
            entity.Property(e => e.NgayHachToan).HasColumnType("datetime");
            entity.Property(e => e.NgayHoaDon).HasColumnType("datetime");
            entity.Property(e => e.NgayPhanBoBatDauCo).HasColumnType("datetime");
            entity.Property(e => e.NgayPhanBoBatDauNo).HasColumnType("datetime");
            entity.Property(e => e.NgayPhanBoKetThucCo).HasColumnType("datetime");
            entity.Property(e => e.NgayPhanBoKetThucNo).HasColumnType("datetime");
            entity.Property(e => e.NgayPhatSinh).HasColumnType("datetime");
            entity.Property(e => e.NghiepVuId).HasColumnName("NghiepVuID");
            entity.Property(e => e.NoiDung).HasMaxLength(1000);
            entity.Property(e => e.SoChungTu).HasMaxLength(100);
            entity.Property(e => e.SoHoaDon).HasMaxLength(100);
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TaiKhoanIdco).HasColumnName("TaiKhoanIDCo");
            entity.Property(e => e.TaiKhoanIdno).HasColumnName("TaiKhoanIDNo");
            entity.Property(e => e.VuViecId).HasColumnName("VuViecID");
            entity.Property(e => e.VuViecIdco).HasColumnName("VuViecIDCo");
            entity.Property(e => e.VuViecIdno).HasColumnName("VuViecIDNo");
        });

        modelBuilder.Entity<NhatKyKho>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.ToTable("NhatKyKho");

            entity.HasIndex(e => e.NgayPhatSinh, "IX_NhatKyKho_NgayPhatSinh").IsClustered();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ChungTuChiTietId).HasColumnName("ChungTuChiTietID");
            entity.Property(e => e.ChungTuId).HasColumnName("ChungTuID");
            entity.Property(e => e.DonGiaCo).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DonGiaNo).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.GhiChu).HasMaxLength(500);
            entity.Property(e => e.GiaTriTien).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GiaVonXuatKhoId).HasColumnName("GiaVonXuatKhoID");
            entity.Property(e => e.IdchungTu).HasColumnName("IDChungTu");
            entity.Property(e => e.IdchungTuChiTiet).HasColumnName("IDChungTuChiTiet");
            entity.Property(e => e.KhoIdco).HasColumnName("KhoIDCo");
            entity.Property(e => e.KhoIdno).HasColumnName("KhoIDNo");
            entity.Property(e => e.KichCoIdco).HasColumnName("KichCoIDCo");
            entity.Property(e => e.KichCoIdno).HasColumnName("KichCoIDNo");
            entity.Property(e => e.KyBaoCaoId).HasColumnName("KyBaoCaoID");
            entity.Property(e => e.LoSanPhamIdco).HasColumnName("LoSanPhamIDCo");
            entity.Property(e => e.LoSanPhamIdno).HasColumnName("LoSanPhamIDNo");
            entity.Property(e => e.LoaiChungTuId).HasColumnName("LoaiChungTuID");
            entity.Property(e => e.MaSanPham).HasMaxLength(100);
            entity.Property(e => e.MauSacIdco).HasColumnName("MauSacIDCo");
            entity.Property(e => e.MauSacIdno).HasColumnName("MauSacIDNo");
            entity.Property(e => e.NamTc).HasColumnName("NamTC");
            entity.Property(e => e.NgayHachToan).HasColumnType("datetime");
            entity.Property(e => e.NgayPhatSinh).HasColumnType("datetime");
            entity.Property(e => e.NhatKyChungId).HasColumnName("NhatKyChungID");
            entity.Property(e => e.NoiDung).HasMaxLength(1000);
            entity.Property(e => e.QuyCachGoi).HasMaxLength(50);
            entity.Property(e => e.SanPhamIdco).HasColumnName("SanPhamIDCo");
            entity.Property(e => e.SanPhamIdno).HasColumnName("SanPhamIDNo");
            entity.Property(e => e.SoChungTu).HasMaxLength(100);
            entity.Property(e => e.SoLuongCo).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongNo).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TaiKhoanIdco).HasColumnName("TaiKhoanIDCo");
            entity.Property(e => e.TaiKhoanIdno).HasColumnName("TaiKhoanIDNo");
            entity.Property(e => e.TenSanPham).HasMaxLength(500);
            entity.Property(e => e.VuViecId).HasColumnName("VuViecID");
        });

        modelBuilder.Entity<NhomDoiTac>(entity =>
        {
            entity.ToTable("NhomDoiTac");

            entity.HasIndex(e => new { e.DraftId, e.MaSo }, "IX_NhomDoiTac_UI1").IsUnique();

            entity.HasIndex(e => new { e.DraftId, e.TenNhomDoiTac, e.DonViId }, "IX_NhomDoiTac_UI2").IsUnique();

            entity.Property(e => e.NhomDoiTacId)
                .ValueGeneratedNever()
                .HasColumnName("NhomDoiTacID");
            entity.Property(e => e.DonViId).HasColumnName("DonViID");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.MaSo).HasMaxLength(50);
            entity.Property(e => e.ParentId).HasColumnName("ParentID");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TenNhomDoiTac).HasMaxLength(300);
            entity.Property(e => e.TinhChatDoiTacId).HasColumnName("TinhChatDoiTacID");
            entity.Property(e => e.ValidTo).HasColumnType("datetime");
        });

        modelBuilder.Entity<NhomDonViTinh>(entity =>
        {
            entity.ToTable("NhomDonViTinh");

            entity.HasIndex(e => new { e.DraftId, e.MaSo }, "IX_NhomDonViTinh_UI1").IsUnique();

            entity.HasIndex(e => new { e.DraftId, e.TenNhomDonViTinh }, "IX_NhomDonViTinh_UI2").IsUnique();

            entity.Property(e => e.NhomDonViTinhId)
                .ValueGeneratedNever()
                .HasColumnName("NhomDonViTinhID");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.MaSo).HasMaxLength(50);
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TenNhomDonViTinh).HasMaxLength(300);
            entity.Property(e => e.ValidTo).HasColumnType("datetime");
        });

        modelBuilder.Entity<NhomKichCo>(entity =>
        {
            entity.ToTable("NhomKichCo");

            entity.HasIndex(e => new { e.DraftId, e.MaSo }, "IX_NhomKichCo_UI1").IsUnique();

            entity.Property(e => e.NhomKichCoId)
                .ValueGeneratedNever()
                .HasColumnName("NhomKichCoID");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.MaSo).HasMaxLength(50);
            entity.Property(e => e.ParentId).HasColumnName("ParentID");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TenNhomKichCo).HasMaxLength(300);
            entity.Property(e => e.ValidTo).HasColumnType("datetime");
            entity.Property(e => e.WebId).HasColumnName("WebID");
        });

        modelBuilder.Entity<NhomLoaiChungTu>(entity =>
        {
            entity.ToTable("NhomLoaiChungTu");

            entity.HasIndex(e => new { e.DraftId, e.MaSo }, "IX_NhomLoaiChungTu_UI1").IsUnique();

            entity.HasIndex(e => new { e.DraftId, e.TenNhomLoaiChungTu }, "IX_NhomLoaiChungTu_UI2").IsUnique();

            entity.Property(e => e.NhomLoaiChungTuId)
                .ValueGeneratedNever()
                .HasColumnName("NhomLoaiChungTuID");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.MaSo).HasMaxLength(50);
            entity.Property(e => e.ParentId).HasColumnName("ParentID");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TenNhomLoaiChungTu).HasMaxLength(300);
            entity.Property(e => e.ValidTo).HasColumnType("datetime");
        });

        modelBuilder.Entity<NhomMauSac>(entity =>
        {
            entity.ToTable("NhomMauSac");

            entity.HasIndex(e => new { e.DraftId, e.MaSo }, "IX_NhomMauSac_UI1").IsUnique();

            entity.Property(e => e.NhomMauSacId)
                .ValueGeneratedNever()
                .HasColumnName("NhomMauSacID");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.MaSo).HasMaxLength(50);
            entity.Property(e => e.ParentId).HasColumnName("ParentID");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TenNhomMauSac).HasMaxLength(300);
            entity.Property(e => e.ValidTo).HasColumnType("datetime");
            entity.Property(e => e.WebId).HasColumnName("WebID");
        });

        modelBuilder.Entity<NhomNghiepVu>(entity =>
        {
            entity.ToTable("NhomNghiepVu");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ComId).HasColumnName("ComID");
            entity.Property(e => e.MaSo).HasMaxLength(50);
            entity.Property(e => e.Ten).HasMaxLength(200);
        });

        modelBuilder.Entity<NhomNghiepVuHopDong>(entity =>
        {
            entity.ToTable("NhomNghiepVuHopDong");

            entity.HasIndex(e => new { e.DraftId, e.MaSo }, "IX_NhomNghiepVuHopDong_UI1").IsUnique();

            entity.HasIndex(e => new { e.DraftId, e.TenNhomNghiepVuHopDong }, "IX_NhomNghiepVuHopDong_UI2").IsUnique();

            entity.Property(e => e.NhomNghiepVuHopDongId)
                .ValueGeneratedNever()
                .HasColumnName("NhomNghiepVuHopDongID");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.FnameDoiTacCo)
                .HasMaxLength(100)
                .HasColumnName("FNameDoiTacCo");
            entity.Property(e => e.FnameDoiTacNo)
                .HasMaxLength(100)
                .HasColumnName("FNameDoiTacNo");
            entity.Property(e => e.FnameTaiKhoanNganHangCo)
                .HasMaxLength(100)
                .HasColumnName("FNameTaiKhoanNganHangCo");
            entity.Property(e => e.FnameTaiKhoanNganHangNo)
                .HasMaxLength(100)
                .HasColumnName("FNameTaiKhoanNganHangNo");
            entity.Property(e => e.Ftable)
                .HasMaxLength(100)
                .HasColumnName("FTable");
            entity.Property(e => e.GhiChu).HasMaxLength(500);
            entity.Property(e => e.MaSo).HasMaxLength(50);
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TaiKhoanCoId).HasColumnName("TaiKhoanCoID");
            entity.Property(e => e.TaiKhoanNoId).HasColumnName("TaiKhoanNoID");
            entity.Property(e => e.TenNhomNghiepVuHopDong).HasMaxLength(300);
        });

        modelBuilder.Entity<NhomSanPham>(entity =>
        {
            entity.ToTable("NhomSanPham");

            entity.HasIndex(e => new { e.DraftId, e.DonViId, e.MaSo }, "IX_NhomSanPham_UI2").IsUnique();

            entity.Property(e => e.NhomSanPhamId)
                .ValueGeneratedNever()
                .HasColumnName("NhomSanPhamID");
            entity.Property(e => e.DonViId).HasColumnName("DonViID");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.LoaiSanPhamId).HasColumnName("LoaiSanPhamID");
            entity.Property(e => e.MaSo).HasMaxLength(50);
            entity.Property(e => e.ParentId).HasColumnName("ParentID");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TenNhomSanPham).HasMaxLength(300);
            entity.Property(e => e.ValidTo).HasColumnType("datetime");
            entity.Property(e => e.YeuToChiPhiId).HasColumnName("YeuToChiPhiID");
        });

        modelBuilder.Entity<NhomThuocTinh>(entity =>
        {
            entity.ToTable("NhomThuocTinh");

            entity.HasIndex(e => new { e.DraftId, e.MaSo }, "IX_NhomThuocTinh_UI1").IsUnique();

            entity.Property(e => e.NhomThuocTinhId)
                .ValueGeneratedNever()
                .HasColumnName("NhomThuocTinhID");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.MaSo).HasMaxLength(50);
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TenNhomThuocTinh).HasMaxLength(150);
            entity.Property(e => e.TinhChatId).HasColumnName("TinhChatID");
        });

        modelBuilder.Entity<NoiDungPhieu>(entity =>
        {
            entity.ToTable("NoiDungPhieu");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.DonViId).HasColumnName("DonViID");
            entity.Property(e => e.NgayPhatSinh).HasColumnType("datetime");
            entity.Property(e => e.NoiDung).HasMaxLength(500);
        });

        modelBuilder.Entity<NotificationType>(entity =>
        {
            entity.ToTable("NotificationType");

            entity.HasIndex(e => new { e.DraftId, e.MaSo }, "IX_NotificationType_UI1").IsUnique();

            entity.Property(e => e.NotificationTypeId)
                .ValueGeneratedNever()
                .HasColumnName("NotificationTypeID");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.MaSo).HasMaxLength(50);
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TenNotificationType).HasMaxLength(150);
        });

        modelBuilder.Entity<Permission>(entity =>
        {
            entity.ToTable("permission");

            entity.Property(e => e.Permissionid).HasColumnName("permissionid");
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Permissiongroup>(entity =>
        {
            entity.ToTable("permissiongroup");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .HasColumnName("code");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasColumnName("name");
        });

        modelBuilder.Entity<PhanXuong>(entity =>
        {
            entity.ToTable("PhanXuong");

            entity.HasIndex(e => new { e.DraftId, e.MaSo, e.DonViId }, "IX_PhanXuong_UI1").IsUnique();

            entity.Property(e => e.PhanXuongId)
                .ValueGeneratedNever()
                .HasColumnName("PhanXuongID");
            entity.Property(e => e.DiaChi).HasMaxLength(300);
            entity.Property(e => e.DienThoai).HasMaxLength(300);
            entity.Property(e => e.DonViId).HasColumnName("DonViID");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.Email).HasMaxLength(300);
            entity.Property(e => e.MaSo).HasMaxLength(50);
            entity.Property(e => e.ParentId).HasColumnName("ParentID");
            entity.Property(e => e.QuanDoc).HasMaxLength(200);
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TenPhanXuong).HasMaxLength(200);
            entity.Property(e => e.ValidTo).HasColumnType("datetime");
            entity.Property(e => e.Website).HasMaxLength(300);
        });

        modelBuilder.Entity<PhiGiaoHang>(entity =>
        {
            entity.ToTable("PhiGiaoHang");

            entity.HasIndex(e => e.DraftId, "IX_PhiGiaoHang_UI1").IsUnique();

            entity.Property(e => e.PhiGiaoHangId)
                .ValueGeneratedNever()
                .HasColumnName("PhiGiaoHangID");
            entity.Property(e => e.ChietKhauBangTien).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ChietKhauTyLe).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DonGiaBaoBi).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.GhiChu).HasMaxLength(500);
            entity.Property(e => e.GiaBan1).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.GiaBan2).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.GiaBan3).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.GiaBanThanhLy).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.GiaMax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.GiaMin).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.NoiDungChietKhau).HasMaxLength(500);
            entity.Property(e => e.NoiDungThanhLy).HasMaxLength(500);
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
        });

        modelBuilder.Entity<PhuongTien>(entity =>
        {
            entity.ToTable("PhuongTien");

            entity.HasIndex(e => new { e.DraftId, e.MaSo }, "IX_PhuongTien_UI1").IsUnique();

            entity.HasIndex(e => new { e.DraftId, e.TenPhuongTien }, "IX_PhuongTien_UI2").IsUnique();

            entity.Property(e => e.PhuongTienId)
                .ValueGeneratedNever()
                .HasColumnName("PhuongTienID");
            entity.Property(e => e.BienSo).HasMaxLength(50);
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.GcnclkieuLoai)
                .HasMaxLength(50)
                .HasColumnName("GCNCLKieuLoai");
            entity.Property(e => e.KhoiLuongBanThan).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.KhoiLuongHangChuyenCho).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.KhoiLuongToanBo).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.LoaiHinhLapRap).HasMaxLength(200);
            entity.Property(e => e.MaSo).HasMaxLength(50);
            entity.Property(e => e.NgayCapGcnclkieuLoai)
                .HasColumnType("datetime")
                .HasColumnName("NgayCapGCNCLKieuLoai");
            entity.Property(e => e.NhanHieu).HasMaxLength(50);
            entity.Property(e => e.NuocSanXuatDongCo).HasMaxLength(200);
            entity.Property(e => e.NuocSanXuatKhung).HasMaxLength(200);
            entity.Property(e => e.SoDongCo).HasMaxLength(50);
            entity.Property(e => e.SoKhung).HasMaxLength(50);
            entity.Property(e => e.SoLoai).HasMaxLength(300);
            entity.Property(e => e.SoNguoiChoPhep).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TaiTrongNum).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.TaiTrongText).HasMaxLength(50);
            entity.Property(e => e.TenPhuongTien).HasMaxLength(300);
            entity.Property(e => e.TenSanPham).HasMaxLength(300);
            entity.Property(e => e.TheTichLamViecDongCo).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.ValidTo).HasColumnType("datetime");
        });

        modelBuilder.Entity<ReportRecord>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ReportRecord");

            entity.Property(e => e.ComId).HasColumnName("ComID");
            entity.Property(e => e.FromTime).HasColumnType("datetime");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.KhoId).HasColumnName("KhoID");
            entity.Property(e => e.Name).HasMaxLength(150);
            entity.Property(e => e.NhomSanPhamId).HasColumnName("NhomSanPhamID");
            entity.Property(e => e.ReportData).HasMaxLength(1024);
            entity.Property(e => e.ReportDate).HasColumnType("datetime");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.ToTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<ReportTemplate>(entity =>
        {
            entity.ToTable("ReportTemplate");

            entity.Property(e => e.ReportTemplateId)
                .ValueGeneratedNever()
                .HasColumnName("ReportTemplateID");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.FileName).HasMaxLength(100);
            entity.Property(e => e.Path).HasMaxLength(500);
            entity.Property(e => e.PrinterName).HasMaxLength(500);
            entity.Property(e => e.ReportCaption).HasMaxLength(500);
            entity.Property(e => e.ReportDesignType).HasMaxLength(500);
            entity.Property(e => e.ReportName).HasMaxLength(500);
            entity.Property(e => e.ReportTypeId).HasColumnName("ReportTypeID");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
        });

        modelBuilder.Entity<ReportType>(entity =>
        {
            entity.ToTable("ReportType");

            entity.Property(e => e.ReportTypeId)
                .ValueGeneratedNever()
                .HasColumnName("ReportTypeID");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.MaSo).HasMaxLength(50);
            entity.Property(e => e.ReportGroupId).HasColumnName("ReportGroupID");
            entity.Property(e => e.ReportTypeName).HasMaxLength(500);
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.ToTable("role");

            entity.Property(e => e.Roleid).HasColumnName("roleid");
            entity.Property(e => e.GroupId).HasMaxLength(50);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.Title).HasMaxLength(150);
        });

        modelBuilder.Entity<RolePermission>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("role_permission");

            entity.Property(e => e.Permissionid).HasColumnName("permissionid");
            entity.Property(e => e.Roleid).HasColumnName("roleid");
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.ToTable("SanPham");

            entity.HasIndex(e => e.DonViId, "IDX_SanPham_DonVi");

            entity.HasIndex(e => new { e.DonViId, e.MaSo, e.TenSanPham }, "IDX_SanPham_KeyWord");

            entity.Property(e => e.SanPhamId)
                .ValueGeneratedNever()
                .HasColumnName("SanPhamID");
            entity.Property(e => e.ChiuThueNk).HasColumnName("ChiuThueNK");
            entity.Property(e => e.ChiuThueTtdb).HasColumnName("ChiuThueTTDB");
            entity.Property(e => e.ChiuThueXk).HasColumnName("ChiuThueXK");
            entity.Property(e => e.DinhLuongDonVi).HasMaxLength(50);
            entity.Property(e => e.DinhLuongGiaTri).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DinhLuongText).HasMaxLength(200);
            entity.Property(e => e.DkmauId).HasColumnName("DKMauID");
            entity.Property(e => e.DknhanHieuId).HasColumnName("DKNhanHieuID");
            entity.Property(e => e.DksoLoaiId).HasColumnName("DKSoLoaiID");
            entity.Property(e => e.DonViId).HasColumnName("DonViID");
            entity.Property(e => e.DonViTinhId).HasColumnName("DonViTinhID");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.GhiChu).HasMaxLength(300);
            entity.Property(e => e.GiaNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.KhoId).HasColumnName("KhoID");
            entity.Property(e => e.KhoNhapLaiId).HasColumnName("KhoNhapLaiID");
            entity.Property(e => e.KhongChiuThueGtgt).HasColumnName("KhongChiuThueGTGT");
            entity.Property(e => e.KichCoId).HasColumnName("KichCoID");
            entity.Property(e => e.KieuLoaiId).HasColumnName("KieuLoaiID");
            entity.Property(e => e.LoaiSanPhamId).HasColumnName("LoaiSanPhamID");
            entity.Property(e => e.MaHopNhat).HasMaxLength(50);
            entity.Property(e => e.MaSo).HasMaxLength(50);
            entity.Property(e => e.MauSacId).HasColumnName("MauSacID");
            entity.Property(e => e.NhaCungCapId).HasColumnName("NhaCungCapID");
            entity.Property(e => e.NhomSanPhamId).HasColumnName("NhomSanPhamID");
            entity.Property(e => e.NhomThuocTinhId).HasColumnName("NhomThuocTinhID");
            entity.Property(e => e.NuocSanXuatId).HasColumnName("NuocSanXuatID");
            entity.Property(e => e.PptinhGiaVonId).HasColumnName("PPTinhGiaVonID");
            entity.Property(e => e.Qrcode).HasColumnName("QRCode");
            entity.Property(e => e.QuyCachDongGoi).HasMaxLength(200);
            entity.Property(e => e.QuyCachGoi).HasMaxLength(50);
            entity.Property(e => e.QuyCachKhoiLuongMax).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.QuyCachKhoiLuongMin).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SanPhamUnionId).HasColumnName("SanPhamUnionID");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TaiKhoanChietKhauId).HasColumnName("TaiKhoanChietKhauID");
            entity.Property(e => e.TaiKhoanDoanhThuId).HasColumnName("TaiKhoanDoanhThuID");
            entity.Property(e => e.TaiKhoanDoanhThuNoiBoId).HasColumnName("TaiKhoanDoanhThuNoiBoID");
            entity.Property(e => e.TaiKhoanGiaVonId).HasColumnName("TaiKhoanGiaVonID");
            entity.Property(e => e.TaiKhoanKhoId).HasColumnName("TaiKhoanKhoID");
            entity.Property(e => e.TaiKhoanNhapLaiId).HasColumnName("TaiKhoanNhapLaiID");
            entity.Property(e => e.TenSanPham).HasMaxLength(300);
            entity.Property(e => e.TenSanPhamDayDu).HasMaxLength(600);
            entity.Property(e => e.ThongTinBaoHanh).HasMaxLength(300);
            entity.Property(e => e.ThongTinSuDung).HasMaxLength(300);
            entity.Property(e => e.ThueSuatGtgt)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("ThueSuatGTGT");
            entity.Property(e => e.ThueSuatMoiTruong).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.ThueSuatNk)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("ThueSuatNK");
            entity.Property(e => e.ThueSuatTtdb)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("ThueSuatTTDB");
            entity.Property(e => e.ThueSuatXk)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("ThueSuatXK");
            entity.Property(e => e.ThuongHieuId).HasColumnName("ThuongHieuID");
            entity.Property(e => e.TinhChatSanPhamId).HasColumnName("TinhChatSanPhamID");
            entity.Property(e => e.ValidTo).HasColumnType("datetime");
            entity.Property(e => e.WebId).HasColumnName("WebID");
            entity.Property(e => e.YeuToChiPhiId).HasColumnName("YeuToChiPhiID");
        });

        modelBuilder.Entity<SanPhamChatLuong>(entity =>
        {
            entity.ToTable("SanPhamChatLuong");

            entity.Property(e => e.SanPhamChatLuongId)
                .ValueGeneratedNever()
                .HasColumnName("SanPhamChatLuongID");
            entity.Property(e => e.GhiChu).HasMaxLength(250);
            entity.Property(e => e.GiaTri).HasMaxLength(250);
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
        });

        modelBuilder.Entity<SanPhamDinhMuc>(entity =>
        {
            entity.ToTable("SanPhamDinhMuc");

            entity.HasIndex(e => new { e.TaiKhoanId, e.KhoId, e.SanPhamId, e.MauSacId, e.KichCoId }, "IX_SanPhamDinhMuc_UI1").IsUnique();

            entity.Property(e => e.SanPhamDinhMucId)
                .ValueGeneratedNever()
                .HasColumnName("SanPhamDinhMucID");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.GhiChu).HasMaxLength(200);
            entity.Property(e => e.GiaTriMax).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.GiaTriMin).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.KhoId).HasColumnName("KhoID");
            entity.Property(e => e.KichCoId).HasColumnName("KichCoID");
            entity.Property(e => e.MauSacId).HasColumnName("MauSacID");
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.SoLuongMax).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongMin).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TaiKhoanId).HasColumnName("TaiKhoanID");
        });

        modelBuilder.Entity<SanPhamDonViTinh>(entity =>
        {
            entity.ToTable("SanPhamDonViTinh");

            entity.Property(e => e.SanPhamDonViTinhId)
                .ValueGeneratedNever()
                .HasColumnName("SanPhamDonViTinhID");
            entity.Property(e => e.DonGiaBaoBi).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DonViTinhQuyDoi).HasMaxLength(50);
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.KyHieuDonViTinh).HasMaxLength(50);
            entity.Property(e => e.QuyCachDongGoi).HasMaxLength(200);
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.Sku)
                .HasMaxLength(50)
                .HasColumnName("SKU");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TyLeQuyDoi).HasColumnType("decimal(18, 6)");
        });

        modelBuilder.Entity<SanPhamImage>(entity =>
        {
            entity.ToTable("SanPhamImage");

            entity.Property(e => e.SanPhamImageId)
                .ValueGeneratedNever()
                .HasColumnName("SanPhamImageID");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
        });

        modelBuilder.Entity<SanPhamKichCo>(entity =>
        {
            entity.ToTable("SanPhamKichCo");

            entity.HasIndex(e => new { e.SanPhamId, e.KichCoId }, "IX_SanPhamKichCo_UI1").IsUnique();

            entity.Property(e => e.SanPhamKichCoId)
                .ValueGeneratedNever()
                .HasColumnName("SanPhamKichCoID");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.KichCoId).HasColumnName("KichCoID");
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
        });

        modelBuilder.Entity<SanPhamMauSac>(entity =>
        {
            entity.ToTable("SanPhamMauSac");

            entity.HasIndex(e => new { e.SanPhamId, e.MauSacId }, "IX_SanPhamMauSac_UI1").IsUnique();

            entity.Property(e => e.SanPhamMauSacId)
                .ValueGeneratedNever()
                .HasColumnName("SanPhamMauSacID");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.MauSacId).HasColumnName("MauSacID");
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
        });

        modelBuilder.Entity<SanPhamNum>(entity =>
        {
            entity.ToTable("SanPhamNum");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Code).HasMaxLength(10);
            entity.Property(e => e.CurrentNum).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DonViId).HasColumnName("DonViID");
        });

        modelBuilder.Entity<SanPhamUnion>(entity =>
        {
            entity.ToTable("SanPhamUnion");

            entity.HasIndex(e => new { e.DraftId, e.MaSo }, "IX_SanPhamUnion_UI1").IsUnique();

            entity.Property(e => e.SanPhamUnionId)
                .ValueGeneratedNever()
                .HasColumnName("SanPhamUnionID");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.LoaiSanPhamId).HasColumnName("LoaiSanPhamID");
            entity.Property(e => e.MaSo).HasMaxLength(50);
            entity.Property(e => e.QuyCachGoi).HasMaxLength(50);
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TenSanPhamUnion).HasMaxLength(300);
            entity.Property(e => e.ThongTinSuDung).HasMaxLength(300);
        });

        modelBuilder.Entity<SanPhamXuatXu>(entity =>
        {
            entity.ToTable("SanPhamXuatXu");

            entity.Property(e => e.SanPhamXuatXuId)
                .ValueGeneratedNever()
                .HasColumnName("SanPhamXuatXuID");
            entity.Property(e => e.GhiChu).HasMaxLength(250);
            entity.Property(e => e.GiaTri).HasMaxLength(250);
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
        });

        modelBuilder.Entity<Staff>(entity =>
        {
            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.AccountName).HasMaxLength(64);
            entity.Property(e => e.Address).HasMaxLength(250);
            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.ComId).HasColumnName("ComID");
            entity.Property(e => e.DeptId).HasColumnName("DeptID");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(150);
            entity.Property(e => e.NhanVt).HasColumnName("NhanVT");
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.Policy).HasMaxLength(512);
            entity.Property(e => e.RootId).HasColumnName("RootID");
        });

        modelBuilder.Entity<StaffKho>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StaffKho");

            entity.Property(e => e.KhoId).HasColumnName("KhoID");
            entity.Property(e => e.StaffId).HasColumnName("StaffID");
        });

        modelBuilder.Entity<SyncConfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_SyncCOnfig");

            entity.ToTable("SyncConfig");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Donviid)
                .HasMaxLength(100)
                .HasColumnName("donviid");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Syncdate)
                .HasColumnType("datetime")
                .HasColumnName("syncdate");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<TaiKhoan>(entity =>
        {
            entity.ToTable("TaiKhoan");

            entity.HasIndex(e => new { e.DraftId, e.MaSo }, "IX_TaiKhoan_UI1").IsUnique();

            entity.Property(e => e.TaiKhoanId)
                .ValueGeneratedNever()
                .HasColumnName("TaiKhoanID");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.LoaiTaiKhoanId).HasColumnName("LoaiTaiKhoanID");
            entity.Property(e => e.MaSo).HasMaxLength(50);
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TaiKhoanIdparent).HasColumnName("TaiKhoanIDParent");
            entity.Property(e => e.TenTaiKhoan).HasMaxLength(300);
            entity.Property(e => e.TinhChatTaiKhoanId).HasColumnName("TinhChatTaiKhoanID");
            entity.Property(e => e.ValidTo).HasColumnType("datetime");
        });

        modelBuilder.Entity<ToKiemNhap>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ToKiemNhap");

            entity.Property(e => e.ChucVuUyVien1).HasMaxLength(500);
            entity.Property(e => e.ChucVuUyVien2).HasMaxLength(500);
            entity.Property(e => e.ChucVuUyVien3).HasMaxLength(500);
            entity.Property(e => e.ChucVuUyVien4).HasMaxLength(500);
            entity.Property(e => e.ChucVuUyVien5).HasMaxLength(500);
            entity.Property(e => e.DonViId).HasColumnName("DonViID");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.NhanVienVatTu).HasMaxLength(500);
            entity.Property(e => e.ToTruong).HasMaxLength(500);
            entity.Property(e => e.UyVien1).HasMaxLength(500);
            entity.Property(e => e.UyVien2).HasMaxLength(500);
            entity.Property(e => e.UyVien3).HasMaxLength(500);
            entity.Property(e => e.UyVien4).HasMaxLength(500);
            entity.Property(e => e.UyVien5).HasMaxLength(500);
        });

        modelBuilder.Entity<TongHopKho>(entity =>
        {
            entity.ToTable("TongHopKho");

            entity.HasIndex(e => e.KhoId, "IX_TongHopKho_KhoID");

            entity.HasIndex(e => e.KhoSanPhamId, "IX_TongHopKho_KhoSanPhamID");

            entity.HasIndex(e => e.MaTongHop, "IX_TongHopKho_MaTongHop");

            entity.HasIndex(e => e.Ngay, "IX_TongHopKho_Ngay");

            entity.HasIndex(e => e.SanPhamId, "IX_TongHopKho_SanPhamID");

            entity.HasIndex(e => e.TaiKhoanId, "IX_TongHopKho_TaiKhoanID");

            entity.HasIndex(e => new { e.MaTongHop, e.KhoSanPhamId, e.Ngay }, "IX_TongHopKho_UI1").IsUnique();

            entity.Property(e => e.TongHopKhoId)
                .ValueGeneratedNever()
                .HasColumnName("TongHopKhoID");
            entity.Property(e => e.DieuChinhLuyKeSoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DieuChinhLuyKeSoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DieuChinhLuyKeTienNhap).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DieuChinhLuyKeTienXuat).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DieuChinhSoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DieuChinhSoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DieuChinhTienNhap).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DieuChinhTienXuat).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.GiaTriNhap).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.GiaTriXuat).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.KhoId).HasColumnName("KhoID");
            entity.Property(e => e.KhoSanPhamId).HasColumnName("KhoSanPhamID");
            entity.Property(e => e.KichCoId).HasColumnName("KichCoID");
            entity.Property(e => e.KyBaoCaoId).HasColumnName("KyBaoCaoID");
            entity.Property(e => e.LuyKeGiaTriNhap).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.LuyKeGiaTriXuat).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.LuyKeSoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.LuyKeSoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.MauSacId).HasColumnName("MauSacID");
            entity.Property(e => e.NamTc).HasColumnName("NamTC");
            entity.Property(e => e.Ngay).HasColumnType("datetime");
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.SoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TaiKhoanId).HasColumnName("TaiKhoanID");
        });

        modelBuilder.Entity<TongHopLoSanPham>(entity =>
        {
            entity.ToTable("TongHopLoSanPham");

            entity.HasIndex(e => new { e.MaTongHop, e.KhoSanPhamId, e.LoSanPhamId, e.Ngay }, "IX_TongHopLoSanPham_UI1").IsUnique();

            entity.Property(e => e.TongHopLoSanPhamId)
                .ValueGeneratedNever()
                .HasColumnName("TongHopLoSanPhamID");
            entity.Property(e => e.DieuChinhLuyKeSoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DieuChinhLuyKeSoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DieuChinhLuyKeTienNhap).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DieuChinhLuyKeTienXuat).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DieuChinhSoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DieuChinhSoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DieuChinhTienNhap).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DieuChinhTienXuat).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.GiaTriNhap).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.GiaTriXuat).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.KhoId).HasColumnName("KhoID");
            entity.Property(e => e.KhoSanPhamId).HasColumnName("KhoSanPhamID");
            entity.Property(e => e.KichCoId).HasColumnName("KichCoID");
            entity.Property(e => e.KyBaoCaoId).HasColumnName("KyBaoCaoID");
            entity.Property(e => e.LoSanPhamId).HasColumnName("LoSanPhamID");
            entity.Property(e => e.LuyKeGiaTriNhap).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.LuyKeGiaTriXuat).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.LuyKeSoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.LuyKeSoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.MauSacId).HasColumnName("MauSacID");
            entity.Property(e => e.NamTc).HasColumnName("NamTC");
            entity.Property(e => e.Ngay).HasColumnType("datetime");
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.SoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TaiKhoanId).HasColumnName("TaiKhoanID");
        });

        modelBuilder.Entity<TongHopLoSanPhamChiTiet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TongHopKhoChiTiet");

            entity.ToTable("TongHopLoSanPhamChiTiet");

            entity.HasIndex(e => new { e.DonViId, e.LoSanPhamId, e.NgayDangKy }, "IDX_TongHopLoSanPhamChiTiet");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ChungTuId).HasColumnName("ChungTuID");
            entity.Property(e => e.DonGiaLo).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DonViId).HasColumnName("DonViID");
            entity.Property(e => e.GiaTriChietKhau).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GiaTriNhap).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GiaTriXuat).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.KhoId).HasColumnName("KhoID");
            entity.Property(e => e.KhoSanPhamId).HasColumnName("KhoSanPhamID");
            entity.Property(e => e.LoSanPhamId).HasColumnName("LoSanPhamID");
            entity.Property(e => e.LoaiChungTuId).HasColumnName("LoaiChungTuID");
            entity.Property(e => e.LuyKeGiaTriChietKhau).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.LuyKeGiaTriNhap).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.LuyKeGiaTriXuat).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.LuyKeSoLuongChietKhau).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.LuyKeSoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.LuyKeSoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.MaHopNhat).HasMaxLength(150);
            entity.Property(e => e.NamTc).HasColumnName("NamTC");
            entity.Property(e => e.NgayDangKy).HasColumnType("datetime");
            entity.Property(e => e.QuyCachGoi).HasMaxLength(150);
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.SoLuongChietKhau).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.TaiKhoanId).HasColumnName("TaiKhoanID");
        });

        modelBuilder.Entity<TongHopLoSanPhamChiTietBackup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TongHopLoSanPhamChiTiet_Backup");

            entity.Property(e => e.ChungTuId).HasColumnName("ChungTuID");
            entity.Property(e => e.DonGiaLo).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DonViId).HasColumnName("DonViID");
            entity.Property(e => e.GiaTriChietKhau).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GiaTriNhap).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GiaTriXuat).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.KhoId).HasColumnName("KhoID");
            entity.Property(e => e.KhoSanPhamId).HasColumnName("KhoSanPhamID");
            entity.Property(e => e.LoSanPhamId).HasColumnName("LoSanPhamID");
            entity.Property(e => e.LoaiChungTuId).HasColumnName("LoaiChungTuID");
            entity.Property(e => e.LuyKeGiaTriChietKhau).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.LuyKeGiaTriNhap).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.LuyKeGiaTriXuat).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.LuyKeSoLuongChietKhau).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.LuyKeSoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.LuyKeSoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.MaHopNhat).HasMaxLength(150);
            entity.Property(e => e.NamTc).HasColumnName("NamTC");
            entity.Property(e => e.NgayDangKy).HasColumnType("datetime");
            entity.Property(e => e.QuyCachGoi).HasMaxLength(150);
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.SoLuongChietKhau).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.TaiKhoanId).HasColumnName("TaiKhoanID");
        });

        modelBuilder.Entity<TongHopLoSanPhamChiTietBackup2021>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TongHopLoSanPhamChiTiet_Backup2021");

            entity.Property(e => e.ChungTuId).HasColumnName("ChungTuID");
            entity.Property(e => e.DonGiaLo).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DonViId).HasColumnName("DonViID");
            entity.Property(e => e.GiaTriChietKhau).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GiaTriNhap).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GiaTriXuat).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.KhoId).HasColumnName("KhoID");
            entity.Property(e => e.KhoSanPhamId).HasColumnName("KhoSanPhamID");
            entity.Property(e => e.LoSanPhamId).HasColumnName("LoSanPhamID");
            entity.Property(e => e.LoaiChungTuId).HasColumnName("LoaiChungTuID");
            entity.Property(e => e.LuyKeGiaTriChietKhau).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.LuyKeGiaTriNhap).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.LuyKeGiaTriXuat).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.LuyKeSoLuongChietKhau).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.LuyKeSoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.LuyKeSoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.MaHopNhat).HasMaxLength(150);
            entity.Property(e => e.NamTc).HasColumnName("NamTC");
            entity.Property(e => e.NgayDangKy).HasColumnType("datetime");
            entity.Property(e => e.QuyCachGoi).HasMaxLength(150);
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.SoLuongChietKhau).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.TaiKhoanId).HasColumnName("TaiKhoanID");
        });

        modelBuilder.Entity<TongHopLoSanPhamChiTietC45>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TongHopL__3214EC27790B9472");

            entity.ToTable("TongHopLoSanPhamChiTietC45");

            entity.HasIndex(e => e.LoSanPhamId, "IDX_LoSanPhamID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ChungTuId).HasColumnName("ChungTuID");
            entity.Property(e => e.DonGiaLo).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DonViId).HasColumnName("DonViID");
            entity.Property(e => e.GiaTriChietKhau).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GiaTriNhap).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GiaTriXuat).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.KhoId).HasColumnName("KhoID");
            entity.Property(e => e.KhoSanPhamId).HasColumnName("KhoSanPhamID");
            entity.Property(e => e.LoSanPhamId).HasColumnName("LoSanPhamID");
            entity.Property(e => e.LoaiChungTuId).HasColumnName("LoaiChungTuID");
            entity.Property(e => e.LuyKeGiaTriChietKhau).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.LuyKeGiaTriNhap).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.LuyKeGiaTriXuat).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.LuyKeSoLuongChietKhau).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.LuyKeSoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.LuyKeSoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.MaHopNhat).HasMaxLength(150);
            entity.Property(e => e.NamTc).HasColumnName("NamTC");
            entity.Property(e => e.NgayDangKy).HasColumnType("datetime");
            entity.Property(e => e.QuyCachGoi).HasMaxLength(150);
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.SoLuongChietKhau).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.TaiKhoanId).HasColumnName("TaiKhoanID");
        });

        modelBuilder.Entity<TongHopLoSanPhamChiTietC790>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TongHopL__3214EC27CE4CD92B");

            entity.ToTable("TongHopLoSanPhamChiTietC790");

            entity.HasIndex(e => e.LoSanPhamId, "IDX_LoSanPhamID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ChungTuId).HasColumnName("ChungTuID");
            entity.Property(e => e.DonGiaLo).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DonViId).HasColumnName("DonViID");
            entity.Property(e => e.GiaTriChietKhau).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GiaTriNhap).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GiaTriXuat).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.KhoId).HasColumnName("KhoID");
            entity.Property(e => e.KhoSanPhamId).HasColumnName("KhoSanPhamID");
            entity.Property(e => e.LoSanPhamId).HasColumnName("LoSanPhamID");
            entity.Property(e => e.LoaiChungTuId).HasColumnName("LoaiChungTuID");
            entity.Property(e => e.LuyKeGiaTriChietKhau).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.LuyKeGiaTriNhap).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.LuyKeGiaTriXuat).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.LuyKeSoLuongChietKhau).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.LuyKeSoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.LuyKeSoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.MaHopNhat).HasMaxLength(150);
            entity.Property(e => e.NamTc).HasColumnName("NamTC");
            entity.Property(e => e.NgayDangKy).HasColumnType("datetime");
            entity.Property(e => e.QuyCachGoi).HasMaxLength(150);
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.SoLuongChietKhau).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.TaiKhoanId).HasColumnName("TaiKhoanID");
        });

        modelBuilder.Entity<TongHopLoSanPhamChiTietCca>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TongHopL__3214EC27ED8DBC1C");

            entity.ToTable("TongHopLoSanPhamChiTietCCA");

            entity.HasIndex(e => e.LoSanPhamId, "IDX_LoSanPhamID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ChungTuId).HasColumnName("ChungTuID");
            entity.Property(e => e.DonGiaLo).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DonViId).HasColumnName("DonViID");
            entity.Property(e => e.GiaTriChietKhau).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GiaTriNhap).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GiaTriXuat).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.KhoId).HasColumnName("KhoID");
            entity.Property(e => e.KhoSanPhamId).HasColumnName("KhoSanPhamID");
            entity.Property(e => e.LoSanPhamId).HasColumnName("LoSanPhamID");
            entity.Property(e => e.LoaiChungTuId).HasColumnName("LoaiChungTuID");
            entity.Property(e => e.LuyKeGiaTriChietKhau).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.LuyKeGiaTriNhap).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.LuyKeGiaTriXuat).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.LuyKeSoLuongChietKhau).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.LuyKeSoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.LuyKeSoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.MaHopNhat).HasMaxLength(150);
            entity.Property(e => e.NamTc).HasColumnName("NamTC");
            entity.Property(e => e.NgayDangKy).HasColumnType("datetime");
            entity.Property(e => e.QuyCachGoi).HasMaxLength(150);
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.SoLuongChietKhau).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.TaiKhoanId).HasColumnName("TaiKhoanID");
        });

        modelBuilder.Entity<TongHopLoSanPhamChiTietCnm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TongHopL__3214EC27ED55D416");

            entity.ToTable("TongHopLoSanPhamChiTietCNM");

            entity.HasIndex(e => e.LoSanPhamId, "IDX_LoSanPhamID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ChungTuId).HasColumnName("ChungTuID");
            entity.Property(e => e.DonGiaLo).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DonViId).HasColumnName("DonViID");
            entity.Property(e => e.GiaTriChietKhau).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GiaTriNhap).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GiaTriXuat).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.KhoId).HasColumnName("KhoID");
            entity.Property(e => e.KhoSanPhamId).HasColumnName("KhoSanPhamID");
            entity.Property(e => e.LoSanPhamId).HasColumnName("LoSanPhamID");
            entity.Property(e => e.LoaiChungTuId).HasColumnName("LoaiChungTuID");
            entity.Property(e => e.LuyKeGiaTriChietKhau).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.LuyKeGiaTriNhap).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.LuyKeGiaTriXuat).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.LuyKeSoLuongChietKhau).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.LuyKeSoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.LuyKeSoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.MaHopNhat).HasMaxLength(150);
            entity.Property(e => e.NamTc).HasColumnName("NamTC");
            entity.Property(e => e.NgayDangKy).HasColumnType("datetime");
            entity.Property(e => e.QuyCachGoi).HasMaxLength(150);
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.SoLuongChietKhau).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.TaiKhoanId).HasColumnName("TaiKhoanID");
        });

        modelBuilder.Entity<TongHopLoSanPhamChiTietCvt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TongHopL__3214EC277873B5D1");

            entity.ToTable("TongHopLoSanPhamChiTietCVT");

            entity.HasIndex(e => e.LoSanPhamId, "IDX_LoSanPhamID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ChungTuId).HasColumnName("ChungTuID");
            entity.Property(e => e.DonGiaLo).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DonViId).HasColumnName("DonViID");
            entity.Property(e => e.GiaTriChietKhau).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GiaTriNhap).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GiaTriXuat).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.KhoId).HasColumnName("KhoID");
            entity.Property(e => e.KhoSanPhamId).HasColumnName("KhoSanPhamID");
            entity.Property(e => e.LoSanPhamId).HasColumnName("LoSanPhamID");
            entity.Property(e => e.LoaiChungTuId).HasColumnName("LoaiChungTuID");
            entity.Property(e => e.LuyKeGiaTriChietKhau).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.LuyKeGiaTriNhap).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.LuyKeGiaTriXuat).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.LuyKeSoLuongChietKhau).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.LuyKeSoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.LuyKeSoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.MaHopNhat).HasMaxLength(150);
            entity.Property(e => e.NamTc).HasColumnName("NamTC");
            entity.Property(e => e.NgayDangKy).HasColumnType("datetime");
            entity.Property(e => e.QuyCachGoi).HasMaxLength(150);
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.SoLuongChietKhau).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.TaiKhoanId).HasColumnName("TaiKhoanID");
        });

        modelBuilder.Entity<TongHopLoSanPhamChiTietK>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TongHopL__3214EC2764D5ADF1");

            entity.ToTable("TongHopLoSanPhamChiTietKS");

            entity.HasIndex(e => e.LoSanPhamId, "IDX_LoSanPhamID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ChungTuId).HasColumnName("ChungTuID");
            entity.Property(e => e.DonGiaLo).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DonViId).HasColumnName("DonViID");
            entity.Property(e => e.GiaTriChietKhau).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GiaTriNhap).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GiaTriXuat).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.KhoId).HasColumnName("KhoID");
            entity.Property(e => e.KhoSanPhamId).HasColumnName("KhoSanPhamID");
            entity.Property(e => e.LoSanPhamId).HasColumnName("LoSanPhamID");
            entity.Property(e => e.LoaiChungTuId).HasColumnName("LoaiChungTuID");
            entity.Property(e => e.LuyKeGiaTriChietKhau).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.LuyKeGiaTriNhap).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.LuyKeGiaTriXuat).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.LuyKeSoLuongChietKhau).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.LuyKeSoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.LuyKeSoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.MaHopNhat).HasMaxLength(150);
            entity.Property(e => e.NamTc).HasColumnName("NamTC");
            entity.Property(e => e.NgayDangKy).HasColumnType("datetime");
            entity.Property(e => e.QuyCachGoi).HasMaxLength(150);
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.SoLuongChietKhau).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.TaiKhoanId).HasColumnName("TaiKhoanID");
        });

        modelBuilder.Entity<TongHopLoSanPhamChiTietKtk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TongHopL__3214EC27A740FAAF");

            entity.ToTable("TongHopLoSanPhamChiTietKTKS");

            entity.HasIndex(e => e.LoSanPhamId, "IDX_LoSanPhamID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ChungTuId).HasColumnName("ChungTuID");
            entity.Property(e => e.DonGiaLo).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DonViId).HasColumnName("DonViID");
            entity.Property(e => e.GiaTriChietKhau).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GiaTriNhap).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.GiaTriXuat).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.KhoId).HasColumnName("KhoID");
            entity.Property(e => e.KhoSanPhamId).HasColumnName("KhoSanPhamID");
            entity.Property(e => e.LoSanPhamId).HasColumnName("LoSanPhamID");
            entity.Property(e => e.LoaiChungTuId).HasColumnName("LoaiChungTuID");
            entity.Property(e => e.LuyKeGiaTriChietKhau).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.LuyKeGiaTriNhap).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.LuyKeGiaTriXuat).HasColumnType("decimal(21, 6)");
            entity.Property(e => e.LuyKeSoLuongChietKhau).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.LuyKeSoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.LuyKeSoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.MaHopNhat).HasMaxLength(150);
            entity.Property(e => e.NamTc).HasColumnName("NamTC");
            entity.Property(e => e.NgayDangKy).HasColumnType("datetime");
            entity.Property(e => e.QuyCachGoi).HasMaxLength(150);
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.SoLuongChietKhau).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.TaiKhoanId).HasColumnName("TaiKhoanID");
        });

        modelBuilder.Entity<TransactionDatum>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BizChungTuId).HasColumnName("BizChungTuID");
            entity.Property(e => e.DonGia).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.GiaTriNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.GiaTriXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.KhoId).HasColumnName("KhoID");
            entity.Property(e => e.KhoSanPhamId).HasColumnName("KhoSanPhamID");
            entity.Property(e => e.LoSanPhamId).HasColumnName("LoSanPhamID");
            entity.Property(e => e.NgayPhatSinh).HasColumnType("datetime");
            entity.Property(e => e.NgayThucHien).HasColumnType("datetime");
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.SoLuong).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongNhap).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongXuat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.TaiKhoanId).HasColumnName("TaiKhoanID");
            entity.Property(e => e.TongTien).HasColumnType("decimal(18, 6)");
        });

        modelBuilder.Entity<UserRole>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("user_role");

            entity.Property(e => e.Roleid).HasColumnName("roleid");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<Userdatum>(entity =>
        {
            entity.HasKey(e => e.Userid);

            entity.ToTable("userdata");

            entity.Property(e => e.Userid)
                .ValueGeneratedNever()
                .HasColumnName("userid");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.FullName).HasMaxLength(200);
            entity.Property(e => e.GroupName).HasMaxLength(50);
            entity.Property(e => e.Password)
                .HasMaxLength(64)
                .HasColumnName("password");
            entity.Property(e => e.PasswordAnswer).HasMaxLength(256);
            entity.Property(e => e.PasswordQuestion).HasMaxLength(256);
            entity.Property(e => e.PasswordSalt).HasMaxLength(128);
            entity.Property(e => e.Policy).HasMaxLength(4000);
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");
        });

        modelBuilder.Entity<WarehouseConfig>(entity =>
        {
            entity.ToTable("WarehouseConfig");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ComId).HasColumnName("ComID");
            entity.Property(e => e.DonViId).HasColumnName("DonViID");
            entity.Property(e => e.KhoSanPhamDomain).HasMaxLength(100);
            entity.Property(e => e.KhoSanPhamService).HasMaxLength(100);
            entity.Property(e => e.LoSanPhamDomain).HasMaxLength(100);
            entity.Property(e => e.LoSanPhamService).HasMaxLength(100);
            entity.Property(e => e.TongHopLoSanPhamDomain).HasMaxLength(100);
            entity.Property(e => e.TongHopLoSanPhamService).HasMaxLength(100);
        });

        modelBuilder.Entity<XuLyKiemKe>(entity =>
        {
            entity.ToTable("XuLyKiemKe");

            entity.Property(e => e.XuLyKiemKeId)
                .ValueGeneratedNever()
                .HasColumnName("XuLyKiemKeID");
            entity.Property(e => e.ChuTichHoiDong).HasMaxLength(500);
            entity.Property(e => e.ChucVuChuTichHoiDong).HasMaxLength(500);
            entity.Property(e => e.ChucVuUyVien1).HasMaxLength(500);
            entity.Property(e => e.ChucVuUyVien10).HasMaxLength(500);
            entity.Property(e => e.ChucVuUyVien2).HasMaxLength(500);
            entity.Property(e => e.ChucVuUyVien3).HasMaxLength(500);
            entity.Property(e => e.ChucVuUyVien4).HasMaxLength(500);
            entity.Property(e => e.ChucVuUyVien5).HasMaxLength(500);
            entity.Property(e => e.ChucVuUyVien6).HasMaxLength(500);
            entity.Property(e => e.ChucVuUyVien7).HasMaxLength(500);
            entity.Property(e => e.ChucVuUyVien8).HasMaxLength(500);
            entity.Property(e => e.ChucVuUyVien9).HasMaxLength(500);
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.GhiChu).HasMaxLength(200);
            entity.Property(e => e.InputId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("InputID");
            entity.Property(e => e.KhoKiemKeId).HasColumnName("KhoKiemKeID");
            entity.Property(e => e.KiemKeKhoId).HasColumnName("KiemKeKhoID");
            entity.Property(e => e.LoaiChungTuId).HasColumnName("LoaiChungTuID");
            entity.Property(e => e.LyDoChungTuId).HasColumnName("LyDoChungTuID");
            entity.Property(e => e.NamPs).HasColumnName("NamPS");
            entity.Property(e => e.NgayChotSo).HasColumnType("datetime");
            entity.Property(e => e.NgayDieuChinh).HasColumnType("datetime");
            entity.Property(e => e.NgayPhatSinh).HasColumnType("datetime");
            entity.Property(e => e.NhanVienGiamSatId).HasColumnName("NhanVienGiamSatID");
            entity.Property(e => e.NhanVienKeToanId).HasColumnName("NhanVienKeToanID");
            entity.Property(e => e.NhanVienKiemKeId).HasColumnName("NhanVienKiemKeID");
            entity.Property(e => e.NoiDungKiemKe).HasMaxLength(500);
            entity.Property(e => e.SoHieu).HasMaxLength(50);
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TaiKhoanKhoId).HasColumnName("TaiKhoanKhoID");
            entity.Property(e => e.ThongTinNhanVienGiamSat).HasMaxLength(500);
            entity.Property(e => e.ThongTinNhanVienKeToan).HasMaxLength(500);
            entity.Property(e => e.ThongTinNhanVienKiemKe).HasMaxLength(500);
            entity.Property(e => e.ThongTinThuKho).HasMaxLength(500);
            entity.Property(e => e.ThuKhoId).HasColumnName("ThuKhoID");
            entity.Property(e => e.UyVien1).HasMaxLength(500);
            entity.Property(e => e.UyVien10).HasMaxLength(500);
            entity.Property(e => e.UyVien2).HasMaxLength(500);
            entity.Property(e => e.UyVien3).HasMaxLength(500);
            entity.Property(e => e.UyVien4).HasMaxLength(500);
            entity.Property(e => e.UyVien5).HasMaxLength(500);
            entity.Property(e => e.UyVien6).HasMaxLength(500);
            entity.Property(e => e.UyVien7).HasMaxLength(500);
            entity.Property(e => e.UyVien8).HasMaxLength(500);
            entity.Property(e => e.UyVien9).HasMaxLength(500);
        });

        modelBuilder.Entity<XuLyKiemKeChiTiet>(entity =>
        {
            entity.ToTable("XuLyKiemKeChiTiet");

            entity.Property(e => e.XuLyKiemKeChiTietId)
                .ValueGeneratedNever()
                .HasColumnName("XuLyKiemKeChiTietID");
            entity.Property(e => e.DonGiaChenhLech).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DonGiaDieuChinh).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DonGiaKiemKe).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DonGiaSoSach).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.GhiChu).HasMaxLength(500);
            entity.Property(e => e.GiaTriChenhLech).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.GiaTriDieuChinh).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.GiaTriKiemKe).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.GiaTriSoSach).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.KhoKiemKeId).HasColumnName("KhoKiemKeID");
            entity.Property(e => e.LoSanPhamId).HasColumnName("LoSanPhamID");
            entity.Property(e => e.LoaiChungTuId).HasColumnName("LoaiChungTuID");
            entity.Property(e => e.NamPs).HasColumnName("NamPS");
            entity.Property(e => e.NgayPhatSinh).HasColumnType("datetime");
            entity.Property(e => e.NhomSanPhamId).HasColumnName("NhomSanPhamID");
            entity.Property(e => e.SanPhamDonViTinhId).HasColumnName("SanPhamDonViTinhID");
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.SoLuong).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongChenhLech).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongDieuChinh).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongHachToan).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SoLuongSoSach).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TaiKhoanKhoId).HasColumnName("TaiKhoanKhoID");
            entity.Property(e => e.XuLyKiemKeId).HasColumnName("XuLyKiemKeID");
        });

        modelBuilder.Entity<YeuToChiPhi>(entity =>
        {
            entity.ToTable("YeuToChiPhi");

            entity.HasIndex(e => new { e.MaSo, e.SsClientId }, "IX_YeuToChiPhi_UI1").IsUnique();

            entity.Property(e => e.YeuToChiPhiId)
                .ValueGeneratedNever()
                .HasColumnName("YeuToChiPhiID");
            entity.Property(e => e.DonViTinh).HasMaxLength(100);
            entity.Property(e => e.DraftId).HasColumnName("DraftID");
            entity.Property(e => e.MaSo).HasMaxLength(50);
            entity.Property(e => e.ParentId).HasColumnName("ParentID");
            entity.Property(e => e.SsClientId).HasColumnName("SS_ClientID");
            entity.Property(e => e.SsCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_CreatedAt");
            entity.Property(e => e.SsCreatedBy).HasColumnName("SS_CreatedBy");
            entity.Property(e => e.SsIsDeleted).HasColumnName("SS_IsDeleted");
            entity.Property(e => e.SsIsLocked).HasColumnName("SS_IsLocked");
            entity.Property(e => e.SsLocationId).HasColumnName("SS_LocationID");
            entity.Property(e => e.SsUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("SS_UpdatedAt");
            entity.Property(e => e.SsUpdatedBy).HasColumnName("SS_UpdatedBy");
            entity.Property(e => e.TenYeuToChiPhi).HasMaxLength(300);
            entity.Property(e => e.ValidTo).HasColumnType("datetime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
