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
        IRepository<Locker> LockerRepository { get; }
        IRepository<Books> BooksRepository { get; }
    }
}
