﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// Information on the order that the cashier is processing is recorded,
/// and then the details of the cashier is also recorded.
/// </summary>
namespace CofffeeLovers.Models
{
    public class Cashier
    {
        /// <summary>
        /// Order item's ID is made.
        /// </summary>
        [DisplayName("Order ID"), Required, StringLength(maximumLength: 10)]
        public int OrderItemsOrderID { get; set; }

        /// <summary>
        /// The product's ID is recorded.
        /// </summary>
        [DisplayName("Order products ID"), Required, StringLength(maximumLength: 10)]
        public int OrderItemsProductsID { get; set; }

        /// <summary>
        /// Staff's ID.
        /// </summary>
        [DisplayName("Staff ID"), Required, StringLength(maximumLength: 3)]
        public int StaffID { get; set; }

        /// <summary>
        /// Cashier's first name.
        /// </summary>
        [DisplayName("First name"), Required, StringLength(maximumLength: 15)]
        public string FirstName { get; set; }

        /// <summary>
        /// Cashier's last name
        /// </summary>
        [DisplayName("Last name"), Required, StringLength(maximumLength: 15)]
        public string LastName { get; set; }

        /// <summary>
        /// Cashier's email.
        /// </summary>
        [DisplayName("Email"), Required, StringLength(maximumLength: 30)]
        public string Email { get; set; }
    }
}