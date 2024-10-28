using Godot;
using System;

public partial class Global : Node
{

    public static Global Instance {get; set;}
    private int dim1;
    private int dim2;
    private int dim3;
    private int dim4;
    private int dim5;
    private int bombs;

    public int Dim1 { get => dim1; set => dim1 = value; }
    public int Dim2 { get => dim2; set => dim2 = value; }
    public int Dim3 { get => dim3; set => dim3 = value; }
    public int Dim4 { get => dim4; set => dim4 = value; }
    public int Dim5 { get => dim5; set => dim5 = value; }
    public int Bombs { get => bombs; set => bombs = value; }


    public override void _Ready()
    {
        Instance = this;
    }

}
