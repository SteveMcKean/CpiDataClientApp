using System;
using System.Collections.Generic;

namespace ODS.Models;

/// <summary>
/// A row is inserted in this table each time we receive any allocation messages.
/// </summary>
public partial class MessagesToPublish
{
    /// <summary>
    /// Primary Key that is Identity column.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Unique Identifier of the message.
    /// </summary>
    public string MessageId { get; set; } = null!;

    /// <summary>
    /// Message in json format that is being received.
    /// </summary>
    public string Message { get; set; } = null!;

    /// <summary>
    /// MessageType of the Message being received.
    /// </summary>
    public string MessageType { get; set; } = null!;

    /// <summary>
    /// Flag to indicate if the adjustement was applied or not. 1 means the tote contents are valid and adjustment is applied.
    /// </summary>
    public bool IsContentsValid { get; set; }

    /// <summary>
    /// CreatedTime for the record in UTC.
    /// </summary>
    public DateTime CreatedDate { get; set; }

    /// <summary>
    /// Time in UTC that this record was last modified.
    /// </summary>
    public DateTime? ModifiedDate { get; set; }
}
