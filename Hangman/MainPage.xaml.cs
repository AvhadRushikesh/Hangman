using System.ComponentModel;
using System.Diagnostics;

namespace Hangman;

public partial class MainPage : ContentPage, INotifyPropertyChanged
{
	#region Fields
	List<string> words = new List<string>()
	{
		"python",
		"java",
		"javascrip",
		"angular",
		"csharp",
		"maui",
		"php",
		"html",
		"css",
		"fsharp",
		"visualbasic",
		"powerbi",
		"signalr",
		"excel",
		"paint",
		"powerpoint",
		"c",
		"cpp",
		"datastructure",
		"algorithm",
		"word",
		"xaml",
		"mysql",
		"postgresql",
		"sqlserver"
	};
	string answer = "";
	#endregion
	public MainPage()
	{
		InitializeComponent();
		PickWord();
	}
	#region Game Engine
	private void PickWord()
	{
		answer = words[new Random().Next(0, words.Count)];
		Debug.WriteLine(answer);
	}
	#endregion
}

