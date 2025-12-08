using GildedRoseKata.Interfaces;

namespace GildedRoseKata.Items;

public class LegendaryItem : StoreItem
{
    public LegendaryItem(string name, int sellIn) : base(name, sellIn, 80)
    {
    }
        
    public override void UpdateQuality()
    {
        //do nothing
    }
}

