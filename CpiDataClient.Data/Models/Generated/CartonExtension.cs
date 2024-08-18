using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class CartonExtension
{
    public Guid Id { get; set; }

    /// <summary>
    /// FK Ref Inventory.Cartons.ID
    /// </summary>
    public Guid CartonId { get; set; }

    /// <summary>
    /// FK Ref Extension.CartonExtensionKey.Id.
    /// </summary>
    public int ExtensionKeyId { get; set; }

    public string ExtensionValue { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual Carton Carton { get; set; } = null!;

    public virtual CartonExtensionKey ExtensionKey { get; set; } = null!;
}
