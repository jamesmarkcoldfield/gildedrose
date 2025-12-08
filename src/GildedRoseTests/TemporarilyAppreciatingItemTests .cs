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
    public void TemporarilyAppreciatingItemTests_UpdateQuality_SellIn11_QualityIncreasesByOne()
    {
        var item = new TemporarilyAppreciatingItem("Ticket", 11, 10);
        var startQuality = item.Quality;
        item.UpdateQuality();
        Assert.Equal(startQuality + 1, item.Quality);
    }

    [Fact]
    public void TemporarilyAppreciatingItemTests_UpdateQuality_SellIn10_QualityIncreasesByTwo()
    {
        var item = new TemporarilyAppreciatingItem("Ticket", 10, 10);
        var startQuality = item.Quality;
        item.UpdateQuality();
        Assert.Equal(startQuality + 2, item.Quality);
    }


    [Fact]
    public void TemporarilyAppreciatingItemTests_UpdateQuality_SellIn6_QualityIncreasesByTwo()
    {
        var item = new TemporarilyAppreciatingItem("Ticket", 6, 10);
        var startQuality = item.Quality;
        item.UpdateQuality();
        Assert.Equal(startQuality + 2, item.Quality);
    }


    [Fact]
    public void TemporarilyAppreciatingItemTests_UpdateQuality_SellIn5_QualityIncreasesByThree()
    {
        var item = new TemporarilyAppreciatingItem("Ticket", 5, 10);
        var startQuality = item.Quality;
        item.UpdateQuality();
        Assert.Equal(startQuality + 3, item.Quality);
    }

    [Fact]
    public void TemporarilyAppreciatingItemTests_UpdateQuality_SellIn1_QualityIncreasesByThree()
    {
        var item = new TemporarilyAppreciatingItem("Ticket", 1, 10);
        var startQuality = item.Quality;
        item.UpdateQuality();
        Assert.Equal(startQuality + 3, item.Quality);
    }


    [Fact]
    public void TemporarilyAppreciatingItemTests_UpdateQuality_SellIn0_QualityZero()
    {
        var item = new TemporarilyAppreciatingItem("Ticket", 0, 30);
        item.UpdateQuality();
        Assert.Equal(0, item.Quality);
    }
}

