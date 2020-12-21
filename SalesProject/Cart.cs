using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesProject
{
    class Cart 
    {
        private readonly decimal CREDIT_LIMIT = 1000;

        private String userID;
        private CUSTOMER user;
        private decimal? balance;
        private decimal cartTotal = 0;
        private StoreDBDataContext db = new StoreDBDataContext();
        private Dictionary<PRODUCT, int> cartItems = new Dictionary<PRODUCT, int>();
        

        public Cart(String userID)
        {
            this.userID = userID;
            ConfigureUserData();
        }

        private void ConfigureUserData() 
        {
            user = db.CUSTOMERs.FirstOrDefault(u => u.userID == userID) ?? null;
            if (user == null)
            {
                throw new NullReferenceException("user data could not be retrieved.");
            }
            balance = user.balance ?? 0;

        }

        public Dictionary<PRODUCT, int> GetCartItems()
        {
            return cartItems;
        }

        public decimal GetCartTotal()
        {
            return cartTotal;
        }

        public void AddToCart(PRODUCT p, int qty)
        {
            if (cartItems.ContainsKey(p))
            {
                cartItems[p] += qty;
            }
            else
            {
                cartItems.Add(p, qty);
            }
            cartTotal += (p.prodPrice ?? 0) * qty;
        }

        public void RemoveFromCart(PRODUCT p)
        {
            if (cartItems.ContainsKey(p))
            {
                cartTotal -= (p.prodPrice ?? 0) * cartItems[p];
                cartItems.Remove(p);
            }
        }

        public bool AttemptCheckout()
        {
            if (cartTotal + balance <= CREDIT_LIMIT)
            {
                balance += cartTotal;
                SaveOrderToDatabase();
                DisplayCheckoutSuccessMessage();
                cartItems.Clear();
                return true;
            }
            else
            {
                DisplayCreditLimitExceededMessage();
                return false;
            }
        }

        private void SaveOrderToDatabase()
        {
            ORDER order = new ORDER();
            order.CUSTOMER = user;
            order.userID = userID;
            order.date = DateTime.Now;
            order.total = cartTotal;
            
            foreach (KeyValuePair<PRODUCT,int> item in cartItems)
            {
                ORDER_ITEM orderItem = new ORDER_ITEM();
                orderItem.ORDER = order;
                orderItem.PRODUCT = item.Key;
                orderItem.orderID = order.orderID;
                orderItem.prodID = item.Key.prodID;
                orderItem.quantity = item.Value;
                
                // add products to order
                order.ORDER_ITEMs.Add(orderItem);

                // decrease amount in stock
                var prod = db.PRODUCTs.FirstOrDefault(p => p.prodID == item.Key.prodID);
                prod.prodStock -= item.Value;
            }

            user.balance = balance;

            try
            {
                db.SubmitChanges();
            }
            catch(Exception e)
            {
                MessageBox.Show("Error: your order could not be placed at this time.");
                throw new Exception("Error saving order to database.");
            }
        }

        private void DisplayCheckoutSuccessMessage()
        {
            MessageBox.Show("Your account will be charged "
                    + string.Format("{0:C}", cartTotal) + " for this purchase.");
        }

        private void DisplayCreditLimitExceededMessage()
        {
            MessageBox.Show("Purchase unsuccessful. Account credit limit exceeded.");
        }

    }
}
