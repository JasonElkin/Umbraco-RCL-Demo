using System.Collections.Generic;

namespace Bootstrap5.Models.ViewModels
{
    public class ImageCarouselView
    {
        public ImageCarouselView(IList<IImageCarouselSlide> slides)
        {
            this.Slides = slides;
            this.HasSlides = slides.Count > 0;
            this.HasMultiple = slides.Count > 1;
        }

        public IList<IImageCarouselSlide> Slides { get; set; }

        public bool HasSlides { get; }
        public bool HasMultiple { get; }
    }
}
