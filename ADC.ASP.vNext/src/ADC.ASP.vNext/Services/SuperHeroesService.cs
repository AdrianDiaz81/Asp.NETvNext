
namespace ADC.ASP.vNext.Services
{
    using System;
    using Models;
    using System.Collections.Generic;

    public class SuperHeroesService : ISuperHeroesService
    {
        public IEnumerable<SuperHeroes> GetAll()
        {
            var result = new List<SuperHeroes>();

            var superHeroes1 = new SuperHeroes { Id = 1, Name = "SpiderMan", Photo = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSUcVuYuDTd_FcMg43ExcMVR0DY9Izjpljvim8hkteAnSZVAb8W" };
            var superHeroes2 = new SuperHeroes { Id = 2, Name = "Thor", Photo = "" };
            var superHeroes3 = new SuperHeroes { Id = 3, Name = "Capitan America", Photo = "" };
            var superHeroes4 = new SuperHeroes { Id = 4, Name = "Hulk", Photo = "" };
            result.Add(superHeroes1);
            result.Add(superHeroes2);
            result.Add(superHeroes3);
            result.Add(superHeroes4);
            return result;
          
        }
    }
}
