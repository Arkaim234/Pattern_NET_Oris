using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.Iterator
{
    public class BookCollection : IContainer<string>
    {
        private List<string> _books = new List<string>();

        public void AddBook(string book) => _books.Add(book);

        public IIterator<string> CreateIterator() => new BookIterator(this);

        private class BookIterator : IIterator<string>
        {
            private BookCollection _collection;
            private int _index = 0;

            public BookIterator(BookCollection collection) => _collection = collection;

            public bool HasNext() => _index < _collection._books.Count;

            public string Next()
            {
                if (!HasNext()) throw new InvalidOperationException();
                return _collection._books[_index++];
            }
        }
    }
}
