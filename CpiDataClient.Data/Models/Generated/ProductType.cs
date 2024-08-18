using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class ProductType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<InboundForecast> InboundForecasts { get; set; } = new List<InboundForecast>();

    public virtual ICollection<Inventory> Inventories { get; set; } = new List<Inventory>();

    public virtual ICollection<Sku> Skus { get; set; } = new List<Sku>();
}
