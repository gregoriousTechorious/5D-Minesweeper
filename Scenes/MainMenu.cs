using Godot;
using System;

public partial class MainMenu : Control
{
	private void OnPlayPressed()
	{
		GetTree().ChangeSceneToFile("res://Scenes/game.tscn");
	}
	
	private void OnOptionsPressed()
	{

	}

	private void OnExitPressed()
	{
		GetTree().Quit();
	}
}
