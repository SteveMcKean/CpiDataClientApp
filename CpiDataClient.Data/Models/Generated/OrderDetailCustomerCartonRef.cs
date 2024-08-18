using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class OrderDetailCustomerCartonRef
{
    public Guid Id { get; set; }

    public Guid OrderDetailId { get; set; }

    public string CustomerCartonRef { get; set; } = null!;

    public Guid SessionKey { get; set; }
}
