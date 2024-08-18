using System;
using System.Collections.Generic;

namespace ODS.Models;

public partial class TableStat
{
    public int TableStatSk { get; set; }

    public string SchemaName { get; set; } = null!;

    public string TableName { get; set; } = null!;

    public int RowCount { get; set; }

    public long ReservedSizeKb { get; set; }

    public long DataSizeKb { get; set; }

    public long IndexSizeKb { get; set; }

    public long UnusedSizeKb { get; set; }

    public DateTimeOffset TableStatDateTime { get; set; }

    public string? TableStatProcessId { get; set; }
}
