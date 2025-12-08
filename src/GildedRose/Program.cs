using GildedRoseKata.Items;
﻿namespace GildedRoseKata;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("OMGHAI!");

        List<Item> Items =
        [
            new StoreItem("+5 Dexterity Vest", 10, 20),
            new AppreciatingItem("Aged Brie", 2, 0),
            new StoreItem("Elixir of the Mongoose", 5, 7),
            new LegendaryItem("Sulfuras, Hand of Ragnaros", 0),
            new LegendaryItem("Sulfuras, Hand of Ragnaros", -1),
            new TemporarilyAppreciatingItem("Backstage passes to a TAFKAL80ETC concert", 15, 20),
            new TemporarilyAppreciatingItem("Backstage passes to a TAFKAL80ETC concert", 10, 49),
            new TemporarilyAppreciatingItem("Backstage passes to a TAFKAL80ETC concert", 5, 49),
            // this conjured item does not work properly yet
            new StoreItem("Conjured Mana Cake", 3, 6)
        ];

        var app = new GildedRose(Items);
        app.ProcessForDays(30);
    }
}
