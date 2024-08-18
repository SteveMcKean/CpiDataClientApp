using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VersionLog
{
    public int Id { get; set; }

    public DateTimeOffset TimeStamp { get; set; }

    public string SqlVersion { get; set; } = null!;

    public int SqlCompatibilityLevel { get; set; }

    public bool SqlReadCommittedSnapshot { get; set; }

    public string Odsversion { get; set; } = null!;
}
