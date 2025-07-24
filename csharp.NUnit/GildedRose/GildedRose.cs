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
        if (IsAgedBrie(theItem) && theItem.Name != "Backstage passes to a TAFKAL80ETC concert")
        {
            if (theItem.Quality > 0)
            {
                if (theItem.Name != "Sulfuras, Hand of Ragnaros")
                {
                    theItem.Quality = theItem.Quality - 1;
                }
            }
        }
        else
        {
            if (theItem.Quality < 50)
            {
                theItem.Quality = theItem.Quality + 1;

                if (theItem.Name == "Backstage passes to a TAFKAL80ETC concert")
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

        if (theItem.Name != "Sulfuras, Hand of Ragnaros")
        {
            theItem.SellIn = theItem.SellIn - 1;
        }

        if (theItem.SellIn < 0)
        {
            if (theItem.Name != "Aged Brie")
            {
                if (theItem.Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (theItem.Quality > 0)
                    {
                        if (theItem.Name != "Sulfuras, Hand of Ragnaros")
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
    }

    bool IsAgedBrie(Item theItem)
    {
        return theItem.Name != "Aged Brie";
    }
}