﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaTicketSalesAutomation.Models
{
    public class Sales:BaseClass
    {
        public Sales()
        {
            creationDate = DateTime.Now.ToString();
        }
        public string creationDate { get; set; }
        public decimal totalPrice { get; set; }
        public int count { get; set; }
        public string sessionTime { get; set; }

        public override string ToString()
        {
            return $"{movieName} adlı filmin {sessionTime} seansına {count} adet bilet kesilmiştir. Toplam tutar = {totalPrice} tl | Satın alınma tarihi = {creationDate}";
        }
       
    }

}
