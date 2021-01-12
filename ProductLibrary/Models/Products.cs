using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLibrary.Models
{
    public class Products:IEnumerable
    {
        List<Product> _productList = null;

        public Products()
        {
            _productList = new List<Product>();
            SeedData();
        }

        public Product this[int index]
        {
            get
            {
                return _productList[index];
            }
        }

        private void SeedData()
        {
            this.Add(ProductObjectFactory.CreateNewProduct("Coffee", "Warm drinks", 5.00m));
            this.Add(ProductObjectFactory.CreateNewProduct("Coca-cola", "Cold drinks", 2.00m));
            this.Add(ProductObjectFactory.CreateNewProduct("Milk", "Cold drinks", 1.50m));
            this.Add(ProductObjectFactory.CreateNewProduct("Thee", "Warm drinks", 3.15m));
            this.Add(ProductObjectFactory.CreateNewProduct("Water", "Cold drinks", 1.15m));
        }

        public void Add(Product product)
        {
            _productList.Add(product);
        }

        public IEnumerator GetEnumerator()
        {
            return _productList.GetEnumerator();
        }
    }
}
