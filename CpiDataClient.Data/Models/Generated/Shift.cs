using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class Shift
{
    public Guid Id { get; set; }

    public DateTimeOffset ShiftStart { get; set; }

    public DateTimeOffset? ShiftEnd { get; set; }

    public int ShiftState { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual ICollection<Note> Notes { get; set; } = new List<Note>();

    public virtual ShiftState ShiftStateNavigation { get; set; } = null!;
}
