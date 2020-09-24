using Games.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Games.Infra.Data.Repository.EventSourcing
{
    public class EventStoreSQLRepository : IEventStoreRepository
    {
        //private readonly EventStoreSqlContext _context;

        public Task<IList<StoredEvent>> All(Guid aggregateId)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Store(StoredEvent theEvent)
        {
            throw new NotImplementedException();
        }
    }
}
