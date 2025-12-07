
namespace GildedRoseKata.Extensions
{
    public static class ItemExtensionMethods
    {
        public static bool IsLegendaryItem(this Item item)
        {
            return item.GetType() == typeof(LegendaryItem);
        }
        public static bool IsNotLegendaryItem(this Item item)
        {
            return !item.IsLegendaryItem();
        }
    }
}
