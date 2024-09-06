#nullable disable
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MilkParadiseShop.Model
{
    [PrimaryKey(nameof(NumId))]
    public class MarketPoint
    {
        public int NumId { get; set; }
        public string Address { get; set; }
    }
}