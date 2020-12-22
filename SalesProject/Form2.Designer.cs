namespace SalesProject
{
    partial class joeysMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cartTab = new System.Windows.Forms.TabPage();
            this.cartTotalValueLabel = new System.Windows.Forms.Label();
            this.cartItemQtyLabel = new System.Windows.Forms.Label();
            this.cartItemPriceLabel = new System.Windows.Forms.Label();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.cartTotalLabel = new System.Windows.Forms.Label();
            this.cartItemNameLabel = new System.Windows.Forms.Label();
            this.selectedItemLabel = new System.Windows.Forms.Label();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.cartItemsDisplay = new System.Windows.Forms.DataGridView();
            this.cartHeader = new System.Windows.Forms.Label();
            this.homeTab = new System.Windows.Forms.TabPage();
            this.JoeysLabel = new System.Windows.Forms.Label();
            this.addToCartButton = new System.Windows.Forms.Button();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.qtyTextBox = new System.Windows.Forms.TextBox();
            this.qtyLabel = new System.Windows.Forms.Label();
            this.stockLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.itemDetailsLabel = new System.Windows.Forms.Label();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.itemList = new System.Windows.Forms.DataGridView();
            this.prodIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.prodPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeProjectDataSet1 = new SalesProject.StoreProjectDataSet1();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.accountTab = new System.Windows.Forms.TabPage();
            this.amountLabel = new System.Windows.Forms.Label();
            this.paymentTextBox = new System.Windows.Forms.TextBox();
            this.makePaymentButton = new System.Windows.Forms.Button();
            this.balanceValueLabel = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.accountTabHeaderLabel = new System.Windows.Forms.Label();
            this.pRODUCTTableAdapter = new SalesProject.StoreProjectDataSet1TableAdapters.PRODUCTTableAdapter();
            this.purchaseTab = new System.Windows.Forms.TabPage();
            this.accountNameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.purchaseHistoryLabel = new System.Windows.Forms.Label();
            this.purchasesDisplay = new System.Windows.Forms.DataGridView();
            this.dateRangeLabel1 = new System.Windows.Forms.Label();
            this.dateRangeLabel2 = new System.Windows.Forms.Label();
            this.toDateTextBox = new System.Windows.Forms.TextBox();
            this.fromDateTextBox = new System.Windows.Forms.TextBox();
            this.sortByDateLabel = new System.Windows.Forms.Label();
            this.sortByTotalLabel = new System.Windows.Forms.Label();
            this.fromPriceTextBox = new System.Windows.Forms.TextBox();
            this.toPriceTextBox = new System.Windows.Forms.TextBox();
            this.toPriceLabel = new System.Windows.Forms.Label();
            this.fromPriceLabel = new System.Windows.Forms.Label();
            this.sortPurchasesButton = new System.Windows.Forms.Button();
            this.storeProjectDataSet2 = new SalesProject.StoreProjectDataSet2();
            this.storeProjectDataSet = new SalesProject.StoreProjectDataSet();
            this.storeProjectDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeProjectDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.storeProjectDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cartTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartItemsDisplay)).BeginInit();
            this.homeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeProjectDataSet1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.accountTab.SuspendLayout();
            this.purchaseTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeProjectDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeProjectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeProjectDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeProjectDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeProjectDataSet2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cartTab
            // 
            this.cartTab.Controls.Add(this.cartTotalValueLabel);
            this.cartTab.Controls.Add(this.cartItemQtyLabel);
            this.cartTab.Controls.Add(this.cartItemPriceLabel);
            this.cartTab.Controls.Add(this.removeItemButton);
            this.cartTab.Controls.Add(this.cartTotalLabel);
            this.cartTab.Controls.Add(this.cartItemNameLabel);
            this.cartTab.Controls.Add(this.selectedItemLabel);
            this.cartTab.Controls.Add(this.checkoutButton);
            this.cartTab.Controls.Add(this.cartItemsDisplay);
            this.cartTab.Controls.Add(this.cartHeader);
            this.cartTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartTab.Location = new System.Drawing.Point(4, 25);
            this.cartTab.Name = "cartTab";
            this.cartTab.Padding = new System.Windows.Forms.Padding(3);
            this.cartTab.Size = new System.Drawing.Size(1406, 844);
            this.cartTab.TabIndex = 1;
            this.cartTab.Text = "Cart";
            this.cartTab.UseVisualStyleBackColor = true;
            // 
            // cartTotalValueLabel
            // 
            this.cartTotalValueLabel.AutoSize = true;
            this.cartTotalValueLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartTotalValueLabel.Location = new System.Drawing.Point(636, 482);
            this.cartTotalValueLabel.Name = "cartTotalValueLabel";
            this.cartTotalValueLabel.Size = new System.Drawing.Size(71, 25);
            this.cartTotalValueLabel.TabIndex = 18;
            this.cartTotalValueLabel.Text = "$0.00";
            this.cartTotalValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cartItemQtyLabel
            // 
            this.cartItemQtyLabel.AutoSize = true;
            this.cartItemQtyLabel.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartItemQtyLabel.Location = new System.Drawing.Point(667, 250);
            this.cartItemQtyLabel.Name = "cartItemQtyLabel";
            this.cartItemQtyLabel.Size = new System.Drawing.Size(91, 20);
            this.cartItemQtyLabel.TabIndex = 17;
            this.cartItemQtyLabel.Text = "Quantity:";
            this.cartItemQtyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cartItemPriceLabel
            // 
            this.cartItemPriceLabel.AutoSize = true;
            this.cartItemPriceLabel.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartItemPriceLabel.Location = new System.Drawing.Point(470, 250);
            this.cartItemPriceLabel.Name = "cartItemPriceLabel";
            this.cartItemPriceLabel.Size = new System.Drawing.Size(58, 20);
            this.cartItemPriceLabel.TabIndex = 16;
            this.cartItemPriceLabel.Text = "Price:";
            this.cartItemPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // removeItemButton
            // 
            this.removeItemButton.BackColor = System.Drawing.Color.IndianRed;
            this.removeItemButton.CausesValidation = false;
            this.removeItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeItemButton.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeItemButton.ForeColor = System.Drawing.Color.White;
            this.removeItemButton.Location = new System.Drawing.Point(570, 322);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(236, 53);
            this.removeItemButton.TabIndex = 15;
            this.removeItemButton.Text = "Remove from Cart";
            this.removeItemButton.UseVisualStyleBackColor = false;
            this.removeItemButton.Visible = false;
            this.removeItemButton.Click += new System.EventHandler(this.removeItemButton_Click);
            // 
            // cartTotalLabel
            // 
            this.cartTotalLabel.AutoSize = true;
            this.cartTotalLabel.BackColor = System.Drawing.Color.Transparent;
            this.cartTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartTotalLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.cartTotalLabel.Location = new System.Drawing.Point(458, 474);
            this.cartTotalLabel.Name = "cartTotalLabel";
            this.cartTotalLabel.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.cartTotalLabel.Size = new System.Drawing.Size(172, 36);
            this.cartTotalLabel.TabIndex = 14;
            this.cartTotalLabel.Text = "Cart Total:";
            // 
            // cartItemNameLabel
            // 
            this.cartItemNameLabel.AutoSize = true;
            this.cartItemNameLabel.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartItemNameLabel.Location = new System.Drawing.Point(470, 172);
            this.cartItemNameLabel.Name = "cartItemNameLabel";
            this.cartItemNameLabel.Size = new System.Drawing.Size(160, 20);
            this.cartItemNameLabel.TabIndex = 13;
            this.cartItemNameLabel.Text = "No Item Selected";
            this.cartItemNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectedItemLabel
            // 
            this.selectedItemLabel.AutoSize = true;
            this.selectedItemLabel.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedItemLabel.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.selectedItemLabel.Location = new System.Drawing.Point(519, 101);
            this.selectedItemLabel.Name = "selectedItemLabel";
            this.selectedItemLabel.Size = new System.Drawing.Size(304, 36);
            this.selectedItemLabel.TabIndex = 12;
            this.selectedItemLabel.Text = "Selected Cart Item";
            // 
            // checkoutButton
            // 
            this.checkoutButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.checkoutButton.CausesValidation = false;
            this.checkoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkoutButton.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutButton.ForeColor = System.Drawing.Color.White;
            this.checkoutButton.Location = new System.Drawing.Point(756, 457);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(160, 53);
            this.checkoutButton.TabIndex = 11;
            this.checkoutButton.Text = "Checkout";
            this.checkoutButton.UseVisualStyleBackColor = false;
            this.checkoutButton.Visible = false;
            this.checkoutButton.Click += new System.EventHandler(this.checkoutButton_Click);
            // 
            // cartItemsDisplay
            // 
            this.cartItemsDisplay.AllowUserToAddRows = false;
            this.cartItemsDisplay.AllowUserToDeleteRows = false;
            this.cartItemsDisplay.AllowUserToResizeColumns = false;
            this.cartItemsDisplay.AllowUserToResizeRows = false;
            this.cartItemsDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartItemsDisplay.Location = new System.Drawing.Point(35, 101);
            this.cartItemsDisplay.Name = "cartItemsDisplay";
            this.cartItemsDisplay.RowHeadersWidth = 51;
            this.cartItemsDisplay.RowTemplate.Height = 24;
            this.cartItemsDisplay.Size = new System.Drawing.Size(417, 453);
            this.cartItemsDisplay.TabIndex = 1;
            this.cartItemsDisplay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cartItemsDisplay_CellClick);
            // 
            // cartHeader
            // 
            this.cartHeader.AutoSize = true;
            this.cartHeader.BackColor = System.Drawing.Color.Transparent;
            this.cartHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartHeader.ForeColor = System.Drawing.Color.ForestGreen;
            this.cartHeader.Location = new System.Drawing.Point(413, 19);
            this.cartHeader.Name = "cartHeader";
            this.cartHeader.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.cartHeader.Size = new System.Drawing.Size(115, 46);
            this.cartHeader.TabIndex = 0;
            this.cartHeader.Text = "Cart";
            // 
            // homeTab
            // 
            this.homeTab.Controls.Add(this.JoeysLabel);
            this.homeTab.Controls.Add(this.addToCartButton);
            this.homeTab.Controls.Add(this.itemNameLabel);
            this.homeTab.Controls.Add(this.qtyTextBox);
            this.homeTab.Controls.Add(this.qtyLabel);
            this.homeTab.Controls.Add(this.stockLabel);
            this.homeTab.Controls.Add(this.priceLabel);
            this.homeTab.Controls.Add(this.itemDetailsLabel);
            this.homeTab.Controls.Add(this.searchBar);
            this.homeTab.Controls.Add(this.searchLabel);
            this.homeTab.Controls.Add(this.itemList);
            this.homeTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeTab.Location = new System.Drawing.Point(4, 25);
            this.homeTab.Name = "homeTab";
            this.homeTab.Padding = new System.Windows.Forms.Padding(3);
            this.homeTab.Size = new System.Drawing.Size(1406, 844);
            this.homeTab.TabIndex = 0;
            this.homeTab.Text = "Home";
            this.homeTab.UseVisualStyleBackColor = true;
            // 
            // JoeysLabel
            // 
            this.JoeysLabel.AutoSize = true;
            this.JoeysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JoeysLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.JoeysLabel.Location = new System.Drawing.Point(72, 40);
            this.JoeysLabel.Name = "JoeysLabel";
            this.JoeysLabel.Size = new System.Drawing.Size(519, 46);
            this.JoeysLabel.TabIndex = 11;
            this.JoeysLabel.Text = "                     Joey\'s Grocery";
            // 
            // addToCartButton
            // 
            this.addToCartButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.addToCartButton.CausesValidation = false;
            this.addToCartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToCartButton.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToCartButton.ForeColor = System.Drawing.Color.White;
            this.addToCartButton.Location = new System.Drawing.Point(491, 362);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(160, 53);
            this.addToCartButton.TabIndex = 10;
            this.addToCartButton.Text = "Add to Cart";
            this.addToCartButton.UseVisualStyleBackColor = false;
            this.addToCartButton.Visible = false;
            this.addToCartButton.Click += new System.EventHandler(this.addToCartButton_Click);
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNameLabel.Location = new System.Drawing.Point(487, 229);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(0, 20);
            this.itemNameLabel.TabIndex = 9;
            this.itemNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // qtyTextBox
            // 
            this.qtyTextBox.Location = new System.Drawing.Point(777, 289);
            this.qtyTextBox.Name = "qtyTextBox";
            this.qtyTextBox.Size = new System.Drawing.Size(49, 24);
            this.qtyTextBox.TabIndex = 8;
            this.qtyTextBox.Visible = false;
            // 
            // qtyLabel
            // 
            this.qtyLabel.AutoSize = true;
            this.qtyLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyLabel.Location = new System.Drawing.Point(676, 289);
            this.qtyLabel.Name = "qtyLabel";
            this.qtyLabel.Size = new System.Drawing.Size(78, 18);
            this.qtyLabel.TabIndex = 7;
            this.qtyLabel.Text = "Quantity:";
            this.qtyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.qtyLabel.Visible = false;
            // 
            // stockLabel
            // 
            this.stockLabel.AutoSize = true;
            this.stockLabel.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockLabel.Location = new System.Drawing.Point(710, 378);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(0, 20);
            this.stockLabel.TabIndex = 6;
            this.stockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(487, 287);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(0, 20);
            this.priceLabel.TabIndex = 5;
            // 
            // itemDetailsLabel
            // 
            this.itemDetailsLabel.AutoSize = true;
            this.itemDetailsLabel.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemDetailsLabel.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.itemDetailsLabel.Location = new System.Drawing.Point(586, 146);
            this.itemDetailsLabel.Name = "itemDetailsLabel";
            this.itemDetailsLabel.Size = new System.Drawing.Size(203, 36);
            this.itemDetailsLabel.TabIndex = 3;
            this.itemDetailsLabel.Text = "Item Details";
            // 
            // searchBar
            // 
            this.searchBar.Location = new System.Drawing.Point(183, 160);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(266, 24);
            this.searchBar.TabIndex = 2;
            this.searchBar.TextChanged += new System.EventHandler(this.searchBar_TextChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.searchLabel.Location = new System.Drawing.Point(72, 153);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(95, 29);
            this.searchLabel.TabIndex = 1;
            this.searchLabel.Text = "Search";
            // 
            // itemList
            // 
            this.itemList.AllowUserToAddRows = false;
            this.itemList.AllowUserToDeleteRows = false;
            this.itemList.AutoGenerateColumns = false;
            this.itemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodIDDataGridViewTextBoxColumn,
            this.prodNameDataGridViewTextBoxColumn,
            this.prodPriceDataGridViewTextBoxColumn,
            this.prodStockDataGridViewTextBoxColumn});
            this.itemList.DataSource = this.pRODUCTBindingSource;
            this.itemList.Location = new System.Drawing.Point(70, 208);
            this.itemList.Name = "itemList";
            this.itemList.ReadOnly = true;
            this.itemList.RowHeadersWidth = 51;
            this.itemList.RowTemplate.Height = 24;
            this.itemList.Size = new System.Drawing.Size(379, 401);
            this.itemList.TabIndex = 0;
            this.itemList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemList_CellClick);
            // 
            // prodIDDataGridViewTextBoxColumn
            // 
            this.prodIDDataGridViewTextBoxColumn.DataPropertyName = "prodID";
            this.prodIDDataGridViewTextBoxColumn.HeaderText = "prodID";
            this.prodIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodIDDataGridViewTextBoxColumn.Name = "prodIDDataGridViewTextBoxColumn";
            this.prodIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.prodIDDataGridViewTextBoxColumn.Visible = false;
            this.prodIDDataGridViewTextBoxColumn.Width = 70;
            // 
            // prodNameDataGridViewTextBoxColumn
            // 
            this.prodNameDataGridViewTextBoxColumn.DataPropertyName = "prodName";
            this.prodNameDataGridViewTextBoxColumn.HeaderText = "Item";
            this.prodNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodNameDataGridViewTextBoxColumn.Name = "prodNameDataGridViewTextBoxColumn";
            this.prodNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.prodNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.prodNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.prodNameDataGridViewTextBoxColumn.Width = 215;
            // 
            // prodPriceDataGridViewTextBoxColumn
            // 
            this.prodPriceDataGridViewTextBoxColumn.DataPropertyName = "prodPrice";
            this.prodPriceDataGridViewTextBoxColumn.HeaderText = "prodPrice";
            this.prodPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodPriceDataGridViewTextBoxColumn.Name = "prodPriceDataGridViewTextBoxColumn";
            this.prodPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.prodPriceDataGridViewTextBoxColumn.Visible = false;
            this.prodPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // prodStockDataGridViewTextBoxColumn
            // 
            this.prodStockDataGridViewTextBoxColumn.DataPropertyName = "prodStock";
            this.prodStockDataGridViewTextBoxColumn.HeaderText = "prodStock";
            this.prodStockDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodStockDataGridViewTextBoxColumn.Name = "prodStockDataGridViewTextBoxColumn";
            this.prodStockDataGridViewTextBoxColumn.ReadOnly = true;
            this.prodStockDataGridViewTextBoxColumn.Visible = false;
            this.prodStockDataGridViewTextBoxColumn.Width = 125;
            // 
            // pRODUCTBindingSource
            // 
            this.pRODUCTBindingSource.DataMember = "PRODUCT";
            this.pRODUCTBindingSource.DataSource = this.storeProjectDataSet1;
            // 
            // storeProjectDataSet1
            // 
            this.storeProjectDataSet1.DataSetName = "StoreProjectDataSet1";
            this.storeProjectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.homeTab);
            this.tabControl1.Controls.Add(this.cartTab);
            this.tabControl1.Controls.Add(this.accountTab);
            this.tabControl1.Controls.Add(this.purchaseTab);
            this.tabControl1.Location = new System.Drawing.Point(0, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1414, 873);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // accountTab
            // 
            this.accountTab.Controls.Add(this.emailLabel);
            this.accountTab.Controls.Add(this.addressLabel);
            this.accountTab.Controls.Add(this.accountNameLabel);
            this.accountTab.Controls.Add(this.amountLabel);
            this.accountTab.Controls.Add(this.paymentTextBox);
            this.accountTab.Controls.Add(this.makePaymentButton);
            this.accountTab.Controls.Add(this.balanceValueLabel);
            this.accountTab.Controls.Add(this.balanceLabel);
            this.accountTab.Controls.Add(this.accountTabHeaderLabel);
            this.accountTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountTab.Location = new System.Drawing.Point(4, 25);
            this.accountTab.Name = "accountTab";
            this.accountTab.Padding = new System.Windows.Forms.Padding(3);
            this.accountTab.Size = new System.Drawing.Size(1406, 844);
            this.accountTab.TabIndex = 2;
            this.accountTab.Text = "Account";
            this.accountTab.UseVisualStyleBackColor = true;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.BackColor = System.Drawing.Color.Transparent;
            this.amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.amountLabel.Location = new System.Drawing.Point(243, 463);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.amountLabel.Size = new System.Drawing.Size(172, 26);
            this.amountLabel.TabIndex = 15;
            this.amountLabel.Text = "Enter Amount:";
            // 
            // paymentTextBox
            // 
            this.paymentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentTextBox.Location = new System.Drawing.Point(435, 463);
            this.paymentTextBox.Name = "paymentTextBox";
            this.paymentTextBox.Size = new System.Drawing.Size(141, 26);
            this.paymentTextBox.TabIndex = 13;
            // 
            // makePaymentButton
            // 
            this.makePaymentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.makePaymentButton.CausesValidation = false;
            this.makePaymentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.makePaymentButton.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makePaymentButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.makePaymentButton.Location = new System.Drawing.Point(296, 527);
            this.makePaymentButton.Name = "makePaymentButton";
            this.makePaymentButton.Size = new System.Drawing.Size(280, 53);
            this.makePaymentButton.TabIndex = 12;
            this.makePaymentButton.Text = "Pay Balance";
            this.makePaymentButton.UseVisualStyleBackColor = false;
            this.makePaymentButton.Click += new System.EventHandler(this.makePaymentButton_Click);
            // 
            // balanceValueLabel
            // 
            this.balanceValueLabel.AutoSize = true;
            this.balanceValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.balanceValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceValueLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.balanceValueLabel.Location = new System.Drawing.Point(458, 389);
            this.balanceValueLabel.Name = "balanceValueLabel";
            this.balanceValueLabel.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.balanceValueLabel.Size = new System.Drawing.Size(118, 37);
            this.balanceValueLabel.TabIndex = 3;
            this.balanceValueLabel.Text = "$0.00";
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.BackColor = System.Drawing.Color.Transparent;
            this.balanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceLabel.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.balanceLabel.Location = new System.Drawing.Point(161, 389);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.balanceLabel.Size = new System.Drawing.Size(277, 37);
            this.balanceLabel.TabIndex = 2;
            this.balanceLabel.Text = "Current Balance:";
            // 
            // accountTabHeaderLabel
            // 
            this.accountTabHeaderLabel.AutoSize = true;
            this.accountTabHeaderLabel.BackColor = System.Drawing.Color.Transparent;
            this.accountTabHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountTabHeaderLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.accountTabHeaderLabel.Location = new System.Drawing.Point(316, 25);
            this.accountTabHeaderLabel.Name = "accountTabHeaderLabel";
            this.accountTabHeaderLabel.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.accountTabHeaderLabel.Size = new System.Drawing.Size(305, 46);
            this.accountTabHeaderLabel.TabIndex = 1;
            this.accountTabHeaderLabel.Text = "Account Home";
            // 
            // pRODUCTTableAdapter
            // 
            this.pRODUCTTableAdapter.ClearBeforeFill = true;
            // 
            // purchaseTab
            // 
            this.purchaseTab.Controls.Add(this.sortPurchasesButton);
            this.purchaseTab.Controls.Add(this.fromPriceTextBox);
            this.purchaseTab.Controls.Add(this.toPriceTextBox);
            this.purchaseTab.Controls.Add(this.toPriceLabel);
            this.purchaseTab.Controls.Add(this.fromPriceLabel);
            this.purchaseTab.Controls.Add(this.sortByTotalLabel);
            this.purchaseTab.Controls.Add(this.sortByDateLabel);
            this.purchaseTab.Controls.Add(this.fromDateTextBox);
            this.purchaseTab.Controls.Add(this.toDateTextBox);
            this.purchaseTab.Controls.Add(this.dateRangeLabel2);
            this.purchaseTab.Controls.Add(this.dateRangeLabel1);
            this.purchaseTab.Controls.Add(this.purchasesDisplay);
            this.purchaseTab.Controls.Add(this.purchaseHistoryLabel);
            this.purchaseTab.Location = new System.Drawing.Point(4, 25);
            this.purchaseTab.Name = "purchaseTab";
            this.purchaseTab.Padding = new System.Windows.Forms.Padding(3);
            this.purchaseTab.Size = new System.Drawing.Size(1406, 844);
            this.purchaseTab.TabIndex = 3;
            this.purchaseTab.Text = "Purchase History";
            this.purchaseTab.UseVisualStyleBackColor = true;
            // 
            // accountNameLabel
            // 
            this.accountNameLabel.AutoSize = true;
            this.accountNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.accountNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNameLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.accountNameLabel.Location = new System.Drawing.Point(44, 109);
            this.accountNameLabel.Name = "accountNameLabel";
            this.accountNameLabel.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.accountNameLabel.Size = new System.Drawing.Size(109, 26);
            this.accountNameLabel.TabIndex = 16;
            this.accountNameLabel.Text = "Name:  ";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.BackColor = System.Drawing.Color.Transparent;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addressLabel.Location = new System.Drawing.Point(44, 287);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.addressLabel.Size = new System.Drawing.Size(221, 26);
            this.addressLabel.TabIndex = 17;
            this.addressLabel.Text = "Shipping Address:  ";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.emailLabel.Location = new System.Drawing.Point(44, 198);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.emailLabel.Size = new System.Drawing.Size(106, 26);
            this.emailLabel.TabIndex = 18;
            this.emailLabel.Text = "Email:  ";
            // 
            // purchaseHistoryLabel
            // 
            this.purchaseHistoryLabel.AutoSize = true;
            this.purchaseHistoryLabel.BackColor = System.Drawing.Color.Transparent;
            this.purchaseHistoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseHistoryLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.purchaseHistoryLabel.Location = new System.Drawing.Point(291, 31);
            this.purchaseHistoryLabel.Name = "purchaseHistoryLabel";
            this.purchaseHistoryLabel.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.purchaseHistoryLabel.Size = new System.Drawing.Size(345, 46);
            this.purchaseHistoryLabel.TabIndex = 18;
            this.purchaseHistoryLabel.Text = "Purchase History";
            // 
            // purchasesDisplay
            // 
            this.purchasesDisplay.AllowUserToAddRows = false;
            this.purchasesDisplay.AllowUserToDeleteRows = false;
            this.purchasesDisplay.AllowUserToResizeColumns = false;
            this.purchasesDisplay.AllowUserToResizeRows = false;
            this.purchasesDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchasesDisplay.Location = new System.Drawing.Point(8, 174);
            this.purchasesDisplay.Name = "purchasesDisplay";
            this.purchasesDisplay.ReadOnly = true;
            this.purchasesDisplay.RowHeadersWidth = 51;
            this.purchasesDisplay.RowTemplate.Height = 24;
            this.purchasesDisplay.Size = new System.Drawing.Size(466, 305);
            this.purchasesDisplay.TabIndex = 19;
            // 
            // dateRangeLabel1
            // 
            this.dateRangeLabel1.AutoSize = true;
            this.dateRangeLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dateRangeLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateRangeLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dateRangeLabel1.Location = new System.Drawing.Point(474, 229);
            this.dateRangeLabel1.Name = "dateRangeLabel1";
            this.dateRangeLabel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.dateRangeLabel1.Size = new System.Drawing.Size(89, 26);
            this.dateRangeLabel1.TabIndex = 20;
            this.dateRangeLabel1.Text = "From:";
            // 
            // dateRangeLabel2
            // 
            this.dateRangeLabel2.AutoSize = true;
            this.dateRangeLabel2.BackColor = System.Drawing.Color.Transparent;
            this.dateRangeLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateRangeLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dateRangeLabel2.Location = new System.Drawing.Point(721, 229);
            this.dateRangeLabel2.Name = "dateRangeLabel2";
            this.dateRangeLabel2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.dateRangeLabel2.Size = new System.Drawing.Size(62, 26);
            this.dateRangeLabel2.TabIndex = 21;
            this.dateRangeLabel2.Text = "To:";
            // 
            // toDateTextBox
            // 
            this.toDateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDateTextBox.Location = new System.Drawing.Point(799, 229);
            this.toDateTextBox.Name = "toDateTextBox";
            this.toDateTextBox.Size = new System.Drawing.Size(113, 26);
            this.toDateTextBox.TabIndex = 22;
            // 
            // fromDateTextBox
            // 
            this.fromDateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDateTextBox.Location = new System.Drawing.Point(579, 229);
            this.fromDateTextBox.Name = "fromDateTextBox";
            this.fromDateTextBox.Size = new System.Drawing.Size(126, 26);
            this.fromDateTextBox.TabIndex = 23;
            // 
            // sortByDateLabel
            // 
            this.sortByDateLabel.AutoSize = true;
            this.sortByDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.sortByDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortByDateLabel.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.sortByDateLabel.Location = new System.Drawing.Point(480, 174);
            this.sortByDateLabel.Name = "sortByDateLabel";
            this.sortByDateLabel.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.sortByDateLabel.Size = new System.Drawing.Size(225, 22);
            this.sortByDateLabel.TabIndex = 24;
            this.sortByDateLabel.Text = "Sort by date (mm/dd/yy):";
            // 
            // sortByTotalLabel
            // 
            this.sortByTotalLabel.AutoSize = true;
            this.sortByTotalLabel.BackColor = System.Drawing.Color.Transparent;
            this.sortByTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortByTotalLabel.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.sortByTotalLabel.Location = new System.Drawing.Point(480, 301);
            this.sortByTotalLabel.Name = "sortByTotalLabel";
            this.sortByTotalLabel.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.sortByTotalLabel.Size = new System.Drawing.Size(138, 22);
            this.sortByTotalLabel.TabIndex = 25;
            this.sortByTotalLabel.Text = "Sort by Total:";
            // 
            // fromPriceTextBox
            // 
            this.fromPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromPriceTextBox.Location = new System.Drawing.Point(579, 350);
            this.fromPriceTextBox.Name = "fromPriceTextBox";
            this.fromPriceTextBox.Size = new System.Drawing.Size(126, 26);
            this.fromPriceTextBox.TabIndex = 29;
            // 
            // toPriceTextBox
            // 
            this.toPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toPriceTextBox.Location = new System.Drawing.Point(804, 350);
            this.toPriceTextBox.Name = "toPriceTextBox";
            this.toPriceTextBox.Size = new System.Drawing.Size(113, 26);
            this.toPriceTextBox.TabIndex = 28;
            // 
            // toPriceLabel
            // 
            this.toPriceLabel.AutoSize = true;
            this.toPriceLabel.BackColor = System.Drawing.Color.Transparent;
            this.toPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toPriceLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toPriceLabel.Location = new System.Drawing.Point(726, 350);
            this.toPriceLabel.Name = "toPriceLabel";
            this.toPriceLabel.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.toPriceLabel.Size = new System.Drawing.Size(62, 26);
            this.toPriceLabel.TabIndex = 27;
            this.toPriceLabel.Text = "To:";
            // 
            // fromPriceLabel
            // 
            this.fromPriceLabel.AutoSize = true;
            this.fromPriceLabel.BackColor = System.Drawing.Color.Transparent;
            this.fromPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromPriceLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fromPriceLabel.Location = new System.Drawing.Point(474, 350);
            this.fromPriceLabel.Name = "fromPriceLabel";
            this.fromPriceLabel.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.fromPriceLabel.Size = new System.Drawing.Size(89, 26);
            this.fromPriceLabel.TabIndex = 26;
            this.fromPriceLabel.Text = "From:";
            // 
            // sortPurchasesButton
            // 
            this.sortPurchasesButton.BackColor = System.Drawing.Color.MediumTurquoise;
            this.sortPurchasesButton.CausesValidation = false;
            this.sortPurchasesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortPurchasesButton.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortPurchasesButton.ForeColor = System.Drawing.Color.White;
            this.sortPurchasesButton.Location = new System.Drawing.Point(579, 426);
            this.sortPurchasesButton.Name = "sortPurchasesButton";
            this.sortPurchasesButton.Size = new System.Drawing.Size(236, 53);
            this.sortPurchasesButton.TabIndex = 30;
            this.sortPurchasesButton.Text = "Sort";
            this.sortPurchasesButton.UseVisualStyleBackColor = false;
            this.sortPurchasesButton.Click += new System.EventHandler(this.sortPurchasesButton_Click);
            // 
            // storeProjectDataSet2
            // 
            this.storeProjectDataSet2.DataSetName = "StoreProjectDataSet2";
            this.storeProjectDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // storeProjectDataSet
            // 
            this.storeProjectDataSet.DataSetName = "StoreProjectDataSet";
            this.storeProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // storeProjectDataSetBindingSource
            // 
            this.storeProjectDataSetBindingSource.DataSource = this.storeProjectDataSet;
            this.storeProjectDataSetBindingSource.Position = 0;
            // 
            // storeProjectDataSetBindingSource1
            // 
            this.storeProjectDataSetBindingSource1.DataSource = this.storeProjectDataSet;
            this.storeProjectDataSetBindingSource1.Position = 0;
            // 
            // storeProjectDataSet2BindingSource
            // 
            this.storeProjectDataSet2BindingSource.DataSource = this.storeProjectDataSet2;
            this.storeProjectDataSet2BindingSource.Position = 0;
            // 
            // joeysMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 722);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "joeysMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Joey\'s";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.cartTab.ResumeLayout(false);
            this.cartTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartItemsDisplay)).EndInit();
            this.homeTab.ResumeLayout(false);
            this.homeTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeProjectDataSet1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.accountTab.ResumeLayout(false);
            this.accountTab.PerformLayout();
            this.purchaseTab.ResumeLayout(false);
            this.purchaseTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeProjectDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeProjectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeProjectDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeProjectDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeProjectDataSet2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage cartTab;
        private System.Windows.Forms.TabPage homeTab;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.DataGridView itemList;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label itemDetailsLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.TextBox qtyTextBox;
        private System.Windows.Forms.Label qtyLabel;
        private System.Windows.Forms.Label stockLabel;
        private System.Windows.Forms.Button addToCartButton;
        private System.Windows.Forms.Label JoeysLabel;
        private StoreProjectDataSet1 storeProjectDataSet1;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource;
        private StoreProjectDataSet1TableAdapters.PRODUCTTableAdapter pRODUCTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn prodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label cartHeader;
        private System.Windows.Forms.DataGridView cartItemsDisplay;
        private System.Windows.Forms.Button checkoutButton;
        private System.Windows.Forms.Label cartItemNameLabel;
        private System.Windows.Forms.Label selectedItemLabel;
        private System.Windows.Forms.Label cartTotalLabel;
        private System.Windows.Forms.Label cartItemQtyLabel;
        private System.Windows.Forms.Label cartItemPriceLabel;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.Label cartTotalValueLabel;
        private System.Windows.Forms.TabPage accountTab;
        private System.Windows.Forms.Label balanceValueLabel;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Label accountTabHeaderLabel;
        private System.Windows.Forms.TextBox paymentTextBox;
        private System.Windows.Forms.Button makePaymentButton;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.TabPage purchaseTab;
        private System.Windows.Forms.Label accountNameLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label purchaseHistoryLabel;
        private System.Windows.Forms.DataGridView purchasesDisplay;
        private System.Windows.Forms.Label sortByDateLabel;
        private System.Windows.Forms.TextBox fromDateTextBox;
        private System.Windows.Forms.TextBox toDateTextBox;
        private System.Windows.Forms.Label dateRangeLabel2;
        private System.Windows.Forms.Label dateRangeLabel1;
        private System.Windows.Forms.TextBox fromPriceTextBox;
        private System.Windows.Forms.TextBox toPriceTextBox;
        private System.Windows.Forms.Label toPriceLabel;
        private System.Windows.Forms.Label fromPriceLabel;
        private System.Windows.Forms.Label sortByTotalLabel;
        private System.Windows.Forms.Button sortPurchasesButton;
        private StoreProjectDataSet2 storeProjectDataSet2;
        private System.Windows.Forms.BindingSource storeProjectDataSetBindingSource;
        private StoreProjectDataSet storeProjectDataSet;
        private System.Windows.Forms.BindingSource storeProjectDataSetBindingSource1;
        private System.Windows.Forms.BindingSource storeProjectDataSet2BindingSource;
    }
}