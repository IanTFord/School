using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaProjectSprint2 {
    public partial class Form_Order : Form {
        bool signoutPressed = false;
        public Form_Order() {
            InitializeComponent();
        }

        //goes back to signin page
        private void btn_signout_Click(object sender, EventArgs e) {
            signoutPressed = true;
            Program.OpenSigninForm();
        }

        //if the big x is pressed close the program otherwise go back to signin
        private void Form_Order_FormClosing(object sender, FormClosingEventArgs e) {
            if(!signoutPressed)
                Application.Exit();
        }

        private void btn_adddrink_Click(object sender, EventArgs e) {
            //Error Cases
            //if quantity isn't a number
            int quantity;
            if (!int.TryParse(txtb_drinkQuantity.Text, out quantity)) {
                lbl_drinkerror.Text = "Enter a Valid Quantity";
                lbl_drinkerror.Visible = true;
            }
            //if didnt select a drink
            else if (drop_drink.SelectedItem == null) {
                lbl_drinkerror.Text = "Select a Drink";
                lbl_drinkerror.Visible = true;
            }
            //if didnt select a size
            else if (drop_drinkSize.SelectedItem == null) {
                lbl_drinkerror.Text = "Select a Size";
                lbl_drinkerror.Visible = true;
            }
            //No Errors? Add drinks to Order and Reset Inputs
            else {
                Program.AddToOrder(new Drink(drop_drink.Text, drop_drinkSize.Text, quantity));
                lbl_drinkerror.Text = "Added to Order";
                drop_drinkSize.SelectedIndex = -1;
                drop_drink.SelectedIndex = -1;
                txtb_drinkQuantity.Text = "";
                lbl_drinkerror.Visible = true;
            }
        }

        private void btn_addpizza_Click(object sender, EventArgs e) {
            //Error Cases
            //if quantity isn't int
            int quantity;
            if (!int.TryParse(txtb_pizzaQuantity.Text, out quantity)) {
                lbl_pizzaerror.Text = "Enter a Valid Quantity";
                lbl_pizzaerror.Visible = true;
            }
            //if didnt select a crust type
            else if (drop_crust.SelectedItem == null) {
                lbl_pizzaerror.Text = "Select a Crust Type";
                lbl_pizzaerror.Visible = true;
            }
            //if didnt select a size
            else if (drop_crust.SelectedItem == null) {
                lbl_pizzaerror.Text = "Select a Size";
                lbl_pizzaerror.Visible = true;
            }
            //if more than 4 toppings
            else if (checkbtns_toppings.CheckedIndices.Count > 4) {
                lbl_pizzaerror.Text = "Maximum of 4 Toppings";
                lbl_pizzaerror.Visible = true;
            }
            //No Errors? Add Pizza to Order
            else {
                List<string> toppings = new List<string>();
                foreach (string topping in checkbtns_toppings.CheckedItems) {
                    toppings.Add(topping);
                }
                Program.AddToOrder(new Pizza(drop_crust.Text,drop_pizzaSize.Text, quantity,toppings));
                lbl_pizzaerror.Text = "Added to Order";
                drop_pizzaSize.SelectedIndex = -1;
                drop_crust.SelectedIndex = -1;
                txtb_pizzaQuantity.Text = "";
                lbl_pizzaerror.Visible = true;
            }
        }

        private void btn_checkout_Click(object sender, EventArgs e) {
            group_order.Visible = false;
            group_ordersummary.Visible = true;

            //Populate Order
            PopulateOrderList();

            //Set total Price
            lbl_totalprice.Text = "Total: $" + Program.GetOrderPrice();
        }

        //Populates Order List
        private void PopulateOrderList() {
            checkbtns_order.Items.Clear();
            foreach (IPurchasable item in Program.GetOrder()) {
                checkbtns_order.Items.Add(item.GetItemName());
            }
        }

        //Returns to order menu
        private void btn_back_Click(object sender, EventArgs e) {
            group_order.Visible = true;
            group_ordersummary.Visible = false;
        }

        //Goes to order summary
        private void btn_submit_Click(object sender, EventArgs e) {
            signoutPressed = true;
            Program.OpenSigninForm();
        }

        //removes selected items from order
        private void btn_removeitems_Click(object sender, EventArgs e) {
            foreach(string itemToRemove in checkbtns_order.SelectedItems) {
                Program.RemoveFromOrder(itemToRemove);
            }
            PopulateOrderList();
        }
    }
}
