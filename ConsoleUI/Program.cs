using ProductLibrary.Models;
using ProductLibrary.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Products products = new Products();
            ProductRecordsView productRecordsView = ProductObjectFactory.ProductRecordsViewObject(products);


            Console.WriteLine(ProductCommonOutpuText.GetApplicationHeading());
            productRecordsView.RunRecordsView();
        }
    }
}
