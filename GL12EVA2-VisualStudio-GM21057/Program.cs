using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Eva:2
// Ejercicio:
// Fecha: 3/5/2022
// Autor: Brandon William Gomez Monge
// Carnet: GM21057
// GL: #12
// GT: #3
// Instructora: Lizeth Carmeline Gochez De Peñate

namespace GM21057Guia
{
	//Descripcion del programa:
	//Se ingresan las temperaturas de cada día de la semana las cuales solo pueden variar de -23 a 23 grados(7 días) tomada a las 12m,
	//para cierta cantidad de semanas(no se conoce cuantas), determinar e informar:
	//a.Promedio de temperatura semanal b.La temperatura más fría y la más cálida leída en las semanas

	class Program
	{
		public static void Main(string[] args)
		{
			//Identificacion del programa en pantalla
			Console.Title = ("Calculo de temperaturas en los dias de la semana");
			Console.WriteLine("Calculo de temperaturas en los dias de la semana ");
			Console.WriteLine("Autor:Brandon Gomez");

			//DECLARACION DE VARIABLES
			double temperatura;
			double sumaDia; sumaDia=0;
			double tempProm; tempProm = 0;
			double conTemp; conTemp = 0;
			double dia; dia = 1;
			double diaCalor; diaCalor = 1;
			double diaFrio; diaFrio = 1;
			double diaMasFrio; diaMasFrio = 0;
			double diaMasCalor; diaMasCalor = 0;
			double semanaFrio; semanaFrio = 0;
			double semanaCalor; semanaCalor = 0;
			double semanasARegistrar; semanasARegistrar = 0;
			int e; e = 1; int a; a = 1;
			//ENTRADA DE DATOS
			Console.WriteLine("Ingrese las semanas a registrar: "); semanasARegistrar = double.Parse(Console.ReadLine());

			//PROCESO DE DATOS
			while (a <= semanasARegistrar)
			{

				for (e = 1; e <= 7; e++)
				{
				
					temperatura = TemperaturaDia(e);
					conTemp = conTemp + temperatura;
					sumaDia = temperatura;
					dia = e;
					semanaFrio = a;

					if (e == 1)
					{
						diaMasCalor = sumaDia;
						diaMasFrio = sumaDia;
						

					}

					else
					{
						if (sumaDia > diaMasCalor)
						{
							diaMasCalor = sumaDia;
							diaCalor = dia;
							semanaCalor = a;

						}

						if (sumaDia < diaMasFrio)
						{
							diaMasFrio = sumaDia;
							diaFrio = dia;
							semanaFrio = a;

						}
					}

				}
                

				tempProm = conTemp / 7;
				Console.WriteLine("-------------------------------------------------------------------------------------------- ");
				Console.WriteLine("Promedio de temperatura de la semana es: " + tempProm);
				Console.WriteLine(" ");
				//PROCESO DE DATOS
				a++;
			}
			ImprimirResultado(diaCalor, diaFrio,semanaFrio,semanaCalor);
			Console.ReadKey(true);
		}


		public static double TemperaturaDia(int e)
		{
			double temperatura;
			//ENTRADA DE DATOS

			Console.Write(" Ingrese la temperatura entre -23 grados y 23 grados del dia {0} en grados Celcius: ", e); temperatura = double.Parse(Console.ReadLine());

			while (temperatura<-23 || temperatura>23)
            {
				Console.WriteLine("Debe ingresar temperaturas entre -23 grados y 23 grados");
				Console.WriteLine(" ");
				Console.Write("Ingrese la temperatura entre -23 grados y 23 grados del dia {0} en grados Celcius: ", e); temperatura = double.Parse(Console.ReadLine());
			}
			
			 return temperatura; 
		}

		public static void ImprimirResultado(double diaCalor, double diaFrio, double semanaFrio, double semanaCalor)
		{//SALIDA DE DATOS
			Console.WriteLine("-------------------------------------------------------------------------------------------- ");
			Console.WriteLine(" ");
			Console.WriteLine("[lUNES=1; Martes=2; Miercoles=3; Jueves=4; Viernes=5; Sabado=6; Domingo=7;]");
			Console.WriteLine(" ");
			Console.WriteLine("-------------------------------------------------------------------------------------------- ");
			Console.WriteLine(" ");
			Console.WriteLine("SEMANA {0} Dia Mas caluroso: {1}. ",semanaCalor, diaCalor);
			Console.WriteLine("-------------------------------------------------------------------------------------------- ");
			Console.WriteLine(" ");
			Console.WriteLine("SEMANA {0} Dia Mas Frio: {1}. ",semanaFrio, diaFrio);
			Console.WriteLine("-------------------------------------------------------------------------------------------- ");
			
			
		}

	}
}