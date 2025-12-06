using GildedRoseKata;
using GildedRoseTests.Helpers;

namespace GildedRoseTests;

public class GildedRoseTest
{
    [Fact]
    public void GildedRose_UpdateQuality_SingleItem_ItemNameNotChangedOnUpdate()
    {
        List<Item> items = [ItemHelpers.CreateItem("foo", 0, 0)];
        GildedRose app = new(items);
        app.UpdateQuality();
        Assert.Equal("foo", items[0].Name);
    }
}
