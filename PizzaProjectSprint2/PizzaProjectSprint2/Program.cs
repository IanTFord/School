using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace PizzaProjectSprint2 {
    static class Program {
        static List<IPurchasable> order = new List<IPurchasable>();
        static Dictionary<string,string> users = new Dictionary<string, string>();
        static Form_Order orderForm;
        static Form_SignIn signinForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {

            //sets up user dictionary
            string path = Application.StartupPath + "\\users.txt";
            //if txt file doesnt exist create it
            if (!File.Exists(path)) {
                File.Create(path);
            }
            StreamReader SR = new StreamReader(path);

            //reads lines from text file into dictionary
            string line = SR.ReadLine();
            while (line != null) {
                int psdIndex = line.IndexOf(" ");
                users.Add(line.Substring(0, psdIndex), line.Substring(psdIndex + 1));
                line = SR.ReadLine();
            }
            SR.Close();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_SignIn());
        }
        
        //opens ordering form
        public static void OpenOrderForm(Form_SignIn signinForm) {
            Program.signinForm = signinForm;
            orderForm = new Form_Order();
            orderForm.Show();
            Program.signinForm.Hide();
        }
        
        //Opens signinform
        public static void OpenSigninForm() {
            orderForm.Close();
            signinForm.Show();
        }

        //Checks username and password
        public static string GetPassword(string user) {
            if(users.ContainsKey(user))
                return users[user];
            return null;
        }

        //adds user to user dictionary
        public static void AddUser(string user, string pass) {
            users.Add(user, pass);
        }

        //order getter
        public static List<IPurchasable> GetOrder() {
            return order;
        }

        //add item to order
        public static void AddToOrder(IPurchasable item) {
            //if item is already in order increase items quantity
            //otherwise add the item to the order
            IPurchasable itemToIncrease = null;
            foreach(IPurchasable orderItem in order) {
                if (orderItem.GetItemName().Substring(orderItem.GetItemName().IndexOf("-") + 2) == item.GetItemName().Substring(orderItem.GetItemName().IndexOf("-") + 2)) {
                    itemToIncrease = orderItem;
                    break;
                }
            }
            if (itemToIncrease != null)
                itemToIncrease.SetQuantity(itemToIncrease.GetQuantity() + item.GetQuantity());
            else
                order.Add(item);
        }

        //Removes item
        public static void RemoveFromOrder(string itemToRemove) {
            foreach (IPurchasable item in order)
                if (item.GetItemName() == itemToRemove) {
                    order.Remove(item);
                    break;
                }
        }
        

        //Gets total order price
        public static float GetOrderPrice() {
            float price = 0;
            foreach (IPurchasable item in order)
                price += item.GetPrice();
            return price;
        }
    }
}
