namespace C_1SecondTryHomeWork
{
    public class ProductIterator : IEnumerator<string>
    {
        private readonly List<string> _products;
        private int _position = -1;

        public ProductIterator(List<string> products)
        {
            _products = products;
        }

        public string Current => _products[_position];

        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            _position++;
            return _position < _products.Count;
        }

        public void Reset()
        {
            _position = -1;
        }

    }

}
