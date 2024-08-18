using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class BookmarkView
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Bookmark> Bookmarks { get; set; } = new List<Bookmark>();
}
