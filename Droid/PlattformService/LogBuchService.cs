﻿using System;
using Android.Content;
using Android.Content.PM;
using Android.Widget;
using AppQuest_PixelMaler.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(LogBuchService))]
namespace AppQuest_PixelMaler.Droid
{
	public class LogBuchService : ILogBuchService
	{

		public void OpenLogBuch(string task, String solution, string solutionName = "pixels")
		{
			var context = Forms.Context;

			Intent intent = new Intent("ch.appquest.intent.LOG");

			if (context.PackageManager.QueryIntentActivities(intent, PackageInfoFlags.MatchDefaultOnly).Count == 0)
			{
				Toast.MakeText(context, "Logbook App not Installed", ToastLength.Long).Show();
				return;
			}

			// Achtung, je nach App wird etwas anderes eingetragen
			intent.PutExtra("ch.appquest.logmessage", $"{{  \"task\": \"{task}\", \"{solutionName}\": {solution}}}");

			context.StartActivity(intent);
		}
	}
}
