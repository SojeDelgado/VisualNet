using ControlPeliculas.Models;
namespace ControlPeliculas{

    class ControlPeliculasAdmin{
        private List<Pelicula> _peliculas;
    

        public ControlPeliculasAdmin(){
            _peliculas = new List<Pelicula>();
        }

        public void showMenuPrincipal(){
            int opcionSeleccionada = 0;

            do{

                Console.WriteLine("Bienvenido al Menú peliculas");
                Console.WriteLine("1. Filtrar por nombre");
                Console.WriteLine("2. Filtrar por genero");
                Console.WriteLine("3. Filtrar por año");
                Console.WriteLine("4. Salir");

            }while (!validaMenu(4,ref opcionSeleccionada));
            switch (opcionSeleccionada){
                case 1: filtrarPorNombre(); //Se mandará a llamar al método filtrar por nombre
                break;
                case 2: filtrarPorGenero(); //Se mandará a llamar al método filtrar por genero
                break;
                case 3: filtrarPorAnio(); //Se mandará a llamar al método filtrar por año
                break;
                case 4: break;
            }
        }


    /**
        * Este método reordenará la lista por orden menor-mayor del atributo "año"
        */
        private void filtrarPorAnio()
        {
            _peliculas = _peliculas.OrderBy(x => x.anio).ToList();
            Console.WriteLine(String.Join(Environment.NewLine, _peliculas));
        }

        /**
        * Este método reordenará la lista por orden alfabetico del atributo "nombre"
        */
        private void filtrarPorNombre(){
            _peliculas = _peliculas.OrderBy(x => x.nombre).ToList();
            Console.WriteLine(String.Join(Environment.NewLine, _peliculas));
        }

        /**
        * Este método reordenará la lista por orden alfabetico del atributo "genero"
        */
        private void filtrarPorGenero(){
            _peliculas = _peliculas.OrderBy(x => x.genero).ToList();
            Console.WriteLine(String.Join(Environment.NewLine, _peliculas));
        }

        private bool validaMenu(int opciones, ref int opcionSeleccionada)
        {
            int n;
            if (int.TryParse(Console.ReadLine(), out n)){
                if (n <= opciones){
                    opcionSeleccionada = n;
                    return true;

                }else{
                    Console.Clear();
                    Console.WriteLine("Opción invalida.");
                    return false;
                }

            }else{
                Console.WriteLine("Valor ingresado no es valido.");
                return false;

            }
        }

        public void inicializarDatos(){
            Pelicula pelicula1 = new Pelicula("Anabelle","Terror",2012);
            Pelicula pelicula2 = new Pelicula("Spider-Man","Accion",2021);
            Pelicula pelicula3 = new Pelicula("KingsMan","Accion",2018);
            Pelicula pelicula4 = new Pelicula("Vikingos","Aventura",2019);
            Pelicula pelicula5 = new Pelicula("Batman","Suspenso",2022);
            Pelicula pelicula6 = new Pelicula("Joker","Drama",2017);

            _peliculas = new List<Pelicula> 
            { pelicula1, pelicula2 ,pelicula3,
              pelicula4, pelicula5, pelicula6};
        }
    }
}