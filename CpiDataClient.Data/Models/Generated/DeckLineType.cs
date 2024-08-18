using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class DeckLineType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<DeckLine1> DeckLine1s { get; set; } = new List<DeckLine1>();

    public virtual ICollection<DeckLine> DeckLines { get; set; } = new List<DeckLine>();
}
