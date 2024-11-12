namespace My_Grocery_Store
{
    partial class AddProduct
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
            header = new Label();
            nameBox = new TextBox();
            idBox = new TextBox();
            priceBox = new TextBox();
            autoIdCheck = new CheckBox();
            labelName = new Label();
            labelID = new Label();
            labelPrice = new Label();
            labelUnits = new Label();
            unitsBox = new ComboBox();
            addProductBtn = new Button();
            exitBtn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // header
            // 
            header.AutoSize = true;
            header.BackColor = SystemColors.ActiveCaption;
            header.Font = new Font("Segoe UI", 19F);
            header.Location = new Point(5, 23);
            header.Name = "header";
            header.Padding = new Padding(0, 0, 140, 0);
            header.Size = new Size(340, 45);
            header.TabIndex = 0;
            header.Text = "Add product";
            header.Click += header_Click;
            // 
            // nameBox
            // 
            nameBox.Font = new Font("Segoe UI", 11F);
            nameBox.Location = new Point(141, 85);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(204, 32);
            nameBox.TabIndex = 1;
            // 
            // idBox
            // 
            idBox.Font = new Font("Segoe UI", 11F);
            idBox.Location = new Point(141, 123);
            idBox.Name = "idBox";
            idBox.Size = new Size(204, 32);
            idBox.TabIndex = 1;
            // 
            // priceBox
            // 
            priceBox.Font = new Font("Segoe UI", 11F);
            priceBox.Location = new Point(141, 161);
            priceBox.Name = "priceBox";
            priceBox.Size = new Size(204, 32);
            priceBox.TabIndex = 1;
            // 
            // autoIdCheck
            // 
            autoIdCheck.AutoSize = true;
            autoIdCheck.Font = new Font("Segoe UI", 11F);
            autoIdCheck.Location = new Point(351, 126);
            autoIdCheck.Name = "autoIdCheck";
            autoIdCheck.Size = new Size(105, 29);
            autoIdCheck.TabIndex = 2;
            autoIdCheck.Text = "AUTO ID";
            autoIdCheck.UseVisualStyleBackColor = true;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 11F);
            labelName.Location = new Point(73, 88);
            labelName.Name = "labelName";
            labelName.Size = new Size(62, 25);
            labelName.TabIndex = 3;
            labelName.Text = "Name";
            labelName.Click += label1_Click;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Segoe UI", 11F);
            labelID.Location = new Point(105, 126);
            labelID.Name = "labelID";
            labelID.Size = new Size(30, 25);
            labelID.TabIndex = 3;
            labelID.Text = "ID";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Segoe UI", 11F);
            labelPrice.Location = new Point(8, 164);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(127, 25);
            labelPrice.TabIndex = 3;
            labelPrice.Text = "Price per Unit";
            // 
            // labelUnits
            // 
            labelUnits.AutoSize = true;
            labelUnits.Font = new Font("Segoe UI", 11F);
            labelUnits.Location = new Point(80, 207);
            labelUnits.Name = "labelUnits";
            labelUnits.Size = new Size(55, 25);
            labelUnits.TabIndex = 3;
            labelUnits.Text = "Units";
            // 
            // unitsBox
            // 
            unitsBox.DropDownStyle = ComboBoxStyle.DropDownList;
            unitsBox.Font = new Font("Segoe UI", 11F);
            unitsBox.FormattingEnabled = true;
            unitsBox.Location = new Point(141, 204);
            unitsBox.Name = "unitsBox";
            unitsBox.Size = new Size(204, 33);
            unitsBox.TabIndex = 4;
            // 
            // addProductBtn
            // 
            addProductBtn.BackColor = Color.YellowGreen;
            addProductBtn.Location = new Point(141, 276);
            addProductBtn.Name = "addProductBtn";
            addProductBtn.Size = new Size(204, 45);
            addProductBtn.TabIndex = 5;
            addProductBtn.Text = "Add Product ";
            addProductBtn.UseVisualStyleBackColor = false;
            addProductBtn.Click += addProductBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.DarkSalmon;
            exitBtn.Location = new Point(362, 23);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(94, 45);
            exitBtn.TabIndex = 6;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 261);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 7;
            label1.Text = "label1";
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(459, 350);
            Controls.Add(label1);
            Controls.Add(exitBtn);
            Controls.Add(addProductBtn);
            Controls.Add(unitsBox);
            Controls.Add(labelUnits);
            Controls.Add(labelPrice);
            Controls.Add(labelID);
            Controls.Add(labelName);
            Controls.Add(autoIdCheck);
            Controls.Add(priceBox);
            Controls.Add(idBox);
            Controls.Add(nameBox);
            Controls.Add(header);
            Name = "AddProduct";
            Text = "Form1";
            Load += AddProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label header;
        private TextBox nameBox;
        private TextBox idBox;
        private TextBox priceBox;
        private CheckBox autoIdCheck;
        private Label labelName;
        private Label labelID;
        private Label labelPrice;
        private Label labelUnits;
        private ComboBox unitsBox;
        private Button addProductBtn;
        private Button exitBtn;
        private Label label1;
    }
}
