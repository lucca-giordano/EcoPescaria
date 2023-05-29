using Godot;
using System;

public partial class JogoPrincipal : Node2D
{
	//classes do jogo
	game game = new game();

	//variaveis de elementos do jogo
	public Sprite2D rod, rodF, verao, outono, inverno, primavera;
	public CharacterBody2D Player;
	public Node2D UI;
	public Label pontos, extintos;
	public AnimatedSprite2D pesca;

	public Sprite2D Atum, Salmao, Tainha, Tilapia, Dourado, Leao, Palhaco, Lanterna, Cascudo;
	public Sprite2D AtumInterr, SalmaoInterr, TainhaInterr, TilapiaInterr, DouradoInterr, LeaoInterr, PalhacoInterr, LanternaInterr, CascudoInterr;

	//variaveis de estado do jogo
	public bool pescando, pescado;
	public int estacao;
	
	//funções do jogo
	public override void _Ready()
	{
		rod = GetNode<Sprite2D>("Player/FishingRod");
		rodF = GetNode<Sprite2D>("Player/FishingRodFish");
		pesca = GetNode<AnimatedSprite2D>("Player/PeixesNaVara");
		Player = GetNode<CharacterBody2D>("Player");
		UI = GetNode<Node2D>("UI");

		pontos = GetNode<Label>("UI/LabelPontos");
		extintos = GetNode<Label>("UI/LabelExtintos");

		verao = GetNode<Sprite2D>("UI/Estacoes/Verao");
		outono = GetNode<Sprite2D>("UI/Estacoes/Outono");
		inverno = GetNode<Sprite2D>("UI/Estacoes/Inverno");
		primavera = GetNode<Sprite2D>("UI/Estacoes/Primavera");

		Atum = GetNode<Sprite2D>("UI/Peixes/Atum");
		AtumInterr = GetNode<Sprite2D>("UI/Interrogacoes/InterrogacaoAtum");

		Salmao = GetNode<Sprite2D>("UI/Peixes/Salmao");
		SalmaoInterr = GetNode<Sprite2D>("UI/Interrogacoes/InterrogacaoSalmao");

		Tainha = GetNode<Sprite2D>("UI/Peixes/Tainha");
		TainhaInterr = GetNode<Sprite2D>("UI/Interrogacoes/InterrogacaoTainha");

		Tilapia = GetNode<Sprite2D>("UI/Peixes/Tilapia");
		TilapiaInterr = GetNode<Sprite2D>("UI/Interrogacoes/InterrogacaoTilapia");

		Dourado = GetNode<Sprite2D>("UI/Peixes/Dourado");
		DouradoInterr = GetNode<Sprite2D>("UI/Interrogacoes/InterrogacaoDourado");

		Leao = GetNode<Sprite2D>("UI/Peixes/PeixeLeao");
		LeaoInterr = GetNode<Sprite2D>("UI/Interrogacoes/InterrogacaoLeao");

		Palhaco = GetNode<Sprite2D>("UI/Peixes/PeixePalhaco");
		PalhacoInterr = GetNode<Sprite2D>("UI/Interrogacoes/InterrogacaoPalhaco");

		Lanterna = GetNode<Sprite2D>("UI/Peixes/PeixeLanterna");
		LanternaInterr = GetNode<Sprite2D>("UI/Interrogacoes/InterrogacaoLanterna");

		Cascudo = GetNode<Sprite2D>("UI/Peixes/Cascudo");
		CascudoInterr = GetNode<Sprite2D>("UI/Interrogacoes/InterrogacaoCascudo");

		pescando = false;
		pescado = false;
		estacao = 0;

		UI.Hide();
		rod.Hide();
		rodF.Hide();
		verao.Hide();
		outono.Hide();
		inverno.Hide();
		primavera.Hide();

		pesca.Play("Idle");

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
				rod.Hide();
				rodF.Show();
				game.pescar();

				if(game.peixe == "Atum"){
					pesca.Play("Atum");
				}
				if(game.peixe == "Salmao"){
					pesca.Play("Salmao");
				}
				if(game.peixe == "Tainha"){
					pesca.Play("Tainha");
				}
				if(game.peixe == "Tilapia"){
					pesca.Play("Tilapia");
				}
				if(game.peixe == "Dourado"){
					pesca.Play("Dourado");
				}
				if(game.peixe == "Leao"){
					pesca.Play("Leao");
				}
				if(game.peixe == "Palhaco"){
					pesca.Play("Palhaco");
				}
				if(game.peixe == "Lanterna"){
					pesca.Play("Lanterna");
				}
				if(game.peixe == "Cascudo"){
					pesca.Play("Cascudo");
				}
			}
		}

		if(pescado){
			if(Input.IsActionJustPressed("pegar")){
				game.pegar();
				rod.Show();
				rodF.Hide();
				pesca.Play("Idle");
				pescado = false;
			}
			else if(Input.IsActionJustPressed("soltar")){
				game.soltar();
				rod.Show();
				rodF.Hide();
				pesca.Play("Idle");
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
			rodF.Hide();
			pesca.Play("Idle");
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
		//GD.Print("Tempo recomeçou!");
		estacao++;
		if(estacao == 4){
			estacao = 0;
		}
	}

}
