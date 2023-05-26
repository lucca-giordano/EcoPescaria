using Godot;
using System;

public partial class BG : ParallaxBackground
{
	game game = new game();
	
	public Sprite2D Verao, Outono, Inverno, Primavera;
	
	public override void _Ready()
	{
		Verao = GetNode<Sprite2D>("BgVerao");
		Outono = GetNode<Sprite2D>("BgOutono");
		Inverno = GetNode<Sprite2D>("BgInverno");
		Primavera = GetNode<Sprite2D>("BgPrimavera");

		Verao.Hide();
		Outono.Hide();
		Inverno.Hide();
		Primavera.Hide();

	}

	public override void _Process(double delta)
	{
		
		if(game.estacao == "verao"){
			Verao.Show();
			Outono.Hide();
			Inverno.Hide();
			Primavera.Hide();
		}
		else if(game.estacao == "outono"){
			Verao.Hide();
			Outono.Show();
			Inverno.Hide();
			Primavera.Hide();
		}
		else if(game.estacao == "inverno"){
			Verao.Hide();
			Outono.Hide();
			Inverno.Show();
			Primavera.Hide();
		}
		else if(game.estacao == "primavera"){
			Verao.Hide();
			Outono.Hide();
			Inverno.Hide();
			Primavera.Show();
		}
		
	}
}
