using GildedRoseKata.Items;

namespace GildedRoseTests;

public class TemporarilyAppreciatingItemTests
{
    [Fact]
    public void TemporarilyAppreciatingItemTests_UpdateQuality_IncreasesByOne()
    {
        var item = new TemporarilyAppreciatingItem("Ticket", 20, 10);
        var startQuality = item.Quality;
        item.UpdateQuality();
        Assert.Equal(startQuality + 1, item.Quality);
    }

    [Fact]
    public void TemporarilyAppreciatingItemTests_UpdateQuality_AtMaximum_DoesNotIncrease()
    {
        var item = new TemporarilyAppreciatingItem("Ticket", 20, 50);
        var startQuality = item.Quality;
        item.UpdateQuality();
        Assert.Equal(startQuality, item.Quality);
    }

    [Fact]
    public void TemporarilyAppreciatingItemTests_UpdateQuality_SellInAt11_QualityIncreasesByOne()
    {
        var item = new TemporarilyAppreciatingItem("Ticket", 11, 10);
        var startQuality = item.Quality;
        item.UpdateQuality();
        Assert.Equal(startQuality + 1, item.Quality);
    }

    [Fact]
    public void TemporarilyAppreciatingItemTests_UpdateQuality_SellInAt10_QualityIncreasesByTwo()
    {
        var item = new TemporarilyAppreciatingItem("Ticket", 10, 10);
        var startQuality = item.Quality;
        item.UpdateQuality();
        Assert.Equal(startQuality + 2, item.Quality);
    }

    [Fact]
    public void TemporarilyAppreciatingItemTests_UpdateQuality_SellInPassed_QualityZero()
    {
        var item = new TemporarilyAppreciatingItem("Ticket", 0, 30);
        item.UpdateQuality();
        Assert.Equal(0, item.Quality);
    }
}

