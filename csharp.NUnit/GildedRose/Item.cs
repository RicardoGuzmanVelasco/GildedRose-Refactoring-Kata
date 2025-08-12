namespace GildedRoseKata;

public class Item
{
    public string Name { get; set; }
    public int SellIn { get; set; }
    public int Quality { get; set; }
    
    public void PassDay()
    {
        if (Name != "Aged Brie" && Name != "Backstage passes to a TAFKAL80ETC concert")
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

                if (Name == "Backstage passes to a TAFKAL80ETC concert")
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
            SellIn = SellIn - 1;
        }

        if (SellIn < 0)
        {
            if (Name != "Aged Brie")
            {
                if (Name != "Backstage passes to a TAFKAL80ETC concert")
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
                    Quality = Quality - Quality;
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
    
        

    private bool QualityNotSulfurasdojderfgoijsdofg()
    {
        return HasQuality && !IsSulfuras;
    }

    private bool IsSulfuras => Name == "Sulfuras, Hand of Ragnaros";

    private bool HasQuality => Quality > 0;
}