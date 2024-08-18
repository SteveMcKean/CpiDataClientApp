using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwBotAlertLog
{
    public Guid Id { get; set; }

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
}
