using Godot;
using System;

public partial class game : Node
{
	public int pontos = 0;
	public int pontosLim = 500;

	public int extintos = 0;
	public int extintosLim = 3;

	public string peixe;

	public string estacao;

	public void pescar(){

		var random = new RandomNumberGenerator();
		var pesca = random.RandiRange(0, 100);

		if(pesca <= 20){
			peixe = "Atum";
		}
		else if(pesca <= 40){
			peixe = "Salmao";
		}
		else if(pesca <= 60){
			peixe = "Tainha";
		}
		else if(pesca <= 80){
			peixe = "Tilapia";
		}
		else if(pesca <= 85){
			peixe = "Dourado";
		}
		else if(pesca <= 100){
			peixe = "Temporada";
		}

		GD.Print("pescou! Você pegou o: " + peixe);

	}
	
	public void pegar(){
		pontos += 10;
		GD.Print("pegou!");
	}

	public void soltar(){
		GD.Print("soltou!");
	}
}
