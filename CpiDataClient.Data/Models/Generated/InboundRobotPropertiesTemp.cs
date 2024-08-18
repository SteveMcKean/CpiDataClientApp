using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class InboundRobotPropertiesTemp
{
    public Guid Id { get; set; }

    public int LayerHeight { get; set; }

    public int DelayerPlatePressure { get; set; }

    public int DelayerClosePlatesDelay { get; set; }

    public int DelayerRobotAcceleration { get; set; }

    public int DelayerPickNumber { get; set; }

    public int SingulatorRobotAcceleration { get; set; }

    public int SupportLayoutN { get; set; }

    public int SupportLayoutM { get; set; }

    public int ReducedSupport { get; set; }

    public int SingulatorPickStrengthShortSide { get; set; }

    public int SingulatorPickStrengthLongSide { get; set; }

    public int VisionPickMode { get; set; }

    public int TopStrength { get; set; }

    public string ProfileName { get; set; } = null!;

    public int RobotConfigurationProfileId { get; set; }
}
