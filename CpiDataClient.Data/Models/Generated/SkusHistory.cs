using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class SkusHistory
{
    public Guid Id { get; set; }

    public string Sku { get; set; } = null!;

    public int AllergenTypeId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public int ProductTypes { get; set; }

    public int Width { get; set; }

    public int Length { get; set; }

    public int Height { get; set; }

    public int Weight { get; set; }

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

    public DateTime CreatedDate { get; set; }

    public DateTime ModifiedDate { get; set; }

    public int? MaxCartonsPerPickface { get; set; }

    public bool IsFridgePack { get; set; }

    public bool IsPressurized { get; set; }

    public int? PackagingTypeId { get; set; }

    public int? PalletizationGroupTypeId { get; set; }

    public bool? IsFragile { get; set; }

    public int BreakPackEligible { get; set; }

    public bool? IsBreakPackEligibleCustomer { get; set; }

    public bool? IsBreakPackEligibleOverride { get; set; }

    public int? RelativePalletPlacement { get; set; }

    public string? Upc { get; set; }

    public bool? IsUnknown { get; set; }

    public int? SegregationZoneId { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }
}
