﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// Customer's card details are recorded, this is going to be used
/// when an order is going to be made.
/// </summary>
namespace CofffeeLovers.Models
{
    public class Customer_Payment_Method
    {

        [Required]
        public int PaymentMethodCode { get; set; }

        /// <summary>
        /// Card's number is recorded for the payment method.
        /// </summary>
        [Required, StringLength(maximumLength: 16)]
        public int CardNumber { get; set; }

        /// <summary>
        /// Date of the purchase is taken.
        /// </summary>
        [Required]
        public DateTime DateOfPurcahse { get; set; }

        /// <summary>
        /// Total price of the items is then wrote down.
        /// </summary>
        [Required]
        public Decimal Total { get; set; }

        /// <summary>
        /// The bill number is made.
        /// </summary>
        [Required]
        public int BillNumber { get; set; }
    }
}