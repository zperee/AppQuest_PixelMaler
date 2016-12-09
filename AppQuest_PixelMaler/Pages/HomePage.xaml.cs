using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Newtonsoft.Json;
using AppQuest_PixelMaler.Model;

namespace AppQuest_PixelMaler.Pages
{
    public partial class HomePage : ContentPage
    {
		private Color _color;
        public HomePage()
        {
			InitializeComponent();
			_color = Color.White;
        }

		protected override void OnAppearing()
		{
			base.OnAppearing();
			foreach (var child in grid.Children)
			{
				var GestureRecognizer = new TapGestureRecognizer();
				GestureRecognizer.Tapped += GestureRecognizer_Tapped;
				child.GestureRecognizers.Add(GestureRecognizer);
			}
			var width = App.ScreenWidth / 13.0 - 4;

			foreach (var column in grid.ColumnDefinitions)
			{
				column.Width = new GridLength(width);
			}

			foreach (var row in grid.RowDefinitions)
			{
				row.Height = new GridLength(width);
			}
		}

		void GestureRecognizer_Tapped(object sender, EventArgs e)
		{
			var boxview = (BoxView)sender;
			boxview.BackgroundColor = _color;
		}

		private void Button_OnClicked(object sender, EventArgs e)
		{
			var button = (Button)sender;
			_color = button.BackgroundColor;
		}

		void OnClear_Clicked(object sender, System.EventArgs e)
		{
			foreach (var cell in grid.Children)
			{
				var boxView = (BoxView)cell;
				boxView.BackgroundColor = Color.White;
			}
		}

		void OnBackground_Clicked(object sender, System.EventArgs e)
		{
			foreach (var cell in grid.Children)
			{
				var boxView = (BoxView)cell;
				boxView.BackgroundColor = _color;
			}
		}

		void OnSendServer_Clicked(object sender, System.EventArgs e)
		{
			var list = new List<SubmitObject>();
			foreach (var cell in grid.Children.Where(cell => cell.BackgroundColor != Color.White))
			{
				int red = (int)(cell.BackgroundColor.R * 255);
				int green = (int)(cell.BackgroundColor.G * 255);
				int blue = (int)(cell.BackgroundColor.B * 255);
				int alpha = (int)(cell.BackgroundColor.A * 255);

			    int x = Grid.GetColumn(cell);
			    int y = Grid.GetRow(cell);

				var pixel = new SubmitObject
				{
					XAttribute = x.ToString(),
					YAttribute = y.ToString(),
					Color = string.Format("#{0:X2}{1:X2}{2:X2}{3:X2}", red, green, blue, alpha)
				};
				list.Add(pixel);
			}

			string result = JsonConvert.SerializeObject(list);
			var logBuch = DependencyService.Get<ILogBuchService>();

			logBuch.OpenLogBuch("Pixelmaler", result);
		}
	}
}
