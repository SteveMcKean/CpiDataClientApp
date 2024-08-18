using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class Sku
{
    public Guid Id { get; set; }

    public string Sku1 { get; set; } = null!;

    public int AllergenTypeId { get; set; }

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

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public int? MaxCartonsPerPickface { get; set; }

    public bool IsFridgePack { get; set; }

    public bool IsPressurized { get; set; }

    public int PackagingTypeId { get; set; }

    public int PalletizationGroupTypeId { get; set; }

    public bool? IsFragile { get; set; }

    public bool IsUnknown { get; set; }

    public int BreakPackEligible { get; set; }

    public bool? IsBreakPackEligibleCustomer { get; set; }

    public bool? IsBreakPackEligibleOverride { get; set; }

    public bool? IsBreakPackEligible { get; set; }

    public int? RelativePalletPlacement { get; set; }

    public int? SegregationZoneId { get; set; }

    public virtual AllergenType AllergenType { get; set; } = null!;

    public virtual BreakPackEligible BreakPackEligibleNavigation { get; set; } = null!;

    public virtual ICollection<CartonRequest> CartonRequests { get; set; } = new List<CartonRequest>();

    public virtual ICollection<Carton> Cartons { get; set; } = new List<Carton>();

    public virtual ICollection<Forecast> Forecasts { get; set; } = new List<Forecast>();

    public virtual HoldState HoldStateNavigation { get; set; } = null!;

    public virtual ICollection<InboundDimensionalVariant> InboundDimensionalVariants { get; set; } = new List<InboundDimensionalVariant>();

    public virtual ICollection<InboundForecast> InboundForecasts { get; set; } = new List<InboundForecast>();

    public virtual LeadEdgeOrientation LeadEdgeOrientationNavigation { get; set; } = null!;

    public virtual ICollection<Lpn> Lpns { get; set; } = new List<Lpn>();

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual ICollection<OutboundDimensionalVariant> OutboundDimensionalVariants { get; set; } = new List<OutboundDimensionalVariant>();

    public virtual PackagingType PackagingType { get; set; } = null!;

    public virtual PalletizationGroupType PalletizationGroupType { get; set; } = null!;

    public virtual ProductType ProductTypesNavigation { get; set; } = null!;

    public virtual Zone? SegregationZone { get; set; }

    public virtual ICollection<SkuExtension> SkuExtensions { get; set; } = new List<SkuExtension>();

    public virtual SkuSubstitution? SkuSubstitutionSourceSku { get; set; }

    public virtual ICollection<SkuSubstitution> SkuSubstitutionSubstituteSkus { get; set; } = new List<SkuSubstitution>();

    public virtual SkusExtensionDatum? SkusExtensionDatum { get; set; }

    public virtual SlottedState SlottedStateNavigation { get; set; } = null!;

    public virtual WarehousePack? WarehousePack { get; set; }

    public virtual ICollection<Upc> Upcs { get; set; } = new List<Upc>();
}
