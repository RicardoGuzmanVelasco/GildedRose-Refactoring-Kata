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
        if (name == "Sulfuras, Hand of Ragnaros")
            return new Sulfuras()
            {
                SellIn = sellIn,
                Quality = quality
            };

        if (name == "Aged Brie")
            return new AgedBrie()
            {
                SellIn = sellIn,
                Quality = quality
            };
        
        if (name == "Backstage passes to a TAFKAL80ETC concert")
        {
            return new BackstagePasses()
            {
                Name = name,
                SellIn = sellIn,
                Quality = quality
            };
        }

        return new Item
        {
            Name = name,
            SellIn = sellIn,
            Quality = quality
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