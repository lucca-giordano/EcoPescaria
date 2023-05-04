using Godot;
using System;

public partial class JogoPrincipal : Node2D
{

	// Declaração das variáveis

	static Texture2D veraoSprite = (Texture2D)GD.Load("res://assets/estacoes/Verao.png");
	static Texture2D outonoSprite = (Texture2D)GD.Load("res://assets/estacoes/Outono.png");
	static Texture2D invernoSprite = (Texture2D)GD.Load("res://assets/estacoes/Inverno.png");
	static Texture2D primaveraSprite = (Texture2D)GD.Load("res://assets/estacoes/Primavera.png");

	private int seasonIndex = 0;
	Texture2D atual;
	public Texture2D[] estacoes = { veraoSprite, outonoSprite, invernoSprite, primaveraSprite };

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		var mouse = ResourceLoader.Load("res://assets/Cursor.png");
		Input.SetCustomMouseCursor(mouse);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		DrawTexture(estacoes[seasonIndex], new Vector2(100, 100));
		GD.Print("O sprite foi impresso");
	}
	
	private void _on_sprite_estacao_draw()
	{

	}
	
}
