#nullable disable
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MilkParadiseShop.Model
{
    [PrimaryKey(nameof(OrderId), nameof(ProdId))]
    public class ProdInOrder
    {
        public ProdInOrder(int orderId, int prodId, int quantity) 
        { 
            OrderId = orderId;
            ProdId = prodId;
            Quantity = quantity;
        }

        [ForeignKey("Order")]
        public int OrderId { get; set; }

        [ForeignKey("Product")]
        public int ProdId { get; set; }
        public int Quantity { get; set; } 
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}