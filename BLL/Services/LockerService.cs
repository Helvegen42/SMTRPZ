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

        public async Task PlaceGoodsAsync(BooksDTO books, LockerDTO cRoom)
        {
            var room = await _uof.LockerRepository.GetByIdAsync(cRoom.Id);

            if (room == null) throw new Exception("Clear");

            var mappedBooks = _mapper.Map<Books>(books);

            if ((string)books.Theme != (string)cRoom.Theme) throw new Exception("Wrong");

            room.Goodsos.Add(mappedBooks);

            await _uof.ContainRoomRepository.UpdateAsync(room);
        }
    }
}
