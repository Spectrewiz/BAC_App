using System;

namespace BAC_App
{
	public class DataModel
	{
		public DataModel ()
		{
		}

	}

	//Object for Drinks
	public class Drink
	{
		public string name { get; set; }
		public int alcocholContent { get; set; } //multiply by .01 to get percent?
		public string type { get; set; } //type of drink Ex. beer or hard liquor
		public DateTime dateCreated { get; set; }
	}
}

