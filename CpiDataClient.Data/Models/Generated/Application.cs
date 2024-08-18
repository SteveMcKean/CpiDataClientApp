using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class Application
{
    public Guid Id { get; set; }

    public string ApplicationName { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual ICollection<ConfigurationParameter> ConfigurationParameters { get; set; } = new List<ConfigurationParameter>();
}
