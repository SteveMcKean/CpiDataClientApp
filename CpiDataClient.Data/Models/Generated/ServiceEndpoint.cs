using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class ServiceEndpoint
{
    public int Id { get; set; }

    public string? Address { get; set; }

    public string? Contract { get; set; }

    public string? Name { get; set; }

    public int? Type { get; set; }

    public string? SubSystemId { get; set; }
}
