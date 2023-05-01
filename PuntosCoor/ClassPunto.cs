using System;

class Punto	
{
	//Propiedades
	private int x, y;

	private static int contadorDeObjetos = 0;

	//Metodos
	public Punto()
	{
		//Console.WriteLine("Este es el constructor por defecto");
		this.x = 0;
		this.y = 0;
		contadorDeObjetos++;
	}
	public Punto(int x, int y)
	{
        //Console.WriteLine($"Coordenada X: {x} Coordenada Y: {y}");
        this.x = x;
		this.y = y;
		contadorDeObjetos++;
    }

	public double DistanciaHasta(Punto other)
	{
		int xDif = this.x - other.x;

		int yDif = this.y - other.y;	

		double distanciaPuntos = Math.Sqrt(Math.Pow(xDif, 2)+Math.Pow(yDif, 2));

		return distanciaPuntos;

	}

	public static int ContadorDeObjetos()
	{
		
		return contadorDeObjetos;
	
	}
}


