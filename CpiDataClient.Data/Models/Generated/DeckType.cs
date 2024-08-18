using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class DeckType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Deck1> Deck1s { get; set; } = new List<Deck1>();
}
