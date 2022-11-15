﻿using System.Collections.ObjectModel;
using System.Reflection.Metadata.Ecma335;
using static ElectronicsShop.GlobalConst.SearchConst;

namespace ElectronicsShop.Services
{
    public class ProductsService
    {
        public List<Product> GetProducts()
        {
            List<Product> products = new()
            {
                new Product(KITCHEN_CATEGORY, 1, "Fridge_1", "lol_1_manufacturer", 10000, "lol_1_description", 0, "fridge.jpg"),
                new Product(KITCHEN_CATEGORY, 2, "Toaster_1", "lol_2_manufacturer", 10000, "lol_2_description", 0, "toaster.jpg"),
                new Product(TV_CATEGORY, 3, "TV_1", "lol_3_manufacturer", 10000, "lol_3_description", 0, "tv.jpg"),
                new Product(TV_CATEGORY, 4, "TV_2", "lol_3_manufacturer", 10000, "lol_3_description", 0, "tv2.jpg"),
                new Product(SMARTPHONES_CATEGORY, 5, "Smartphone_1", "lol_3_manufacturer", 10000, "lol_3_description", 0, "smartphone.jpg"),
                new Product(HOME_CATEGORY, 6, "Homeapl_1", "lol_3_manufacturer", 10000, "lol_3_description", 0, "washing_machine.jpg"),
                new Product(LAPTOPS_CATEGORY, 7, "Laptop_1", "lol_3_manufacturer", 10000, "lol_3_description", 0, "laptop.jpg")
            };
            return products;
        }
        public List<Product> GetProducts(Product filter)
        {
            return TempServer.FilterProducts(filter);
        }
    }
}
