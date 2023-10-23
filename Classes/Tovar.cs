using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovik.Classes
{
    public class Tovar
    {
        public int TovarId { get; set; }
        public Image Picture { get; set; }
        public string TovarName { get; set; }
        public string TovarCateg { get; set; }
        public double TovarPrice { get; set; }
        public int DaysToProduce { get; set; }

        public string picPath;

        public Tovar(int tovarId, string tovarName, string tovarCateg, double tovarPrice, int daysToProduce, string path)
        {
            TovarId = tovarId;
            TovarName = tovarName;
            TovarCateg = tovarCateg;
            TovarPrice = tovarPrice;
            DaysToProduce = daysToProduce;
            Picture = Image.FromFile("..\\..\\Images\\Tovars\\" + path);
        }
    }
}
