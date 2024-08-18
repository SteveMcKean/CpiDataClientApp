using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class SkusTemp
{
    public Guid Id { get; set; }

    public string Sku { get; set; } = null!;

    public int? AllergenTypeId { get; set; }

    public string? Upc { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public int ProductTypes { get; set; }

    public int? Width { get; set; }

    public int? Length { get; set; }

    public int? Height { get; set; }

    public int? Weight { get; set; }

    public int SlottedState { get; set; }

    public bool IsTaught { get; set; }

    public bool IsUpcavailable { get; set; }

    public bool IsProblemUpc { get; set; }

    public bool IsEligible { get; set; }

    public int OutboundConveyorProgram { get; set; }

    public int OutboundRobotProgram { get; set; }

    public double GripForce { get; set; }

    public int RotationWindowDays { get; set; }

    public int CasesPerLayer { get; set; }

    public int LayersPerPallet { get; set; }

    public int LeadEdgeOrientation { get; set; }

    public int Vcp { get; set; }

    public int Ssp { get; set; }

    public bool IsDateSensitive { get; set; }

    public int HoldState { get; set; }

    public int? ReconTypeAction { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public int? MaxCartonsPerPickface { get; set; }

    public bool IsFridgePack { get; set; }

    public bool IsPressurized { get; set; }

    public int? PackagingTypeId { get; set; }

    public int PalletizationGroupTypeId { get; set; }

    public bool? IsCodeDated { get; set; }

    public bool? IsAutoDepal { get; set; }

    public string? ItemUpc { get; set; }

    public string? Description2 { get; set; }

    public string? Color { get; set; }

    public string? ItemSize { get; set; }

    public int? WarehousePerVendorPack { get; set; }

    public bool LithiumIndicator { get; set; }

    public int? Fhscode { get; set; }

    public int? SegregationCode { get; set; }

    public string? MaterialType { get; set; }

    public string? VendorStockNo { get; set; }

    public string? VendorName { get; set; }

    public string? OriginalRequest { get; set; }

    public bool? IsFragile { get; set; }

    public bool IsUnknown { get; set; }

    public int BreakPackEligible { get; set; }

    public bool? IsBreakPackEligibleCustomer { get; set; }

    public bool? IsBreakPackEligibleOverride { get; set; }

    public int? RelativePalletPlacement { get; set; }

    public int? SegregationZoneId { get; set; }
}
