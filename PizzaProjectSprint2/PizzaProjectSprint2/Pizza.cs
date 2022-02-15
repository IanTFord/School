using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaProjectSprint2 {

    public interface IPurchasable {
        string GetItemName();
        float GetPrice();
        int GetQuantity();
        void SetQuantity(int quantity);
    }

    public class Pizza : IPurchasable {
        private string crust, size;
        private int quantity;
        private List<String> toppings;
        public Pizza(string crust, string size, int quantity, List<String> toppings) {
            this.crust = crust;
            this.size = size;
            this.quantity = quantity;
            this.toppings = toppings;
        }

        //price getter based on price of components
        public float GetPrice() {
            float price = 0;
            //sum of price of toppings crust and pizza size
            foreach (String t in toppings) price += float.Parse(t.Substring(t.IndexOf("$")+1));
            price += float.Parse(size.Substring(size.IndexOf("$")+1));
            price += float.Parse(crust.Substring(crust.IndexOf("$")+1));
            return price * quantity;
        }

        //quantity getter
        public int GetQuantity() {
            return quantity;
        }

        //quantity setter
        public void SetQuantity(int quantity) {
            this.quantity = quantity;
        }

        //returns item name
        public string GetItemName() {
            string itemName = GetQuantity() + " - $" + GetPrice() / GetQuantity() + " - " + size.Substring(0, size.IndexOf(" ")) + " " + crust.Substring(0, crust.IndexOf(" ")) + " Crust Pizza with ";
            foreach (string topping in toppings) itemName += topping.Substring(0,topping.IndexOf("-") - 1) + " ";
            return itemName;
        }
    }

    //drink class
    public class Drink : IPurchasable {
        private string drink, size;
        private int quantity;
        public Drink(string drink, string size, int quantity) {
            this.drink = drink;
            this.size = size;
            this.quantity = quantity;
        }

        //Price of drink
        public float GetPrice() {
            return float.Parse(size.Substring(size.IndexOf("$")+1)) * quantity;
        }

        //quantity getter
        public int GetQuantity() {
            return quantity;
        }

        //quantity setter
        public void SetQuantity(int quantity) {
            this.quantity = quantity;
        }

        //returns item name
        public string GetItemName() {
            return GetQuantity() + " - $" + GetPrice() / GetQuantity() + " - " + size.Substring(0, size.IndexOf(" ")) + " " + drink;
        }
    }
}
