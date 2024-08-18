using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class ToteLocationDiscrepancy
{
    public int Id { get; set; }

    public string Sku { get; set; } = null!;

    public Guid CartonId { get; set; }

    public Guid Lpnid { get; set; }

    public string CustomerCartonRef { get; set; } = null!;

    public int Vcp { get; set; }

    public int Ssp { get; set; }

    public int NumEaches { get; set; }

    public int ContainerTypeId { get; set; }

    public int? SkuholdState { get; set; }

    public int? LpnholdState { get; set; }

    public DateTime DateCreated { get; set; }
}
