﻿using System;
using System.Collections.Generic;

namespace GildedRoseKata;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("OMGHAI!");

        IList<Item> items = new List<Item>
        {
            Item.Create("+5 Dexterity Vest", 10, 20),
            Item.Create("Aged Brie", 2, 0),
            Item.Create("Elixir of the Mongoose", 5, 7),
            Item.Create("Sulfuras, Hand of Ragnaros", 0, 80),
            Item.Create("Sulfuras, Hand of Ragnaros", -1, 80),
            Item.Create("Backstage passes to a TAFKAL80ETC concert", 15, 20),
            Item.Create("Backstage passes to a TAFKAL80ETC concert", 10, 49),
            Item.Create("Backstage passes to a TAFKAL80ETC concert", 5, 49),
            // this conjured item does not work properly yet
            Item.Create("Conjured Mana Cake", 3, 6)
        };

        var app = new GildedRose(items);

        int days = 2;
        if (args.Length > 0)
        {
            days = int.Parse(args[0]) + 1;
        }

        for (var i = 0; i < days; i++)
        {
            Console.WriteLine("-------- day " + i + " --------");
            Console.WriteLine("name, sellIn, quality");
            for (var j = 0; j < items.Count; j++)
            {
                Console.WriteLine(items[j].Name + ", " + items[j].SellIn + ", " + items[j].Quality);
            }
            Console.WriteLine("");
            app.UpdateQuality();
        }
    }
}