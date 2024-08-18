using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class ShelfModule
{
    public int Id { get; set; }

    public int Number { get; set; }

    public int? BottomOfShelf { get; set; }

    public int? Height { get; set; }

    public int? Width { get; set; }

    public int? MaxStorageHeight { get; set; }

    public int? MaxStorageWeight { get; set; }
}
