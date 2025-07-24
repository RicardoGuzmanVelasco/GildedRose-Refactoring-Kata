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
        if (!theItem.IsAgedBrie() && !theItem.IsBackstagePasses())
            theItem.DecreaseQuality();
        else
            lkasjdfkl(theItem);

        if (!theItem.IsSulfuras())
            theItem.SellIn = theItem.SellIn - 1;

        if (theItem.SellIn < 0)
            jaklsdjflkads(theItem);
    }

    static void jaklsdjflkads(Item theItem)
    {
        if (theItem.IsAgedBrie())
            theItem.IncreaseQuality();
        else
        {
            if (theItem.IsBackstagePasses())
                theItem.SpoilQuality();
            else
                theItem.DecreaseQuality();
        }
    }

    static void lkasjdfkl(Item theItem)
    {
        if (theItem.Quality < 50)
        {
            theItem.Quality = theItem.Quality + 1;

            if (theItem.IsBackstagePasses())
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
}