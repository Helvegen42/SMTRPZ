using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IBooksService
    {
        Task AddBooksAsync(BooksDTO books);
        Task<BooksDTO> GetBooksByIdAsync(int id);
    }
}
