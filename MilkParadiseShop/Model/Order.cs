#nullable disable
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MilkParadiseShop.Model
{
    [PrimaryKey(nameof(NumId))]
    public class Order
    {
        public int NumId { get; set; }

        [ForeignKey("Worker")]
        public Nullable<int> WorkerId { get; set; }

        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public DateTime DateCreate { get; set; }
        public Nullable<DateTime> DateEnd { get; set; }
        public string Address { get; set; }
        public string OrderType { get; set; }
        public string Status { get; set; }
        public decimal TotalPrice { get; set; }
        public bool ArchStatus { get; set; }
        public Worker Worker { get; set; }
        public Client Client { get; set; }
        public string WorkerFullName
        {
            get
            {
                string result = string.Empty;
                using (BaseContext baseContext = new BaseContext())
                {
                    var worker = baseContext.Workers.Where(p => p.NumId == WorkerId).FirstOrDefault();
                    if (worker != null)
                        result = worker.SurName + " " + worker.Name;
                }
                return result;
            }
        }
        public ICollection<ProdInOrder> ProdsInOrders { get; set; }
    }
}