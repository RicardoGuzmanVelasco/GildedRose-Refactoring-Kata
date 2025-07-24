namespace GildedRoseKata;

internal class Sulfuras : Item
{
    public override string Name => "Sulfuras, Hand of Ragnaros";

    public override void DecreaseSellIn()
    {
        //Sulfuras is legendary, does not sell in.
    }

    public override void DecreaseQuality()
    {
        //Sulfuras is legendary, does not decrease quality.
    }
}