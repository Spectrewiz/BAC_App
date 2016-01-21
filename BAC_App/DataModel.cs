using System;
using System.Collections.Generic;

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

	/// <summary>
<<<<<<< HEAD
	/// Object for Drinks.  Contains 4 properties: name, alcholContent, type, and dateAdded.
=======
	/// Object for Drink
>>>>>>> f92de9d38b8ac0c4ba416970a5419b0f5d3264ea
	/// </summary>
	public class Drink
	{
		public string name { get; set; }
		public int alcocholContent { get; set; } //multiply by .01 to get percent? - or set as a decimal and multiply by 100 when displaying to screen for %
		public DrinkType type { get; set; } //type of drink Ex. beer or hard liquor
		public DateTime dateAdded { get; set; }

		/// <summary>
		/// Calculates the BAC of a person with their drink list
		/// </summary>
		/// <returns>The persons BAC</returns>
		public static float calculateBAC(List<Drink> drinks) {
			//TODO: Find good BAC calculation
		}
	}
}

