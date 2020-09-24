using Games.Domain.Models;
using Games.Domain.Interfaces.Repositories;
using Games.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using NetDevPack.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Games.Infra.Data.Repository
{
    public class PersonRepository : IPersonRepository
    {

        protected readonly GamesContext Db;
        protected readonly DbSet<PersonModel> DbSet;        

        public PersonRepository(GamesContext context)
        {
            Db = context;
            DbSet = Db.Set<PersonModel>();
        }

        public IUnitOfWork UnitOfWork => Db;

        public void Add(PersonModel person)
        {
            DbSet.Add(person);
        }

        public void Dispose()
        {
            Db.Dispose();
        }

        public async Task<IEnumerable<PersonModel>> GetAll()
        {
            return await DbSet.ToListAsync();
        }

        public async Task<PersonModel> GetByEmail(string email)
        {
            return await DbSet.AsNoTracking().FirstOrDefaultAsync(c => c.Email == email);
        }

        public async Task<PersonModel> GetById(Guid id)
        {
            return await DbSet.FindAsync(id);
        }

        public void Remove(PersonModel person)
        {
            DbSet.Remove(person);
        }

        public void Update(PersonModel person)
        {
            DbSet.Update(person);
        }
    }
}
