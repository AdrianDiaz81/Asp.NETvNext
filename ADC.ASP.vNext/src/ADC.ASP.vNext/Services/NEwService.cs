namespace ADC.ASP.vNext.Services
{
    using Models;
    using System.Collections.Generic;
    public class NewsService : INewService
    {
        public IEnumerable<News> GetMostPopular()
        {
            return new News[]
            {
                new News
                {
                    Id = 1,
                    Headline = "ASP.NET 5 Introducción a ViewComponents",
                    Text = "En este post..."
                },
                new News
                {
                    Id = 2,
                    Headline = "ASP.NET 5 Trabajando con el cliente I ",
                    Text = "En este post..."
                },
                new News
                {
                    Id = 3,
                    Headline = "ASP.NET 5 Trabajando con el cliente II",
                    Text = "En este post..."
                }
            };
        }
    }
}
