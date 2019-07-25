using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Susa.Core.Entities.Models;
using Susa.Core.Repo;

namespace Susa.Core.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class BroadcastService : IBroadcastService
    {
        private readonly IAsyncRepository<Broadcast> _broadcastRepository;
        public BroadcastService(IAsyncRepository<Broadcast> asyncRepository)
        {
            this._broadcastRepository = asyncRepository;
        }

        public async Task<IEnumerable<Broadcast>> BroadcastsAsync()
        {
            return await _broadcastRepository.ListAllAsync();
        }

        public async Task<Broadcast> BroadcastByIdAsync(int id)
        {
            return await _broadcastRepository.GetByIdAsync(id);
        }
        
    }
}
