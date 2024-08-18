using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class CandidateCustomerCartonRef
{
    public Guid Id { get; set; }

    public Guid OrderDetailId { get; set; }

    public string CustomerCartonRef { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual OrderDetail OrderDetail { get; set; } = null!;
}
