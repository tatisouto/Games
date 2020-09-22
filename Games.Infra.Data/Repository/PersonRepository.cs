using Games.Domain.Entities;
using Games.Domain.Interfaces.Repositories;
using Games.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using NetDevPack.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Games.Infra.Data.Repository
{
    public class PersonRepository : IRepositoryBase<Person>
    {

        protected readonly GamesContext Db;
        protected readonly DbSet<Person> DbSet;

        public PersonRepository(GamesContext context)
        {
            Db = context;
            DbSet = Db.Set<Person>();
        }

        public IUnitOfWork UnitOfWork => Db;

        public void Add(Person person)
        {
            DbSet.Add(person);
        }

        public async Task<IEnumerable<Person>> GetAll()
        {
            return await DbSet.ToListAsync();
        }

        public async Task<Person> GetById(Guid id)
        {
            return await DbSet.FindAsync(id);
        }

        public void Remove(Person person)
        {
            DbSet.Remove(person);
        }

        public void Update(Person person)
        {
            DbSet.Update(person);
        }
    }
}
