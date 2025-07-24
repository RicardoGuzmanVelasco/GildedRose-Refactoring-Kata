namespace GildedRoseKata;

public class Normal : Item
{
    public virtual void PassDay()
    {
        DecreaseQuality();
        DecreaseSellIn();
    }
}