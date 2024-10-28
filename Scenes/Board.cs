using Godot;
using System;

public partial class Board : Node3D
{
	HyperCube[,,,,] board;	
	int totalSquares;
	int bombs;
	int xLength;
	int yLength;
	int zLength;
	int wLength;
	int vLength;

    public int TotalSquares { get => totalSquares; set => totalSquares = value; }
    public int Bombs { get => bombs; set => bombs = value; }
    public int XLength { get => xLength; set => xLength = value; }
    public int YLength { get => yLength; set => yLength = value; }
    public int ZLength { get => zLength; set => zLength = value; }
    public int WLength { get => wLength; set => wLength = value; }
    public int VLength { get => vLength; set => vLength = value; }

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void PrintBoard()
	{
		for (int x = 0; x < board.GetLength(0); x++) {
			for (int y = 0; y < board.GetLength(1); y++) {
				for (int z = 0; z < board.GetLength(2); z++) {
					for (int w = 0; w < board.GetLength(3); w++) {
						for (int v = 0; v < board.GetLength(4); v++) {
							GD.Print(board[x, y, z, w, v]);
						}
					}
				}
			}
		}
	}

	public void InitializeBoard() 
	{
		XLength = Global.Instance.Dim1;
		YLength = Global.Instance.Dim2;
		ZLength = Global.Instance.Dim3;
		WLength = Global.Instance.Dim4;
		VLength = Global.Instance.Dim5;
		TotalSquares = XLength+YLength+ZLength+WLength+VLength;
		Bombs = Global.Instance.Bombs;
		
		board = new HyperCube[XLength, YLength, ZLength, WLength, VLength];
	}

	public bool IsValidPos(int[] position)
	{
		int x = position[0];
		int y = position[1];
		int z = position[2];
		int w = position[3];
		int v = position[4];

		if (x < 0 || y < 0 || z < 0 || w < 0 || v < 0 ||
			x > XLength-1 || y > YLength-1 || z > ZLength-1 || w > WLength-1 || v > VLength-1) {
				return false;
			}
		return true;
	}

	public void generateBombs()
	{
		Random random = new Random();

		int bombsRemaining = Bombs;
		int totalSquaresRemaining = TotalSquares;

		for (int x = 0; x < board.GetLength(0); x++) {
			for (int y = 0; y < board.GetLength(1); y++) {
				for (int z = 0; z < board.GetLength(2); z++) {
					for (int w = 0; w < board.GetLength(3); w++) {
						for (int v = 0; v < board.GetLength(4); v++) {
							bool tempBomb = false;
							int tempNum = random.Next(0, totalSquaresRemaining-1);
							if (tempNum < bombsRemaining) {
								tempBomb = true;
								bombsRemaining--;
							}
							totalSquaresRemaining--;


							//TO DO MUST FIND OUT A WAY TO INSTANTIATE THE HYPERCUBE INTO HERE AND ALSO SAYING IF IT HAS A BOMB OR NOT
							//board[x,y,z,w,v] = ;
						}
					}
				}
			}
		}
	}
}
