using Godot;
using System;

public partial class TelaInicial : Node2D
{
	private void _on_button_iniciar_pressed()
	{
		GetTree().ChangeSceneToFile("res://scenes/JogoPrincipal.tscn");
	}
	
	private void _on_button_creditos_pressed()
	{
		GetTree().ChangeSceneToFile("res://scenes/TelaCreditos.tscn");
	}
}
