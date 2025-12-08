using GildedRoseKata.Items;

namespace GildedRoseTests
{
    public class StoreItemTests
    {
        [Fact]
        public void StoreItem_Constructor_NameAsSpecified()
        {
            // Arrange & Act
            var storeItem = new StoreItem("A store item", 12, 45);

            // Assert
            Assert.Equal("A store item", storeItem.Name);
        }

        [Fact]
        public void StoreItem_Constructor_SellInAsSpecified()
        {
            // Arrange & Act
            var storeItem = new StoreItem("A store item", 12, 45);

            // Assert
            Assert.Equal(12, storeItem.SellIn);
        }

        [Fact]
        public void StoreItem_Constructor_QualityAsSpecified()
        {
            // Arrange & Act
            var storeItem = new StoreItem("A store item", 12, 45);

            // Assert
            Assert.Equal(45, storeItem.Quality);
        }

        [Fact]
        public void StoreItem_UpdateQuality_SellInDecrementsByOne()
        {
            // Arrange
            var storeItem = new StoreItem("A store item", 12, 45);
            var startSellIn = storeItem.SellIn;

            // Act
            storeItem.UpdateQuality();

            // Assert
            Assert.Equal(startSellIn - 1, storeItem.SellIn);
        }

        [Fact]
        public void StoreItem_UpdateQuality_QualityDecrementsByOne()
        {
            // Arrange
            var storeItem = new StoreItem("A store item", 12, 45);
            var startQuality = storeItem.Quality;

            // Act
            storeItem.UpdateQuality();

            // Assert
            Assert.Equal(startQuality - 1, storeItem.Quality);
        }


        [Fact]
        public void StoreItem_SellAboveZero_QualityDecrementsByOne()
        {
            // Arrange
            var storeItem = new StoreItem("A store item", 1, 45);
            var startQuality = storeItem.Quality;

            // Act
            storeItem.UpdateQuality();

            // Assert
            Assert.Equal(startQuality - 1, storeItem.Quality);
        }

        [Fact]
        public void StoreItem_SellInZero_QualityDecrementsByTwo()
        {
            // Arrange
            var storeItem = new StoreItem("A store item", 0, 45);
            var startQuality = storeItem.Quality;

            // Act
            storeItem.UpdateQuality();

            // Assert
            Assert.Equal(startQuality - 2, storeItem.Quality);
        }


        [Fact]
        public void StoreItem_UpdateQuality_QualityZero_CannotGoNegative()
        {
            // Arrange
            var storeItem = new StoreItem("A store item", 5, 0);
            var startQuality = storeItem.Quality;

            // Act
            storeItem.UpdateQuality();

            // Assert
            Assert.Equal(0, storeItem.Quality);
        }
    }
}
