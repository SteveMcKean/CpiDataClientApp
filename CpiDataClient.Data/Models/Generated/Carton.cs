using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class Carton
{
    public Guid Id { get; set; }

    public string CustomerCartonRef { get; set; } = null!;

    public DateTimeOffset? EnteringWarehouseTime { get; set; }

    public DateTimeOffset? StoredTime { get; set; }

    public DateTimeOffset? ExitingWarehouseTime { get; set; }

    public int Width { get; set; }

    public int Length { get; set; }

    public int Height { get; set; }

    public int Weight { get; set; }

    public bool DimensionsOverwritten { get; set; }

    public int StoredOrientation { get; set; }

    public bool IsOpenCase { get; set; }

    public int Ssp { get; set; }

    public int Vcp { get; set; }

    public int Eaches { get; set; }

    public int ProductTypes { get; set; }

    public DateTimeOffset? ExpirationDate { get; set; }

    public int? AppointmentNumber { get; set; }

    public int? Ponumber { get; set; }

    public bool IsMarkedForReprint { get; set; }

    public int State { get; set; }

    public DateTimeOffset? StateChangeTime { get; set; }

    public string? HoldReason { get; set; }

    public DateTimeOffset? CartonHoldTime { get; set; }

    public bool InTransition { get; set; }

    public DateTimeOffset? TransitionReleaseDate { get; set; }

    public DateTimeOffset Fifodate { get; set; }

    public string? AlternateContainerRef { get; set; }

    public DateTimeOffset? ShelfLifeReportStartTime { get; set; }

    public bool IsOutlier { get; set; }

    public int? ReceiptId { get; set; }

    public Guid SkuId { get; set; }

    public Guid? LpnId { get; set; }

    public Guid? UpcId { get; set; }

    public Guid? OutboundDimVarId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public string? Batch { get; set; }

    public string? SourceFacility { get; set; }

    public int? LabelTypeId { get; set; }

    public string? StoreLabel { get; set; }

    public int? StoreNumber { get; set; }

    public int ContainerTypeId { get; set; }

    public string? HandlingDimensions { get; set; }

    public string? DeliveryGroup { get; set; }

    public bool EnableDimensionCheck { get; set; }

    public bool IsActiveCustomerCartonRef { get; set; }

    public int OuterWidth { get; set; }

    public int OuterLength { get; set; }

    public int OuterHeight { get; set; }

    public int? BotMeasuredWidth { get; set; }

    public int? BotMeasuredLength { get; set; }

    public int StoredWidth { get; set; }

    public int StoredLength { get; set; }

    public bool IsExceptionProcessingRequired { get; set; }

    public int? WarehousePacksCount { get; set; }

    public virtual ICollection<CartonExtension> CartonExtensions { get; set; } = new List<CartonExtension>();

    public virtual ICollection<CartonScan> CartonScans { get; set; } = new List<CartonScan>();

    public virtual ContainerType ContainerType { get; set; } = null!;

    public virtual ICollection<ExceptionProcessingRequiredDetail> ExceptionProcessingRequiredDetails { get; set; } = new List<ExceptionProcessingRequiredDetail>();

    public virtual InboundCarton? InboundCarton { get; set; }

    public virtual ICollection<InboundCartonLabel> InboundCartonLabels { get; set; } = new List<InboundCartonLabel>();

    public virtual ICollection<InboundConveyorLoadCarton> InboundConveyorLoadCartons { get; set; } = new List<InboundConveyorLoadCarton>();

    public virtual ICollection<Inventory> Inventories { get; set; } = new List<Inventory>();

    public virtual LabelType? LabelType { get; set; }

    public virtual Lpn? Lpn { get; set; }

    public virtual OutboundCarton? OutboundCarton { get; set; }

    public virtual OutboundDimensionalVariant? OutboundDimVar { get; set; }

    public virtual RemovedCarton? RemovedCarton { get; set; }

    public virtual ICollection<ShakeAndSealLoad> ShakeAndSealLoads { get; set; } = new List<ShakeAndSealLoad>();

    public virtual Sku Sku { get; set; } = null!;

    public virtual CartonState StateNavigation { get; set; } = null!;

    public virtual LeadEdgeOrientation StoredOrientationNavigation { get; set; } = null!;

    public virtual ICollection<TaskPlanCarton> TaskPlanCartons { get; set; } = new List<TaskPlanCarton>();

    public virtual ICollection<TransferBufferLoadCarton> TransferBufferLoadCartons { get; set; } = new List<TransferBufferLoadCarton>();

    public virtual Upc? Upc { get; set; }
}
