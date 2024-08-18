using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class SelectedCustomerCartonRef
{
    public Guid Id { get; set; }

    public Guid CartonRequestId { get; set; }

    public string CustomerCartonRef { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual CartonRequest CartonRequest { get; set; } = null!;
}
