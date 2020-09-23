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
    public class GameLendRepository : IGameLendRepository
    {

        protected readonly GamesContext Db;
        protected readonly DbSet<GameLend> DbSet;

        public GameLendRepository(GamesContext context)
        {
            Db = context;
            DbSet = Db.Set<GameLend>();
        }

        public IUnitOfWork UnitOfWork => Db;

        public void Add(GameLend entity)
        {
            DbSet.Add(entity);
        }

        public void Remove(GameLend entity)
        {
            DbSet.Remove(entity);
        }

        public void Update(GameLend entity)
        {
            DbSet.Update(entity);
        }

        public async Task<IEnumerable<GameLend>> GetAll()
        {
            return await DbSet.ToListAsync();
        }

        public async Task<GameLend> GetById(Guid id)
        {
            return await DbSet.FindAsync(id);
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
