using Godot;
using System;

public partial class UI : Node2D
{
	public Sprite2D Atum, Salmao, Tainha, Tilapia, Dourado, Leao, Palhaco, Lanterna, Cascudo;
	public Sprite2D AtumInterr, SalmaoInterr, TainhaInterr, TilapiaInterr, DouradoInterr, LeaoInterr, PalhacoInterr, LanternaInterr, CascudoInterr;
	
	game game = new game();

	public override void _Ready()
	{
		Atum = GetNode<Sprite2D>("Peixes/Atum");
		AtumInterr = GetNode<Sprite2D>("Interrogacoes/InterrogacaoAtum");

		Salmao = GetNode<Sprite2D>("Peixes/Salmao");
		SalmaoInterr = GetNode<Sprite2D>("Interrogacoes/InterrogacaoSalmao");

		Tainha = GetNode<Sprite2D>("Peixes/Tainha");
		TainhaInterr = GetNode<Sprite2D>("Interrogacoes/InterrogacaoTainha");

		Tilapia = GetNode<Sprite2D>("Peixes/Tilapia");
		TilapiaInterr = GetNode<Sprite2D>("Interrogacoes/InterrogacaoTilapia");

		Dourado = GetNode<Sprite2D>("Peixes/Dourado");
		DouradoInterr = GetNode<Sprite2D>("Interrogacoes/InterrogacaoDourado");

		Leao = GetNode<Sprite2D>("Peixes/PeixeLeao");
		LeaoInterr = GetNode<Sprite2D>("Interrogacoes/InterrogacaoLeao");

		Palhaco = GetNode<Sprite2D>("Peixes/PeixePalhaco");
		PalhacoInterr = GetNode<Sprite2D>("Interrogacoes/InterrogacaoPalhaco");

		Lanterna = GetNode<Sprite2D>("Peixes/PeixeLanterna");
		LanternaInterr = GetNode<Sprite2D>("Interrogacoes/InterrogacaoLanterna");

		Cascudo = GetNode<Sprite2D>("Peixes/Cascudo");
		CascudoInterr = GetNode<Sprite2D>("Interrogacoes/InterrogacaoCascudo");
		
		Atum.Hide();
		Salmao.Hide();
		Tainha.Hide();
		Tilapia.Hide();
		Dourado.Hide();
		Leao.Hide();
		Palhaco.Hide();
		Lanterna.Hide();
		Cascudo.Hide();

	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if(game.descobertas[0] == "Atum"){
			Atum.Show();
			AtumInterr.Hide();
		}
		if(game.descobertas[1] == "Salmao"){
			Salmao.Show();
			SalmaoInterr.Hide();
		}
		if(game.descobertas[2] == "Tainha"){
			Tainha.Show();
			TainhaInterr.Hide();
		}
		if(game.descobertas[3] == "Tilapia"){
			Tilapia.Show();
			TilapiaInterr.Hide();
		}
		if(game.descobertas[4] == "Dourado"){
			Dourado.Show();
			DouradoInterr.Hide();
		}
		if(game.descobertas[5] == "Leao"){
			Leao.Show();
			LeaoInterr.Hide();
		}
		if(game.descobertas[6] == "Palhaco"){
			Palhaco.Show();
			PalhacoInterr.Hide();
		}
		if(game.descobertas[7] == "Lanterna"){
			Lanterna.Show();
			LanternaInterr.Hide();
		}
		if(game.descobertas[8] == "Cascudo"){
			Cascudo.Show();
			CascudoInterr.Hide();
		}
	}
}
