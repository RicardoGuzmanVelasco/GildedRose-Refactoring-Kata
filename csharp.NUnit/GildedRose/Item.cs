using System;

namespace GildedRoseKata;

public class Item
{
    public string Name { get; set; }
    public int SellIn { get; set; }
    public int Quality { get; set; }
    
    public void PassDay()
    {
        if (!IsAgedBrie && !IsBackstage)
        {
            DecreaseQuality();
        }
        else
        {
            IncreaseQuality();

            if (IsBackstage)
            {
                if (SellIn < 11)
                {
                    IncreaseQuality();
                }

                if (SellIn < 6)
                {
                    IncreaseQuality();
                }
            }
        }

        if (!IsSulfuras)
        {
            SellIn--;
        }

        if (SellIn < 0)
        {
            if (!IsAgedBrie)
            {
                if (!IsBackstage)
                {
                    DecreaseQuality();
                }
                else
                {
                    Quality = 0;
                }
            }
            else
            {
                IncreaseQuality();
            }
        }
    }

    private void DecreaseQuality()
    {
        if (IsSulfuras) return;
        Quality = Math.Max(--Quality, 0);
    }

    private void IncreaseQuality()
    {
        Quality = Math.Min(++Quality, 50);
    }

    private bool IsBackstage => (Name == "Backstage passes to a TAFKAL80ETC concert");

    private bool IsAgedBrie => Name == "Aged Brie";


    private bool IsSulfuras => Name == "Sulfuras, Hand of Ragnaros";

    private bool HasQuality => Quality > 0;
}