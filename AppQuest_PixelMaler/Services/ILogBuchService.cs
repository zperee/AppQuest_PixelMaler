using System;
namespace AppQuest_PixelMaler
{
	public interface ILogBuchService
	{
		void OpenLogBuch(string task, String solution, string solutionName = "pixels");
	}
}
