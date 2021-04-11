﻿using System;

namespace WzorceProjektowe.Strukturalne.Facade.II
{
    public class Client
    {
        public static void Execute()
        {
            IProductService productService = null;
            ICartService cartService = null;
            IPaymentService paymentService = null;

            var productIds = new[] { 1, 2, 3 };
            var cartId = 123;

            var order = new OrderFacade(productService, paymentService, cartService);
            order.Order(productIds, cartId);
        }
    }
}