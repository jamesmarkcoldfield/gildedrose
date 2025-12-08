using GildedRoseKata.Interfaces;
using GildedRoseKata.Items;

namespace GildedRoseKata;

public class GildedRose
{
    IList<Item> Items;
    public GildedRose(IList<Item> Items)
    {
        this.Items = Items;
    }

    public void UpdateQuality()
    {
        for (var i = 0; i < Items.Count; i++) 
        {
            var item = Items[i];

            if (item is IQualityUpdatable updatable)
            {
                updatable.UpdateQuality();
            }
        }
    }
}
