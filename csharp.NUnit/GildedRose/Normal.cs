namespace GildedRoseKata;

public class Normal : Item
{
    public override void PassDay()
    {
        DecreaseQuality();
        DecreaseSellIn();
    }
}