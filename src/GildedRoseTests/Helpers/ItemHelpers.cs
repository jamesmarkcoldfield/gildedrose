using GildedRoseKata;

namespace GildedRoseTests.Helpers
{
    public static class ItemHelpers
    {
        public static Item CreateItem(string name, int sellIn, int quality)
        {
            return new Item { Name = name, SellIn = sellIn, Quality = quality };
        }
    }
}
