﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RentCycleWebApp.Models
{
    public partial class UserCategory
    {
        public UserCategory()
        {
            DeviceRates = new HashSet<DeviceRate>();
        }

        public int Id { get; set; }
        public string UserCategory1 { get; set; }

        public virtual ICollection<DeviceRate> DeviceRates { get; set; }
    }
}