using GildedRoseKata.Items;

namespace GildedRoseTests;

public class LegendaryItemTests
{

    [Fact]
    public void LegendaryItem_Constructor_NameAsSpecified()
    {
        // Arrange & Act
        var legendaryItem = new LegendaryItem("A legendary item", 12);

        // Assert
        Assert.Equal("A legendary item", legendaryItem.Name);
    }

    [Fact]
    public void LegendaryItem_Constructor_SellInAsSpecified()
    {
        // Arrange & Act
        var legendaryItem = new LegendaryItem("A legendary item", 12);

        // Assert
        Assert.Equal(12, legendaryItem.SellIn);
    }

    [Fact]
    public void LegendaryItem_Constructor_QualityIsAlways80()
    {
        // Arrange & Act
        var legendaryItem = new LegendaryItem("A legendary item", 12);

        // Assert
        Assert.Equal(80, legendaryItem.Quality);
    }

    [Fact]
    public void LegendaryItem_UpdateQuality_SellInDoesNotChange()
    {
        // Arrange
        var legendaryItem = new LegendaryItem("A legendary item", 12);

        // Act
        legendaryItem.UpdateQuality();

        // Assert
        Assert.Equal(12, legendaryItem.SellIn);
    }

    [Fact]
    public void LegendaryItem_UpdateQuality_QualityDoesNotChange()
    {
        // Arrange
        var legendaryItem = new LegendaryItem("A legendary item", 12);
        var startQuality = legendaryItem.Quality;

        // Act
        legendaryItem.UpdateQuality();

        // Assert
        Assert.Equal(startQuality, legendaryItem.Quality);
    }

}
