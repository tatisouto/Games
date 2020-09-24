using Games.Domain.Models;
using Games.Domain.Interfaces.Repositories;
using Games.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using NetDevPack.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Games.Infra.Data.Repository
{
    public class GameLendRepository : IGameLendRepository
    {

        protected readonly GamesContext Db;
        protected readonly DbSet<GameLendModel> DbSet;

        public GameLendRepository(GamesContext context)
        {
            Db = context;
            DbSet = Db.Set<GameLendModel>();
        }

        public IUnitOfWork UnitOfWork => Db;

        public void Add(GameLendModel entity)
        {
            DbSet.Add(entity);
        }

        public void Remove(GameLendModel entity)
        {
            DbSet.Remove(entity);
        }

        public void Update(GameLendModel entity)
        {
            DbSet.Update(entity);
        }

        public async Task<IEnumerable<GameLendModel>> GetAll()
        {
            return await DbSet.ToListAsync();
        }

        public async Task<GameLendModel> GetById(Guid id)
        {
            return await DbSet.FindAsync(id);
        }

        public async Task<GameLendModel> GetByGameId(Guid idGame)
        {
            return await DbSet.AsNoTracking().FirstOrDefaultAsync(c => c.IdGame == idGame);
        }

        public bool GameIsAvailable(Guid idGame)
        {
            return DbSet.AsNoTracking().Any(c => c.IdGame == idGame && c.ReturnedOn == null);

        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
