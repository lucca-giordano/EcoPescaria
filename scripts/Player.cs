using Godot;
using System;

public partial class Player : CharacterBody2D
{
	public const float Speed = 300.0f;
	public const float JumpVelocity = -400.0f;
	private AnimatedSprite2D AnimatedSprite;

	// Get the gravity from the project settings to be synced with RigidBody nodes.
	public float gravity = ProjectSettings.GetSetting("physics/2d/default_gravity").AsSingle();

	private void _on_ready()
	{
		AnimatedSprite = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
		AnimatedSprite.Play("idle");
		// fazer a vara não aparecer ao iniciar o jogo
		GetNode<Sprite2D>("FishingRod").Visible = false;
	}

	public override void _PhysicsProcess(double delta)
	{
		Vector2 velocity = Velocity;

		// Add the gravity.
		if (!IsOnFloor())
		{
			velocity.Y += gravity * (float)delta;
			AnimatedSprite.Play("jump");
		}
		
		// Handle Jump.
		if (Input.IsActionJustPressed("ui_accept") && IsOnFloor())
		{
			velocity.Y = JumpVelocity;
		}

		// Get the input direction and handle the movement/deceleration.
		// As good practice, you should replace UI actions with custom gameplay actions.
		Vector2 direction = Input.GetVector("A", "D", "W", "S");
		if (direction != Vector2.Zero)
		{
			velocity.X = direction.X * Speed;
			AnimatedSprite.Play("run");
		}
		
		else
		{
			velocity.X = Mathf.MoveToward(Velocity.X, 0, Speed);
			AnimatedSprite.Play("idle");
		}

		//inverter o sprite de acordo com a direção
		if (direction.X < 0)
		{
			AnimatedSprite.FlipH = true;
		}
		
		else if (direction.X > 0)
		{
			AnimatedSprite.FlipH = false;
		}

		Velocity = velocity;
		MoveAndSlide();
	}


	private void _on_area_de_pesca_body_entered(Node2D body)
	{
		GetNode<Sprite2D>("FishingRod").Visible = true;
	}


	private void _on_area_de_pesca_body_exited(Node2D body)
	{
		GetNode<Sprite2D>("FishingRod").Visible = false;
	}
	
	private void _on_fishing_rod_ready()
	{
		GetNode<Sprite2D>("FishingRod").Visible = false;
	}

}
