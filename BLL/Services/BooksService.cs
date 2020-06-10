using AutoMapper;
using BLL.DTO;
using BLL.Interfaces;
using DAL.Entities;
using DAL.UoF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    class BooksService : BaseService, IBooksService
    {
        public BooksService(IMapper mapper, IUoF uof) : base(mapper, uof)
        {

        }

        public async Task AddGoodsAsync(BooksDTO books
            )
        {
            var mappedGoods = _mapper.Map<Books>(books);

            await _uof.BooksRepository.AddAsync(mappedBooks);
        }

        public async Task<BooksDTO> GetBooksByIdAsync(int id)
        {
            var result = await _uof.BooksRepository.GetByIdAsync(id);

            return _mapper.Map<BooksDTO>(result);
        }

    }
}
