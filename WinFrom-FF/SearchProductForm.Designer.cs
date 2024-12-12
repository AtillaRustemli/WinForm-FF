namespace WinFrom_FF
{
    partial class SearchProductForm
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
            nameLabel = new Label();
            name = new Label();
            descriptionLabel = new Label();
            description = new RichTextBox();
            price = new Label();
            priceLabel = new Label();
            costPrice = new Label();
            costPriceLabel = new Label();
            discount = new Label();
            discountLabel = new Label();
            category = new Label();
            categoryLabel = new Label();
            quantityInStock = new Label();
            quantityInStockLabel = new Label();
            id = new Label();
            idLabel = new Label();
            searchAgain = new Button();
            goBack = new Button();
            searchPoint = new Panel();
            cancel = new Button();
            searchRightNow = new Button();
            pickedProduct = new ComboBox();
            createdDate = new Label();
            createdDateLabel = new Label();
            searchPoint.SuspendLayout();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameLabel.ForeColor = SystemColors.ButtonHighlight;
            nameLabel.Location = new Point(12, 69);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(92, 32);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name: ";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            name.ForeColor = SystemColors.ButtonHighlight;
            name.Location = new Point(258, 69);
            name.Name = "name";
            name.Size = new Size(0, 32);
            name.TabIndex = 1;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            descriptionLabel.ForeColor = SystemColors.ButtonHighlight;
            descriptionLabel.Location = new Point(12, 418);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(156, 32);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Descriptioin: ";
            // 
            // description
            // 
            description.Location = new Point(258, 429);
            description.Name = "description";
            description.Size = new Size(270, 49);
            description.TabIndex = 3;
            description.Text = "";
            // 
            // price
            // 
            price.AutoSize = true;
            price.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            price.ForeColor = SystemColors.ButtonHighlight;
            price.Location = new Point(258, 121);
            price.Name = "price";
            price.Size = new Size(0, 32);
            price.TabIndex = 5;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            priceLabel.ForeColor = SystemColors.ButtonHighlight;
            priceLabel.Location = new Point(12, 121);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(73, 32);
            priceLabel.TabIndex = 4;
            priceLabel.Text = "Price:";
            // 
            // costPrice
            // 
            costPrice.AutoSize = true;
            costPrice.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            costPrice.ForeColor = SystemColors.ButtonHighlight;
            costPrice.Location = new Point(258, 172);
            costPrice.Name = "costPrice";
            costPrice.Size = new Size(0, 32);
            costPrice.TabIndex = 7;
            // 
            // costPriceLabel
            // 
            costPriceLabel.AutoSize = true;
            costPriceLabel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            costPriceLabel.ForeColor = SystemColors.ButtonHighlight;
            costPriceLabel.Location = new Point(12, 172);
            costPriceLabel.Name = "costPriceLabel";
            costPriceLabel.Size = new Size(128, 32);
            costPriceLabel.TabIndex = 6;
            costPriceLabel.Text = "Cost Price:";
            // 
            // discount
            // 
            discount.AutoSize = true;
            discount.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            discount.ForeColor = SystemColors.ButtonHighlight;
            discount.Location = new Point(258, 222);
            discount.Name = "discount";
            discount.Size = new Size(0, 32);
            discount.TabIndex = 9;
            // 
            // discountLabel
            // 
            discountLabel.AutoSize = true;
            discountLabel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            discountLabel.ForeColor = SystemColors.ButtonHighlight;
            discountLabel.Location = new Point(12, 222);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new Size(122, 32);
            discountLabel.TabIndex = 8;
            discountLabel.Text = "Discount: ";
            // 
            // category
            // 
            category.AutoSize = true;
            category.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            category.ForeColor = SystemColors.ButtonHighlight;
            category.Location = new Point(258, 274);
            category.Name = "category";
            category.Size = new Size(0, 32);
            category.TabIndex = 11;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            categoryLabel.ForeColor = SystemColors.ButtonHighlight;
            categoryLabel.Location = new Point(12, 274);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(120, 32);
            categoryLabel.TabIndex = 10;
            categoryLabel.Text = "Category:";
            // 
            // quantityInStock
            // 
            quantityInStock.AutoSize = true;
            quantityInStock.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            quantityInStock.ForeColor = SystemColors.ButtonHighlight;
            quantityInStock.Location = new Point(258, 324);
            quantityInStock.Name = "quantityInStock";
            quantityInStock.Size = new Size(0, 32);
            quantityInStock.TabIndex = 13;
            // 
            // quantityInStockLabel
            // 
            quantityInStockLabel.AutoSize = true;
            quantityInStockLabel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            quantityInStockLabel.ForeColor = SystemColors.ButtonHighlight;
            quantityInStockLabel.Location = new Point(12, 324);
            quantityInStockLabel.Name = "quantityInStockLabel";
            quantityInStockLabel.Size = new Size(209, 32);
            quantityInStockLabel.TabIndex = 12;
            quantityInStockLabel.Text = "Quantity in Stock:";
            // 
            // id
            // 
            id.AutoSize = true;
            id.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            id.ForeColor = SystemColors.ButtonHighlight;
            id.Location = new Point(258, 19);
            id.Name = "id";
            id.Size = new Size(0, 32);
            id.TabIndex = 15;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            idLabel.ForeColor = SystemColors.ButtonHighlight;
            idLabel.Location = new Point(12, 19);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(48, 32);
            idLabel.TabIndex = 14;
            idLabel.Text = "Id: ";
            // 
            // searchAgain
            // 
            searchAgain.BackColor = SystemColors.Highlight;
            searchAgain.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            searchAgain.ForeColor = SystemColors.ButtonHighlight;
            searchAgain.Location = new Point(258, 514);
            searchAgain.Name = "searchAgain";
            searchAgain.Size = new Size(268, 81);
            searchAgain.TabIndex = 34;
            searchAgain.Text = "Search again";
            searchAgain.UseVisualStyleBackColor = false;
            searchAgain.Click += searchAgain_Click;
            // 
            // goBack
            // 
            goBack.BackColor = SystemColors.Highlight;
            goBack.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            goBack.ForeColor = SystemColors.ButtonHighlight;
            goBack.Location = new Point(12, 514);
            goBack.Name = "goBack";
            goBack.Size = new Size(147, 81);
            goBack.TabIndex = 33;
            goBack.Text = "Go back";
            goBack.UseVisualStyleBackColor = false;
            goBack.Click += goBack_Click;
            // 
            // searchPoint
            // 
            searchPoint.BackColor = Color.Gray;
            searchPoint.Controls.Add(cancel);
            searchPoint.Controls.Add(searchRightNow);
            searchPoint.Controls.Add(pickedProduct);
            searchPoint.Location = new Point(91, 104);
            searchPoint.Name = "searchPoint";
            searchPoint.Size = new Size(376, 335);
            searchPoint.TabIndex = 37;
            // 
            // cancel
            // 
            cancel.BackColor = Color.FromArgb(192, 0, 0);
            cancel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancel.ForeColor = SystemColors.ButtonHighlight;
            cancel.Location = new Point(60, 245);
            cancel.Name = "cancel";
            cancel.Size = new Size(260, 62);
            cancel.TabIndex = 2;
            cancel.Text = "Cancel";
            cancel.UseVisualStyleBackColor = false;
            cancel.Click += cancel_Click;
            // 
            // searchRightNow
            // 
            searchRightNow.BackColor = SystemColors.GradientActiveCaption;
            searchRightNow.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchRightNow.ForeColor = SystemColors.ButtonHighlight;
            searchRightNow.Location = new Point(60, 103);
            searchRightNow.Name = "searchRightNow";
            searchRightNow.Size = new Size(260, 102);
            searchRightNow.TabIndex = 1;
            searchRightNow.Text = "Search ot right  now";
            searchRightNow.UseVisualStyleBackColor = false;
            searchRightNow.Click += searchRightNow_Click;
            // 
            // pickedProduct
            // 
            pickedProduct.FormattingEnabled = true;
            pickedProduct.Location = new Point(60, 28);
            pickedProduct.Name = "pickedProduct";
            pickedProduct.Size = new Size(260, 23);
            pickedProduct.TabIndex = 0;
            // 
            // createdDate
            // 
            createdDate.AutoSize = true;
            createdDate.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createdDate.ForeColor = SystemColors.ButtonHighlight;
            createdDate.Location = new Point(258, 373);
            createdDate.Name = "createdDate";
            createdDate.Size = new Size(0, 32);
            createdDate.TabIndex = 37;
            // 
            // createdDateLabel
            // 
            createdDateLabel.AutoSize = true;
            createdDateLabel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createdDateLabel.ForeColor = SystemColors.ButtonHighlight;
            createdDateLabel.Location = new Point(12, 373);
            createdDateLabel.Name = "createdDateLabel";
            createdDateLabel.Size = new Size(165, 32);
            createdDateLabel.TabIndex = 36;
            createdDateLabel.Text = "Created Date:";
            // 
            // SearchProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(538, 613);
            Controls.Add(searchPoint);
            Controls.Add(createdDate);
            Controls.Add(createdDateLabel);
            Controls.Add(searchAgain);
            Controls.Add(goBack);
            Controls.Add(id);
            Controls.Add(idLabel);
            Controls.Add(quantityInStock);
            Controls.Add(quantityInStockLabel);
            Controls.Add(category);
            Controls.Add(categoryLabel);
            Controls.Add(discount);
            Controls.Add(discountLabel);
            Controls.Add(costPrice);
            Controls.Add(costPriceLabel);
            Controls.Add(price);
            Controls.Add(priceLabel);
            Controls.Add(description);
            Controls.Add(descriptionLabel);
            Controls.Add(name);
            Controls.Add(nameLabel);
            Name = "SearchProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SearchProductForm";
            Load += SearchProductForm_Load;
            searchPoint.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private Label name;
        private Label descriptionLabel;
        private RichTextBox description;
        private Label price;
        private Label priceLabel;
        private Label costPrice;
        private Label costPriceLabel;
        private Label discount;
        private Label discountLabel;
        private Label category;
        private Label categoryLabel;
        private Label quantityInStock;
        private Label quantityInStockLabel;
        private Label id;
        private Label idLabel;
        private Button searchAgain;
        private Button goBack;
        private Panel searchPoint;
        private Button cancel;
        private Button searchRightNow;
        private ComboBox pickedProduct;
        private Label createdDate;
        private Label createdDateLabel;
    }
}