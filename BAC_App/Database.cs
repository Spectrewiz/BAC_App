using System;
using System.IO;
using SQLite;

#if __IOS__
using Foundation;
#endif

namespace BAC_App
{
	public class Database
	{
		public Database ()
		{
		}

		public static string documentsFolder()
		{
			string path;

			#if __ANDROID__
			path = Android.App.Application.Context.GetExternalFilesDir(null).AbsoluteFile;
			#endif

			Directory.CreateDirectory (path);
		}

	}
}

