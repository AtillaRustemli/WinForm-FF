namespace WinFrom_FF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            headerBackground = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            header = new Label();
            viewer = new DataGridView();
            addProduct = new Button();
            updateProduct = new Button();
            searchProduct = new Button();
            deleteProduct = new Button();
            headerBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)viewer).BeginInit();
            SuspendLayout();
            // 
            // headerBackground
            // 
            headerBackground.BackColor = SystemColors.ActiveCaption;
            headerBackground.Controls.Add(pictureBox2);
            headerBackground.Controls.Add(pictureBox1);
            headerBackground.Controls.Add(header);
            headerBackground.Location = new Point(0, 0);
            headerBackground.Name = "headerBackground";
            headerBackground.Size = new Size(1155, 100);
            headerBackground.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.BMU_logo_svg;
            pictureBox2.Location = new Point(71, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(227, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_warehouse;
            pictureBox1.Location = new Point(861, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(184, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // header
            // 
            header.AutoSize = true;
            header.Font = new Font("Segoe UI Semibold", 26F, FontStyle.Bold);
            header.ForeColor = SystemColors.ButtonHighlight;
            header.Location = new Point(389, 19);
            header.Name = "header";
            header.Size = new Size(328, 47);
            header.TabIndex = 0;
            header.Text = "WareHouse System";
            // 
            // viewer
            // 
            viewer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewer.Location = new Point(335, 155);
            viewer.Name = "viewer";
            viewer.Size = new Size(710, 430);
            viewer.TabIndex = 2;
            // 
            // addProduct
            // 
            addProduct.BackColor = SystemColors.ActiveCaption;
            addProduct.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addProduct.ForeColor = SystemColors.ButtonHighlight;
            addProduct.Location = new Point(12, 155);
            addProduct.Name = "addProduct";
            addProduct.Size = new Size(226, 96);
            addProduct.TabIndex = 3;
            addProduct.Text = "Add Product";
            addProduct.UseVisualStyleBackColor = false;
            addProduct.Click += addProduct_Click;
            // 
            // updateProduct
            // 
            updateProduct.BackColor = SystemColors.ActiveCaption;
            updateProduct.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateProduct.ForeColor = SystemColors.ButtonHighlight;
            updateProduct.Location = new Point(12, 264);
            updateProduct.Name = "updateProduct";
            updateProduct.Size = new Size(226, 103);
            updateProduct.TabIndex = 4;
            updateProduct.Text = "Update Product";
            updateProduct.UseVisualStyleBackColor = false;
            updateProduct.Click += updateProduct_Click;
            // 
            // searchProduct
            // 
            searchProduct.BackColor = SystemColors.ActiveCaption;
            searchProduct.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchProduct.ForeColor = SystemColors.ButtonHighlight;
            searchProduct.Location = new Point(12, 482);
            searchProduct.Name = "searchProduct";
            searchProduct.Size = new Size(226, 103);
            searchProduct.TabIndex = 6;
            searchProduct.Text = "Search Product";
            searchProduct.UseVisualStyleBackColor = false;
            searchProduct.Click += searchProduct_Click;
            // 
            // deleteProduct
            // 
            deleteProduct.BackColor = SystemColors.ActiveCaption;
            deleteProduct.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteProduct.ForeColor = SystemColors.ButtonHighlight;
            deleteProduct.Location = new Point(12, 373);
            deleteProduct.Name = "deleteProduct";
            deleteProduct.Size = new Size(226, 96);
            deleteProduct.TabIndex = 5;
            deleteProduct.Text = "Delete Product";
            deleteProduct.UseVisualStyleBackColor = false;
            deleteProduct.Click += deleteProduct_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 675);
            Controls.Add(searchProduct);
            Controls.Add(deleteProduct);
            Controls.Add(updateProduct);
            Controls.Add(addProduct);
            Controls.Add(viewer);
            Controls.Add(headerBackground);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WareHouse";
            Load += Form1_Load;
            headerBackground.ResumeLayout(false);
            headerBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)viewer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel headerBackground;
        private Label header;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private DataGridView viewer;
        private Button addProduct;
        private Button updateProduct;
        private Button searchProduct;
        private Button deleteProduct;
    }
}
