using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesProject
{
    class Account
    {
        private readonly decimal CREDIT_LIMIT = 1000;

        private string userID;
        private CUSTOMER user;
        private decimal? balance;
        private string name;
        private string email;
        private string address;
        private decimal cartTotal = 0;
        private StoreDBDataContext db = new StoreDBDataContext();
        private Dictionary<PRODUCT, int> cartItems = new Dictionary<PRODUCT, int>();
        

        public Account(string userID)
        {
            this.userID = userID;
            ConfigureUserData();
        }

        public string UserID => userID; 

        public Dictionary<PRODUCT, int> CartItems => cartItems;

        public decimal CartTotal => cartTotal;

        public decimal Balance => balance ?? 0;

        public string Name => name;

        public string Email => email;

        public string Address => address;

        private void ConfigureUserData()
        {
            // refresh db
            db.Refresh(System.Data.Linq.RefreshMode.KeepChanges);

            user = db.CUSTOMERs.FirstOrDefault(u => u.userID == userID) ?? null;
            if (user == null)
            {
                throw new NullReferenceException("user data could not be retrieved.");
            }
            balance = user.balance ?? 0;
            name = user.firstName + " " + user.lastName;
            email = user.email;
            address = user.address + ", " + user.city + ", " + user.state + " " + user.zip;
        }

        public void PayBalance(decimal d)
        {
            if (d > 0)
            {
                user.balance -= d;
                SubmitPayment(d);
            }
            else
            {
                DisplayInvalidAmountMessage();
            }
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
            if (cartTotal + (user.balance ?? 0) <= CREDIT_LIMIT)
            {
                PlaceOrder();
                cartItems.Clear();
                ConfigureUserData();
                return true;
            }
            else
            {
                DisplayCreditLimitExceededMessage();
                return false;
            }
        }

        private void PlaceOrder()
        {
            // update user balance
            user.balance += cartTotal;
            
            // create order
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

            // submit changes to db
            SubmitOrder();
        }

        private void SubmitOrder()
        {
            try
            {
                db.SubmitChanges();

                DisplayCheckoutSuccessMessage();
                cartTotal = 0;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: your order could not be placed at this time.");
                throw new Exception("Error saving order to database.");
            }
        }

        private void SubmitPayment(decimal d)
        {         
            try
            {
                db.SubmitChanges();
                DisplaySuccessfulPaymentMessage(d);
                ConfigureUserData();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
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

        private void DisplaySuccessfulPaymentMessage(decimal d)
        {
            MessageBox.Show("Your payment of " + string.Format("{0:C}", d) +
                        " has been processed successfuly.");
        }

        private void DisplayInvalidAmountMessage()
        {
            MessageBox.Show("Payment amounts must be greater than 0.");
        }

    }
}
