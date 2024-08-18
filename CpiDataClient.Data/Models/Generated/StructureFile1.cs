using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class StructureFile1
{
    public Guid Id { get; set; }

    public string FileName { get; set; } = null!;

    public string? PackageName { get; set; }

    public string? PackageVersion { get; set; }

    public string StructureMapVersion { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public string? ContentXml { get; set; }

    public bool? IsActive { get; set; }

    public string? Customer { get; set; }

    public string? Site { get; set; }

    public string? SystemMode { get; set; }

    public virtual ICollection<SystemResource> SystemResources { get; set; } = new List<SystemResource>();
}
