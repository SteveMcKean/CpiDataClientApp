using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class WarehousePack
{
    public Guid Id { get; set; }

    public Guid SkuId { get; set; }

    public int? Width { get; set; }

    public int? Length { get; set; }

    public int? Height { get; set; }

    public int? Weight { get; set; }

    public int? WarehousePackPackageTypeId { get; set; }

    public bool IsManualPickOnly { get; set; }

    public decimal? RoboticPickEligibleScore { get; set; }

    public DateTime? RoboticPickScoreDate { get; set; }

    public string? MeasurementStation { get; set; }

    public int MeasuredBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual MeasuredBy MeasuredByNavigation { get; set; } = null!;

    public virtual Sku Sku { get; set; } = null!;

    public virtual WarehousePackPackageType? WarehousePackPackageType { get; set; }

    public virtual ICollection<WarehousePackHandlingProfileType> WarehousePackHandlingProfileTypes { get; set; } = new List<WarehousePackHandlingProfileType>();
}
