﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Library.Model
{
    /// <summary>
    /// An order that can only be read from.
    /// </summary>
    public interface IReadOnlyOrder
    {
        /// <summary>
        /// The customer who made the order.
        /// </summary>
        ICustomer Customer { get; }

        /// <summary>
        /// The location that the order was placed from.
        /// </summary>
        ILocation StoreLocation { get; }

        /// <summary>
        /// The orderlines inside of the order.
        /// </summary>
        List<IOrderLine> OrderLines { get; }

        /// <summary>
        /// The time the order was proccessed.
        /// </summary>
        DateTimeOffset? OrderTime { get; }

        /// <summary>
        /// The ID of the order.
        /// </summary>
        int? Id { get; }

        /// <summary>
        /// The total price for the order
        /// </summary>
        decimal TotalPrice { get; }
    }
}