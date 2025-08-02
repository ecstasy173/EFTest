using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class NhatKyChietKhau
{
    public long Id { get; set; }

    public Guid? SsClientId { get; set; }

    public DateTime? SsCreatedAt { get; set; }

    public Guid? KhoSanPhamId { get; set; }

    public long? ChietKhauChiTietId { get; set; }

    public Guid? LoSanPhamCuId { get; set; }

    public Guid? LoSanPhamMoiId { get; set; }

    public decimal? SoTonLoCu { get; set; }
}
