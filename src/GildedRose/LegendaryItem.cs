namespace GildedRoseKata;

public class LegendaryItem : Item, IQualityUpdatable 
{
    public LegendaryItem(string name, int sellIn)
    {
        Name = name;
        SellIn = sellIn;
        Quality = 80;
    }

    public void UpdateQuality()
    {
        //do nothing
    }
}

