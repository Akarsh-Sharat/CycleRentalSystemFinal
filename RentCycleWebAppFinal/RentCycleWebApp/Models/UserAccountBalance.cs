﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RentCycleWebApp.Models
{
    public partial class UserAccountBalance
    {
        public int Id { get; set; }
        public int UserAccountId { get; set; }
        public decimal BalanceAmount { get; set; }

        public virtual UserAccount UserAccount { get; set; }
    }
}