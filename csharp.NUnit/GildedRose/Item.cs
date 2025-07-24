using System;

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
        
        return new Item
        {
            Name = name,
            SellIn = sellIn,
            Quality = quality
        };
    }

    public void PassDay()
    {
        
    }

    public virtual void DecreaseSellIn()
    {
        if (!IsSulfuras())
            SellIn -= 1;
    }

    public virtual void DecreaseQuality()
    {
        if (IsSulfuras())
            return;
        
        Quality = Math.Max(0, Quality - 1);
    }

    public void IncreaseQuality()
    {
        Quality = Math.Min(50, Quality + 1);
    }

    public void SpoilQuality()
    {
        Quality = 0;
    }
    
    public bool IsSulfuras() => Name == "Sulfuras, Hand of Ragnaros";
    public bool IsBackstagePasses() => Name == "Backstage passes to a TAFKAL80ETC concert";
    public bool IsAgedBrie() => Name == "Aged Brie";
}