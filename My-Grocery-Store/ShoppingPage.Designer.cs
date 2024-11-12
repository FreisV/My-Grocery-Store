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
            listView1 = new ListView();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            numericUpDown1 = new NumericUpDown();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
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
            // listView1
            // 
            listView1.Location = new Point(284, 100);
            listView1.Name = "listView1";
            listView1.Size = new Size(240, 154);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(284, 77);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 4;
            label3.Text = "Shopping Page";
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11.25F);
            label5.Location = new Point(324, 266);
            label5.Name = "label5";
            label5.Size = new Size(16, 18);
            label5.TabIndex = 6;
            label5.Text = "0";
            // 
            // button1
            // 
            button1.BackColor = Color.PaleTurquoise;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button1.Location = new Point(20, 260);
            button1.Name = "button1";
            button1.Size = new Size(240, 33);
            button1.TabIndex = 7;
            button1.Text = "Select";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.PaleTurquoise;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button2.Location = new Point(399, 260);
            button2.Name = "button2";
            button2.Size = new Size(125, 33);
            button2.TabIndex = 8;
            button2.Text = "Checkout";
            button2.UseVisualStyleBackColor = false;
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
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 11.25F);
            label10.Location = new Point(131, 320);
            label10.Name = "label10";
            label10.Size = new Size(13, 18);
            label10.TabIndex = 13;
            label10.Text = "-";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 11.25F);
            label11.ImageAlign = ContentAlignment.MiddleRight;
            label11.Location = new Point(131, 344);
            label11.Name = "label11";
            label11.Size = new Size(13, 18);
            label11.TabIndex = 14;
            label11.Text = "-";
            label11.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 11.25F);
            label12.Location = new Point(131, 369);
            label12.Name = "label12";
            label12.Size = new Size(13, 18);
            label12.TabIndex = 15;
            label12.Text = "-";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(131, 395);
            numericUpDown1.Margin = new Padding(2);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(129, 23);
            numericUpDown1.TabIndex = 17;
            // 
            // button3
            // 
            button3.BackColor = Color.PaleTurquoise;
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button3.Location = new Point(20, 449);
            button3.Name = "button3";
            button3.Size = new Size(240, 33);
            button3.TabIndex = 18;
            button3.Text = "Add to basket";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Tomato;
            button4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button4.Location = new Point(284, 449);
            button4.Name = "button4";
            button4.Size = new Size(240, 33);
            button4.TabIndex = 19;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // ShoppingPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(544, 501);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(numericUpDown1);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(listView1);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ShoppingPage";
            Text = "Shopping Page";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox listBox1;
        private ListView listView1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button button2;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private NumericUpDown numericUpDown1;
        private Button button3;
        private Button button4;
    }
}
