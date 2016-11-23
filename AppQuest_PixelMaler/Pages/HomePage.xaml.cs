using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace AppQuest_PixelMaler.Pages
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
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
			// sender = boxview
			var boxview = (BoxView)sender;
			//boxview.BackgroundColor;
		}
	}
}
