﻿//author:Yadira Garnica Bonome
using System;
using MongoDB.Bson.Serialization.Attributes;

namespace PaymentService.Models
{
    public class Transaction
    {
        /// <summary>
        /// Id autogenerated
        /// </summary>
        [BsonId]
        public string Id { get; set; }

        /// <summary>
        /// Amount to be pay
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Name in the credit card
        /// </summary>
        public string CardName { get; set; }

        /// <summary>
        /// Expiration year
        /// </summary>
        public int CardExpYear { get; set; }

        /// <summary>
        /// Expiration month
        /// </summary>
        public int CardExpMonth { get; set; }
        
        /// <summary>
        /// Credit card number
        /// </summary>
        public string CardNumber { get; set; }

        /// <summary>
        /// Credit card brand
        /// </summary>
        public string CardType { get; set; }

        /// <summary>
        /// Credit card secure number
        /// </summary>
        public string CardCVV { get; set; }

        /// <summary>
        /// Date of the transaction
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// True if the transaction was success
        /// </summary>
        public bool MundipaggCreated { get; set; }
    }
}
