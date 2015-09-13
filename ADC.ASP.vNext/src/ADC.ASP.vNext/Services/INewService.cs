

namespace ADC.ASP.vNext.Services
{
    using Models;
    using System.Collections.Generic;
    public interface INewService

        {
            IEnumerable<News> GetMostPopular();
        }
    
}
