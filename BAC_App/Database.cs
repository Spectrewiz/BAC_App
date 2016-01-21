using System.Collections.Generic;

#if __IOS__
using Foundation;
#endif

namespace BAC_App
{
	public class Database
	{
		public Database ()
		{
			CreateDatabase ();
		}

		//Creates the database in the given path depending on OS.
		public static string documentsFolder()
		{
			string path;

			#if __ANDROID__
			path = Android.App.Application.Context.GetExternalFilesDir(null).AbsolutePath;
			#endif

			Directory.CreateDirectory (path);
			return path;
		}

		//Creates the database with a table of Drinks
		public static void CreateDatabase()
		{
			var conn = new SQLiteConnection (System.IO.Path.Combine (documentsFolder(), "database.db"));
			conn.CreateTable <Drink> ();
			conn.Close ();
		}

		public static void insertDrink(Drink drink)
		{
			var conn = new SQLiteConnection (System.IO.Path.Combine (documentsFolder(), "database.db"));
			conn.Insert (drink);
			conn.Close ();
		}

		public static void deleteDrink(Drink drink)
		{
			var conn = new SQLiteConnection (System.IO.Path.Combine (documentsFolder(), "database.db"));
			conn.Query<Drink> ("DELETE * FROM Drink WHERE_dateCreated=?", drink.dateCreated);
			conn.Close ();
		}

		public static List<Drink> getDrinks()
		{
			var conn = new SQLiteConnection (System.IO.Path.Combine (documentsFolder(), "database.db"));
			var results = conn.Query<Drink> ("SELECT * FROM Drink");
			conn.Close ();
			return results;
		}
	}
}