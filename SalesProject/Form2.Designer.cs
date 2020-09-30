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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.JoeysLabel = new System.Windows.Forms.Label();
            this.addToCartButton = new System.Windows.Forms.Button();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.qtyTextBox = new System.Windows.Forms.TextBox();
            this.qtyLabel = new System.Windows.Forms.Label();
            this.stockLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.itemDetailsLabel = new System.Windows.Forms.Label();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.itemList = new System.Windows.Forms.DataGridView();
            this.prodIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.prodPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeProjectDataSet1 = new SalesProject.StoreProjectDataSet1();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pRODUCTTableAdapter = new SalesProject.StoreProjectDataSet1TableAdapters.PRODUCTTableAdapter();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeProjectDataSet1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1406, 844);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.JoeysLabel);
            this.tabPage1.Controls.Add(this.addToCartButton);
            this.tabPage1.Controls.Add(this.itemNameLabel);
            this.tabPage1.Controls.Add(this.qtyTextBox);
            this.tabPage1.Controls.Add(this.qtyLabel);
            this.tabPage1.Controls.Add(this.stockLabel);
            this.tabPage1.Controls.Add(this.priceLabel);
            this.tabPage1.Controls.Add(this.itemDetailsLabel);
            this.tabPage1.Controls.Add(this.searchBar);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.itemList);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1406, 844);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.qtyTextBox.Size = new System.Drawing.Size(49, 22);
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
            this.searchBar.Size = new System.Drawing.Size(266, 22);
            this.searchBar.TabIndex = 2;
            this.searchBar.TextChanged += new System.EventHandler(this.searchBar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Location = new System.Drawing.Point(72, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search";
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
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1414, 873);
            this.tabControl1.TabIndex = 0;
            // 
            // pRODUCTTableAdapter
            // 
            this.pRODUCTTableAdapter.ClearBeforeFill = true;
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
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeProjectDataSet1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.Label label1;
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
    }
}