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

    public class CheeseMongersItem
    {
        public string Name { get; set; }

        public int ValidByDays { get; set; }

        public int Quality { get; set; }
    }

    public class RicottaCheese
    {
        public string Name { get; set; }
        public int ValidByDays { get; set; }
        public int Quality { get; set; }
    }
}
   
