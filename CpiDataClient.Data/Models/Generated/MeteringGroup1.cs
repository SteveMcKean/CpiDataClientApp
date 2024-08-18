using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class MeteringGroup1
{
    public int Id { get; set; }

    public string MeteringGroupId { get; set; } = null!;

    public string? Name { get; set; }

    public string? Path { get; set; }

    public string? Type { get; set; }
}
