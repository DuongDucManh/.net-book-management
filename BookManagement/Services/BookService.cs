using Repositories;
using Repositories.Entities;

namespace Services
{
    public class BookService
    {
        //Class ở giữa DB và UI
        //UI - FORM vừa làm - có grid/table <---> service --- Repo ---- DB/table
        //txtBookName, btnCreate, dgvList       BookService  CRUD vs    DB
        //                                      List Books     kết nối csdl, connection

        //Chứa các method để cung cấp data cho UI
        //Chưa các method để tương tác vs DB/REPO

        private BookRepository _repo = new();
        public List<Book> GetAllBooks()
        {
            return _repo.GetBooks();
        }

        public void UpdateBook(Book book)
        {
             _repo.UpdateBook(book);
        }

        public void DeleteBookFromUserSelected(Book book)
        {
            _repo.DeleteBook(book);
        }

        public void CreateBookFromUserInput(Book book)
        {
            _repo.CreateBook(book);
        }
    }
}
