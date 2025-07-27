using System;
using System.Diagnostics;

namespace GildedRoseKata;

public abstract class Item
{
    public virtual string Name { get; private init; }
    public int SellIn { get; protected set; }
    public int Quality { get; protected set; }

    public static Item Create(string name, int sellIn, int quality)
    {
        return name switch
        {
            "Sulfuras, Hand of Ragnaros" => new Sulfuras() { SellIn = sellIn, Quality = quality },
            "Aged Brie" => new AgedBrie() { SellIn = sellIn, Quality = quality },
            "Backstage passes to a TAFKAL80ETC concert" => new BackstagePasses() { SellIn = sellIn, Quality = quality },
            "Conjured Mana Cake" => new Conjured() { SellIn = sellIn, Quality = quality},
            _ => new Normal { Name = name, SellIn = sellIn, Quality = quality }
        };
    }

    public abstract void PassDay();

    protected void DecreaseSellIn()
    {
        SellIn -= 1;
    }

    protected bool IsSpoiled()
    {
        return SellIn < 0;
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