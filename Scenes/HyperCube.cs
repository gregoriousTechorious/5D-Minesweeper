using Godot;
using System;

public partial class HyperCube : Node3D
{

	int[,] adjacentPositions = new int[243, 5];
	bool isBomb;
	int[] position = new int[5];


	public HyperCube(int[] pos)
	{
		this.position = pos;
		GD.Print("new hypercube");
	}

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
