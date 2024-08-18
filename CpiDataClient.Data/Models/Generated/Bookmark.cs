using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class Bookmark
{
    public Guid Id { get; set; }

    public int View { get; set; }

    public string Detail { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual BookmarkView ViewNavigation { get; set; } = null!;
}
