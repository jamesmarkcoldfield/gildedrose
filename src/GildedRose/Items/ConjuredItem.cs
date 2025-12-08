namespace GildedRoseKata.Items;
public class ConjuredItem : StoreItem
{
    public ConjuredItem(string name, int sellIn, int quality) : base(name, sellIn, quality)
    {
    }

    public override void UpdateQuality()
    {
        SellIn -= 1;

        var qualityChange = 2;

        if (SellIn < 0)
        {
            qualityChange = 4;
        }

        Quality -= qualityChange;

        //Ensure quality does not go below 0
        Quality = Math.Max(0, Quality);

        
    }
}

