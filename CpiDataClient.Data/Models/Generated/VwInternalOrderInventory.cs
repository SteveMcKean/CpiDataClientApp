using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwInternalOrderInventory
{
    public Guid Id { get; set; }

    public int CaseGroupNumber { get; set; }

    public string? CustomerCartonGroupRef { get; set; }

    public string CustomerCartonRef { get; set; } = null!;

    public int ItemType { get; set; }

    public int? SuspectType { get; set; }

    public DateTimeOffset? ExpirationDate { get; set; }

    public int? AppointmentNumber { get; set; }

    public int? Ponumber { get; set; }

    public int State { get; set; }

    public string Sku { get; set; } = null!;

    public string? LicensePlateNumber { get; set; }

    public string? Batch { get; set; }

    public string? SourceFacility { get; set; }

    public string? Upc { get; set; }

    public string? SkuDescription { get; set; }

    public string? LabelTypeName { get; set; }

    public Guid InventoryId { get; set; }

    public Guid? CartonId { get; set; }

    public DateTimeOffset? EnteringWarehouseTime { get; set; }

    public int ProductTypes { get; set; }

    public string? HoldReason { get; set; }

    public Guid SkuId { get; set; }

    public int? LabelTypeId { get; set; }

    public Guid? LpnId { get; set; }

    public Guid? UpcId { get; set; }

    public DateTime CreatedDate { get; set; }

    public bool? IsSuspect { get; set; }

    public int CartonHoldState { get; set; }

    public int SkuHoldState { get; set; }

    public int? LpnHoldState { get; set; }

    public int ContainerType { get; set; }

    public bool IsExceptionProcessingRequired { get; set; }
}
