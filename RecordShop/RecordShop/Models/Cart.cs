using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using static RecordShop.Models.DbContextModel;

namespace RecordShop.Models
{
    public partial class Cart
    {


        RecordShop_Context _storeDB = new RecordShop_Context();
        public Cart(RecordShop_Context storeDB)
        {
            _storeDB = storeDB;
        }

        public int CartId { get; set; }

        public List<CartItem> Items { get; private set; }

        public static readonly Cart Instance;

        [HttpGet]
        public static Cart getCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<RecordShop_Context>();

            var cartId = session.GetInt32("CartId");
            session.SetString("CardId", cartId.ToString());

            return new Cart(context) { CartId = (int)cartId };
        }

        public void AddToCart(Record record)
        {
            var cartItem = _storeDB.CartItems.SingleOrDefault(s => s.RecordId == record.RecordId && s.CartId == CartId);

            if(cartItem == null)
            {
                var rec = new CartItem
                {
                    CartId = CartId,
                    RecordId = record.RecordId,
                    Record = record,
                    Quantity = 1

                };
                _storeDB.CartItems.Add(rec);
            }
            else
            {
                cartItem.Quantity++;
            }
            _storeDB.SaveChanges();
        }

        public int RemoveFromCart(Record record)
        {
            var cartItem = _storeDB.CartItems.SingleOrDefault(s => s.RecordId == record.RecordId && s.CartId == CartId);
            var localQuantity = 0;

            if(cartItem != null)
            {
                if(cartItem.Quantity > 1)
                {
                    cartItem.Quantity--;
                    localQuantity = cartItem.Quantity;
                }
                else
                {
                    _storeDB.CartItems.Remove(cartItem);
                }
            }
            _storeDB.SaveChanges();

            return localQuantity;
        }

        public List<CartItem> GetCartItems()
        {
            return Items ?? (Items = _storeDB.CartItems.Where(c => c.CartId == CartId)
                .Include(s => s.Record).ToList());
        }

        public void ClearCart()
        {
            var cartItems = _storeDB.CartItems.Where(cart => cart.CartId == CartId);
            _storeDB.CartItems.RemoveRange(cartItems);
            _storeDB.SaveChanges();
        }

        public decimal GetCartTotal()
        {
            var total = _storeDB.CartItems.Where(c => c.CartId == CartId)
                .Select(c => c.Record.Price * c.Quantity).Sum();
            return total;
        }
    }
}
