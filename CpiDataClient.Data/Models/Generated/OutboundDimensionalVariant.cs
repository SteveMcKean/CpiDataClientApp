using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class OutboundDimensionalVariant
{
    public int RecordNumber { get; set; }

    public Guid Id { get; set; }

    public Guid SkuId { get; set; }

    public int Tolerance { get; set; }

    public int WeightTolerance { get; set; }

    public int CartonLength { get; set; }

    public int CartonWidth { get; set; }

    public int CartonHeight { get; set; }

    public int CartonWeight { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public int OdvTypeId { get; set; }

    public virtual ICollection<CartonRequest> CartonRequests { get; set; } = new List<CartonRequest>();

    public virtual ICollection<Carton> Cartons { get; set; } = new List<Carton>();

    public virtual OdvType OdvType { get; set; } = null!;

    public virtual Sku Sku { get; set; } = null!;
}
