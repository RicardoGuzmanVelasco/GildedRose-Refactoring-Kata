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

    public void DecreaseQuality()
    {
        if (IsSulfuras(this))
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
    
    public static bool IsSulfuras(Item theItem)
    {
        return theItem.Name == "Sulfuras, Hand of Ragnaros";
    }
}