using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ODS.Models;

namespace ODS.Data;

public partial class OdsContext : DbContext
{
    public OdsContext()
    {
    }

    public OdsContext(DbContextOptions<OdsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Aisle> Aisles { get; set; }

    public virtual DbSet<Aisle1> Aisles1 { get; set; }

    public virtual DbSet<AisleState> AisleStates { get; set; }

    public virtual DbSet<AisleStatesTombstone> AisleStatesTombstones { get; set; }

    public virtual DbSet<AisleType> AisleTypes { get; set; }

    public virtual DbSet<Alert> Alerts { get; set; }

    public virtual DbSet<Alert1> Alerts1 { get; set; }

    public virtual DbSet<AlertDefinition> AlertDefinitions { get; set; }

    public virtual DbSet<AlertExtension> AlertExtensions { get; set; }

    public virtual DbSet<AlertExtensionField> AlertExtensionFields { get; set; }

    public virtual DbSet<AlertItem> AlertItems { get; set; }

    public virtual DbSet<AlertItemWork> AlertItemWorks { get; set; }

    public virtual DbSet<AlertLog> AlertLogs { get; set; }

    public virtual DbSet<AlertLogsWork> AlertLogsWorks { get; set; }

    public virtual DbSet<AlertSeverity> AlertSeverities { get; set; }

    public virtual DbSet<AlertType> AlertTypes { get; set; }

    public virtual DbSet<AllergenType> AllergenTypes { get; set; }

    public virtual DbSet<AllocationAvailabilityState> AllocationAvailabilityStates { get; set; }

    public virtual DbSet<AllocationLog> AllocationLogs { get; set; }

    public virtual DbSet<AllocationMessage> AllocationMessages { get; set; }

    public virtual DbSet<AllocationPoolType> AllocationPoolTypes { get; set; }

    public virtual DbSet<Annotation> Annotations { get; set; }

    public virtual DbSet<AnnotationsTombstone> AnnotationsTombstones { get; set; }

    public virtual DbSet<Application> Applications { get; set; }

    public virtual DbSet<AssetType> AssetTypes { get; set; }

    public virtual DbSet<AuditTrailEvent> AuditTrailEvents { get; set; }

    public virtual DbSet<AuditTrailGroup> AuditTrailGroups { get; set; }

    public virtual DbSet<AuditTrailLog> AuditTrailLogs { get; set; }

    public virtual DbSet<AuditTrailLogsWork> AuditTrailLogsWorks { get; set; }

    public virtual DbSet<AuditTrailReason> AuditTrailReasons { get; set; }

    public virtual DbSet<AutoReceivingStatus> AutoReceivingStatuses { get; set; }

    public virtual DbSet<Bay> Bays { get; set; }

    public virtual DbSet<Bay1> Bays1 { get; set; }

    public virtual DbSet<Bookmark> Bookmarks { get; set; }

    public virtual DbSet<BookmarkView> BookmarkViews { get; set; }

    public virtual DbSet<Bot> Bots { get; set; }

    public virtual DbSet<BotAlertLog> BotAlertLogs { get; set; }

    public virtual DbSet<BotLift> BotLifts { get; set; }

    public virtual DbSet<BotLift1> BotLifts1 { get; set; }

    public virtual DbSet<BotLiftLevel> BotLiftLevels { get; set; }

    public virtual DbSet<BotLiftReader> BotLiftReaders { get; set; }

    public virtual DbSet<BotLocation> BotLocations { get; set; }

    public virtual DbSet<BotMaintenanceLog> BotMaintenanceLogs { get; set; }

    public virtual DbSet<BotModel> BotModels { get; set; }

    public virtual DbSet<BotPullDetail> BotPullDetails { get; set; }

    public virtual DbSet<BotState> BotStates { get; set; }

    public virtual DbSet<BotWarehouseState> BotWarehouseStates { get; set; }

    public virtual DbSet<BotWorkOrder> BotWorkOrders { get; set; }

    public virtual DbSet<BreakPackEligible> BreakPackEligibles { get; set; }

    public virtual DbSet<BreakpackLoop> BreakpackLoops { get; set; }

    public virtual DbSet<BreakpackLoop1> BreakpackLoops1 { get; set; }

    public virtual DbSet<BreakpackTransferBuffer> BreakpackTransferBuffers { get; set; }

    public virtual DbSet<CandidateCaseGroupNumber> CandidateCaseGroupNumbers { get; set; }

    public virtual DbSet<CandidateCustomerCartonRef> CandidateCustomerCartonRefs { get; set; }

    public virtual DbSet<Carton> Cartons { get; set; }

    public virtual DbSet<CartonAvailabilitySelectionMode> CartonAvailabilitySelectionModes { get; set; }

    public virtual DbSet<CartonExtension> CartonExtensions { get; set; }

    public virtual DbSet<CartonExtensionKey> CartonExtensionKeys { get; set; }

    public virtual DbSet<CartonLabel> CartonLabels { get; set; }

    public virtual DbSet<CartonLabel1> CartonLabels1 { get; set; }

    public virtual DbSet<CartonLift> CartonLifts { get; set; }

    public virtual DbSet<CartonLift1> CartonLifts1 { get; set; }

    public virtual DbSet<CartonLiftArm> CartonLiftArms { get; set; }

    public virtual DbSet<CartonLiftMotionParameter> CartonLiftMotionParameters { get; set; }

    public virtual DbSet<CartonLiftOffset> CartonLiftOffsets { get; set; }

    public virtual DbSet<CartonLiftState> CartonLiftStates { get; set; }

    public virtual DbSet<CartonLiftStatesTombstone> CartonLiftStatesTombstones { get; set; }

    public virtual DbSet<CartonLiftStopReason> CartonLiftStopReasons { get; set; }

    public virtual DbSet<CartonLiftTransitionState> CartonLiftTransitionStates { get; set; }

    public virtual DbSet<CartonRejectReason> CartonRejectReasons { get; set; }

    public virtual DbSet<CartonRequest> CartonRequests { get; set; }

    public virtual DbSet<CartonRequestsWork> CartonRequestsWorks { get; set; }

    public virtual DbSet<CartonScan> CartonScans { get; set; }

    public virtual DbSet<CartonState> CartonStates { get; set; }

    public virtual DbSet<CartonTypeSelectionMode> CartonTypeSelectionModes { get; set; }

    public virtual DbSet<CartonsHistory> CartonsHistories { get; set; }

    public virtual DbSet<CartonsVcpeachesBackup> CartonsVcpeachesBackups { get; set; }

    public virtual DbSet<CartonsVcpsspbackup> CartonsVcpsspbackups { get; set; }

    public virtual DbSet<CartonsWork> CartonsWorks { get; set; }

    public virtual DbSet<Cell> Cells { get; set; }

    public virtual DbSet<Cell1> Cells1 { get; set; }

    public virtual DbSet<ChildOutboundType> ChildOutboundTypes { get; set; }

    public virtual DbSet<CleanupOrdersBackup> CleanupOrdersBackups { get; set; }

    public virtual DbSet<CodePlate> CodePlates { get; set; }

    public virtual DbSet<CodePlate1> CodePlates1 { get; set; }

    public virtual DbSet<ConfigurationBlob> ConfigurationBlobs { get; set; }

    public virtual DbSet<ConfigurationGroup> ConfigurationGroups { get; set; }

    public virtual DbSet<ConfigurationGroup1> ConfigurationGroups1 { get; set; }

    public virtual DbSet<ConfigurationParameter> ConfigurationParameters { get; set; }

    public virtual DbSet<ConfigurationParameter1> ConfigurationParameters1 { get; set; }

    public virtual DbSet<ConfigurationParametersChangeLog> ConfigurationParametersChangeLogs { get; set; }

    public virtual DbSet<Conflict> Conflicts { get; set; }

    public virtual DbSet<ConflictCarton> ConflictCartons { get; set; }

    public virtual DbSet<ContainerType> ContainerTypes { get; set; }

    public virtual DbSet<ConveyorLane> ConveyorLanes { get; set; }

    public virtual DbSet<ConveyorLane1> ConveyorLanes1 { get; set; }

    public virtual DbSet<CustomerPriorityRule> CustomerPriorityRules { get; set; }

    public virtual DbSet<Deck> Decks { get; set; }

    public virtual DbSet<Deck1> Decks1 { get; set; }

    public virtual DbSet<DeckLine> DeckLines { get; set; }

    public virtual DbSet<DeckLine1> DeckLines1 { get; set; }

    public virtual DbSet<DeckLineType> DeckLineTypes { get; set; }

    public virtual DbSet<DeckState> DeckStates { get; set; }

    public virtual DbSet<DeckStatesTombstone> DeckStatesTombstones { get; set; }

    public virtual DbSet<DeckType> DeckTypes { get; set; }

    public virtual DbSet<DeliveryState> DeliveryStates { get; set; }

    public virtual DbSet<DepalletizerOperationalMode> DepalletizerOperationalModes { get; set; }

    public virtual DbSet<DepalletizingRejectionReason> DepalletizingRejectionReasons { get; set; }

    public virtual DbSet<DepalletizingSubState> DepalletizingSubStates { get; set; }

    public virtual DbSet<DeploymentAction> DeploymentActions { get; set; }

    public virtual DbSet<DeploymentCategory> DeploymentCategories { get; set; }

    public virtual DbSet<DeploymentStep> DeploymentSteps { get; set; }

    public virtual DbSet<Destination> Destinations { get; set; }

    public virtual DbSet<Destination1> Destinations1 { get; set; }

    public virtual DbSet<DestinationAvailabilityStatus> DestinationAvailabilityStatuses { get; set; }

    public virtual DbSet<DestinationCategory> DestinationCategories { get; set; }

    public virtual DbSet<DestinationCategory1> DestinationCategories1 { get; set; }

    public virtual DbSet<DestinationDestinationCategory> DestinationDestinationCategories { get; set; }

    public virtual DbSet<DestinationEndpoint> DestinationEndpoints { get; set; }

    public virtual DbSet<DestinationState> DestinationStates { get; set; }

    public virtual DbSet<DestinationStatesTombstone> DestinationStatesTombstones { get; set; }

    public virtual DbSet<DestinationsBackup> DestinationsBackups { get; set; }

    public virtual DbSet<DestinationsDestinationCategory> DestinationsDestinationCategories { get; set; }

    public virtual DbSet<Driveway> Driveways { get; set; }

    public virtual DbSet<Driveway1> Driveways1 { get; set; }

    public virtual DbSet<DrivewayState> DrivewayStates { get; set; }

    public virtual DbSet<DrivewayStatesTombstone> DrivewayStatesTombstones { get; set; }

    public virtual DbSet<DuplicateAllocationMessage> DuplicateAllocationMessages { get; set; }

    public virtual DbSet<EdgeAlignment> EdgeAlignments { get; set; }

    public virtual DbSet<EmailParameter> EmailParameters { get; set; }

    public virtual DbSet<Endpoint> Endpoints { get; set; }

    public virtual DbSet<Endpoint1> Endpoints1 { get; set; }

    public virtual DbSet<EndpointBackup> EndpointBackups { get; set; }

    public virtual DbSet<EndpointConnection> EndpointConnections { get; set; }

    public virtual DbSet<EndpointConnection1> EndpointConnections1 { get; set; }

    public virtual DbSet<EnumerationProperty> EnumerationProperties { get; set; }

    public virtual DbSet<EnumerationReference> EnumerationReferences { get; set; }

    public virtual DbSet<EnumerationReferenceValue> EnumerationReferenceValues { get; set; }

    public virtual DbSet<ErrorLog> ErrorLogs { get; set; }

    public virtual DbSet<ExceptionProcessingRequiredDetail> ExceptionProcessingRequiredDetails { get; set; }

    public virtual DbSet<ExecutionDetailsLog> ExecutionDetailsLogs { get; set; }

    public virtual DbSet<ExecutionLog> ExecutionLogs { get; set; }

    public virtual DbSet<ExecutionStatus> ExecutionStatuses { get; set; }

    public virtual DbSet<ExpirationSelectionMode> ExpirationSelectionModes { get; set; }

    public virtual DbSet<ExtensionKeyDatum> ExtensionKeyData { get; set; }

    public virtual DbSet<Forecast> Forecasts { get; set; }

    public virtual DbSet<ForecastTemp> ForecastTemps { get; set; }

    public virtual DbSet<FulfilledBy> FulfilledBies { get; set; }

    public virtual DbSet<GenericAlertLog> GenericAlertLogs { get; set; }

    public virtual DbSet<HealthMonitor> HealthMonitors { get; set; }

    public virtual DbSet<HoldState> HoldStates { get; set; }

    public virtual DbSet<Inbound> Inbounds { get; set; }

    public virtual DbSet<InboundBatch> InboundBatches { get; set; }

    public virtual DbSet<InboundCarton> InboundCartons { get; set; }

    public virtual DbSet<InboundCartonLabel> InboundCartonLabels { get; set; }

    public virtual DbSet<InboundCartonRejectReason> InboundCartonRejectReasons { get; set; }

    public virtual DbSet<InboundConveyorLoad> InboundConveyorLoads { get; set; }

    public virtual DbSet<InboundConveyorLoadCarton> InboundConveyorLoadCartons { get; set; }

    public virtual DbSet<InboundConveyorLoadCartonsTombstone> InboundConveyorLoadCartonsTombstones { get; set; }

    public virtual DbSet<InboundConveyorLoadsTombstone> InboundConveyorLoadsTombstones { get; set; }

    public virtual DbSet<InboundDestination> InboundDestinations { get; set; }

    public virtual DbSet<InboundDimensionalVariant> InboundDimensionalVariants { get; set; }

    public virtual DbSet<InboundDimensionalVariantsHistory> InboundDimensionalVariantsHistories { get; set; }

    public virtual DbSet<InboundDimensionalVariantsImportResult> InboundDimensionalVariantsImportResults { get; set; }

    public virtual DbSet<InboundDimensionalVariantsTemp> InboundDimensionalVariantsTemps { get; set; }

    public virtual DbSet<InboundDimensionalVariantsTemp1> InboundDimensionalVariantsTemps1 { get; set; }

    public virtual DbSet<InboundDimensionalVariantsWork> InboundDimensionalVariantsWorks { get; set; }

    public virtual DbSet<InboundForecast> InboundForecasts { get; set; }

    public virtual DbSet<InboundLpn> InboundLpns { get; set; }

    public virtual DbSet<InboundPallet> InboundPallets { get; set; }

    public virtual DbSet<InboundPalletAlternatePrintingState> InboundPalletAlternatePrintingStates { get; set; }

    public virtual DbSet<InboundPalletLabelingSubState> InboundPalletLabelingSubStates { get; set; }

    public virtual DbSet<InboundPalletSource> InboundPalletSources { get; set; }

    public virtual DbSet<InboundPalletState> InboundPalletStates { get; set; }

    public virtual DbSet<InboundPalletStoredState> InboundPalletStoredStates { get; set; }

    public virtual DbSet<InboundPalletsBackup> InboundPalletsBackups { get; set; }

    public virtual DbSet<InboundRobotPropertiesHistory> InboundRobotPropertiesHistories { get; set; }

    public virtual DbSet<InboundRobotPropertiesTemp> InboundRobotPropertiesTemps { get; set; }

    public virtual DbSet<InboundRobotPropertiesTemp1> InboundRobotPropertiesTemps1 { get; set; }

    public virtual DbSet<InboundRobotProperty> InboundRobotProperties { get; set; }

    public virtual DbSet<IneligibilityReason> IneligibilityReasons { get; set; }

    public virtual DbSet<Inventory> Inventories { get; set; }

    public virtual DbSet<InventoryExtendingShelfBackup> InventoryExtendingShelfBackups { get; set; }

    public virtual DbSet<InventoryItemType> InventoryItemTypes { get; set; }

    public virtual DbSet<InventoryTombstone> InventoryTombstones { get; set; }

    public virtual DbSet<Issue> Issues { get; set; }

    public virtual DbSet<ItemMaster> ItemMasters { get; set; }

    public virtual DbSet<LabelBase> LabelBases { get; set; }

    public virtual DbSet<LabelBaseWork> LabelBaseWorks { get; set; }

    public virtual DbSet<LabelType> LabelTypes { get; set; }

    public virtual DbSet<LeadEdgeOrientation> LeadEdgeOrientations { get; set; }

    public virtual DbSet<Level> Levels { get; set; }

    public virtual DbSet<Level1> Levels1 { get; set; }

    public virtual DbSet<LevelMapModel> LevelMapModels { get; set; }

    public virtual DbSet<LevelModuleState> LevelModuleStates { get; set; }

    public virtual DbSet<LevelModuleStatesTombstone> LevelModuleStatesTombstones { get; set; }

    public virtual DbSet<LicensePlateNumberStringTemp> LicensePlateNumberStringTemps { get; set; }

    public virtual DbSet<LiftLoad> LiftLoads { get; set; }

    public virtual DbSet<LiftLoadCarton> LiftLoadCartons { get; set; }

    public virtual DbSet<LiftLoadCartonsTombstone> LiftLoadCartonsTombstones { get; set; }

    public virtual DbSet<LiftLoadsTombstone> LiftLoadsTombstones { get; set; }

    public virtual DbSet<LocationType> LocationTypes { get; set; }

    public virtual DbSet<LocationWorkOrder> LocationWorkOrders { get; set; }

    public virtual DbSet<Lpn> Lpns { get; set; }

    public virtual DbSet<LpnSelectionMode> LpnSelectionModes { get; set; }

    public virtual DbSet<LpnStringTemp> LpnStringTemps { get; set; }

    public virtual DbSet<Lpnextension> Lpnextensions { get; set; }

    public virtual DbSet<LpnextensionKey> LpnextensionKeys { get; set; }

    public virtual DbSet<LpnrejectReason> LpnrejectReasons { get; set; }

    public virtual DbSet<LpnrejectReason1> LpnrejectReasons1 { get; set; }

    public virtual DbSet<LpnsBackup> LpnsBackups { get; set; }

    public virtual DbSet<LpnsHistory> LpnsHistories { get; set; }

    public virtual DbSet<ManualBuildReason> ManualBuildReasons { get; set; }

    public virtual DbSet<MeasuredBy> MeasuredBies { get; set; }

    public virtual DbSet<MessageCategory> MessageCategories { get; set; }

    public virtual DbSet<MessageQueue> MessageQueues { get; set; }

    public virtual DbSet<MessageType> MessageTypes { get; set; }

    public virtual DbSet<MessagesToPublish> MessagesToPublishes { get; set; }

    public virtual DbSet<MeteringGroup> MeteringGroups { get; set; }

    public virtual DbSet<MeteringGroup1> MeteringGroups1 { get; set; }

    public virtual DbSet<MeteringGroupInformation> MeteringGroupInformations { get; set; }

    public virtual DbSet<MeteringGroupRef> MeteringGroupRefs { get; set; }

    public virtual DbSet<Module> Modules { get; set; }

    public virtual DbSet<Module1> Modules1 { get; set; }

    public virtual DbSet<MultiPalletType> MultiPalletTypes { get; set; }

    public virtual DbSet<Note> Notes { get; set; }

    public virtual DbSet<NotifyState> NotifyStates { get; set; }

    public virtual DbSet<OdvType> OdvTypes { get; set; }

    public virtual DbSet<OperationalMode> OperationalModes { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Order1> Orders1 { get; set; }

    public virtual DbSet<OrderBatch> OrderBatches { get; set; }

    public virtual DbSet<OrderBatch1> OrderBatches1 { get; set; }

    public virtual DbSet<OrderBatchState> OrderBatchStates { get; set; }

    public virtual DbSet<OrderCancelSource> OrderCancelSources { get; set; }

    public virtual DbSet<OrderCartonType> OrderCartonTypes { get; set; }

    public virtual DbSet<OrderDestination> OrderDestinations { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<OrderDetail1> OrderDetails1 { get; set; }

    public virtual DbSet<OrderDetailCartonLabel> OrderDetailCartonLabels { get; set; }

    public virtual DbSet<OrderDetailCaseGroupNumber> OrderDetailCaseGroupNumbers { get; set; }

    public virtual DbSet<OrderDetailCustomerCartonRef> OrderDetailCustomerCartonRefs { get; set; }

    public virtual DbSet<OrderDetailExtension> OrderDetailExtensions { get; set; }

    public virtual DbSet<OrderDetailExtension1> OrderDetailExtensions1 { get; set; }

    public virtual DbSet<OrderDetailExtensionKey> OrderDetailExtensionKeys { get; set; }

    public virtual DbSet<OrderExtension> OrderExtensions { get; set; }

    public virtual DbSet<OrderExtension1> OrderExtensions1 { get; set; }

    public virtual DbSet<OrderExtensionKey> OrderExtensionKeys { get; set; }

    public virtual DbSet<OrderHoldState> OrderHoldStates { get; set; }

    public virtual DbSet<OrderPlanState> OrderPlanStates { get; set; }

    public virtual DbSet<OrderState> OrderStates { get; set; }

    public virtual DbSet<OrderType> OrderTypes { get; set; }

    public virtual DbSet<OrderType1> OrderTypes1 { get; set; }

    public virtual DbSet<OrdersWork> OrdersWorks { get; set; }

    public virtual DbSet<Outbound> Outbounds { get; set; }

    public virtual DbSet<OutboundBatch> OutboundBatches { get; set; }

    public virtual DbSet<OutboundBatch1> OutboundBatches1 { get; set; }

    public virtual DbSet<OutboundCarton> OutboundCartons { get; set; }

    public virtual DbSet<OutboundDestination> OutboundDestinations { get; set; }

    public virtual DbSet<OutboundDimensionalVariant> OutboundDimensionalVariants { get; set; }

    public virtual DbSet<OutboundDimensionalVariantTombstone> OutboundDimensionalVariantTombstones { get; set; }

    public virtual DbSet<OutboundExtension> OutboundExtensions { get; set; }

    public virtual DbSet<OutboundExtensionKey> OutboundExtensionKeys { get; set; }

    public virtual DbSet<OutboundExtensionValue> OutboundExtensionValues { get; set; }

    public virtual DbSet<OutboundLabel> OutboundLabels { get; set; }

    public virtual DbSet<OutboundOrderSummary> OutboundOrderSummaries { get; set; }

    public virtual DbSet<OutboundPallet> OutboundPallets { get; set; }

    public virtual DbSet<OutboundPallet1> OutboundPallets1 { get; set; }

    public virtual DbSet<OutboundPalletAlternatePrintingState> OutboundPalletAlternatePrintingStates { get; set; }

    public virtual DbSet<OutboundPalletDeliveredState> OutboundPalletDeliveredStates { get; set; }

    public virtual DbSet<OutboundPalletLabelingSubState> OutboundPalletLabelingSubStates { get; set; }

    public virtual DbSet<OutboundPalletNotifyState> OutboundPalletNotifyStates { get; set; }

    public virtual DbSet<OutboundParentChildMap> OutboundParentChildMaps { get; set; }

    public virtual DbSet<OutboundState> OutboundStates { get; set; }

    public virtual DbSet<OutputPriority> OutputPriorities { get; set; }

    public virtual DbSet<PackagingType> PackagingTypes { get; set; }

    public virtual DbSet<PalletBaseType> PalletBaseTypes { get; set; }

    public virtual DbSet<PalletBaseType1> PalletBaseTypes1 { get; set; }

    public virtual DbSet<PalletBuiltBy> PalletBuiltBies { get; set; }

    public virtual DbSet<PalletDeliveryState> PalletDeliveryStates { get; set; }

    public virtual DbSet<PalletLayer> PalletLayers { get; set; }

    public virtual DbSet<PalletPalletizingResult> PalletPalletizingResults { get; set; }

    public virtual DbSet<PalletSequencingRequest> PalletSequencingRequests { get; set; }

    public virtual DbSet<PalletSequencingRequestError> PalletSequencingRequestErrors { get; set; }

    public virtual DbSet<PalletSequencingRequestState> PalletSequencingRequestStates { get; set; }

    public virtual DbSet<PalletSourceType> PalletSourceTypes { get; set; }

    public virtual DbSet<PalletType> PalletTypes { get; set; }

    public virtual DbSet<PalletizationGroupType> PalletizationGroupTypes { get; set; }

    public virtual DbSet<PalletizationGroupType1> PalletizationGroupTypes1 { get; set; }

    public virtual DbSet<PalletizingSubState> PalletizingSubStates { get; set; }

    public virtual DbSet<Parameter> Parameters { get; set; }

    public virtual DbSet<PartialPalletState> PartialPalletStates { get; set; }

    public virtual DbSet<PickupAndDeliveryStation> PickupAndDeliveryStations { get; set; }

    public virtual DbSet<PickupAndDeliveryStation1> PickupAndDeliveryStations1 { get; set; }

    public virtual DbSet<PickupAndDeliveryStationDirection> PickupAndDeliveryStationDirections { get; set; }

    public virtual DbSet<PickupAndDeliveryStationType> PickupAndDeliveryStationTypes { get; set; }

    public virtual DbSet<ProcessLog> ProcessLogs { get; set; }

    public virtual DbSet<ProductProperty> ProductProperties { get; set; }

    public virtual DbSet<ProductType> ProductTypes { get; set; }

    public virtual DbSet<PullListLocation> PullListLocations { get; set; }

    public virtual DbSet<QuantityType> QuantityTypes { get; set; }

    public virtual DbSet<ReallocatedCartonRequest> ReallocatedCartonRequests { get; set; }

    public virtual DbSet<ReconTypeAction> ReconTypeActions { get; set; }

    public virtual DbSet<ReducedSurface> ReducedSurfaces { get; set; }

    public virtual DbSet<RelativeOrientation> RelativeOrientations { get; set; }

    public virtual DbSet<RemovedCarton> RemovedCartons { get; set; }

    public virtual DbSet<ReplenishmentPriority> ReplenishmentPriorities { get; set; }

    public virtual DbSet<ReplenishmentRequest> ReplenishmentRequests { get; set; }

    public virtual DbSet<ReplenishmentRequestsHistory> ReplenishmentRequestsHistories { get; set; }

    public virtual DbSet<ReplenishmentRequestsHistoryWork> ReplenishmentRequestsHistoryWorks { get; set; }

    public virtual DbSet<ReplenishmentTask> ReplenishmentTasks { get; set; }

    public virtual DbSet<ReplenishmentTaskState> ReplenishmentTaskStates { get; set; }

    public virtual DbSet<ResetShelfDetailLog> ResetShelfDetailLogs { get; set; }

    public virtual DbSet<ResetShelfLog> ResetShelfLogs { get; set; }

    public virtual DbSet<Resolution> Resolutions { get; set; }

    public virtual DbSet<ResourceType> ResourceTypes { get; set; }

    public virtual DbSet<RobotConfigurationProfile> RobotConfigurationProfiles { get; set; }

    public virtual DbSet<RobotConfigurationProfile1> RobotConfigurationProfiles1 { get; set; }

    public virtual DbSet<RuleModel> RuleModels { get; set; }

    public virtual DbSet<RuleSet> RuleSets { get; set; }

    public virtual DbSet<RuleType> RuleTypes { get; set; }

    public virtual DbSet<SafetyZone> SafetyZones { get; set; }

    public virtual DbSet<SafetyZoneToLevelMap> SafetyZoneToLevelMaps { get; set; }

    public virtual DbSet<Scanner> Scanners { get; set; }

    public virtual DbSet<Scanner1> Scanners1 { get; set; }

    public virtual DbSet<ScannerType> ScannerTypes { get; set; }

    public virtual DbSet<ScheduledShift> ScheduledShifts { get; set; }

    public virtual DbSet<ScratchReason> ScratchReasons { get; set; }

    public virtual DbSet<ScreenedProcess> ScreenedProcesses { get; set; }

    public virtual DbSet<SecurityStatement> SecurityStatements { get; set; }

    public virtual DbSet<SegregationBayModel> SegregationBayModels { get; set; }

    public virtual DbSet<SegregationRuleModel> SegregationRuleModels { get; set; }

    public virtual DbSet<SegregationRuleSet> SegregationRuleSets { get; set; }

    public virtual DbSet<SegregationZone> SegregationZones { get; set; }

    public virtual DbSet<SegregationZoneProductType> SegregationZoneProductTypes { get; set; }

    public virtual DbSet<SegregationZoneRuleSet> SegregationZoneRuleSets { get; set; }

    public virtual DbSet<SelectedCustomerCartonRef> SelectedCustomerCartonRefs { get; set; }

    public virtual DbSet<SequencedDestinationCategory> SequencedDestinationCategories { get; set; }

    public virtual DbSet<ServiceEndpoint> ServiceEndpoints { get; set; }

    public virtual DbSet<ShakeAndSealLoad> ShakeAndSealLoads { get; set; }

    public virtual DbSet<ShakeAndSealLoadsTombstone> ShakeAndSealLoadsTombstones { get; set; }

    public virtual DbSet<Shelf> Shelves { get; set; }

    public virtual DbSet<Shelf1> Shelves1 { get; set; }

    public virtual DbSet<ShelfDictionary> ShelfDictionaries { get; set; }

    public virtual DbSet<ShelfModule> ShelfModules { get; set; }

    public virtual DbSet<ShelfScan> ShelfScans { get; set; }

    public virtual DbSet<ShelfScansTombstone> ShelfScansTombstones { get; set; }

    public virtual DbSet<ShelfState> ShelfStates { get; set; }

    public virtual DbSet<ShelveState> ShelveStates { get; set; }

    public virtual DbSet<ShelveStateHistory> ShelveStateHistories { get; set; }

    public virtual DbSet<Shift> Shifts { get; set; }

    public virtual DbSet<ShiftDayOfWeek> ShiftDayOfWeeks { get; set; }

    public virtual DbSet<ShiftState> ShiftStates { get; set; }

    public virtual DbSet<Side> Sides { get; set; }

    public virtual DbSet<Sku> Skus { get; set; }

    public virtual DbSet<SkuActivityOutboundDestination> SkuActivityOutboundDestinations { get; set; }

    public virtual DbSet<SkuActivityOutboundOrder> SkuActivityOutboundOrders { get; set; }

    public virtual DbSet<SkuActivityOutboundPallet> SkuActivityOutboundPallets { get; set; }

    public virtual DbSet<SkuExtension> SkuExtensions { get; set; }

    public virtual DbSet<SkuExtensionKey> SkuExtensionKeys { get; set; }

    public virtual DbSet<SkuExtensionsTemp> SkuExtensionsTemps { get; set; }

    public virtual DbSet<SkuStringTemp> SkuStringTemps { get; set; }

    public virtual DbSet<SkuSubstitution> SkuSubstitutions { get; set; }

    public virtual DbSet<SkusExtensionDataHistory> SkusExtensionDataHistories { get; set; }

    public virtual DbSet<SkusExtensionDataWork> SkusExtensionDataWorks { get; set; }

    public virtual DbSet<SkusExtensionDatum> SkusExtensionData { get; set; }

    public virtual DbSet<SkusHistory> SkusHistories { get; set; }

    public virtual DbSet<SkusHoldStateBackup> SkusHoldStateBackups { get; set; }

    public virtual DbSet<SkusTemp> SkusTemps { get; set; }

    public virtual DbSet<SkusTemp1> SkusTemps1 { get; set; }

    public virtual DbSet<SkusUpcsTemp> SkusUpcsTemps { get; set; }

    public virtual DbSet<SkusWithExtensionDatum> SkusWithExtensionData { get; set; }

    public virtual DbSet<SkusWorkUpdate> SkusWorkUpdates { get; set; }

    public virtual DbSet<SlottedState> SlottedStates { get; set; }

    public virtual DbSet<StartupScriptsLog> StartupScriptsLogs { get; set; }

    public virtual DbSet<StartupStoredProceduresList> StartupStoredProceduresLists { get; set; }

    public virtual DbSet<StartupStoredProceduresList1> StartupStoredProceduresLists1 { get; set; }

    public virtual DbSet<StgAlertItemWork> StgAlertItemWorks { get; set; }

    public virtual DbSet<StgAlertLogsWork> StgAlertLogsWorks { get; set; }

    public virtual DbSet<StgAuditTrailLogsWork> StgAuditTrailLogsWorks { get; set; }

    public virtual DbSet<StgCartonRequestsWork> StgCartonRequestsWorks { get; set; }

    public virtual DbSet<StgCartonsWork> StgCartonsWorks { get; set; }

    public virtual DbSet<StgLabelBaseWork> StgLabelBaseWorks { get; set; }

    public virtual DbSet<StgOrdersWork> StgOrdersWorks { get; set; }

    public virtual DbSet<StgReplenishmentRequestsHistoryWork> StgReplenishmentRequestsHistoryWorks { get; set; }

    public virtual DbSet<StgShakeAndSealLoadsTombstone> StgShakeAndSealLoadsTombstones { get; set; }

    public virtual DbSet<StgSkusWork> StgSkusWorks { get; set; }

    public virtual DbSet<StgSkusWorkUpdate> StgSkusWorkUpdates { get; set; }

    public virtual DbSet<StgTaskPlanCartonsTombstoneWork> StgTaskPlanCartonsTombstoneWorks { get; set; }

    public virtual DbSet<StructureFile> StructureFiles { get; set; }

    public virtual DbSet<StructureFile1> StructureFiles1 { get; set; }

    public virtual DbSet<StructureLocation> StructureLocations { get; set; }

    public virtual DbSet<StructureStateReason> StructureStateReasons { get; set; }

    public virtual DbSet<StructureStateReason1> StructureStateReasons1 { get; set; }

    public virtual DbSet<Subsystem> Subsystems { get; set; }

    public virtual DbSet<Subsystem1> Subsystems1 { get; set; }

    public virtual DbSet<SubsystemOperationalStatus> SubsystemOperationalStatuses { get; set; }

    public virtual DbSet<SubsystemServiceEndpoint> SubsystemServiceEndpoints { get; set; }

    public virtual DbSet<SubsystemServiceEndpointType> SubsystemServiceEndpointTypes { get; set; }

    public virtual DbSet<SubsystemServiceStatus> SubsystemServiceStatuses { get; set; }

    public virtual DbSet<SuspectAction> SuspectActions { get; set; }

    public virtual DbSet<SuspectLocationSubState> SuspectLocationSubStates { get; set; }

    public virtual DbSet<SuspectReason> SuspectReasons { get; set; }

    public virtual DbSet<SuspectResolution> SuspectResolutions { get; set; }

    public virtual DbSet<SystemResource> SystemResources { get; set; }

    public virtual DbSet<TableList> TableLists { get; set; }

    public virtual DbSet<TableStat> TableStats { get; set; }

    public virtual DbSet<TaskPlan> TaskPlans { get; set; }

    public virtual DbSet<TaskPlanCarton> TaskPlanCartons { get; set; }

    public virtual DbSet<TaskPlanCartonsTombstone> TaskPlanCartonsTombstones { get; set; }

    public virtual DbSet<TaskPlanCartonsTombstoneWork> TaskPlanCartonsTombstoneWorks { get; set; }

    public virtual DbSet<TaskPlansTombstone> TaskPlansTombstones { get; set; }

    public virtual DbSet<TextList> TextLists { get; set; }

    public virtual DbSet<TipOverrideReasonCode> TipOverrideReasonCodes { get; set; }

    public virtual DbSet<ToteLocationDiscrepancy> ToteLocationDiscrepancies { get; set; }

    public virtual DbSet<TransferBuffer> TransferBuffers { get; set; }

    public virtual DbSet<TransferBuffer1> TransferBuffers1 { get; set; }

    public virtual DbSet<TransferBufferLoad> TransferBufferLoads { get; set; }

    public virtual DbSet<TransferBufferLoadCarton> TransferBufferLoadCartons { get; set; }

    public virtual DbSet<TransferBufferLoadCartonsTombstone> TransferBufferLoadCartonsTombstones { get; set; }

    public virtual DbSet<TransferBufferLoadsTombstone> TransferBufferLoadsTombstones { get; set; }

    public virtual DbSet<TransferBufferState> TransferBufferStates { get; set; }

    public virtual DbSet<TransferBufferType> TransferBufferTypes { get; set; }

    public virtual DbSet<TransferBuffersState> TransferBuffersStates { get; set; }

    public virtual DbSet<TransferBuffersStatesHistory> TransferBuffersStatesHistories { get; set; }

    public virtual DbSet<TransferLocation> TransferLocations { get; set; }

    public virtual DbSet<TransferLocation1> TransferLocations1 { get; set; }

    public virtual DbSet<TransitionState> TransitionStates { get; set; }

    public virtual DbSet<Upc> Upcs { get; set; }

    public virtual DbSet<UpcsTemp> UpcsTemps { get; set; }

    public virtual DbSet<VersionLog> VersionLogs { get; set; }

    public virtual DbSet<VerticalConveyorSide> VerticalConveyorSides { get; set; }

    public virtual DbSet<VerticalTransferBufferGroup> VerticalTransferBufferGroups { get; set; }

    public virtual DbSet<VisionPickMode> VisionPickModes { get; set; }

    public virtual DbSet<VwAisleInformation> VwAisleInformations { get; set; }

    public virtual DbSet<VwAisleSideWithShelvesInfo> VwAisleSideWithShelvesInfos { get; set; }

    public virtual DbSet<VwAlertLog> VwAlertLogs { get; set; }

    public virtual DbSet<VwAllocationOrderState> VwAllocationOrderStates { get; set; }

    public virtual DbSet<VwAppsSkuSearchForInventoryTab> VwAppsSkuSearchForInventoryTabs { get; set; }

    public virtual DbSet<VwBayInformation> VwBayInformations { get; set; }

    public virtual DbSet<VwBotAlertLog> VwBotAlertLogs { get; set; }

    public virtual DbSet<VwBotAlertLogsInfo> VwBotAlertLogsInfos { get; set; }

    public virtual DbSet<VwBotLiftInformation> VwBotLiftInformations { get; set; }

    public virtual DbSet<VwBotPullItem> VwBotPullItems { get; set; }

    public virtual DbSet<VwBotWarehouseState> VwBotWarehouseStates { get; set; }

    public virtual DbSet<VwBreakpackInteractionAisleDatum> VwBreakpackInteractionAisleData { get; set; }

    public virtual DbSet<VwBreakpackLoopInformation> VwBreakpackLoopInformations { get; set; }

    public virtual DbSet<VwBreakpackLoopInformation1> VwBreakpackLoopInformations1 { get; set; }

    public virtual DbSet<VwBreakpackTransferBufferInformation> VwBreakpackTransferBufferInformations { get; set; }

    public virtual DbSet<VwBreakpackTransferBuffersDatum> VwBreakpackTransferBuffersData { get; set; }

    public virtual DbSet<VwBreakpackTransitAisleDatum> VwBreakpackTransitAisleData { get; set; }

    public virtual DbSet<VwBuildStructureCacheForBayViewer> VwBuildStructureCacheForBayViewers { get; set; }

    public virtual DbSet<VwCartonAvailabilityCartonStateJunction> VwCartonAvailabilityCartonStateJunctions { get; set; }

    public virtual DbSet<VwCartonCountsByOrderId> VwCartonCountsByOrderIds { get; set; }

    public virtual DbSet<VwCartonCountsByOrderIdSkuId> VwCartonCountsByOrderIdSkuIds { get; set; }

    public virtual DbSet<VwCartonCountsByOrderIdSkuIdDestinationId> VwCartonCountsByOrderIdSkuIdDestinationIds { get; set; }

    public virtual DbSet<VwCartonCountsByOrderIdSkuIdPalletId> VwCartonCountsByOrderIdSkuIdPalletIds { get; set; }

    public virtual DbSet<VwCartonExtensionInfo> VwCartonExtensionInfos { get; set; }

    public virtual DbSet<VwCartonLabel> VwCartonLabels { get; set; }

    public virtual DbSet<VwCartonLabelDatum> VwCartonLabelData { get; set; }

    public virtual DbSet<VwCartonLiftInformation> VwCartonLiftInformations { get; set; }

    public virtual DbSet<VwCartonLiftTransferBufferInformation> VwCartonLiftTransferBufferInformations { get; set; }

    public virtual DbSet<VwCartonLpnExtension> VwCartonLpnExtensions { get; set; }

    public virtual DbSet<VwCartonOverlappingSuspect> VwCartonOverlappingSuspects { get; set; }

    public virtual DbSet<VwCartonRequestSummaryByOrderIdandSkuId> VwCartonRequestSummaryByOrderIdandSkuIds { get; set; }

    public virtual DbSet<VwCartonRequestsAndOutboundCarton> VwCartonRequestsAndOutboundCartons { get; set; }

    public virtual DbSet<VwCodePlateInformation> VwCodePlateInformations { get; set; }

    public virtual DbSet<VwConfigurationGroupRanked> VwConfigurationGroupRankeds { get; set; }

    public virtual DbSet<VwConflictedInventoryOnShortenedShelf> VwConflictedInventoryOnShortenedShelves { get; set; }

    public virtual DbSet<VwConveyorLanesInformation> VwConveyorLanesInformations { get; set; }

    public virtual DbSet<VwDeckInformation> VwDeckInformations { get; set; }

    public virtual DbSet<VwDeckLineInformation> VwDeckLineInformations { get; set; }

    public virtual DbSet<VwDestination> VwDestinations { get; set; }

    public virtual DbSet<VwDestinationInformation> VwDestinationInformations { get; set; }

    public virtual DbSet<VwDestinationsEndpointsInformation> VwDestinationsEndpointsInformations { get; set; }

    public virtual DbSet<VwDrivewayInformation> VwDrivewayInformations { get; set; }

    public virtual DbSet<VwEmptySuspectLocation> VwEmptySuspectLocations { get; set; }

    public virtual DbSet<VwEndpointConnectionInformation> VwEndpointConnectionInformations { get; set; }

    public virtual DbSet<VwEndpointInformation> VwEndpointInformations { get; set; }

    public virtual DbSet<VwExceptionProcessingRequiredInfo> VwExceptionProcessingRequiredInfos { get; set; }

    public virtual DbSet<VwGetAislesInInventory> VwGetAislesInInventories { get; set; }

    public virtual DbSet<VwGetAllAnnotation> VwGetAllAnnotations { get; set; }

    public virtual DbSet<VwGetInventoryInStructure> VwGetInventoryInStructures { get; set; }

    public virtual DbSet<VwGetLpnsInInventory> VwGetLpnsInInventories { get; set; }

    public virtual DbSet<VwGetSkusInInventory> VwGetSkusInInventories { get; set; }

    public virtual DbSet<VwInboundCartonLimit> VwInboundCartonLimits { get; set; }

    public virtual DbSet<VwInboundCartonsCount> VwInboundCartonsCounts { get; set; }

    public virtual DbSet<VwInboundDimensionalVariantsForSku> VwInboundDimensionalVariantsForSkus { get; set; }

    public virtual DbSet<VwInboundPalletComposition> VwInboundPalletCompositions { get; set; }

    public virtual DbSet<VwInternalOrderInventory> VwInternalOrderInventories { get; set; }

    public virtual DbSet<VwInventoryCartonInformation> VwInventoryCartonInformations { get; set; }

    public virtual DbSet<VwInventoryLocationInformation> VwInventoryLocationInformations { get; set; }

    public virtual DbSet<VwInventoryShelvesInfo> VwInventoryShelvesInfos { get; set; }

    public virtual DbSet<VwItemsInsideRestrictedSegregationZone> VwItemsInsideRestrictedSegregationZones { get; set; }

    public virtual DbSet<VwItemsOutOfSegregationZone> VwItemsOutOfSegregationZones { get; set; }

    public virtual DbSet<VwLatestCartonScan> VwLatestCartonScans { get; set; }

    public virtual DbSet<VwLatestShelfScan> VwLatestShelfScans { get; set; }

    public virtual DbSet<VwLevelTopology> VwLevelTopologies { get; set; }

    public virtual DbSet<VwLpnStringTemp> VwLpnStringTemps { get; set; }

    public virtual DbSet<VwLpnWithDetail> VwLpnWithDetails { get; set; }

    public virtual DbSet<VwOrderDetailSummaryByOrderIdandSkuId> VwOrderDetailSummaryByOrderIdandSkuIds { get; set; }

    public virtual DbSet<VwOrderDetailsCartonCountByOrderId> VwOrderDetailsCartonCountByOrderIds { get; set; }

    public virtual DbSet<VwOrderOrderToteSummary> VwOrderOrderToteSummaries { get; set; }

    public virtual DbSet<VwOrderPalletSourceType> VwOrderPalletSourceTypes { get; set; }

    public virtual DbSet<VwOrderSummary> VwOrderSummaries { get; set; }

    public virtual DbSet<VwOutboundCartonActivity> VwOutboundCartonActivities { get; set; }

    public virtual DbSet<VwOutboundIdexclusionListForSkuActivityOutboundOrder> VwOutboundIdexclusionListForSkuActivityOutboundOrders { get; set; }

    public virtual DbSet<VwOutboundPallet> VwOutboundPallets { get; set; }

    public virtual DbSet<VwOutboundPalletSummary> VwOutboundPalletSummaries { get; set; }

    public virtual DbSet<VwPickupAndDelStationsInfo> VwPickupAndDelStationsInfos { get; set; }

    public virtual DbSet<VwPndStationInformation> VwPndStationInformations { get; set; }

    public virtual DbSet<VwProcessLog> VwProcessLogs { get; set; }

    public virtual DbSet<VwProcessResult> VwProcessResults { get; set; }

    public virtual DbSet<VwScannersInformation> VwScannersInformations { get; set; }

    public virtual DbSet<VwSegregationBayInfo> VwSegregationBayInfos { get; set; }

    public virtual DbSet<VwSegregationProductPropertyMap> VwSegregationProductPropertyMaps { get; set; }

    public virtual DbSet<VwSegregationRuleModelInfo> VwSegregationRuleModelInfos { get; set; }

    public virtual DbSet<VwSegregationZoneDatum> VwSegregationZoneData { get; set; }

    public virtual DbSet<VwSegregationZoneIdsForInventory> VwSegregationZoneIdsForInventories { get; set; }

    public virtual DbSet<VwSegregationZoneInfo> VwSegregationZoneInfos { get; set; }

    public virtual DbSet<VwSegregationZoneSkuMappingRule> VwSegregationZoneSkuMappingRules { get; set; }

    public virtual DbSet<VwShelfInformation> VwShelfInformations { get; set; }

    public virtual DbSet<VwShelvesHeightType> VwShelvesHeightTypes { get; set; }

    public virtual DbSet<VwShelvesToBeDeleted> VwShelvesToBeDeleteds { get; set; }

    public virtual DbSet<VwSkuSubstitution> VwSkuSubstitutions { get; set; }

    public virtual DbSet<VwSkuVelocityDetail> VwSkuVelocityDetails { get; set; }

    public virtual DbSet<VwSkuWithActiveLpn> VwSkuWithActiveLpns { get; set; }

    public virtual DbSet<VwSkuWithActiveOutboundLpn> VwSkuWithActiveOutboundLpns { get; set; }

    public virtual DbSet<VwSkuWithDetail> VwSkuWithDetails { get; set; }

    public virtual DbSet<VwSkuWithDetailsFast> VwSkuWithDetailsFasts { get; set; }

    public virtual DbSet<VwStagingCartonLift> VwStagingCartonLifts { get; set; }

    public virtual DbSet<VwStagingEndpointId> VwStagingEndpointIds { get; set; }

    public virtual DbSet<VwStructureInfo> VwStructureInfos { get; set; }

    public virtual DbSet<VwSubsystemInformation> VwSubsystemInformations { get; set; }

    public virtual DbSet<VwTransferBufferInfo> VwTransferBufferInfos { get; set; }

    public virtual DbSet<VwTransferBuffersToBeDeleted> VwTransferBuffersToBeDeleteds { get; set; }

    public virtual DbSet<VwUnavailableStructureResource> VwUnavailableStructureResources { get; set; }

    public virtual DbSet<VwZoneInformation> VwZoneInformations { get; set; }

    public virtual DbSet<WarehousePack> WarehousePacks { get; set; }

    public virtual DbSet<WarehousePackHandlingProfileType> WarehousePackHandlingProfileTypes { get; set; }

    public virtual DbSet<WarehousePackHandlingProfilesTemp> WarehousePackHandlingProfilesTemps { get; set; }

    public virtual DbSet<WarehousePackPackageType> WarehousePackPackageTypes { get; set; }

    public virtual DbSet<WarehousePacksTemp> WarehousePacksTemps { get; set; }

    public virtual DbSet<WorkOrder> WorkOrders { get; set; }

    public virtual DbSet<WorkOrderAlertLog> WorkOrderAlertLogs { get; set; }

    public virtual DbSet<WorkOrderChangeState> WorkOrderChangeStates { get; set; }

    public virtual DbSet<WorkOrderIssue> WorkOrderIssues { get; set; }

    public virtual DbSet<WorkOrderIssueResolution> WorkOrderIssueResolutions { get; set; }

    public virtual DbSet<WorkOrderNote> WorkOrderNotes { get; set; }

    public virtual DbSet<WorkOrderState> WorkOrderStates { get; set; }

    public virtual DbSet<Zone> Zones { get; set; }

    public virtual DbSet<Zone1> Zones1 { get; set; }

    public virtual DbSet<ZoneBayModel> ZoneBayModels { get; set; }

    public virtual DbSet<ZoneBayModelHistory> ZoneBayModelHistories { get; set; }

    public virtual DbSet<ZoneState> ZoneStates { get; set; }

    public virtual DbSet<ZoneStatesTombstone> ZoneStatesTombstones { get; set; }

    public virtual DbSet<ZoneType> ZoneTypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.,1533;Database=ODS;User=sa;Password=setup123####;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Aisle>(entity =>
        {
            entity.ToTable("Aisles", "Staging");

            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Aisle1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Aisle");

            entity.ToTable("Aisles", "Structure");

            entity.HasIndex(e => e.ModuleId, "IDX_FK_Aisle_Module");

            entity.HasIndex(e => e.ZoneId, "IDX_FK_Aisle_Zone");

            entity.HasIndex(e => e.LevelId, "IDX_Structure_Aisles_LevelId");

            entity.HasIndex(e => e.ResourceName, "UC_AisleResourceName")
                .IsUnique()
                .HasFilter("([ResourceName] IS NOT NULL)");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.ResourceName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Level).WithMany(p => p.Aisle1s)
                .HasForeignKey(d => d.LevelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Aisle_Level");

            entity.HasOne(d => d.Module).WithMany(p => p.Aisle1s)
                .HasForeignKey(d => d.ModuleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Aisle_Module");

            entity.HasOne(d => d.Type).WithMany(p => p.Aisle1s)
                .HasForeignKey(d => d.TypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Aisle_Type");

            entity.HasOne(d => d.Zone).WithMany(p => p.Aisle1s)
                .HasForeignKey(d => d.ZoneId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Aisle_Zone");
        });

        modelBuilder.Entity<AisleState>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_AisleState");

            entity.ToTable("AisleStates", "Structure", tb =>
                {
                    tb.HasTrigger("trg_AisleStates_Insert");
                    tb.HasTrigger("trg_AisleStates_Update");
                });

            entity.HasIndex(e => e.AisleId, "IDX_Structure_AisleStates_AisleId");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.StateNote)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.Aisle).WithMany(p => p.AisleStates)
                .HasForeignKey(d => d.AisleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AisleState_Aisle");

            entity.HasOne(d => d.StateNavigation).WithMany(p => p.AisleStates)
                .HasForeignKey(d => d.State)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AisleState_TransitionState");
        });

        modelBuilder.Entity<AisleStatesTombstone>(entity =>
        {
            entity.HasKey(e => e.AisleStatesTombstoneSk);

            entity.ToTable("AisleStatesTombstone", "Structure");

            entity.Property(e => e.AisleStatesTombstoneSk).HasColumnName("AisleStatesTombstoneSK");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.StateNote)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.TombstoneDate).HasDefaultValueSql("(getutcdate())");
        });

        modelBuilder.Entity<AisleType>(entity =>
        {
            entity.ToTable("AisleType", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<Alert>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Alert");

            entity.ToTable("Alerts", "Alert");

            entity.HasIndex(e => new { e.AlertType, e.AlertCode }, "UC_Alert_AlertNumber").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.HardwareOriginType).HasMaxLength(25);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Publisher).HasMaxLength(25);
            entity.Property(e => e.RecoveryOptions).HasMaxLength(4000);
            entity.Property(e => e.ResolutionOwner).HasMaxLength(50);

            entity.HasOne(d => d.AlertTypeNavigation).WithMany(p => p.Alerts)
                .HasForeignKey(d => d.AlertType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Alerts_AlertType");

            entity.HasOne(d => d.SeverityNavigation).WithMany(p => p.Alerts)
                .HasForeignKey(d => d.Severity)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Alerts_AlertSeverity");
        });

        modelBuilder.Entity<Alert1>(entity =>
        {
            entity.ToTable("Alerts", "Staging");

            entity.Property(e => e.Description)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.HardwareOriginType).HasMaxLength(25);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Publisher).HasMaxLength(25);
            entity.Property(e => e.RecoveryOptions).HasMaxLength(4000);
            entity.Property(e => e.ResolutionOwner).HasMaxLength(50);
        });

        modelBuilder.Entity<AlertDefinition>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Alert");

            entity.ToTable("AlertDefinition");

            entity.HasIndex(e => new { e.Id, e.AlertTypeId }, "IX_AlertDefinition_AlertType");

            entity.HasIndex(e => new { e.Code, e.Id }, "IX_AlertDefinition_CoveringIndex");

            entity.HasIndex(e => e.Code, "UC_Alert_AlertNumber").IsUnique();

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("(left(suser_name(),(25)))");
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(sysdatetimeoffset())");
            entity.Property(e => e.Description)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.HardwareOriginType).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("(left(suser_name(),(25)))");
            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(sysdatetimeoffset())");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Publisher).HasMaxLength(50);
            entity.Property(e => e.RecoveryOptions).HasMaxLength(4000);
            entity.Property(e => e.ResolutionOwner).HasMaxLength(50);

            entity.HasOne(d => d.AlertSeverity).WithMany(p => p.AlertDefinitions)
                .HasForeignKey(d => d.AlertSeverityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AlertDefinition_AlertSeverity");

            entity.HasOne(d => d.AlertType).WithMany(p => p.AlertDefinitions)
                .HasForeignKey(d => d.AlertTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AlertDefinition_AlertType");
        });

        modelBuilder.Entity<AlertExtension>(entity =>
        {
            entity.ToTable("AlertExtension");

            entity.HasIndex(e => new { e.Id, e.AlertItemId }, "IX_AlertExtension");

            entity.HasIndex(e => e.AlertItemId, "IX_FK_AlertExtension_AlertItem");

            entity.Property(e => e.StringValue).HasMaxLength(500);

            entity.HasOne(d => d.AlertExtensionField).WithMany(p => p.AlertExtensions)
                .HasForeignKey(d => d.AlertExtensionFieldId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AlertExtension_AlertExtensionField");

            entity.HasOne(d => d.AlertItem).WithMany(p => p.AlertExtensions)
                .HasForeignKey(d => d.AlertItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AlertExtension_AlertItem");
        });

        modelBuilder.Entity<AlertExtensionField>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_BotAlertLogs");

            entity.ToTable("AlertExtensionField");

            entity.HasIndex(e => new { e.Id, e.Name }, "IX_AlertExtensionField_Name");

            entity.HasIndex(e => e.Name, "IX_AlertExtensionField_UniqueName").IsUnique();

            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AlertItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_BotAlertLog");

            entity.ToTable("AlertItem");

            entity.HasIndex(e => new { e.Id, e.AlertDefinitionId }, "IX_AlertItem_Definition");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("(left(suser_name(),(25)))");
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(sysdatetimeoffset())");
            entity.Property(e => e.CreatedTime).HasDefaultValueSql("(sysdatetimeoffset())");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("(left(suser_name(),(25)))");
            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(sysdatetimeoffset())");

            entity.HasOne(d => d.AlertDefinition).WithMany(p => p.AlertItems)
                .HasForeignKey(d => d.AlertDefinitionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AlertItem_AlertDefinition");
        });

        modelBuilder.Entity<AlertItemWork>(entity =>
        {
            entity.HasKey(e => e.AlertItemId).HasName("PK_StagingAlertItemWork_AlertItemID");

            entity.ToTable("AlertItemWork", "Staging");

            entity.Property(e => e.AlertItemId)
                .ValueGeneratedNever()
                .HasColumnName("AlertItemID");
        });

        modelBuilder.Entity<AlertLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_AlertLog");

            entity.ToTable("AlertLogs", "Alert");

            entity.HasIndex(e => new { e.AlertId, e.CreatedTime }, "IX_AlertLogs_ControlCenterCoveringIndex");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.AlertContext).HasColumnType("xml");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.HasOne(d => d.Alert).WithMany(p => p.AlertLogs)
                .HasForeignKey(d => d.AlertId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AlertLog_Alert");
        });

        modelBuilder.Entity<AlertLogsWork>(entity =>
        {
            entity.HasKey(e => e.AlertLogId).HasName("PK_AlertLogsWork_AlertLogID");

            entity.ToTable("AlertLogsWork", "Staging");

            entity.Property(e => e.AlertLogId)
                .ValueGeneratedNever()
                .HasColumnName("AlertLogID");
        });

        modelBuilder.Entity<AlertSeverity>(entity =>
        {
            entity.ToTable("AlertSeverity", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<AlertType>(entity =>
        {
            entity.ToTable("AlertType", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<AllergenType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_AllergenType");

            entity.ToTable("AllergenTypes", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<AllocationAvailabilityState>(entity =>
        {
            entity.ToTable("AllocationAvailabilityState", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<AllocationLog>(entity =>
        {
            entity.HasKey(e => e.AllocationLogSk);

            entity.ToTable("AllocationLogs", "Inventory");

            entity.HasIndex(e => e.OrderId, "IDX_Inventory_AllocationLogs_OrderID");

            entity.HasIndex(e => e.StartTime, "IDX_Inventory_AllocationLogs_StartTime");

            entity.Property(e => e.AllocationLogSk).HasColumnName("AllocationLogSK");
            entity.Property(e => e.EndTime).HasDefaultValueSql("(sysdatetimeoffset())");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
        });

        modelBuilder.Entity<AllocationMessage>(entity =>
        {
            entity.ToTable("AllocationMessages", "Inventory");

            entity.HasIndex(e => e.MessageId, "UQ_AllocationMessage_MessageId").IsUnique();

            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.MessageType).HasMaxLength(200);
            entity.Property(e => e.Processed).HasDefaultValue(1);
        });

        modelBuilder.Entity<AllocationPoolType>(entity =>
        {
            entity.ToTable("AllocationPoolType", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Annotation>(entity =>
        {
            entity.ToTable("Annotations", "Structure", tb =>
                {
                    tb.HasTrigger("trg_Annotations_InValidResourceName");
                    tb.HasTrigger("trg_Annotations_UpdateDelete");
                });

            entity.HasIndex(e => e.ResourceName, "IDX_Annotations_ResourceName").IsUnique();

            entity.Property(e => e.EnteredBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ResourceName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StateNote)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.ResourceType).WithMany(p => p.Annotations)
                .HasForeignKey(d => d.ResourceTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Annotations_ResourceType");

            entity.HasOne(d => d.StateReason).WithMany(p => p.Annotations)
                .HasForeignKey(d => d.StateReasonId)
                .HasConstraintName("FK_Annotations_StructureStateReason");
        });

        modelBuilder.Entity<AnnotationsTombstone>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AnnotationsTombstone", "Structure");

            entity.Property(e => e.AnnotationsTombstoneSk)
                .ValueGeneratedOnAdd()
                .HasColumnName("AnnotationsTombstoneSK");
            entity.Property(e => e.EnteredBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ResourceName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StateNote)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.TombstoneDate).HasDefaultValueSql("(getutcdate())");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Application>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Application");

            entity.ToTable("Applications", "Configuration");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ApplicationName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.HasMany(d => d.ConfigurationParameters).WithMany(p => p.Applications)
                .UsingEntity<Dictionary<string, object>>(
                    "ApplicationParameterXref",
                    r => r.HasOne<ConfigurationParameter>().WithMany()
                        .HasForeignKey("ConfigurationParameterId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ApplicationParameterXRef_ConfigParameter"),
                    l => l.HasOne<Application>().WithMany()
                        .HasForeignKey("ApplicationId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ApplicationParameterXRef_Application"),
                    j =>
                    {
                        j.HasKey("ApplicationId", "ConfigurationParameterId").HasName("PK_ApplicationParamterXRef");
                        j.ToTable("ApplicationParameterXRef", "Configuration");
                        j.HasIndex(new[] { "ConfigurationParameterId", "ApplicationId" }, "IDX_FK_ApplicationParameterXRef_ConfigParameter");
                    });
        });

        modelBuilder.Entity<AssetType>(entity =>
        {
            entity.ToTable("AssetType", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<AuditTrailEvent>(entity =>
        {
            entity.ToTable("AuditTrailEvent", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<AuditTrailGroup>(entity =>
        {
            entity.ToTable("AuditTrailGroup", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<AuditTrailLog>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_AuditTrailLog")
                .IsClustered(false);

            entity.ToTable("AuditTrailLogs", "Audit");

            entity.HasIndex(e => e.EventTime, "AuditTrail_EventTime").IsClustered();

            entity.HasIndex(e => new { e.AuditTrailGroup, e.AuditTrailEvent, e.AuditTrailReason }, "idxnc_Audit_AuditTrailLogs__AuditTrailGroup_AuditTrailEvent_AuditTrailReason");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Detail).HasMaxLength(4000);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.NewValue).HasMaxLength(2000);
            entity.Property(e => e.OldValue).HasMaxLength(2000);

            entity.HasOne(d => d.AuditTrailEventNavigation).WithMany(p => p.AuditTrailLogs)
                .HasForeignKey(d => d.AuditTrailEvent)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AuditTrailLogs_AuditTrailEvent");

            entity.HasOne(d => d.AuditTrailGroupNavigation).WithMany(p => p.AuditTrailLogs)
                .HasForeignKey(d => d.AuditTrailGroup)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AuditTrailLogs_AuditTrailGroup");

            entity.HasOne(d => d.AuditTrailReasonNavigation).WithMany(p => p.AuditTrailLogs)
                .HasForeignKey(d => d.AuditTrailReason)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AuditTrailLogs_AuditTrailReason");
        });

        modelBuilder.Entity<AuditTrailLogsWork>(entity =>
        {
            entity.HasKey(e => e.AuditTrailLogsId);

            entity.ToTable("AuditTrailLogsWork", "Staging");

            entity.Property(e => e.AuditTrailLogsId)
                .ValueGeneratedNever()
                .HasColumnName("AuditTrailLogsID");
        });

        modelBuilder.Entity<AuditTrailReason>(entity =>
        {
            entity.ToTable("AuditTrailReason", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<AutoReceivingStatus>(entity =>
        {
            entity.ToTable("AutoReceivingStatus", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<Bay>(entity =>
        {
            entity.ToTable("Bays", "Staging");

            entity.HasIndex(e => new { e.Number, e.AisleId, e.LevelMapModelId, e.Side }, "IX_StgBays_CoveringImportValidation");

            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Bay1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Bay");

            entity.ToTable("Bays", "Structure");

            entity.HasIndex(e => new { e.AisleId, e.ShelfSide }, "IDX_Structure_Bays_AisleId_ShelfSide");

            entity.HasIndex(e => e.ResourceName, "UC_BayResourceName")
                .IsUnique()
                .HasFilter("([ResourceName] IS NOT NULL)");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.ResourceName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Aisle).WithMany(p => p.Bay1s)
                .HasForeignKey(d => d.AisleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Bay_Aisle");

            entity.HasOne(d => d.ShelfSideNavigation).WithMany(p => p.Bay1s)
                .HasForeignKey(d => d.ShelfSide)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Bay_ShelfSide");
        });

        modelBuilder.Entity<Bookmark>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Bookmark");

            entity.ToTable("Bookmarks", "UserPreferences");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Detail).HasColumnType("xml");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.HasOne(d => d.ViewNavigation).WithMany(p => p.Bookmarks)
                .HasForeignKey(d => d.View)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Bookmark_BookmarkView");
        });

        modelBuilder.Entity<BookmarkView>(entity =>
        {
            entity.ToTable("BookmarkView", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<Bot>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Bot");

            entity.ToTable("Bots", "Bot");

            entity.HasIndex(e => e.Number, "UC_Bot_Number").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.AddressEndPointIp).HasMaxLength(250);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.FirmwareVersion).HasMaxLength(25);
            entity.Property(e => e.MacAddress1)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MacAddress2)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MaxChargeMvolts).HasColumnName("MaxChargeMVolts");
            entity.Property(e => e.MinChargeMvolts).HasColumnName("MinChargeMVolts");
            entity.Property(e => e.ModelType).HasDefaultValue(1);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Number)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.RfId1)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RfId2)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Vin)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.HasOne(d => d.ModelTypeNavigation).WithMany(p => p.Bots)
                .HasForeignKey(d => d.ModelType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Bot_BotModel");
        });

        modelBuilder.Entity<BotAlertLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_BotAlertLog");

            entity.ToTable("BotAlertLogs", "Alert");

            entity.HasIndex(e => e.BotId, "IDX_FK_BotAlertLog_Bot");

            entity.HasIndex(e => e.StructureLocationId, "IDX_FK_StructureLocation_StructureLocationId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.AutoLocateCrcfail).HasColumnName("AutoLocateCRCFail ");
            entity.Property(e => e.AutoLocateNoBarcode).HasColumnName("AutoLocateNoBarcode ");
            entity.Property(e => e.BadCaseDimensionErrorExpectedDepth).HasColumnName("BadCaseDimensionError_ExpectedDepth");
            entity.Property(e => e.BadCaseDimensionErrorMeasuredDepth).HasColumnName("BadCaseDimensionError_MeasuredDepth");
            entity.Property(e => e.BladeTargetOutOfRangeErrorFront).HasColumnName("BladeTargetOutOfRangeError_Front");
            entity.Property(e => e.BladeTargetOutOfRangeErrorRear).HasColumnName("BladeTargetOutOfRangeError_Rear");
            entity.Property(e => e.BladeTargetOutOfRangeErrorType).HasColumnName("BladeTargetOutOfRangeError_Type");
            entity.Property(e => e.CannotSecurePayload).HasColumnName("CannotSecure_Payload");
            entity.Property(e => e.CaseHandlingDisabled).HasColumnName("CaseHandling_Disabled");
            entity.Property(e => e.CaseLenOutOfToleranceErrorExpectedDepth).HasColumnName("CaseLenOutOfToleranceError_ExpectedDepth");
            entity.Property(e => e.CaseLenOutOfToleranceErrorMeasuredDepth).HasColumnName("CaseLenOutOfToleranceError_MeasuredDepth");
            entity.Property(e => e.CasePutIntoCaseErrorX1).HasColumnName("CasePutIntoCaseError_X1");
            entity.Property(e => e.CasePutIntoCaseErrorX2).HasColumnName("CasePutIntoCaseError_X2");
            entity.Property(e => e.CasePutIntoCaseErrorY1).HasColumnName("CasePutIntoCaseError_Y1");
            entity.Property(e => e.CasePutIntoCaseErrorY2).HasColumnName("CasePutIntoCaseError_Y2");
            entity.Property(e => e.DynamicStateLinearVel).HasColumnName("DynamicState_LinearVel");
            entity.Property(e => e.DynamicStateRotationVel).HasColumnName("DynamicState_RotationVel");
            entity.Property(e => e.DynamicStateXposition).HasColumnName("DynamicState_XPosition");
            entity.Property(e => e.DynamicStateYaw).HasColumnName("DynamicState_Yaw");
            entity.Property(e => e.DynamicStateYposition).HasColumnName("DynamicState_YPosition");
            entity.Property(e => e.ExperimentalMisc).HasColumnName("Experimental_Misc");
            entity.Property(e => e.ExtensionRetractFail).HasColumnName("ExtensionRetract_Fail");
            entity.Property(e => e.ExtensionTimeoutDirection)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ExtensionTimeout_Direction");
            entity.Property(e => e.ExtensionTimeoutPosition).HasColumnName("ExtensionTimeout_Position");
            entity.Property(e => e.InternalErrorGenericError).HasColumnName("InternalError_GenericError");
            entity.Property(e => e.InventoryCheckResultsCaseGroupNumber).HasColumnName("InventoryCheckResults_CaseGroupNumber");
            entity.Property(e => e.InventoryCheckResultsCasePickDepth).HasColumnName("InventoryCheckResults_CasePickDepth");
            entity.Property(e => e.InventoryCheckResultsCaseYaw).HasColumnName("InventoryCheckResults_CaseYaw");
            entity.Property(e => e.InventoryCheckResultsCenterPointX).HasColumnName("InventoryCheckResults_CenterPointX");
            entity.Property(e => e.InventoryCheckResultsCenterPointY).HasColumnName("InventoryCheckResults_CenterPointY");
            entity.Property(e => e.InventoryCheckResultsLowerXpoint).HasColumnName("InventoryCheckResults_LowerXPoint");
            entity.Property(e => e.InventoryCheckResultsLowerYpoint).HasColumnName("InventoryCheckResults_LowerYPoint");
            entity.Property(e => e.InventoryCheckResultsUpperXpoint).HasColumnName("InventoryCheckResults_UpperXPoint");
            entity.Property(e => e.InventoryCheckResultsUpperYpoint).HasColumnName("InventoryCheckResults_UpperYPoint");
            entity.Property(e => e.LineSensorReportFrontLineScore).HasColumnName("LineSensorReport_FrontLineScore");
            entity.Property(e => e.LineSensorReportRearLineScore).HasColumnName("LineSensorReport_RearLineScore");
            entity.Property(e => e.PositionUncertainEstimateVariance).HasColumnName("PositionUncertain_EstimateVariance");
            entity.Property(e => e.PositionUncertainPositionError).HasColumnName("PositionUncertain_PositionError");
            entity.Property(e => e.PulseWidthFrontPulseWidth).HasColumnName("PulseWidth_FrontPulseWidth");
            entity.Property(e => e.PulseWidthRearPulseWidth).HasColumnName("PulseWidth_RearPulseWidth");
            entity.Property(e => e.RecoverySuccess).HasColumnName("Recovery_Success");
            entity.Property(e => e.RollerTimeoutReason)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.SensorWarningIssue).HasColumnName("SensorWarning_Issue");
            entity.Property(e => e.SensorWarningSensor).HasColumnName("SensorWarning_Sensor");
            entity.Property(e => e.SystemInitializationFailureAxis).HasColumnName("SystemInitializationFailure_Axis");
            entity.Property(e => e.SystemInitializationFailureErrorCode).HasColumnName("SystemInitializationFailure_ErrorCode");
            entity.Property(e => e.ThumperScoreLeftThumperScore).HasColumnName("ThumperScore_LeftThumperScore");
            entity.Property(e => e.ThumperScoreRightThumperScore).HasColumnName("ThumperScore_RightThumperScore");
            entity.Property(e => e.TractionDriveDrive)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("TractionDrive_Drive");
            entity.Property(e => e.TractionDriveErrorString)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("TractionDrive_ErrorString");
            entity.Property(e => e.UnimplementedFatalErrorsCaseBayCalculation).HasColumnName("UnimplementedFatalErrors_CaseBayCalculation");
            entity.Property(e => e.UnimplementedFatalErrorsFeatureMapError).HasColumnName("UnimplementedFatalErrors_FeatureMapError");
            entity.Property(e => e.UnimplementedFatalErrorsNotActive).HasColumnName("UnimplementedFatalErrors_NotActive");
            entity.Property(e => e.UnimplementedFatalErrorsNotInitialised).HasColumnName("UnimplementedFatalErrors_NotInitialised");
            entity.Property(e => e.UnimplementedFatalErrorsRoverAlertBadargs).HasColumnName("UnimplementedFatalErrors_RoverAlertBadargs");
            entity.Property(e => e.UnimplementedFatalErrorsRoverAlertNotinit).HasColumnName("UnimplementedFatalErrors_RoverAlertNotinit");
            entity.Property(e => e.UnimplementedModerateErrorsCasePickNotIdle).HasColumnName("UnimplementedModerateErrors_CasePickNotIdle");
            entity.Property(e => e.UnimplementedModerateErrorsCasePickNotPlanned).HasColumnName("UnimplementedModerateErrors_CasePickNotPlanned");
            entity.Property(e => e.UnimplementedModerateErrorsNoWayPoints).HasColumnName("UnimplementedModerateErrors_NoWayPoints");
            entity.Property(e => e.UnimplementedModerateErrorsPlanningError).HasColumnName("UnimplementedModerateErrors_PlanningError");
            entity.Property(e => e.UnimplementedModerateErrorsTooManyWayPoints).HasColumnName("UnimplementedModerateErrors_TooManyWayPoints");
            entity.Property(e => e.WheelRadiusLeftWheelRadius).HasColumnName("WheelRadius_LeftWheelRadius");
            entity.Property(e => e.WheelRadiusRightWheelRadius).HasColumnName("WheelRadius_RightWheelRadius");
            entity.Property(e => e.WrongLevelErrorExpected).HasColumnName("WrongLevelError_Expected");
            entity.Property(e => e.WrongLevelErrorObserved).HasColumnName("WrongLevelError_Observed");

            entity.HasOne(d => d.Bot).WithMany(p => p.BotAlertLogs)
                .HasForeignKey(d => d.BotId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BotAlertLog_Bot");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.BotAlertLog)
                .HasForeignKey<BotAlertLog>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BotAlertLog_AlertLog");

            entity.HasOne(d => d.StructureLocation).WithMany(p => p.BotAlertLogs)
                .HasForeignKey(d => d.StructureLocationId)
                .HasConstraintName("FK_StructureLocation_StructureLocationId");
        });

        modelBuilder.Entity<BotLift>(entity =>
        {
            entity.ToTable("BotLifts", "Staging");

            entity.Property(e => e.CarriageMapNodeName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BotLift1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_BotLift");

            entity.ToTable("BotLifts", "Structure");

            entity.HasIndex(e => e.ModuleId, "IDX_FK_BotLift_Module");

            entity.HasIndex(e => e.Name, "UC_BotLiftName").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(50);

            entity.HasOne(d => d.Module).WithMany(p => p.BotLift1s)
                .HasForeignKey(d => d.ModuleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BotLift_Module");
        });

        modelBuilder.Entity<BotLiftLevel>(entity =>
        {
            entity.ToTable("BotLiftLevels", "Staging");

            entity.Property(e => e.BotLiftName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BotLiftReader>(entity =>
        {
            entity.ToTable("BotLiftReaders", "Staging");

            entity.Property(e => e.BotLiftName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BotLocation>(entity =>
        {
            entity.ToTable("BotLocation", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<BotMaintenanceLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_BotMaintLog");

            entity.ToTable("BotMaintenanceLogs", "Bot");

            entity.HasIndex(e => new { e.BotNumber, e.CreatedDate }, "IDX_Bot_BotMaintenanceLogs_BotNumber_CreatedDate");

            entity.Property(e => e.BotNumber)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.OperatorComment).IsUnicode(false);

            entity.HasOne(d => d.BotNumberNavigation).WithMany(p => p.BotMaintenanceLogs)
                .HasPrincipalKey(p => p.Number)
                .HasForeignKey(d => d.BotNumber)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BotMaintLog_Bot");
        });

        modelBuilder.Entity<BotModel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_BotModel");

            entity.ToTable("BotModels", "Bot");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.DistanceFromCedsensorToFrontOfBot).HasColumnName("DistanceFromCEDSensorToFrontOfBot");
            entity.Property(e => e.DistanceFromCedsensorToRearOfBot).HasColumnName("DistanceFromCEDSensorToRearOfBot");
            entity.Property(e => e.FirmwareVersion)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.MaxChargeMvolts).HasColumnName("MaxChargeMVolts");
            entity.Property(e => e.MinChargeMvolts).HasColumnName("MinChargeMVolts");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BotPullDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_BotPullDetail");

            entity.ToTable("BotPullDetails", "Bot");

            entity.HasIndex(e => e.BotNumber, "UC_Number").IsUnique();

            entity.Property(e => e.BotNumber)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.PullReason)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.HasOne(d => d.BotNumberNavigation).WithOne(p => p.BotPullDetail)
                .HasPrincipalKey<Bot>(p => p.Number)
                .HasForeignKey<BotPullDetail>(d => d.BotNumber)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BotPullDetail_Number");
        });

        modelBuilder.Entity<BotState>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_BotState");

            entity.ToTable("BotStates", "Bot");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.LineSensorReportFrontLineScore)
                .HasDefaultValue(0)
                .HasColumnName("LineSensorReport_FrontLineScore");
            entity.Property(e => e.LineSensorReportRearLineScore)
                .HasDefaultValue(0)
                .HasColumnName("LineSensorReport_RearLineScore");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ThumperScoreLeftThumperScore).HasColumnName("ThumperScore_LeftThumperScore");
            entity.Property(e => e.ThumperScoreRightThumperScore).HasColumnName("ThumperScore_RightThumperScore");
            entity.Property(e => e.WheelRadiusLeftWheelRadius).HasColumnName("WheelRadius_LeftWheelRadius");
            entity.Property(e => e.WheelRadiusRightWheelRadius).HasColumnName("WheelRadius_RightWheelRadius");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.BotState)
                .HasForeignKey<BotState>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BotState_Bot");
        });

        modelBuilder.Entity<BotWarehouseState>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_BotWarehouseState");

            entity.ToTable("BotWarehouseStates", "Bot", tb => tb.HasTrigger("Trg_BotWarehouseStates_LocationInsert"));

            entity.HasIndex(e => new { e.ToDate, e.Location, e.LevelId }, "IDX_Bot_BotWarehouseStates_ActiveBWS");

            entity.HasIndex(e => new { e.BotId, e.ToDate }, "IDX_Bot_BotWarehouseStates_BotId_ToDate");

            entity.HasIndex(e => e.LevelId, "IDX_FK_BotWarehouseState_Level");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.HasOne(d => d.Bot).WithMany(p => p.BotWarehouseStates)
                .HasForeignKey(d => d.BotId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BotWarehouseState_Bot");

            entity.HasOne(d => d.Level).WithMany(p => p.BotWarehouseStates)
                .HasForeignKey(d => d.LevelId)
                .HasConstraintName("FK_BotWarehouseState_Level");

            entity.HasOne(d => d.LocationNavigation).WithMany(p => p.BotWarehouseStates)
                .HasForeignKey(d => d.Location)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BotWarehouseStates_BotLocation");
        });

        modelBuilder.Entity<BotWorkOrder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_BotWorkOrder");

            entity.ToTable("BotWorkOrders", "Maintenance");

            entity.HasIndex(e => e.BotId, "IDX_FK_BotWorkOrder_Bot");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Bot).WithMany(p => p.BotWorkOrders)
                .HasForeignKey(d => d.BotId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BotWorkOrder_Bot");
        });

        modelBuilder.Entity<BreakPackEligible>(entity =>
        {
            entity.ToTable("BreakPackEligible", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<BreakpackLoop>(entity =>
        {
            entity.ToTable("BreakpackLoops", "Staging");

            entity.Property(e => e.CellName).HasMaxLength(50);
            entity.Property(e => e.CellSide)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.TurnAroundDeckName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BreakpackLoop1>(entity =>
        {
            entity.ToTable("BreakpackLoops", "Structure");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.CellName).HasMaxLength(50);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.TurnAroundDeckName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.CellSide).WithMany(p => p.BreakpackLoop1s)
                .HasForeignKey(d => d.CellSideId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BreakpackLoops_CellSide");

            entity.HasOne(d => d.InteractionAisle).WithMany(p => p.BreakpackLoop1InteractionAisles)
                .HasForeignKey(d => d.InteractionAisleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BreakpackLoops_InteractionAisle");

            entity.HasOne(d => d.Level).WithMany(p => p.BreakpackLoop1s)
                .HasForeignKey(d => d.LevelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BreakpackLoops_Level");

            entity.HasOne(d => d.TransitAisle).WithMany(p => p.BreakpackLoop1TransitAisles)
                .HasForeignKey(d => d.TransitAisleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BreakpackLoops_TransitAisle");
        });

        modelBuilder.Entity<BreakpackTransferBuffer>(entity =>
        {
            entity.ToTable("BreakpackTransferBuffers", "Staging");

            entity.Property(e => e.CellName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MapNode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Xcoordinate).HasColumnName("XCoordinate");
            entity.Property(e => e.Ycoordinate).HasColumnName("YCoordinate");
        });

        modelBuilder.Entity<CandidateCaseGroupNumber>(entity =>
        {
            entity.ToTable("CandidateCaseGroupNumbers", "Orders");

            entity.HasIndex(e => new { e.CaseGroupNumber, e.OrderDetailId }, "UIX_Orders_CandidateCaseGroupNumbers_CGN_OrdDetailID").IsUnique();

            entity.HasIndex(e => new { e.OrderDetailId, e.CaseGroupNumber }, "UNCLIX_CandidateCaseGroupNumbers").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.EligibleForCr)
                .HasDefaultValue(true)
                .HasColumnName("EligibleForCR");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.HasOne(d => d.IneligibilityReason).WithMany(p => p.CandidateCaseGroupNumbers)
                .HasForeignKey(d => d.IneligibilityReasonId)
                .HasConstraintName("FK_CandidateCaseGroupNumbers_IneligibilityReason");

            entity.HasOne(d => d.OrderDetail).WithMany(p => p.CandidateCaseGroupNumbers)
                .HasForeignKey(d => d.OrderDetailId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CandidateCaseGroupNumbers_OrderDetail");
        });

        modelBuilder.Entity<CandidateCustomerCartonRef>(entity =>
        {
            entity.ToTable("CandidateCustomerCartonRefs", "Orders");

            entity.HasIndex(e => new { e.OrderDetailId, e.CustomerCartonRef }, "UQX_CandidateCustomerCartonRefs").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CustomerCartonRef)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.HasOne(d => d.OrderDetail).WithMany(p => p.CandidateCustomerCartonRefs)
                .HasForeignKey(d => d.OrderDetailId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CandidateCustomerCartonRefs_OrderDetail");
        });

        modelBuilder.Entity<Carton>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Carton");

            entity.ToTable("Cartons", "Inventory", tb =>
                {
                    tb.HasTrigger("trg_Carton_Insert");
                    tb.HasTrigger("trg_Carton_InsertUpdateSetCellGroupOnStoreTote");
                    tb.HasTrigger("trg_Cartons_LogHistory");
                });

            entity.HasIndex(e => e.ContainerTypeId, "IDX_Cartons_ContainerTypeIDWithIncludes");

            entity.HasIndex(e => new { e.LpnId, e.EnteringWarehouseTime, e.ExitingWarehouseTime }, "IDX_FK_Carton_Lpn");

            entity.HasIndex(e => e.UpcId, "IDX_FK_Carton_Upc");

            entity.HasIndex(e => new { e.SkuId, e.Ssp, e.Vcp, e.ExpirationDate, e.IsOpenCase, e.ExitingWarehouseTime, e.EnteringWarehouseTime }, "IDX_Inventory_Cartons_AllocationGenericResponse");

            entity.HasIndex(e => e.AlternateContainerRef, "IDX_Inventory_Cartons_AlternateContainerRef");

            entity.HasIndex(e => e.ContainerTypeId, "IDX_Inventory_Cartons_ContainerTypeId");

            entity.HasIndex(e => e.CustomerCartonRef, "IDX_Inventory_Cartons_CustomerCartonRef").IsUnique();

            entity.HasIndex(e => new { e.OutboundDimVarId, e.ExitingWarehouseTime, e.State, e.EnteringWarehouseTime }, "IDX_Inventory_Cartons_ODV_PlanningInformation");

            entity.HasIndex(e => new { e.ExitingWarehouseTime, e.EnteringWarehouseTime }, "IDX_Inventory_Cartons_WarehouseTimes");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.AlternateContainerRef)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Batch)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CustomerCartonRef)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DeliveryGroup)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.EnableDimensionCheck).HasDefaultValue(true);
            entity.Property(e => e.Fifodate).HasColumnName("FIFODate");
            entity.Property(e => e.HandlingDimensions).IsUnicode(false);
            entity.Property(e => e.HoldReason)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.IsActiveCustomerCartonRef).HasDefaultValue(true);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Ponumber).HasColumnName("PONumber");
            entity.Property(e => e.SourceFacility)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Ssp).HasColumnName("SSP");
            entity.Property(e => e.State).HasDefaultValue(1);
            entity.Property(e => e.StoreLabel).IsUnicode(false);
            entity.Property(e => e.StoredLength).HasComputedColumnSql("(isnull([BotMeasuredLength],[Length]))", true);
            entity.Property(e => e.StoredWidth).HasComputedColumnSql("(isnull([BotMeasuredWidth],[Width]))", true);
            entity.Property(e => e.Vcp).HasColumnName("VCP");

            entity.HasOne(d => d.ContainerType).WithMany(p => p.Cartons)
                .HasForeignKey(d => d.ContainerTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cartons_ContainerType");

            entity.HasOne(d => d.LabelType).WithMany(p => p.Cartons)
                .HasForeignKey(d => d.LabelTypeId)
                .HasConstraintName("FK_Cartons_LabelType");

            entity.HasOne(d => d.Lpn).WithMany(p => p.Cartons)
                .HasForeignKey(d => d.LpnId)
                .HasConstraintName("FK_Carton_Lpn");

            entity.HasOne(d => d.OutboundDimVar).WithMany(p => p.Cartons)
                .HasForeignKey(d => d.OutboundDimVarId)
                .HasConstraintName("FK_Cartons_OutboundDimVars");

            entity.HasOne(d => d.Sku).WithMany(p => p.Cartons)
                .HasForeignKey(d => d.SkuId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Carton_Sku");

            entity.HasOne(d => d.StateNavigation).WithMany(p => p.Cartons)
                .HasForeignKey(d => d.State)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cartons_CartonState");

            entity.HasOne(d => d.StoredOrientationNavigation).WithMany(p => p.Cartons)
                .HasForeignKey(d => d.StoredOrientation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cartons_StoredOrientation");

            entity.HasOne(d => d.Upc).WithMany(p => p.Cartons)
                .HasForeignKey(d => d.UpcId)
                .HasConstraintName("FK_Carton_Upc");
        });

        modelBuilder.Entity<CartonAvailabilitySelectionMode>(entity =>
        {
            entity.ToTable("CartonAvailabilitySelectionMode", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<CartonExtension>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_Inventory_CartonExtension_Id")
                .IsClustered(false);

            entity.ToTable("CartonExtension", "Inventory");

            entity.HasIndex(e => new { e.CartonId, e.ExtensionKeyId }, "UQX_CartonExtension_CartonID_KeyId")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CartonId)
                .HasComment("FK Ref Inventory.Cartons.ID")
                .HasColumnName("CartonID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("(left(suser_name(),(25)))");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime");
            entity.Property(e => e.ExtensionKeyId)
                .HasComment("FK Ref Extension.CartonExtensionKey.Id.")
                .HasColumnName("ExtensionKeyID");
            entity.Property(e => e.ExtensionValue).HasMaxLength(2000);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("(left(suser_name(),(25)))");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Carton).WithMany(p => p.CartonExtensions)
                .HasForeignKey(d => d.CartonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Inventory_Cartons_ID");

            entity.HasOne(d => d.ExtensionKey).WithMany(p => p.CartonExtensions)
                .HasForeignKey(d => d.ExtensionKeyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CartonExtensionKeyID");
        });

        modelBuilder.Entity<CartonExtensionKey>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_CartonExtensionKeyID");

            entity.ToTable("CartonExtensionKey", "Extension");

            entity.HasIndex(e => e.Name, "UQX_CartonExtensionKeyName").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(sysdatetimeoffset())");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(sysdatetimeoffset())");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CartonLabel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_CartonLabel");

            entity.ToTable("CartonLabels", "Orders");

            entity.HasIndex(e => e.Id, "IDX_FK_LabelBase_CartonLabel");

            entity.HasIndex(e => e.OrderDetailId, "IDX_FK_OrderDetail_CartonLabel");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.CartonLabel)
                .HasForeignKey<CartonLabel>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LabelBase_CartonLabel");

            entity.HasOne(d => d.OrderDetail).WithMany(p => p.CartonLabels)
                .HasForeignKey(d => d.OrderDetailId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderDetail_CartonLabel");
        });

        modelBuilder.Entity<CartonLabel1>(entity =>
        {
            entity.ToTable("CartonLabels", "Staging");

            entity.HasIndex(e => e.SessionKey, "IX_CartonLabels");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.BarCode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LabelData)
                .HasMaxLength(4000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CartonLift>(entity =>
        {
            entity.HasKey(e => e.Number);

            entity.ToTable("CartonLifts", "Staging");

            entity.Property(e => e.Number).ValueGeneratedNever();
            entity.Property(e => e.CellName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.GroupId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ModuleNumber).HasComment("The Module Number for the CartonLift. Currently not provided in Structure File");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CartonLift1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_CartonLift");

            entity.ToTable("CartonLifts", "Structure");

            entity.HasIndex(e => e.ModuleId, "IDX_FK_CartonLift_Module");

            entity.HasIndex(e => e.Name, "UC_CartonLiftName").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.CartonLiftGroupNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CellName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(500);

            entity.HasOne(d => d.Module).WithMany(p => p.CartonLift1s)
                .HasForeignKey(d => d.ModuleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CartonLift_Module");
        });

        modelBuilder.Entity<CartonLiftArm>(entity =>
        {
            entity.ToTable("CartonLiftArms", "Staging");
        });

        modelBuilder.Entity<CartonLiftMotionParameter>(entity =>
        {
            entity.ToTable("CartonLiftMotionParameters", "Staging");

            entity.Property(e => e.Type)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CartonLiftOffset>(entity =>
        {
            entity.ToTable("CartonLiftOffsets", "Staging");

            entity.Property(e => e.PickZoffset).HasColumnName("PickZOffset");
            entity.Property(e => e.PlaceZoffset).HasColumnName("PlaceZOffset");
        });

        modelBuilder.Entity<CartonLiftState>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_CartonLiftState");

            entity.ToTable("CartonLiftStates", "Structure", tb =>
                {
                    tb.HasTrigger("trg_CartonLiftStates_Insert");
                    tb.HasTrigger("trg_CartonLiftStates_Update");
                });

            entity.HasIndex(e => e.CartonLiftId, "IDX_FK_CartonLiftState_CartonLift");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.IsEnabled).HasDefaultValue(true);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.HasOne(d => d.CartonLift).WithMany(p => p.CartonLiftStates)
                .HasForeignKey(d => d.CartonLiftId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CartonLiftState_CartonLift");

            entity.HasOne(d => d.StateNavigation).WithMany(p => p.CartonLiftStates)
                .HasForeignKey(d => d.State)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CartonLiftState_CartonLiftTransitionState");

            entity.HasOne(d => d.StopReasonNavigation).WithMany(p => p.CartonLiftStates)
                .HasForeignKey(d => d.StopReason)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CartonLiftState_CartonLiftStopReason");
        });

        modelBuilder.Entity<CartonLiftStatesTombstone>(entity =>
        {
            entity.HasKey(e => e.CartonLiftStatesTombstoneSk).HasName("PK_CartonLiftStateTombstone");

            entity.ToTable("CartonLiftStatesTombstone", "Structure");

            entity.Property(e => e.CartonLiftStatesTombstoneSk).HasColumnName("CartonLiftStatesTombstoneSK");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.TombstoneDate).HasDefaultValueSql("(getutcdate())");
        });

        modelBuilder.Entity<CartonLiftStopReason>(entity =>
        {
            entity.ToTable("CartonLiftStopReason", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<CartonLiftTransitionState>(entity =>
        {
            entity.ToTable("CartonLiftTransitionState", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<CartonRejectReason>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_RefTab_CartonRejectReasons");

            entity.ToTable("CartonRejectReasons", "ReferenceTables");

            entity.HasIndex(e => e.Name, "UQX_RefTab_CartonRejectReasonName").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("This ID value is bit-masked INT, which goes exponentially, i.e. 4,8,6,32... up to ~2B as INT. The SUM of any single one or combo of this ID value is written to RejectReason on Inbound.InboundCartons. ");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CartonRequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_CartonRequest");

            entity.ToTable("CartonRequests", "Outbound");

            entity.HasIndex(e => e.ModifiedDate, "IDX_CartonRequests_ModifiedDate");

            entity.HasIndex(e => e.LpnId, "IDX_FK_CartonRequest_Lpn");

            entity.HasIndex(e => new { e.SkuId, e.DeliveryState }, "IDX_FK_CartonRequest_Sku");

            entity.HasIndex(e => e.OrderDetailId, "IDX_FK_CartonRequests_OrderDetail");

            entity.HasIndex(e => e.OutboundDimensionalVariantId, "IDX_FK_CartonRequests_OutboundDimVar");

            entity.HasIndex(e => new { e.DeliveryState, e.Vcp, e.Ssp, e.SkuId, e.OutboundId, e.CustomerCartonRef }, "IDX_Outbound_CartonRequests_AllocationResponse");

            entity.HasIndex(e => new { e.DeliveryState, e.CustomerCartonRef }, "IDX_Outbound_CartonRequests_DeliveryState");

            entity.HasIndex(e => e.OutboundId, "IDX_Outbound_CartonRequests_OutboundId");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.Batch)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.CartonAvailabilitySelectionMode).HasDefaultValue(1);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CustomerCartonRef)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Ponumber).HasColumnName("PONumber");
            entity.Property(e => e.SourceFacility)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Ssp).HasColumnName("SSP");
            entity.Property(e => e.UseAvailableOnly).HasDefaultValue(true);
            entity.Property(e => e.Vcp).HasColumnName("VCP");

            entity.HasOne(d => d.AllocationPoolTypeNavigation).WithMany(p => p.CartonRequests)
                .HasForeignKey(d => d.AllocationPoolType)
                .HasConstraintName("FK_CartonRequests_AllocationPoolType");

            entity.HasOne(d => d.CartonAvailabilitySelectionModeNavigation).WithMany(p => p.CartonRequests)
                .HasForeignKey(d => d.CartonAvailabilitySelectionMode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CartonRequests_CartonAvailabilitySelectionMode");

            entity.HasOne(d => d.CartonTypeSelectionModeNavigation).WithMany(p => p.CartonRequests)
                .HasForeignKey(d => d.CartonTypeSelectionMode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CartonRequests_CartonTypeSelectionMode");

            entity.HasOne(d => d.ContainerTypeNavigation).WithMany(p => p.CartonRequests)
                .HasForeignKey(d => d.ContainerType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CartonRequests_ContainerType");

            entity.HasOne(d => d.DeliveryStateNavigation).WithMany(p => p.CartonRequests)
                .HasForeignKey(d => d.DeliveryState)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CartonRequests_DeliveryState");

            entity.HasOne(d => d.LabelType).WithMany(p => p.CartonRequests)
                .HasForeignKey(d => d.LabelTypeId)
                .HasConstraintName("FK_CartonRequests_LabelType");

            entity.HasOne(d => d.Lpn).WithMany(p => p.CartonRequests)
                .HasForeignKey(d => d.LpnId)
                .HasConstraintName("FK_CartonRequest_Lpn");

            entity.HasOne(d => d.LpnSelectionModeNavigation).WithMany(p => p.CartonRequests)
                .HasForeignKey(d => d.LpnSelectionMode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CartonRequests_LpnSelectionMode");

            entity.HasOne(d => d.OrderDetail).WithMany(p => p.CartonRequests)
                .HasForeignKey(d => d.OrderDetailId)
                .HasConstraintName("FK_CartonRequests_OrderDetail");

            entity.HasOne(d => d.OutboundDimensionalVariant).WithMany(p => p.CartonRequests)
                .HasForeignKey(d => d.OutboundDimensionalVariantId)
                .HasConstraintName("FK_CartonRequests_OutboundDimVar");

            entity.HasOne(d => d.Outbound).WithMany(p => p.CartonRequests)
                .HasForeignKey(d => d.OutboundId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CartonRequest_OutboundPallet");

            entity.HasOne(d => d.ScratchReasonNavigation).WithMany(p => p.CartonRequests)
                .HasForeignKey(d => d.ScratchReason)
                .HasConstraintName("FK_CartonRequests_ScratchReason");

            entity.HasOne(d => d.Sku).WithMany(p => p.CartonRequests)
                .HasForeignKey(d => d.SkuId)
                .HasConstraintName("FK_CartonRequest_Sku");

            entity.HasMany(d => d.OutboundCartons).WithMany(p => p.CartonRequests)
                .UsingEntity<Dictionary<string, object>>(
                    "OutboundCartonsCartonRequest",
                    r => r.HasOne<OutboundCarton>().WithMany()
                        .HasForeignKey("OutboundCartonId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_OutboundCartonCartonRequest_OutboundCarton"),
                    l => l.HasOne<CartonRequest>().WithMany()
                        .HasForeignKey("CartonRequestId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_OutboundCartonCartonRequest_PlannedCarton"),
                    j =>
                    {
                        j.HasKey("CartonRequestId", "OutboundCartonId").HasName("PK_OutboundCartonCartonRequest");
                        j.ToTable("OutboundCartonsCartonRequests", "Outbound");
                        j.HasIndex(new[] { "OutboundCartonId", "CartonRequestId" }, "IDX_OutboundCartonsCartonRequests_Columns");
                    });
        });

        modelBuilder.Entity<CartonRequestsWork>(entity =>
        {
            entity.HasKey(e => e.CartonRequestId);

            entity.ToTable("CartonRequestsWork", "Staging");

            entity.Property(e => e.CartonRequestId).ValueGeneratedNever();
        });

        modelBuilder.Entity<CartonScan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_CartonScan");

            entity.ToTable("CartonScans", "Inventory");

            entity.HasIndex(e => e.CartonId, "IDX_Inventory_CartonScans_CartonId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ScanSource)
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.HasOne(d => d.Carton).WithMany(p => p.CartonScans)
                .HasForeignKey(d => d.CartonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CartonScan_Carton");

            entity.HasOne(d => d.ScannerTypeNavigation).WithMany(p => p.CartonScans)
                .HasForeignKey(d => d.ScannerType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CartonScan_ScannerType");
        });

        modelBuilder.Entity<CartonState>(entity =>
        {
            entity.ToTable("CartonState", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<CartonTypeSelectionMode>(entity =>
        {
            entity.ToTable("CartonTypeSelectionMode", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<CartonsHistory>(entity =>
        {
            entity.HasKey(e => e.CartonHistorySk).HasName("PK_CartonsHistorySK");

            entity.ToTable("CartonsHistory", "Inventory");

            entity.HasIndex(e => e.Id, "IX_InventoryCartonsHistory_CartonID");

            entity.Property(e => e.CartonHistorySk).HasColumnName("CartonHistorySK");
            entity.Property(e => e.AlternateContainerRef)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Batch)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CustomerCartonRef)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DeliveryGroup)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Fifodate).HasColumnName("FIFODate");
            entity.Property(e => e.HandlingDimensions).IsUnicode(false);
            entity.Property(e => e.HoldReason)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Ponumber).HasColumnName("PONumber");
            entity.Property(e => e.SourceFacility)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Ssp).HasColumnName("SSP");
            entity.Property(e => e.StoreLabel).IsUnicode(false);
            entity.Property(e => e.Vcp).HasColumnName("VCP");
        });

        modelBuilder.Entity<CartonsVcpeachesBackup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CartonsVCPEachesBackup", "Support");

            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CartonsVcpsspbackup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CartonsVCPSSPBackup", "Support");

            entity.Property(e => e.NewSsp).HasColumnName("NewSSP");
            entity.Property(e => e.NewVcp).HasColumnName("NewVCP");
            entity.Property(e => e.OldSsp).HasColumnName("OldSSP");
            entity.Property(e => e.OldVcp).HasColumnName("OldVCP");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CartonsWork>(entity =>
        {
            entity.HasKey(e => e.CartonId).HasName("PK_StagingCartonsWork_CartonID");

            entity.ToTable("CartonsWork", "Staging");

            entity.Property(e => e.CartonId)
                .ValueGeneratedNever()
                .HasColumnName("CartonID");
        });

        modelBuilder.Entity<Cell>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Cells_Id");

            entity.ToTable("Cells", "Staging");

            entity.Property(e => e.CellGroup)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Direction)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Cell1>(entity =>
        {
            entity.ToTable("Cells", "Structure");

            entity.HasIndex(e => e.Name, "UC_Cells_Name").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.CellGroup)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Direction)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<ChildOutboundType>(entity =>
        {
            entity.ToTable("ChildOutboundType", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<CleanupOrdersBackup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CleanupOrdersBackup", "Support");

            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CodePlate>(entity =>
        {
            entity.HasKey(e => e.CodePlateId).HasName("PK_Staging_CodePlates");

            entity.ToTable("CodePlates", "Staging");

            entity.Property(e => e.CodePlateId).ValueGeneratedNever();
            entity.Property(e => e.ChargerName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Xend).HasColumnName("XEnd");
            entity.Property(e => e.Xstart).HasColumnName("XStart");
            entity.Property(e => e.Yend).HasColumnName("YEnd");
            entity.Property(e => e.Ystart).HasColumnName("YStart");
        });

        modelBuilder.Entity<CodePlate1>(entity =>
        {
            entity.ToTable("CodePlates", "Structure");

            entity.HasIndex(e => e.CodePlateId, "UC_CodePlates_CodePlateId").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.ChargerName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Xend).HasColumnName("XEnd");
            entity.Property(e => e.Xstart).HasColumnName("XStart");
            entity.Property(e => e.Yend).HasColumnName("YEnd");
            entity.Property(e => e.Ystart).HasColumnName("YStart");

            entity.HasOne(d => d.Level).WithMany(p => p.CodePlate1s)
                .HasForeignKey(d => d.LevelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CodePlates_Level");
        });

        modelBuilder.Entity<ConfigurationBlob>(entity =>
        {
            entity.ToTable("ConfigurationBlob", "Configuration");

            entity.HasIndex(e => e.Key, "UC_ConfigurationBlob_Key").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Key)
                .HasMaxLength(512)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ConfigurationGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ConfigGroup");

            entity.ToTable("ConfigurationGroups", "Configuration");

            entity.HasIndex(e => e.Path, "IDX_ConfigurationGroups_Path");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.DisplayText).HasMaxLength(500);
            entity.Property(e => e.GroupName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Path)
                .HasMaxLength(512)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ConfigurationGroup1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ConfigGroup");

            entity.ToTable("ConfigurationGroups", "Staging");

            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.DisplayText).HasMaxLength(500);
            entity.Property(e => e.GroupName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Path)
                .HasMaxLength(512)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ConfigurationParameter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ConfigParameter");

            entity.ToTable("ConfigurationParameters", "Configuration", tb => tb.HasTrigger("trg_log_ConfigurationParameterChange"));

            entity.HasIndex(e => e.Path, "IDX_ConfigurationParameters_Path");

            entity.HasIndex(e => e.GroupId, "IDX_FK_ConfigParameter_ConfigSubGroup");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.DisplayText).HasMaxLength(500);
            entity.Property(e => e.FullyQualifiedTypeName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.IsEditable).HasDefaultValue(true);
            entity.Property(e => e.MaxValue)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.MinValue)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Path)
                .HasMaxLength(512)
                .IsUnicode(false);
            entity.Property(e => e.ValidationRegEx)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ValidationRegexFailMessage).HasMaxLength(250);
            entity.Property(e => e.Value).HasMaxLength(4000);

            entity.HasOne(d => d.Group).WithMany(p => p.ConfigurationParameters)
                .HasForeignKey(d => d.GroupId)
                .HasConstraintName("FK_ConfigParameter_ConfigSubGroup");
        });

        modelBuilder.Entity<ConfigurationParameter1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ConfigParameter");

            entity.ToTable("ConfigurationParameters", "Staging");

            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.DisplayText).HasMaxLength(500);
            entity.Property(e => e.FullyQualifiedTypeName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.MaxValue)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.MinValue)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Path)
                .HasMaxLength(512)
                .IsUnicode(false);
            entity.Property(e => e.ValidationRegEx)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ValidationRegexFailMessage).HasMaxLength(250);
            entity.Property(e => e.Value).HasMaxLength(4000);
        });

        modelBuilder.Entity<ConfigurationParametersChangeLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ConfigParametersChangeLog");

            entity.ToTable("ConfigurationParametersChangeLog", "Configuration");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ArchiveReason)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ArchivedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ArchivedDate).HasDefaultValueSql("(sysdatetimeoffset())");
            entity.Property(e => e.ChangeWasAdelete).HasColumnName("ChangeWasADelete");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.DisplayText).HasMaxLength(500);
            entity.Property(e => e.FullyQualifiedTypeName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.MaxValue)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.MinValue)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Path)
                .HasMaxLength(512)
                .IsUnicode(false);
            entity.Property(e => e.ValidationRegEx)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ValidationRegexFailMessage).HasMaxLength(250);
            entity.Property(e => e.Value).HasMaxLength(4000);
        });

        modelBuilder.Entity<Conflict>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Conflict");

            entity.ToTable("Conflicts", "Inventory");

            entity.HasIndex(e => e.IsResolved, "IX_Conflicts_IsResolved");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ConflictTime).HasColumnName("conflictTime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.FromCartonGroupLocationGuid).HasColumnName("fromCartonGroupLocationGuid");
            entity.Property(e => e.FromCartonGroupType).HasColumnName("fromCartonGroupType");
            entity.Property(e => e.IsResolved).HasColumnName("isResolved");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ToCartonGroupLocationGuid).HasColumnName("toCartonGroupLocationGuid");
            entity.Property(e => e.ToCartonGroupType).HasColumnName("toCartonGroupType");
        });

        modelBuilder.Entity<ConflictCarton>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ConflictCarton");

            entity.ToTable("ConflictCartons", "Inventory");

            entity.HasIndex(e => e.ConflictId, "IDX_FK_ConflictId");

            entity.HasIndex(e => new { e.CartonId, e.IsResolved }, "IX_ConflictCartons_CartonIdAndIsResolved");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.IsFrom).HasColumnName("isFrom");
            entity.Property(e => e.IsResolved).HasColumnName("isResolved");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.XPos).HasColumnName("xPos");
            entity.Property(e => e.YPos).HasColumnName("yPos");

            entity.HasOne(d => d.Conflict).WithMany(p => p.ConflictCartons)
                .HasForeignKey(d => d.ConflictId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConflictId");
        });

        modelBuilder.Entity<ContainerType>(entity =>
        {
            entity.ToTable("ContainerType", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<ConveyorLane>(entity =>
        {
            entity.ToTable("ConveyorLanes", "Staging");

            entity.Property(e => e.ConveyorSubsystemRef).IsUnicode(false);
            entity.Property(e => e.EndpointId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SynchronizeAvailability).HasDefaultValue(true);
            entity.Property(e => e.SynchronizeState).HasDefaultValue(true);
        });

        modelBuilder.Entity<ConveyorLane1>(entity =>
        {
            entity.ToTable("ConveyorLanes", "Structure");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.ConveyorSubsystemRef).IsUnicode(false);
            entity.Property(e => e.SynchronizeAvailability).HasDefaultValue(true);
            entity.Property(e => e.SynchronizeState).HasDefaultValue(true);

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.ConveyorLane1)
                .HasForeignKey<ConveyorLane1>(d => d.Id)
                .HasConstraintName("FK_ConveyorLanes_Endpoint");
        });

        modelBuilder.Entity<CustomerPriorityRule>(entity =>
        {
            entity.ToTable("CustomerPriorityRules", "Orders");

            entity.HasIndex(e => e.CustomerNumber, "IX_CustomerPriorityRules_CustomerNumber").IsUnique();

            entity.HasIndex(e => e.CustomerNumber, "UC_CustomerNumber").IsUnique();

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CustomerNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

            entity.HasOne(d => d.OutputPriorityNavigation).WithMany(p => p.CustomerPriorityRules)
                .HasForeignKey(d => d.OutputPriority)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomerPriorityRules_OutputPriority");
        });

        modelBuilder.Entity<Deck>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DecksStaging");

            entity.ToTable("Decks", "Staging");

            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Deck1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Deck");

            entity.ToTable("Decks", "Structure");

            entity.HasIndex(e => e.ResourceName, "UC_DeckResourceName")
                .IsUnique()
                .HasFilter("([ResourceName] IS NOT NULL)");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ResourceName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Level).WithMany(p => p.Deck1s)
                .HasForeignKey(d => d.LevelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Deck_Level");

            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.Deck1s)
                .HasForeignKey(d => d.Type)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Deck_Type");
        });

        modelBuilder.Entity<DeckLine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Staging_DeckLines");

            entity.ToTable("DeckLines", "Staging");

            entity.Property(e => e.AisleDwRef)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.DeckLines)
                .HasForeignKey(d => d.Type)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_STG_DeckLine_Type");
        });

        modelBuilder.Entity<DeckLine1>(entity =>
        {
            entity.ToTable("DeckLines", "Structure");

            entity.HasIndex(e => e.ResourceName, "IDX_Structure_DeckLines_ResourceName").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ResourceName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Deck).WithMany(p => p.DeckLine1s)
                .HasForeignKey(d => d.DeckId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DeckLine_Decks");

            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.DeckLine1s)
                .HasForeignKey(d => d.Type)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DeckLine_Type");
        });

        modelBuilder.Entity<DeckLineType>(entity =>
        {
            entity.ToTable("DeckLineType", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DeckState>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DeckStatesStates");

            entity.ToTable("DeckStates", "Structure", tb =>
                {
                    tb.HasTrigger("trg_DeckStates_Insert");
                    tb.HasTrigger("trg_DeckStates_Update");
                });

            entity.HasIndex(e => e.DeckId, "IDX_Structure_DeckStates_DeckId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.State).HasDefaultValue(2);
            entity.Property(e => e.StateChangeDateTime).HasDefaultValueSql("(sysdatetimeoffset())");
            entity.Property(e => e.StateNote)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.Deck).WithMany(p => p.DeckStates)
                .HasForeignKey(d => d.DeckId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DeckStateStates_Decks");

            entity.HasOne(d => d.StateNavigation).WithMany(p => p.DeckStates)
                .HasForeignKey(d => d.State)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DeckState_States");
        });

        modelBuilder.Entity<DeckStatesTombstone>(entity =>
        {
            entity.HasKey(e => e.DeckStatesTombstoneSk);

            entity.ToTable("DeckStatesTombstone", "Structure");

            entity.Property(e => e.DeckStatesTombstoneSk).HasColumnName("DeckStatesTombstoneSK");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.StateNote)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.TombstoneDate).HasDefaultValueSql("(getutcdate())");
        });

        modelBuilder.Entity<DeckType>(entity =>
        {
            entity.ToTable("DeckType", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<DeliveryState>(entity =>
        {
            entity.ToTable("DeliveryState", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<DepalletizerOperationalMode>(entity =>
        {
            entity.ToTable("DepalletizerOperationalMode", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<DepalletizingRejectionReason>(entity =>
        {
            entity.ToTable("DepalletizingRejectionReason", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<DepalletizingSubState>(entity =>
        {
            entity.ToTable("DepalletizingSubState", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<DeploymentAction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_StepAction");

            entity.ToTable("DeploymentActions", "Staging");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DeploymentCategory>(entity =>
        {
            entity.ToTable("DeploymentCategory", "Staging");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DeploymentStep>(entity =>
        {
            entity.ToTable("DeploymentSteps", "Staging");

            entity.HasIndex(e => e.Name, "IX_DeploymentSteps_Name").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Destination>(entity =>
        {
            entity.ToTable("Destinations", "Outbound");

            entity.HasIndex(e => e.DestinationId, "UC_Destinations_DestinationId").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.ConveyorRef)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CustomerRef)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Cell).WithMany(p => p.Destinations)
                .HasForeignKey(d => d.CellId)
                .HasConstraintName("FK_Destination_Cells");

            entity.HasMany(d => d.Endpoints).WithMany(p => p.Destinations)
                .UsingEntity<Dictionary<string, object>>(
                    "DestinationsEndpoint",
                    r => r.HasOne<Endpoint1>().WithMany()
                        .HasForeignKey("EndpointId")
                        .HasConstraintName("FK_DestinationsEndpoints_Endpoint"),
                    l => l.HasOne<Destination>().WithMany()
                        .HasForeignKey("DestinationId")
                        .HasConstraintName("FK_DestinationsEndpoints_Destination"),
                    j =>
                    {
                        j.HasKey("DestinationId", "EndpointId");
                        j.ToTable("DestinationsEndpoints", "Outbound");
                        j.HasIndex(new[] { "DestinationId", "EndpointId" }, "IDX_DestinationsEndpoints_Columns");
                        j.HasIndex(new[] { "EndpointId" }, "IDX_FK_DestinationsEndpoints_Endpoint");
                    });

            entity.HasMany(d => d.MeteringGroups).WithMany(p => p.Destinations)
                .UsingEntity<Dictionary<string, object>>(
                    "DestinationsMeteringGroup",
                    r => r.HasOne<MeteringGroup>().WithMany()
                        .HasForeignKey("MeteringGroupId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_DestinationsMeteringGroups_MeteringGroup"),
                    l => l.HasOne<Destination>().WithMany()
                        .HasForeignKey("DestinationId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_DestinationsMeteringGroups_Destination"),
                    j =>
                    {
                        j.HasKey("DestinationId", "MeteringGroupId");
                        j.ToTable("DestinationsMeteringGroups", "Outbound");
                        j.HasIndex(new[] { "DestinationId", "MeteringGroupId" }, "IDX_DestinationsMeteringGroups_Columns");
                        j.HasIndex(new[] { "MeteringGroupId" }, "IDX_FK_DestinationsMeteringGroups_MeteringGroup");
                    });
        });

        modelBuilder.Entity<Destination1>(entity =>
        {
            entity.ToTable("Destinations", "Staging");

            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DestinationAvailabilityStatus>(entity =>
        {
            entity.ToTable("DestinationAvailabilityStatus", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<DestinationCategory>(entity =>
        {
            entity.ToTable("DestinationCategories", "Outbound");

            entity.HasIndex(e => e.Name, "UC_DestinationCategories_Name").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CustomerRef)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DestinationCategory1>(entity =>
        {
            entity.ToTable("DestinationCategories", "Staging");

            entity.Property(e => e.CustomerRef)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DestinationDestinationCategory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DestinationDestinationCategories", "Staging");

            entity.Property(e => e.DestinationCatName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DestinationName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DestinationEndpoint>(entity =>
        {
            entity.ToTable("DestinationEndpoints", "Staging");

            entity.Property(e => e.EndpointId)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DestinationState>(entity =>
        {
            entity.ToTable("DestinationStates", "Outbound", tb => tb.HasTrigger("trg_iu_DestinationStates"));

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.AvailabilityStatus).HasDefaultValue(1);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.LastChangeReason)
                .HasMaxLength(1024)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.HasOne(d => d.AvailabilityStatusNavigation).WithMany(p => p.DestinationStates)
                .HasForeignKey(d => d.AvailabilityStatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DestinationStates_DestinationAvailabilityStatus");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.DestinationState)
                .HasForeignKey<DestinationState>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DestinationStates_Destination");
        });

        modelBuilder.Entity<DestinationStatesTombstone>(entity =>
        {
            entity.HasKey(e => e.DestStatesTombstoneSk);

            entity.ToTable("DestinationStatesTombstone", "Outbound");

            entity.Property(e => e.DestStatesTombstoneSk).HasColumnName("DestStatesTombstoneSK");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.LastChangeReason)
                .HasMaxLength(1024)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.TombstoneDate).HasDefaultValueSql("(getutcdate())");
        });

        modelBuilder.Entity<DestinationsBackup>(entity =>
        {
            entity.HasKey(e => e.DestinationBackupSk).HasName("PK_DestinationBackupSK");

            entity.ToTable("DestinationsBackup", "Support");

            entity.Property(e => e.DestinationBackupSk).HasColumnName("DestinationBackupSK");
            entity.Property(e => e.ConveyorRef)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CustomerRef)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DestinationsDestinationCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DestinationsDestinationCategories_1");

            entity.ToTable("DestinationsDestinationCategories", "Outbound");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("DefaultUser");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(sysutcdatetime())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("DefaultUser");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(sysutcdatetime())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.DestinationCategory).WithMany(p => p.DestinationsDestinationCategories)
                .HasForeignKey(d => d.DestinationCategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DestinationsDestinationCategories_DestinationCategory");

            entity.HasOne(d => d.Destination).WithMany(p => p.DestinationsDestinationCategories)
                .HasForeignKey(d => d.DestinationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DestinationsDestinationCategories_Destination");
        });

        modelBuilder.Entity<Driveway>(entity =>
        {
            entity.ToTable("Driveways", "Staging");

            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.Number).HasMaxLength(200);
        });

        modelBuilder.Entity<Driveway1>(entity =>
        {
            entity.ToTable("Driveways", "Structure");

            entity.HasIndex(e => e.ResourceName, "UC_DrivewayResourceName")
                .IsUnique()
                .HasFilter("([ResourceName] IS NOT NULL)");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Number).HasMaxLength(200);
            entity.Property(e => e.ResourceName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Level).WithMany(p => p.Driveway1s)
                .HasForeignKey(d => d.LevelId)
                .HasConstraintName("FK_Driveway_Level");

            entity.HasOne(d => d.Module).WithMany(p => p.Driveway1s)
                .HasForeignKey(d => d.ModuleId)
                .HasConstraintName("FK_Driveway_Module");
        });

        modelBuilder.Entity<DrivewayState>(entity =>
        {
            entity.ToTable("DrivewayStates", "Structure", tb => tb.HasTrigger("trg_DrivewayStates_Update"));

            entity.HasIndex(e => e.StateReasonId, "IDX_FK_DrivewayStates_StrucStateReason");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.IsCommissioned).HasDefaultValue(true);
            entity.Property(e => e.IsOnline).HasDefaultValue(true);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.StateChangeDateTime).HasDefaultValueSql("(sysdatetimeoffset())");
            entity.Property(e => e.StateNote)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.Driveway).WithMany(p => p.DrivewayStates)
                .HasForeignKey(d => d.DrivewayId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DrivewayStates_Driveway");

            entity.HasOne(d => d.StateNavigation).WithMany(p => p.DrivewayStates)
                .HasForeignKey(d => d.State)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DrivewayStates_TDrivewayState");

            entity.HasOne(d => d.StateReason).WithMany(p => p.DrivewayStates)
                .HasForeignKey(d => d.StateReasonId)
                .HasConstraintName("FK_DrivewayStates_StrucStateReason");
        });

        modelBuilder.Entity<DrivewayStatesTombstone>(entity =>
        {
            entity.HasKey(e => e.DrivewayStatesTombstoneSk).HasName("PK_DrivewayStatesTombstoneSK");

            entity.ToTable("DrivewayStatesTombstone", "Structure");

            entity.Property(e => e.DrivewayStatesTombstoneSk).HasColumnName("DrivewayStatesTombstoneSK");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.StateNote)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DuplicateAllocationMessage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ErrorLogs");

            entity.ToTable("DuplicateAllocationMessages", "Inventory");

            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(sysutcdatetime())");
        });

        modelBuilder.Entity<EdgeAlignment>(entity =>
        {
            entity.ToTable("EdgeAlignment", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<EmailParameter>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EmailParameters", "Purge");

            entity.Property(e => e.Ccrecipients)
                .IsUnicode(false)
                .HasColumnName("CCRecipients");
            entity.Property(e => e.CreatedDate)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.EmailSubject)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.ProfileName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Recipients).IsUnicode(false);
        });

        modelBuilder.Entity<Endpoint>(entity =>
        {
            entity.ToTable("Endpoints", "Staging");

            entity.Property(e => e.CustomerEndpointRef)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DisplayName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.EndpointId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RequiresWmsnotification).HasColumnName("RequiresWMSNotification");
            entity.Property(e => e.SubsystemId)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Endpoint1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Endpoint");

            entity.ToTable("Endpoints", "Structure");

            entity.HasIndex(e => e.EndpointId, "UC_Endpoint_EndpointId").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.DisplayName).IsUnicode(false);
            entity.Property(e => e.EndpointId).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.RequiresWmsnotification).HasColumnName("RequiresWMSNotification");

            entity.HasOne(d => d.Subsystem).WithMany(p => p.Endpoint1s)
                .HasForeignKey(d => d.SubsystemId)
                .HasConstraintName("FK_Endpoint_SubsystemId");
        });

        modelBuilder.Entity<EndpointBackup>(entity =>
        {
            entity.HasKey(e => e.EndpointBackupSk).HasName("PK_EndpointBackupSK");

            entity.ToTable("EndpointBackup", "Support");

            entity.Property(e => e.EndpointBackupSk).HasColumnName("EndpointBackupSK");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.DisplayName).IsUnicode(false);
            entity.Property(e => e.EndpointId).HasMaxLength(50);
            entity.Property(e => e.RequiresWmsnotification).HasColumnName("RequiresWMSNotification");
        });

        modelBuilder.Entity<EndpointConnection>(entity =>
        {
            entity.ToTable("EndpointConnections", "Staging");

            entity.Property(e => e.FromEndpointId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ToEndpointId)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EndpointConnection1>(entity =>
        {
            entity.ToTable("EndpointConnections", "Structure");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EnumerationProperty>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_EnumerationProperty");

            entity.ToTable("EnumerationProperties", "Metadata");

            entity.HasIndex(e => e.EnumerationReferenceId, "IDX_FK_EnumerationProperty_EnumerationReference");

            entity.HasIndex(e => new { e.FullNamespace, e.ParentClass, e.Name }, "UC_EnumerationProperty_FullNamespace_ParentClass_Name").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ColumnName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.FullNamespace)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ParentClass)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TableName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.EnumerationReference).WithMany(p => p.EnumerationProperties)
                .HasForeignKey(d => d.EnumerationReferenceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EnumerationProperty_EnumerationReference");
        });

        modelBuilder.Entity<EnumerationReference>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_EnumerationReference");

            entity.ToTable("EnumerationReferences", "Metadata");

            entity.HasIndex(e => new { e.FullNamespace, e.Name }, "UC_EnumerationReference_FullNamespace_Name").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.FullNamespace)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EnumerationReferenceValue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_EnumerationReferenceValue");

            entity.ToTable("EnumerationReferenceValues", "Metadata");

            entity.HasIndex(e => new { e.EnumerationReferenceId, e.IntValue }, "UC_EnumerationReferenceValue_IntValue").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CustomerReference)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.FriendlyName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SortOrder).HasDefaultValue(0);

            entity.HasOne(d => d.EnumerationReference).WithMany(p => p.EnumerationReferenceValues)
                .HasForeignKey(d => d.EnumerationReferenceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EnumerationReferenceValue_EnumerationReference");
        });

        modelBuilder.Entity<ErrorLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ErrorLogging");

            entity.ToTable("ErrorLogs", "Inventory");

            entity.Property(e => e.Id).HasComment("Primary Key that is Identity column.");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(sysutcdatetime())")
                .HasComment("Time in UTC that this record is logged");
            entity.Property(e => e.ErrorMessage)
                .IsUnicode(false)
                .HasComment("Error Message");
            entity.Property(e => e.ErrorSource)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("Level at which the error is logged");
            entity.Property(e => e.MessageId).HasComment("Unique Identifier of the message.");
        });

        modelBuilder.Entity<ExceptionProcessingRequiredDetail>(entity =>
        {
            entity.ToTable("ExceptionProcessingRequiredDetails", "Inventory", tb =>
                {
                    tb.HasTrigger("trg_Delete_ExceptionProcessingRequiredDetails");
                    tb.HasTrigger("trg_Insert_ExceptionProcessingRequiredDetails");
                });

            entity.HasIndex(e => e.CartonId, "IDX_Inventory_ExceptionProcessingRequiredDetails_CartonId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ExtraInformation).IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Reason)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.SubReason)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.HasOne(d => d.Carton).WithMany(p => p.ExceptionProcessingRequiredDetails)
                .HasForeignKey(d => d.CartonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ExceptionProcessingRequiredDetails_CartonId");
        });

        modelBuilder.Entity<ExecutionDetailsLog>(entity =>
        {
            entity.ToTable("ExecutionDetailsLog", "Purge");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ErrorMessage).IsUnicode(false);
            entity.Property(e => e.ExecutionId).HasColumnName("ExecutionID");
            entity.Property(e => e.ObjectName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.TableName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.TotalTimeInMs)
                .HasComputedColumnSql("(datediff(millisecond,[StartTime],[EndTime]))", false)
                .HasColumnName("TotalTimeInMS");

            entity.HasOne(d => d.Execution).WithMany(p => p.ExecutionDetailsLogs)
                .HasForeignKey(d => d.ExecutionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ExecutionDetailsLog_ExecutionID");
        });

        modelBuilder.Entity<ExecutionLog>(entity =>
        {
            entity.HasKey(e => e.ExecutionId).HasName("PK_ExecutionLog_ExecutionID");

            entity.ToTable("ExecutionLog", "Purge");

            entity.Property(e => e.ExecutionId).HasColumnName("ExecutionID");
            entity.Property(e => e.ErrorMessage).IsUnicode(false);
        });

        modelBuilder.Entity<ExecutionStatus>(entity =>
        {
            entity.ToTable("ExecutionStatus", "Support");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ExpirationSelectionMode>(entity =>
        {
            entity.ToTable("ExpirationSelectionMode", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<ExtensionKeyDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ExtensionKeyData", "Staging");

            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Forecast>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Forecast");

            entity.ToTable("Forecasts", "Sku");

            entity.HasIndex(e => e.SkuId, "IDX_FK_Forecast_Sku");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.HasOne(d => d.Sku).WithMany(p => p.Forecasts)
                .HasForeignKey(d => d.SkuId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Forecast_Sku");
        });

        modelBuilder.Entity<ForecastTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ForecastTemp", "Sku");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FulfilledBy>(entity =>
        {
            entity.ToTable("FulfilledBy", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<GenericAlertLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_GenericAlertLog");

            entity.ToTable("GenericAlertLogs", "Alert");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Description)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(50);

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.GenericAlertLog)
                .HasForeignKey<GenericAlertLog>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GenericAlertLog_AlertLog");
        });

        modelBuilder.Entity<HealthMonitor>(entity =>
        {
            entity.ToTable("HealthMonitor", "Admin");

            entity.Property(e => e.CounterName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HoldState>(entity =>
        {
            entity.ToTable("HoldState", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<Inbound>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Inbound");

            entity.ToTable("Inbounds", "Inbound");

            entity.HasIndex(e => e.CustomerCartonGroupRef, "IDX_InboundPallet_CustomerCartonGroupRef");

            entity.HasIndex(e => e.CustomerInboundRef, "UC_Inbound_CustomerInboundRef").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CustomerCartonGroupRef)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CustomerInboundRef)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InboundBatch>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_InboundBatch");

            entity.ToTable("InboundBatches", "Inbound");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.InboundBatch)
                .HasForeignKey<InboundBatch>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InboundBatch_Inbound");
        });

        modelBuilder.Entity<InboundCarton>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_InboundCarton");

            entity.ToTable("InboundCartons", "Inbound");

            entity.HasIndex(e => e.InboundId, "IDX_FK_InboundCarton_Inbound");

            entity.HasIndex(e => e.InboundConveyorId, "IDX_FK_InboundCarton_InboundConveyorId");

            entity.HasIndex(e => e.InboundLpnid, "IDX_FK_InboundLPNId_InboundLPN");

            entity.HasIndex(e => e.InboundLpnid, "IDX_InboundCartons_InboundLPNIdWithIncludes");

            entity.HasIndex(e => new { e.OnCartonLiftTime, e.OnShelfTime }, "IDX_InboundCartons_for_SSRS");

            entity.HasIndex(e => e.ConveyorCaseId, "IX_InboundCartons_ConveyorCaseId");

            entity.HasIndex(e => e.RejectTime, "IX_InboundCartons_RejectTime");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ConveyorCaseId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CustomerCartonGroupRef)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InboundLpnid).HasColumnName("InboundLPNId");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.InboundCarton)
                .HasForeignKey<InboundCarton>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InboundCarton_Carton");

            entity.HasOne(d => d.InboundConveyor).WithMany(p => p.InboundCartonInboundConveyors)
                .HasForeignKey(d => d.InboundConveyorId)
                .HasConstraintName("FK_InboundCarton_InboundConveyorId");

            entity.HasOne(d => d.InboundDestinationNavigation).WithMany(p => p.InboundCartons)
                .HasForeignKey(d => d.InboundDestination)
                .HasConstraintName("FK_InboundCartons_InboundDestination");

            entity.HasOne(d => d.Inbound).WithMany(p => p.InboundCartons)
                .HasForeignKey(d => d.InboundId)
                .HasConstraintName("FK_InboundCarton_Inbound");

            entity.HasOne(d => d.InboundLpn).WithMany(p => p.InboundCartons)
                .HasForeignKey(d => d.InboundLpnid)
                .HasConstraintName("FK_InboundLPNId_InboundLPN");

            entity.HasOne(d => d.RejectConveyor).WithMany(p => p.InboundCartonRejectConveyors)
                .HasForeignKey(d => d.RejectConveyorId)
                .HasConstraintName("FK_InboundCarton_RejectConveyorId");

            entity.HasMany(d => d.InboundCartonRejectReasons).WithMany(p => p.InboundCartons)
                .UsingEntity<Dictionary<string, object>>(
                    "InboundCartonInboundCartonRejectReason",
                    r => r.HasOne<InboundCartonRejectReason>().WithMany()
                        .HasForeignKey("InboundCartonRejectReasonId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__InboundCartonInboundCartonRejectReasons_InboundCartonRejectReasons"),
                    l => l.HasOne<InboundCarton>().WithMany()
                        .HasForeignKey("InboundCartonId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_InboundCartonInboundCartonRejectReasons_InboundCartons"),
                    j =>
                    {
                        j.HasKey("InboundCartonId", "InboundCartonRejectReasonId");
                        j.ToTable("InboundCartonInboundCartonRejectReasons", "Inbound");
                    });
        });

        modelBuilder.Entity<InboundCartonLabel>(entity =>
        {
            entity.ToTable("InboundCartonLabel", "Inbound");

            entity.HasIndex(e => e.CartonId, "IDX_FK_Cartons_InboundCartonLabel");

            entity.HasIndex(e => e.Id, "IDX_FK_LabelBase_InboundCartonLabel");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Carton).WithMany(p => p.InboundCartonLabels)
                .HasForeignKey(d => d.CartonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cartons_InboundCartonLabel");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.InboundCartonLabel)
                .HasForeignKey<InboundCartonLabel>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LabelBase_InboundCartonLabel");
        });

        modelBuilder.Entity<InboundCartonRejectReason>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__InboundC__3214EC073F78FAF4");

            entity.ToTable("InboundCartonRejectReasons", "Inbound");

            entity.HasIndex(e => e.Name, "UQX_RefTab_CartonRejectReasonName").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InboundConveyorLoad>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.ToTable("InboundConveyorLoads", "Inventory", tb => tb.HasTrigger("trg_InboundConveyorLoads_Update"));

            entity.HasIndex(e => e.ConveyorLaneId, "IDX_FK_InboundConveyorLoads_ConveyorLanes");

            entity.HasIndex(e => e.CustomerCartonGroupRef, "IDX_Inventory_InboundConveyorLoads_CustomerCartonGroupRef");

            entity.HasIndex(e => e.RecordNumber, "IX_InboundConveyorLoads")
                .IsUnique()
                .IsClustered();

            entity.HasIndex(e => e.CaseGroupNumber, "IX_InboundConveyorLoads_CaseGroupNumber");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CustomerCartonGroupRef)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.RecordNumber).ValueGeneratedOnAdd();

            entity.HasOne(d => d.ConveyorLane).WithMany(p => p.InboundConveyorLoads)
                .HasForeignKey(d => d.ConveyorLaneId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InboundConveyorLoads_ConveyorLanes");
        });

        modelBuilder.Entity<InboundConveyorLoadCarton>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.ToTable("InboundConveyorLoadCartons", "Inventory");

            entity.HasIndex(e => e.CartonId, "IDX_FK_InboundConveyorLoadCartons_Cartons");

            entity.HasIndex(e => e.InboundConveyorLoadId, "IDX_FK_InboundConveyorLoadCartons_InboundConveyorLoads");

            entity.HasIndex(e => e.RecordNumber, "IX_InboundConveyorLoadCartons")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.RecordNumber).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Carton).WithMany(p => p.InboundConveyorLoadCartons)
                .HasForeignKey(d => d.CartonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InboundConveyorLoadCartons_Cartons");

            entity.HasOne(d => d.InboundConveyorLoad).WithMany(p => p.InboundConveyorLoadCartons)
                .HasForeignKey(d => d.InboundConveyorLoadId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InboundConveyorLoadCartons_InboundConveyorLoads");
        });

        modelBuilder.Entity<InboundConveyorLoadCartonsTombstone>(entity =>
        {
            entity.HasKey(e => e.InbConvLoadsCtnsTombstoneSk);

            entity.ToTable("InboundConveyorLoadCartonsTombstone", "Inventory");

            entity.HasIndex(e => new { e.CartonId, e.InboundConveyorLoadId }, "IDX_Inventory_InboundConveyorLoadCartonsTombstone_CartonID_InbConvrLoadID");

            entity.Property(e => e.InbConvLoadsCtnsTombstoneSk).HasColumnName("InbConvLoadsCtnsTombstoneSK");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.TombstoneDate).HasDefaultValueSql("(getutcdate())");
        });

        modelBuilder.Entity<InboundConveyorLoadsTombstone>(entity =>
        {
            entity.HasKey(e => e.InbConvLoadsTombstoneSk);

            entity.ToTable("InboundConveyorLoadsTombstone", "Inventory");

            entity.HasIndex(e => e.Id, "IDX_Inventory_InboundConveyorLoadsTombstone_ID");

            entity.Property(e => e.InbConvLoadsTombstoneSk).HasColumnName("InbConvLoadsTombstoneSK");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CustomerCartonGroupRef)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.TombstoneDate).HasDefaultValueSql("(getutcdate())");
        });

        modelBuilder.Entity<InboundDestination>(entity =>
        {
            entity.ToTable("InboundDestination", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<InboundDimensionalVariant>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_InboundDimensionalVariant_ID");

            entity.ToTable("InboundDimensionalVariants", "Sku", tb => tb.HasTrigger("trg_InboundDimVar_Update"));

            entity.HasIndex(e => e.ParentInboundDimensionalVariantId, "IDX_IDV__ParentInboundDimensionalVariantId");

            entity.HasIndex(e => e.Id, "IX_InboundDimensionalVariant_Id").IsUnique();

            entity.HasIndex(e => e.SkuId, "IX_InboundDimensionalVariants_SkuId");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(sysdatetimeoffset())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsStorageEligible).HasDefaultValue(true);
            entity.Property(e => e.MeasurementStation)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(sysdatetimeoffset())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordNumber).ValueGeneratedOnAdd();
            entity.Property(e => e.TipOverridden).HasDefaultValue(false);
            entity.Property(e => e.TipOverrideUserName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.InboundRobotProperty).WithMany(p => p.InboundDimensionalVariants)
                .HasForeignKey(d => d.InboundRobotPropertyId)
                .HasConstraintName("FK_InboundDimensionalVariants_InboundRobotProperties");

            entity.HasOne(d => d.MeasuredByNavigation).WithMany(p => p.InboundDimensionalVariants)
                .HasForeignKey(d => d.MeasuredBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InboundDimensionalVariants_MeasuredBy");

            entity.HasOne(d => d.ParentInboundDimensionalVariant).WithMany(p => p.InverseParentInboundDimensionalVariant)
                .HasForeignKey(d => d.ParentInboundDimensionalVariantId)
                .HasConstraintName("FK_InboundDimensionalVariants_InboundDimensionalVariants");

            entity.HasOne(d => d.Sku).WithMany(p => p.InboundDimensionalVariants)
                .HasForeignKey(d => d.SkuId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InboundDimensionalVariant_Skus");

            entity.HasOne(d => d.StoredOrientationNavigation).WithMany(p => p.InboundDimensionalVariants)
                .HasForeignKey(d => d.StoredOrientation)
                .HasConstraintName("FK_InboundDimensionalVariants_StoredOrientation");

            entity.HasOne(d => d.TipOverrideReassonCodeNavigation).WithMany(p => p.InboundDimensionalVariants)
                .HasForeignKey(d => d.TipOverrideReassonCode)
                .HasConstraintName("FK_InboundDimensionalVariants_TipOverrideReasonCode");
        });

        modelBuilder.Entity<InboundDimensionalVariantsHistory>(entity =>
        {
            entity.HasKey(e => e.InboundDimensionalVariantsHistorySk);

            entity.ToTable("InboundDimensionalVariantsHistory", "Sku");

            entity.HasIndex(e => e.SkuId, "IX_InboundDimensionalVariants_SkuId");

            entity.Property(e => e.InboundDimensionalVariantsHistorySk).HasColumnName("InboundDimensionalVariantsHistorySK");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.HistoryDate).HasDefaultValueSql("(sysdatetimeoffset())");
            entity.Property(e => e.MeasurementStation)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<InboundDimensionalVariantsImportResult>(entity =>
        {
            entity.HasKey(e => e.RecordNumber);

            entity.ToTable("InboundDimensionalVariantsImportResults", "Sku");

            entity.Property(e => e.Action).HasMaxLength(50);
            entity.Property(e => e.IsStorageEligible).HasDefaultValue(true);
        });

        modelBuilder.Entity<InboundDimensionalVariantsTemp>(entity =>
        {
            entity.ToTable("InboundDimensionalVariantsTemp");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<InboundDimensionalVariantsTemp1>(entity =>
        {
            entity.ToTable("InboundDimensionalVariantsTemp", "Sku");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.IsStorageEligible).HasDefaultValue(true);
            entity.Property(e => e.MeasurementStation)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InboundDimensionalVariantsWork>(entity =>
        {
            entity.HasKey(e => e.InboundDimensionalVariantsSk);

            entity.ToTable("InboundDimensionalVariantsWork", "Staging");

            entity.Property(e => e.InboundDimensionalVariantsSk).HasColumnName("InboundDimensionalVariantsSK");
            entity.Property(e => e.MatchingIdvid).HasColumnName("MatchingIDVId");
            entity.Property(e => e.MatchingOdvid).HasColumnName("MatchingODVId");
        });

        modelBuilder.Entity<InboundForecast>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_InboundForecast");

            entity.ToTable("InboundForecasts", "Inbound");

            entity.HasIndex(e => e.InboundId, "IDX_FK_InboundForecast_Inbound");

            entity.HasIndex(e => e.ScheduledShiftId, "IDX_FK_InboundForecast_ScheduledShift");

            entity.HasIndex(e => e.SkuId, "IDX_FK_InboundForecast_Sku");

            entity.HasIndex(e => new { e.ShiftStartDate, e.ScheduledShiftId, e.ForecastReceiveDateTime }, "IDX_Inbound_InboundForecasts_AllocationResponse").IsDescending(false, false, true);

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.AppointmentType)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ProcessType)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Shift)
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.HasOne(d => d.Inbound).WithMany(p => p.InboundForecasts)
                .HasForeignKey(d => d.InboundId)
                .HasConstraintName("FK_InboundForecast_Inbound");

            entity.HasOne(d => d.ProductTypesNavigation).WithMany(p => p.InboundForecasts)
                .HasForeignKey(d => d.ProductTypes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InboundForecast_ProductTypes");

            entity.HasOne(d => d.ScheduledShift).WithMany(p => p.InboundForecasts)
                .HasForeignKey(d => d.ScheduledShiftId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InboundForecast_ScheduledShift");

            entity.HasOne(d => d.Sku).WithMany(p => p.InboundForecasts)
                .HasForeignKey(d => d.SkuId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InboundForecast_Sku");
        });

        modelBuilder.Entity<InboundLpn>(entity =>
        {
            entity.ToTable("InboundLPNs", "Inbound");

            entity.HasIndex(e => e.Lpnid, "IDX_FK_InboundLPNs_LPN");

            entity.HasIndex(e => e.PalletLayerId, "IDX_FK_InboundLPNs_PalletLayers");

            entity.HasIndex(e => e.PalletLayerId, "IDX_InboundLPNs_PalletLayerIdWithIncludes");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CartonsExpected).HasDefaultValue(0);
            entity.Property(e => e.CartonsInducted).HasDefaultValue(0);
            entity.Property(e => e.CartonsRejectedDamaged).HasDefaultValue(0);
            entity.Property(e => e.CartonsRejectedOutOfTolerance).HasDefaultValue(0);
            entity.Property(e => e.CartonsScratched).HasDefaultValue(0);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.InductionType)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.Lpnid).HasColumnName("LPNId");
            entity.Property(e => e.LpnrejectReasonId).HasColumnName("LPNRejectReasonId");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.PurchaseOrderNumber)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.RecordNumber).ValueGeneratedOnAdd();

            entity.HasOne(d => d.AutoReceivingStatusNavigation).WithMany(p => p.InboundLpns)
                .HasForeignKey(d => d.AutoReceivingStatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InboundLPNs_AutoReceivingStatus");

            entity.HasOne(d => d.Lpn).WithMany(p => p.InboundLpns)
                .HasForeignKey(d => d.Lpnid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InboundLPNs_LPN");

            entity.HasOne(d => d.LpnrejectReason).WithMany(p => p.InboundLpns)
                .HasForeignKey(d => d.LpnrejectReasonId)
                .HasConstraintName("FK_InboundLPNs_RejectReason");

            entity.HasOne(d => d.PalletLayer).WithMany(p => p.InboundLpns)
                .HasForeignKey(d => d.PalletLayerId)
                .HasConstraintName("FK_InboundLPNs_PalletLayers");
        });

        modelBuilder.Entity<InboundPallet>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_InboundPallet")
                .IsClustered(false);

            entity.ToTable("InboundPallets", "Inbound");

            entity.HasIndex(e => e.InboundPalletSourceId, "IDX_FK_InboundPallet_InboundPalletSource");

            entity.HasIndex(e => e.PalletBaseTypeId, "IDX_FK_InboundPallet_PalletBaseType");

            entity.HasIndex(e => e.PalletState, "IDX_InboundPallet_PalletState");

            entity.HasIndex(e => e.PalletType, "IDX_InboundPallet_PalletType");

            entity.HasIndex(e => new { e.ParentLpn, e.PalletState, e.PalletType }, "IDX_InboundPallets_ParentLPN");

            entity.HasIndex(e => e.RecordNumber, "IX_InboundPallets_ClusteredIndex").IsClustered();

            entity.HasIndex(e => e.InboundPalletNumber, "UC_InboundPallet_InboundPalletNumber").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.DepalletizerId).HasColumnName("DepalletizerID");
            entity.Property(e => e.InductionType)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.PalletBaseTypeId).HasDefaultValue(-1);
            entity.Property(e => e.ParentLpn)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("ParentLPN");
            entity.Property(e => e.PickupLocation)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.RecordNumber).ValueGeneratedOnAdd();

            entity.HasOne(d => d.AlternatePrintingStateNavigation).WithMany(p => p.InboundPallets)
                .HasForeignKey(d => d.AlternatePrintingState)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InboundPallets_InboundPalletAlternatePrintingState");

            entity.HasOne(d => d.DeliveryStateNavigation).WithMany(p => p.InboundPallets)
                .HasForeignKey(d => d.DeliveryState)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InboundPallets_PalletDeliveryState");

            entity.HasOne(d => d.DepalletizerOperationalModeNavigation).WithMany(p => p.InboundPallets)
                .HasForeignKey(d => d.DepalletizerOperationalMode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InboundPallets_DepalletizerOperationalMode");

            entity.HasOne(d => d.DepalletizingRejectionReasonNavigation).WithMany(p => p.InboundPallets)
                .HasForeignKey(d => d.DepalletizingRejectionReason)
                .HasConstraintName("FK_InboundPallets_DepalletizingRejectionReason");

            entity.HasOne(d => d.DepalletizingSubStateNavigation).WithMany(p => p.InboundPallets)
                .HasForeignKey(d => d.DepalletizingSubState)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InboundPallets_DepalletizingSubState");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.InboundPallet)
                .HasForeignKey<InboundPallet>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InboundPallet_Inbound");

            entity.HasOne(d => d.InboundPalletSource).WithMany(p => p.InboundPallets)
                .HasForeignKey(d => d.InboundPalletSourceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InboundPallets_InboundPalletSource");

            entity.HasOne(d => d.LabelingSubStateNavigation).WithMany(p => p.InboundPallets)
                .HasForeignKey(d => d.LabelingSubState)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InboundPallets_InboundPalletLabelingSubState");

            entity.HasOne(d => d.PalletBaseType).WithMany(p => p.InboundPallets)
                .HasForeignKey(d => d.PalletBaseTypeId)
                .HasConstraintName("FK_InboundPallets_PalletBaseType");

            entity.HasOne(d => d.PalletStateNavigation).WithMany(p => p.InboundPallets)
                .HasForeignKey(d => d.PalletState)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InboundPallets_InboundPalletState");

            entity.HasOne(d => d.PalletTypeNavigation).WithMany(p => p.InboundPallets)
                .HasForeignKey(d => d.PalletType)
                .HasConstraintName("FK_InboundPallets_MultiPalletType");

            entity.HasOne(d => d.PartialPalletStateNavigation).WithMany(p => p.InboundPallets)
                .HasForeignKey(d => d.PartialPalletState)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InboundPallets_PartialPalletState");

            entity.HasOne(d => d.StoredStateNavigation).WithMany(p => p.InboundPallets)
                .HasForeignKey(d => d.StoredState)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InboundPallets_InboundPalletStoredState");
        });

        modelBuilder.Entity<InboundPalletAlternatePrintingState>(entity =>
        {
            entity.ToTable("InboundPalletAlternatePrintingState", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<InboundPalletLabelingSubState>(entity =>
        {
            entity.ToTable("InboundPalletLabelingSubState", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<InboundPalletSource>(entity =>
        {
            entity.ToTable("InboundPalletSource", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<InboundPalletState>(entity =>
        {
            entity.ToTable("InboundPalletState", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<InboundPalletStoredState>(entity =>
        {
            entity.ToTable("InboundPalletStoredState", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<InboundPalletsBackup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("InboundPalletsBackup", "Support");

            entity.HasIndex(e => e.UpdatedOn, "IX_InboundPalletsBackup_UpdatedOn");

            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InboundRobotPropertiesHistory>(entity =>
        {
            entity.HasKey(e => e.InboundRobotPropHistorySk).HasName("PK_InboundRobotPropHistory");

            entity.ToTable("InboundRobotPropertiesHistory", "Sku");

            entity.Property(e => e.InboundRobotPropHistorySk).HasColumnName("InboundRobotPropHistorySK");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.HistoryDate).HasDefaultValueSql("(sysdatetimeoffset())");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ProfileName)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InboundRobotPropertiesTemp>(entity =>
        {
            entity.ToTable("InboundRobotPropertiesTemp");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ProfileName)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InboundRobotPropertiesTemp1>(entity =>
        {
            entity.ToTable("InboundRobotPropertiesTemp", "Sku");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ProfileName)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InboundRobotProperty>(entity =>
        {
            entity.ToTable("InboundRobotProperties", "Sku", tb => tb.HasTrigger("trg_InboundRobotProp_Update"));

            entity.HasIndex(e => e.VisionPickMode, "IDX_FK_InboundRobotProperties_VisionPickMode");

            entity.HasIndex(e => e.Id, "IX_InboundRobotProperties_Id").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ProfileName)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValue("Default");
            entity.Property(e => e.RecordNumber).ValueGeneratedOnAdd();
            entity.Property(e => e.RobotConfigurationProfileId).HasDefaultValue(-1);

            entity.HasOne(d => d.RobotConfigurationProfile).WithMany(p => p.InboundRobotProperties)
                .HasForeignKey(d => d.RobotConfigurationProfileId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InboundRobotProperties_InboundRobotConfigurationProfile");

            entity.HasOne(d => d.VisionPickModeNavigation).WithMany(p => p.InboundRobotProperties)
                .HasForeignKey(d => d.VisionPickMode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InboundRobotProperties_VisionPickMode");
        });

        modelBuilder.Entity<IneligibilityReason>(entity =>
        {
            entity.ToTable("IneligibilityReason", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<Inventory>(entity =>
        {
            entity.ToTable("Inventory", "Inventory", tb => tb.HasTrigger("trg_Inventory_Update"));

            entity.HasIndex(e => new { e.CartonId, e.ShelfId, e.ShelfLocationOffsetY, e.ShelfLocationOffsetX, e.IsSuspect }, "IDX_Inventory_Inventory_CartonShelfLocation");

            entity.HasIndex(e => e.CaseGroupNumber, "IDX_Inventory_Inventory_CaseGroupNumber");

            entity.HasIndex(e => e.CustomerCartonGroupRef, "IDX_Inventory_Inventory_CustomerCartonGroupRef");

            entity.HasIndex(e => new { e.ItemType, e.SuspectType, e.CartonId }, "IDX_Inventory_Inventory_ItemType");

            entity.HasIndex(e => new { e.Id, e.CartonId, e.ShelfId, e.ShelfLocationOffsetY, e.ShelfLocationOffsetX, e.ShelfLocationWidth }, "IDX_Inventory_Inventory_ShelfLocation");

            entity.HasIndex(e => e.IsSuspect, "IDX_Inventory_IsSuspect");

            entity.HasIndex(e => e.ShelfId, "IDX_Inventory_ShelfId");

            entity.HasIndex(e => new { e.SuspectTime, e.SuspectClearTime, e.CartonId }, "IDX_Inventory_SuspectTimes_CartonId");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CustomerCartonGroupRef)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IsSuspect).HasComputedColumnSql("(CONVERT([bit],case when [SuspectTime] IS NOT NULL AND [SuspectClearTime] IS NULL OR [SuspectTime]>[SuspectClearTime] then (1) else (0) end))", true);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ShelfLocationCartonOffsetX).HasColumnName("ShelfLocation_CartonOffsetX");
            entity.Property(e => e.ShelfLocationCartonOffsetY).HasColumnName("ShelfLocation_CartonOffsetY");
            entity.Property(e => e.ShelfLocationOffsetX).HasColumnName("ShelfLocation_OffsetX");
            entity.Property(e => e.ShelfLocationOffsetY).HasColumnName("ShelfLocation_OffsetY");
            entity.Property(e => e.ShelfLocationWidth).HasColumnName("ShelfLocation_Width");

            entity.HasOne(d => d.Carton).WithMany(p => p.Inventories)
                .HasForeignKey(d => d.CartonId)
                .HasConstraintName("FK_Inventory_Carton");

            entity.HasOne(d => d.ItemTypeNavigation).WithMany(p => p.Inventories)
                .HasForeignKey(d => d.ItemType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Inventory_InventoryItemType");

            entity.HasOne(d => d.ItemType1).WithMany(p => p.Inventories)
                .HasForeignKey(d => d.ItemType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Inventory_ProductTypes");

            entity.HasOne(d => d.Shelf).WithMany(p => p.Inventories)
                .HasForeignKey(d => d.ShelfId)
                .HasConstraintName("FK_Inventory_Shelf");
        });

        modelBuilder.Entity<InventoryExtendingShelfBackup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("InventoryExtendingShelfBackup", "Support");

            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InventoryItemType>(entity =>
        {
            entity.ToTable("InventoryItemType", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<InventoryTombstone>(entity =>
        {
            entity.HasKey(e => e.InventoryTombsoneSk);

            entity.ToTable("InventoryTombstone", "Inventory");

            entity.HasIndex(e => e.CartonId, "IDX_InventoryTombstone_CartonID");

            entity.Property(e => e.InventoryTombsoneSk).HasColumnName("InventoryTombsoneSK");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CustomerCartonGroupRef)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ShelfLocationCartonOffsetX).HasColumnName("ShelfLocation_CartonOffsetX");
            entity.Property(e => e.ShelfLocationCartonOffsetY).HasColumnName("ShelfLocation_CartonOffsetY");
            entity.Property(e => e.ShelfLocationOffsetX).HasColumnName("ShelfLocation_OffsetX");
            entity.Property(e => e.ShelfLocationOffsetY).HasColumnName("ShelfLocation_OffsetY");
            entity.Property(e => e.ShelfLocationWidth).HasColumnName("ShelfLocation_Width");
            entity.Property(e => e.TombstoneDate).HasDefaultValueSql("(getutcdate())");
        });

        modelBuilder.Entity<Issue>(entity =>
        {
            entity.ToTable("Issues", "Maintenance");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CreatedByUserName).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(25);

            entity.HasOne(d => d.AssetTypeNavigation).WithMany(p => p.Issues)
                .HasForeignKey(d => d.AssetType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Issues_AssetType");
        });

        modelBuilder.Entity<ItemMaster>(entity =>
        {
            entity.HasKey(e => e.StagingItemMasterSk).HasName("PK_StagingItemMasterSK");

            entity.ToTable("ItemMaster", "Staging");

            entity.HasIndex(e => e.CustomerItemCode, "IX_StagingItemMaster_CustomerItemCode");

            entity.HasIndex(e => e.RejectReason, "IX_StagingItemMaster_RejectReason");

            entity.Property(e => e.StagingItemMasterSk).HasColumnName("StagingItemMasterSK");
            entity.Property(e => e.AutoDepalIndicator)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CaseUpc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CaseUPC");
            entity.Property(e => e.Column34)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column 34");
            entity.Property(e => e.CreatedDateTime).HasDefaultValueSql("(sysdatetimeoffset())");
            entity.Property(e => e.CrushableFactor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CustomerItemCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fhscode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FHSCode");
            entity.Property(e => e.GoldDimIndicator)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HazMatCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HazMatDesc)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Hi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HI");
            entity.Property(e => e.ImportFileName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.IsCodeDated)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ItemColor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ItemDescription)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ItemDescription2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ItemSize)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ItemStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ItemUpc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ItemUPC");
            entity.Property(e => e.LithiumIndicator)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MaterialType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.QtyPerVendorPack)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RotationWindow)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SegregationCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StrictRotation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Symeligible)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SYMEligible");
            entity.Property(e => e.SystemAssignment)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ti)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TI");
            entity.Property(e => e.VendorDescription)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VendorName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VendorNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VendorStockNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WarhouseArea)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WhpackHeight)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WHPackHeight");
            entity.Property(e => e.WhpackLength)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WHPackLength");
            entity.Property(e => e.WhpackWeight)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WHPackWeight");
            entity.Property(e => e.WhpackWidth)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WHPackWidth");
        });

        modelBuilder.Entity<LabelBase>(entity =>
        {
            entity.ToTable("LabelBase");

            entity.HasIndex(e => new { e.IsActive, e.BarCode }, "IDX_LabelBase_Barcode_IsActive");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.BarCode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.LabelData).IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LabelBaseWork>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LabelBaseWork", "Staging");

            entity.HasIndex(e => e.LabelBaseId, "IDX_StagingLabelBaseWork_LabelBaseID")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.LabelBaseId).HasColumnName("LabelBaseID");
        });

        modelBuilder.Entity<LabelType>(entity =>
        {
            entity.ToTable("LabelType", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<LeadEdgeOrientation>(entity =>
        {
            entity.ToTable("LeadEdgeOrientation", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<Level>(entity =>
        {
            entity.ToTable("Levels", "Staging");

            entity.HasIndex(e => e.Number, "IX_Levels_Number").IsUnique();
        });

        modelBuilder.Entity<Level1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Level");

            entity.ToTable("Levels", "Structure");

            entity.HasIndex(e => e.ResourceName, "UC_LevelResourceName")
                .IsUnique()
                .HasFilter("([ResourceName] IS NOT NULL)");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.ResourceName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Xmax).HasColumnName("XMax");
            entity.Property(e => e.Xmin).HasColumnName("XMin");
            entity.Property(e => e.Ymax).HasColumnName("YMax");
            entity.Property(e => e.Ymin).HasColumnName("YMin");
        });

        modelBuilder.Entity<LevelMapModel>(entity =>
        {
            entity.ToTable("LevelMapModels", "Staging");
        });

        modelBuilder.Entity<LevelModuleState>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_LevelModuleState");

            entity.ToTable("LevelModuleStates", "Structure", tb =>
                {
                    tb.HasTrigger("trg_LevelModuleStates_Insert");
                    tb.HasTrigger("trg_LevelModuleStates_Update");
                });

            entity.HasIndex(e => e.LevelId, "IDX_FK_LevelModuleState_Level");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.StateNote)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.Level).WithMany(p => p.LevelModuleStates)
                .HasForeignKey(d => d.LevelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LevelModuleState_Level");

            entity.HasOne(d => d.Module).WithMany(p => p.LevelModuleStates)
                .HasForeignKey(d => d.ModuleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LevelModuleState_Module");

            entity.HasOne(d => d.StateNavigation).WithMany(p => p.LevelModuleStates)
                .HasForeignKey(d => d.State)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LevelModuleState_TransitionState");
        });

        modelBuilder.Entity<LevelModuleStatesTombstone>(entity =>
        {
            entity.HasKey(e => e.LevelModleStatesTombstoneSk);

            entity.ToTable("LevelModuleStatesTombstone", "Structure");

            entity.Property(e => e.LevelModleStatesTombstoneSk).HasColumnName("LevelModleStatesTombstoneSK");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.StateNote)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.TombstoneDate).HasDefaultValueSql("(getutcdate())");
        });

        modelBuilder.Entity<LicensePlateNumberStringTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LicensePlateNumberStringTemp", "Sku");

            entity.HasIndex(e => e.LicensePlateNumberString, "PK_LicensePlateNumberString")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.LicensePlateNumberString)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LiftLoad>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("LiftLoads", "Inventory");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CustomerCartonGroupRef)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LiftLoadCarton>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("LiftLoadCartons", "Inventory");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LiftLoadCartonsTombstone>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("LiftLoadCartonsTombstone", "Inventory");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.TransferBufferLoadCartonsTombstoneSk).HasColumnName("TransferBufferLoadCartonsTombstoneSK");
        });

        modelBuilder.Entity<LiftLoadsTombstone>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("LiftLoadsTombstone", "Inventory");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CustomerCartonGroupRef)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.TransferBufferLoadsTombstoneSk).HasColumnName("TransferBufferLoadsTombstoneSK");
        });

        modelBuilder.Entity<LocationType>(entity =>
        {
            entity.ToTable("LocationType", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<LocationWorkOrder>(entity =>
        {
            entity.ToTable("LocationWorkOrders", "Maintenance");

            entity.HasIndex(e => e.LocationId, "IDX_FK_LocationWorkOrders_Location");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Location).WithMany(p => p.LocationWorkOrders)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LocationWorkOrders_Location");
        });

        modelBuilder.Entity<Lpn>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_LPN");

            entity.ToTable("LPNs", "Sku", tb => tb.HasTrigger("trg_LpnsLogHistory"));

            entity.HasIndex(e => e.SkuId, "IDX_FK_LPN_Sku");

            entity.HasIndex(e => e.LicensePlateNumber, "IDX_LPN_LicensePlateNumber");

            entity.HasIndex(e => e.LabelTypeId, "IX_Sku_LPNs_LabelTypeID");

            entity.HasIndex(e => new { e.LicensePlateNumber, e.IsInternal }, "idxLpnIsInternalUniqueForIsActiveTrue")
                .IsUnique()
                .HasFilter("([IsActive]=(1))");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Batch)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.CellGroup)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.LicensePlateNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.SourceFacility)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.HasOne(d => d.HoldStateNavigation).WithMany(p => p.Lpns)
                .HasForeignKey(d => d.HoldState)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LPN_HoldState");

            entity.HasOne(d => d.LabelType).WithMany(p => p.Lpns)
                .HasForeignKey(d => d.LabelTypeId)
                .HasConstraintName("FK_Lpn_LabelType");

            entity.HasOne(d => d.Sku).WithMany(p => p.Lpns)
                .HasForeignKey(d => d.SkuId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LPN_Sku");
        });

        modelBuilder.Entity<LpnSelectionMode>(entity =>
        {
            entity.ToTable("LpnSelectionMode", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<LpnStringTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LpnStringTemp", "Sku");

            entity.HasIndex(e => e.LpnString, "PK_LpnString")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.LpnString)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Lpnextension>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.ToTable("LPNExtension", "Sku");

            entity.HasIndex(e => e.ExtensionValue, "IX_Sku_LPNExtension_ExtensionValue");

            entity.HasIndex(e => new { e.Lpnid, e.ExtensionKeyId }, "UIX_LPNExtension_LPNId_KeyID")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("(left(suser_name(),(25)))");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime");
            entity.Property(e => e.ExtensionKeyId).HasComment("FK Ref Extension.LPNExtensionKey.Id.");
            entity.Property(e => e.ExtensionValue).HasMaxLength(2000);
            entity.Property(e => e.Lpnid)
                .HasComment("FK Ref Sku.LPNs.ID")
                .HasColumnName("LPNID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("(left(suser_name(),(25)))");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.ExtensionKey).WithMany(p => p.Lpnextensions)
                .HasForeignKey(d => d.ExtensionKeyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LPNExtension_LPNExtensionKey");

            entity.HasOne(d => d.Lpn).WithMany(p => p.Lpnextensions)
                .HasForeignKey(d => d.Lpnid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Sku_LPNs_ID");
        });

        modelBuilder.Entity<LpnextensionKey>(entity =>
        {
            entity.ToTable("LPNExtensionKey", "Extension");

            entity.HasIndex(e => e.Name, "UQX_LPNExtensionKeyName").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(sysdatetimeoffset())");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(sysdatetimeoffset())");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LpnrejectReason>(entity =>
        {
            entity.ToTable("LPNRejectReason", "Lookups");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(sysdatetimeoffset())");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DisplayName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(sysdatetimeoffset())");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RecordNumber).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LpnrejectReason1>(entity =>
        {
            entity.HasKey(e => e.RecordNumber).HasName("PK_LPNRejectReason_1");

            entity.ToTable("LPNRejectReasons", "Staging");

            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DisplayName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LpnsBackup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LPNsBackup", "Support");

            entity.Property(e => e.LicensePlateNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LpnsHistory>(entity =>
        {
            entity.HasKey(e => e.LpnsHistorySk).HasName("PK_LpnsHistorySK");

            entity.ToTable("LpnsHistory", "Sku");

            entity.Property(e => e.LpnsHistorySk).HasColumnName("LpnsHistorySK");
            entity.Property(e => e.Batch)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.LicensePlateNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.SourceFacility)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ManualBuildReason>(entity =>
        {
            entity.ToTable("ManualBuildReason", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<MeasuredBy>(entity =>
        {
            entity.ToTable("MeasuredBy", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<MessageCategory>(entity =>
        {
            entity.ToTable("MessageCategories", "Staging");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MessageQueue>(entity =>
        {
            entity.ToTable("MessageQueue");

            entity.Property(e => e.Schema)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Table)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MessageType>(entity =>
        {
            entity.ToTable("MessageType", "Staging");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MessagesToPublish>(entity =>
        {
            entity.ToTable("MessagesToPublish", "Inventory", tb => tb.HasComment("A row is inserted in this table each time we receive any allocation messages."));

            entity.HasIndex(e => e.MessageId, "UQ_MessagesToPublish_MessageId").IsUnique();

            entity.Property(e => e.Id).HasComment("Primary Key that is Identity column.");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(sysutcdatetime())")
                .HasComment("CreatedTime for the record in UTC.");
            entity.Property(e => e.IsContentsValid).HasComment("Flag to indicate if the adjustement was applied or not. 1 means the tote contents are valid and adjustment is applied.");
            entity.Property(e => e.Message).HasComment("Message in json format that is being received.");
            entity.Property(e => e.MessageId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("Unique Identifier of the message.");
            entity.Property(e => e.MessageType)
                .HasMaxLength(200)
                .HasComment("MessageType of the Message being received.");
            entity.Property(e => e.ModifiedDate).HasComment("Time in UTC that this record was last modified.");
        });

        modelBuilder.Entity<MeteringGroup>(entity =>
        {
            entity.ToTable("MeteringGroups", "Outbound");

            entity.HasIndex(e => e.MeteringGroupId, "UC_MeteringGroups_MeteringGroupId").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.MeteringGroupId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Path)
                .HasMaxLength(512)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MeteringGroup1>(entity =>
        {
            entity.ToTable("MeteringGroups", "Staging");

            entity.Property(e => e.MeteringGroupId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Path)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MeteringGroupInformation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("MeteringGroupInformation", "Staging");

            entity.Property(e => e.MeteringGroupId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Path)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MeteringGroupRef>(entity =>
        {
            entity.ToTable("MeteringGroupRef", "Staging");

            entity.Property(e => e.MeteringGroupId)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Module>(entity =>
        {
            entity.ToTable("Modules", "Staging");

            entity.HasIndex(e => e.Number, "IX_Modules_Number").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Module1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Module");

            entity.ToTable("Modules", "Structure");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<MultiPalletType>(entity =>
        {
            entity.ToTable("MultiPalletType", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<Note>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Note");

            entity.ToTable("Notes", "Shift");

            entity.HasIndex(e => e.ShiftId, "IDX_FK_Note_Shift");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.AssetName).HasMaxLength(50);
            entity.Property(e => e.AudienceRole).HasMaxLength(50);
            entity.Property(e => e.AuthorUserName).HasMaxLength(50);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(50);

            entity.HasOne(d => d.Shift).WithMany(p => p.Notes)
                .HasForeignKey(d => d.ShiftId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Note_Shift");
        });

        modelBuilder.Entity<NotifyState>(entity =>
        {
            entity.ToTable("NotifyState", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<OdvType>(entity =>
        {
            entity.ToTable("OdvType", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<OperationalMode>(entity =>
        {
            entity.ToTable("OperationalMode", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Order");

            entity.ToTable("Orders", "Orders");

            entity.HasIndex(e => e.OrderTypeId, "IDX_FK_Order_OrderType");

            entity.HasIndex(e => e.ClosedTime, "IDX_Orders_ClosedTime");

            entity.HasIndex(e => e.CreatedDate, "IDX_Orders_Orders_CreatedDate");

            entity.HasIndex(e => e.OrderBatchId, "IDX_Orders_Orders_OrderBatchId");

            entity.HasIndex(e => e.OrderNumber, "IDX_Orders_Orders_OrderNumber");

            entity.HasIndex(e => e.ParentOrderId, "IDX_Orders_Orders_ParentOrderId");

            entity.HasIndex(e => e.State, "IDX_Orders_Orders_State");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CellGroup)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CustomerChainNumber)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CustomerName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.CustomerNumber)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.DoorNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.OrderNumber)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.OrderTypeId).HasDefaultValue(-1);
            entity.Property(e => e.TrailerNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TruckRoute)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.CaseStorageNotifyStateNavigation).WithMany(p => p.OrderCaseStorageNotifyStateNavigations)
                .HasForeignKey(d => d.CaseStorageNotifyState)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_NotifyState3");

            entity.HasOne(d => d.CompletedNotifyStateNavigation).WithMany(p => p.OrderCompletedNotifyStateNavigations)
                .HasForeignKey(d => d.CompletedNotifyState)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_NotifyState2");

            entity.HasOne(d => d.HoldStateNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.HoldState)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_OrderHoldState");

            entity.HasOne(d => d.OrderBatch).WithMany(p => p.Orders)
                .HasForeignKey(d => d.OrderBatchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_OrderBatch");

            entity.HasOne(d => d.OrderCancelSource).WithMany(p => p.Orders)
                .HasForeignKey(d => d.OrderCancelSourceId)
                .HasConstraintName("FK_Order_OrderCancelSource");

            entity.HasOne(d => d.OrderType).WithMany(p => p.Orders)
                .HasForeignKey(d => d.OrderTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_OrderType");

            entity.HasOne(d => d.ParentOrder).WithMany(p => p.InverseParentOrder)
                .HasForeignKey(d => d.ParentOrderId)
                .HasConstraintName("FK_Order_Order");

            entity.HasOne(d => d.PlanStateNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.PlanState)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_OrderPlanState");

            entity.HasOne(d => d.PlanUpdatedNotifyStateNavigation).WithMany(p => p.OrderPlanUpdatedNotifyStateNavigations)
                .HasForeignKey(d => d.PlanUpdatedNotifyState)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_NotifyState1");

            entity.HasOne(d => d.PlannedNotifyStateNavigation).WithMany(p => p.OrderPlannedNotifyStateNavigations)
                .HasForeignKey(d => d.PlannedNotifyState)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_NotifyState");

            entity.HasOne(d => d.SelectionModeNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.SelectionMode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_ExpirationSelectionMode");

            entity.HasOne(d => d.StateNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.State)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_OrderState");
        });

        modelBuilder.Entity<Order1>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.SessionKey }).HasName("PK_StgOrders");

            entity.ToTable("Orders", "Staging");

            entity.HasIndex(e => e.SessionKey, "IX_Orders");

            entity.Property(e => e.CellGroup)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CustomerChainNumber)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CustomerName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.CustomerNumber)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.DoorNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.OrderNumber)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.TrailerNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TruckRoute)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OrderBatch>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_OrderBatch");

            entity.ToTable("OrderBatches", "Orders");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CustomerBatchRef).HasMaxLength(25);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.HasOne(d => d.StateNavigation).WithMany(p => p.OrderBatches)
                .HasForeignKey(d => d.State)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderBatches_OrderBatchState");
        });

        modelBuilder.Entity<OrderBatch1>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.SessionKey }).HasName("PK_StgOrderBatches");

            entity.ToTable("OrderBatches", "Staging");

            entity.Property(e => e.CustomerBatchRef).HasMaxLength(25);
        });

        modelBuilder.Entity<OrderBatchState>(entity =>
        {
            entity.ToTable("OrderBatchState", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<OrderCancelSource>(entity =>
        {
            entity.ToTable("OrderCancelSource", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<OrderCartonType>(entity =>
        {
            entity.ToTable("OrderCartonType", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<OrderDestination>(entity =>
        {
            entity.ToTable("OrderDestination", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_OrderDetail");

            entity.ToTable("OrderDetails", "Orders");

            entity.HasIndex(e => e.DestinationCategoryId, "IDX_FK_OrderDetail_DestinationCategory");

            entity.HasIndex(e => e.FulfilledById, "IDX_FK_OrderDetail_FulfilledBy");

            entity.HasIndex(e => e.LpnId, "IDX_FK_OrderDetail_Lpn");

            entity.HasIndex(e => e.SkuId, "IDX_FK_OrderDetail_Sku");

            entity.HasIndex(e => e.OrderId, "IDX_OrderDetails_CI_OutboundSummary");

            entity.HasIndex(e => e.ContainerType, "IDX_OrderDetails_ContainerType");

            entity.HasIndex(e => new { e.OrderId, e.SkuId, e.LpnId }, "IDX_Orders_OrderDetails_OrderId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Batch)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.CartonAvailabilitySelectionMode).HasDefaultValue(1);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CustomerCartonRef)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CustomerChainNumber)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CustomerNumber)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CustomerRef)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CustomerTaskId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.GroupId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Ponumber).HasColumnName("PONumber");
            entity.Property(e => e.SourceFacility)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.SpogNumber)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Ssp).HasColumnName("SSP");
            entity.Property(e => e.UseAvailableOnly).HasDefaultValue(true);
            entity.Property(e => e.Vcp).HasColumnName("VCP");

            entity.HasOne(d => d.CartonAvailabilitySelectionModeNavigation).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.CartonAvailabilitySelectionMode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderDetails_CartonAvailabilitySelectionMode");

            entity.HasOne(d => d.CartonTypeNavigation).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.CartonType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderDetails_OrderCartonType");

            entity.HasOne(d => d.ContainerTypeNavigation).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.ContainerType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderDetails_ContainerType");

            entity.HasOne(d => d.DestinationCategory).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.DestinationCategoryId)
                .HasConstraintName("FK_OrderDetail_DestinationCategory");

            entity.HasOne(d => d.FulfilledBy).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.FulfilledById)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderDetails_FulfilledById");

            entity.HasOne(d => d.LabelType).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.LabelTypeId)
                .HasConstraintName("FK_OrderDetails_LabelType");

            entity.HasOne(d => d.Lpn).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.LpnId)
                .HasConstraintName("FK_OrderDetail_Lpn");

            entity.HasOne(d => d.LpnSelectionModeNavigation).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.LpnSelectionMode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderDetails_LpnSelectionMode");

            entity.HasOne(d => d.OrderDestinationNavigation).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.OrderDestination)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderDetails_OrderDestination");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderDetail_Order");

            entity.HasOne(d => d.PalletBaseType).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.PalletBaseTypeId)
                .HasConstraintName("FK_OrderDetails_PalletBaseType");

            entity.HasOne(d => d.QuantityTypeNavigation).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.QuantityType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderDetails_QuantityType");

            entity.HasOne(d => d.Sku).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.SkuId)
                .HasConstraintName("FK_OrderDetail_Sku");
        });

        modelBuilder.Entity<OrderDetail1>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.SessionKey }).HasName("PK_StgOrderDetails");

            entity.ToTable("OrderDetails", "Staging");

            entity.HasIndex(e => e.SessionKey, "IX_OrderDetails");

            entity.Property(e => e.Batch)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.CustomerCartonRef)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CustomerChainNumber)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CustomerNumber)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CustomerRef)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CustomerTaskId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.GroupId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ponumber).HasColumnName("PONumber");
            entity.Property(e => e.SourceFacility)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.SpogNumber)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Ssp).HasColumnName("SSP");
            entity.Property(e => e.Vcp).HasColumnName("VCP");
        });

        modelBuilder.Entity<OrderDetailCartonLabel>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.SessionKey });

            entity.ToTable("OrderDetailCartonLabels", "Staging");

            entity.HasIndex(e => e.SessionKey, "IX_CartonLabels");

            entity.Property(e => e.BarCode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LabelData)
                .HasMaxLength(4000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OrderDetailCaseGroupNumber>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.SessionKey });

            entity.ToTable("OrderDetailCaseGroupNumbers", "Staging");

            entity.Property(e => e.EligibleForCr).HasColumnName("EligibleForCR");
        });

        modelBuilder.Entity<OrderDetailCustomerCartonRef>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.SessionKey });

            entity.ToTable("OrderDetailCustomerCartonRefs", "Staging");

            entity.HasIndex(e => e.SessionKey, "IX_OrderDetailCustomerCartonRefs");

            entity.Property(e => e.CustomerCartonRef)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OrderDetailExtension>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_Orders_OrderDetailExtension_Id")
                .IsClustered(false);

            entity.ToTable("OrderDetailExtension", "Orders");

            entity.HasIndex(e => new { e.OrderDetailId, e.ExtensionKeyId }, "UQX_OrderDetailExtension_OrderDetailID_ExtensionKeyId")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("(left(suser_name(),(25)))");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime");
            entity.Property(e => e.ExtensionKeyId)
                .HasComment("FK Ref Extension.OrderDetailExtensionKey.Id.")
                .HasColumnName("ExtensionKeyID");
            entity.Property(e => e.ExtensionValue).HasMaxLength(2000);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("(left(suser_name(),(25)))");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime");
            entity.Property(e => e.OrderDetailId)
                .HasComment("FK Ref Orders.OrderDetails.ID")
                .HasColumnName("OrderDetailID");

            entity.HasOne(d => d.ExtensionKey).WithMany(p => p.OrderDetailExtensions)
                .HasForeignKey(d => d.ExtensionKeyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderDetailExtensionKeyID");

            entity.HasOne(d => d.OrderDetail).WithMany(p => p.OrderDetailExtensions)
                .HasForeignKey(d => d.OrderDetailId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderDetailExtension_OrderDetails_ID");
        });

        modelBuilder.Entity<OrderDetailExtension1>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.SessionKey }).HasName("PK_StgOrderDetailExtensions");

            entity.ToTable("OrderDetailExtensions", "Staging");

            entity.HasIndex(e => e.SessionKey, "IX_OrderDetailExtensions");

            entity.Property(e => e.ExtensionKeyId).HasColumnName("ExtensionKeyID");
            entity.Property(e => e.ExtensionValue).HasMaxLength(2000);
            entity.Property(e => e.OrderDetailId).HasColumnName("OrderDetailID");
        });

        modelBuilder.Entity<OrderDetailExtensionKey>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_OrderDetailExtensionKeyID");

            entity.ToTable("OrderDetailExtensionKey", "Extension");

            entity.HasIndex(e => e.Name, "UQX_OrderDetailExtensionKeyName").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(sysdatetimeoffset())");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(sysdatetimeoffset())");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OrderExtension>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.ToTable("OrderExtension", "Orders");

            entity.HasIndex(e => new { e.OrderId, e.ExtensionKeyId }, "UQX_OrderExtension_OrderID_ExtensionKeyId")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("(left(suser_name(),(25)))");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime");
            entity.Property(e => e.ExtensionKeyId).HasComment("FK Ref Extension.OrderExtensionKey.Id.");
            entity.Property(e => e.ExtensionValue).HasMaxLength(2000);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("(left(suser_name(),(25)))");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime");
            entity.Property(e => e.OrderId).HasComment("FK Ref Orders.Orders.Id");

            entity.HasOne(d => d.ExtensionKey).WithMany(p => p.OrderExtensions)
                .HasForeignKey(d => d.ExtensionKeyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderExtensionKeyId");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderExtensions)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderExtension_Orders");
        });

        modelBuilder.Entity<OrderExtension1>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.SessionKey });

            entity.ToTable("OrderExtensions", "Staging");

            entity.Property(e => e.ExtensionValue).HasMaxLength(2000);
        });

        modelBuilder.Entity<OrderExtensionKey>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_OrderExtensionKeyID");

            entity.ToTable("OrderExtensionKey", "Extension");

            entity.HasIndex(e => e.Name, "UQX_OrderExtensionKeyName").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(sysdatetimeoffset())");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(sysdatetimeoffset())");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OrderHoldState>(entity =>
        {
            entity.ToTable("OrderHoldState", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<OrderPlanState>(entity =>
        {
            entity.ToTable("OrderPlanState", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<OrderState>(entity =>
        {
            entity.ToTable("OrderState", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<OrderType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_OrderType");

            entity.ToTable("OrderTypes", "Orders");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(sysdatetimeoffset())");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DisplayName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.IsDefault).HasDefaultValue(false);
            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(sysdatetimeoffset())");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RecordNumber).ValueGeneratedOnAdd();
            entity.Property(e => e.Regex)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OrderType1>(entity =>
        {
            entity.HasKey(e => e.RecordNumber);

            entity.ToTable("OrderTypes", "Staging");

            entity.Property(e => e.CanManualCancel).HasDefaultValue(false);
            entity.Property(e => e.DefaultPriority).HasDefaultValue(0);
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DisplayName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DisplayOrder).HasDefaultValue(0);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Regex)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OrdersWork>(entity =>
        {
            entity.HasKey(e => e.OrderBatchId).HasName("PK_StagingOrdersWork_OrderBatchID");

            entity.ToTable("OrdersWork", "Staging");

            entity.Property(e => e.OrderBatchId)
                .ValueGeneratedNever()
                .HasComment("The IDs in here are actually from Orders.OrderBatches.OrderBatchID.")
                .HasColumnName("OrderBatchID");
        });

        modelBuilder.Entity<Outbound>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Outbound");

            entity.ToTable("Outbounds", "Outbound");

            entity.HasIndex(e => e.DestinationId, "IDX_FK_Outbound_Destination");

            entity.HasIndex(e => new { e.OrderId, e.State }, "IDX_Outbound_Outbounds_OrderId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.HasOne(d => d.ChildOutboundType).WithMany(p => p.Outbounds)
                .HasForeignKey(d => d.ChildOutboundTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Outbound_ChildOutboundType");

            entity.HasOne(d => d.Destination).WithMany(p => p.Outbounds)
                .HasForeignKey(d => d.DestinationId)
                .HasConstraintName("FK_Outbound_Destination");

            entity.HasOne(d => d.Order).WithMany(p => p.Outbounds)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Outbound_Order");

            entity.HasOne(d => d.OutboundDestinationNavigation).WithMany(p => p.Outbounds)
                .HasForeignKey(d => d.OutboundDestination)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Outbounds_OutboundDestination");

            entity.HasOne(d => d.StateNavigation).WithMany(p => p.Outbounds)
                .HasForeignKey(d => d.State)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Outbounds_OutboundState");
        });

        modelBuilder.Entity<OutboundBatch>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_OutboundBatch");

            entity.ToTable("OutboundBatches", "Outbound");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.OutboundBatch)
                .HasForeignKey<OutboundBatch>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OutboundBatch_Outbound");
        });

        modelBuilder.Entity<OutboundBatch1>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.SessionKey });

            entity.ToTable("OutboundBatches", "Staging");
        });

        modelBuilder.Entity<OutboundCarton>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_OutboundCarton");

            entity.ToTable("OutboundCartons", "Outbound");

            entity.HasIndex(e => e.CartonLabelId, "IDX_FK_OutboundCarton_CartonLabel");

            entity.HasIndex(e => e.DestinationId, "IDX_FK_OutboundCarton_Destination");

            entity.HasIndex(e => new { e.DeliveredTime, e.PurgedTime, e.DestinationGroup, e.OnConveyorTime }, "IDX_OutboundCartons_GetOutboundCartonsPerformance");

            entity.HasIndex(e => new { e.OnConveyorTime, e.RejectedTime }, "IDX_OutboundCartons_for_SSRS");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.IsOutbounding).HasComputedColumnSql("(case when coalesce([OnBotTime],[OnCartonLiftTime],[OnConveyorTime],[RoutedToDestinationTime],[DeliveredTime],[PalletizedTime],[PurgedTime],[RejectedTime]) IS NOT NULL OR coalesce([RejectReason],[OutboundDestination],[DestinationGroup]) IS NOT NULL OR coalesce([DestinationId],[CartonLabelId]) IS NOT NULL then (1) else (0) end)", false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.OnLiftPnDtime).HasColumnName("OnLiftPnDTime");

            entity.HasOne(d => d.CartonLabel).WithMany(p => p.OutboundCartons)
                .HasForeignKey(d => d.CartonLabelId)
                .HasConstraintName("FK_OutboundCarton_CartonLabel");

            entity.HasOne(d => d.Destination).WithMany(p => p.OutboundCartons)
                .HasForeignKey(d => d.DestinationId)
                .HasConstraintName("FK_OutboundCarton_Destination");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.OutboundCarton)
                .HasForeignKey<OutboundCarton>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OutboundCarton_Carton");

            entity.HasOne(d => d.OutboundDestinationNavigation).WithMany(p => p.OutboundCartons)
                .HasForeignKey(d => d.OutboundDestination)
                .HasConstraintName("FK_OutboundCartons_OutboundDestination");
        });

        modelBuilder.Entity<OutboundDestination>(entity =>
        {
            entity.ToTable("OutboundDestination", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<OutboundDimensionalVariant>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_OutboundDimVars");

            entity.ToTable("OutboundDimensionalVariants", "Sku", tb => tb.HasTrigger("trg_OutboundDimensionalVariantsLogHistory"));

            entity.HasIndex(e => e.Id, "IX_OutboundDimVars_Id").IsUnique();

            entity.HasIndex(e => new { e.SkuId, e.IsActive }, "IX_OutboundDimensionalVariants_SkuId_IsActive");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.RecordNumber).ValueGeneratedOnAdd();

            entity.HasOne(d => d.OdvType).WithMany(p => p.OutboundDimensionalVariants)
                .HasForeignKey(d => d.OdvTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OutboundDimVars_OdvType");

            entity.HasOne(d => d.Sku).WithMany(p => p.OutboundDimensionalVariants)
                .HasForeignKey(d => d.SkuId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OutboundDimVars_Skus");
        });

        modelBuilder.Entity<OutboundDimensionalVariantTombstone>(entity =>
        {
            entity.HasKey(e => e.OutboundDimensionalVariantTombsoneSk);

            entity.ToTable("OutboundDimensionalVariantTombstone", "Sku");

            entity.Property(e => e.OutboundDimensionalVariantTombsoneSk).HasColumnName("OutboundDimensionalVariantTombsoneSK");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.TombstoneDate).HasDefaultValueSql("(getutcdate())");
        });

        modelBuilder.Entity<OutboundExtension>(entity =>
        {
            entity.ToTable("OutboundExtension", "Outbound");

            entity.HasIndex(e => e.ExtensionKeyId, "IDX_OutboundExtension_ExtensionKeyId");

            entity.HasIndex(e => e.ExtensionValueId, "IDX_OutboundExtension_ExtensionValueId");

            entity.HasIndex(e => e.OutboundId, "IDX_OutboundExtension_OutboundId");

            entity.HasIndex(e => new { e.ExtensionKeyId, e.OutboundId }, "UC_OutboundExtension_ExtensionKeyId_OutboundId").IsUnique();

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.HasOne(d => d.ExtensionKey).WithMany(p => p.OutboundExtensions)
                .HasForeignKey(d => d.ExtensionKeyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OutboundExtension_ExtensionKeyId");

            entity.HasOne(d => d.ExtensionValue).WithMany(p => p.OutboundExtensions)
                .HasForeignKey(d => d.ExtensionValueId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OutboundExtension_ExtensionValueId");

            entity.HasOne(d => d.Outbound).WithMany(p => p.OutboundExtensions)
                .HasForeignKey(d => d.OutboundId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OutboundExtension_OutboundId");
        });

        modelBuilder.Entity<OutboundExtensionKey>(entity =>
        {
            entity.ToTable("OutboundExtensionKey", "Outbound");

            entity.HasIndex(e => e.Key, "UC_OutboundExtensionKey_Key").IsUnique();

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Key)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OutboundExtensionValue>(entity =>
        {
            entity.ToTable("OutboundExtensionValue", "Outbound");

            entity.HasIndex(e => e.Value, "UC_OutboundExtensionValue_Value").IsUnique();

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Value)
                .HasMaxLength(2000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OutboundLabel>(entity =>
        {
            entity.ToTable("OutboundLabel", "Outbound");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.BarCode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.LabelData).IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.OutboundLabel)
                .HasForeignKey<OutboundLabel>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OutboundLabel_Outbound");
        });

        modelBuilder.Entity<OutboundOrderSummary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("OutboundOrderSummary", "Orders");

            entity.Property(e => e.CustomerBatchRef).HasMaxLength(25);
            entity.Property(e => e.CustomerChainNumber)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CustomerNumber)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.DoorNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.OrderNumber)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.OrderTypeDisplayName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.OrderTypeName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TrailerNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TruckRoute)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OutboundPallet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_OutboundPallet");

            entity.ToTable("OutboundPallets", "Outbound");

            entity.HasIndex(e => e.PalletBaseTypeId, "IDX_FK_OutboundPallet_PalletBaseType");

            entity.HasIndex(e => e.BuiltTime, "IDX_OutboundPallets_BuiltTime");

            entity.HasIndex(e => e.OutboundPalletNumber, "UC_OutboundPallet_OutboundPalletNumber").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CustomerPalletNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Lpn)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PalletBaseTypeId).HasDefaultValue(-1);
            entity.Property(e => e.PalletResultFileName).HasMaxLength(250);
            entity.Property(e => e.ParentPalletId).HasColumnName("ParentPalletID");
            entity.Property(e => e.PickupLocation).HasMaxLength(30);
            entity.Property(e => e.PlannedPalletFileName).HasMaxLength(250);
            entity.Property(e => e.SequenceFileName).HasMaxLength(250);

            entity.HasOne(d => d.AlternatePrintingStateNavigation).WithMany(p => p.OutboundPallets)
                .HasForeignKey(d => d.AlternatePrintingState)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OutboundPallets_OutboundPalletAlternatePrintingState");

            entity.HasOne(d => d.BuildModeNavigation).WithMany(p => p.OutboundPallets)
                .HasForeignKey(d => d.BuildMode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OutboundPallets_OperationalMode");

            entity.HasOne(d => d.BuildResultNavigation).WithMany(p => p.OutboundPallets)
                .HasForeignKey(d => d.BuildResult)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OutboundPallets_PalletPalletizingResult");

            entity.HasOne(d => d.DeliveredStateNavigation).WithMany(p => p.OutboundPallets)
                .HasForeignKey(d => d.DeliveredState)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OutboundPallets_OutboundPalletDeliveredState");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.OutboundPallet)
                .HasForeignKey<OutboundPallet>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OutboundPallet_Outbound");

            entity.HasOne(d => d.LabelingSubStateNavigation).WithMany(p => p.OutboundPallets)
                .HasForeignKey(d => d.LabelingSubState)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OutboundPallets_OutboundPalletLabelingSubState");

            entity.HasOne(d => d.ManualBuildReason).WithMany(p => p.OutboundPallets)
                .HasForeignKey(d => d.ManualBuildReasonId)
                .HasConstraintName("FK_OutboundPallets_ManualBuildReason");

            entity.HasOne(d => d.NotifiedStateNavigation).WithMany(p => p.OutboundPallets)
                .HasForeignKey(d => d.NotifiedState)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OutboundPallets_OutboundPalletNotifyState");

            entity.HasOne(d => d.PalletBaseType).WithMany(p => p.OutboundPallets)
                .HasForeignKey(d => d.PalletBaseTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OutboundPallets_PalletPalletBaseType");

            entity.HasOne(d => d.PalletBuiltBy).WithMany(p => p.OutboundPallets)
                .HasForeignKey(d => d.PalletBuiltById)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OutboundPallets_PalletBuiltBy");

            entity.HasOne(d => d.PalletTypeNavigation).WithMany(p => p.OutboundPallets)
                .HasForeignKey(d => d.PalletType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OutboundPallets_PalletType");

            entity.HasOne(d => d.PalletizingSubStateNavigation).WithMany(p => p.OutboundPallets)
                .HasForeignKey(d => d.PalletizingSubState)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OutboundPallets_PalletizingSubState");
        });

        modelBuilder.Entity<OutboundPallet1>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.SessionKey });

            entity.ToTable("OutboundPallets", "Staging");

            entity.Property(e => e.CustomerPalletNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Lpn)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.PalletResultFileName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ParentPalletId).HasColumnName("ParentPalletID");
            entity.Property(e => e.PickupLocation)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PlannedPalletFileName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.SequenceFileName)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OutboundPalletAlternatePrintingState>(entity =>
        {
            entity.ToTable("OutboundPalletAlternatePrintingState", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<OutboundPalletDeliveredState>(entity =>
        {
            entity.ToTable("OutboundPalletDeliveredState", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<OutboundPalletLabelingSubState>(entity =>
        {
            entity.ToTable("OutboundPalletLabelingSubState", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<OutboundPalletNotifyState>(entity =>
        {
            entity.ToTable("OutboundPalletNotifyState", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<OutboundParentChildMap>(entity =>
        {
            entity.HasKey(e => new { e.ParentId, e.ChildId });

            entity.ToTable("OutboundParentChildMap", "Outbound");

            entity.HasIndex(e => e.ChildId, "UK_OutboundParentChildMap_ChildId").IsUnique();

            entity.HasOne(d => d.Child).WithOne(p => p.OutboundParentChildMapChild)
                .HasForeignKey<OutboundParentChildMap>(d => d.ChildId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Parent).WithMany(p => p.OutboundParentChildMapParents)
                .HasForeignKey(d => d.ParentId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<OutboundState>(entity =>
        {
            entity.ToTable("OutboundState", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<OutputPriority>(entity =>
        {
            entity.ToTable("OutputPriority", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(40);
        });

        modelBuilder.Entity<PackagingType>(entity =>
        {
            entity.ToTable("PackagingType", "Sku");

            entity.HasIndex(e => e.Name, "UC_SkuPackagingTypeName").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedDate)
                .HasPrecision(3)
                .HasDefaultValueSql("(sysdatetimeoffset())");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DisplayName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.IsDefault).HasDefaultValue(false);
            entity.Property(e => e.ModifiedDate)
                .HasPrecision(3)
                .HasDefaultValueSql("(sysdatetimeoffset())");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PalletBaseType>(entity =>
        {
            entity.ToTable("PalletBaseType");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DisplayName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.IsDefaultInbound).HasDefaultValue(false);
            entity.Property(e => e.IsDefaultOutbound).HasDefaultValue(false);
            entity.Property(e => e.IsModified).HasDefaultValue(false);
            entity.Property(e => e.MaxHeight).HasDefaultValue(0);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PalletBaseType1>(entity =>
        {
            entity.HasKey(e => e.RecordNumber).HasName("PK_PalletBaseType_1");

            entity.ToTable("PalletBaseTypes", "Staging");

            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DisplayName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DisplayOrder).HasDefaultValue(0);
            entity.Property(e => e.IsActive).HasDefaultValue(false);
            entity.Property(e => e.IsModified).HasDefaultValue(false);
            entity.Property(e => e.MaxHeight).HasDefaultValue(0);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PalletBuiltBy>(entity =>
        {
            entity.ToTable("PalletBuiltBy", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<PalletDeliveryState>(entity =>
        {
            entity.ToTable("PalletDeliveryState", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<PalletLayer>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_Layers")
                .IsClustered(false);

            entity.ToTable("PalletLayers", "Inbound");

            entity.HasIndex(e => e.PalletId, "IDX_FK_InboundPalletLayers_InboundPallets");

            entity.HasIndex(e => e.RecordNumber, "IX_InboundPalletLayers").IsClustered();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.RecordNumber).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Pallet).WithMany(p => p.PalletLayers)
                .HasForeignKey(d => d.PalletId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InboundPalletLayers_InboundPallets");
        });

        modelBuilder.Entity<PalletPalletizingResult>(entity =>
        {
            entity.ToTable("PalletPalletizingResult", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<PalletSequencingRequest>(entity =>
        {
            entity.ToTable("PalletSequencingRequests", "Sequencing");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.PalletFileName).HasMaxLength(250);
            entity.Property(e => e.SequenceFileName).HasMaxLength(250);

            entity.HasOne(d => d.StateNavigation).WithMany(p => p.PalletSequencingRequests)
                .HasForeignKey(d => d.State)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PalletSequencingRequests_PalletSequencingRequestState");
        });

        modelBuilder.Entity<PalletSequencingRequestError>(entity =>
        {
            entity.ToTable("PalletSequencingRequestErrors", "Sequencing");

            entity.HasIndex(e => e.PalletSequencingRequestId, "IDX_FK_PalletSequencingRequestErrors_PalletSequencingRequests");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ComponentName).HasMaxLength(200);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.HasOne(d => d.PalletSequencingRequest).WithMany(p => p.PalletSequencingRequestErrors)
                .HasForeignKey(d => d.PalletSequencingRequestId)
                .HasConstraintName("FK_PalletSequencingRequestErrors_PalletSequencingRequests");
        });

        modelBuilder.Entity<PalletSequencingRequestState>(entity =>
        {
            entity.ToTable("PalletSequencingRequestState", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<PalletSourceType>(entity =>
        {
            entity.ToTable("PalletSourceType", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<PalletType>(entity =>
        {
            entity.ToTable("PalletType", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<PalletizationGroupType>(entity =>
        {
            entity.ToTable("PalletizationGroupType", "Sku");

            entity.HasIndex(e => e.Name, "UC_SkuPalletizationGroupTypeName").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedDate)
                .HasPrecision(3)
                .HasDefaultValueSql("(sysdatetimeoffset())");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DisplayName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate)
                .HasPrecision(3)
                .HasDefaultValueSql("(sysdatetimeoffset())");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PalletizationGroupType1>(entity =>
        {
            entity.HasKey(e => e.RecordNumber).HasName("PK_PalletizationGroupType_1");

            entity.ToTable("PalletizationGroupTypes", "Staging");

            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DisplayName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DisplayOrder).HasDefaultValue(0);
            entity.Property(e => e.IsActive).HasDefaultValue(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PalletizingSubState>(entity =>
        {
            entity.ToTable("PalletizingSubState", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<Parameter>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Parameters", "Purge");

            entity.HasIndex(e => new { e.CategoryType, e.KeyName }, "UQ_Parameters_CategoryTypeAndKeyName").IsUnique();

            entity.Property(e => e.CategoryType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.KeyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.KeyValue)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.KeyValueProperty)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PartialPalletState>(entity =>
        {
            entity.ToTable("PartialPalletState", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<PickupAndDeliveryStation>(entity =>
        {
            entity.ToTable("PickupAndDeliveryStations", "Staging");

            entity.Property(e => e.CellName)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SubsystemId)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PickupAndDeliveryStation1>(entity =>
        {
            entity.ToTable("PickupAndDeliveryStations", "Structure");

            entity.HasIndex(e => e.ModuleId, "IDX_FK_PickupAndDeliveryStation_Module");

            entity.HasIndex(e => e.Name, "UC_PndName").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CellName).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(500);

            entity.HasOne(d => d.Aisle).WithMany(p => p.PickupAndDeliveryStation1s)
                .HasForeignKey(d => d.AisleId)
                .HasConstraintName("FK_PickupAndDeliveryStations_Aisle");

            entity.HasOne(d => d.DirectionNavigation).WithMany(p => p.PickupAndDeliveryStation1s)
                .HasForeignKey(d => d.Direction)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PickupAndDeliveryStations_Direction");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.PickupAndDeliveryStation1)
                .HasForeignKey<PickupAndDeliveryStation1>(d => d.Id)
                .HasConstraintName("FK_PickupAndDeliveryStations_Endpoint");

            entity.HasOne(d => d.Module).WithMany(p => p.PickupAndDeliveryStation1s)
                .HasForeignKey(d => d.ModuleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PickupAndDeliveryStation_Module");

            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.PickupAndDeliveryStation1s)
                .HasForeignKey(d => d.Type)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PickupAndDeliveryStations_Type");
        });

        modelBuilder.Entity<PickupAndDeliveryStationDirection>(entity =>
        {
            entity.ToTable("PickupAndDeliveryStationDirection", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<PickupAndDeliveryStationType>(entity =>
        {
            entity.ToTable("PickupAndDeliveryStationType", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<ProcessLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DeploymentResults");

            entity.ToTable("ProcessLog", "Staging");

            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Message)
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.HasOne(d => d.DeploymentAction).WithMany(p => p.ProcessLogs)
                .HasForeignKey(d => d.DeploymentActionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DeploymentResults_StepAction");

            entity.HasOne(d => d.DeploymentCategory).WithMany(p => p.ProcessLogs)
                .HasForeignKey(d => d.DeploymentCategoryId)
                .HasConstraintName("FK_ProcessLog_DeploymentCategory");

            entity.HasOne(d => d.DeploymentStep).WithMany(p => p.ProcessLogs)
                .HasForeignKey(d => d.DeploymentStepId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DeploymentResults_DeploymentSteps");

            entity.HasOne(d => d.MessageCategory).WithMany(p => p.ProcessLogs)
                .HasForeignKey(d => d.MessageCategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DeploymentResults_MessageCategories");

            entity.HasOne(d => d.MessageType).WithMany(p => p.ProcessLogs)
                .HasForeignKey(d => d.MessageTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DeploymentResults_MessageType");
        });

        modelBuilder.Entity<ProductProperty>(entity =>
        {
            entity.ToTable("ProductProperty", "Segregation");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ProductTypeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PropertyName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ProductType>(entity =>
        {
            entity.ToTable("ProductTypes", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<PullListLocation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_PullListLocations");

            entity.ToTable("PullListLocation", "Maintenance");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.LastMaintenance).HasColumnType("datetime");
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LookBackEnd).HasColumnType("datetime");
            entity.Property(e => e.LookBackStart).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Reason).HasMaxLength(250);
        });

        modelBuilder.Entity<QuantityType>(entity =>
        {
            entity.ToTable("QuantityType", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<ReallocatedCartonRequest>(entity =>
        {
            entity.HasKey(e => e.RecordNumber).HasName("PK_Outbound_ReallocatedCartonRequests_RecordNumber");

            entity.ToTable("ReallocatedCartonRequests", "Outbound");

            entity.HasIndex(e => e.ReallocatedCartonRequestsId, "IX_Outbound_ReallocatedCartonRequestsID");

            entity.Property(e => e.ReallocatedCartonRequestsId).HasColumnName("ReallocatedCartonRequestsID");
            entity.Property(e => e.ReallocationDateTime).HasDefaultValueSql("(sysdatetimeoffset())");
        });

        modelBuilder.Entity<ReconTypeAction>(entity =>
        {
            entity.ToTable("ReconTypeAction", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<ReducedSurface>(entity =>
        {
            entity.ToTable("ReducedSurface", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<RelativeOrientation>(entity =>
        {
            entity.ToTable("RelativeOrientation", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RemovedCarton>(entity =>
        {
            entity.HasKey(e => e.CartonId).HasName("PK_RemovedCartons_ID");

            entity.ToTable("RemovedCartons", "Inventory");

            entity.Property(e => e.CartonId)
                .ValueGeneratedNever()
                .HasColumnName("CartonID");
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getutcdate())");

            entity.HasOne(d => d.Carton).WithOne(p => p.RemovedCarton)
                .HasForeignKey<RemovedCarton>(d => d.CartonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RemovedCartons_ID");
        });

        modelBuilder.Entity<ReplenishmentPriority>(entity =>
        {
            entity.ToTable("ReplenishmentPriority", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<ReplenishmentRequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ReplenishmentRequest");

            entity.ToTable("ReplenishmentRequests", "Inbound", tb => tb.HasTrigger("trg_ReplenishmentRequests_Delete"));

            entity.HasIndex(e => new { e.SkuId, e.Deadline, e.ReplenishmentPriority }, "IDX_FK_ReplenishmentRequest_Sku");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedDate).HasPrecision(0);
            entity.Property(e => e.Deadline).HasPrecision(0);
        });

        modelBuilder.Entity<ReplenishmentRequestsHistory>(entity =>
        {
            entity.HasKey(e => e.ReplenishmentReqHistorySk);

            entity.ToTable("ReplenishmentRequestsHistory", "Inbound");

            entity.Property(e => e.ReplenishmentReqHistorySk).HasColumnName("ReplenishmentReqHistorySK");
            entity.Property(e => e.CreatedDate).HasPrecision(0);
            entity.Property(e => e.Deadline).HasPrecision(0);
            entity.Property(e => e.HistoryCreatedDate)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysdatetimeoffset())");
        });

        modelBuilder.Entity<ReplenishmentRequestsHistoryWork>(entity =>
        {
            entity.HasKey(e => e.ReplenishmentReqHistorySk);

            entity.ToTable("ReplenishmentRequestsHistoryWork", "Staging");

            entity.Property(e => e.ReplenishmentReqHistorySk)
                .ValueGeneratedNever()
                .HasColumnName("ReplenishmentReqHistorySK");
        });

        modelBuilder.Entity<ReplenishmentTask>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ReplenishmentTask");

            entity.ToTable("ReplenishmentTasks", "Inbound");

            entity.HasIndex(e => e.Id, "IDX_FK_ReplenishmentTask_Id");

            entity.HasIndex(e => e.SkuId, "IDX_FK_SkuId");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Deadline).HasPrecision(0);
            entity.Property(e => e.EndTime).HasPrecision(3);
            entity.Property(e => e.Location)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.OperatorName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Plant)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StartTime).HasPrecision(3);
            entity.Property(e => e.TimeRequestLastAssigned).HasPrecision(3);

            entity.HasOne(d => d.OutboundPallet).WithMany(p => p.ReplenishmentTasks)
                .HasForeignKey(d => d.OutboundPalletId)
                .HasConstraintName("FK_ReplenishmentTasks_OutboundPallets");

            entity.HasOne(d => d.TaskPriorityNavigation).WithMany(p => p.ReplenishmentTasks)
                .HasForeignKey(d => d.TaskPriority)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReplenishmentTasks_TaskPriority");

            entity.HasOne(d => d.TaskStateNavigation).WithMany(p => p.ReplenishmentTasks)
                .HasForeignKey(d => d.TaskState)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReplenishmentTasks_TaskState");
        });

        modelBuilder.Entity<ReplenishmentTaskState>(entity =>
        {
            entity.ToTable("ReplenishmentTaskState", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<ResetShelfDetailLog>(entity =>
        {
            entity.ToTable("ResetShelfDetailLog", "Inventory");

            entity.HasIndex(e => e.CartonId, "IDX_ResetShelfDetailLog_CartonId");

            entity.HasIndex(e => e.ResetShelfLogId, "IDX_ResetShelfDetailLog_ResetShelfLogId");

            entity.Property(e => e.Action)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CustomerCartonGroupRef)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IsSuspect).HasComputedColumnSql("(CONVERT([bit],case when [SuspectTime] IS NOT NULL AND [SuspectClearTime] IS NULL OR [SuspectTime]>[SuspectClearTime] then (1) else (0) end))", true);
            entity.Property(e => e.ShelfLocationCartonOffsetX).HasColumnName("ShelfLocation_CartonOffsetX");
            entity.Property(e => e.ShelfLocationCartonOffsetY).HasColumnName("ShelfLocation_CartonOffsetY");
            entity.Property(e => e.ShelfLocationOffsetX).HasColumnName("ShelfLocation_OffsetX");
            entity.Property(e => e.ShelfLocationOffsetY).HasColumnName("ShelfLocation_OffsetY");
            entity.Property(e => e.ShelfLocationWidth).HasColumnName("ShelfLocation_Width");
        });

        modelBuilder.Entity<ResetShelfLog>(entity =>
        {
            entity.ToTable("ResetShelfLog", "Inventory");

            entity.HasIndex(e => e.ShelfId, "IDX_ResetShelfLog_ShelfId");
        });

        modelBuilder.Entity<Resolution>(entity =>
        {
            entity.ToTable("Resolutions", "Maintenance");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CreatedByUserName).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(25);

            entity.HasOne(d => d.AssetTypeNavigation).WithMany(p => p.Resolutions)
                .HasForeignKey(d => d.AssetType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Resolutions_AssetType");
        });

        modelBuilder.Entity<ResourceType>(entity =>
        {
            entity.ToTable("ResourceType", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<RobotConfigurationProfile>(entity =>
        {
            entity.ToTable("RobotConfigurationProfiles", "Sku");

            entity.HasIndex(e => e.Name, "UC_SkuRobotConfigurationProfilesName").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedDate)
                .HasPrecision(3)
                .HasDefaultValueSql("(sysdatetimeoffset())");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DisplayName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.IsDefault).HasDefaultValue(false);
            entity.Property(e => e.ModifiedDate)
                .HasPrecision(3)
                .HasDefaultValueSql("(sysdatetimeoffset())");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Profile).HasColumnType("xml");
        });

        modelBuilder.Entity<RobotConfigurationProfile1>(entity =>
        {
            entity.HasKey(e => e.RecordNumber).HasName("PK_RobotConfigurationProfiles_1");

            entity.ToTable("RobotConfigurationProfiles", "Staging");

            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DisplayName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DisplayOrder).HasDefaultValue(0);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Profile).HasColumnType("xml");
        });

        modelBuilder.Entity<RuleModel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_RuleModel_Id");

            entity.ToTable("RuleModel", "Segregation");

            entity.Property(e => e.ExpectedValue)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Property).WithMany(p => p.RuleModels)
                .HasForeignKey(d => d.PropertyId)
                .HasConstraintName("FK_RuleModel_ProductRule");

            entity.HasOne(d => d.RuleSet).WithMany(p => p.RuleModels)
                .HasForeignKey(d => d.RuleSetId)
                .HasConstraintName("FK_RuleModel_RuleSet");

            entity.HasOne(d => d.RuleType).WithMany(p => p.RuleModels)
                .HasForeignKey(d => d.RuleTypeId)
                .HasConstraintName("FK_RuleModel_ModelType");
        });

        modelBuilder.Entity<RuleSet>(entity =>
        {
            entity.ToTable("RuleSet", "Segregation");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.SegregationZoneType).WithMany(p => p.RuleSets)
                .HasForeignKey(d => d.SegregationZoneTypeId)
                .HasConstraintName("FK_RuleSet_ZoneType");
        });

        modelBuilder.Entity<RuleType>(entity =>
        {
            entity.ToTable("RuleType", "Segregation");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SafetyZone>(entity =>
        {
            entity.ToTable("SafetyZones", "Staging");

            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.ZoneTypeName).HasMaxLength(100);
        });

        modelBuilder.Entity<SafetyZoneToLevelMap>(entity =>
        {
            entity.ToTable("SafetyZoneToLevelMap", "Staging");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Scanner>(entity =>
        {
            entity.ToTable("Scanners", "Staging");

            entity.Property(e => e.CanPrintRejectLabels).HasDefaultValue(false);
            entity.Property(e => e.CanReject).HasDefaultValue(true);
            entity.Property(e => e.EndpointId).HasMaxLength(50);
            entity.Property(e => e.ProvidesDimensions).HasDefaultValue(false);
            entity.Property(e => e.ProvidesWeight).HasDefaultValue(true);
        });

        modelBuilder.Entity<Scanner1>(entity =>
        {
            entity.ToTable("Scanners", "Structure");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.Scanner1)
                .HasForeignKey<Scanner1>(d => d.Id)
                .HasConstraintName("FK_Scanners_Endpoint");
        });

        modelBuilder.Entity<ScannerType>(entity =>
        {
            entity.ToTable("ScannerType", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<ScheduledShift>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ScheduledShiftID");

            entity.ToTable("ScheduledShifts", "Shift");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.HasOne(d => d.ShiftStartDayOfWeekNavigation).WithMany(p => p.ScheduledShifts)
                .HasForeignKey(d => d.ShiftStartDayOfWeek)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ScheduledShifts_ShiftDayOfWeek");
        });

        modelBuilder.Entity<ScratchReason>(entity =>
        {
            entity.ToTable("ScratchReason", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<ScreenedProcess>(entity =>
        {
            entity.HasKey(e => e.ScreenedProcessSk).HasName("PK_SupportScreenedProcessesSK");

            entity.ToTable("ScreenedProcesses", "Support");

            entity.HasIndex(e => new { e.ExecutionDateTime, e.SessionId }, "IX_Support_ScreenedProcess_ExecTime").IsUnique();

            entity.Property(e => e.ScreenedProcessSk).HasColumnName("ScreenedProcessSK");
            entity.Property(e => e.Dbname)
                .HasMaxLength(128)
                .HasColumnName("DBName");
            entity.Property(e => e.ExecutionDateTime).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.HostName).HasMaxLength(128);
            entity.Property(e => e.LoginName).HasMaxLength(128);
            entity.Property(e => e.ProgramName).HasMaxLength(128);
            entity.Property(e => e.SessionId).HasColumnName("SessionID");
            entity.Property(e => e.TransactionBeginTime).HasColumnType("datetime");
            entity.Property(e => e.TransactionId).HasColumnName("TransactionID");
        });

        modelBuilder.Entity<SecurityStatement>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SecurityStatements", "Metadata");

            entity.Property(e => e.Sqltext)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("SQLText");
        });

        modelBuilder.Entity<SegregationBayModel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Staging_SegregationBayModel");

            entity.ToTable("SegregationBayModel", "Staging");

            entity.Property(e => e.Side)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SegregationRuleModel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Staging_SegregationRuleModel");

            entity.ToTable("SegregationRuleModel", "Staging");

            entity.Property(e => e.ExpectedValue)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Property)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SegregationRuleSet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Staging_SegregatioRuleSet");

            entity.ToTable("SegregationRuleSet", "Staging");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SegregationZoneType)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SegregationZone>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Staging_SegregationZone");

            entity.ToTable("SegregationZone", "Staging");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SegregationZoneProductType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_SegregationZoneProducType");

            entity.ToTable("SegregationZoneProductType", "Staging");

            entity.Property(e => e.ProductType)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SegregationZoneRuleSet>(entity =>
        {
            entity.ToTable("SegregationZoneRuleSet", "Staging");
        });

        modelBuilder.Entity<SelectedCustomerCartonRef>(entity =>
        {
            entity.ToTable("SelectedCustomerCartonRefs", "Outbound");

            entity.HasIndex(e => new { e.CartonRequestId, e.CustomerCartonRef }, "UQX_SelectedCustomerCartonRefs").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CustomerCartonRef)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.HasOne(d => d.CartonRequest).WithMany(p => p.SelectedCustomerCartonRefs)
                .HasForeignKey(d => d.CartonRequestId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SelectedCustomerCartonRefs_CartonRequest");
        });

        modelBuilder.Entity<SequencedDestinationCategory>(entity =>
        {
            entity.ToTable("SequencedDestinationCategories", "Staging");

            entity.Property(e => e.DestinationCategoryId)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ServiceEndpoint>(entity =>
        {
            entity.ToTable("ServiceEndpoints", "Staging");

            entity.Property(e => e.Address)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Contract)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SubSystemId)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ShakeAndSealLoad>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ShakeAndSeal");

            entity.ToTable("ShakeAndSealLoads", "Inventory", tb => tb.HasTrigger("trg_ShakeAndSealLoads_Update"));

            entity.HasIndex(e => e.CartonId, "IDX_Inventory_ShakeAndSeal_CartonId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CustomerCartonGroupRef)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IsSuspect).HasComputedColumnSql("(CONVERT([bit],case when [SuspectTime] IS NOT NULL AND [SuspectClearTime] IS NULL OR [SuspectTime]>[SuspectClearTime] then (1) else (0) end))", true);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.HasOne(d => d.Carton).WithMany(p => p.ShakeAndSealLoads)
                .HasForeignKey(d => d.CartonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ShakeAndSeal_Carton");

            entity.HasOne(d => d.DropOffTransferBuffer).WithMany(p => p.ShakeAndSealLoads)
                .HasForeignKey(d => d.DropOffTransferBufferId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ShakeAndSeal_UnloadTransferBufferId");
        });

        modelBuilder.Entity<ShakeAndSealLoadsTombstone>(entity =>
        {
            entity.HasKey(e => e.ShakeAndSealLoadsTombstoneSk);

            entity.ToTable("ShakeAndSealLoadsTombstone", "Inventory");

            entity.Property(e => e.ShakeAndSealLoadsTombstoneSk).HasColumnName("ShakeAndSealLoadsTombstoneSK");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CustomerCartonGroupRef)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.TombstoneDate).HasDefaultValueSql("(getutcdate())");
        });

        modelBuilder.Entity<Shelf>(entity =>
        {
            entity.ToTable("Shelves", "Staging");

            entity.HasIndex(e => new { e.AisleId, e.BayId, e.LevelMapModelId, e.Side, e.Name }, "IX_StgShelves_CoveringImportValidation");

            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Shelf1>(entity =>
        {
            entity.ToTable("Shelves", "Structure");

            entity.HasIndex(e => e.BayId, "IDX_Shelves_BayId");

            entity.HasIndex(e => e.ResourceName, "UC_ShelfResourceName")
                .IsUnique()
                .HasFilter("([ResourceName] IS NOT NULL)");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.ResourceName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Bay).WithMany(p => p.Shelf1s)
                .HasForeignKey(d => d.BayId)
                .HasConstraintName("FK_Shelves_Bay");

            entity.HasOne(d => d.ShelfSideNavigation).WithMany(p => p.Shelf1s)
                .HasForeignKey(d => d.ShelfSide)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Shelves_ShelfSide");
        });

        modelBuilder.Entity<ShelfDictionary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ShelfDictionary", "Structure");

            entity.Property(e => e.HashString)
                .HasMaxLength(54)
                .IsUnicode(false);
            entity.Property(e => e.ShelfId).HasColumnName("ShelfID");
        });

        modelBuilder.Entity<ShelfModule>(entity =>
        {
            entity.ToTable("ShelfModules", "Staging");
        });

        modelBuilder.Entity<ShelfScan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ShelfScan");

            entity.ToTable("ShelfScans", "Structure", tb => tb.HasTrigger("trg_ShelfScans_Insert"));

            entity.HasIndex(e => e.ShelfId, "IDX_FK_ShelfScan_Shelf");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.HasOne(d => d.Shelf).WithMany(p => p.ShelfScans)
                .HasForeignKey(d => d.ShelfId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ShelfScan_Shelf");
        });

        modelBuilder.Entity<ShelfScansTombstone>(entity =>
        {
            entity.HasKey(e => e.ShelfScansTombstoneSk);

            entity.ToTable("ShelfScansTombstone", "Structure");

            entity.Property(e => e.ShelfScansTombstoneSk).HasColumnName("ShelfScansTombstoneSK");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.TombstoneDate).HasDefaultValueSql("(getutcdate())");
        });

        modelBuilder.Entity<ShelfState>(entity =>
        {
            entity.ToTable("ShelfState", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<ShelveState>(entity =>
        {
            entity.ToTable("ShelveStates", "Structure", tb => tb.HasTrigger("trg_ShelfStates_Update"));

            entity.HasIndex(e => e.StateReasonId, "IDX_FK_ShelveStates_StrucStateReason");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.StateChangeDateTime).HasDefaultValueSql("(sysdatetimeoffset())");
            entity.Property(e => e.StateNote)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.ShelveState)
                .HasForeignKey<ShelveState>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ShelveStates_Shelves");

            entity.HasOne(d => d.StateNavigation).WithMany(p => p.ShelveStates)
                .HasForeignKey(d => d.State)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ShelveStates_ShelfState");

            entity.HasOne(d => d.StateReason).WithMany(p => p.ShelveStates)
                .HasForeignKey(d => d.StateReasonId)
                .HasConstraintName("FK_ShelveStates_StrucStateReason");
        });

        modelBuilder.Entity<ShelveStateHistory>(entity =>
        {
            entity.HasKey(e => e.ShelfStateHistorySk).HasName("PK_CartonsHistorySK");

            entity.ToTable("ShelveStateHistory", "Structure");

            entity.Property(e => e.ShelfStateHistorySk).HasColumnName("ShelfStateHistorySK");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.HistoryCreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(left(suser_name(),(25)))");
            entity.Property(e => e.HistoryCreatedDate).HasDefaultValueSql("(sysdatetimeoffset())");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.StateNote)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ToDate).HasDefaultValueSql("(sysdatetimeoffset())");
        });

        modelBuilder.Entity<Shift>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Shift");

            entity.ToTable("Shifts", "Shift");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.HasOne(d => d.ShiftStateNavigation).WithMany(p => p.Shifts)
                .HasForeignKey(d => d.ShiftState)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Shifts_ShiftState");
        });

        modelBuilder.Entity<ShiftDayOfWeek>(entity =>
        {
            entity.ToTable("ShiftDayOfWeek", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<ShiftState>(entity =>
        {
            entity.ToTable("ShiftState", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<Side>(entity =>
        {
            entity.ToTable("Sides", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<Sku>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Sku");

            entity.ToTable("Skus", "Sku", tb => tb.HasTrigger("trg_Skus_Update"));

            entity.HasIndex(e => e.AllergenTypeId, "IDX_FK_Sku_AllergenType");

            entity.HasIndex(e => e.PackagingTypeId, "IDX_FK_Sku_PackagingType");

            entity.HasIndex(e => e.PalletizationGroupTypeId, "IDX_FK_Sku_PalletizationGroupType");

            entity.HasIndex(e => new { e.IsTaught, e.IsBreakPackEligible }, "IDX_IsTaught_IsBreakPackEligible");

            entity.HasIndex(e => new { e.Id, e.HoldState }, "IDX_Sku_Skus_HoldState");

            entity.HasIndex(e => e.Sku1, "UC_Sku_Sku").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Description).HasMaxLength(1024);
            entity.Property(e => e.IsBreakPackEligible).HasComputedColumnSql("(coalesce([IsBreakPackEligibleOverride],[IsBreakPackEligibleCustomer],CONVERT([bit],(0))))", true);
            entity.Property(e => e.IsProblemUpc).HasColumnName("IsProblemUPC");
            entity.Property(e => e.IsUpcavailable)
                .HasDefaultValue(true)
                .HasColumnName("IsUPCAvailable");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.PackagingTypeId).HasDefaultValue(-1);
            entity.Property(e => e.PalletizationGroupTypeId).HasDefaultValue(-1);
            entity.Property(e => e.Sku1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SKU");
            entity.Property(e => e.Ssp).HasColumnName("SSP");
            entity.Property(e => e.Upc)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Vcp).HasColumnName("VCP");

            entity.HasOne(d => d.AllergenType).WithMany(p => p.Skus)
                .HasForeignKey(d => d.AllergenTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Sku_AllergenType");

            entity.HasOne(d => d.BreakPackEligibleNavigation).WithMany(p => p.Skus)
                .HasForeignKey(d => d.BreakPackEligible)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Skus_BreakPackEligible");

            entity.HasOne(d => d.HoldStateNavigation).WithMany(p => p.Skus)
                .HasForeignKey(d => d.HoldState)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Skus_HoldState");

            entity.HasOne(d => d.LeadEdgeOrientationNavigation).WithMany(p => p.Skus)
                .HasForeignKey(d => d.LeadEdgeOrientation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Skus_LeadEdgeOrientation");

            entity.HasOne(d => d.PackagingType).WithMany(p => p.Skus)
                .HasForeignKey(d => d.PackagingTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Skus_PackagingType");

            entity.HasOne(d => d.PalletizationGroupType).WithMany(p => p.Skus)
                .HasForeignKey(d => d.PalletizationGroupTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Skus_PalletizationGroupType");

            entity.HasOne(d => d.ProductTypesNavigation).WithMany(p => p.Skus)
                .HasForeignKey(d => d.ProductTypes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Skus_ProductTypes");

            entity.HasOne(d => d.SegregationZone).WithMany(p => p.Skus)
                .HasForeignKey(d => d.SegregationZoneId)
                .HasConstraintName("FK_Skus_SegregationZoneId");

            entity.HasOne(d => d.SlottedStateNavigation).WithMany(p => p.Skus)
                .HasForeignKey(d => d.SlottedState)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Skus_SlottedState");

            entity.HasMany(d => d.Upcs).WithMany(p => p.Skus)
                .UsingEntity<Dictionary<string, object>>(
                    "SkusUpc",
                    r => r.HasOne<Upc>().WithMany()
                        .HasForeignKey("UpcId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_SkusUpcs_Upc"),
                    l => l.HasOne<Sku>().WithMany()
                        .HasForeignKey("SkuId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_SkusUpcs_Sku"),
                    j =>
                    {
                        j.HasKey("SkuId", "UpcId");
                        j.ToTable("SkusUpcs", "Sku");
                        j.HasIndex(new[] { "UpcId", "SkuId" }, "IDX_SkusUpcs_UpcSku").IsUnique();
                    });
        });

        modelBuilder.Entity<SkuActivityOutboundDestination>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SkuActivityOutboundDestinations", "Sku");

            entity.Property(e => e.CustomerBatchRef).HasMaxLength(25);
            entity.Property(e => e.DestinationConveyorRef)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DestinationCustomerRef)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DestinationName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OrderNumber)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.Sku)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SKU");
            entity.Property(e => e.SkuName).HasMaxLength(100);
        });

        modelBuilder.Entity<SkuActivityOutboundOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SkuActivityOutboundOrder", "Sku");

            entity.Property(e => e.CustomerBatchRef).HasMaxLength(25);
            entity.Property(e => e.OrderNumber)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.Sku)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SKU");
            entity.Property(e => e.SkuName).HasMaxLength(100);
        });

        modelBuilder.Entity<SkuActivityOutboundPallet>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SkuActivityOutboundPallet", "Sku");

            entity.Property(e => e.CustomerBatchRef).HasMaxLength(25);
            entity.Property(e => e.CustomerPalletNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Lpn)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LPN");
            entity.Property(e => e.OrderNumber)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.Sku)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SKU");
            entity.Property(e => e.SkuName).HasMaxLength(100);
        });

        modelBuilder.Entity<SkuExtension>(entity =>
        {
            entity.ToTable("SkuExtension", "Sku");

            entity.HasIndex(e => new { e.SkuId, e.ExtensionKeyId }, "UQX_SkuExtension_SkuId_ExtensionKeyId").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("(left(suser_name(),(25)))");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(sysutcdatetime())")
                .HasColumnType("datetime");
            entity.Property(e => e.ExtensionValue).HasMaxLength(2000);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("(left(suser_name(),(25)))");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(sysutcdatetime())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.ExtensionKey).WithMany(p => p.SkuExtensions)
                .HasForeignKey(d => d.ExtensionKeyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SkuExtension_SkuExtensionKey");

            entity.HasOne(d => d.Sku).WithMany(p => p.SkuExtensions)
                .HasForeignKey(d => d.SkuId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Sku_SkuId");
        });

        modelBuilder.Entity<SkuExtensionKey>(entity =>
        {
            entity.ToTable("SkuExtensionKey", "Extension");

            entity.HasIndex(e => e.Name, "UQX_SkuExtensionKeyName").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(sysdatetimeoffset())");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(sysdatetimeoffset())");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SkuExtensionsTemp>(entity =>
        {
            entity.ToTable("SkuExtensionsTemp", "Sku");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ExtensionValue).HasMaxLength(2000);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SkuStringTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SkuStringTemp", "Sku");

            entity.HasIndex(e => e.Skustring, "PK_SkuStringTemp")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.Skustring)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SKUString");
        });

        modelBuilder.Entity<SkuSubstitution>(entity =>
        {
            entity.HasKey(e => e.SourceSkuId);

            entity.ToTable("SkuSubstitution", "Sku");

            entity.HasIndex(e => e.SubstituteSkuId, "IX_SkuSkuSubstitution_SubSkuID");

            entity.Property(e => e.SourceSkuId).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.HasOne(d => d.SourceSku).WithOne(p => p.SkuSubstitutionSourceSku)
                .HasForeignKey<SkuSubstitution>(d => d.SourceSkuId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Sku_SourceSku");

            entity.HasOne(d => d.SubstituteSku).WithMany(p => p.SkuSubstitutionSubstituteSkus)
                .HasForeignKey(d => d.SubstituteSkuId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Sku_SubstituteSku");
        });

        modelBuilder.Entity<SkusExtensionDataHistory>(entity =>
        {
            entity.HasKey(e => e.SkuExtensionDataHistorySk);

            entity.ToTable("SkusExtensionDataHistory", "Sku");

            entity.Property(e => e.SkuExtensionDataHistorySk).HasColumnName("SkuExtensionDataHistorySK");
            entity.Property(e => e.Color)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Description2)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Fhscode).HasColumnName("FHSCode");
            entity.Property(e => e.HistoryDate).HasDefaultValueSql("(sysdatetimeoffset())");
            entity.Property(e => e.ItemSize)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ItemUpc)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ItemUPC");
            entity.Property(e => e.MaterialType)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.VendorName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.VendorStockNo)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SkusExtensionDataWork>(entity =>
        {
            entity.HasKey(e => e.StagingSkusExtensionDataWorkSk)
                .HasName("PK_StagingSkusExtensionDataWork")
                .IsClustered(false);

            entity.ToTable("SkusExtensionDataWork", "Staging");

            entity.HasIndex(e => e.Id, "UIX_StagingSkusExtensionDataWork_ID")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.StagingSkusExtensionDataWorkSk).HasColumnName("StagingSkusExtensionDataWorkSK");
            entity.Property(e => e.Color)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Description2)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Fhscode).HasColumnName("FHSCode");
            entity.Property(e => e.IsUpdate).HasColumnName("isUpdate");
            entity.Property(e => e.ItemSize)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ItemUpc)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ItemUPC");
            entity.Property(e => e.MaterialType)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RowCheckSum).HasComment("This CHECKSUM is calculated based on selected columns, while inserting from Sku.SkusTemp, used to detect changes against existing data in Sku.SkusExtensionData .");
            entity.Property(e => e.VendorName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.VendorStockNo)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SkusExtensionDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Sku.SkusExtensionData");

            entity.ToTable("SkusExtensionData", "Sku", tb => tb.HasTrigger("trg_SkuExtData_Update"));

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Color)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Description2)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Fhscode).HasColumnName("FHSCode");
            entity.Property(e => e.ItemSize)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ItemUpc)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ItemUPC");
            entity.Property(e => e.MaterialType)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.VendorName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.VendorStockNo)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.SkusExtensionDatum)
                .HasForeignKey<SkusExtensionDatum>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SkusExtensionData_Skus");
        });

        modelBuilder.Entity<SkusHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SkusHistory", "Sku");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Description).HasMaxLength(1024);
            entity.Property(e => e.IsProblemUpc).HasColumnName("IsProblemUPC");
            entity.Property(e => e.IsUpcavailable).HasColumnName("IsUPCAvailable");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Sku)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SKU");
            entity.Property(e => e.Ssp).HasColumnName("SSP");
            entity.Property(e => e.Upc)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Vcp).HasColumnName("VCP");
        });

        modelBuilder.Entity<SkusHoldStateBackup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SkusHoldStateBackup", "Support");

            entity.Property(e => e.Sku)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SkusTemp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_SkuTemp");

            entity.ToTable("SkusTemp", "Sku");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.AllergenTypeId).HasDefaultValue(0);
            entity.Property(e => e.Color)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Description).HasMaxLength(1024);
            entity.Property(e => e.Description2)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Fhscode).HasColumnName("FHSCode");
            entity.Property(e => e.IsProblemUpc).HasColumnName("IsProblemUPC");
            entity.Property(e => e.IsUpcavailable)
                .HasDefaultValue(true)
                .HasColumnName("IsUPCAvailable");
            entity.Property(e => e.ItemSize)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ItemUpc)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ItemUPC");
            entity.Property(e => e.MaterialType)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.OriginalRequest).HasMaxLength(2250);
            entity.Property(e => e.PalletizationGroupTypeId).HasDefaultValue(-1);
            entity.Property(e => e.Sku)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SKU");
            entity.Property(e => e.Ssp).HasColumnName("SSP");
            entity.Property(e => e.Upc)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Vcp).HasColumnName("VCP");
            entity.Property(e => e.VendorName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.VendorStockNo)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SkusTemp1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_StagingSkusTemp");

            entity.ToTable("SkusTemp", "Staging");

            entity.HasIndex(e => e.Sku, "UIX_StagingSkusTemp_SKU").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Color)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Description).HasMaxLength(1024);
            entity.Property(e => e.Description2)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Fhscode).HasColumnName("FHSCode");
            entity.Property(e => e.IsProblemUpc).HasColumnName("IsProblemUPC");
            entity.Property(e => e.IsUpcavailable)
                .HasDefaultValue(true)
                .HasColumnName("IsUPCAvailable");
            entity.Property(e => e.ItemSize)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ItemUpc)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ItemUPC");
            entity.Property(e => e.MaterialType)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.OriginalRequest).HasMaxLength(2250);
            entity.Property(e => e.PackagingTypeId).HasDefaultValue(-1);
            entity.Property(e => e.PalletizationGroupTypeId).HasDefaultValue(-1);
            entity.Property(e => e.Sku)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SKU");
            entity.Property(e => e.Ssp).HasColumnName("SSP");
            entity.Property(e => e.Upc)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Vcp).HasColumnName("VCP");
            entity.Property(e => e.VendorName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.VendorStockNo)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SkusUpcsTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SkusUpcsTemp", "Sku");
        });

        modelBuilder.Entity<SkusWithExtensionDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SkusWithExtensionData", "Sku");

            entity.Property(e => e.Color)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Description).HasMaxLength(1024);
            entity.Property(e => e.Description2)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Fhscode).HasColumnName("FHSCode");
            entity.Property(e => e.IsProblemUpc).HasColumnName("IsProblemUPC");
            entity.Property(e => e.IsUpcavailable).HasColumnName("IsUPCAvailable");
            entity.Property(e => e.ItemSize)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ItemUpc)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ItemUPC");
            entity.Property(e => e.MaterialType)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Sku)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SKU");
            entity.Property(e => e.Ssp).HasColumnName("SSP");
            entity.Property(e => e.Upc)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Vcp).HasColumnName("VCP");
            entity.Property(e => e.VendorName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.VendorStockNo)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SkusWorkUpdate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Staging_SkuWorkUpdate");

            entity.ToTable("SkusWorkUpdate", "Staging");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<SlottedState>(entity =>
        {
            entity.ToTable("SlottedState", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<StartupScriptsLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Id");

            entity.ToTable("StartupScriptsLog", "Support");

            entity.Property(e => e.Action)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.ExecutedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ExecutionStatus).HasDefaultValue(0);
            entity.Property(e => e.StartupSpname)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("StartupSPName");
        });

        modelBuilder.Entity<StartupStoredProceduresList>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_StgStartupStoredProceduresList");

            entity.ToTable("StartupStoredProceduresList", "Staging");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DisplayName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<StartupStoredProceduresList1>(entity =>
        {
            entity.ToTable("StartupStoredProceduresList", "Startup");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(sysdatetimeoffset())");
            entity.Property(e => e.Description)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.DisplayName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(sysdatetimeoffset())");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<StgAlertItemWork>(entity =>
        {
            entity.HasKey(e => e.AlertItemId).HasName("PK_StgAlertItemWork_AlertItemID");

            entity.ToTable("StgAlertItemWork", "Purge");

            entity.Property(e => e.AlertItemId)
                .ValueGeneratedNever()
                .HasColumnName("AlertItemID");
        });

        modelBuilder.Entity<StgAlertLogsWork>(entity =>
        {
            entity.HasKey(e => e.AlertLogId).HasName("PK_StgAlertLogsWork_AlertLogID");

            entity.ToTable("StgAlertLogsWork", "Purge");

            entity.Property(e => e.AlertLogId)
                .ValueGeneratedNever()
                .HasColumnName("AlertLogID");
        });

        modelBuilder.Entity<StgAuditTrailLogsWork>(entity =>
        {
            entity.HasKey(e => e.AuditTrailLogsId);

            entity.ToTable("StgAuditTrailLogsWork", "Purge");

            entity.Property(e => e.AuditTrailLogsId)
                .ValueGeneratedNever()
                .HasColumnName("AuditTrailLogsID");
        });

        modelBuilder.Entity<StgCartonRequestsWork>(entity =>
        {
            entity.HasKey(e => e.CartonRequestId);

            entity.ToTable("StgCartonRequestsWork", "Purge");

            entity.Property(e => e.CartonRequestId).ValueGeneratedNever();
        });

        modelBuilder.Entity<StgCartonsWork>(entity =>
        {
            entity.HasKey(e => e.CartonId).HasName("PK_StgCartonsWork_CartonID");

            entity.ToTable("StgCartonsWork", "Purge");

            entity.Property(e => e.CartonId)
                .ValueGeneratedNever()
                .HasColumnName("CartonID");
        });

        modelBuilder.Entity<StgLabelBaseWork>(entity =>
        {
            entity.HasKey(e => e.LabelBaseId);

            entity.ToTable("StgLabelBaseWork", "Purge");

            entity.Property(e => e.LabelBaseId)
                .ValueGeneratedNever()
                .HasColumnName("LabelBaseID");
        });

        modelBuilder.Entity<StgOrdersWork>(entity =>
        {
            entity.HasKey(e => e.OrderBatchId).HasName("PK_StgOrdersWork_OrderBatchID");

            entity.ToTable("StgOrdersWork", "Purge");

            entity.Property(e => e.OrderBatchId)
                .ValueGeneratedNever()
                .HasColumnName("OrderBatchID");
        });

        modelBuilder.Entity<StgReplenishmentRequestsHistoryWork>(entity =>
        {
            entity.HasKey(e => e.ReplenishmentReqHistorySk);

            entity.ToTable("StgReplenishmentRequestsHistoryWork", "Purge");

            entity.Property(e => e.ReplenishmentReqHistorySk)
                .ValueGeneratedNever()
                .HasColumnName("ReplenishmentReqHistorySK");
        });

        modelBuilder.Entity<StgShakeAndSealLoadsTombstone>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_StgShakeAndSealLoadsTombstone_Id");

            entity.ToTable("StgShakeAndSealLoadsTombstone", "Purge");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<StgSkusWork>(entity =>
        {
            entity.HasKey(e => e.SkuId).HasName("PK_StgSkusWork_SkuID");

            entity.ToTable("StgSkusWork", "Purge");

            entity.Property(e => e.SkuId)
                .ValueGeneratedNever()
                .HasColumnName("SkuID");
        });

        modelBuilder.Entity<StgSkusWorkUpdate>(entity =>
        {
            entity.ToTable("StgSkusWorkUpdate", "Purge");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<StgTaskPlanCartonsTombstoneWork>(entity =>
        {
            entity.HasKey(e => e.TaskPlanCtnsTombstoneSk).HasName("PK_StgTaskPlanCartonsTombstoneWork_TaskPlanCtnsTombstoneSK");

            entity.ToTable("StgTaskPlanCartonsTombstoneWork", "Purge");

            entity.Property(e => e.TaskPlanCtnsTombstoneSk)
                .ValueGeneratedNever()
                .HasColumnName("TaskPlanCtnsTombstoneSK");
        });

        modelBuilder.Entity<StructureFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_StructureFiles");

            entity.ToTable("StructureFile", "Staging");

            entity.Property(e => e.ContentXml).HasColumnType("xml");
            entity.Property(e => e.Customer).HasMaxLength(100);
            entity.Property(e => e.FileName).HasMaxLength(200);
            entity.Property(e => e.PackageName).HasMaxLength(200);
            entity.Property(e => e.PackageVersion).HasMaxLength(25);
            entity.Property(e => e.Site).HasMaxLength(100);
            entity.Property(e => e.StructureMapVersion).HasMaxLength(50);
            entity.Property(e => e.SystemMode).HasMaxLength(50);
        });

        modelBuilder.Entity<StructureFile1>(entity =>
        {
            entity.ToTable("StructureFiles", "Structure");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.ContentXml).HasColumnType("xml");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Customer).HasMaxLength(100);
            entity.Property(e => e.FileName).HasMaxLength(200);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.PackageName).HasMaxLength(200);
            entity.Property(e => e.PackageVersion).HasMaxLength(25);
            entity.Property(e => e.Site).HasMaxLength(100);
            entity.Property(e => e.StructureMapVersion).HasMaxLength(50);
            entity.Property(e => e.SystemMode).HasMaxLength(50);
        });

        modelBuilder.Entity<StructureLocation>(entity =>
        {
            entity.ToTable("StructureLocations", "Structure");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(50);

            entity.HasOne(d => d.LocationTypeNavigation).WithMany(p => p.StructureLocations)
                .HasForeignKey(d => d.LocationType)
                .HasConstraintName("FK_StructureLocations_LocationType");
        });

        modelBuilder.Entity<StructureStateReason>(entity =>
        {
            entity.ToTable("StructureStateReason", "Lookups");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(sysdatetimeoffset())");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DisplayName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(sysdatetimeoffset())");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RecordNumber).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<StructureStateReason1>(entity =>
        {
            entity.HasKey(e => e.RecordNumber).HasName("PK_StructureStateReason_1");

            entity.ToTable("StructureStateReasons", "Staging");

            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DisplayName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Subsystem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Subsystem");

            entity.ToTable("Subsystems", "Staging");

            entity.Property(e => e.SubsystemId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SubsystemType)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Subsystem1>(entity =>
        {
            entity.ToTable("Subsystems", "Subsystem");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.DesiredOperationalStatus).HasDefaultValue(1);
            entity.Property(e => e.DesiredServiceStatus).HasDefaultValue(1);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.SubsystemId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SubsystemType)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Version)
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.HasOne(d => d.DesiredOperationalStatusNavigation).WithMany(p => p.Subsystem1s)
                .HasForeignKey(d => d.DesiredOperationalStatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ZoneState_SubsystemOperationalStatus");

            entity.HasOne(d => d.DesiredServiceStatusNavigation).WithMany(p => p.Subsystem1s)
                .HasForeignKey(d => d.DesiredServiceStatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ZoneState_SubsystemServiceStatus");
        });

        modelBuilder.Entity<SubsystemOperationalStatus>(entity =>
        {
            entity.ToTable("SubsystemOperationalStatus", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<SubsystemServiceEndpoint>(entity =>
        {
            entity.ToTable("SubsystemServiceEndpoints", "Subsystem");

            entity.HasIndex(e => e.SubsystemId, "IDX_FK_SubsystemServiceEndpoints_Subsystem");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.Address).IsUnicode(false);
            entity.Property(e => e.Contract).IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.EndpointTypeNavigation).WithMany(p => p.SubsystemServiceEndpoints)
                .HasForeignKey(d => d.EndpointType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SubsystemServiceEndpoints_SubsystemServiceEndpointType");

            entity.HasOne(d => d.Subsystem).WithMany(p => p.SubsystemServiceEndpoints)
                .HasForeignKey(d => d.SubsystemId)
                .HasConstraintName("FK_SubsystemServiceEndpoints_Subsystem");
        });

        modelBuilder.Entity<SubsystemServiceEndpointType>(entity =>
        {
            entity.ToTable("SubsystemServiceEndpointType", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<SubsystemServiceStatus>(entity =>
        {
            entity.ToTable("SubsystemServiceStatus", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<SuspectAction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_SuspsectAction");

            entity.ToTable("SuspectAction", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<SuspectLocationSubState>(entity =>
        {
            entity.ToTable("SuspectLocationSubState", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<SuspectReason>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_SuspsectReason");

            entity.ToTable("SuspectReason", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<SuspectResolution>(entity =>
        {
            entity.ToTable("SuspectResolution", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<SystemResource>(entity =>
        {
            entity.HasKey(e => e.SystemResourcesSk).HasName("PK_Structure_SystemResourcesSK");

            entity.ToTable("SystemResources", "Structure");

            entity.Property(e => e.SystemResourcesSk).HasColumnName("SystemResourcesSK");
            entity.Property(e => e.ApiVersion)
                .HasMaxLength(5)
                .HasDefaultValue("V1");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(sysdatetimeoffset())");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(sysdatetimeoffset())");

            entity.HasOne(d => d.StructureFile).WithMany(p => p.SystemResources)
                .HasForeignKey(d => d.StructureFileId)
                .HasConstraintName("FK_SystemResources_Structure");
        });

        modelBuilder.Entity<TableList>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TableList", "Purge");

            entity.HasIndex(e => e.TableName, "UQ_TableList_TableName").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.TableName)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TableStat>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TableStat", "Purge");

            entity.Property(e => e.DataSizeKb).HasColumnName("DataSizeKB");
            entity.Property(e => e.IndexSizeKb).HasColumnName("IndexSizeKB");
            entity.Property(e => e.ReservedSizeKb).HasColumnName("ReservedSizeKB");
            entity.Property(e => e.RowCount).HasColumnName("Row_Count");
            entity.Property(e => e.SchemaName).HasMaxLength(128);
            entity.Property(e => e.TableName).HasMaxLength(128);
            entity.Property(e => e.TableStatDateTime).HasDefaultValueSql("(sysdatetimeoffset())");
            entity.Property(e => e.TableStatProcessId)
                .HasMaxLength(38)
                .HasColumnName("TableStatProcessID");
            entity.Property(e => e.TableStatSk)
                .ValueGeneratedOnAdd()
                .HasColumnName("TableStatSK");
            entity.Property(e => e.UnusedSizeKb).HasColumnName("UnusedSizeKB");
        });

        modelBuilder.Entity<TaskPlan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TaskPlan");

            entity.ToTable("TaskPlans", "Inventory", tb => tb.HasTrigger("trg_TaskPlan_Update"));

            entity.HasIndex(e => e.LevelId, "IDX_FK_TaskPlan_Level");

            entity.HasIndex(e => e.LoadShelfId, "IDX_FK_TaskPlan_LoadShelf");

            entity.HasIndex(e => e.LoadTransferBufferId, "IDX_FK_TaskPlan_LoadTransferBuffer");

            entity.HasIndex(e => e.UnloadShelfId, "IDX_FK_TaskPlan_UnloadShelf");

            entity.HasIndex(e => e.UnloadTransferBufferId, "IDX_FK_TaskPlan_UnloadTransferBuffer");

            entity.HasIndex(e => e.BotId, "IDX_Inventory_TaskPlans_BotId");

            entity.HasIndex(e => e.Id, "IDX_TaskPlans_SuspectTimes");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CustomerCartonGroupRef)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IsSuspect).HasComputedColumnSql("(CONVERT([bit],case when [SuspectTime] IS NOT NULL AND [SuspectClearTime] IS NULL OR [SuspectTime]>[SuspectClearTime] then (1) else (0) end))", true);
            entity.Property(e => e.LoadShelfLocationCartonOffsetX).HasColumnName("LoadShelfLocation_CartonOffsetX");
            entity.Property(e => e.LoadShelfLocationCartonOffsetY).HasColumnName("LoadShelfLocation_CartonOffsetY");
            entity.Property(e => e.LoadShelfLocationOffsetX).HasColumnName("LoadShelfLocation_OffsetX");
            entity.Property(e => e.LoadShelfLocationOffsetY).HasColumnName("LoadShelfLocation_OffsetY");
            entity.Property(e => e.LoadShelfLocationWidth).HasColumnName("LoadShelfLocation_Width");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.UnloadShelfLocationCartonOffsetX).HasColumnName("UnloadShelfLocation_CartonOffsetX");
            entity.Property(e => e.UnloadShelfLocationCartonOffsetY).HasColumnName("UnloadShelfLocation_CartonOffsetY");
            entity.Property(e => e.UnloadShelfLocationOffsetX).HasColumnName("UnloadShelfLocation_OffsetX");
            entity.Property(e => e.UnloadShelfLocationOffsetY).HasColumnName("UnloadShelfLocation_OffsetY");
            entity.Property(e => e.UnloadShelfLocationWidth).HasColumnName("UnloadShelfLocation_Width");

            entity.HasOne(d => d.Bot).WithMany(p => p.TaskPlans)
                .HasForeignKey(d => d.BotId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TaskPlan_Bot");

            entity.HasOne(d => d.Level).WithMany(p => p.TaskPlans)
                .HasForeignKey(d => d.LevelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TaskPlan_Level");

            entity.HasOne(d => d.LoadShelf).WithMany(p => p.TaskPlanLoadShelves)
                .HasForeignKey(d => d.LoadShelfId)
                .HasConstraintName("FK_TaskPlan_LoadShelf");

            entity.HasOne(d => d.LoadTransferBuffer).WithMany(p => p.TaskPlanLoadTransferBuffers)
                .HasForeignKey(d => d.LoadTransferBufferId)
                .HasConstraintName("FK_TaskPlan_LoadTransferBuffer");

            entity.HasOne(d => d.UnloadShelf).WithMany(p => p.TaskPlanUnloadShelves)
                .HasForeignKey(d => d.UnloadShelfId)
                .HasConstraintName("FK_TaskPlan_UnloadShelf");

            entity.HasOne(d => d.UnloadTransferBuffer).WithMany(p => p.TaskPlanUnloadTransferBuffers)
                .HasForeignKey(d => d.UnloadTransferBufferId)
                .HasConstraintName("FK_TaskPlan_UnloadTransferBuffer");
        });

        modelBuilder.Entity<TaskPlanCarton>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TaskPlanCarton");

            entity.ToTable("TaskPlanCartons", "Inventory");

            entity.HasIndex(e => e.CartonId, "IDX_Inventory_TaskPlanCartons_CartonId");

            entity.HasIndex(e => e.TaskPlanId, "IDX_Inventory_TaskPlanCartons_TaskPlanId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.HasOne(d => d.Carton).WithMany(p => p.TaskPlanCartons)
                .HasForeignKey(d => d.CartonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TaskPlanCarton_Carton");

            entity.HasOne(d => d.TaskPlan).WithMany(p => p.TaskPlanCartons)
                .HasForeignKey(d => d.TaskPlanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TaskPlanCarton_TaskPlan");
        });

        modelBuilder.Entity<TaskPlanCartonsTombstone>(entity =>
        {
            entity.HasKey(e => e.TaskPlanCtnsTombstoneSk).HasName("PK_TaskPlanCartonTombstone");

            entity.ToTable("TaskPlanCartonsTombstone", "Inventory");

            entity.Property(e => e.TaskPlanCtnsTombstoneSk).HasColumnName("TaskPlanCtnsTombstoneSK");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.TombstoneDate).HasDefaultValueSql("(getutcdate())");
        });

        modelBuilder.Entity<TaskPlanCartonsTombstoneWork>(entity =>
        {
            entity.HasKey(e => e.TaskPlanCartonsTombstoneId).HasName("PK_TaskPlanCartonTombstoneWork");

            entity.ToTable("TaskPlanCartonsTombstoneWork", "Staging");

            entity.Property(e => e.TaskPlanCartonsTombstoneId)
                .ValueGeneratedNever()
                .HasColumnName("TaskPlanCartonsTombstoneID");
        });

        modelBuilder.Entity<TaskPlansTombstone>(entity =>
        {
            entity.HasKey(e => e.TaskPlansTombstoneSk).HasName("PK_TaskPlanTombstone");

            entity.ToTable("TaskPlansTombstone", "Inventory");

            entity.Property(e => e.TaskPlansTombstoneSk).HasColumnName("TaskPlansTombstoneSK");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CustomerCartonGroupRef)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LoadShelfLocationCartonOffsetX).HasColumnName("LoadShelfLocation_CartonOffsetX");
            entity.Property(e => e.LoadShelfLocationCartonOffsetY).HasColumnName("LoadShelfLocation_CartonOffsetY");
            entity.Property(e => e.LoadShelfLocationOffsetX).HasColumnName("LoadShelfLocation_OffsetX");
            entity.Property(e => e.LoadShelfLocationOffsetY).HasColumnName("LoadShelfLocation_OffsetY");
            entity.Property(e => e.LoadShelfLocationWidth).HasColumnName("LoadShelfLocation_Width");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.TombstoneDate).HasDefaultValueSql("(getutcdate())");
            entity.Property(e => e.UnloadShelfLocationCartonOffsetX).HasColumnName("UnloadShelfLocation_CartonOffsetX");
            entity.Property(e => e.UnloadShelfLocationCartonOffsetY).HasColumnName("UnloadShelfLocation_CartonOffsetY");
            entity.Property(e => e.UnloadShelfLocationOffsetX).HasColumnName("UnloadShelfLocation_OffsetX");
            entity.Property(e => e.UnloadShelfLocationOffsetY).HasColumnName("UnloadShelfLocation_OffsetY");
            entity.Property(e => e.UnloadShelfLocationWidth).HasColumnName("UnloadShelfLocation_Width");
        });

        modelBuilder.Entity<TextList>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TextList", "Staging");

            entity.Property(e => e.TextItem)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("textItem");
        });

        modelBuilder.Entity<TipOverrideReasonCode>(entity =>
        {
            entity.ToTable("TipOverrideReasonCode", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<ToteLocationDiscrepancy>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ToteLocationDiscrepancies", "Inventory");

            entity.Property(e => e.CartonId).HasColumnName("CartonID");
            entity.Property(e => e.CustomerCartonRef)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DateCreated).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.LpnholdState).HasColumnName("LPNHoldState");
            entity.Property(e => e.Lpnid).HasColumnName("LPNID");
            entity.Property(e => e.Sku)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SKU");
            entity.Property(e => e.SkuholdState).HasColumnName("SKUHoldState");
            entity.Property(e => e.Ssp).HasColumnName("SSP");
            entity.Property(e => e.Vcp).HasColumnName("VCP");
        });

        modelBuilder.Entity<TransferBuffer>(entity =>
        {
            entity.ToTable("TransferBuffers", "Staging");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PickupAndDeliveryStationName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VerticalConveyorSideName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Xcoordinate).HasColumnName("XCoordinate");
            entity.Property(e => e.Ycoordinate).HasColumnName("YCoordinate");
        });

        modelBuilder.Entity<TransferBuffer1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TransferBuffer");

            entity.ToTable("TransferBuffers", "Structure");

            entity.HasIndex(e => e.CartonLiftId, "IDX_FK_TransferBuffer_CartonLift");

            entity.HasIndex(e => e.DrivewayId, "IDX_FK_TransferBuffer_Driveway");

            entity.HasIndex(e => e.LevelId, "IDX_FK_TransferBuffer_Level");

            entity.HasIndex(e => e.PickupAndDeliveryStationId, "IDX_FK_TransferBuffer_PickupAndDeliveryStation");

            entity.HasIndex(e => e.VerticalConveyorSideId, "IDX_FK_TransferBuffer_VerticalConveyorSide");

            entity.HasIndex(e => new { e.Id, e.CartonLiftId }, "IDX_TransferBuffer_CartonLiftAndId");

            entity.HasIndex(e => e.Name, "UC_TransferBufferName").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.MapNode).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.VerticalId)
                .HasDefaultValue(-1)
                .HasColumnName("VerticalID");
            entity.Property(e => e.Xcoordinate).HasColumnName("XCoordinate");
            entity.Property(e => e.Ycoordinate).HasColumnName("YCoordinate");

            entity.HasOne(d => d.Aisle).WithMany(p => p.TransferBuffer1s)
                .HasForeignKey(d => d.AisleId)
                .HasConstraintName("FK_TransferBuffer_Aisle");

            entity.HasOne(d => d.CartonLift).WithMany(p => p.TransferBuffer1s)
                .HasForeignKey(d => d.CartonLiftId)
                .HasConstraintName("FK_TransferBuffer_CartonLift");

            entity.HasOne(d => d.DrivewayNavigation).WithMany(p => p.TransferBuffer1s)
                .HasForeignKey(d => d.DrivewayId)
                .HasConstraintName("FK_TransferBuffer_Driveway");

            entity.HasOne(d => d.EdgeAlignmentNavigation).WithMany(p => p.TransferBuffer1s)
                .HasForeignKey(d => d.EdgeAlignment)
                .HasConstraintName("FK_TransferBuffer_EdgeAlignment");

            entity.HasOne(d => d.Level).WithMany(p => p.TransferBuffer1s)
                .HasForeignKey(d => d.LevelId)
                .HasConstraintName("FK_TransferBuffer_Level");

            entity.HasOne(d => d.PickupAndDeliveryStation).WithMany(p => p.TransferBuffer1s)
                .HasForeignKey(d => d.PickupAndDeliveryStationId)
                .HasConstraintName("FK_TransferBuffer_PickupAndDeliveryStation");

            entity.HasOne(d => d.SideNavigation).WithMany(p => p.TransferBuffer1s)
                .HasForeignKey(d => d.Side)
                .HasConstraintName("FK_TransferBuffer_Side");

            entity.HasOne(d => d.TransferBufferTypeNavigation).WithMany(p => p.TransferBuffer1s)
                .HasForeignKey(d => d.TransferBufferType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransferBuffer_TransferBufferType");

            entity.HasOne(d => d.VerticalConveyorSide).WithMany(p => p.TransferBuffer1s)
                .HasForeignKey(d => d.VerticalConveyorSideId)
                .HasConstraintName("FK_TransferBuffer_VerticalConveyorSide");
        });

        modelBuilder.Entity<TransferBufferLoad>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TransferBufferLoad");

            entity.ToTable("TransferBufferLoads", "Inventory", tb => tb.HasTrigger("trg_TransferBufferLoad_Update"));

            entity.HasIndex(e => e.TransferBufferId, "IDX_FK_TransferBufferLoad_TransferBuffer");

            entity.HasIndex(e => e.CaseGroupNumber, "IX_TransferBufferLoads_CaseGroupNumber");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CustomerCartonGroupRef)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IsSuspect).HasComputedColumnSql("(CONVERT([bit],case when [SuspectTime] IS NOT NULL AND [SuspectClearTime] IS NULL OR [SuspectTime]>[SuspectClearTime] then (1) else (0) end))", true);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.HasOne(d => d.TransferBuffer).WithMany(p => p.TransferBufferLoads)
                .HasForeignKey(d => d.TransferBufferId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransferBufferLoad_TransferBuffer");
        });

        modelBuilder.Entity<TransferBufferLoadCarton>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TransferBufferLoadCarton");

            entity.ToTable("TransferBufferLoadCartons", "Inventory");

            entity.HasIndex(e => new { e.CartonId, e.TransferBufferLoadId }, "IDX_Inventory_TransferBufferLoadCartons_CartonId");

            entity.HasIndex(e => new { e.TransferBufferLoadId, e.CartonId }, "IDX_Inventory_TransferBufferLoadCartons_TransferBufferLoadId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.HasOne(d => d.Carton).WithMany(p => p.TransferBufferLoadCartons)
                .HasForeignKey(d => d.CartonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransferBufferLoadCarton_Carton");

            entity.HasOne(d => d.TransferBufferLoad).WithMany(p => p.TransferBufferLoadCartons)
                .HasForeignKey(d => d.TransferBufferLoadId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransferBufferLoadCarton_LiftLoad");
        });

        modelBuilder.Entity<TransferBufferLoadCartonsTombstone>(entity =>
        {
            entity.HasKey(e => e.TransferBufferLoadCartonsTombstoneSk).HasName("PK_TransferBufferLoadCartonTombstone");

            entity.ToTable("TransferBufferLoadCartonsTombstone", "Inventory");

            entity.HasIndex(e => e.CartonId, "IDX_TransferBufferLoadCartonsTombstone_CartonID");

            entity.Property(e => e.TransferBufferLoadCartonsTombstoneSk).HasColumnName("TransferBufferLoadCartonsTombstoneSK");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.TombstoneDate).HasDefaultValueSql("(getutcdate())");
        });

        modelBuilder.Entity<TransferBufferLoadsTombstone>(entity =>
        {
            entity.HasKey(e => e.TransferBufferLoadsTombstoneSk);

            entity.ToTable("TransferBufferLoadsTombstone", "Inventory");

            entity.Property(e => e.TransferBufferLoadsTombstoneSk).HasColumnName("TransferBufferLoadsTombstoneSK");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CustomerCartonGroupRef)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.TombstoneDate).HasDefaultValueSql("(getutcdate())");
        });

        modelBuilder.Entity<TransferBufferState>(entity =>
        {
            entity.ToTable("TransferBufferState", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TransferBufferType>(entity =>
        {
            entity.ToTable("TransferBufferType", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<TransferBuffersState>(entity =>
        {
            entity.ToTable("TransferBuffersStates", "Structure", tb => tb.HasTrigger("trg_TransferBuffersStates_Update"));

            entity.HasIndex(e => e.StateReasonId, "IDX_FK_TransferBuffersStates_StrucStateReason");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.IsOnline).HasDefaultValue(true);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.State).HasDefaultValue(2);
            entity.Property(e => e.StateChangeDateTime).HasDefaultValueSql("(sysdatetimeoffset())");
            entity.Property(e => e.StateNote)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.TransferBuffersState)
                .HasForeignKey<TransferBuffersState>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransferBuffersStates_TransferBuffers");

            entity.HasOne(d => d.StateNavigation).WithMany(p => p.TransferBuffersStates)
                .HasForeignKey(d => d.State)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransferBuffersStates_TBufferState");

            entity.HasOne(d => d.StateReason).WithMany(p => p.TransferBuffersStates)
                .HasForeignKey(d => d.StateReasonId)
                .HasConstraintName("FK_TransferBuffersStates_StrucStateReason");
        });

        modelBuilder.Entity<TransferBuffersStatesHistory>(entity =>
        {
            entity.HasKey(e => e.TransferBuffersStateHistorySk).HasName("PK_TransferBuffersStatesHistorySK");

            entity.ToTable("TransferBuffersStatesHistory", "Structure");

            entity.Property(e => e.TransferBuffersStateHistorySk).HasColumnName("TransferBuffersStateHistorySK");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.HistoryCreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(left(suser_name(),(25)))");
            entity.Property(e => e.HistoryCreatedDate).HasDefaultValueSql("(sysdatetimeoffset())");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.StateNote)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ToDate).HasDefaultValueSql("(sysdatetimeoffset())");
        });

        modelBuilder.Entity<TransferLocation>(entity =>
        {
            entity.ToTable("TransferLocations", "Staging");

            entity.Property(e => e.OutboundX)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TransferLocation1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TransferLoc");

            entity.ToTable("TransferLocations", "Structure");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TransitionState>(entity =>
        {
            entity.ToTable("TransitionState", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<Upc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_UpcId");

            entity.ToTable("Upcs", "Sku");

            entity.HasIndex(e => e.Name, "IDX_Upcs_Name");

            entity.HasIndex(e => e.Name, "UC_UPC_Name").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UpcsTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UpcsTemp", "Sku");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VersionLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_versionlogsid");

            entity.Property(e => e.Odsversion)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("ODSVersion");
            entity.Property(e => e.SqlVersion)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.TimeStamp).HasDefaultValueSql("(sysdatetimeoffset())");
        });

        modelBuilder.Entity<VerticalConveyorSide>(entity =>
        {
            entity.ToTable("VerticalConveyorSides", "Structure");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.CustomerVerticalConveyorSideRef)
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.VerticalConveyorSide)
                .HasForeignKey<VerticalConveyorSide>(d => d.Id)
                .HasConstraintName("FK_VerticalConveyorSides_Endpoint");
        });

        modelBuilder.Entity<VerticalTransferBufferGroup>(entity =>
        {
            entity.ToTable("VerticalTransferBufferGroups", "Staging");

            entity.Property(e => e.DrivewayName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EntranceNode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MapNode)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VisionPickMode>(entity =>
        {
            entity.ToTable("VisionPickMode", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<VwAisleInformation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwAisleInformation", "Staging");

            entity.Property(e => e.Name).IsUnicode(false);
            entity.Property(e => e.ResourceName)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.ZoneName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwAisleSideWithShelvesInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwAisleSideWithShelvesInfo", "Structure");

            entity.Property(e => e.AisleNumber).HasColumnName("aisleNumber");
            entity.Property(e => e.AisleSide)
                .HasMaxLength(200)
                .HasColumnName("aisleSide");
            entity.Property(e => e.AisleSideName)
                .HasMaxLength(212)
                .HasColumnName("aisleSideName");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.LevelNumber).HasColumnName("levelNumber");
            entity.Property(e => e.ShelfName)
                .HasMaxLength(4000)
                .HasColumnName("shelfName");
        });

        modelBuilder.Entity<VwAlertLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwAlertLogs", "Alert");

            entity.Property(e => e.AlertContext).HasColumnType("xml");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwAllocationOrderState>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwAllocationOrderStates", "Orders");

            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<VwAppsSkuSearchForInventoryTab>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwAppsSkuSearchForInventoryTab", "Sku");

            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.PackagingTypeName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PalletizationGroupType)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Sku)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SKU");
            entity.Property(e => e.Ssp).HasColumnName("SSP");
            entity.Property(e => e.Upcid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("UPCId");
            entity.Property(e => e.Vcp).HasColumnName("VCP");
        });

        modelBuilder.Entity<VwBayInformation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwBayInformation", "Staging");

            entity.Property(e => e.BayName).HasMaxLength(100);
            entity.Property(e => e.Name).IsUnicode(false);
            entity.Property(e => e.ResourceName)
                .HasMaxLength(157)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwBotAlertLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwBotAlertLogs", "Alert");

            entity.Property(e => e.AutoLocateCrcfail).HasColumnName("AutoLocateCRCFail ");
            entity.Property(e => e.AutoLocateNoBarcode).HasColumnName("AutoLocateNoBarcode ");
            entity.Property(e => e.BadCaseDimensionErrorExpectedDepth).HasColumnName("BadCaseDimensionError_ExpectedDepth");
            entity.Property(e => e.BadCaseDimensionErrorMeasuredDepth).HasColumnName("BadCaseDimensionError_MeasuredDepth");
            entity.Property(e => e.BladeTargetOutOfRangeErrorFront).HasColumnName("BladeTargetOutOfRangeError_Front");
            entity.Property(e => e.BladeTargetOutOfRangeErrorRear).HasColumnName("BladeTargetOutOfRangeError_Rear");
            entity.Property(e => e.BladeTargetOutOfRangeErrorType).HasColumnName("BladeTargetOutOfRangeError_Type");
            entity.Property(e => e.CannotSecurePayload).HasColumnName("CannotSecure_Payload");
            entity.Property(e => e.CaseHandlingDisabled).HasColumnName("CaseHandling_Disabled");
            entity.Property(e => e.CaseLenOutOfToleranceErrorExpectedDepth).HasColumnName("CaseLenOutOfToleranceError_ExpectedDepth");
            entity.Property(e => e.CaseLenOutOfToleranceErrorMeasuredDepth).HasColumnName("CaseLenOutOfToleranceError_MeasuredDepth");
            entity.Property(e => e.CasePutIntoCaseErrorX1).HasColumnName("CasePutIntoCaseError_X1");
            entity.Property(e => e.CasePutIntoCaseErrorX2).HasColumnName("CasePutIntoCaseError_X2");
            entity.Property(e => e.CasePutIntoCaseErrorY1).HasColumnName("CasePutIntoCaseError_Y1");
            entity.Property(e => e.CasePutIntoCaseErrorY2).HasColumnName("CasePutIntoCaseError_Y2");
            entity.Property(e => e.DynamicStateLinearVel).HasColumnName("DynamicState_LinearVel");
            entity.Property(e => e.DynamicStateRotationVel).HasColumnName("DynamicState_RotationVel");
            entity.Property(e => e.DynamicStateXposition).HasColumnName("DynamicState_XPosition");
            entity.Property(e => e.DynamicStateYaw).HasColumnName("DynamicState_Yaw");
            entity.Property(e => e.DynamicStateYposition).HasColumnName("DynamicState_YPosition");
            entity.Property(e => e.ExperimentalMisc).HasColumnName("Experimental_Misc");
            entity.Property(e => e.ExtensionRetractFail).HasColumnName("ExtensionRetract_Fail");
            entity.Property(e => e.ExtensionTimeoutDirection)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ExtensionTimeout_Direction");
            entity.Property(e => e.ExtensionTimeoutPosition).HasColumnName("ExtensionTimeout_Position");
            entity.Property(e => e.InternalErrorGenericError).HasColumnName("InternalError_GenericError");
            entity.Property(e => e.InventoryCheckResultsCaseGroupNumber).HasColumnName("InventoryCheckResults_CaseGroupNumber");
            entity.Property(e => e.InventoryCheckResultsCasePickDepth).HasColumnName("InventoryCheckResults_CasePickDepth");
            entity.Property(e => e.InventoryCheckResultsCaseYaw).HasColumnName("InventoryCheckResults_CaseYaw");
            entity.Property(e => e.InventoryCheckResultsCenterPointX).HasColumnName("InventoryCheckResults_CenterPointX");
            entity.Property(e => e.InventoryCheckResultsCenterPointY).HasColumnName("InventoryCheckResults_CenterPointY");
            entity.Property(e => e.InventoryCheckResultsLowerXpoint).HasColumnName("InventoryCheckResults_LowerXPoint");
            entity.Property(e => e.InventoryCheckResultsLowerYpoint).HasColumnName("InventoryCheckResults_LowerYPoint");
            entity.Property(e => e.InventoryCheckResultsUpperXpoint).HasColumnName("InventoryCheckResults_UpperXPoint");
            entity.Property(e => e.InventoryCheckResultsUpperYpoint).HasColumnName("InventoryCheckResults_UpperYPoint");
            entity.Property(e => e.LineSensorReportFrontLineScore).HasColumnName("LineSensorReport_FrontLineScore");
            entity.Property(e => e.LineSensorReportRearLineScore).HasColumnName("LineSensorReport_RearLineScore");
            entity.Property(e => e.PositionUncertainEstimateVariance).HasColumnName("PositionUncertain_EstimateVariance");
            entity.Property(e => e.PositionUncertainPositionError).HasColumnName("PositionUncertain_PositionError");
            entity.Property(e => e.PulseWidthFrontPulseWidth).HasColumnName("PulseWidth_FrontPulseWidth");
            entity.Property(e => e.PulseWidthRearPulseWidth).HasColumnName("PulseWidth_RearPulseWidth");
            entity.Property(e => e.RecoverySuccess).HasColumnName("Recovery_Success");
            entity.Property(e => e.RollerTimeoutReason)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.SensorWarningIssue).HasColumnName("SensorWarning_Issue");
            entity.Property(e => e.SensorWarningSensor).HasColumnName("SensorWarning_Sensor");
            entity.Property(e => e.SystemInitializationFailureAxis).HasColumnName("SystemInitializationFailure_Axis");
            entity.Property(e => e.SystemInitializationFailureErrorCode).HasColumnName("SystemInitializationFailure_ErrorCode");
            entity.Property(e => e.ThumperScoreLeftThumperScore).HasColumnName("ThumperScore_LeftThumperScore");
            entity.Property(e => e.ThumperScoreRightThumperScore).HasColumnName("ThumperScore_RightThumperScore");
            entity.Property(e => e.TractionDriveDrive)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("TractionDrive_Drive");
            entity.Property(e => e.TractionDriveErrorString)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("TractionDrive_ErrorString");
            entity.Property(e => e.UnimplementedFatalErrorsCaseBayCalculation).HasColumnName("UnimplementedFatalErrors_CaseBayCalculation");
            entity.Property(e => e.UnimplementedFatalErrorsFeatureMapError).HasColumnName("UnimplementedFatalErrors_FeatureMapError");
            entity.Property(e => e.UnimplementedFatalErrorsNotActive).HasColumnName("UnimplementedFatalErrors_NotActive");
            entity.Property(e => e.UnimplementedFatalErrorsNotInitialised).HasColumnName("UnimplementedFatalErrors_NotInitialised");
            entity.Property(e => e.UnimplementedFatalErrorsRoverAlertBadargs).HasColumnName("UnimplementedFatalErrors_RoverAlertBadargs");
            entity.Property(e => e.UnimplementedFatalErrorsRoverAlertNotinit).HasColumnName("UnimplementedFatalErrors_RoverAlertNotinit");
            entity.Property(e => e.UnimplementedModerateErrorsCasePickNotIdle).HasColumnName("UnimplementedModerateErrors_CasePickNotIdle");
            entity.Property(e => e.UnimplementedModerateErrorsCasePickNotPlanned).HasColumnName("UnimplementedModerateErrors_CasePickNotPlanned");
            entity.Property(e => e.UnimplementedModerateErrorsNoWayPoints).HasColumnName("UnimplementedModerateErrors_NoWayPoints");
            entity.Property(e => e.UnimplementedModerateErrorsPlanningError).HasColumnName("UnimplementedModerateErrors_PlanningError");
            entity.Property(e => e.UnimplementedModerateErrorsTooManyWayPoints).HasColumnName("UnimplementedModerateErrors_TooManyWayPoints");
            entity.Property(e => e.WheelRadiusLeftWheelRadius).HasColumnName("WheelRadius_LeftWheelRadius");
            entity.Property(e => e.WheelRadiusRightWheelRadius).HasColumnName("WheelRadius_RightWheelRadius");
            entity.Property(e => e.WrongLevelErrorExpected).HasColumnName("WrongLevelError_Expected");
            entity.Property(e => e.WrongLevelErrorObserved).HasColumnName("WrongLevelError_Observed");
        });

        modelBuilder.Entity<VwBotAlertLogsInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwBotAlertLogsInfo", "Alert");

            entity.Property(e => e.AddressEndPointIp).HasMaxLength(250);
            entity.Property(e => e.AlertsId).HasColumnName("AlertsID");
            entity.Property(e => e.AlertsLogId).HasColumnName("AlertsLogID");
            entity.Property(e => e.AutoLocateCrcfail).HasColumnName("AutoLocateCRCFail ");
            entity.Property(e => e.AutoLocateNoBarcode).HasColumnName("AutoLocateNoBarcode ");
            entity.Property(e => e.BadCaseDimensionErrorExpectedDepth).HasColumnName("BadCaseDimensionError_ExpectedDepth");
            entity.Property(e => e.BadCaseDimensionErrorMeasuredDepth).HasColumnName("BadCaseDimensionError_MeasuredDepth");
            entity.Property(e => e.BladeTargetOutOfRangeErrorFront).HasColumnName("BladeTargetOutOfRangeError_Front");
            entity.Property(e => e.BladeTargetOutOfRangeErrorRear).HasColumnName("BladeTargetOutOfRangeError_Rear");
            entity.Property(e => e.BladeTargetOutOfRangeErrorType).HasColumnName("BladeTargetOutOfRangeError_Type");
            entity.Property(e => e.BotId).HasColumnName("BotID");
            entity.Property(e => e.BotNumber)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.CannotSecurePayload).HasColumnName("CannotSecure_Payload");
            entity.Property(e => e.CaseHandlingDisabled).HasColumnName("CaseHandling_Disabled");
            entity.Property(e => e.CaseLenOutOfToleranceErrorExpectedDepth).HasColumnName("CaseLenOutOfToleranceError_ExpectedDepth");
            entity.Property(e => e.CaseLenOutOfToleranceErrorMeasuredDepth).HasColumnName("CaseLenOutOfToleranceError_MeasuredDepth");
            entity.Property(e => e.CasePutIntoCaseErrorX1).HasColumnName("CasePutIntoCaseError_X1");
            entity.Property(e => e.CasePutIntoCaseErrorX2).HasColumnName("CasePutIntoCaseError_X2");
            entity.Property(e => e.CasePutIntoCaseErrorY1).HasColumnName("CasePutIntoCaseError_Y1");
            entity.Property(e => e.CasePutIntoCaseErrorY2).HasColumnName("CasePutIntoCaseError_Y2");
            entity.Property(e => e.Description)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.DynamicStateLinearVel).HasColumnName("DynamicState_LinearVel");
            entity.Property(e => e.DynamicStateRotationVel).HasColumnName("DynamicState_RotationVel");
            entity.Property(e => e.DynamicStateXposition).HasColumnName("DynamicState_XPosition");
            entity.Property(e => e.DynamicStateYaw).HasColumnName("DynamicState_Yaw");
            entity.Property(e => e.DynamicStateYposition).HasColumnName("DynamicState_YPosition");
            entity.Property(e => e.ExperimentalMisc).HasColumnName("Experimental_Misc");
            entity.Property(e => e.ExtensionRetractFail).HasColumnName("ExtensionRetract_Fail");
            entity.Property(e => e.ExtensionTimeoutDirection)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ExtensionTimeout_Direction");
            entity.Property(e => e.ExtensionTimeoutPosition).HasColumnName("ExtensionTimeout_Position");
            entity.Property(e => e.FirmwareVersion).HasMaxLength(25);
            entity.Property(e => e.HardwareOriginType).HasMaxLength(25);
            entity.Property(e => e.InternalErrorGenericError).HasColumnName("InternalError_GenericError");
            entity.Property(e => e.InventoryCheckResultsCaseGroupNumber).HasColumnName("InventoryCheckResults_CaseGroupNumber");
            entity.Property(e => e.InventoryCheckResultsCasePickDepth).HasColumnName("InventoryCheckResults_CasePickDepth");
            entity.Property(e => e.InventoryCheckResultsCaseYaw).HasColumnName("InventoryCheckResults_CaseYaw");
            entity.Property(e => e.InventoryCheckResultsCenterPointX).HasColumnName("InventoryCheckResults_CenterPointX");
            entity.Property(e => e.InventoryCheckResultsCenterPointY).HasColumnName("InventoryCheckResults_CenterPointY");
            entity.Property(e => e.InventoryCheckResultsLowerXpoint).HasColumnName("InventoryCheckResults_LowerXPoint");
            entity.Property(e => e.InventoryCheckResultsLowerYpoint).HasColumnName("InventoryCheckResults_LowerYPoint");
            entity.Property(e => e.InventoryCheckResultsUpperXpoint).HasColumnName("InventoryCheckResults_UpperXPoint");
            entity.Property(e => e.InventoryCheckResultsUpperYpoint).HasColumnName("InventoryCheckResults_UpperYPoint");
            entity.Property(e => e.LevelName).HasMaxLength(50);
            entity.Property(e => e.LineSensorReportFrontLineScore).HasColumnName("LineSensorReport_FrontLineScore");
            entity.Property(e => e.LineSensorReportRearLineScore).HasColumnName("LineSensorReport_RearLineScore");
            entity.Property(e => e.MacAddress1)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MacAddress2)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MaxChargeMvolts).HasColumnName("MaxChargeMVolts");
            entity.Property(e => e.MinChargeMvolts).HasColumnName("MinChargeMVolts");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.PositionUncertainEstimateVariance).HasColumnName("PositionUncertain_EstimateVariance");
            entity.Property(e => e.PositionUncertainPositionError).HasColumnName("PositionUncertain_PositionError");
            entity.Property(e => e.Publisher).HasMaxLength(25);
            entity.Property(e => e.PulseWidthFrontPulseWidth).HasColumnName("PulseWidth_FrontPulseWidth");
            entity.Property(e => e.PulseWidthRearPulseWidth).HasColumnName("PulseWidth_RearPulseWidth");
            entity.Property(e => e.RecoveryOptions).HasMaxLength(4000);
            entity.Property(e => e.RecoverySuccess).HasColumnName("Recovery_Success");
            entity.Property(e => e.ResolutionOwner).HasMaxLength(50);
            entity.Property(e => e.RfId1)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RfId2)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RollerTimeoutReason)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.SensorWarningIssue).HasColumnName("SensorWarning_Issue");
            entity.Property(e => e.SensorWarningSensor).HasColumnName("SensorWarning_Sensor");
            entity.Property(e => e.SystemInitializationFailureAxis).HasColumnName("SystemInitializationFailure_Axis");
            entity.Property(e => e.SystemInitializationFailureErrorCode).HasColumnName("SystemInitializationFailure_ErrorCode");
            entity.Property(e => e.ThumperScoreLeftThumperScore).HasColumnName("ThumperScore_LeftThumperScore");
            entity.Property(e => e.ThumperScoreRightThumperScore).HasColumnName("ThumperScore_RightThumperScore");
            entity.Property(e => e.TractionDriveDrive)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("TractionDrive_Drive");
            entity.Property(e => e.TractionDriveErrorString)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("TractionDrive_ErrorString");
            entity.Property(e => e.UnimplementedFatalErrorsCaseBayCalculation).HasColumnName("UnimplementedFatalErrors_CaseBayCalculation");
            entity.Property(e => e.UnimplementedFatalErrorsFeatureMapError).HasColumnName("UnimplementedFatalErrors_FeatureMapError");
            entity.Property(e => e.UnimplementedFatalErrorsNotActive).HasColumnName("UnimplementedFatalErrors_NotActive");
            entity.Property(e => e.UnimplementedFatalErrorsNotInitialised).HasColumnName("UnimplementedFatalErrors_NotInitialised");
            entity.Property(e => e.UnimplementedFatalErrorsRoverAlertBadargs).HasColumnName("UnimplementedFatalErrors_RoverAlertBadargs");
            entity.Property(e => e.UnimplementedFatalErrorsRoverAlertNotinit).HasColumnName("UnimplementedFatalErrors_RoverAlertNotinit");
            entity.Property(e => e.UnimplementedModerateErrorsCasePickNotIdle).HasColumnName("UnimplementedModerateErrors_CasePickNotIdle");
            entity.Property(e => e.UnimplementedModerateErrorsCasePickNotPlanned).HasColumnName("UnimplementedModerateErrors_CasePickNotPlanned");
            entity.Property(e => e.UnimplementedModerateErrorsNoWayPoints).HasColumnName("UnimplementedModerateErrors_NoWayPoints");
            entity.Property(e => e.UnimplementedModerateErrorsPlanningError).HasColumnName("UnimplementedModerateErrors_PlanningError");
            entity.Property(e => e.UnimplementedModerateErrorsTooManyWayPoints).HasColumnName("UnimplementedModerateErrors_TooManyWayPoints");
            entity.Property(e => e.Vin)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.WheelRadiusLeftWheelRadius).HasColumnName("WheelRadius_LeftWheelRadius");
            entity.Property(e => e.WheelRadiusRightWheelRadius).HasColumnName("WheelRadius_RightWheelRadius");
            entity.Property(e => e.WrongLevelErrorExpected).HasColumnName("WrongLevelError_Expected");
            entity.Property(e => e.WrongLevelErrorObserved).HasColumnName("WrongLevelError_Observed");
        });

        modelBuilder.Entity<VwBotLiftInformation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwBotLiftInformation", "Staging");

            entity.Property(e => e.CarriageMapNodeName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwBotPullItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwBotPullItem", "Bot");

            entity.Property(e => e.BotNumber)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Location)
                .HasMaxLength(200)
                .HasColumnName("location");
            entity.Property(e => e.OperatorComment).IsUnicode(false);
            entity.Property(e => e.Pullreason)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwBotWarehouseState>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwBotWarehouseStates", "Bot");

            entity.Property(e => e.BotLiftName).HasMaxLength(50);
            entity.Property(e => e.BotNumber)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwBreakpackInteractionAisleDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwBreakpackInteractionAisleData", "Structure");

            entity.Property(e => e.BreakpackLiftBypassOutboundPickupAndDeliveryStationName).HasMaxLength(500);
            entity.Property(e => e.BreakpackLiftInboundPickupAndDeliveryStationName).HasMaxLength(500);
            entity.Property(e => e.BreakpackLiftOutboundPickupAndDeliveryStationName).HasMaxLength(500);
            entity.Property(e => e.Name).HasMaxLength(4000);
            entity.Property(e => e.PutWallPickupAndDeliveryStationName).HasMaxLength(500);
            entity.Property(e => e.ShakeAndSealInboundPickupAndDeliveryStationName).HasMaxLength(500);
            entity.Property(e => e.ShakeAndSealOutboundPickupAndDeliveryStationName).HasMaxLength(500);
        });

        modelBuilder.Entity<VwBreakpackLoopInformation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwBreakpackLoopInformation", "Staging");

            entity.Property(e => e.CellName).HasMaxLength(50);
            entity.Property(e => e.Name)
                .HasMaxLength(107)
                .HasColumnName("NAME");
            entity.Property(e => e.TurnAroundDeckName)
                .HasMaxLength(107)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwBreakpackLoopInformation1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwBreakpackLoopInformation", "Structure");

            entity.Property(e => e.BreakpackInteractionAisleName).HasMaxLength(4000);
            entity.Property(e => e.BreakpackTransitAisleName).HasMaxLength(4000);
            entity.Property(e => e.CellName).HasMaxLength(50);
            entity.Property(e => e.CellSide).HasMaxLength(200);
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<VwBreakpackTransferBufferInformation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwBreakpackTransferBufferInformation", "Staging");

            entity.Property(e => e.MapNode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PickupAndDeliveryStationName).HasMaxLength(500);
            entity.Property(e => e.TransferBufferName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TransferBufferTypeName)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.Xcoordinate).HasColumnName("XCoordinate");
            entity.Property(e => e.Ycoordinate).HasColumnName("YCoordinate");
        });

        modelBuilder.Entity<VwBreakpackTransferBuffersDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwBreakpackTransferBuffersData", "Structure");

            entity.Property(e => e.Name).HasMaxLength(500);
        });

        modelBuilder.Entity<VwBreakpackTransitAisleDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwBreakpackTransitAisleData", "Structure");

            entity.Property(e => e.Name).HasMaxLength(4000);
        });

        modelBuilder.Entity<VwBuildStructureCacheForBayViewer>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwBuildStructureCacheForBayViewer", "Structure");

            entity.Property(e => e.AisleName).HasMaxLength(50);
            entity.Property(e => e.BayName).HasMaxLength(50);
            entity.Property(e => e.Createdby)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate).HasColumnName("createddate");
            entity.Property(e => e.LevelName).HasMaxLength(50);
            entity.Property(e => e.Modifiedby)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("modifiedby");
            entity.Property(e => e.Modifieddate).HasColumnName("modifieddate");
            entity.Property(e => e.ShelfName).HasMaxLength(50);
            entity.Property(e => e.ZoneName).HasMaxLength(50);
        });

        modelBuilder.Entity<VwCartonAvailabilityCartonStateJunction>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwCartonAvailabilityCartonStateJunction");

            entity.Property(e => e.CartonAvailabilityName).HasMaxLength(50);
            entity.Property(e => e.CartonStateName).HasMaxLength(200);
        });

        modelBuilder.Entity<VwCartonCountsByOrderId>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwCartonCountsByOrderId", "Orders");
        });

        modelBuilder.Entity<VwCartonCountsByOrderIdSkuId>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwCartonCountsByOrderIdSkuId", "Sku");
        });

        modelBuilder.Entity<VwCartonCountsByOrderIdSkuIdDestinationId>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwCartonCountsByOrderIdSkuIdDestinationId", "Sku");
        });

        modelBuilder.Entity<VwCartonCountsByOrderIdSkuIdPalletId>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwCartonCountsByOrderIdSkuIdPalletId", "Sku");
        });

        modelBuilder.Entity<VwCartonExtensionInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwCartonExtensionInfo", "Inventory");

            entity.Property(e => e.ExtensionValue).HasMaxLength(2000);
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwCartonLabel>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwCartonLabels", "Inventory");

            entity.Property(e => e.CustomerCartonRef)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Description).HasMaxLength(1024);
            entity.Property(e => e.Destination)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Direction)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Lpn)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LPN");
            entity.Property(e => e.Sku)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SKU");
            entity.Property(e => e.Upc)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(8)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwCartonLabelDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwCartonLabelData", "Inventory");

            entity.Property(e => e.BarCode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LabelData).IsUnicode(false);
        });

        modelBuilder.Entity<VwCartonLiftInformation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwCartonLiftInformation", "Staging");

            entity.Property(e => e.CellName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.GroupId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LiftName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ModuleId).HasColumnName("ModuleID");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwCartonLiftTransferBufferInformation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwCartonLiftTransferBufferInformation", "Staging");

            entity.Property(e => e.EntranceNode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MapNode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TransferBufferName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TransferBufferTypeName)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.VerticalConveyorSideName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Xcoordinate).HasColumnName("XCoordinate");
            entity.Property(e => e.Ycoordinate).HasColumnName("YCoordinate");
        });

        modelBuilder.Entity<VwCartonLpnExtension>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwCartonLpnExtensions", "Sku");

            entity.Property(e => e.ExtensionValue).HasMaxLength(2000);
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwCartonOverlappingSuspect>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwCartonOverlappingSuspects", "Inventory");
        });

        modelBuilder.Entity<VwCartonRequestSummaryByOrderIdandSkuId>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwCartonRequestSummaryByOrderIdandSkuId");
        });

        modelBuilder.Entity<VwCartonRequestsAndOutboundCarton>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwCartonRequestsAndOutboundCartons", "Sku");

            entity.Property(e => e.Batch)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.CartonAvailabilitySelectionModeName).HasMaxLength(50);
            entity.Property(e => e.CartonSelectionMode).HasMaxLength(200);
            entity.Property(e => e.CustomerCartonRef)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DestinationName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Lpn)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LpnSelectionModeName).HasMaxLength(200);
            entity.Property(e => e.Ponumber).HasColumnName("PONumber");
            entity.Property(e => e.SourceFacility)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Ssp).HasColumnName("SSP");
            entity.Property(e => e.Vcp).HasColumnName("VCP");
        });

        modelBuilder.Entity<VwCodePlateInformation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwCodePlateInformation", "Staging");

            entity.Property(e => e.ChargerName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Xend).HasColumnName("XEnd");
            entity.Property(e => e.Xstart).HasColumnName("XStart");
            entity.Property(e => e.Yend).HasColumnName("YEnd");
            entity.Property(e => e.Ystart).HasColumnName("YStart");
        });

        modelBuilder.Entity<VwConfigurationGroupRanked>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwConfigurationGroupRanked", "Staging");

            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.DisplayText).HasMaxLength(500);
            entity.Property(e => e.GroupName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Path)
                .HasMaxLength(512)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwConflictedInventoryOnShortenedShelf>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwConflictedInventoryOnShortenedShelf", "Staging");

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<VwConveyorLanesInformation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwConveyorLanesInformation", "Staging");

            entity.Property(e => e.ConveyorSubsystemRef).IsUnicode(false);
        });

        modelBuilder.Entity<VwDeckInformation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwDeckInformation", "Staging");

            entity.Property(e => e.Name).HasMaxLength(151);
            entity.Property(e => e.ResourceName)
                .HasMaxLength(114)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwDeckLineInformation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwDeckLineInformation", "Staging");

            entity.Property(e => e.DeckId).HasColumnName("deckId");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ResourceName)
                .HasMaxLength(201)
                .IsUnicode(false);
            entity.Property(e => e.Type).HasColumnName("type");
        });

        modelBuilder.Entity<VwDestination>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwDestinations", "Outbound");

            entity.Property(e => e.Category)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EndpointId).HasMaxLength(50);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwDestinationInformation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwDestinationInformation", "Staging");

            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwDestinationsEndpointsInformation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwDestinationsEndpointsInformation", "Staging");

            entity.Property(e => e.EndpointName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwDrivewayInformation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwDrivewayInformation", "Staging");

            entity.Property(e => e.DrivewayNumber).HasMaxLength(200);
            entity.Property(e => e.Name).HasMaxLength(209);
            entity.Property(e => e.ResourceName).HasMaxLength(205);
        });

        modelBuilder.Entity<VwEmptySuspectLocation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwEmptySuspectLocations", "Inventory");

            entity.Property(e => e.CustomerCartonGroupRef)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShelfLocationCartonOffsetX).HasColumnName("ShelfLocation_CartonOffsetX");
            entity.Property(e => e.ShelfLocationCartonOffsetY).HasColumnName("ShelfLocation_CartonOffsetY");
            entity.Property(e => e.ShelfLocationOffsetX).HasColumnName("ShelfLocation_OffsetX");
            entity.Property(e => e.ShelfLocationOffsetY).HasColumnName("ShelfLocation_OffsetY");
            entity.Property(e => e.ShelfLocationWidth).HasColumnName("ShelfLocation_Width");
        });

        modelBuilder.Entity<VwEndpointConnectionInformation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwEndpointConnectionInformation", "Staging");

            entity.Property(e => e.InEndpointName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OutEndpointName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwEndpointInformation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwEndpointInformation", "Staging");

            entity.Property(e => e.CustomerEndpointRef)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DisplayName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.EndpointName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwExceptionProcessingRequiredInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwExceptionProcessingRequiredInfo", "Inventory");

            entity.Property(e => e.ExtraInformation).IsUnicode(false);
            entity.Property(e => e.Reason)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.SubReason)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwGetAislesInInventory>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetAislesInInventory", "Structure");
        });

        modelBuilder.Entity<VwGetAllAnnotation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetAllAnnotation", "Structure");

            entity.Property(e => e.EnteredBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ResourceName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ResourceType).HasMaxLength(200);
            entity.Property(e => e.StateNote)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.StructureStateReasonName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwGetInventoryInStructure>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetInventoryInStructure", "Inventory");

            entity.Property(e => e.CartonSsp).HasColumnName("CartonSSP");
            entity.Property(e => e.CartonVcp).HasColumnName("CartonVCP");
            entity.Property(e => e.ImholdCartons).HasColumnName("IMHoldCartons");
            entity.Property(e => e.ImholdEaches).HasColumnName("IMHoldEaches");
            entity.Property(e => e.ImholdOrderTotes).HasColumnName("IMHoldOrderTotes");
            entity.Property(e => e.ImholdSupplyTotes).HasColumnName("IMHoldSupplyTotes");
            entity.Property(e => e.ImholdTotes).HasColumnName("IMHoldTotes");
            entity.Property(e => e.LicensePlateNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LpnholdCartons).HasColumnName("LPNHoldCartons");
            entity.Property(e => e.LpnholdEaches).HasColumnName("LPNHoldEaches");
            entity.Property(e => e.LpnholdTotes).HasColumnName("LPNHoldTotes");
            entity.Property(e => e.LpnunavailableCartons).HasColumnName("LPNUnavailableCartons");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Sku)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SKU");
            entity.Property(e => e.SkuSsp).HasColumnName("SkuSSP");
            entity.Property(e => e.SkuVcp).HasColumnName("SkuVCP");
            entity.Property(e => e.SkuholdCartons).HasColumnName("SKUHoldCartons");
            entity.Property(e => e.SkuholdEaches).HasColumnName("SKUHoldEaches");
            entity.Property(e => e.SkuholdTotes).HasColumnName("SKUHoldTotes");
            entity.Property(e => e.SkuunavailableCartons).HasColumnName("SKUUnavailableCartons");
        });

        modelBuilder.Entity<VwGetLpnsInInventory>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetLpnsInInventory", "Sku");
        });

        modelBuilder.Entity<VwGetSkusInInventory>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetSkusInInventory", "Sku");
        });

        modelBuilder.Entity<VwInboundCartonLimit>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwInboundCartonLimits", "Configuration");

            entity.Property(e => e.CpiweightTolerance).HasColumnName("CPIWeightTolerance");
            entity.Property(e => e.Odvtolerance).HasColumnName("ODVTolerance");
        });

        modelBuilder.Entity<VwInboundCartonsCount>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwInboundCartonsCount", "Inbound");

            entity.Property(e => e.Lpnid).HasColumnName("LPNId");
        });

        modelBuilder.Entity<VwInboundDimensionalVariantsForSku>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VwInboundDimensionalVariantsForSkus", "Sku");

            entity.Property(e => e.MeasurementStation)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Sku)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SKU");
        });

        modelBuilder.Entity<VwInboundPalletComposition>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwInboundPalletComposition", "Inbound");

            entity.Property(e => e.Batch)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.CustomerCartonGroupRef)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CustomerInboundRef)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.DepalletizerId).HasColumnName("DepalletizerID");
            entity.Property(e => e.InductionType)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.LicensePlateNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Lpnid).HasColumnName("LPNId");
            entity.Property(e => e.ParentLpn)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("ParentLPN");
            entity.Property(e => e.PickupLocation)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Sku)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SKU");
            entity.Property(e => e.SkuDescription).HasMaxLength(1024);
            entity.Property(e => e.SkuName).HasMaxLength(100);
            entity.Property(e => e.SourceFacility)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwInternalOrderInventory>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwInternalOrderInventory", "Inventory");

            entity.Property(e => e.Batch)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.CustomerCartonGroupRef)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CustomerCartonRef)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.HoldReason)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.LabelTypeName).HasMaxLength(50);
            entity.Property(e => e.LicensePlateNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Ponumber).HasColumnName("PONumber");
            entity.Property(e => e.Sku)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SKU");
            entity.Property(e => e.SkuDescription).HasMaxLength(1024);
            entity.Property(e => e.SourceFacility)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Upc)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwInventoryCartonInformation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwInventoryCartonInformation", "Inventory");

            entity.Property(e => e.AlternateContainerRef)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Batch)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.BayName).HasMaxLength(50);
            entity.Property(e => e.CustomerCartonGroupRef)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CustomerCartonRef)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FreightType).HasMaxLength(2000);
            entity.Property(e => e.HoldReason)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.LicensePlateNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LpnExtensionPonumber)
                .HasMaxLength(2000)
                .HasColumnName("LpnExtensionPONumber");
            entity.Property(e => e.PocreateDate)
                .HasMaxLength(2000)
                .HasColumnName("POCreateDate");
            entity.Property(e => e.ReceiverNo).HasMaxLength(2000);
            entity.Property(e => e.ShelfLocationCartonOffsetX).HasColumnName("ShelfLocation_CartonOffsetX");
            entity.Property(e => e.ShelfLocationCartonOffsetY).HasColumnName("ShelfLocation_CartonOffsetY");
            entity.Property(e => e.ShelfLocationOffsetX).HasColumnName("ShelfLocation_OffsetX");
            entity.Property(e => e.ShelfLocationOffsetY).HasColumnName("ShelfLocation_OffsetY");
            entity.Property(e => e.ShelfLocationWidth).HasColumnName("ShelfLocation_Width");
            entity.Property(e => e.ShelfName).HasMaxLength(50);
            entity.Property(e => e.Sku)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SKU");
            entity.Property(e => e.SkuDescription).HasMaxLength(1024);
            entity.Property(e => e.SkuName).HasMaxLength(100);
            entity.Property(e => e.SourceFacility)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Ssp).HasColumnName("SSP");
            entity.Property(e => e.Upc)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Vcp).HasColumnName("VCP");
        });

        modelBuilder.Entity<VwInventoryLocationInformation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwInventoryLocationInformation", "Inventory");

            entity.Property(e => e.BayName).HasMaxLength(50);
            entity.Property(e => e.ShelfLocationOffsetX).HasColumnName("ShelfLocation_OffsetX");
            entity.Property(e => e.ShelfLocationOffsetY).HasColumnName("ShelfLocation_OffsetY");
            entity.Property(e => e.ShelfLocationWidth).HasColumnName("ShelfLocation_Width");
            entity.Property(e => e.ShelfName).HasMaxLength(50);
        });

        modelBuilder.Entity<VwInventoryShelvesInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwInventoryShelvesInfo", "Structure");

            entity.Property(e => e.Side).HasMaxLength(1);
        });

        modelBuilder.Entity<VwItemsInsideRestrictedSegregationZone>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwItemsInsideRestrictedSegregationZone", "Segregation");

            entity.Property(e => e.AllergenTypeName).HasMaxLength(200);
            entity.Property(e => e.BayName).HasMaxLength(50);
            entity.Property(e => e.CartonId).HasColumnName("CartonID");
            entity.Property(e => e.CustomerCartonGroupRef)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CustomerCartonRef)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.ProductTypeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SegProductPropertyName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShelfName).HasMaxLength(50);
            entity.Property(e => e.SkuDescription).HasMaxLength(1024);
            entity.Property(e => e.SkuId).HasColumnName("SkuID");
            entity.Property(e => e.Violation)
                .HasMaxLength(29)
                .IsUnicode(false);
            entity.Property(e => e.ZoneDescription)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwItemsOutOfSegregationZone>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwItemsOutOfSegregationZone", "Segregation");

            entity.Property(e => e.BayName).HasMaxLength(50);
            entity.Property(e => e.CartonId).HasColumnName("CartonID");
            entity.Property(e => e.CustomerCartonGroupRef)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CustomerCartonRef)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.SegProductPropertyId).HasColumnName("SegProductPropertyID");
            entity.Property(e => e.SegProductPropertyName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShelfName).HasMaxLength(50);
            entity.Property(e => e.SkuDescription).HasMaxLength(1024);
            entity.Property(e => e.SkuId).HasColumnName("SkuID");
            entity.Property(e => e.Violation)
                .HasMaxLength(12)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwLatestCartonScan>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwLatestCartonScans", "Inventory");
        });

        modelBuilder.Entity<VwLatestShelfScan>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwLatestShelfScans", "Structure");
        });

        modelBuilder.Entity<VwLevelTopology>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwLevelTopology", "Structure");

            entity.Property(e => e.CompId).HasColumnName("compId");
            entity.Property(e => e.CompName)
                .HasMaxLength(4000)
                .HasColumnName("compName");
            entity.Property(e => e.CompNumber).HasColumnName("compNumber");
            entity.Property(e => e.CompType)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("compType");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ParentId).HasColumnName("parentId");
            entity.Property(e => e.ParentName)
                .HasMaxLength(500)
                .HasColumnName("parentName");
            entity.Property(e => e.ParentNumber).HasColumnName("parentNumber");
            entity.Property(e => e.ResourceSubType).HasMaxLength(200);
        });

        modelBuilder.Entity<VwLpnStringTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwLpnStringTemp", "Sku");
        });

        modelBuilder.Entity<VwLpnWithDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwLpnWithDetails", "Sku");
        });

        modelBuilder.Entity<VwOrderDetailSummaryByOrderIdandSkuId>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwOrderDetailSummaryByOrderIdandSkuId");

            entity.Property(e => e.Batch)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.CustomerCartonRef)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CustomerChainNumber)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CustomerNumber)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CustomerTaskId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.GroupId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ponumber).HasColumnName("PONumber");
            entity.Property(e => e.SourceFacility)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.SpogNumber)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Ssp).HasColumnName("SSP");
            entity.Property(e => e.Vcp).HasColumnName("VCP");
        });

        modelBuilder.Entity<VwOrderDetailsCartonCountByOrderId>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwOrderDetailsCartonCountByOrderId", "Orders");
        });

        modelBuilder.Entity<VwOrderOrderToteSummary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwOrderOrderToteSummary", "Orders");
        });

        modelBuilder.Entity<VwOrderPalletSourceType>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwOrderPalletSourceTypes", "Orders");
        });

        modelBuilder.Entity<VwOrderSummary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwOrderSummary", "Orders");
        });

        modelBuilder.Entity<VwOutboundCartonActivity>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwOutboundCartonActivity", "Outbound");

            entity.Property(e => e.CartonSelectionMode).HasMaxLength(200);
            entity.Property(e => e.CustomerCartonRef)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CustomerChainNumber)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CustomerNumber)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.DeliveryStateName).HasMaxLength(200);
            entity.Property(e => e.DestinationName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Lpn)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LpnSelectionModeName).HasMaxLength(200);
            entity.Property(e => e.OrderNumber)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.OrderStateName).HasMaxLength(200);
            entity.Property(e => e.OrderTypeName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Ponumber).HasColumnName("PONumber");
            entity.Property(e => e.ScratchReasonName).HasMaxLength(200);
            entity.Property(e => e.Sku)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SKU");
            entity.Property(e => e.SkuDescription).HasMaxLength(1024);
            entity.Property(e => e.SkuName).HasMaxLength(100);
            entity.Property(e => e.Ssp).HasColumnName("SSP");
            entity.Property(e => e.SubstituteSku)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SubstituteSkuDescription).HasMaxLength(1024);
            entity.Property(e => e.SubstituteSkuName).HasMaxLength(100);
            entity.Property(e => e.Vcp).HasColumnName("VCP");
        });

        modelBuilder.Entity<VwOutboundIdexclusionListForSkuActivityOutboundOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwOutboundIDExclusionListForSkuActivityOutboundOrder", "Sku");

            entity.Property(e => e.ExclOutboundId).HasColumnName("ExclOutboundID");
        });

        modelBuilder.Entity<VwOutboundPallet>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwOutboundPallets");

            entity.Property(e => e.CustomerPalletNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Lpn)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PalletResultFileName).HasMaxLength(250);
            entity.Property(e => e.ParentPalletId).HasColumnName("ParentPalletID");
            entity.Property(e => e.PickupLocation).HasMaxLength(30);
            entity.Property(e => e.PlannedPalletFileName).HasMaxLength(250);
            entity.Property(e => e.SequenceFileName).HasMaxLength(250);
        });

        modelBuilder.Entity<VwOutboundPalletSummary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwOutboundPalletSummary", "Outbound");

            entity.Property(e => e.CustomerBatchRef).HasMaxLength(25);
            entity.Property(e => e.CustomerName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.CustomerPalletNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DestinationName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LicensePlateNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OrderNumber)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.PalletBuiltBy).HasMaxLength(200);
            entity.Property(e => e.TruckRoute)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwPickupAndDelStationsInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwPickupAndDelStationsInfo", "Structure");

            entity.Property(e => e.ConvBufName)
                .HasMaxLength(500)
                .HasColumnName("convBufName");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.PndName)
                .HasMaxLength(500)
                .HasColumnName("pndName");
            entity.Property(e => e.VerticalId).HasColumnName("VerticalID");
        });

        modelBuilder.Entity<VwPndStationInformation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwPndStationInformation", "Staging");

            entity.Property(e => e.CellName)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<VwProcessLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwProcessLog", "Staging");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DeploymentAction)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DeploymentStep)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Message)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.MessageCategory)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MessageType)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwProcessResult>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwProcessResults", "Staging");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DeploymentAction)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DeploymentCategory)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DeploymentStep)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Message)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.MessageCategory)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MessageType)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwScannersInformation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwScannersInformation", "Staging");
        });

        modelBuilder.Entity<VwSegregationBayInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwSegregationBayInfo", "Staging");

            entity.Property(e => e.SubTier).HasColumnName("subTier");
        });

        modelBuilder.Entity<VwSegregationProductPropertyMap>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwSegregationProductPropertyMap", "Segregation");

            entity.Property(e => e.AllergenTypeId).HasColumnName("AllergenTypeID");
            entity.Property(e => e.ProductPropertyName)
                .HasMaxLength(17)
                .IsUnicode(false);
            entity.Property(e => e.RefProductTypeId).HasColumnName("RefProductTypeID");
            entity.Property(e => e.SegProductPropertyId).HasColumnName("SegProductPropertyID");
            entity.Property(e => e.SegProductPropertyName)
                .HasMaxLength(19)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwSegregationRuleModelInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwSegregationRuleModelInfo", "Staging");

            entity.Property(e => e.ExpectedValue)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwSegregationZoneDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwSegregationZoneData", "Segregation");

            entity.Property(e => e.SegregationType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SegregationZone)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwSegregationZoneIdsForInventory>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwSegregationZoneIdsForInventory", "Segregation");

            entity.Property(e => e.CartonId).HasColumnName("CartonID");
        });

        modelBuilder.Entity<VwSegregationZoneInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwSegregationZoneInfo", "Segregation");

            entity.Property(e => e.BayId).HasColumnName("BayID");
            entity.Property(e => e.ExpectedValue)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProductTypeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PropertyName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RuleSetDescription)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RuleTypeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ZoneDescription)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ZoneRuleTypeName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwSegregationZoneSkuMappingRule>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwSegregationZoneSkuMappingRule", "Segregation");

            entity.Property(e => e.ProductTypeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PropertyName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwShelfInformation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwShelfInformation", "Staging");

            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.ResourceName).IsUnicode(false);
            entity.Property(e => e.ShelfName).IsUnicode(false);
        });

        modelBuilder.Entity<VwShelvesHeightType>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwShelvesHeightTypes", "Structure");
        });

        modelBuilder.Entity<VwShelvesToBeDeleted>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwShelvesToBeDeleted", "Staging");

            entity.Property(e => e.ShelfName).HasMaxLength(50);
        });

        modelBuilder.Entity<VwSkuSubstitution>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwSkuSubstitution", "Sku");

            entity.Property(e => e.SourceSku)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SourceSkuName).HasMaxLength(100);
            entity.Property(e => e.SubstituteSku)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SubstituteSkuName).HasMaxLength(100);
        });

        modelBuilder.Entity<VwSkuVelocityDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwSkuVelocityDetails", "Sku");
        });

        modelBuilder.Entity<VwSkuWithActiveLpn>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwSkuWithActiveLpns", "Sku");

            entity.Property(e => e.LpnrejectReasonId).HasColumnName("LPNRejectReasonId");
        });

        modelBuilder.Entity<VwSkuWithActiveOutboundLpn>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwSkuWithActiveOutboundLPNs", "Sku");
        });

        modelBuilder.Entity<VwSkuWithDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwSkuWithDetails", "Sku");

            entity.Property(e => e.HasAnyActiveInboundLpn).HasColumnName("HasAnyActiveInboundLPN");
            entity.Property(e => e.HasAnyActiveOutboundLpn).HasColumnName("HasAnyActiveOutboundLPN");
            entity.Property(e => e.SkuId).HasColumnName("SkuID");
        });

        modelBuilder.Entity<VwSkuWithDetailsFast>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwSkuWithDetailsFast", "Sku");

            entity.Property(e => e.HasAnyActiveInboundLpn).HasColumnName("HasAnyActiveInboundLPN");
            entity.Property(e => e.HasAnyActiveOutboundLpn).HasColumnName("HasAnyActiveOutboundLPN");
            entity.Property(e => e.SkuId).HasColumnName("SkuID");
        });

        modelBuilder.Entity<VwStagingCartonLift>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwStagingCartonLifts", "Staging");

            entity.Property(e => e.CellName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.GroupId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwStagingEndpointId>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwStagingEndpointIds", "Staging");

            entity.Property(e => e.EndpointId)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwStructureInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwStructureInfo", "Structure");

            entity.Property(e => e.AisleName).HasMaxLength(50);
            entity.Property(e => e.BayName).HasMaxLength(50);
            entity.Property(e => e.LevelName).HasMaxLength(50);
            entity.Property(e => e.ModuleName).HasMaxLength(50);
            entity.Property(e => e.ShelfName).HasMaxLength(50);
            entity.Property(e => e.ZoneName).HasMaxLength(50);
        });

        modelBuilder.Entity<VwSubsystemInformation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwSubsystemInformation", "Staging");

            entity.Property(e => e.SubsystemId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SubsystemType)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Version)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwTransferBufferInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwTransferBufferInfo", "Structure");

            entity.Property(e => e.CartonLiftName).HasMaxLength(500);
            entity.Property(e => e.CellName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EdgeAlignment).HasMaxLength(200);
            entity.Property(e => e.Side).HasMaxLength(200);
            entity.Property(e => e.TransferBufferName).HasMaxLength(500);
            entity.Property(e => e.TransferBufferType).HasMaxLength(200);
            entity.Property(e => e.Xcoordinate).HasColumnName("XCoordinate");
            entity.Property(e => e.Ycoordinate).HasColumnName("YCoordinate");
        });

        modelBuilder.Entity<VwTransferBuffersToBeDeleted>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwTransferBuffersToBeDeleted", "Staging");

            entity.Property(e => e.Tbid).HasColumnName("TBId");
            entity.Property(e => e.Tbname)
                .HasMaxLength(500)
                .HasColumnName("TBName");
        });

        modelBuilder.Entity<VwUnavailableStructureResource>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwUnavailableStructureResources", "Structure");

            entity.Property(e => e.ResourceName).HasMaxLength(500);
            entity.Property(e => e.ResourceState).HasMaxLength(200);
            entity.Property(e => e.ResourceType)
                .HasMaxLength(14)
                .IsUnicode(false);
            entity.Property(e => e.StateReason)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.StateReasonNote)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwZoneInformation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwZoneInformation", "Staging");

            entity.Property(e => e.ZoneName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WarehousePack>(entity =>
        {
            entity.HasKey(e => e.SkuId);

            entity.ToTable("WarehousePacks", "Sku");

            entity.HasIndex(e => e.Id, "UC_WarehousePacks_Key").IsUnique();

            entity.Property(e => e.SkuId).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.MeasurementStation)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.RoboticPickEligibleScore).HasColumnType("numeric(18, 3)");

            entity.HasOne(d => d.MeasuredByNavigation).WithMany(p => p.WarehousePacks)
                .HasForeignKey(d => d.MeasuredBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WarehousePacks_MeasuredBy");

            entity.HasOne(d => d.Sku).WithOne(p => p.WarehousePack)
                .HasForeignKey<WarehousePack>(d => d.SkuId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WarehousePacks_Sku");

            entity.HasOne(d => d.WarehousePackPackageType).WithMany(p => p.WarehousePacks)
                .HasForeignKey(d => d.WarehousePackPackageTypeId)
                .HasConstraintName("FK_WarehousePacks_WarehousePackPackageType");

            entity.HasMany(d => d.WarehousePackHandlingProfileTypes).WithMany(p => p.WarehousePacks)
                .UsingEntity<Dictionary<string, object>>(
                    "WarehousePackHandlingProfile",
                    r => r.HasOne<WarehousePackHandlingProfileType>().WithMany()
                        .HasForeignKey("WarehousePackHandlingProfileTypeId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_WarehousePackHandlingProfiles_HandlingProfile"),
                    l => l.HasOne<WarehousePack>().WithMany()
                        .HasPrincipalKey("Id")
                        .HasForeignKey("WarehousePackId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_WarehousePackHandlingProfiles_WarehousePack"),
                    j =>
                    {
                        j.HasKey("WarehousePackId", "WarehousePackHandlingProfileTypeId");
                        j.ToTable("WarehousePackHandlingProfiles", "Sku");
                    });
        });

        modelBuilder.Entity<WarehousePackHandlingProfileType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_WarehousePackHandlingProfile");

            entity.ToTable("WarehousePackHandlingProfileType", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<WarehousePackHandlingProfilesTemp>(entity =>
        {
            entity.HasKey(e => new { e.WarehousePackId, e.WarehousePackHandlingProfileTypeId });

            entity.ToTable("WarehousePackHandlingProfilesTemp", "Sku");
        });

        modelBuilder.Entity<WarehousePackPackageType>(entity =>
        {
            entity.ToTable("WarehousePackPackageType", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<WarehousePacksTemp>(entity =>
        {
            entity.HasKey(e => e.SkuId);

            entity.ToTable("WarehousePacksTemp", "Sku");

            entity.Property(e => e.SkuId).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.MeasurementStation)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.RoboticPickEligibleScore).HasColumnType("decimal(18, 3)");
        });

        modelBuilder.Entity<WorkOrder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_WorkOrder");

            entity.ToTable("WorkOrders", "Maintenance");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CreatedTime).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedTime).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Number).ValueGeneratedOnAdd();

            entity.HasOne(d => d.AssetTypeNavigation).WithMany(p => p.WorkOrders)
                .HasForeignKey(d => d.AssetType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WorkOrders_AssetType");
        });

        modelBuilder.Entity<WorkOrderAlertLog>(entity =>
        {
            entity.HasKey(e => new { e.WorkOrderId, e.AlertLogId });

            entity.ToTable("WorkOrderAlertLogs", "Maintenance");

            entity.HasIndex(e => e.AlertLogId, "IDX_FK_WorkOrderAlertLogs_AlertLog");

            entity.HasIndex(e => e.WorkOrderId, "IDX_FK_WorkOrderAlertLogs_WorkOrder");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.HasOne(d => d.AlertLog).WithMany(p => p.WorkOrderAlertLogs)
                .HasForeignKey(d => d.AlertLogId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WorkOrderAlertLogs_AlertLog");

            entity.HasOne(d => d.WorkOrder).WithMany(p => p.WorkOrderAlertLogs)
                .HasForeignKey(d => d.WorkOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WorkOrderAlertLogs_WorkOrder");
        });

        modelBuilder.Entity<WorkOrderChangeState>(entity =>
        {
            entity.ToTable("WorkOrderChangeStates", "Maintenance");

            entity.HasIndex(e => e.WorkOrderId, "IDX_FK_WorkOrderChangeState_WorkOrder");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.UserName).HasMaxLength(50);

            entity.HasOne(d => d.NewStateNavigation).WithMany(p => p.WorkOrderChangeStateNewStateNavigations)
                .HasForeignKey(d => d.NewState)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WorkOrderChangeState_WorkOrderState");

            entity.HasOne(d => d.OldStateNavigation).WithMany(p => p.WorkOrderChangeStateOldStateNavigations)
                .HasForeignKey(d => d.OldState)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WorkOrderChangeState_WorkOrderState1");

            entity.HasOne(d => d.WorkOrder).WithMany(p => p.WorkOrderChangeStates)
                .HasForeignKey(d => d.WorkOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WorkOrderChangeState_WorkOrder");
        });

        modelBuilder.Entity<WorkOrderIssue>(entity =>
        {
            entity.ToTable("WorkOrderIssues", "Maintenance");

            entity.HasIndex(e => e.IssueId, "IDX_FK_WorkOrderIssues_Issue");

            entity.HasIndex(e => e.WorkOrderId, "IDX_FK_WorkOrderIssues_WorkOrder");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.HasOne(d => d.Issue).WithMany(p => p.WorkOrderIssues)
                .HasForeignKey(d => d.IssueId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WorkOrderIssues_Issue");

            entity.HasOne(d => d.WorkOrder).WithMany(p => p.WorkOrderIssues)
                .HasForeignKey(d => d.WorkOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WorkOrderIssues_WorkOrder");
        });

        modelBuilder.Entity<WorkOrderIssueResolution>(entity =>
        {
            entity.ToTable("WorkOrderIssueResolutions", "Maintenance");

            entity.HasIndex(e => e.WorkOrderIssueId, "IDX_FK_WorkOrderIssueResolutions_WorkOrderIssue");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.HasOne(d => d.WorkOrderIssue).WithMany(p => p.WorkOrderIssueResolutions)
                .HasForeignKey(d => d.WorkOrderIssueId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WorkOrderIssueResolutions_WorkOrderIssue");
        });

        modelBuilder.Entity<WorkOrderNote>(entity =>
        {
            entity.ToTable("WorkOrderNotes", "Maintenance");

            entity.HasIndex(e => e.WorkOrderId, "IDX_FK_WorkOrderNotes_WorkOrder");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.UserName).HasMaxLength(25);

            entity.HasOne(d => d.WorkOrder).WithMany(p => p.WorkOrderNotes)
                .HasForeignKey(d => d.WorkOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WorkOrderNotes_WorkOrder");
        });

        modelBuilder.Entity<WorkOrderState>(entity =>
        {
            entity.ToTable("WorkOrderState", "ReferenceTables");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<Zone>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_SegregationZone");

            entity.ToTable("Zone", "Segregation");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasMany(d => d.ProductProperties).WithMany(p => p.SegregationZones)
                .UsingEntity<Dictionary<string, object>>(
                    "ZoneProductProperty",
                    r => r.HasOne<ProductProperty>().WithMany()
                        .HasForeignKey("ProductPropertyId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ZoneProductProperty_ProductProperty"),
                    l => l.HasOne<Zone>().WithMany()
                        .HasForeignKey("SegregationZoneId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ZoneProductProperty_Zone"),
                    j =>
                    {
                        j.HasKey("SegregationZoneId", "ProductPropertyId");
                        j.ToTable("ZoneProductProperty", "Segregation");
                    });

            entity.HasMany(d => d.RuleSets).WithMany(p => p.SegregationZones)
                .UsingEntity<Dictionary<string, object>>(
                    "ZoneRuleSet",
                    r => r.HasOne<RuleSet>().WithMany()
                        .HasForeignKey("RuleSetId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ZoneRuleSet_RuleSet"),
                    l => l.HasOne<Zone>().WithMany()
                        .HasForeignKey("SegregationZoneId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ZoneRuleSet_Zone"),
                    j =>
                    {
                        j.HasKey("SegregationZoneId", "RuleSetId");
                        j.ToTable("ZoneRuleSet", "Segregation");
                    });
        });

        modelBuilder.Entity<Zone1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Zone");

            entity.ToTable("Zones", "Structure");

            entity.HasIndex(e => e.Name, "UQX_ZoneName").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<ZoneBayModel>(entity =>
        {
            entity.ToTable("ZoneBayModel", "Segregation", tb => tb.HasTrigger("trg_ZoneBayModel_Delete"));

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("(left(suser_name(),(25)))");
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(sysutcdatetime())");

            entity.HasOne(d => d.Bay).WithMany(p => p.ZoneBayModels)
                .HasForeignKey(d => d.BayId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ZoneBayModel_Bays");

            entity.HasOne(d => d.SegregationZone).WithMany(p => p.ZoneBayModels)
                .HasForeignKey(d => d.SegregationZoneId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ZoneBayModel_Zone");
        });

        modelBuilder.Entity<ZoneBayModelHistory>(entity =>
        {
            entity.HasKey(e => e.ZoneBayModelHistorySk).HasName("PK_ZoneBayModelHistorySK");

            entity.ToTable("ZoneBayModelHistory", "Segregation");

            entity.Property(e => e.ZoneBayModelHistorySk).HasColumnName("ZoneBayModelHistorySK");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.HistoryCreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(left(suser_name(),(50)))");
            entity.Property(e => e.HistoryCreatedDate).HasDefaultValueSql("(sysdatetimeoffset())");
        });

        modelBuilder.Entity<ZoneState>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ZoneState");

            entity.ToTable("ZoneStates", "Structure", tb =>
                {
                    tb.HasTrigger("trg_ZoneStates_Insert");
                    tb.HasTrigger("trg_ZoneStates_Update");
                });

            entity.HasIndex(e => e.ZoneId, "IDX_FK_ZoneState_Zone");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.StateNote)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.StateNavigation).WithMany(p => p.ZoneStates)
                .HasForeignKey(d => d.State)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ZoneState_TransitionState");

            entity.HasOne(d => d.Zone).WithMany(p => p.ZoneStates)
                .HasForeignKey(d => d.ZoneId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ZoneState_Zone");
        });

        modelBuilder.Entity<ZoneStatesTombstone>(entity =>
        {
            entity.HasKey(e => e.ZoneStatesTombstoneSk);

            entity.ToTable("ZoneStatesTombstone", "Structure");

            entity.Property(e => e.ZoneStatesTombstoneSk).HasColumnName("ZoneStatesTombstoneSK");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.StateNote)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.TombstoneDate).HasDefaultValueSql("(getutcdate())");
        });

        modelBuilder.Entity<ZoneType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_SegregationZoneType");

            entity.ToTable("ZoneType", "Segregation");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });
        modelBuilder.HasSequence<int>("CartonGroupNumberSequence", "Inventory").HasMin(1L);
        modelBuilder.HasSequence("InboundPalletNumberSequence", "Inbound")
            .HasMin(1L)
            .HasMax(2147483647L);
        modelBuilder.HasSequence<int>("OutboundPalletNumberSequence", "Outbound").HasMin(1L);

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
