using System;
using Microsoft.AspNetCore.Mvc;

namespace DuckBuildAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuackController : ControllerBase
    {
        [HttpGet]
        public bool ShouldIQuack(Guid duckId)
        {
            return true;
        }

        [HttpPost]
        public Quack ScheduleQuack(Quack request)
        {
            // Create a quack
            return new Quack();
        }
    }
}
