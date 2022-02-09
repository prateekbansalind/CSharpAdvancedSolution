using System.Collections.Generic;

namespace LambdaExpressions
{
    public class BookRepo
    {
        public List<Book> BookList()
        {
            return new List<Book>
            {
                new Book() {Title = "Title 1", Price = 5},
                new Book() {Title = "Title 2", Price = 7},
                new Book() {Title = "Title 3", Price = 15}
            };
        }
    }
}
