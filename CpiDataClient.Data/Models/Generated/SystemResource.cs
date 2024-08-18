using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class SystemResource
{
    public int SystemResourcesSk { get; set; }

    public string SystemResourcesData { get; set; } = null!;

    public DateTimeOffset CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTimeOffset ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public bool? IsActive { get; set; }

    public Guid? StructureFileId { get; set; }

    public string ApiVersion { get; set; } = null!;

    public virtual StructureFile1? StructureFile { get; set; }
}
