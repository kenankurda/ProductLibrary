using ProductLibrary.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLibrary.Models
{
    public class ProductObjectFactory
    {
        private static ProductCreateView productCreateView = null;
        public static Product CreateNewProduct(string name, string description, decimal price)
        {
            return new Product
            {
                Name = name,
                Description = description,
                Price = price
            };
        }

        public static ProductRecordsView ProductRecordsViewObject(Products products)
        {
            return new ProductRecordsView(products);
        }

    }
}
