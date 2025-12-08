namespace GildedRoseKata.Items;

    public class AppreciatingItem : StoreItem
    {
        public AppreciatingItem(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {
        }

    public override void UpdateQuality()
        {
            SellIn -= 1;

            Quality = Math.Min(50,  Quality + 1);
        }
    }
}
