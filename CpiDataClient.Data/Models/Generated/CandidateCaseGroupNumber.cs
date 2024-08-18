using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class CandidateCaseGroupNumber
{
    public Guid Id { get; set; }

    public Guid OrderDetailId { get; set; }

    public int CaseGroupNumber { get; set; }

    public bool EligibleForCr { get; set; }

    public int? IneligibilityReasonId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual IneligibilityReason? IneligibilityReason { get; set; }

    public virtual OrderDetail OrderDetail { get; set; } = null!;
}
