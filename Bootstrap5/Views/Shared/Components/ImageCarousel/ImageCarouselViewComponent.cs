using Bootstrap5.Models;
using Bootstrap5.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Bootstrap5.Views.Shared.Components.ImageCarousel
{
    public class ImageCarouselViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(IEnumerable<IImageCarouselSlide> slides)
        {
            var slideList = slides.ToList();

            var vm = new ImageCarouselView(slideList);

            return View(vm);
        }
    }
}
