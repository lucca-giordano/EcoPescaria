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
	public Node2D atual;
	public Texture2D[] estacoes = { veraoSprite, outonoSprite, invernoSprite, primaveraSprite };

	public static Node2D verao, outono, inverno, primavera;
	public Node2D[] estacoesNode = { verao, outono, inverno, primavera };

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		var mouse = ResourceLoader.Load("res://assets/Cursor.png");
		Input.SetCustomMouseCursor(mouse);

		verao = GetNode<Node2D>("Verao");
		outono = GetNode<Node2D>("Outono");
		inverno = GetNode<Node2D>("Inverno");
		primavera = GetNode<Node2D>("Primavera");

		// torna a visibilidade de todas por padrão falsa
		verao.Visible = false;
		outono.Visible = false;
		inverno.Visible = false;
		primavera.Visible = false;

	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		// atualiza a estação atual, deixando uma visivel depois a outra
		atual = estacoesNode[seasonIndex];
		atual.Visible = true;



	}
	
	private void _on_sprite_estacao_draw()
	{

	}
	
}
