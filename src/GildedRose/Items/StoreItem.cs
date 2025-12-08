using GildedRoseKata.Interfaces;

namespace GildedRoseKata.Items
{
    public class StoreItem : Item, IQualityUpdatable
    {
        public StoreItem(string name, int sellIn, int quality)
        {
            Name = name;
            SellIn = sellIn;
            Quality = quality;
        }

        public void UpdateQuality()
        {
            Quality += -1;
            SellIn += -1;
        }
    }
}
