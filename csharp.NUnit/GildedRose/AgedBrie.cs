﻿namespace GildedRoseKata;

internal class AgedBrie : Item
{
    public override string Name => "Aged Brie";

    public override void PassDay()
    {
        IncreaseQuality();
        DecreaseSellIn();
    }

    protected override void DecreaseQuality()
    {
        IncreaseQuality();
    }
}