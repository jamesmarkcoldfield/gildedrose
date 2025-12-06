using GildedRoseKata;

namespace GildedRoseTests;

public class GildedRoseTest
{
    [Fact]
    public void GildedRose_UpdateQuality_ItemNameNotChangedOnUpdate()
    {
        List<Item> items = [ new Item { Name = "foo", SellIn = 0, Quality = 0 } ];
        GildedRose app = new(items);
        app.UpdateQuality();
        Assert.Equal("foo", items[0].Name);
    }
}
