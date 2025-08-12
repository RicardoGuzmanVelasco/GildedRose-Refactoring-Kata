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
            if (HasQuality)
            {
                if (!IsSulfuras)
                {
                    Quality--;
                }
            }
        }
        else
        {
            if (Quality < 50)
            {
                Quality++;

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
                    if (Quality > 0)
                    {
                        if (!IsSulfuras)
                        {
                            Quality--;
                        }
                    }
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

    private void IncreaseQuality()
    {
        if (Quality < 50)
        {
            Quality++;
        }
    }

    private bool IsBackstage => (Name == "Backstage passes to a TAFKAL80ETC concert");

    private bool IsAgedBrie => Name == "Aged Brie";


    private bool IsSulfuras => Name == "Sulfuras, Hand of Ragnaros";

    private bool HasQuality => Quality > 0;
}