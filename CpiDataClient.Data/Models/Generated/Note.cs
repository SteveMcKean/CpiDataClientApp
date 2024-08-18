using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class Note
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string Content { get; set; } = null!;

    public string? AssetName { get; set; }

    public DateTimeOffset NoteTime { get; set; }

    public string AuthorUserName { get; set; } = null!;

    public string? AudienceRole { get; set; }

    public bool IsFlagged { get; set; }

    public bool IsIncludedOnShiftReport { get; set; }

    public Guid? ShiftId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual Shift? Shift { get; set; }
}
