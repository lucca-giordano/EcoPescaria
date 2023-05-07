using Godot;
using System;

public partial class SpawnerDireita : CharacterBody2D
{
	public float spd = 100.0f;
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
		posicao.X += spd * (float)delta;

		// Defina a nova posição do objeto
		Position = posicao;
	}
}
