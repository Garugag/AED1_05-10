using System;
using System.Collections.Generic;
using System.Text;

class Veiculo
	{
		string marca;
		int ano;
		double valor;
		int km;
		
		public void atualizar()
		{
			Console.WriteLine("Em que ano estamos?")
			int I = int.Parse(Console.ReadLine());
			if (ano < I)
          {
            valor = valor - (I - ano) * 2.05;
          }
		}
		public void relatorio()
		{
			Console.WriteLine("O seu relatorio atual é:");
			Console.Write("Marca: ");
			Console.WriteLine(marca);
			Console.Write("O ano do veiculo: ");
			Console.WriteLine(ano);
			Console.Write("O preço do veiculo: ");
			Console.WriteLine(valor);
			Console.Write("Os KMs rodados: ");
			Console.WriteLine(km);
		}
	}