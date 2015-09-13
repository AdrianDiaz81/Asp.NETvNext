

namespace ADC.ASP.vNext.ViewComponents
{
    using ADC.ASP.vNext.Services;
    using Microsoft.AspNet.Mvc;
    public class MostPopularNews : ViewComponent
    {
        private INewService _service;

        public MostPopularNews(INewService service)
        {
            _service = service;
        }

        public IViewComponentResult Invoke()
        {
            var mostPopularNews = _service.GetMostPopular();

            return View(mostPopularNews);
        }
    }
}
