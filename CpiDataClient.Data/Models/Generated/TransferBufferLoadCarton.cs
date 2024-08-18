using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class TransferBufferLoadCarton
{
    public Guid Id { get; set; }

    public int Position { get; set; }

    public Guid CartonId { get; set; }

    public Guid TransferBufferLoadId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual Carton Carton { get; set; } = null!;

    public virtual TransferBufferLoad TransferBufferLoad { get; set; } = null!;
}
