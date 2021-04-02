using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoProductos.Datos
{
    public class Producto
    {
        public string ID { set; get; }
        public string Nombre_Descripcion { set; get; }
        public string Precio { set; get; }
        public string Imagen { set; get; }
        public string cantidad { set; get; }
        public int Barras { set; get; }


        public override string ToString()
        {
            return ID;
        }
    }
}
