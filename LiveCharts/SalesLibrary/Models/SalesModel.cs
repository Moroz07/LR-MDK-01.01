using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesLibrary.Models
{
    public class SalesModel
    {
        private Dictionary<Item, List<Sale>> salesByItems_ =
            new Dictionary<Item, List<Sale>>();

        public void AddSales(Item item, List<Sale> sales)
        {
            if (salesByItems_.ContainsKey(item))
            {
                salesByItems_[item].AddRange(sales);
            }
            else
            {
                salesByItems_.Add(item, sales);
            }
        }


        public List<Sale> LoadSalesForItem(string itemName)
        {
            List<Item> allItems = salesByItems_.Keys.ToList();
            Item targetItem = allItems.Find(item => item.Name == itemName);
            if (targetItem != null)
            {
                return salesByItems_[targetItem];
            }

            return new List<Sale>();
        }

        public bool Load()
        {
            AddSales(new Item { Name = "Капучино", Price = 150 },
                new List<Sale>() {
                    new Sale {Time = new System.DateTime(2026, 2, 1), Count = 43 } ,
                    new Sale {Time = new System.DateTime(2026, 2, 2), Count = 62 },
                    new Sale {Time = new System.DateTime(2026, 2, 3), Count = 24 },
                    new Sale {Time = new System.DateTime(2026, 2, 4), Count = 36 },
                    new Sale {Time = new System.DateTime(2026, 2, 5), Count = 38 },
                    new Sale {Time = new System.DateTime(2026, 2, 6), Count = 44 },
                    new Sale {Time = new System.DateTime(2026, 2, 7), Count = 32 },
                    new Sale {Time = new System.DateTime(2026, 2, 8), Count = 55 },
                    new Sale {Time = new System.DateTime(2026, 2, 9), Count = 35 },
                    new Sale {Time = new System.DateTime(2026, 2, 10), Count = 18},
                });

            AddSales(new Item { Name = "Сок добрый", Price = 120 },
                new List<Sale>() {
                    new Sale {Time = new System.DateTime(2026, 2, 1), Count = 15 } ,
                    new Sale {Time = new System.DateTime(2026, 2, 2), Count = 25 },
                    new Sale {Time = new System.DateTime(2026, 2, 3), Count = 31 },
                    new Sale {Time = new System.DateTime(2026, 2, 4),Count = 9  },
                    new Sale {Time = new System.DateTime(2026, 3, 6), Count = 19 },
                    new Sale {Time = new System.DateTime(2026, 2, 8), Count = 20 },
                    new Sale {Time = new System.DateTime(2026, 2, 9),Count = 14 },
                    new Sale {Time = new System.DateTime(2026, 3, 10), Count = 33 },
               });

            AddSales(new Item { Name = "Чай Ice", Price = 85 },
                new List<Sale>() {
                    new Sale {Time = new System.DateTime(2026, 2, 1), Count = 10 } ,
                    new Sale {Time = new System.DateTime(2026, 2, 2), Count = 56 },
                    new Sale {Time = new System.DateTime(2026, 2, 3), Count = 45 },
                    new Sale {Time = new System.DateTime(2026, 2, 4),Count = 7  },
                    new Sale {Time = new System.DateTime(2026, 3, 7), Count = 22 },
                    new Sale {Time = new System.DateTime(2026, 2, 9), Count = 34 },
                    new Sale {Time = new System.DateTime(2026, 2, 10),Count = 39 },
                    new Sale {Time = new System.DateTime(2026, 3, 11), Count = 33 },
               });

            return true;
        }

        public List<Item> GetAllItems()
        {
            return salesByItems_.Keys.ToList();
        }

        public double GetTotalProfit()
        {
            double result = 0.0;
            foreach (KeyValuePair<Item, List<Sale>> keyValue in salesByItems_)
            {
                Item item = keyValue.Key;
                result += keyValue.Value.Sum(sale => sale.Count * item.Price);
            }

            return result;
        }

        public Item GetItem(string itemName)
        {
            foreach (KeyValuePair<Item, List<Sale>> keyValue in salesByItems_)
            {
                Item item = keyValue.Key;
                if (item.Name == itemName)
                {
                    return item;
                }
            }

            return null;
        }
    }
}
