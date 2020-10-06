using System;
using System.Collections.Generic;
using System.Text;

class Vendedor
	{
		double salario = 2134.43.;
		double comissao = 75.43;
		int vendas = 0;

		public void receber_salario()
		{
			Console.WriteLine("Quantos veiculos vendeu?")
			vendas = int.Parse(Console.ReadLine());
			double salario_completo = salario + comissao * vendas;
			Console.WriteLine(salario_completo);
		}
	}