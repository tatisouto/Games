﻿using Games.Domain.Entities;
using Games.Domain.Interfaces.Repositories;
using Games.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using NetDevPack.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Games.Infra.Data.Repository
{
    public class GameRepository : IRepositoryBase<Game>
    {

        protected readonly GamesContext Db;
        protected readonly DbSet<Game> DbSet;

        public GameRepository(GamesContext context)
        {
            Db = context;
            DbSet = Db.Set<Game>();
        }

        public IUnitOfWork UnitOfWork => Db;

        public void Add(Game entity)
        {
            DbSet.Add(entity);
        }

        public void Remove(Game entity)
        {
            DbSet.Remove(entity);
        }

        public void Update(Game entity)
        {
            DbSet.Update(entity);
        }

        public async Task<IEnumerable<Game>> GetAll()
        {
            return await DbSet.ToListAsync();
        }

        public async Task<Game> GetById(Guid id)
        {
            return await DbSet.FindAsync(id);
        }

      
    }
}