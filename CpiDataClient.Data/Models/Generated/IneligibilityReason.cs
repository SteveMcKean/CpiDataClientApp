using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class IneligibilityReason
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<CandidateCaseGroupNumber> CandidateCaseGroupNumbers { get; set; } = new List<CandidateCaseGroupNumber>();
}
