namespace GildedRoseKata;

internal class AgedBrie : Item
{
    public override string Name => "Aged Brie";
    
    protected override void DecreaseQuality()
    {
        IncreaseQuality();
    }
    
    protected override void DecreaseSellIn()
    {
        SellIn -= 1;
        if (SellIn < 0)
            IncreaseQuality();
    }
}