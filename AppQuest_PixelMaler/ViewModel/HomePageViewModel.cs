using Xamarin.Forms;

namespace AppQuest_PixelMaler.ViewModel
{
    public class HomePageViewModel
    {
        private Color _color;

        public void ChangePixelColor(BoxView boxView)
        {
            _color = boxView.BackgroundColor;
            boxView.BackgroundColor = _color;
        }

        public void ChangeColor(Color color)
        {
            _color = color;
        }
    }
}