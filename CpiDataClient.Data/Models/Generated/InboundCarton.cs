using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class InboundCarton
{
    public Guid Id { get; set; }

    public DateTimeOffset? OnConveyorTime { get; set; }

    public DateTimeOffset? OnCartonLiftTime { get; set; }

    public DateTimeOffset? PickfaceTime { get; set; }

    public DateTimeOffset? OnBotTime { get; set; }

    public DateTimeOffset? OnShelfTime { get; set; }

    public DateTimeOffset? PurgeTime { get; set; }

    public Guid? RejectConveyorId { get; set; }

    public int? RejectReason { get; set; }

    public DateTimeOffset? RejectTime { get; set; }

    public int? InboundDestination { get; set; }

    public Guid? InboundConveyorId { get; set; }

    public string? CustomerCartonGroupRef { get; set; }

    public Guid? InboundId { get; set; }

    public Guid? InboundLpnid { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTimeOffset? ReportedTime { get; set; }

    public string? ConveyorCaseId { get; set; }

    public DateTimeOffset? OnLiftArmTime { get; set; }

    public DateTimeOffset? OnLiftBufferTime { get; set; }

    public virtual Carton IdNavigation { get; set; } = null!;

    public virtual Inbound? Inbound { get; set; }

    public virtual ConveyorLane1? InboundConveyor { get; set; }

    public virtual InboundDestination? InboundDestinationNavigation { get; set; }

    public virtual InboundLpn? InboundLpn { get; set; }

    public virtual ConveyorLane1? RejectConveyor { get; set; }

    public virtual ICollection<InboundCartonRejectReason> InboundCartonRejectReasons { get; set; } = new List<InboundCartonRejectReason>();
}
