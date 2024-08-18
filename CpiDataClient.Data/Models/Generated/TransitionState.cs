using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class TransitionState
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<AisleState> AisleStates { get; set; } = new List<AisleState>();

    public virtual ICollection<DeckState> DeckStates { get; set; } = new List<DeckState>();

    public virtual ICollection<DrivewayState> DrivewayStates { get; set; } = new List<DrivewayState>();

    public virtual ICollection<LevelModuleState> LevelModuleStates { get; set; } = new List<LevelModuleState>();

    public virtual ICollection<ZoneState> ZoneStates { get; set; } = new List<ZoneState>();
}
