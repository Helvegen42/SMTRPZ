using DAL.Entities;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.UoF
{
    class UoF : IUoF, IDisposable
    {
        public UoF(ApplicationDbContext context) => _context = context;

        readonly ApplicationDbContext _context;

        IRepository<Storage> storageRepository;
        IRepository<Locker> containRoomRepository;
        IRepository<Books> goodsRepository;

        public IRepository<Storage> StorageRepository =>
            storageRepository ??= new Repository<Storage>(_context);

        public IRepository<Locker> LockerRepository =>
            lockerRepository ??= new Repository<Locker>(_context);

        public IRepository<Books> BooksRepository =>
           booksRepository ??= new Repository<Books>(_context);

        bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }

            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~UoF()
        {
            Dispose(false);
        }
    }
}
