using GildedRoseKata.Items;

namespace GildedRoseTests;

public class AppreciatingItemTests
{
    [Fact]
    public void AppreciatingItem_UpdateQuality_IncreasesByOne()
    {
        var item = new AppreciatingItem("Cheese", 20, 10);
        var startQuality = item.Quality;
        item.UpdateQuality();
        Assert.Equal(startQuality + 1, item.Quality);
    }

    [Fact]
    public void AppreciatingItem_UpdateQuality_AtMaximum_DoesNotIncrease()
    {
        var item = new AppreciatingItem("Cheese", 20, 50);
        var startQuality = item.Quality;
        item.UpdateQuality();
        Assert.Equal(startQuality, item.Quality);
    }

    [Fact]
    public void AppreciatingItem_UpdateQuality_SellInDecreasesByOne()
    {
        var item = new AppreciatingItem("Cheese", 20, 50);
        var startSellIn = item.SellIn;
        item.UpdateQuality();
        Assert.Equal(startSellIn - 1, item.SellIn);
    }
}

