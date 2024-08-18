﻿using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class VwOrderDetailSummaryByOrderIdandSkuId
{
    public Guid OrderId { get; set; }

    public Guid? SkuId { get; set; }

    public string? CustomerNumber { get; set; }

    public string? CustomerChainNumber { get; set; }

    public string? SpogNumber { get; set; }

    public int? Quantity { get; set; }

    public int QuantityType { get; set; }

    public int? TotalEaches { get; set; }

    public int? TotalCartons { get; set; }

    public int CartonType { get; set; }

    public int? Vcp { get; set; }

    public int? Ssp { get; set; }

    public bool? TrapFlag { get; set; }

    public int? TrapPromotionNumber { get; set; }

    public int? AppointmentNumber { get; set; }

    public int? Ponumber { get; set; }

    public string? CustomerCartonRef { get; set; }

    public Guid? LpnId { get; set; }

    public int OrderDestination { get; set; }

    public bool CanUseExpired { get; set; }

    public bool UseAvailableOnly { get; set; }

    public int? ExpirationWindow { get; set; }

    public Guid? DestinationCategoryId { get; set; }

    public string? CustomerTaskId { get; set; }

    public int LpnSelectionMode { get; set; }

    public string? GroupId { get; set; }

    public int ExpirationOffset { get; set; }

    public int CartonAvailabilitySelectionMode { get; set; }

    public string? Batch { get; set; }

    public string? SourceFacility { get; set; }

    public DateTimeOffset? ExpirationDate { get; set; }

    public int? PalletBaseTypeId { get; set; }
}
