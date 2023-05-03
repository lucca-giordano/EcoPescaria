using Godot;
using System;

public partial class JogoPrincipal : Node2D
{

	// Declaração das variáveis
	private Texture[] textures;
	private int seasonIndex = 0;
	Texture atual;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{

		// Carrega as sprites das estações
		Texture veraoSprite = (Texture)GD.Load("res://assets/estacoes/Verao.png");
		Texture outonoSprite = (Texture)GD.Load("res://assets/estacoes/Outono.png");
		Texture invernoSprite = (Texture)GD.Load("res://assets/estacoes/Inverno.png");
		Texture primaveraSprite = (Texture)GD.Load("res://assets/estacoes/Primavera.png");

		// Adiciona as sprites das estações no array
		estacoes = new Texture[] { veraoSprite, outonoSprite, invernoSprite, primaveraSprite };

		var mouse = ResourceLoader.Load("res://assets/Cursor.png");
		Input.SetCustomMouseCursor(mouse);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	
	private void _on_character_body_2d_draw()
	{
		//Desenha o sprite da estação
		DrawTexture(estacoes[seasonIndex], new Vector2(0, 0));
		
	}
}
