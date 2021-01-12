using ProductLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLibrary.Views
{
    public class ProductRecordsView
    {
        private Products _products = null;

        public ProductRecordsView(Products products)
        {
            _products = products;
        }

        public void RunRecordsView()
        {
            Console.WriteLine(ProductCommonOutpuText.GetColumnHeadings());
            Console.WriteLine();

            foreach (Product item in _products)
            {
                Console.WriteLine(item.GetProductInformation());
            }
        }
    }
}
