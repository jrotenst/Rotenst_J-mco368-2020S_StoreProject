using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesProject
{
    public partial class joeysMain : Form
    {
        private Account account;
        private StoreDBDataContext db = new StoreDBDataContext();

        private PRODUCT selectedItem;
        private int selectedCartRowIndex;
        private int quantity;

        public joeysMain(string userID)
        {
            InitializeComponent();
            account = new Account(userID);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.pRODUCTTableAdapter.Fill(this.storeProjectDataSet1.PRODUCT);
            itemList.Sort(itemList.Columns[1], ListSortDirection.Ascending);
            UpdateCartTabData();
            UpdateAccountTab();
            UpdatePurchasesTab();
        }

        private void UpdateCartTabData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("SKU", typeof(int));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Quantity", typeof(int));

            account.CartItems.ToList().ForEach(kvp => dt.Rows.Add(new object[]
            {
                kvp.Key.prodID, 
                kvp.Key.prodName, 
                kvp.Value
            }));

            cartItemsDisplay.DataSource = dt;
            
            if (account.CartItems.Count > 0)
            {
                checkoutButton.Visible = true;
            }
            else
            {
                cartItemNameLabel.Text = "No item selected";
                cartItemPriceLabel.Text = "Price:";
                cartItemQtyLabel.Text = "Quantity";
                removeItemButton.Visible = false;
            }
            cartTotalValueLabel.Text = string.Format("{0:C}", account.CartTotal);
        }

        private void UpdateAccountTab()
        {
            balanceValueLabel.Text = string.Format("{0:C}", account.Balance);
            accountNameLabel.Text = "Name:  " + account.Name;
            emailLabel.Text = "Email:  " + account.Email;
            addressLabel.Text = "Address:  " + account.Address;
        }

        private void UpdatePurchasesTab()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Date", typeof(string));
            dt.Columns.Add("Total", typeof(string));

            db.ORDERs.Where(p => p.userID == account.UserID).ToList().ForEach(p => dt.Rows.Add(new object[]
            {
                p.orderID,
                string.Format("{0:MM/dd/yy}", p.date),
                string.Format("{0:C}", p.total)
            }));

            purchasesDisplay.DataSource = dt;
        }

        private void searchBar_TextChanged(object sender, EventArgs e)
        {
            var items = db.PRODUCTs.Where(p => p.prodName.Contains(searchBar.Text)).OrderBy(p => p.prodName);
            itemList.DataSource = items;
        }

        private void itemList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            itemNameLabel.Visible = true;
            priceLabel.Visible = true;
            qtyLabel.Visible = true;
            qtyTextBox.Visible = true;
            qtyTextBox.Text = "";
            addToCartButton.Visible = true;
            stockLabel.Visible = true;

            var row = itemList.Rows[(itemList.SelectedCells[0].RowIndex)];
            string id = row.Cells[0].Value.ToString();
            selectedItem = db.PRODUCTs.Single(p => p.prodID.ToString() == id);

            itemNameLabel.Text = selectedItem.prodName;
            priceLabel.Text = string.Format("{0:C}", selectedItem.prodPrice);

            if (selectedItem.prodStock <= 0)
            {
                stockLabel.ForeColor = Color.Red;
                stockLabel.Text = "Out of Stock";
            }
            else if (selectedItem.prodStock >= 20)
            {
                stockLabel.ForeColor = Color.ForestGreen;
                stockLabel.Text = "In Stock 20+";
            }
            else
            {
                stockLabel.ForeColor = Color.ForestGreen;
                stockLabel.Text = "In Stock";
            }
        }

        private void addToCartButton_Click(object sender, EventArgs e)
        {
            if (AddIsValid())
            {
                account.AddToCart(selectedItem, quantity);
                UpdateCartTabData();
            }
        }

        private bool AddIsValid()
        {
            bool isInt = int.TryParse(qtyTextBox.Text, out quantity);

            if (itemNameLabel.Text == "")
            {
                MessageBox.Show("No item has been selected");
            }
            else if (stockLabel.Text == "Out of Stock")
            {
                MessageBox.Show("Item is not in stock");
            }
            else if (!isInt || quantity <= 0)
            {
                MessageBox.Show("Please enter a quantity greater than zero");
            }
            else if (quantity > selectedItem.prodStock)
            {
                MessageBox.Show("Quantity entered exceeds amount in stock");
            }
            else
            {
                return true;
            }
            return false;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCartTabData();
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            if (account.CartItems.Count != 0)
            {
                if (account.AttemptCheckout())
                {
                    // refresh db
                    db.Refresh(System.Data.Linq.RefreshMode.KeepChanges);
                }
                UpdateAccountTab();
                UpdateCartTabData();
            }
            else
            {
                MessageBox.Show("Cart is Empty.");
            }
        }

        private void cartItemsDisplay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedCartRowIndex = e.RowIndex;
            cartItemNameLabel.Visible = true;
            removeItemButton.Visible = true;

            string id = cartItemsDisplay.Rows[e.RowIndex].Cells[0].Value.ToString();
            PRODUCT prod = db.PRODUCTs.FirstOrDefault(p => p.prodID == int.Parse(id));
            cartItemNameLabel.Text = cartItemsDisplay.Rows[e.RowIndex].Cells[1].Value.ToString();
            cartItemPriceLabel.Text = "Price: " + string.Format("{0:C}", prod.prodPrice);
            cartItemQtyLabel.Text = "Quantity: " + cartItemsDisplay.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void removeItemButton_Click(object sender, EventArgs e)
        {
            string id = cartItemsDisplay.Rows[selectedCartRowIndex].Cells[0].Value.ToString();
            PRODUCT cartItem = db.PRODUCTs.FirstOrDefault(p => p.prodID == int.Parse(id)) ?? null;

            if (cartItem != null)
            {
                account.RemoveFromCart(cartItem);
                UpdateCartTabData();
            }
        }

        private void makePaymentButton_Click(object sender, EventArgs e)
        {
            decimal amount;
            if (decimal.TryParse(paymentTextBox.Text, out amount))
            {
                account.PayBalance(amount);
                paymentTextBox.Text = "";
            }
            UpdateAccountTab();
            UpdateCartTabData();
        }

        private void sortPurchasesButton_Click(object sender, EventArgs e)
        {
            //GetSortingParams();
        }
    }
}
