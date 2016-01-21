using System;

namespace BAC_App
{
	public class DataModel
	{
		public DataModel ()
		{
			string letsSeeIfThisWorks = "I hope it does";
		}

	}

	public enum DrinkType {Beer, Liquor, Wine};

	//Object for Drinks
	public class Drink
	{
		public string name { get; set; }
		public int alcocholContent { get; set; } //multiply by .01 to get percent? - or set as a decimal and multiply by 100 when displaying to screen for %
		public DrinkType type { get; set; } //type of drink Ex. beer or hard liquor
		public DateTime dateAdded { get; set; }
	}
}

