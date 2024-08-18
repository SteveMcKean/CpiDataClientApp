using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class InboundLpn
{
    public int RecordNumber { get; set; }

    public Guid Id { get; set; }

    public Guid Lpnid { get; set; }

    public Guid? PalletLayerId { get; set; }

    public int? CartonsInducted { get; set; }

    public int? CartonsScratched { get; set; }

    public int? CartonsRejectedOutOfTolerance { get; set; }

    public int? CartonsRejectedDamaged { get; set; }

    public int? CartonsExpected { get; set; }

    public int NumCasesRejectedUnreadableUpc { get; set; }

    public int NumCasesRejectedUnknownUpc { get; set; }

    public int NumCasesRejectedLpnRejected { get; set; }

    public int NumCasesRemovedNotRejected { get; set; }

    public int? NumCasesNotInducted { get; set; }

    public int? NumCasesRejectedOutOfTolerance { get; set; }

    public int? NumCasesRemoved { get; set; }

    public int? NumCasesOnRejectedPallet { get; set; }

    public int? NumCasesInducted { get; set; }

    public int AutoReceivingStatus { get; set; }

    public string? InductionType { get; set; }

    public string? PurchaseOrderNumber { get; set; }

    public int? LpnrejectReasonId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual AutoReceivingStatus AutoReceivingStatusNavigation { get; set; } = null!;

    public virtual ICollection<InboundCarton> InboundCartons { get; set; } = new List<InboundCarton>();

    public virtual Lpn Lpn { get; set; } = null!;

    public virtual LpnrejectReason? LpnrejectReason { get; set; }

    public virtual PalletLayer? PalletLayer { get; set; }
}
