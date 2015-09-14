

namespace ADC.ASP.vNext.Services
{
    using Models;
    using System.Collections.Generic;

    public interface ISuperHeroesService
    {
        IEnumerable<SuperHeroes> GetAll();
    }
}
