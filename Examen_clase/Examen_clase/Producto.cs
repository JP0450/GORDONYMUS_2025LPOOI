using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_clase
{
    internal class Producto
    {

        private string nombre;
        private double precio;
        private double stock;
        private string marca;

        public Producto(string nombre, double precio, int stock, string marca)
        {
            if (precio<0)
            {
                throw new ArgumentException("No puede ser negativo el precio");
            }
            if (stock<0)
            {
                throw new ArgumentException("No puede ser negativo el stock");
            }
            this.nombre = nombre;
            this.precio = precio;
            this.stock = stock;
            this.marca = marca;
        }
        public void Setprecio(double precio)
        {
            if (precio<0)
            {
                throw new ArgumentException("No puede ser negativo el precio");
            }
            this.precio = precio;
        }
        public void Setstock(double stock)
        {
            if (stock < 0)
            {
                throw new ArgumentException("No puede ser negativo el stock");
            }
            this.stock = stock;
        }
        

        //public string Compra(List<Producto> productos, int opcion)
        //{
            
            //switch (opcion)
            //{
            //    case 1:
            //        foreach (var m in productos)
            //        {
            //            Console.WriteLine($"Nombre: {m.nombre}, Precio: {m.precio}, Stock: {m.stock}, Marca: {m.marca}");
            //        }
            //        Console.WriteLine("Ingrese su nombre");
            //        string nombre = Console.ReadLine();
            //        Console.WriteLine("Ingrese su correo");
            //        string correo = Console.ReadLine();
            //        Console.WriteLine("Ingrese su telefono");
            //        string telefono = Console.ReadLine();
            //        Clientes cliente = new Clientes(nombre, correo, telefono);
            //        cliente.RegistrarCompra();
            //        //bucle para comprar cadad uno de los elementos
            //        //Console.WriteLine("que va a comprar");

            //        Console.WriteLine("que va a comprar");
            //        return "";
                    
            //    case 2://mostrar productos
            //        foreach (var m in productos)
            //        {
            //            Console.WriteLine($"Nombre: {m.nombre}, Precio: {m.precio}, Stock: {m.stock}, Marca: {m.marca}");
            //        }
            //        return "";
            //    case 3:
            //        return "";
            //}
            //return "";
           
        //}

        public static void ViewProduct(List<Producto> productos)
        {
            Console.WriteLine("bienvenido al supermercado el tumbis ");
            Console.WriteLine("1. Comprar");
            Console.WriteLine("2. Ver productos");
            Console.WriteLine("3. Salir");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:

                    foreach (var m in productos)
                    {
                        Console.WriteLine($"Nombre: {m.nombre}, Precio: {m.precio}, Stock: {m.stock}, Marca: {m.marca}");
                    }

                    Console.WriteLine("Ingrese su nombre");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese su correo");
                    string correo = Console.ReadLine();
                    Console.WriteLine("Ingrese su telefono");
                    string telefono = Console.ReadLine();
                    Clientes cliente = new Clientes(nombre, correo, telefono);
                    cliente.RegistrarCompra();
                    //bucle para comprar cada uno de los elementos
                    Console.WriteLine("cuanto va a comprar?");
                    int cantidad = int.Parse(Console.ReadLine());
                    double compratotal = 0;
                    for (int i = 0; i < cantidad; i++)
                    {
                        Console.WriteLine("que va a comprar?");
                        int compra = int.Parse(Console.ReadLine());
                        if (compra == 1)
                        {
                            productos[compra - 1].stock--;
                            compratotal = productos[compra - 1].precio + compratotal;
                        }
                        else if (compra == 2)
                        {
                            productos[compra - 1].stock--;
                            compratotal = productos[compra - 1].precio + compratotal;
                        }
                        else if (compra == 3)
                        {
                            productos[compra - 1].stock--;
                            compratotal = productos[compra - 1].precio + compratotal;
                        }
                    }
                    Console.WriteLine($"El total de la compra es {compratotal}");


                    break;

                case 2:
                    foreach (var m in productos)
                    {
                        Console.WriteLine($"Nombre: {m.nombre}, Precio: {m.precio}, Stock: {m.stock}, Marca: {m.marca}");
                    }


                    break;
                case 3:
                    break;

            }




            //string compra=Producto.Compra(productos, opcion);
            ////compra.Compra();

            Console.ReadKey();



        }



    }
}
