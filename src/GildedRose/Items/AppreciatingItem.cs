namespace GildedRoseKata.Items;

    public class AppreciatingItem : StoreItem
    {
        public AppreciatingItem(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {
        }

    public override void UpdateQuality()
    {
        SellIn -= 1;

        var amountToIncrease = 1;

        if (SellIn < 0)
        {
            amountToIncrease = 2;
        }

        Quality = Math.Min(50,  Quality + amountToIncrease);
    }
}
