using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwStructureInfo
{
    public Guid ZoneId { get; set; }

    public string? ZoneName { get; set; }

    public int ZoneNumber { get; set; }

    public int ZoneSafetyZoneRef { get; set; }

    public Guid ModuleId { get; set; }

    public int ModuleNumber { get; set; }

    public string? ModuleName { get; set; }

    public int ModuleStartPointX { get; set; }

    public int ModuleStartPointY { get; set; }

    public int ModuleEndPointX { get; set; }

    public int ModuleEndPointY { get; set; }

    public Guid LevelId { get; set; }

    public int LevelNumber { get; set; }

    public string? LevelName { get; set; }

    public int LevelHeight { get; set; }

    public Guid AisleId { get; set; }

    public int AisleNumber { get; set; }

    public string? AisleName { get; set; }

    public int AisleStartPointX { get; set; }

    public int AisleStartPointY { get; set; }

    public int AisleEndPointX { get; set; }

    public int AisleEndPointY { get; set; }

    public Guid BayId { get; set; }

    public int BayNumber { get; set; }

    public string? BayName { get; set; }

    public int BayShelfSide { get; set; }

    public int BayOffsetX { get; set; }

    public int BayOffsetY { get; set; }

    public int BayWidth { get; set; }

    public int BayLength { get; set; }

    public int BayHeight { get; set; }

    public int BayWeight { get; set; }

    public Guid ShelfId { get; set; }

    public int ShelfNumber { get; set; }

    public string? ShelfName { get; set; }

    public int ShelfShelfSide { get; set; }

    public int ShelfOffsetX { get; set; }

    public int ShelfOffsetY { get; set; }

    public int ShelfOffsetZ { get; set; }

    public int ShelfWidth { get; set; }

    public int ShelfLength { get; set; }

    public int ShelfHeight { get; set; }

    public int ShelfWeight { get; set; }
}
