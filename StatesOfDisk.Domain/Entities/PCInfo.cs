﻿using StatesOfDisk.Domain.Common;

namespace StatesOfDisk.Domain.Entities;

public sealed class PCInfo : BaseEntity
{
    //public string Id { get; set; }
    public DateTimeOffset? UpdateTimestamp { get; set; }
    public string? ComputerName { get; set; }
    public decimal? DiskCfreeSpace { get; set; }
}