using E_COM.Models;
using E_COM.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_COM.Components
{
    public class ShoppingCartSummary:ViewComponent
    {
        private readonly ShopppingCart _shoppingcart;
        public ShoppingCartSummary(ShopppingCart shopppingCart)
        {
            _shoppingcart = shopppingCart;

        }

        public IViewComponentResult Invoke()
        {
            var items = _shoppingcart.GetShoppingCartItems();
            _shoppingcart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShopingCart = _shoppingcart,
                ShoppingCartTotal = _shoppingcart.GetShoppingCartTotal()
            };
            return View(shoppingCartViewModel);
        }
    }
}
