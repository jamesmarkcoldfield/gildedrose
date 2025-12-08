using GildedRoseKata.Items;

namespace GildedRoseTests;

public  class ConjuredItemTests
{

    [Fact]
    public void ConjuredItem_UpdateQuality_SellInDecrementsByOne()
    {
        // Arrange
        var storeItem = new ConjuredItem("A store item", 12, 45);
        var startSellIn = storeItem.SellIn;

        // Act
        storeItem.UpdateQuality();

        // Assert
        Assert.Equal(startSellIn - 1, storeItem.SellIn);
    }

    [Fact]
    public void ConjuredItem_UpdateQuality_SellInPositive_QualityDecrementsByTwo()
    {
        // Arrange
        var storeItem = new ConjuredItem("A store item", 1, 45);
        var startQuality = storeItem.Quality;

        // Act
        storeItem.UpdateQuality();

        // Assert
        Assert.Equal(startQuality - 2, storeItem.Quality);
    }


    [Fact]
    public void ConjuredItem_UpdateQuality_SellInZero_QualityDecrementsByFour()
    {
        // Arrange
        var storeItem = new ConjuredItem("A store item", 0, 45);
        var startQuality = storeItem.Quality;

        // Act
        storeItem.UpdateQuality();

        // Assert
        Assert.Equal(startQuality - 4, storeItem.Quality);
    }


    [Fact]
    public void ConjuredItem_UpdateQuality_QualityZero_CannotGoNegative()
    {
        // Arrange
        var storeItem = new ConjuredItem("A store item", 5, 0);
        var startQuality = storeItem.Quality;

        // Act
        storeItem.UpdateQuality();

        // Assert
        Assert.Equal(0, storeItem.Quality);
    }

    [Fact]
    public void ConjuredItem_UpdateQuality_QualityOne_OnlyGoesToZero()
    {
        // Arrange
        var storeItem = new ConjuredItem("A store item", 4, 1);
        var startQuality = storeItem.Quality;

        // Act
        storeItem.UpdateQuality();

        // Assert
        Assert.Equal(0, storeItem.Quality);
    }

}

