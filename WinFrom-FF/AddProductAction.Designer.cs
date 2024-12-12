namespace WinFrom_FF
{
    partial class AddProductAction
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
            label1 = new Label();
            name = new TextBox();
            nameLabel = new Label();
            costPriceLabel = new Label();
            costPrice = new TextBox();
            priceLabel = new Label();
            price = new TextBox();
            discountLabel = new Label();
            discount = new TextBox();
            description = new RichTextBox();
            descriptionLabel = new Label();
            category = new ComboBox();
            categoryLabel = new Label();
            quantityInStock = new MaskedTextBox();
            quantityInStockLabel = new Label();
            goBack = new Button();
            add = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(-45, 359);
            label1.Name = "label1";
            label1.Size = new Size(19, 30);
            label1.TabIndex = 16;
            label1.Text = " ";
            // 
            // name
            // 
            name.Location = new Point(221, 24);
            name.Name = "name";
            name.Size = new Size(256, 23);
            name.TabIndex = 17;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameLabel.ForeColor = SystemColors.ButtonHighlight;
            nameLabel.Location = new Point(8, 15);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(75, 30);
            nameLabel.TabIndex = 18;
            nameLabel.Text = "Name:";
            // 
            // costPriceLabel
            // 
            costPriceLabel.AutoSize = true;
            costPriceLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            costPriceLabel.ForeColor = SystemColors.ButtonHighlight;
            costPriceLabel.Location = new Point(8, 111);
            costPriceLabel.Name = "costPriceLabel";
            costPriceLabel.Size = new Size(113, 30);
            costPriceLabel.TabIndex = 20;
            costPriceLabel.Text = "Cost Price:";
            // 
            // costPrice
            // 
            costPrice.Location = new Point(221, 118);
            costPrice.Name = "costPrice";
            costPrice.Size = new Size(256, 23);
            costPrice.TabIndex = 19;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            priceLabel.ForeColor = SystemColors.ButtonHighlight;
            priceLabel.Location = new Point(8, 64);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(59, 30);
            priceLabel.TabIndex = 22;
            priceLabel.Text = "Price";
            // 
            // price
            // 
            price.Location = new Point(221, 73);
            price.Name = "price";
            price.Size = new Size(256, 23);
            price.TabIndex = 21;
            // 
            // discountLabel
            // 
            discountLabel.AutoSize = true;
            discountLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            discountLabel.ForeColor = SystemColors.ButtonHighlight;
            discountLabel.Location = new Point(8, 157);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new Size(102, 30);
            discountLabel.TabIndex = 24;
            discountLabel.Text = "Discount:";
            // 
            // discount
            // 
            discount.Location = new Point(221, 164);
            discount.Name = "discount";
            discount.Size = new Size(256, 23);
            discount.TabIndex = 23;
            // 
            // description
            // 
            description.Location = new Point(221, 305);
            description.Name = "description";
            description.Size = new Size(256, 96);
            description.TabIndex = 25;
            description.Text = "";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            descriptionLabel.ForeColor = SystemColors.ButtonHighlight;
            descriptionLabel.Location = new Point(8, 305);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(127, 30);
            descriptionLabel.TabIndex = 26;
            descriptionLabel.Text = "Description:";
            // 
            // category
            // 
            category.FormattingEnabled = true;
            category.Location = new Point(221, 207);
            category.Name = "category";
            category.Size = new Size(256, 23);
            category.TabIndex = 27;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            categoryLabel.ForeColor = SystemColors.ButtonHighlight;
            categoryLabel.Location = new Point(12, 207);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(107, 30);
            categoryLabel.TabIndex = 28;
            categoryLabel.Text = "Category:";
            // 
            // quantityInStock
            // 
            quantityInStock.Location = new Point(221, 255);
            quantityInStock.Mask = "00000000";
            quantityInStock.Name = "quantityInStock";
            quantityInStock.Size = new Size(256, 23);
            quantityInStock.TabIndex = 29;
            quantityInStock.ValidatingType = typeof(int);
            // 
            // quantityInStockLabel
            // 
            quantityInStockLabel.AutoSize = true;
            quantityInStockLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            quantityInStockLabel.ForeColor = SystemColors.ButtonHighlight;
            quantityInStockLabel.Location = new Point(12, 248);
            quantityInStockLabel.Name = "quantityInStockLabel";
            quantityInStockLabel.Size = new Size(184, 30);
            quantityInStockLabel.TabIndex = 30;
            quantityInStockLabel.Text = "Quantity In Stock:";
            // 
            // goBack
            // 
            goBack.BackColor = SystemColors.Highlight;
            goBack.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            goBack.ForeColor = SystemColors.ButtonHighlight;
            goBack.Location = new Point(12, 459);
            goBack.Name = "goBack";
            goBack.Size = new Size(147, 81);
            goBack.TabIndex = 31;
            goBack.Text = "Go back";
            goBack.UseVisualStyleBackColor = false;
            goBack.Click += goBack_Click;
            // 
            // add
            // 
            add.BackColor = SystemColors.Highlight;
            add.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            add.ForeColor = SystemColors.ButtonHighlight;
            add.Location = new Point(330, 459);
            add.Name = "add";
            add.Size = new Size(147, 81);
            add.TabIndex = 32;
            add.Text = "Add";
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click;
            // 
            // AddProductAction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(503, 582);
            Controls.Add(add);
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
            Controls.Add(label1);
            Name = "AddProductAction";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "a";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox name;
        private Label nameLabel;
        private Label costPriceLabel;
        private TextBox costPrice;
        private Label priceLabel;
        private TextBox price;
        private Label discountLabel;
        private TextBox discount;
        private RichTextBox description;
        private Label descriptionLabel;
        private ComboBox category;
        private Label categoryLabel;
        private MaskedTextBox quantityInStock;
        private Label quantityInStockLabel;
        private Button goBack;
        private Button add;
    }
}