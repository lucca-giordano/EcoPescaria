using Godot;
using System;

public partial class SpawnerDireitaNode : Node2D
{
	PackedScene packedScene = ResourceLoader.Load("res://scenes/Spawner-direita.tscn") as PackedScene;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		var customSprite = packedScene.Instantiate();
		AddChild(customSprite);
	}
}
