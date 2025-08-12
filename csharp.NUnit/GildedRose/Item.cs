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
            if (QualityNotSulfurasdojderfgoijsdofg())
            {
                Quality--;
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
                        if (Quality < 50)
                        {
                            Quality++;
                        }
                    }

                    if (SellIn < 6)
                    {
                        if (Quality < 50)
                        {
                            Quality++;
                        }
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
                if (Quality < 50)
                {
                    Quality++;
                }
            }
        }
    }

    private bool IsBackstage => (Name == "Backstage passes to a TAFKAL80ETC concert");

    private bool IsAgedBrie => Name == "Aged Brie";


    private bool QualityNotSulfurasdojderfgoijsdofg()
    {
        return HasQuality && !IsSulfuras;
    }

    private bool IsSulfuras => Name == "Sulfuras, Hand of Ragnaros";

    private bool HasQuality => Quality > 0;
}