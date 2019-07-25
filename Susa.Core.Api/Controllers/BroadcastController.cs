using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Susa.Core.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Susa.Core.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BroadcastController : Controller
    {
        private readonly IBroadcastService _broadcastService;
        public BroadcastController(IBroadcastService broadcast)
        {
            this._broadcastService = broadcast;
        }

        [HttpGet()]
        public async Task<IActionResult> Broadcasts()
        {
            var data = await _broadcastService.BroadcastsAsync();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Broadcasts(int id)
        {
            var data = await _broadcastService.BroadcastByIdAsync(id);
            return Ok(data);
        }
    }
}
