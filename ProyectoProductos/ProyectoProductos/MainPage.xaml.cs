using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ProyectoProductos.Datos;

namespace ProyectoProductos
{
    public partial class MainPage : ContentPage
    {
        Random random = new Random();
        public IList<Producto> productos { get; private set; }
        public MainPage()
        {
            InitializeComponent();
            productos = new List<Producto>();

            int R = random.Next(11111111,99999999);
            productos.Add(new Producto
            {
                ID = "46424",
                Nombre_Descripcion = "Leche deslactosada",
                Precio = "Precio: 6.5",
                Imagen = "https://pilandina.com.bo/wp-content/uploads/2019/06/lechedeslactosada-600x600.png",
                cantidad = "Cantidad: 20",
                Barras = R
            });

            productos.Add(new Producto
            {
                ID = "08543",
                Nombre_Descripcion = "Duraznos en almibar",
                Precio = "Precio: 12.5",
                Imagen = "https://geant.vteximg.com.br/arquivos/ids/228786-700-700/690716.jpg?v=636850753066870000",
                cantidad= "Cantidad 45",
                Barras=R              
            });

            productos.Add(new Producto
            {
                ID = "53502",
                Nombre_Descripcion = "Coca Cola Zero",
                Precio = "Precio: 5",
                Imagen = "https://coca-colafemsa.com/wp-content/uploads/2020/02/8-5.png",
                cantidad= "Cantidad 120",
                Barras=R
            });

            productos.Add(new Producto
            {
                ID = "3575",
                Nombre_Descripcion = "Jugo de naranja",
                Precio = "Precio: 25",
                Imagen = "https://mercaldas.vteximg.com.br/arquivos/ids/188160-400-400/19965.jpg?v=637199773013970000",
                cantidad = "Cantidad: 120",
                Barras = R
            });

            productos.Add(new Producto
            {
                ID = "9535",
                Nombre_Descripcion = "Galletas de chocolate",
                Precio ="Precio: 3.5",
                Imagen = "https://www.ketal.com.bo/image/cache/catalog/product/20030830-550x550.jpg",
                cantidad = "Cantidad: 240",
                Barras = R
            });
            BindingContext = this;

        }
        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Producto SelectedItem = e.SelectedItem as Producto;
        }
        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Producto tappedSelected = e.Item as Producto;
        }



    }
}
