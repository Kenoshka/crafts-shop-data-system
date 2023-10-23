using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovik.Classes
{
    class TovarCheck
    {
        int id;
        string tovName;
        int amount;
        double price;

        public int Id { get { return id; } set { id = value; } }
        public string TovName { get { return tovName; } set { tovName = value; } }
        public int Amount { get { return amount; } set { amount = value; } }
        public double Price { get { return price; } set { price = value; } }

        public TovarCheck(int id, string tovName, int amount, double price)
        {
            Id = id;
            TovName = tovName;
            Amount = amount;
            Price = price;
        }
    }
}
