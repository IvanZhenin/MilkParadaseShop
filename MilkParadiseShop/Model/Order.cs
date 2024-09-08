#nullable disable
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace MilkParadiseShop.Model
{
    [PrimaryKey(nameof(NumId))]
    public class Order
    {
        public Order(int numId, int clientId, DateTime dateCreate, string address, string orderType,
            string status, decimal totalPrice, int? workerId = null) 
        { 
            NumId = numId;
            ClientId = clientId;
            DateCreate = dateCreate;
            Address = address;
            OrderType = orderType;
            Status = status;
            TotalPrice = totalPrice;
            if (workerId != null)
                WorkerId = workerId;
        }
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
        public string ArchiveText
        {
            get
            {
                string result = string.Empty;
                using (BaseContext baseContext = new BaseContext())
                {
                    var order = baseContext.Orders.Where(p => p.NumId == NumId).FirstOrDefault();
                    if (order.ArchStatus == true)
                    {
                        result = "Архивирован";
                    }
                    else
                    {
                        result = "Не архивирован";
                    }
                }
                return result;
            }
        }

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
                    {
                        result = worker.SurName + " " + worker.Name;
                    }
                    else
                    {
                        result = " - ";
                    }
                }
                return result;
            }
        }
        public int TotalProdQuantity
        {
            get
            {
                int result = 0;
                using (BaseContext baseContext = new BaseContext())
                {
                    var prodList = baseContext.ProdsInOrders.Where(p => p.OrderId == NumId).ToList();
                    foreach (var pos in prodList)
                        result += pos.Quantity;
                }
                return result;
            }
        }
        public ICollection<ProdInOrder> ProdsInOrders { get; set; }
    }
}