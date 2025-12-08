using GildedRoseKata.Interfaces;
using GildedRoseKata.Items;

namespace GildedRoseKata;

public class GildedRose
{
    IList<Item> Items;
    public GildedRose(IList<Item> Items)
    {
        this.Items = Items;
    }

    private void UpdateQuality()
    {
        for (var i = 0; i < Items.Count; i++) 
        {
            var item = Items[i];

            if (item is IQualityUpdatable updatable)
            {
                updatable.UpdateQuality();
            }
        }
    }

    public void ProcessForDays(int numberOfDays)
    {
        for (var i = 0; i <= numberOfDays; i++)
        {
            Console.WriteLine("-------- day " + i + " --------");
            Console.WriteLine("name, sellIn, quality");
            for (var j = 0; j < Items.Count; j++)
            {
                System.Console.WriteLine(Items[j]);
            }
            Console.WriteLine("");
            UpdateQuality();
        }
    }
}
