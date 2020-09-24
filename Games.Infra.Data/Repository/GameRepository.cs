using Games.Domain.Models;
using Games.Domain.Interfaces.Repositories;
using Games.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using NetDevPack.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Games.Infra.Data.Repository
{
    public class GameRepository : IGameRepository
    {

        protected readonly GamesContext Db;
        protected readonly DbSet<GameModel> DbSet;

        public GameRepository(GamesContext context)
        {
            Db = context;
            DbSet = Db.Set<GameModel>();
        }

        public IUnitOfWork UnitOfWork => Db;

        public void Add(GameModel entity)
        {
            DbSet.Add(entity);
        }

        public void Remove(GameModel entity)
        {
            DbSet.Remove(entity);
        }

        public void Update(GameModel entity)
        {
            DbSet.Update(entity);
        }

        public async Task<IEnumerable<GameModel>> GetAll()
        {
            return await DbSet.ToListAsync();
        }

        public async Task<GameModel> GetById(Guid id)
        {
            return await DbSet.FindAsync(id);
        }

        public void Dispose()
        {
            Db.Dispose();
        }

        public async Task<GameModel> GetByDescription(string description)
        {
            return await DbSet.AsNoTracking().FirstOrDefaultAsync(c => c.Description == description);
        }
    }
}
