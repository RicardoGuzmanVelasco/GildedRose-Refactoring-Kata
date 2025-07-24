using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    IList<Item> Items;

    public GildedRose(IList<Item> Items)
    {
        this.Items = Items;
    }

    public void UpdateQuality()
    {
        foreach (var item in Items)
            aklsdjflkadsj(item);
    }

    void aklsdjflkadsj(Item theItem)
    {
        if (!IsAgedBrie(theItem) && !IsBackstagePasses(theItem))
            theItem.DecreaseQuality();
        else
            lkasjdfkl(theItem);

        if (!Item.IsSulfuras(theItem))
            theItem.SellIn = theItem.SellIn - 1;

        if (theItem.SellIn < 0)
            jaklsdjflkads(theItem);
    }

    static void jaklsdjflkads(Item theItem)
    {
        if (!IsAgedBrie(theItem))
        {
            if (!IsBackstagePasses(theItem))
                theItem.DecreaseQuality();
            else
                theItem.SpoilQuality();
        }
        else
            theItem.IncreaseQuality();
    }

    static void lkasjdfkl(Item theItem)
    {
        if (theItem.Quality < 50)
        {
            theItem.Quality = theItem.Quality + 1;

            if (IsBackstagePasses(theItem))
            {
                if (theItem.SellIn < 11)
                {
                    if (theItem.Quality < 50)
                    {
                        theItem.Quality = theItem.Quality + 1;
                    }
                }

                if (theItem.SellIn < 6)
                {
                    if (theItem.Quality < 50)
                    {
                        theItem.Quality = theItem.Quality + 1;
                    }
                }
            }
        }
    }

    private static bool IsBackstagePasses(Item theItem)
    {
        return theItem.Name == "Backstage passes to a TAFKAL80ETC concert";
    }

    static bool IsAgedBrie(Item theItem)
    {
        return theItem.Name == "Aged Brie";
    }
}