using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class OutboundCarton
{
    public Guid Id { get; set; }

    public DateTimeOffset? OnBotTime { get; set; }

    public DateTimeOffset? OnCartonLiftTime { get; set; }

    public DateTimeOffset? OnConveyorTime { get; set; }

    public DateTimeOffset? RoutedToDestinationTime { get; set; }

    public DateTimeOffset? DeliveredTime { get; set; }

    public DateTimeOffset? PalletizedTime { get; set; }

    public DateTimeOffset? PurgedTime { get; set; }

    public int? RejectReason { get; set; }

    public DateTimeOffset? RejectedTime { get; set; }

    public int? OutboundDestination { get; set; }

    public int? DestinationGroup { get; set; }

    public Guid? DestinationId { get; set; }

    public Guid? CartonLabelId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public int IsOutbounding { get; set; }

    public DateTimeOffset? OnLiftArmTime { get; set; }

    public DateTimeOffset? OnLiftPnDtime { get; set; }

    public virtual CartonLabel? CartonLabel { get; set; }

    public virtual Destination? Destination { get; set; }

    public virtual Carton IdNavigation { get; set; } = null!;

    public virtual OutboundDestination? OutboundDestinationNavigation { get; set; }

    public virtual ICollection<CartonRequest> CartonRequests { get; set; } = new List<CartonRequest>();
}
