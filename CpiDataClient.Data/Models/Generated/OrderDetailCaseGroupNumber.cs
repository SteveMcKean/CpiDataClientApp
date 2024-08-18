using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class OrderDetailCaseGroupNumber
{
    public Guid Id { get; set; }

    public Guid OrderDetailId { get; set; }

    public int CaseGroupNumber { get; set; }

    public bool EligibleForCr { get; set; }

    public int? IneligibilityReasonId { get; set; }

    public Guid SessionKey { get; set; }
}
