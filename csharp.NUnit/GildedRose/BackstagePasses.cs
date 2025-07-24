using System;

namespace GildedRoseKata;

internal class BackstagePasses : Item
{
    public override void PassDay()
    {
        IncreaseQuality();
        if (SellIn < 11)
            IncreaseQuality();
        if (SellIn < 6)
            IncreaseQuality();
        SellIn -= 1;

        if (SellIn < 0)
            Quality = 0;
    }
}