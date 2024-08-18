using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class BotLiftReader
{
    public int Id { get; set; }

    public string? BotLiftName { get; set; }

    public int? ReaderId { get; set; }
}
