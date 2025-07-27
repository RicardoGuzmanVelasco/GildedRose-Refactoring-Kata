namespace GildedRoseKata;

public class Conjured : Item
{
    public override string Name => "Conjured Mana Cake";

    public override void PassDay()
    {
        DecreaseQuality();
        DecreaseQuality();
        DecreaseSellIn();
        if (IsSpoiled())
            DecreaseQuality();
    }
}