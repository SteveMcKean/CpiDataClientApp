using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class StructureFile
{
    public int Id { get; set; }

    public string FileName { get; set; } = null!;

    public string? PackageName { get; set; }

    public string? PackageVersion { get; set; }

    public string StructureMapVersion { get; set; } = null!;

    public string? ContentXml { get; set; }

    public string? Customer { get; set; }

    public string? Site { get; set; }

    public string? SystemMode { get; set; }
}
