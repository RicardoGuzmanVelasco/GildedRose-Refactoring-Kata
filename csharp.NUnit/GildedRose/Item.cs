using System;
using System.Diagnostics;

namespace GildedRoseKata;

public class Item
{
    public virtual string Name { get; init; }
    public int SellIn { get; set; }
    public int Quality { get; set; }

    public static Item Create(string name, int sellIn, int quality)
    {
        return name switch
        {
            "Sulfuras, Hand of Ragnaros" => new Sulfuras() { SellIn = sellIn, Quality = quality },
            "Aged Brie" => new AgedBrie() { SellIn = sellIn, Quality = quality },
            "Backstage passes to a TAFKAL80ETC concert" => new BackstagePasses() { Name = name, SellIn = sellIn, Quality = quality },
            _ => new Normal { Name = name, SellIn = sellIn, Quality = quality }
        };
    }

    public virtual void PassDay()
    {
        DecreaseQuality();
        DecreaseSellIn();
    }

    protected virtual void DecreaseSellIn()
    {
        SellIn -= 1;

        if (SellIn < 0)
            DecreaseQuality();
    }

    protected virtual void DecreaseQuality()
    {
        Quality = Math.Max(0, Quality - 1);
    }

    protected void IncreaseQuality()
    {
        Quality = Math.Min(50, Quality + 1);
    }
}