﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace HellwegFinal.Models
{
    public partial class InfractionType
    {
        public InfractionType()
        {
            Infractions = new HashSet<Infraction>();
        }

        public int InfractionTypeIndex { get; set; }
        public string InfractionTypeDescription { get; set; }
        public string InfractionTypeName { get; set; }

        public virtual ICollection<Infraction> Infractions { get; set; }
    }
}