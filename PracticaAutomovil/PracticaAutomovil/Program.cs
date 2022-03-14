// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ejercicio;

Automovil auto = new Automovil(12345, "Toyota", "Supra", 12000, 600000);
Console.WriteLine("Caracteristicas del auto: " + auto.ToString());
AutomovilDeLujo automovilDeLujo = new AutomovilDeLujo(123, "Nissan", "GTR", 0, 100000000);
automovilDeLujo.agregarAireAcondicionado();
automovilDeLujo.agregarVentanaElectrica();
//Console.WriteLine("Caracteristicas del auto de lujo: " + automovilDeLujo.ToString());

Consesionaria consesionaria = new Consesionaria(6);

consesionaria.agregarAuto(auto);
consesionaria.agregarAuto(automovilDeLujo);

//Console.WriteLine("Se mostrarar el auto: ");
//consesionaria.mostrarAuto(auto);

Console.WriteLine("Se mostrarar el auto de lujo: ");
consesionaria.mostrarAuto(automovilDeLujo);

Console.WriteLine("Se mostraran todos los autos: ");
consesionaria.mostrarAutos();

//Console.WriteLine("Se eliminó el auto de lujo: \n");
//consesionaria.eliminarAuto(automovilDeLujo);

//Console.WriteLine("Se mostrara el auto de lujo: ");
//consesionaria.mostrarAuto(automovilDeLujo);

Console.WriteLine("Se eliminara el indice 1 ");
consesionaria.eliminarIndice(1);

Console.WriteLine("Se mostraran todos los autos: ");
consesionaria.mostrarAutos();

Console.WriteLine("SE VACIARA LA CONSESIONARIA");
consesionaria.vaciarConsesionaria();

Console.WriteLine("Se mostraran todos los autos: ");
consesionaria.mostrarAutos();




namespace Ejercicio
{
	internal class Automovil
	{
		private int _id;
		private string _marca;
		private string _modelo;
		private int _km;
		private float _precio;

		public Automovil(int id, string marca, string modelo, int km, float precio)
		{
			this._id = id;
			this._marca = marca;
			this._modelo = modelo;
			this._km = km;
			this._precio = precio;
		}

		public int id { set; get; }
		public string marca { set; get; }
		public string modelo { set; get; }
		public int km { set; get; }
		public float precio { set; get; }

		public override string ToString()
		{
			return $"ID:{this._id} ,Marca:{this._marca} ,Modelo:{this._modelo} ,KM:{this._km} ,Precio:{this._precio}  \n";
		}
	}
}

namespace Ejercicio
{
	internal class AutomovilDeLujo : Automovil
	{
		private Boolean _AireAcondicionado;
		private Boolean _VentanaElectrica;
		private Boolean _AsientosPremium;
		private Boolean _PantallaTouch;

		public AutomovilDeLujo(int id, string marca, string modelo, int km, float precio) : base(id, marca, modelo, km, precio)
		{
			this._AireAcondicionado = false;
			this._VentanaElectrica = false;
			this._AsientosPremium = false;
			this._PantallaTouch = false;
		}
		public void agregarAireAcondicionado()
		{
			this._AireAcondicionado = true;
			this.precio += 10000;
		}
		public void agregarVentanaElectrica()
		{
			this._VentanaElectrica = true;
			this.precio += 20000;
		}
		public void agregaAsietosPremium()
		{
			this._AsientosPremium = true;
			this.precio += 15000;
		}
		public void agregaPantallaTouch()
		{
			this._PantallaTouch = true;
			this.precio += 20000;
		}
		/* "ID: ,Marca: ,Modelo: ,KM: ,Precio: " + "Extras: Aire Acondicionado, Ventana Electrica, Asientos Premium, PantallaTouch"*/
		/* "ID: ,Marca: ,Modelo: ,KM: ,Precio: " + "Extras: Aire Acondicionado"*/
		/* "ID: ,Marca: ,Modelo: ,KM: ,Precio: " + "Extras: Ventana Electrica, Asientos Premium"*/
		/* "ID: ,Marca: ,Modelo: ,KM: ,Precio: " */
		public override string ToString()
		{

			string extras = "";
			if (_AireAcondicionado)
			{
				extras += "Aire Acondicionado, ";

			}
			if (_VentanaElectrica)
			{
				extras += "Ventan Electrica, ";
			}
			if (_AsientosPremium)
			{
				extras += "Asientos Premium, ";
			}
			if (_PantallaTouch)
			{
				extras += "Pantalla Touch";
			}
			extras += "\n";

			return base.ToString() + extras;
		}

	}
}

namespace Ejercicio
{
	internal class Consesionaria
	{
		object[] _Automoviles;
		int _MAXIMOAUTOS;
		int _numAutomoviles;

		public Consesionaria(int maximo)
        {
			this._MAXIMOAUTOS = maximo;
			this._Automoviles = new object[maximo];
			this._numAutomoviles = -1;
        }

		public int agregarAuto(Automovil auto)
        {
			if (!llena()) //Hay espacio
            {
				_numAutomoviles = _numAutomoviles + 1;
				_Automoviles[_numAutomoviles] = auto;
				return _numAutomoviles;
            }
            else
            {
				return -1; //Indica que no se pudo agregar
            }
        }

		public void mostrarAuto(Automovil auto)
        {
			int posicion = buscarAuto(auto);
			
			if (posicion != -2) //Está el auto
            {
				Console.WriteLine(_Automoviles[posicion].ToString());
            }
            else
            {
				Console.WriteLine("No se encontró el auto");
            }
        }

		public object eliminarAuto(Automovil auto)
        {
			int posicion = buscarAuto(auto);
			if (posicion != -2) //Lo encontramos
            {
				object autoEliminado = _Automoviles[posicion]; //Asignamos el valor eliminado
				_numAutomoviles--; //Decrementamos el numero de autos en el arreglo


				for(int movimiento = posicion; movimiento <= _numAutomoviles; movimiento++)
                {
					_Automoviles[movimiento] = _Automoviles[movimiento + 1]; 
					//Recorremos el valor para que no haya valores vacios
                }
				return autoEliminado;
            }
            else //No lo encontramos
            {
				return null; 
            }	
        }

		public void mostrarAutos()
        {
			for (int movimiento = 0; movimiento <= _numAutomoviles; movimiento++) //Recorre toda la lista
            {
				Console.WriteLine(_Automoviles[movimiento].ToString());
            }
		}

		public Boolean vaciarConsesionaria()
        {
			if(_numAutomoviles == -1) //Ya está vacia 
            {
				Console.WriteLine("La lista actualmente está vacia \n");
				return false;
            }
            else
            {
				for(int movimiento = _numAutomoviles; movimiento >= 0; movimiento--) //Recorre toda la lista de arriba hacia abajo
                {
					eliminarIndice(movimiento); //Elimina toda la lista
                }
				return true;
            }
        }


		//---------------- Otros metodos necesarios para completar los metodos principales ---------------------------------------


		public Boolean llena()
		{
			if (_numAutomoviles == (_MAXIMOAUTOS - 1))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public int buscarAuto(Automovil auto)
		{
			int posicion = 0;
			//Busca mientras haya donde buscar  Y  mientras no lo encontremos 
			while (posicion <= _numAutomoviles && !auto.ToString().Equals(_Automoviles[posicion].ToString()))
			{
				posicion = posicion + 1;
			}
			if (posicion > _numAutomoviles) // No lo encontramos
			{
				return -2; 
			}
			else // Lo encontramos
			{
				return posicion;
			}
		}

		public object eliminarIndice(int indice)
		{

			if (indice >= 0 && indice <= _numAutomoviles) //Valor valido
			{
				object autoEliminado = _Automoviles[indice]; //Asignamos el valor eliminado
				_numAutomoviles--; //Decrementamos el numero de autos en el arreglo


				for (int movimiento = indice; movimiento <= _numAutomoviles; movimiento++)
				{
					_Automoviles[movimiento] = _Automoviles[movimiento + 1];
					//Recorremos el valor para que no haya valores vacios
				}
				return autoEliminado;
			}
			else
			{
				return false;
			}

		}

	}
}
	