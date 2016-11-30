using System.Collections.Generic;
using Newtonsoft.Json;

namespace AppQuest_PixelMaler.Model
{
    public class PixelGrid
    {
		public PixelGrid()
		{
			Field = new List<Pixel>();
		}
		[JsonProperty()]
        public IList<Pixel> Field { get; set; }
    }
}