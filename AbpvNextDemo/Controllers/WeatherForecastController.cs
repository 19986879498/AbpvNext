using AbpvNext.Application.My;
using AbpvNext.Application.User.Dto;
using AbpvNext.Domain.UserInfo;
using AbpvNextEntityFrameworkCore;
using AbpvNextFilters.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbpvNextDemo.Controllers
{
    [ServiceFilter(typeof(AbpvNextExceptionFilterAttribute))]
    [TypeFilter(typeof(AbpvNextExceptionFilterAttribute))]
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly AbpvNextDbContext dbContext;
        private readonly IMyService myService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,AbpvNextDbContext dbContext,IMyService myService)
        {
            _logger = logger;
            this.dbContext = dbContext;
            this.myService = myService;
        }

        [HttpGet,Route("Get")]
        public IEnumerable<WeatherForecast> Get()
        {
            //throw new Exception("应用程序出现未知错误");
            var context = this.dbContext;
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
        [HttpGet, Route("GetUsers")]
        public Users GetUsers()
        {
            return myService.GetUsers();
        }

        [HttpGet, Route("AsyncUserDto")]
        public IActionResult AsyncUserDto()
        {
            UserDto myuser = this.myService.GetUserDtoAsync().Result;
            return new JsonResult(myuser);
        }
        
    }
}
