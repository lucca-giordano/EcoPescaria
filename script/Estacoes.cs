using Godot;
using System;

public partial class Estacoes : Sprite2D
{
	private Texture[] textures;
	private float seasonIndex = 0;
	Texture[] estacoes;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		// Carrega as sprites das estações
		Texture veraoSprite = (Texture)GD.Load("res://assets/estacoes/Verao.png");
		Texture outonoSprite = (Texture)GD.Load("res://assets/estacoes/Outono.png");
		Texture invernoSprite = (Texture)GD.Load("res://assets/estacoes/Inverno.png");
		Texture primaveraSprite = (Texture)GD.Load("res://assets/estacoes/Primavera.png");

		// Cria um array com as sprites das estações
		Texture[] estacoes = { veraoSprite, outonoSprite, invernoSprite, primaveraSprite };

	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

}
