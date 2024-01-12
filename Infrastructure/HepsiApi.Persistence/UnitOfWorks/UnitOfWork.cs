using HepsiApi.Application.Interfaces.Repositories;
using HepsiApi.Application.Interfaces.UnitOfWorks;
using HepsiApi.Persistence.Context;
using HepsiApi.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiApi.Persistence.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext appDbContext;

        public UnitOfWork(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async ValueTask DisposeAsync()=> await this.appDbContext.DisposeAsync();


        public int Save() => appDbContext.SaveChanges();

        public async Task<int> SaveAsync()=> await appDbContext.SaveChangesAsync();

        IReadRepository<T> IUnitOfWork.GetReadRepository<T>()=> new ReadRepository<T>(appDbContext);

        IWriteRepository<T> IUnitOfWork.GetWriteRepository<T>()=> new WriteRepository<T>(appDbContext);
    }
}
