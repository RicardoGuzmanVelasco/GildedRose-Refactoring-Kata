namespace GildedRoseKata;

internal class Sulfuras : Item
{
    public override string Name => "Sulfuras, Hand of Ragnaros";

    protected override void DecreaseSellIn()
    {
        //Sulfuras is legendary, does not sell in.
    }

    protected override void DecreaseQuality()
    {
        //Sulfuras is legendary, does not decrease quality.
    }
}