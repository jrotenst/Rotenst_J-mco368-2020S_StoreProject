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
        private string userID;
        private Cart cart;
        private PRODUCT selectedItem;
        private int selectedCartRowIndex;
        private int quantity;
        private StoreDBDataContext db = new StoreDBDataContext();

        public joeysMain(string userID)
        {
            InitializeComponent();
            this.userID = userID;
            cart = new Cart(userID);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.pRODUCTTableAdapter.Fill(this.storeProjectDataSet1.PRODUCT);
            itemList.Sort(itemList.Columns[1], ListSortDirection.Ascending);
            UpdateCartTabData();
            UpdateAccountTab();
        }

        private void UpdateCartTabData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("SKU", typeof(int));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Quantity", typeof(int));

            cart.GetCartItems().ToList().ForEach(kvp => dt.Rows.Add(new object[]
            {
                kvp.Key.prodID, 
                kvp.Key.prodName, 
                kvp.Value
            }));

            cartItemsDisplay.DataSource = dt;
            
            if (cart.GetCartItems().Count > 0)
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
            cartTotalValueLabel.Text = string.Format("{0:C}", cart.GetCartTotal());
        }

        private void UpdateAccountTab()
        {
            balanceValueLabel.Text = GetUserBalance();
        }

        private string GetUserBalance()
        {
            decimal bal = db.CUSTOMERs.Single(c => c.userID == userID).balance ?? 0;
            return string.Format("{0:C}", bal);
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
                cart.AddToCart(selectedItem, quantity);
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

        private void cartHeader_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCartTabData();
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            if (cart.GetCartItems().Count != 0)
            {
                if (cart.AttemptCheckout())
                {
                    db = new StoreDBDataContext();
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
                cart.RemoveFromCart(cartItem);
                UpdateCartTabData();
            }
        }
    }
}
