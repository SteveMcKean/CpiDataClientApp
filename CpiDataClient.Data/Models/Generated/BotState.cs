using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class BotState
{
    public Guid Id { get; set; }

    public DateTimeOffset StateTime { get; set; }

    public int WheelRadiusLeftWheelRadius { get; set; }

    public int WheelRadiusRightWheelRadius { get; set; }

    public int OdometerReading { get; set; }

    public int ThumperScoreLeftThumperScore { get; set; }

    public int ThumperScoreRightThumperScore { get; set; }

    public int SlotSensorPulseWidth { get; set; }

    public int HoldingForce { get; set; }

    public int HoldingForceX { get; set; }

    public int HoldingForceY { get; set; }

    public int SlatSensorRear { get; set; }

    public int SlatSensorFront { get; set; }

    public int? LineSensorReportFrontLineScore { get; set; }

    public int? LineSensorReportRearLineScore { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual Bot IdNavigation { get; set; } = null!;
}
