using Godot;
using System;

public partial class JogoPrincipal : Node2D
{
	//classes do jogo
	game game = new game();

	//variaveis de elementos do jogo
	public Sprite2D rod, verao, outono, inverno, primavera;
	public CharacterBody2D Player;
	public Node2D UI;
	public Label pontos, extintos;

	//variaveis de estado do jogo
	public bool pescando, pescado;
	public int estacao;
	
	//funções do jogo
	public override void _Ready()
	{
		rod = GetNode<Sprite2D>("Player/FishingRod");
		Player = GetNode<CharacterBody2D>("Player");
		UI = GetNode<Node2D>("UI");

		pontos = GetNode<Label>("UI/LabelPontos");
		extintos = GetNode<Label>("UI/LabelExtintos");

		verao = GetNode<Sprite2D>("UI/Estacoes/Verao");
		outono = GetNode<Sprite2D>("UI/Estacoes/Outono");
		inverno = GetNode<Sprite2D>("UI/Estacoes/Inverno");
		primavera = GetNode<Sprite2D>("UI/Estacoes/Primavera");

		pescando = false;
		pescado = false;
		estacao = 0;

		UI.Hide();
		rod.Hide();
		verao.Hide();
		outono.Hide();
		inverno.Hide();
		primavera.Hide();

		GD.Print("DEBUG:\n Rod = " + rod + "\n PLayer = " + Player + "\n UI = " + UI + "\n pontos = " + pontos + "\n extintos = " + extintos + "\n verao = " + verao + "\n outono = " + outono + "\n inverno = " + inverno + "\n primavera = " + primavera);


	}
	
	public override void _Process(double delta)
	{

		//atualiza os pontos e extintos
		pontos.Text = "PONTOS: " + game.pontos.ToString();
		extintos.Text = "EXTINTOS: " + game.extintos.ToString() + "/2";

		if(pescando && !pescado){
			if(Input.IsActionJustPressed("pescar")){
				pescado = true;
				game.pescar();
			}
		}

		if(pescado){
			if(Input.IsActionJustPressed("pegar")){
				game.pegar();
				pescado = false;
			}
			else if(Input.IsActionJustPressed("soltar")){
				game.soltar();
				pescado = false;
			}
		}


		if(estacao == 0){
			game.estacao = "verao";

			verao.Show();
			outono.Hide();
			inverno.Hide();
			primavera.Hide();
		}
		else if(estacao == 1){
			game.estacao = "outono";

			verao.Hide();
			outono.Show();
			inverno.Hide();
			primavera.Hide();
		}
		else if(estacao == 2){
			game.estacao = "inverno";

			verao.Hide();
			outono.Hide();
			inverno.Show();
			primavera.Hide();
		}
		else if(estacao == 3){
			game.estacao = "primavera";

			verao.Hide();
			outono.Hide();
			inverno.Hide();
			primavera.Show();
		}

	}

	//funcoes da area de pesca
	private void _on_area_de_pesca_body_entered(Node2D body)
	{
		if(body == Player){
			pescando = true;
			rod.Show();
			//GD.Print("ENTROU:\n Body = " + body + "\n PLayer = " + Player);
		}
	}

	private void _on_area_de_pesca_body_exited(Node2D body)
	{
		if(body == Player){
			pescando = false;
			rod.Hide();
			//GD.Print("SAIU:\n Body = " + body + "\n PLayer = " + Player);

			if(pescado){
				pescado = false;
				GD.Print("Perdeu o peixe!");
			}
		}
	}

	//funcoes da area da casa
	private void _on_area_da_casa_body_entered(Node2D body)
	{
		if(body == Player){
			UI.Show();
		}
	}

	private void _on_area_da_casa_body_exited(Node2D body)
	{		
		if(body == Player){
			UI.Hide();
		}
	}

	private void _on_timer_timeout()
	{
		GD.Print("Tempo recomeçou!");
		estacao++;
		if(estacao == 4){
			estacao = 0;
		}
	}

}
