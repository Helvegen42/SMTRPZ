using AutoMapper;
using BLL.DTO;
using DAL.Entities;
using DAL.UoF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    class LockerService : BaseService
    {
        public LockerService(IMapper mapper, IUoF uof) : base(mapper, uof)
        {

        }

        public async Task PlaceBooksAsync(BooksDTO books, LockerDTO cRoom)
        {
            var room = await _uof.LockerRepository.GetByIdAsync(cRoom.Id);

            if (room == null) throw new Exception("Clear");

            var mappedBooks = _mapper.Map<Books>(books);

            if ((string)books.Theme != (string)cRoom.Theme) throw new Exception("Wrong");

            room.Bookses.Add(mappedBooks);

            await _uof.LockerRepository.UpdateAsync(room);
        }
    }
}
