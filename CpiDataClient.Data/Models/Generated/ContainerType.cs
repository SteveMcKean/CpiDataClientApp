using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class ContainerType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<CartonRequest> CartonRequests { get; set; } = new List<CartonRequest>();

    public virtual ICollection<Carton> Cartons { get; set; } = new List<Carton>();

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
