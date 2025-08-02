using System;
using System.Collections.Generic;

namespace EFCore.Core.Domain.Entities;

public partial class ReportTemplate
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

    public Guid ReportTemplateId { get; set; }

    public string? ReportName { get; set; }

    public string? ReportCaption { get; set; }

    public Guid? ReportTypeId { get; set; }

    public string? MauQuyChuan { get; set; }

    public bool? InNhieuLien { get; set; }

    public int? SoLienMacDinh { get; set; }

    public string? FileName { get; set; }

    public string? Path { get; set; }

    public int? LineNo { get; set; }

    public string? MoTa { get; set; }

    public string? HeaderText { get; set; }

    public string? FooterText { get; set; }

    public string? ReportDesignType { get; set; }

    public string? PrinterName { get; set; }

    public bool? IsDefault { get; set; }

    public bool? IsBuildIn { get; set; }

    public string? CondTaiKhoanNo { get; set; }

    public string? CondTaiKhoanCo { get; set; }

    public string? CondExtend01 { get; set; }

    public string? CondExtend02 { get; set; }

    public string? CondExtend03 { get; set; }

    public string? CondExtend04 { get; set; }

    public string? CondExtend05 { get; set; }

    public string? CondExtend06 { get; set; }

    public string? CondExtend07 { get; set; }

    public string? CondExtend08 { get; set; }

    public string? CondExtend09 { get; set; }

    public string? CondExtend10 { get; set; }
}
