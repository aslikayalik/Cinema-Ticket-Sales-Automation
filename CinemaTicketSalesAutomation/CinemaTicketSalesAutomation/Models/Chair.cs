﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaTicketSalesAutomation.Models
{
    public class Chair
    {
        public Chair(string _row, string _number)
        {
            row = _row;
            number = _number;
        }
        public string row { get; set; }
        public string number { get; set; }
        public bool status { get; set; }
    }
}
