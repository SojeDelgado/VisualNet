namespace ControlProductosHogar.Models{

    class Mueble{
        private String _nombreMueble;
        private String _modeloMueble;
        private int _precio;
        private int _cantidadVentas;

        public Mueble(String nombreMueble, String modeloMueble, int precio, int cantidadVentas){
            _nombreMueble = nombreMueble;
            _modeloMueble = modeloMueble;
            _precio = precio;
            _cantidadVentas = cantidadVentas;

        }

        public string nombreMueble{
            get {return _nombreMueble;}
            set {_nombreMueble = value;}
        }

        public string modeloMueble{
            get{return _modeloMueble;}
            set{_modeloMueble = value;}
        }

        public int precio{
            get{return _precio;}
            set{_precio = value;}
        }

        public int cantidadVentas{
            get{return _cantidadVentas;}
            set{_cantidadVentas = value;}
        }

        public override string ToString(){
            return "[ Nombre: " + _nombreMueble + " , Modelo: " + _modeloMueble + " , Precio: " + _precio + " , Ventas: " + _cantidadVentas + "]";
        }
    }    
}