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
            this.pRODUCTTableAdapter = new SalesProject.StoreProjectDataSet1TableAdapters.PRODUCTTableAdapter();
            this.cartTotalValueLabel = new System.Windows.Forms.Label();
            this.accountTab = new System.Windows.Forms.TabPage();
            this.accountTabHeaderLabel = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.balanceValueLabel = new System.Windows.Forms.Label();
            this.cartTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartItemsDisplay)).BeginInit();
            this.homeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeProjectDataSet1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.accountTab.SuspendLayout();
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
            this.cartHeader.Click += new System.EventHandler(this.cartHeader_Click);
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
            this.tabControl1.Location = new System.Drawing.Point(0, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1414, 873);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // pRODUCTTableAdapter
            // 
            this.pRODUCTTableAdapter.ClearBeforeFill = true;
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
            // accountTab
            // 
            this.accountTab.Controls.Add(this.balanceValueLabel);
            this.accountTab.Controls.Add(this.balanceLabel);
            this.accountTab.Controls.Add(this.accountTabHeaderLabel);
            this.accountTab.Location = new System.Drawing.Point(4, 25);
            this.accountTab.Name = "accountTab";
            this.accountTab.Padding = new System.Windows.Forms.Padding(3);
            this.accountTab.Size = new System.Drawing.Size(1406, 844);
            this.accountTab.TabIndex = 2;
            this.accountTab.Text = "Account";
            this.accountTab.UseVisualStyleBackColor = true;
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
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.BackColor = System.Drawing.Color.Transparent;
            this.balanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceLabel.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.balanceLabel.Location = new System.Drawing.Point(8, 124);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.balanceLabel.Size = new System.Drawing.Size(287, 37);
            this.balanceLabel.TabIndex = 2;
            this.balanceLabel.Text = "Account Balance:";
            // 
            // balanceValueLabel
            // 
            this.balanceValueLabel.AutoSize = true;
            this.balanceValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.balanceValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceValueLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.balanceValueLabel.Location = new System.Drawing.Point(331, 124);
            this.balanceValueLabel.Name = "balanceValueLabel";
            this.balanceValueLabel.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.balanceValueLabel.Size = new System.Drawing.Size(118, 37);
            this.balanceValueLabel.TabIndex = 3;
            this.balanceValueLabel.Text = "$0.00";
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
    }
}