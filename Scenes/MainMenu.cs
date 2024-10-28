using Godot;
using System;

public partial class MainMenu : Control
{
	private void OnPlayPressed()
	{
		try 
		{
			int dim1 = int.Parse(GetNode<LineEdit>("MarginContainer/GridContainer/HBoxContainer2/Dimension1").Text);
			int dim2 = int.Parse(GetNode<LineEdit>("MarginContainer/GridContainer/HBoxContainer2/Dimension2").Text);
			int dim3 = int.Parse(GetNode<LineEdit>("MarginContainer/GridContainer/HBoxContainer2/Dimension3").Text);
			int dim4 = int.Parse(GetNode<LineEdit>("MarginContainer/GridContainer/HBoxContainer2/Dimension4").Text);
			int dim5 = int.Parse(GetNode<LineEdit>("MarginContainer/GridContainer/HBoxContainer2/Dimension5").Text);
			int bombs = int.Parse(GetNode<LineEdit>("MarginContainer/GridContainer/HBoxContainer2/Bombs").Text);
			Global.Instance.Dim1 = dim1;
			Global.Instance.Dim2 = dim2;
			Global.Instance.Dim3 = dim3;
			Global.Instance.Dim4 = dim4;
			Global.Instance.Dim5 = dim5;
			GD.Print(dim1 + dim2 +dim3 + dim4 +dim5);

			GetTree().ChangeSceneToFile("res://Scenes/game.tscn");
		}
		catch (System.FormatException e)
		{
			Console.WriteLine(e);
			// this needs to make a popup to user that they did not input a number
		}
		
		
		
	}
	
	private void OnOptionsPressed()
	{

	}

	private void OnExitPressed()
	{
		GetTree().Quit();
	}
}
