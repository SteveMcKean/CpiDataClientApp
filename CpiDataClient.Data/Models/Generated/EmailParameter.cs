using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class EmailParameter
{
    public int Id { get; set; }

    public string ProfileName { get; set; } = null!;

    public string EmailSubject { get; set; } = null!;

    public string Recipients { get; set; } = null!;

    public string? Ccrecipients { get; set; }

    public DateTime CreatedDate { get; set; }

    public bool IsActive { get; set; }
}
