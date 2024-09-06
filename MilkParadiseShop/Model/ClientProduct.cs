#nullable disable
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MilkParadiseShop.Model
{
    [PrimaryKey(nameof(ClientId),nameof(ProdId))]
    public class ClientProduct
    {
        public ClientProduct() { }
        public ClientProduct(int clientId,int prodId, int quantity) 
        { 
            ClientId = clientId;
            ProdId = prodId;
            Quantity = quantity;
        }
        [ForeignKey("Client")]
        public int ClientId { get; set; }

        [ForeignKey("Product")]
        public int ProdId { get; set; }
        public int Quantity { get; set; }
        public string ProdName
        { 
            get 
            {
                string name = string.Empty;
                using (BaseContext baseContext = new BaseContext())
                {
                    name = baseContext.Products.Where(p => p.NumId == ProdId).First().Name;
                }
                return name;
            } 
        }
        public Decimal TotalPriceForProduct
        {
            get
            {
                decimal price = 0;
                using (BaseContext baseContext = new BaseContext())
                {
                    price = baseContext.Products.Where(p => p.NumId == ProdId).First().Price * Quantity;
                }
                return price;
            }
        }
        public Client Client { get;set; }
        public Product Product { get; set; }
    }
}