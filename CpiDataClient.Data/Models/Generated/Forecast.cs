using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class Forecast
{
    public Guid Id { get; set; }

    public DateTimeOffset ForecastDate { get; set; }

    public int Quantity { get; set; }

    public Guid SkuId { get; set; }

    public bool IsForPromotion { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual Sku Sku { get; set; } = null!;
}
