using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppQuest_PixelMaler.ViewModel;
using Xamarin.Forms;

namespace AppQuest_PixelMaler.Pages
{
    public partial class HomePage : ContentPage
    {
        private HomePageViewModel _viewModel;
        public HomePage()
        {
            InitializeComponent();
            _viewModel = new HomePageViewModel();
        }

		protected override void OnAppearing()
		{
			base.OnAppearing();
			foreach (var child in Grid.Children)
			{
				var GestureRecognizer = new TapGestureRecognizer();
				GestureRecognizer.Tapped += GestureRecognizer_Tapped;
				child.GestureRecognizers.Add(GestureRecognizer);
			}
				
		}

		void GestureRecognizer_Tapped(object sender, EventArgs e)
		{
			var boxview = (BoxView)sender;
			_viewModel.ChangePixelColor(boxview);
		}

        private void Button_OnClicked(object sender, EventArgs e)
        {
            var button = (Button) sender;
            button.BorderColor = Color.Aqua;
            var color = button.BackgroundColor;
            _viewModel.ChangeColor(color);
        }
    }
}
