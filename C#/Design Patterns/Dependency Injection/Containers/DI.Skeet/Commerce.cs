﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DI.Skeet.Classes;
using DI.Skeet.Interfaces;

namespace DI.Skeet
{
    public class Commerce
    {
        private IBillingProcessor _billingProcessor;
        private ICustomerProcessor _customerProcessor;
        private INotifier _notifier;
        private ILogger _logger;

        public Commerce(IBillingProcessor billingProcessor,
            ICustomerProcessor customerProcessor,
            INotifier notifier,
            ILogger logger)
        {
            _billingProcessor = billingProcessor;
            _customerProcessor = customerProcessor;
            _notifier = notifier;
            _logger = logger;
        }

        public void ProcessOrder(OrderInfo orderInfo)
        {
            _billingProcessor.ProcessPayment(orderInfo.CustomerName, orderInfo.CreditCard, orderInfo.Price);
            _logger.Log("Billing processed");
            _customerProcessor.UpdateCustomer(orderInfo.CustomerName);
            _logger.Log("Updated to customer");
            _notifier.SendReceipt(orderInfo);
            _logger.Log("Receipt sent");
        }
    }
}
