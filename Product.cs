using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Product {
    class Product {
        public string Name;
        public double Price;
        public int Quantity;

        public Product() {

        }

        public Product(string name, double price, int quantity) {
            Name = name; Price = price; Quantity = quantity;
        } 

        public Product(string name, double price) {
            Name = name; Price = price;
        }

        public double ValueInStock() {
            return Price * Quantity;
        }

        public void AddProducts(int quantity) {
            Quantity += quantity;
        }

        public void RemoveProducts(int quantity) {
            Quantity -= quantity;
        }

        public override string ToString() {
            return Name + ", $" + Price.ToString("F2", CultureInfo.InvariantCulture) + ", "
                + Quantity + " units. Total: $" + ValueInStock().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
