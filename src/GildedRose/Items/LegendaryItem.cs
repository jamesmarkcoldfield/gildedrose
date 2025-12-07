using GildedRoseKata.Interfaces;

namespace GildedRoseKata.Items;

public class LegendaryItem : StoreItem
{
    public LegendaryItem(string name, int sellIn) : base(name, sellIn, 80)
    {
    }
        
    public new void UpdateQuality()
    {
        //do nothing
    }
}

