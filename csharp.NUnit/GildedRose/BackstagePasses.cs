using System;

namespace GildedRoseKata;

internal class BackstagePasses : Item
{
    public override string Name =>  "Backstage passes to a TAFKAL80ETC concert";

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