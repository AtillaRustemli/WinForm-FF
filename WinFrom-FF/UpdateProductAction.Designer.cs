namespace WinFrom_FF
{
    partial class UpdateProductAction
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
            update = new Button();
            goBack = new Button();
            quantityInStockLabel = new Label();
            quantityInStock = new MaskedTextBox();
            categoryLabel = new Label();
            category = new ComboBox();
            descriptionLabel = new Label();
            description = new RichTextBox();
            discountLabel = new Label();
            discount = new TextBox();
            priceLabel = new Label();
            price = new TextBox();
            costPriceLabel = new Label();
            costPrice = new TextBox();
            nameLabel = new Label();
            name = new TextBox();
            allProducts = new ComboBox();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            titleLabel = new Label();
            SuspendLayout();
            // 
            // update
            // 
            update.BackColor = SystemColors.Highlight;
            update.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            update.ForeColor = SystemColors.ButtonHighlight;
            update.Location = new Point(339, 473);
            update.Name = "update";
            update.Size = new Size(147, 81);
            update.TabIndex = 48;
            update.Text = "Update";
            update.UseVisualStyleBackColor = false;
            update.Click += update_Click;
            // 
            // goBack
            // 
            goBack.BackColor = SystemColors.Highlight;
            goBack.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            goBack.ForeColor = SystemColors.ButtonHighlight;
            goBack.Location = new Point(21, 473);
            goBack.Name = "goBack";
            goBack.Size = new Size(147, 81);
            goBack.TabIndex = 47;
            goBack.Text = "Go back";
            goBack.UseVisualStyleBackColor = false;
            goBack.Click += goBack_Click;
            // 
            // quantityInStockLabel
            // 
            quantityInStockLabel.AutoSize = true;
            quantityInStockLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            quantityInStockLabel.ForeColor = SystemColors.ButtonHighlight;
            quantityInStockLabel.Location = new Point(25, 305);
            quantityInStockLabel.Name = "quantityInStockLabel";
            quantityInStockLabel.Size = new Size(184, 30);
            quantityInStockLabel.TabIndex = 46;
            quantityInStockLabel.Text = "Quantity In Stock:";
            // 
            // quantityInStock
            // 
            quantityInStock.Location = new Point(230, 312);
            quantityInStock.Mask = "00000000";
            quantityInStock.Name = "quantityInStock";
            quantityInStock.Size = new Size(256, 23);
            quantityInStock.TabIndex = 45;
            quantityInStock.ValidatingType = typeof(int);
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            categoryLabel.ForeColor = SystemColors.ButtonHighlight;
            categoryLabel.Location = new Point(25, 264);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(107, 30);
            categoryLabel.TabIndex = 44;
            categoryLabel.Text = "Category:";
            // 
            // category
            // 
            category.FormattingEnabled = true;
            category.Location = new Point(230, 264);
            category.Name = "category";
            category.Size = new Size(256, 23);
            category.TabIndex = 43;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            descriptionLabel.ForeColor = SystemColors.ButtonHighlight;
            descriptionLabel.Location = new Point(25, 353);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(127, 30);
            descriptionLabel.TabIndex = 42;
            descriptionLabel.Text = "Description:";
            // 
            // description
            // 
            description.Location = new Point(235, 353);
            description.Name = "description";
            description.Size = new Size(256, 96);
            description.TabIndex = 41;
            description.Text = "";
            // 
            // discountLabel
            // 
            discountLabel.AutoSize = true;
            discountLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            discountLabel.ForeColor = SystemColors.ButtonHighlight;
            discountLabel.Location = new Point(21, 214);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new Size(102, 30);
            discountLabel.TabIndex = 40;
            discountLabel.Text = "Discount:";
            // 
            // discount
            // 
            discount.Location = new Point(230, 221);
            discount.Name = "discount";
            discount.Size = new Size(256, 23);
            discount.TabIndex = 39;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            priceLabel.ForeColor = SystemColors.ButtonHighlight;
            priceLabel.Location = new Point(21, 121);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(59, 30);
            priceLabel.TabIndex = 38;
            priceLabel.Text = "Price";
            // 
            // price
            // 
            price.Location = new Point(230, 130);
            price.Name = "price";
            price.Size = new Size(256, 23);
            price.TabIndex = 37;
            // 
            // costPriceLabel
            // 
            costPriceLabel.AutoSize = true;
            costPriceLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            costPriceLabel.ForeColor = SystemColors.ButtonHighlight;
            costPriceLabel.Location = new Point(21, 168);
            costPriceLabel.Name = "costPriceLabel";
            costPriceLabel.Size = new Size(113, 30);
            costPriceLabel.TabIndex = 36;
            costPriceLabel.Text = "Cost Price:";
            // 
            // costPrice
            // 
            costPrice.Location = new Point(230, 175);
            costPrice.Name = "costPrice";
            costPrice.Size = new Size(256, 23);
            costPrice.TabIndex = 35;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameLabel.ForeColor = SystemColors.ButtonHighlight;
            nameLabel.Location = new Point(21, 77);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(75, 30);
            nameLabel.TabIndex = 34;
            nameLabel.Text = "Name:";
            // 
            // name
            // 
            name.Location = new Point(230, 86);
            name.Name = "name";
            name.Size = new Size(256, 23);
            name.TabIndex = 33;
            // 
            // allProducts
            // 
            allProducts.FormattingEnabled = true;
            allProducts.Location = new Point(103, 42);
            allProducts.Name = "allProducts";
            allProducts.Size = new Size(255, 23);
            allProducts.TabIndex = 49;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = SystemColors.ButtonHighlight;
            titleLabel.Location = new Point(103, 9);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(255, 30);
            titleLabel.TabIndex = 50;
            titleLabel.Text = "Chose product to update";
            // 
            // UpdateProductAction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(503, 582);
            Controls.Add(titleLabel);
            Controls.Add(allProducts);
            Controls.Add(update);
            Controls.Add(goBack);
            Controls.Add(quantityInStockLabel);
            Controls.Add(quantityInStock);
            Controls.Add(categoryLabel);
            Controls.Add(category);
            Controls.Add(descriptionLabel);
            Controls.Add(description);
            Controls.Add(discountLabel);
            Controls.Add(discount);
            Controls.Add(priceLabel);
            Controls.Add(price);
            Controls.Add(costPriceLabel);
            Controls.Add(costPrice);
            Controls.Add(nameLabel);
            Controls.Add(name);
            Name = "UpdateProductAction";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "a";
            Load += UpdateProductAction_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button update;
        private Button goBack;
        private Label quantityInStockLabel;
        private MaskedTextBox quantityInStock;
        private Label categoryLabel;
        private ComboBox category;
        private Label descriptionLabel;
        private RichTextBox description;
        private Label discountLabel;
        private TextBox discount;
        private Label priceLabel;
        private TextBox price;
        private Label costPriceLabel;
        private TextBox costPrice;
        private Label nameLabel;
        private TextBox name;
        private ComboBox allProducts;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Label titleLabel;
    }
}