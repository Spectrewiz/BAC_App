using System;

namespace BAC_App
{
	public enum Gender {Male, Female}

	public class Profile
	{
		public Profile (int heightFeet, int heightInches, int weight, Gender gender)
		{
			this.gender = gender;
			this.weight = weight;
			this.heightFeet = heightFeet;
			this.heightInches = heightInches;
		}

		public int heightFeet { get; set; }
		public int heightInches { get; set; }
		public int weight { get; set; }
		public Gender gender { get; set; }
	}
}

