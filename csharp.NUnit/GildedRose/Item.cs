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

        return new Item
        {
            Name = name,
            SellIn = sellIn,
            Quality = quality
        };
    }

    public void PassDay()
    {
        var theItem = this;

        if (!theItem.IsBackstagePasses())
            theItem.DecreaseQuality();
        else
            lkasjdfkl(theItem);

        theItem.DecreaseSellIn();
    }

    protected virtual void DecreaseSellIn()
    {
        SellIn -= 1;

        if (SellIn < 0)
            Spoil(this);
    }

    protected virtual void DecreaseQuality()
    {
        Quality = Math.Max(0, Quality - 1);
    }

    protected void IncreaseQuality()
    {
        Quality = Math.Min(50, Quality + 1);
    }

    void SpoilQuality()
    {
        Quality = 0;
    }

    public bool IsBackstagePasses() => Name == "Backstage passes to a TAFKAL80ETC concert";

    static void lkasjdfkl(Item theItem)
    {
        theItem.IncreaseQuality();

        if (theItem.IsBackstagePasses())
        {
            if (theItem.SellIn < 11)
                theItem.IncreaseQuality();

            if (theItem.SellIn < 6)
                theItem.IncreaseQuality();
        }
    }

    static void Spoil(Item theItem)
    {
        if (theItem.IsBackstagePasses())
            theItem.SpoilQuality();
        else
            theItem.DecreaseQuality();
    }
}