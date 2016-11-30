using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace AppQuest_PixelMaler.Model
{
    public class Pixel
    {
		[JsonProperty("y")]
		public string YAttribute { get; set; }
		[JsonProperty("x")]
        public string XAttribute { get; set; }
		[JsonProperty("color")]
		public string Color { get; set; }
    }
}
