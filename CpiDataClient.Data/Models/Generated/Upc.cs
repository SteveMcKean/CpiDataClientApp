using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class Upc
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual ICollection<Carton> Cartons { get; set; } = new List<Carton>();

    public virtual ICollection<Sku> Skus { get; set; } = new List<Sku>();
}
