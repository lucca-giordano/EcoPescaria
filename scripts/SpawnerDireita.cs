using Godot;
using System;

public partial class SpawnerDireita : CharacterBody2D
{
	public Vector2 spd = Vector2(100, 0);
	public Vector2 posicaoInicial;

	public override void _Ready()
	{
		posicaoInicial = Position;
	}
	
	public override void _Process(double delta)
	{
// Acesse a posição do objeto
		Vector2 posicao = Position;

		// Atualize a posição do objeto para a direita
		posicao.X += spd;

		// Defina a nova posição do objeto
		Position = posicao;
	}
}
