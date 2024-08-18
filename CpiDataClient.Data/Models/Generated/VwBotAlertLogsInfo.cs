using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwBotAlertLogsInfo
{
    public Guid BotId { get; set; }

    public Guid? LevelId { get; set; }

    public Guid? StructureLocationId { get; set; }

    public int DynamicStateXposition { get; set; }

    public int DynamicStateYposition { get; set; }

    public int DynamicStateYaw { get; set; }

    public int? DynamicStateLinearVel { get; set; }

    public int? DynamicStateRotationVel { get; set; }

    public int WheelRadiusLeftWheelRadius { get; set; }

    public int WheelRadiusRightWheelRadius { get; set; }

    public int PulseWidthFrontPulseWidth { get; set; }

    public int PulseWidthRearPulseWidth { get; set; }

    public int ThumperScoreLeftThumperScore { get; set; }

    public int ThumperScoreRightThumperScore { get; set; }

    public string? TractionDriveDrive { get; set; }

    public string? TractionDriveErrorString { get; set; }

    public int? PositionUncertainPositionError { get; set; }

    public int? PositionUncertainEstimateVariance { get; set; }

    public int? LineSensorReportFrontLineScore { get; set; }

    public int? LineSensorReportRearLineScore { get; set; }

    public int? CasePutIntoCaseErrorX1 { get; set; }

    public int? CasePutIntoCaseErrorX2 { get; set; }

    public int? CasePutIntoCaseErrorY1 { get; set; }

    public int? CasePutIntoCaseErrorY2 { get; set; }

    public int? ExtensionTimeoutPosition { get; set; }

    public string? ExtensionTimeoutDirection { get; set; }

    public int Odometer { get; set; }

    public int? UnderVoltage { get; set; }

    public int? SlotSensorPulseWidth { get; set; }

    public int? SlotSensorScore { get; set; }

    public int? TurnCount { get; set; }

    public int? ExcessiveHoldingForce { get; set; }

    public int? DeckLineWarningErrorCount { get; set; }

    public int? CasterUnlockFailureLevel { get; set; }

    public int? AutoLocateNoBarcode { get; set; }

    public int? AutoLocateCrcfail { get; set; }

    public int? MotionWhileDisabledError { get; set; }

    public int? WrongLevelErrorExpected { get; set; }

    public int? WrongLevelErrorObserved { get; set; }

    public int? WhichArm { get; set; }

    public int? PickAir { get; set; }

    public int? BadCaseDimensionErrorExpectedDepth { get; set; }

    public int? BadCaseDimensionErrorMeasuredDepth { get; set; }

    public string? RollerTimeoutReason { get; set; }

    public int? CaseLenOutOfToleranceErrorExpectedDepth { get; set; }

    public int? CaseLenOutOfToleranceErrorMeasuredDepth { get; set; }

    public int? BladeTargetOutOfRangeErrorFront { get; set; }

    public int? BladeTargetOutOfRangeErrorRear { get; set; }

    public int? BladeTargetOutOfRangeErrorType { get; set; }

    public int? CaseHandlingDisabled { get; set; }

    public int? ExtensionRetractFail { get; set; }

    public int? OverhangingCase { get; set; }

    public int? CannotSecurePayload { get; set; }

    public int? ExperimentalMisc { get; set; }

    public int? RecoverySuccess { get; set; }

    public int? SensorWarningSensor { get; set; }

    public int? SensorWarningIssue { get; set; }

    public int? SystemInitializationFailureAxis { get; set; }

    public int? SystemInitializationFailureErrorCode { get; set; }

    public int? UnimplementedModerateErrorsNoWayPoints { get; set; }

    public int? UnimplementedModerateErrorsTooManyWayPoints { get; set; }

    public int? UnimplementedModerateErrorsPlanningError { get; set; }

    public int? UnimplementedModerateErrorsCasePickNotPlanned { get; set; }

    public int? UnimplementedModerateErrorsCasePickNotIdle { get; set; }

    public int? UnimplementedFatalErrorsNotInitialised { get; set; }

    public int? UnimplementedFatalErrorsNotActive { get; set; }

    public int? UnimplementedFatalErrorsFeatureMapError { get; set; }

    public int? UnimplementedFatalErrorsCaseBayCalculation { get; set; }

    public int? UnimplementedFatalErrorsRoverAlertNotinit { get; set; }

    public int? UnimplementedFatalErrorsRoverAlertBadargs { get; set; }

    public int? InternalErrorGenericError { get; set; }

    public int? InventoryCheckResultsCaseGroupNumber { get; set; }

    public int? InventoryCheckResultsCasePickDepth { get; set; }

    public int? InventoryCheckResultsCaseYaw { get; set; }

    public int? InventoryCheckResultsCenterPointX { get; set; }

    public int? InventoryCheckResultsCenterPointY { get; set; }

    public int? InventoryCheckResultsLowerXpoint { get; set; }

    public int? InventoryCheckResultsLowerYpoint { get; set; }

    public int? InventoryCheckResultsUpperXpoint { get; set; }

    public int? InventoryCheckResultsUpperYpoint { get; set; }

    public Guid AlertsLogId { get; set; }

    public DateTimeOffset AlertsLogCreatedTime { get; set; }

    public int? AlertContext { get; set; }

    public string BotNumber { get; set; } = null!;

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

    public Guid AlertsId { get; set; }

    public int AlertCode { get; set; }

    public int AlertType { get; set; }

    public string HardwareOriginType { get; set; } = null!;

    public int Severity { get; set; }

    public string ResolutionOwner { get; set; } = null!;

    public string Publisher { get; set; } = null!;

    public int RelevanceTime { get; set; }

    public string Description { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string RecoveryOptions { get; set; } = null!;

    public int LevelNumber { get; set; }

    public string? LevelName { get; set; }

    public int Height { get; set; }
}
