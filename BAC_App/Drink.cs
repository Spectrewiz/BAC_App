using System;

namespace BAC_App
{
	public enum DrinkType {Beer, Liquor, Wine};

	/// <summary>
	/// Object for Drinks.  Contains 4 properties: name, alcholContent, type, and dateAdded.
	/// </summary>
	public class Drink
	{
		public Drink(string name, float alcoholContent, DrinkType type, DateTime dateAdded) {
			this.name = name;
			this.alcocholContent = alcoholContent;
			this.type = type;
			this.dateAdded = dateAdded;
		}

		public string name { get; set; }
		public float alcocholContent { get; set; } //multiply by .01 to get percent? - or set as a decimal and multiply by 100 when displaying to screen for %
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

