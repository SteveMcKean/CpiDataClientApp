using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class DeckLine
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Length { get; set; }

    public int Width { get; set; }

    public int DeckRef { get; set; }

    public int Type { get; set; }

    public int Orientation { get; set; }

    public int OriginX { get; set; }

    public int OriginY { get; set; }

    public string? AisleDwRef { get; set; }

    public int LevelMapModelId { get; set; }

    public int? DeckLineId { get; set; }

    public virtual DeckLineType TypeNavigation { get; set; } = null!;
}
