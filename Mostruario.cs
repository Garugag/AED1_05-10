using System;
using System.Collections.Generic;
using System.Text;

class Mostruario
{
	private vendedor Representante;

	public List<veiculo> carros;

  public mostruario(vendedor goku)
	{
    Representante = goku;
    carros = new List<veiculo>();
	}
	public void setRepresentante(vendedor goku)
	{
    Representante = goku;
	}
}
