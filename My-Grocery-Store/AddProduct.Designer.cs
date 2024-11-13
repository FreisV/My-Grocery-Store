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
            SuspendLayout();
            // 
            // header
            // 
            header.AutoSize = true;
            header.BackColor = SystemColors.ActiveCaption;
            header.Font = new Font("Segoe UI", 19F);
            header.Location = new Point(4, 17);
            header.Name = "header";
            header.Padding = new Padding(0, 0, 122, 0);
            header.Size = new Size(281, 36);
            header.TabIndex = 0;
            header.Text = "Add product";
            header.Click += header_Click;
            // 
            // nameBox
            // 
            nameBox.Font = new Font("Segoe UI", 11F);
            nameBox.Location = new Point(123, 64);
            nameBox.Margin = new Padding(3, 2, 3, 2);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(179, 27);
            nameBox.TabIndex = 1;
            // 
            // idBox
            // 
            idBox.Font = new Font("Segoe UI", 11F);
            idBox.Location = new Point(123, 92);
            idBox.Margin = new Padding(3, 2, 3, 2);
            idBox.Name = "idBox";
            idBox.Size = new Size(179, 27);
            idBox.TabIndex = 1;
            idBox.TextChanged += idBox_TextChanged;
            // 
            // priceBox
            // 
            priceBox.Font = new Font("Segoe UI", 11F);
            priceBox.Location = new Point(123, 121);
            priceBox.Margin = new Padding(3, 2, 3, 2);
            priceBox.Name = "priceBox";
            priceBox.Size = new Size(179, 27);
            priceBox.TabIndex = 1;
            // 
            // autoIdCheck
            // 
            autoIdCheck.AutoSize = true;
            autoIdCheck.Font = new Font("Segoe UI", 11F);
            autoIdCheck.Location = new Point(307, 94);
            autoIdCheck.Margin = new Padding(3, 2, 3, 2);
            autoIdCheck.Name = "autoIdCheck";
            autoIdCheck.Size = new Size(85, 24);
            autoIdCheck.TabIndex = 2;
            autoIdCheck.Text = "AUTO ID";
            autoIdCheck.UseVisualStyleBackColor = true;
            autoIdCheck.CheckedChanged += autoIdCheck_CheckedChanged;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 11F);
            labelName.Location = new Point(64, 66);
            labelName.Name = "labelName";
            labelName.Size = new Size(49, 20);
            labelName.TabIndex = 3;
            labelName.Text = "Name";
            labelName.Click += label1_Click;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Segoe UI", 11F);
            labelID.Location = new Point(92, 94);
            labelID.Name = "labelID";
            labelID.Size = new Size(24, 20);
            labelID.TabIndex = 3;
            labelID.Text = "ID";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Segoe UI", 11F);
            labelPrice.Location = new Point(7, 123);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(98, 20);
            labelPrice.TabIndex = 3;
            labelPrice.Text = "Price per Unit";
            // 
            // labelUnits
            // 
            labelUnits.AutoSize = true;
            labelUnits.Font = new Font("Segoe UI", 11F);
            labelUnits.Location = new Point(70, 155);
            labelUnits.Name = "labelUnits";
            labelUnits.Size = new Size(42, 20);
            labelUnits.TabIndex = 3;
            labelUnits.Text = "Units";
            // 
            // unitsBox
            // 
            unitsBox.DropDownStyle = ComboBoxStyle.DropDownList;
            unitsBox.Font = new Font("Segoe UI", 11F);
            unitsBox.FormattingEnabled = true;
            unitsBox.Location = new Point(123, 153);
            unitsBox.Margin = new Padding(3, 2, 3, 2);
            unitsBox.Name = "unitsBox";
            unitsBox.Size = new Size(179, 28);
            unitsBox.TabIndex = 4;
            // 
            // addProductBtn
            // 
            addProductBtn.BackColor = Color.YellowGreen;
            addProductBtn.Location = new Point(123, 207);
            addProductBtn.Margin = new Padding(3, 2, 3, 2);
            addProductBtn.Name = "addProductBtn";
            addProductBtn.Size = new Size(178, 34);
            addProductBtn.TabIndex = 5;
            addProductBtn.Text = "Add Product ";
            addProductBtn.UseVisualStyleBackColor = false;
            addProductBtn.Click += addProductBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.DarkSalmon;
            exitBtn.Location = new Point(317, 17);
            exitBtn.Margin = new Padding(3, 2, 3, 2);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(82, 34);
            exitBtn.TabIndex = 6;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Lavender;
            ClientSize = new Size(402, 262);
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
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
    }
}
