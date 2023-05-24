using Godot;
using System;

public partial class JogoPrincipal : Node2D
{
	public Sprite2D rod;
	public CharacterBody2D PLayer;
	
	public override void _Ready()
	{
		rod = GetNode<Sprite2D>("Player/FishingRod");
		PLayer = GetNode<CharacterBody2D>("Player");

		rod.Hide();
	}
	
	public override void _Process(double delta)
	{
	}


	private void _on_area_de_pesca_body_entered(Node2D body)
	{
		if(body == PLayer){
			rod.Show();
		}
	}


	private void _on_area_de_pesca_body_exited(Node2D body)
	{
		if(body == PLayer){
			rod.Hide();
		}
	}

}


