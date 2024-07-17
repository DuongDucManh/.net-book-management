using Microsoft.Identity.Client;
using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BookCategoryService
    {
        BookCategoryRepository _repo = new BookCategoryRepository();
        //To do: call the repository method to retrieve the data from database... this week/next week 

        //For now we temporarily use the hard-coded values
        public List<BookCategory> GetAllCategories()
        {
            return _repo.GetAllBookCategories();

            //TODO: Gọi class BookCategoryRepository để lấy toàn bộ danh mục phân loại sách từ DB
            //Call class BookCategoryRepository to retrieve all book categories from DB

        }
    }
}
