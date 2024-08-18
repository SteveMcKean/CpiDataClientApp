﻿using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class OrderState
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
