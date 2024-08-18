using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class BotModel
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public int BotWidth { get; set; }

    public int BotHeight { get; set; }

    public int MaxSpeed { get; set; }

    public int MaxAcceleration { get; set; }

    public int MaxDeceleration { get; set; }

    public string? FirmwareVersion { get; set; }

    public int FingerExtensionTime { get; set; }

    public int MaxChargeMvolts { get; set; }

    public int MinChargeMvolts { get; set; }

    public int ChargeTrigger { get; set; }

    public int Mass { get; set; }

    public int CasePickTime { get; set; }

    public int CasePutTime { get; set; }

    public int DeckRailTransitionWaitTime { get; set; }

    public int UltraCapCapacitance { get; set; }

    public int MaxChargingCurrent { get; set; }

    public double MotorResistance20 { get; set; }

    public double MotorResistance100 { get; set; }

    public int MaxAmpMotorAcceleration { get; set; }

    public int MaxAmpMotorDeceleration { get; set; }

    public int ResistanceStaticDeck { get; set; }

    public int ResistanceStaticAisle { get; set; }

    public int ResistanceRollingDeck { get; set; }

    public int ResistanceRollingAisle { get; set; }

    public double DragCoefficient { get; set; }

    public double MotorDriveEfficiency { get; set; }

    public double HotelLoad { get; set; }

    public double UltraCapResistance { get; set; }

    public double Rotate90EnergyRate { get; set; }

    public double Rotate180EnergyRate { get; set; }

    public double TransferEnergyRate { get; set; }

    public int MaxCaseLength { get; set; }

    public int MaxCaseDepth { get; set; }

    public int MaxPayloadWeight { get; set; }

    public int? MinCaseMass { get; set; }

    public int? BotPayloadCenterOffset { get; set; }

    public int? ExtentsX { get; set; }

    public int? ExtentsY { get; set; }

    public int? MinCaseDepth { get; set; }

    public int? MinCaseHeight { get; set; }

    public int? MinCaseWidth { get; set; }

    public int? MinEdgeStorageLocationLength { get; set; }

    public int? MinStorageLocationLength { get; set; }

    public int? RefOriginX { get; set; }

    public int? RefOriginY { get; set; }

    public int? MaxAisleSpeed { get; set; }

    public int? MaxDeckSpeed { get; set; }

    public int? DistanceFromCedsensorToFrontOfBot { get; set; }

    public int? DistanceFromCedsensorToRearOfBot { get; set; }

    public int? PayloadBayLength { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public virtual ICollection<Bot> Bots { get; set; } = new List<Bot>();
}
