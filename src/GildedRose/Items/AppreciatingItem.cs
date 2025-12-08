using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Items
{
    public class AppreciatingItem : StoreItem
    {
        public AppreciatingItem(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {
        }

        public new void UpdateQuality()
        {
            SellIn -= 1;

            Quality = Math.Min(50,  Quality + 1);
        }
    }
}
