using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge
{
    //Geico    question
    //Requirement: in C# update the system to support new type of cheese "Ricotta".
    //"updateQuality" has to degrade "Ricotta" 3 times as fast as normal cheeses, because the freshest "Ricotta" is the most delicious.
    //refactor the code to improve its quality without changing original behaviour.

    public class CheeseMongers
    {
        private IList<CheeseMongersItem> Items;
        public CheeseMongers(IList<CheeseMongersItem> items)
        {
            Items = items;
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                if (Items[i].Name != "Parmigiano Regiano" && Items[i].Name != "Tasting with Chef Massimo")
                {
                    if (Items[i].Quality > 0)
                    {
                        if (Items[i].Name != "Caciocavallo Podolico")
                        {
                            Items[i].Quality = Items[i].Quality - 1;
                        }
                    }
                }
                else
                {
                    if (Items[i].Quality < 100)
                    {
                        Items[i].Quality = Items[i].Quality + 1;

                        if (Items[i].Name == "Tasting with Chef Massimo")
                        {
                            if (Items[i].ValidByDays < 15)
                            {
                                if (Items[i].Quality < 100)
                                {
                                    if (Items[i].Quality + 2 <= 100)
                                    {
                                        Items[i].Quality = Items[i].Quality + 2;
                                    }
                                    else
                                    {
                                        Items[i].Quality = 100;
                                    }
                                }
                            }

                            if (Items[i].ValidByDays < 8)
                            {
                                if (Items[i].Quality < 100)
                                {
                                    if (Items[i].Quality + 2 <= 100)
                                    {
                                        Items[i].Quality = Items[i].Quality + 2;
                                    }
                                    else
                                    {
                                        Items[i].Quality = 100;
                                    }
                                }
                            }
                        }
                    }
                }

                if (Items[i].Name != "Caciocavallo Podolico")
                {
                    Items[i].ValidByDays = Items[i].ValidByDays - 1;
                }

                if (Items[i].ValidByDays < 0)
                {
                    if (Items[i].Name != "Parmigiano Regiano")
                    {
                        if (Items[i].Name != "Tasting with Chef Massimo")
                        {
                            if (Items[i].Quality > 0)
                            {
                                if (Items[i].Name != "Caciocavallo Podolico")
                                {
                                    if (Items[i].Quality - 4 > 0)
                                    {
                                        Items[i].Quality = Items[i].Quality - 4;
                                    }
                                    else
                                    {
                                        Items[i].Quality = 0;
                                    }
                                }
                            }
                        }
                        else
                        {
                            Items[i].Quality = Items[i].Quality - Items[i].Quality;
                        }
                    }
                }
            }
        }

    }

    //Solution
    public class CheeseMongers1
    {
        private IList<CheeseMongersItem> _items;

        public CheeseMongers1(IList<CheeseMongersItem> items)
        {
            _items = items;
        }

        public void UpdateQuality()
        {
            foreach (var item in _items)
            {
                if (item.Name == "Ricotta")
                {
                    DegradeRicotta(item);
                    continue;
                }

                if (item.Name != "Parmigiano Reginao" && item.Name != "Tasting with chef Massimo")
                {
                    UpdateNormalCheese(item);
                }
                else
                {
                    UpdateSpecialCheese(item);
                }

                if (item.Name != "Caciocavallo Padolico")
                {
                    item.ValidByDays--;
                }

                if (item.ValidByDays < 0)
                {
                    UpdateExpiredCheese(item);
                }

            }
        }

        private void DegradeRicotta(CheeseMongersItem ricotta)
        {
            if (ricotta.Quality > 0)
            {
                ricotta.Quality -= 3;
            }
            ricotta.ValidByDays--;
        }

        private void UpdateNormalCheese(CheeseMongersItem normalChese)
        {
            if (normalChese.Quality > 0)
            {
                normalChese.Quality--;
            }
            normalChese.ValidByDays--;
        }

        private void UpdateSpecialCheese(CheeseMongersItem specialCheese)
        {
            if (specialCheese.Quality < 100)
            {
                specialCheese.Quality++;
                if (specialCheese.Name == "Tasting with chef Massimo" && specialCheese.ValidByDays < 15)
                {
                    IncreaseQuality(specialCheese, 2);
                }

                if (specialCheese.ValidByDays < 8)
                {
                    IncreaseQuality(specialCheese, 2);
                }
            }
        }

        private void UpdateExpiredCheese(CheeseMongersItem expiredCheese)
        {
            if (expiredCheese.Name != "parmigiano Regiano" && expiredCheese.Name != "Tasting with Chef Massimo" && expiredCheese.Quality > 0)
            {
                if (expiredCheese.Name != "Caciocavallo Podolico")
                {
                    DecreaseQuality(expiredCheese, 4);
                }
            }
            else
            {
                ResetQuality(expiredCheese);
            }
        }



        private void IncreaseQuality(CheeseMongersItem item, int value)
        {
            if (item.Quality + value <= 100)
            {
                item.Quality += value;
            }
            else
            {
                item.Quality = 100;
            }
        }

        private void DecreaseQuality(CheeseMongersItem item, int value)
        {
            if (item.Quality - value > 0)
            {
                item.Quality -= value;
            }
            else
            {
                item.Quality = 0;
            }
        }

        private void ResetQuality(CheeseMongersItem item)
        {
            item.Quality = 0;
        }
    }
}


public class CheeseMongersItem
{
    public string Name { get; set; }

    public int ValidByDays { get; set; }

    public int Quality { get; set; }
}

//public class RicottaCheese
//{
//    public string Name { get; set; }
//    public int ValidByDays { get; set; }
//    public int Quality { get; set; }
//}

public class RicottaChese : CheeseMongersItem
{

}


