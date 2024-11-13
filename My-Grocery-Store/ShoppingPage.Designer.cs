namespace My_Grocery_Store
{
    partial class ShoppingPage
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
            label1 = new Label();
            label2 = new Label();
            listBox1 = new ListBox();
            label3 = new Label();
            label4 = new Label();
            sum = new Label();
            selectButton = new Button();
            checkoutButton = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            productName = new Label();
            id = new Label();
            price = new Label();
            quantity = new NumericUpDown();
            addButton = new Button();
            exitButton = new Button();
            ShoppingBasket = new ListBox();
            ((System.ComponentModel.ISupportInitialize)quantity).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(20, 23);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(210, 37);
            label1.TabIndex = 0;
            label1.Text = "Shopping Page";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(20, 77);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 1;
            label2.Text = "Aviable items";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(20, 100);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(240, 154);
            listBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(284, 77);
            label3.Name = "label3";
            label3.Size = new Size(126, 20);
            label3.TabIndex = 4;
            label3.Text = "Shopping Basket";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.25F);
            label4.Location = new Point(284, 266);
            label4.Name = "label4";
            label4.Size = new Size(43, 18);
            label4.TabIndex = 5;
            label4.Text = "Sum:";
            // 
            // sum
            // 
            sum.AutoSize = true;
            sum.Font = new Font("Microsoft Sans Serif", 11.25F);
            sum.Location = new Point(324, 266);
            sum.Name = "sum";
            sum.Size = new Size(16, 18);
            sum.TabIndex = 6;
            sum.Text = "0";
            // 
            // selectButton
            // 
            selectButton.BackColor = Color.PaleTurquoise;
            selectButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            selectButton.Location = new Point(20, 260);
            selectButton.Name = "selectButton";
            selectButton.Size = new Size(240, 33);
            selectButton.TabIndex = 7;
            selectButton.Text = "Select";
            selectButton.UseVisualStyleBackColor = false;
            selectButton.Click += selectButton_Click;
            // 
            // checkoutButton
            // 
            checkoutButton.BackColor = Color.PaleTurquoise;
            checkoutButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            checkoutButton.Location = new Point(399, 260);
            checkoutButton.Name = "checkoutButton";
            checkoutButton.Size = new Size(125, 33);
            checkoutButton.TabIndex = 8;
            checkoutButton.Text = "Checkout";
            checkoutButton.UseVisualStyleBackColor = false;
            checkoutButton.Click += checkoutButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 11.25F);
            label6.Location = new Point(20, 320);
            label6.Name = "label6";
            label6.Size = new Size(105, 18);
            label6.TabIndex = 9;
            label6.Text = "Product name:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 11.25F);
            label7.Location = new Point(20, 344);
            label7.Name = "label7";
            label7.Size = new Size(26, 18);
            label7.TabIndex = 10;
            label7.Text = "ID:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 11.25F);
            label8.Location = new Point(20, 369);
            label8.Name = "label8";
            label8.Size = new Size(46, 18);
            label8.TabIndex = 11;
            label8.Text = "Price:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 11.25F);
            label9.Location = new Point(20, 394);
            label9.Name = "label9";
            label9.Size = new Size(66, 18);
            label9.TabIndex = 12;
            label9.Text = "Quantity:";
            // 
            // productName
            // 
            productName.AutoSize = true;
            productName.Font = new Font("Microsoft Sans Serif", 11.25F);
            productName.Location = new Point(131, 320);
            productName.Name = "productName";
            productName.Size = new Size(13, 18);
            productName.TabIndex = 13;
            productName.Text = "-";
            // 
            // id
            // 
            id.AutoSize = true;
            id.Font = new Font("Microsoft Sans Serif", 11.25F);
            id.ImageAlign = ContentAlignment.MiddleRight;
            id.Location = new Point(131, 344);
            id.Name = "id";
            id.Size = new Size(13, 18);
            id.TabIndex = 14;
            id.Text = "-";
            id.TextAlign = ContentAlignment.MiddleRight;
            // 
            // price
            // 
            price.AutoSize = true;
            price.Font = new Font("Microsoft Sans Serif", 11.25F);
            price.Location = new Point(131, 369);
            price.Name = "price";
            price.Size = new Size(13, 18);
            price.TabIndex = 15;
            price.Text = "-";
            // 
            // quantity
            // 
            quantity.Location = new Point(131, 395);
            quantity.Margin = new Padding(2);
            quantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            quantity.Name = "quantity";
            quantity.Size = new Size(129, 23);
            quantity.TabIndex = 17;
            quantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            quantity.ValueChanged += quantity_ValueChanged;
            // 
            // addButton
            // 
            addButton.BackColor = Color.PaleTurquoise;
            addButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            addButton.Location = new Point(20, 449);
            addButton.Name = "addButton";
            addButton.Size = new Size(240, 33);
            addButton.TabIndex = 18;
            addButton.Text = "Add to basket";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Tomato;
            exitButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            exitButton.Location = new Point(284, 449);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(240, 33);
            exitButton.TabIndex = 19;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // ShoppingBasket
            // 
            ShoppingBasket.FormattingEnabled = true;
            ShoppingBasket.ItemHeight = 15;
            ShoppingBasket.Location = new Point(284, 100);
            ShoppingBasket.Name = "ShoppingBasket";
            ShoppingBasket.Size = new Size(240, 154);
            ShoppingBasket.TabIndex = 21;
            // 
            // ShoppingPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(544, 501);
            Controls.Add(ShoppingBasket);
            Controls.Add(exitButton);
            Controls.Add(addButton);
            Controls.Add(quantity);
            Controls.Add(price);
            Controls.Add(id);
            Controls.Add(productName);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(checkoutButton);
            Controls.Add(selectButton);
            Controls.Add(sum);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ShoppingPage";
            Text = "Shopping Page";
            Load += ShoppingPage_Load;
            ((System.ComponentModel.ISupportInitialize)quantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox listBox1;
        private Label label3;
        private Label label4;
        private Label sum;
        private Button selectButton;
        private Button checkoutButton;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label productName;
        private Label id;
        private Label price;
        private NumericUpDown quantity;
        private Button addButton;
        private Button exitButton;
        private ListBox ShoppingBasket;
    }
}
