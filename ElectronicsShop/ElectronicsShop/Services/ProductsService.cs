﻿using System.Collections.ObjectModel;

namespace ElectronicsShop.Services
{
    public class ProductsService
    {
        public ObservableCollection<Product> GetProducts()
        {
            ObservableCollection<Product> products = new()
            {
                new Product("Kitchen Apliances", 1, "Fridge_1", "lol_1_manufacturer", 10000, "lol_1_description", 10, "fridge.jpg"),
                new Product("Kitchen Apliances", 1, "Toaster_1", "lol_2_manufacturer", 10000, "lol_2_description", 10, "toaster.jpg"),
                new Product("TVs", 1, "TV_1", "lol_3_manufacturer", 10000, "lol_3_description", 10, "tv.jpg")
            };
            return products;
        }
    }
}
