using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class OrderCartonType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
