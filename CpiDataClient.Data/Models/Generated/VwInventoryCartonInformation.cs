using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwInventoryCartonInformation
{
    public Guid? Id { get; set; }

    public Guid? CartonId { get; set; }

    public int CaseGroupNumber { get; set; }

    public string? CustomerCartonGroupRef { get; set; }

    public string CustomerCartonRef { get; set; } = null!;

    public int? SuspectType { get; set; }

    public int? SuspectReportedBy { get; set; }

    public DateTimeOffset? SuspectTime { get; set; }

    public DateTimeOffset? SuspectClearTime { get; set; }

    public int? SuspectReason { get; set; }

    public int? SuspectResolution { get; set; }

    public int? SuspectAction { get; set; }

    public int? SuspectLocationSubState { get; set; }

    public int? ShelfLocationOffsetX { get; set; }

    public int? ShelfLocationOffsetY { get; set; }

    public int? ShelfLocationCartonOffsetX { get; set; }

    public int? ShelfLocationCartonOffsetY { get; set; }

    public DateTimeOffset? EnteringWarehouseTime { get; set; }

    public int? ShelfLocationWidth { get; set; }

    public int Width { get; set; }

    public int Length { get; set; }

    public int Height { get; set; }

    public int Weight { get; set; }

    public int StoredOrientation { get; set; }

    public bool IsOpenCase { get; set; }

    public int Ssp { get; set; }

    public int Vcp { get; set; }

    public int Eaches { get; set; }

    public int ProductTypes { get; set; }

    public DateTimeOffset? ExpirationDate { get; set; }

    public int State { get; set; }

    public string? HoldReason { get; set; }

    public bool InTransition { get; set; }

    public string? AlternateContainerRef { get; set; }

    public string? LicensePlateNumber { get; set; }

    public string? Batch { get; set; }

    public string? SourceFacility { get; set; }

    public string Sku { get; set; } = null!;

    public int AllergenTypeId { get; set; }

    public string? Upc { get; set; }

    public string? SkuName { get; set; }

    public string? SkuDescription { get; set; }

    public Guid ShelfId { get; set; }

    public int ShelfNumber { get; set; }

    public string? ShelfName { get; set; }

    public int ShelfSide { get; set; }

    public int OffsetX { get; set; }

    public int OffsetY { get; set; }

    public int ShelfWidth { get; set; }

    public Guid BayId { get; set; }

    public int BayNumber { get; set; }

    public string? BayName { get; set; }

    public int AisleNumber { get; set; }

    public int LevelNumber { get; set; }

    public int ModuleNumber { get; set; }

    public int ZoneNumber { get; set; }

    public string? LpnExtensionPonumber { get; set; }

    public string? ReceiverNo { get; set; }

    public string? PocreateDate { get; set; }

    public bool? IsSuspect { get; set; }

    public int CartonHoldState { get; set; }

    public int SkuHoldState { get; set; }

    public int? LpnHoldState { get; set; }

    public int ContainerType { get; set; }

    public string? FreightType { get; set; }

    public int CartonOuterHeight { get; set; }

    public int CartonOuterWidth { get; set; }

    public int CartonOuterLength { get; set; }
}
