﻿#nullable disable
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MilkParadiseShop.Model
{
    [PrimaryKey(nameof(NumId))]
    public class Client
    {
        public int NumId { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Patronymic { get; set; }
        public string Gender { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int Discount { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<ClientProduct> ClientProducts { get; set; }
    }
}