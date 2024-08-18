using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class ErrorLog
{
    /// <summary>
    /// Primary Key that is Identity column.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Unique Identifier of the message.
    /// </summary>
    public Guid MessageId { get; set; }

    /// <summary>
    /// Level at which the error is logged
    /// </summary>
    public string ErrorSource { get; set; } = null!;

    /// <summary>
    /// Error Message
    /// </summary>
    public string? ErrorMessage { get; set; }

    /// <summary>
    /// Time in UTC that this record is logged
    /// </summary>
    public DateTime CreatedDate { get; set; }
}
