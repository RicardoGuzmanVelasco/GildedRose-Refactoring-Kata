using System;

namespace GildedRoseKata;

public class Item
{
    public string Name { get; set; }
    public int SellIn { get; set; }
    public int Quality { get; set; }

    public void PassDay()
    {
        
    }

    public void DecreaseSellIn()
    {
        if (!IsSulfuras())
            SellIn -= 1;
    }

    public void DecreaseQuality()
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