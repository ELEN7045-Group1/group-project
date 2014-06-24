﻿namespace AccountPresentationSystem.Domain.Model.Billing
{
    using AccountPresentationSystem.Domain.Shared;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    /// <summary>
    /// Uniquely identifies a particular Billing Account. Automatically generated by the application.
    /// </summary>
    public class BillingAccountId : IValueObject<BillingAccountId>
    {
        /// <summary>
        /// The identifier
        /// </summary>
        private readonly string id;


        /// <summary>
        /// Initializes a new instance of the <see cref="BillingAccountId"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <exception cref="System.ArgumentNullException"></exception>
        public  BillingAccountId(string id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                this.id = id;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        /// <summary>
        /// Gets the identifier string.
        /// </summary>
        /// <value>
        /// The identifier string.
        /// </value>
        public string IdString
        {
            get{ return id;}
        }

        /// <summary>
        /// Value objects compare by the values of their attributes, they don't have an identity.
        /// </summary>
        /// <param name="other">The other value object.</param>
        /// <returns>true if the given value object's and this value object's attributes are the same.</returns>
        public bool SameValueAs(BillingAccountId other)
        {
            return other != null && id.Equals(other.id);
        }
    }
}