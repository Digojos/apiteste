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
    public class Teste : ControllerBase
    {
      
        private static string msg()
        {
            var teste = "hello world";            
            return teste;
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

        public Teste(ILogger<WeatherForecastController> logger, TodoContext contexto)
        {
            _logger = logger;
            _context = contexto;
        }

        [HttpGet("msg")]
        public string Get()
        {
            var result = msg();

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