using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class BotLiftLevel
{
    public int Id { get; set; }

    public string? BotLiftName { get; set; }

    public int? LevelId { get; set; }
}
