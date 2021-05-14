﻿using System;
using System.Collections.Generic;

namespace Pinch.SDK.Payments
{
    public class RealtimePaymentSaveOptions
    {
        // Existing Payer
        /// <summary>
        /// If executing a payment for an existing payer, supply their Payer ID.
        /// </summary>
        public string PayerId { get; set; }

        // New Payer
        /// <summary>
        /// The new payer's full name. This can be used instead of supplying a separate first and last names.
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// New payer's First Name
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// New payer's Last Name
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// New payer's Email Address
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// New payer's Mobile Number
        /// </summary>
        public string MobileNumber { get; set; }

        /// <summary>
        /// The payment amount in cents. eg. $10.00 = 1000
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// Optional. The application fee amount in cents. This fee is added to the transaction fee and settled to the Primary Merchant.
        /// </summary>
        public int? ApplicationFee { get; set; }

        /// <summary>
        /// A list of source types to surcharge (Pass on the fees to the customer). eg. ['bank-account', 'credit-card']
        /// </summary>
        public List<string> Surcharge { get; set; } = new List<string>();

        /// <summary>
        /// A description of the payment. This may be shown to the Payer to understand the payment.
        /// </summary>
        public string Description { get; set; }

        // Existing Source (optional. omitting will use latest source)
        /// <summary>
        /// Optionally supply the exact existing Source ID you would like to charge. 
        /// If none is specified it will use the first valid realtime source attached to the payer.
        /// If you want to create a new credit card source, use the <see cref="CreditCardToken"/> property.
        /// </summary>
        public string SourceId { get; set; }

        /// <summary>
        /// Charge this credit card token and attach it as a source to the payer. Tokens are generated by the "Pinch Capture" javascript widget.
        /// </summary>
        public string CreditCardToken { get; set; }

        /// <summary>
        /// Optional. Pinch will echo back the nonce value in the response, this is for replay protection.
        /// If the same Nonce is detected the in progress payment object will be returned.
        /// </summary>
        public string Nonce { get; set; }
    }
}
