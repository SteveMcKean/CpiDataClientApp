using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class InboundForecast
{
    public Guid Id { get; set; }

    public DateTimeOffset? ForecastReceiveDateTime { get; set; }

    public DateTimeOffset? ShiftStartDate { get; set; }

    public string Shift { get; set; } = null!;

    public int? BatchId { get; set; }

    public int? AppointmentNumber { get; set; }

    public string AppointmentType { get; set; } = null!;

    public int ExpectedCartonQuantity { get; set; }

    public string ProcessType { get; set; } = null!;

    public int Width { get; set; }

    public int Length { get; set; }

    public int Height { get; set; }

    public int Weight { get; set; }

    public int ProductTypes { get; set; }

    public Guid SkuId { get; set; }

    public Guid ScheduledShiftId { get; set; }

    public Guid? InboundId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual Inbound? Inbound { get; set; }

    public virtual ProductType ProductTypesNavigation { get; set; } = null!;

    public virtual ScheduledShift ScheduledShift { get; set; } = null!;

    public virtual Sku Sku { get; set; } = null!;
}
