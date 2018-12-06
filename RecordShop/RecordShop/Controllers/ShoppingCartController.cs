using System;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RecordShop.Models;
using Newtonsoft.Json;
using static RecordShop.Models.DbContextModel;
using RecordShop.ViewModels;

namespace RecordShop.Controllers
{
    public class ShoppingCartController : Controller
    {
        public RecordShop_Context _StoreDb;

        public ShoppingCartController(RecordShop_Context storeDb)
        {
            _StoreDb = storeDb;
        }

        public IActionResult Index()
        {
            Cart cart = new Cart(_StoreDb);
            var records = cart.GetCartItems();

            var sCVM = new ShoppingCartViewModal
            {
                Cart = cart,
                CartTotal = cart.GetCartTotal()
            };

            return View(sCVM);
        }

        [HttpGet]
        public JsonResult GetCartItems()
        {
            Cart cart = new Cart(_StoreDb);
            return Json(cart.GetCartItems());
        }

        [HttpGet]
        public JsonResult getCartTotal()
        {
            Cart cart = new Cart(_StoreDb);
            return Json(cart.GetCartTotal());
        }

        public RedirectToActionResult AddToShoppingCart(int recordID)
        {
            var selectedRecord = _StoreDb.Records.FirstOrDefault(p => p.RecordId == recordID);
            if (selectedRecord != null)
            {
                Cart cart = new Cart(_StoreDb);
                cart.AddToCart(selectedRecord);
            }
            return RedirectToAction("Index");

        }

        public RedirectToActionResult RemoveFromShoppingCart(int recordId)
        {
            var selectedRecord = _StoreDb.Records.FirstOrDefault(p => p.RecordId == recordId);
            if (selectedRecord != null)
            {
                Cart cart = new Cart(_StoreDb);
                cart.RemoveFromCart(selectedRecord);
            }

            return RedirectToAction("Index");

        }
    }
}