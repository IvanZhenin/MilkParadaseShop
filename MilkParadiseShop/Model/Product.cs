#nullable disable
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;

namespace MilkParadiseShop.Model
{
    [PrimaryKey(nameof(NumId))]
    public class Product
    {
        public int NumId { get; set; }
        public string Name { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public string Equipment { get; set; }
        public decimal Weight { get; set; }
        public decimal Price { get; set; }
        public byte[] Image { get; set; }
        public Category Category { get; set; }
        public string CategoryName
        {
            get
            {
                string result = string.Empty;
                using(BaseContext baseContext = new BaseContext())
                {
                    result = baseContext.Categories.Where(p => p.NumId == CategoryId).FirstOrDefault().Name;
                }
                return result;
            }
        }
        public ICollection<ProdInOrder> ProdsInOrders { get; set; }
        public ICollection<ClientProduct> ClientProducts { get; set; }
    }
}