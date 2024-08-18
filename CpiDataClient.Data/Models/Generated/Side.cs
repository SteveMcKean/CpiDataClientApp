using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class Side
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Bay1> Bay1s { get; set; } = new List<Bay1>();

    public virtual ICollection<BreakpackLoop1> BreakpackLoop1s { get; set; } = new List<BreakpackLoop1>();

    public virtual ICollection<Shelf1> Shelf1s { get; set; } = new List<Shelf1>();

    public virtual ICollection<TransferBuffer1> TransferBuffer1s { get; set; } = new List<TransferBuffer1>();
}
