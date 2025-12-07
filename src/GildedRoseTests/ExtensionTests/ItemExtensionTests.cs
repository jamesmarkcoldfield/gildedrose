using GildedRoseKata.Extensions;
using GildedRoseKata;
using GildedRoseTests.Helpers;

namespace GildedRoseTests.ExtensionTests
{
    public class ItemExtensionTests
    {
        [Fact]
        public void ExtensionMethod_IsLegendaryItem_ShouldReturnTrueForLegendaryItem()
        {
            // Arrange
            var legendaryItem = new LegendaryItem("Sulfuras, Hand of Ragnaros", 0);
            // Act
            var result = legendaryItem.IsLegendaryItem();
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void ExtensionMethod_IsNotLegendaryItem_ShouldReturnFalseForLegendaryItem()
        {
            // Arrange
            var legendaryItem = ItemHelpers.CreateItem("Ordinary thing...", 12, 10);
            // Act
            var result = legendaryItem.IsLegendaryItem();
            // Assert
            Assert.False(result);
        }

        [Fact]
        public void ExtensionMethod_IsLegendaryItem_ShouldReturnFalseForNotLegendaryItem()
        {
            // Arrange
            var legendaryItem = new LegendaryItem("Sulfuras, Hand of Ragnaros", 0);
            // Act
            var result = legendaryItem.IsNotLegendaryItem();
            // Assert
            Assert.False(result);
        }

        [Fact]
        public void ExtensionMethod_IsNotLegendaryItem_ShouldReturnTrueForNotLegendaryItem()
        {
            // Arrange
            var legendaryItem = ItemHelpers.CreateItem("Ordinary thing...", 12, 10);
            // Act
            var result = legendaryItem.IsNotLegendaryItem();
            // Assert
            Assert.True(result);
        }


    }
}
