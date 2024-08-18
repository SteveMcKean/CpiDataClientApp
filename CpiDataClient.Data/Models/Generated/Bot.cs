using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class Bot
{
    public Guid Id { get; set; }

    public string Number { get; set; } = null!;

    public string? AddressEndPointIp { get; set; }

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

    public string? MacAddress1 { get; set; }

    public string? MacAddress2 { get; set; }

    public string? RfId1 { get; set; }

    public string? RfId2 { get; set; }

    public string? Vin { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public int ModelType { get; set; }

    public virtual ICollection<BotAlertLog> BotAlertLogs { get; set; } = new List<BotAlertLog>();

    public virtual ICollection<BotMaintenanceLog> BotMaintenanceLogs { get; set; } = new List<BotMaintenanceLog>();

    public virtual BotPullDetail? BotPullDetail { get; set; }

    public virtual BotState? BotState { get; set; }

    public virtual ICollection<BotWarehouseState> BotWarehouseStates { get; set; } = new List<BotWarehouseState>();

    public virtual ICollection<BotWorkOrder> BotWorkOrders { get; set; } = new List<BotWorkOrder>();

    public virtual BotModel ModelTypeNavigation { get; set; } = null!;

    public virtual ICollection<TaskPlan> TaskPlans { get; set; } = new List<TaskPlan>();
}
