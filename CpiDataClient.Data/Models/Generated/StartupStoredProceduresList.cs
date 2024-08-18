using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class StartupStoredProceduresList
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string DisplayName { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int DisplayOrder { get; set; }

    public bool IsActive { get; set; }
}
