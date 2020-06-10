using DAL.Entities;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.UoF
{
    public interface IUoF
    {
        IRepository<Storage> StorageRepository { get; }
        IRepository<Locker> ContainRoomRepository { get; }
        IRepository<Books> GoodsRepository { get; }
    }
}
