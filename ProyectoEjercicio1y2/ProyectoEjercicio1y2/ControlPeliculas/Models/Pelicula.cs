namespace ControlPeliculas.Models{
    class Pelicula{
        private String _nombre;
        private String _genero;
        private int _anio;
        
        public Pelicula(String nombre, String genero, int anio){
            _nombre = nombre;
            _genero = genero;
            _anio = anio;
        }

        public string nombre{
            get { return _nombre;}
            set { _nombre = value;}
        }

        public string genero{
            get{ return _genero;}
            set{ _genero = value;}
        }

        public int anio{
            get{ return _anio;}
            set{ _anio = value;}
        }

        public override string ToString(){
            return "[" + "Nombre: " + _nombre + " , Genero: " + _genero + " , Año: " + _anio + "]";
        }
    }
}

