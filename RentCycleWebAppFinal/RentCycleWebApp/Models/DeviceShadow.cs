﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RentCycleWebApp.Models
{
    public partial class DeviceShadow
    {
        public string DeviceId { get; set; }
        public string Location { get; set; }
        public string Status { get; set; }
        public int DeviceModelId { get; set; }
        public string Info { get; set; }
        public DateTime? InOperationFrom { get; set; }
        public DateTime? LastServicingDate { get; set; }
        public int? UserRating { get; set; }

        public virtual DeviceModel DeviceModel { get; set; }
    }
}