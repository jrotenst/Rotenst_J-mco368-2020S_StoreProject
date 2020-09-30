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
        private StoreDBDataContext db = new StoreDBDataContext();
        private string userID;
        private PRODUCT item;
        public joeysMain(string id)
        {
            InitializeComponent();
            userID = id;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeProjectDataSet1.PRODUCT' table. You can move, or remove it, as needed.
            this.pRODUCTTableAdapter.Fill(this.storeProjectDataSet1.PRODUCT);
            itemList.Sort(itemList.Columns[1], ListSortDirection.Ascending);
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
            addToCartButton.Visible = true;
            stockLabel.Visible = true;

            var row = itemList.Rows[(itemList.SelectedCells[0].RowIndex)];
            string id = row.Cells[0].Value.ToString();
            item = db.PRODUCTs.Single(p => p.prodID.ToString() == id);

            itemNameLabel.Text = item.prodName;
            priceLabel.Text = string.Format("{0:C}", item.prodPrice);

            if (item.prodStock <= 0)
            {
                stockLabel.ForeColor = Color.Red;
                stockLabel.Text = "Out of Stock";
            }
            else if (item.prodStock >= 20)
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
            int quantity = 0;
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
            else if (quantity > item.prodStock)
            {
                MessageBox.Show("Quantity entered exceeds amount in stock");
            }
            else
            {
                //add to cart
            }
            
        }
    }
}
