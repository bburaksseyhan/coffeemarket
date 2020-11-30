using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeMarket.Catalog.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        // GET: api/catalog
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Latte", "Americano", "Filtre Coffee", "Mocha" };
        }

        // GET: api/catalog/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "Americano";
        }
    }
}
