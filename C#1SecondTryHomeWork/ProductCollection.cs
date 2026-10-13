using System;
using System.Collections;
using System.Collections.Generic;

namespace C_1SecondTryHomeWork
{
    public class ProductCollection : IEnumerable<string>
    {
        private List<string> _products = new List<string>();

        public void Add(string product)
        {
            _products.Add(product);
        }

        public IEnumerator<string> GetEnumerator()
        {
            return new ProductIterator(_products);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

}
