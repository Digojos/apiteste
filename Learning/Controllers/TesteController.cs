using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Learning.Models;

using Microsoft.Extensions.Logging;

namespace Learning.Controllers
{
    [ApiController]
    [Route("api/teste")]
    public class TesteController : ControllerBase
    {
      
        private static string msg(string name)
        {
            return $"hello world, {name}";
        }

        private static TodoItem GeraObj()
        {
            var obj = new TodoItem();
            obj.Name = "Arroz";
            obj.Description = "Arroz gostosinho";
            obj.Price = "4.20";

            return obj;
        }

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly TodoContext _context;

        public TesteController(ILogger<WeatherForecastController> logger, TodoContext contexto)
        {
            _logger = logger;
            _context = contexto;
        }

        [HttpGet("msg")]
        public string Get(string name)
        {
            var result = msg(name);

            return result;

        }

        [HttpGet("obj")]
        public TodoItem GetObj()
        {
            var obj = GeraObj();
            return obj;
        }
    }
}