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
            kllkafjsdl(theItem);
        else
            lkasjdfkl(theItem);

        if (!IsSulfuras(theItem))
            theItem.SellIn = theItem.SellIn - 1;

        if (theItem.SellIn < 0)
            jaklsdjflkads(theItem);
    }

    static void jaklsdjflkads(Item theItem)
    {
        if (!IsAgedBrie(theItem))
        {
            if (!IsBackstagePasses(theItem))
            {
                if (theItem.Quality > 0)
                {
                    if (!IsSulfuras(theItem))
                    {
                        theItem.Quality = theItem.Quality - 1;
                    }
                }
            }
            else
            {
                theItem.Quality = theItem.Quality - theItem.Quality;
            }
        }
        else
        {
            if (theItem.Quality < 50)
            {
                theItem.Quality = theItem.Quality + 1;
            }
        }
    }

    static void kllkafjsdl(Item theItem)
    {
        if (IsSulfuras(theItem))
            return;

        theItem.DecreaseQuality();
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

    private static bool IsSulfuras(Item theItem)
    {
        return theItem.Name == "Sulfuras, Hand of Ragnaros";
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