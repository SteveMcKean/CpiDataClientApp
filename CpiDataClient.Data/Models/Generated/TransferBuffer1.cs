using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class TransferBuffer1
{
    public Guid Id { get; set; }

    public int VerticalTransferBufferGroupNumber { get; set; }

    public string? Name { get; set; }

    public int TransferBufferType { get; set; }

    public int VerticalId { get; set; }

    public int TransferHeight { get; set; }

    public int OrderId { get; set; }

    public int Xcoordinate { get; set; }

    public int Ycoordinate { get; set; }

    public int Width { get; set; }

    public int Length { get; set; }

    public string? MapNode { get; set; }

    public Guid? CartonLiftId { get; set; }

    public Guid? VerticalConveyorSideId { get; set; }

    public Guid? LevelId { get; set; }

    public Guid? AisleId { get; set; }

    public Guid? PickupAndDeliveryStationId { get; set; }

    public int PndDirection { get; set; }

    public int PositionOnPnd { get; set; }

    public int? CartonHeightMax { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public int? PositionFromStructure { get; set; }

    public int? Driveway { get; set; }

    public Guid? DrivewayId { get; set; }

    public int? CartonLiftGroupId { get; set; }

    public int? ArmId { get; set; }

    public int? GroupId { get; set; }

    public int? TransferBufferShelfId { get; set; }

    public int? SlotId { get; set; }

    public int? Side { get; set; }

    public int? EdgeAlignment { get; set; }

    public int? BotTransferHeight { get; set; }

    public int Number { get; set; }

    public int? CenterY { get; set; }

    public virtual Aisle1? Aisle { get; set; }

    public virtual CartonLift1? CartonLift { get; set; }

    public virtual Driveway1? DrivewayNavigation { get; set; }

    public virtual EdgeAlignment? EdgeAlignmentNavigation { get; set; }

    public virtual Level1? Level { get; set; }

    public virtual PickupAndDeliveryStation1? PickupAndDeliveryStation { get; set; }

    public virtual ICollection<ShakeAndSealLoad> ShakeAndSealLoads { get; set; } = new List<ShakeAndSealLoad>();

    public virtual Side? SideNavigation { get; set; }

    public virtual ICollection<TaskPlan> TaskPlanLoadTransferBuffers { get; set; } = new List<TaskPlan>();

    public virtual ICollection<TaskPlan> TaskPlanUnloadTransferBuffers { get; set; } = new List<TaskPlan>();

    public virtual ICollection<TransferBufferLoad> TransferBufferLoads { get; set; } = new List<TransferBufferLoad>();

    public virtual TransferBufferType TransferBufferTypeNavigation { get; set; } = null!;

    public virtual TransferBuffersState? TransferBuffersState { get; set; }

    public virtual VerticalConveyorSide? VerticalConveyorSide { get; set; }
}
