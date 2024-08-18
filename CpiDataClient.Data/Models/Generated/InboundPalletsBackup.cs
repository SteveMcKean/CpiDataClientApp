using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class InboundPalletsBackup
{
    public Guid InboundPalletId { get; set; }

    public int OrgPalletState { get; set; }

    public int NewPalletState { get; set; }

    public short OrgDepalletizerId { get; set; }

    public short NewDepalletizerId { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public DateTimeOffset UpdatedOn { get; set; }
}
