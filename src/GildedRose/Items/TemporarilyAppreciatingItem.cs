namespace GildedRoseKata.Items;

public class TemporarilyAppreciatingItem : AppreciatingItem
{
    public TemporarilyAppreciatingItem(string name, int sellIn, int quality) : base(name, sellIn, quality)
    {
    }

    public override void UpdateQuality()
    {
        SellIn -= 1;

        if (SellIn < 0)
        {
            Quality = 0;
            return;
        }

        var qualityIncrease = 1;

        if (SellIn < 10)
        {
            qualityIncrease += 1;
        }
        if (SellIn < 5)
        {
            qualityIncrease += 1;
        }

        Quality = Math.Min(50, Quality + qualityIncrease);
    }
}

