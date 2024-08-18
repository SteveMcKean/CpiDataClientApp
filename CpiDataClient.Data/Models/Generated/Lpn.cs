using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class Lpn
{
    public Guid Id { get; set; }

    public string LicensePlateNumber { get; set; } = null!;

    public Guid SkuId { get; set; }

    public DateTimeOffset? ReceivedDate { get; set; }

    public DateTimeOffset? InductionDate { get; set; }

    public DateTimeOffset? ExpirationDate { get; set; }

    public string? Batch { get; set; }

    public string? SourceFacility { get; set; }

    public int HoldState { get; set; }

    public bool IsInternal { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public int? StoreNumber { get; set; }

    public int? LabelTypeId { get; set; }

    public bool IsReceivingRequested { get; set; }

    public string? CellGroup { get; set; }

    public virtual ICollection<CartonRequest> CartonRequests { get; set; } = new List<CartonRequest>();

    public virtual ICollection<Carton> Cartons { get; set; } = new List<Carton>();

    public virtual HoldState HoldStateNavigation { get; set; } = null!;

    public virtual ICollection<InboundLpn> InboundLpns { get; set; } = new List<InboundLpn>();

    public virtual LabelType? LabelType { get; set; }

    public virtual ICollection<Lpnextension> Lpnextensions { get; set; } = new List<Lpnextension>();

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual Sku Sku { get; set; } = null!;
}
