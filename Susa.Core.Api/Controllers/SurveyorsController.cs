using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Susa.Core.Entities.Models;
using Susa.Core.Services.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Susa.Core.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveyorsController : Controller
    {
        private readonly ISurveyorService _surveyorService;
        private readonly ILiveSurveyorService _liveSurveyorService;
        public SurveyorsController(ISurveyorService surveyorService, ILiveSurveyorService liveSurveyorService)
        {
            this._surveyorService = surveyorService;
            this._liveSurveyorService = liveSurveyorService;
        }
        // GET: api/values
        [HttpGet]
        public async Task<IEnumerable<Surveyor>> Get()
        {
            return await _surveyorService.SurveyorsAsync();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<Surveyor> Get(int id)
        {
            return await _surveyorService.SurveyorByIdAsync(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        [HttpGet("livesurveyors")]
        public async Task<IEnumerable<Live_Surveyors>> GetAllLive()
        {
            return await _liveSurveyorService.LiveSurveyorsAsync();
        }

        [HttpPost("getlivein")]
        public async Task<IActionResult> GetLiveIn(Live_Surveyors live_Surveyor)
        {
             await _liveSurveyorService.LiveInAsync(live_Surveyor);
            return Ok();
        }

        [HttpPost("getliveout")]
        public async Task<IActionResult> GetLiveOut(Live_Surveyors live_Surveyor)
        {
            await _liveSurveyorService.LiveOutAsync(live_Surveyor);
            return NotFound();
        }
        
    }
}
