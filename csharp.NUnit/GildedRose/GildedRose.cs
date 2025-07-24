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
            PassDayOn(item);
    }

    void PassDayOn(Item theItem)
    {
        if (!theItem.IsAgedBrie() && !theItem.IsBackstagePasses())
            theItem.DecreaseQuality();
        else
            lkasjdfkl(theItem);

        theItem.DecreaseSellIn();

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
        theItem.IncreaseQuality();

        if (theItem.IsBackstagePasses())
        {
            if (theItem.SellIn < 11)
                theItem.IncreaseQuality();

            if (theItem.SellIn < 6)
                theItem.IncreaseQuality();
        }
    }
}