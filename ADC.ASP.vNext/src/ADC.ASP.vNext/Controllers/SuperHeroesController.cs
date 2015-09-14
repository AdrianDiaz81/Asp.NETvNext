namespace ADC.ASP.vNext.Controllers
{
    using System.Collections.Generic;
    using Microsoft.AspNet.Mvc;
    using Services;
    using Models;
    using System.Linq;

    [Route("api/[controller]")]
    public class SuperHeroesController : Controller
    {
        public ISuperHeroesService service;
        public SuperHeroesController(ISuperHeroesService svc)
        {
            service = svc;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<SuperHeroes> Get()
        {
            return service.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public SuperHeroes Get(int id)
        {
            var result = service.GetAll();

            return result.Where(x => x.Id.Equals(id)).First() ;
        }

        
    }
}
