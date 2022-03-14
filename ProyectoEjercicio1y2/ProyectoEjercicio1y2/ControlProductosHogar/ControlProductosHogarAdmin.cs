using ControlProductosHogar.Models;
namespace ControlProductosHogar{

    class ControlProductosHogarAdmin{

        private List<Mueble> _muebles;

        public ControlProductosHogarAdmin(){
            _muebles = new List<Mueble>();
        }

        public void showMenuPrincipal(){
            int opcion = 0;

            while (opcion == 0){

                Console.WriteLine("1. Agregar nuevo producto");
                Console.WriteLine("2. Ver producto más vendido");
                Console.WriteLine("3. Salir");
                Console.WriteLine("Introduzca la opción: ");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1){
                    Console.Clear();
                    Console.WriteLine("Se escogio la opción 1");

                    agregarProducto();
                    opcion = 0;
                }

                else if (opcion == 2){
                    Console.Clear();
                    Console.WriteLine("Se escogio la opción 2");

                    verProductoMasVendido();
                    Console.WriteLine("\n");
                    opcion = 0;

                }else if (opcion == 3){
                    Console.WriteLine("Bye bye");
                }
                else{
                    Console.WriteLine("Opcion invalida");
                    Console.Clear();
                }

            }
        }

        public void agregarProducto(){
            Console.WriteLine("Ingresa el nombre del mueble");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingresa el modelo del mueble");
            string modelo = Console.ReadLine();

            Console.WriteLine("Ingresa el precio del mueble");
            int prcio = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa la cantidad de ventas del mueble");
            int cVentas = int.Parse(Console.ReadLine());


            Mueble mueble = new Mueble(nombre,modelo,prcio,cVentas);

            _muebles.Add(mueble);
        }

        public void verProductoMasVendido(){
            List<Mueble> ordenarPorVentas = _muebles.OrderBy(x => x.cantidadVentas).ToList();

            Mueble ultimo = ordenarPorVentas.Last();
            Console.WriteLine(ultimo);
        }

        public void inicializarDatos(){
            Mueble mueble1 = new Mueble("Silla","Rustico",50,3);
            Mueble mueble2 = new Mueble("Mesa","Moderno",100,2);
            Mueble mueble3 = new Mueble("Sillon","Antiguo",90,1);
            Mueble mueble4 = new Mueble("Mesa","Antiguo",70,4);
            Mueble mueble5 = new Mueble("Silla","Moderna",150,5);
            Mueble mueble6 = new Mueble("Sillon","Rustico",120,8);
            Mueble mueble7 = new Mueble("Sillon","Moderno",40,6);

            _muebles.Add(mueble1);
            _muebles.Add(mueble2);
            _muebles.Add(mueble3);
            _muebles.Add(mueble4);
            _muebles.Add(mueble5);
            _muebles.Add(mueble6);
            _muebles.Add(mueble7);
        }
    }
}