using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Susa.Core.Entities.Models;

namespace Susa.Core.Services
{
    public interface IBroadcastService
    {
        Task<IEnumerable<Broadcast>> BroadcastsAsync();
        
        Task<Broadcast> BroadcastByIdAsync(int id);
    }
}
