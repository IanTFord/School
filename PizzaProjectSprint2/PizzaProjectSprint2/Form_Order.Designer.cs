namespace PizzaProjectSprint2 {
    partial class Form_Order {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btn_signout = new System.Windows.Forms.Button();
            this.btn_checkout = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.drop_drinkSize = new System.Windows.Forms.ComboBox();
            this.drop_drink = new System.Windows.Forms.ComboBox();
            this.btn_adddrink = new System.Windows.Forms.Button();
            this.lbl_size = new System.Windows.Forms.Label();
            this.lbl_drinktype = new System.Windows.Forms.Label();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.txtb_drinkQuantity = new System.Windows.Forms.TextBox();
            this.txtb_pizzaQuantity = new System.Windows.Forms.TextBox();
            this.lbl_pizzaQuantity = new System.Windows.Forms.Label();
            this.lbl_crust = new System.Windows.Forms.Label();
            this.lbl_pizzaSize = new System.Windows.Forms.Label();
            this.drop_crust = new System.Windows.Forms.ComboBox();
            this.drop_pizzaSize = new System.Windows.Forms.ComboBox();
            this.btn_addpizza = new System.Windows.Forms.Button();
            this.checkbtns_toppings = new System.Windows.Forms.CheckedListBox();
            this.lbl_toppings = new System.Windows.Forms.Label();
            this.lbl_drinkerror = new System.Windows.Forms.Label();
            this.lbl_pizzaerror = new System.Windows.Forms.Label();
            this.group_order = new System.Windows.Forms.GroupBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.checkbtns_order = new System.Windows.Forms.CheckedListBox();
            this.lbl_totalprice = new System.Windows.Forms.Label();
            this.group_ordersummary = new System.Windows.Forms.GroupBox();
            this.lbl_order = new System.Windows.Forms.Label();
            this.btn_removeitems = new System.Windows.Forms.Button();
            this.group_order.SuspendLayout();
            this.group_ordersummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_signout
            // 
            this.btn_signout.Location = new System.Drawing.Point(13, 13);
            this.btn_signout.Name = "btn_signout";
            this.btn_signout.Size = new System.Drawing.Size(75, 23);
            this.btn_signout.TabIndex = 0;
            this.btn_signout.Text = "Sign out";
            this.btn_signout.UseVisualStyleBackColor = true;
            this.btn_signout.Click += new System.EventHandler(this.btn_signout_Click);
            // 
            // btn_checkout
            // 
            this.btn_checkout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_checkout.Location = new System.Drawing.Point(282, 209);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(161, 77);
            this.btn_checkout.TabIndex = 1;
            this.btn_checkout.Text = "Check Out";
            this.btn_checkout.UseVisualStyleBackColor = true;
            this.btn_checkout.Click += new System.EventHandler(this.btn_checkout_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(0, 8);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // drop_drinkSize
            // 
            this.drop_drinkSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drop_drinkSize.FormattingEnabled = true;
            this.drop_drinkSize.Items.AddRange(new object[] {
            "Small - $1.00",
            "Medium - $2.00",
            "Large - $3.00"});
            this.drop_drinkSize.Location = new System.Drawing.Point(301, 39);
            this.drop_drinkSize.Name = "drop_drinkSize";
            this.drop_drinkSize.Size = new System.Drawing.Size(121, 21);
            this.drop_drinkSize.TabIndex = 3;
            // 
            // drop_drink
            // 
            this.drop_drink.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drop_drink.FormattingEnabled = true;
            this.drop_drink.Items.AddRange(new object[] {
            "Coca Cola",
            "Sprite",
            "Root Beer",
            "Mr Pib",
            "Lemonade"});
            this.drop_drink.Location = new System.Drawing.Point(301, 12);
            this.drop_drink.Name = "drop_drink";
            this.drop_drink.Size = new System.Drawing.Size(121, 21);
            this.drop_drink.TabIndex = 5;
            // 
            // btn_adddrink
            // 
            this.btn_adddrink.Location = new System.Drawing.Point(325, 103);
            this.btn_adddrink.Name = "btn_adddrink";
            this.btn_adddrink.Size = new System.Drawing.Size(75, 23);
            this.btn_adddrink.TabIndex = 6;
            this.btn_adddrink.Text = "Add to Cart";
            this.btn_adddrink.UseVisualStyleBackColor = true;
            this.btn_adddrink.Click += new System.EventHandler(this.btn_adddrink_Click);
            // 
            // lbl_size
            // 
            this.lbl_size.AutoSize = true;
            this.lbl_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_size.Location = new System.Drawing.Point(256, 40);
            this.lbl_size.Name = "lbl_size";
            this.lbl_size.Size = new System.Drawing.Size(39, 15);
            this.lbl_size.TabIndex = 7;
            this.lbl_size.Text = "Size:";
            // 
            // lbl_drinktype
            // 
            this.lbl_drinktype.AutoSize = true;
            this.lbl_drinktype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_drinktype.Location = new System.Drawing.Point(250, 13);
            this.lbl_drinktype.Name = "lbl_drinktype";
            this.lbl_drinktype.Size = new System.Drawing.Size(45, 15);
            this.lbl_drinktype.TabIndex = 8;
            this.lbl_drinktype.Text = "Drink:";
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantity.Location = new System.Drawing.Point(276, 69);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(63, 15);
            this.lbl_quantity.TabIndex = 9;
            this.lbl_quantity.Text = "Quantity:";
            // 
            // txtb_drinkQuantity
            // 
            this.txtb_drinkQuantity.Location = new System.Drawing.Point(345, 68);
            this.txtb_drinkQuantity.Name = "txtb_drinkQuantity";
            this.txtb_drinkQuantity.Size = new System.Drawing.Size(34, 20);
            this.txtb_drinkQuantity.TabIndex = 10;
            // 
            // txtb_pizzaQuantity
            // 
            this.txtb_pizzaQuantity.Location = new System.Drawing.Point(119, 208);
            this.txtb_pizzaQuantity.Name = "txtb_pizzaQuantity";
            this.txtb_pizzaQuantity.Size = new System.Drawing.Size(34, 20);
            this.txtb_pizzaQuantity.TabIndex = 16;
            // 
            // lbl_pizzaQuantity
            // 
            this.lbl_pizzaQuantity.AutoSize = true;
            this.lbl_pizzaQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pizzaQuantity.Location = new System.Drawing.Point(50, 209);
            this.lbl_pizzaQuantity.Name = "lbl_pizzaQuantity";
            this.lbl_pizzaQuantity.Size = new System.Drawing.Size(63, 15);
            this.lbl_pizzaQuantity.TabIndex = 15;
            this.lbl_pizzaQuantity.Text = "Quantity:";
            // 
            // lbl_crust
            // 
            this.lbl_crust.AutoSize = true;
            this.lbl_crust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_crust.Location = new System.Drawing.Point(28, 15);
            this.lbl_crust.Name = "lbl_crust";
            this.lbl_crust.Size = new System.Drawing.Size(44, 15);
            this.lbl_crust.TabIndex = 14;
            this.lbl_crust.Text = "Crust:";
            // 
            // lbl_pizzaSize
            // 
            this.lbl_pizzaSize.AutoSize = true;
            this.lbl_pizzaSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pizzaSize.Location = new System.Drawing.Point(34, 42);
            this.lbl_pizzaSize.Name = "lbl_pizzaSize";
            this.lbl_pizzaSize.Size = new System.Drawing.Size(39, 15);
            this.lbl_pizzaSize.TabIndex = 13;
            this.lbl_pizzaSize.Text = "Size:";
            // 
            // drop_crust
            // 
            this.drop_crust.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drop_crust.FormattingEnabled = true;
            this.drop_crust.Items.AddRange(new object[] {
            "Regular - $0.00",
            "Thin - $0.50",
            "Thick - $0.50",
            "Cheese Stuffed - $2.00"});
            this.drop_crust.Location = new System.Drawing.Point(79, 14);
            this.drop_crust.Name = "drop_crust";
            this.drop_crust.Size = new System.Drawing.Size(121, 21);
            this.drop_crust.TabIndex = 12;
            // 
            // drop_pizzaSize
            // 
            this.drop_pizzaSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drop_pizzaSize.FormattingEnabled = true;
            this.drop_pizzaSize.Items.AddRange(new object[] {
            "Small - $7.00",
            "Medium - $11.00",
            "Large - $14.00"});
            this.drop_pizzaSize.Location = new System.Drawing.Point(79, 41);
            this.drop_pizzaSize.Name = "drop_pizzaSize";
            this.drop_pizzaSize.Size = new System.Drawing.Size(121, 21);
            this.drop_pizzaSize.TabIndex = 11;
            // 
            // btn_addpizza
            // 
            this.btn_addpizza.Location = new System.Drawing.Point(97, 238);
            this.btn_addpizza.Name = "btn_addpizza";
            this.btn_addpizza.Size = new System.Drawing.Size(75, 23);
            this.btn_addpizza.TabIndex = 17;
            this.btn_addpizza.Text = "Add to Cart";
            this.btn_addpizza.UseVisualStyleBackColor = true;
            this.btn_addpizza.Click += new System.EventHandler(this.btn_addpizza_Click);
            // 
            // checkbtns_toppings
            // 
            this.checkbtns_toppings.FormattingEnabled = true;
            this.checkbtns_toppings.Items.AddRange(new object[] {
            "Pepperoni - $0.50",
            "Sausage - $0.50",
            "Olives - $0.50",
            "Onions - $0.50",
            "Mushrooms - $1.00",
            "Green Peppers - $0.50",
            "Extra Cheese - $1.00",
            "Ham - $0.50"});
            this.checkbtns_toppings.Location = new System.Drawing.Point(80, 69);
            this.checkbtns_toppings.Name = "checkbtns_toppings";
            this.checkbtns_toppings.Size = new System.Drawing.Size(120, 124);
            this.checkbtns_toppings.TabIndex = 18;
            // 
            // lbl_toppings
            // 
            this.lbl_toppings.AutoSize = true;
            this.lbl_toppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_toppings.Location = new System.Drawing.Point(3, 69);
            this.lbl_toppings.Name = "lbl_toppings";
            this.lbl_toppings.Size = new System.Drawing.Size(70, 15);
            this.lbl_toppings.TabIndex = 19;
            this.lbl_toppings.Text = "Toppings:";
            // 
            // lbl_drinkerror
            // 
            this.lbl_drinkerror.AutoSize = true;
            this.lbl_drinkerror.ForeColor = System.Drawing.Color.Red;
            this.lbl_drinkerror.Location = new System.Drawing.Point(322, 138);
            this.lbl_drinkerror.Name = "lbl_drinkerror";
            this.lbl_drinkerror.Size = new System.Drawing.Size(35, 13);
            this.lbl_drinkerror.TabIndex = 20;
            this.lbl_drinkerror.Text = "label1";
            this.lbl_drinkerror.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_drinkerror.Visible = false;
            // 
            // lbl_pizzaerror
            // 
            this.lbl_pizzaerror.AutoSize = true;
            this.lbl_pizzaerror.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_pizzaerror.ForeColor = System.Drawing.Color.Red;
            this.lbl_pizzaerror.Location = new System.Drawing.Point(94, 273);
            this.lbl_pizzaerror.Name = "lbl_pizzaerror";
            this.lbl_pizzaerror.Size = new System.Drawing.Size(35, 13);
            this.lbl_pizzaerror.TabIndex = 21;
            this.lbl_pizzaerror.Text = "label2";
            this.lbl_pizzaerror.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_pizzaerror.Visible = false;
            // 
            // group_order
            // 
            this.group_order.Controls.Add(this.checkbtns_toppings);
            this.group_order.Controls.Add(this.lbl_pizzaerror);
            this.group_order.Controls.Add(this.btn_checkout);
            this.group_order.Controls.Add(this.lbl_drinkerror);
            this.group_order.Controls.Add(this.drop_drinkSize);
            this.group_order.Controls.Add(this.lbl_toppings);
            this.group_order.Controls.Add(this.drop_drink);
            this.group_order.Controls.Add(this.btn_adddrink);
            this.group_order.Controls.Add(this.btn_addpizza);
            this.group_order.Controls.Add(this.lbl_size);
            this.group_order.Controls.Add(this.txtb_pizzaQuantity);
            this.group_order.Controls.Add(this.lbl_drinktype);
            this.group_order.Controls.Add(this.lbl_pizzaQuantity);
            this.group_order.Controls.Add(this.lbl_quantity);
            this.group_order.Controls.Add(this.lbl_crust);
            this.group_order.Controls.Add(this.txtb_drinkQuantity);
            this.group_order.Controls.Add(this.lbl_pizzaSize);
            this.group_order.Controls.Add(this.drop_pizzaSize);
            this.group_order.Controls.Add(this.drop_crust);
            this.group_order.Location = new System.Drawing.Point(4, 42);
            this.group_order.Name = "group_order";
            this.group_order.Size = new System.Drawing.Size(462, 299);
            this.group_order.TabIndex = 22;
            this.group_order.TabStop = false;
            // 
            // btn_submit
            // 
            this.btn_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.Location = new System.Drawing.Point(166, 252);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(129, 30);
            this.btn_submit.TabIndex = 23;
            this.btn_submit.Text = "Place Order";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // checkbtns_order
            // 
            this.checkbtns_order.FormattingEnabled = true;
            this.checkbtns_order.Location = new System.Drawing.Point(22, 55);
            this.checkbtns_order.Name = "checkbtns_order";
            this.checkbtns_order.Size = new System.Drawing.Size(412, 169);
            this.checkbtns_order.TabIndex = 24;
            // 
            // lbl_totalprice
            // 
            this.lbl_totalprice.AutoSize = true;
            this.lbl_totalprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalprice.Location = new System.Drawing.Point(176, 227);
            this.lbl_totalprice.Name = "lbl_totalprice";
            this.lbl_totalprice.Size = new System.Drawing.Size(106, 18);
            this.lbl_totalprice.TabIndex = 25;
            this.lbl_totalprice.Text = "Total: $43.22";
            // 
            // group_ordersummary
            // 
            this.group_ordersummary.Controls.Add(this.btn_removeitems);
            this.group_ordersummary.Controls.Add(this.lbl_order);
            this.group_ordersummary.Controls.Add(this.checkbtns_order);
            this.group_ordersummary.Controls.Add(this.btn_back);
            this.group_ordersummary.Controls.Add(this.lbl_totalprice);
            this.group_ordersummary.Controls.Add(this.btn_submit);
            this.group_ordersummary.Location = new System.Drawing.Point(13, 39);
            this.group_ordersummary.Name = "group_ordersummary";
            this.group_ordersummary.Size = new System.Drawing.Size(454, 289);
            this.group_ordersummary.TabIndex = 26;
            this.group_ordersummary.TabStop = false;
            this.group_ordersummary.Visible = false;
            // 
            // lbl_order
            // 
            this.lbl_order.AutoSize = true;
            this.lbl_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_order.Location = new System.Drawing.Point(210, 25);
            this.lbl_order.Name = "lbl_order";
            this.lbl_order.Size = new System.Drawing.Size(51, 18);
            this.lbl_order.TabIndex = 27;
            this.lbl_order.Text = "Order";
            // 
            // btn_removeitems
            // 
            this.btn_removeitems.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removeitems.Location = new System.Drawing.Point(38, 258);
            this.btn_removeitems.Name = "btn_removeitems";
            this.btn_removeitems.Size = new System.Drawing.Size(106, 21);
            this.btn_removeitems.TabIndex = 28;
            this.btn_removeitems.Text = "Remove Selected";
            this.btn_removeitems.UseVisualStyleBackColor = true;
            this.btn_removeitems.Click += new System.EventHandler(this.btn_removeitems_Click);
            // 
            // Form_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 343);
            this.Controls.Add(this.group_ordersummary);
            this.Controls.Add(this.group_order);
            this.Controls.Add(this.btn_signout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Order";
            this.Text = "Form_Order";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Order_FormClosing);
            this.group_order.ResumeLayout(false);
            this.group_order.PerformLayout();
            this.group_ordersummary.ResumeLayout(false);
            this.group_ordersummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_signout;
        private System.Windows.Forms.Button btn_checkout;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.ComboBox drop_drinkSize;
        private System.Windows.Forms.ComboBox drop_drink;
        private System.Windows.Forms.Button btn_adddrink;
        private System.Windows.Forms.Label lbl_size;
        private System.Windows.Forms.Label lbl_drinktype;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.TextBox txtb_drinkQuantity;
        private System.Windows.Forms.TextBox txtb_pizzaQuantity;
        private System.Windows.Forms.Label lbl_pizzaQuantity;
        private System.Windows.Forms.Label lbl_crust;
        private System.Windows.Forms.Label lbl_pizzaSize;
        private System.Windows.Forms.ComboBox drop_crust;
        private System.Windows.Forms.ComboBox drop_pizzaSize;
        private System.Windows.Forms.Button btn_addpizza;
        private System.Windows.Forms.CheckedListBox checkbtns_toppings;
        private System.Windows.Forms.Label lbl_toppings;
        private System.Windows.Forms.Label lbl_drinkerror;
        private System.Windows.Forms.Label lbl_pizzaerror;
        private System.Windows.Forms.GroupBox group_order;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.CheckedListBox checkbtns_order;
        private System.Windows.Forms.Label lbl_totalprice;
        private System.Windows.Forms.GroupBox group_ordersummary;
        private System.Windows.Forms.Label lbl_order;
        private System.Windows.Forms.Button btn_removeitems;
    }
}