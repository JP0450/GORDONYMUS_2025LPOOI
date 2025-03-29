using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Examen_clase
{
    class Program
    {
        static void Main()
        {
            List<Empleado> listEmpleado = new List<Empleado>();
            List<Producto> productos = new List<Producto>();
            List<Clientes> clientes = new List<Clientes>();

            //Console.WriteLine("numero de empleados a implementar");
            //int ne = int.Parse(Console.ReadLine());

            //for (int i = 0; i < ne; i++)
            //{
            //    Console.WriteLine("Nombre del empleado");
            //    string nombre = Console.ReadLine();
            //    Console.WriteLine("Cargo del empleado");
            //    string cargo = Console.ReadLine();
            //    Console.WriteLine("Salario del empleado");
            //    double salario = double.Parse(Console.ReadLine());
            //    listEmpleado.Add(new Empleado(nombre, cargo, salario));
            //}

            //stock de productos actualizable y que clientes puedan comprar
            listEmpleado.Add(new Empleado("Jorge", "Analista", 2800000));
            listEmpleado.Add(new Empleado("Anita", "Cajera", 1200000));
            listEmpleado.Add(new Gerente("toño", "Gerente", 7896098, 20000));
            productos.Add(new Producto("1.Deshodorante", 1, 15, "Axe"));
            productos.Add(new Producto("2.Musica", 1, 10, "Orga"));
            productos.Add(new Producto("3.Camisa", 1, 11, "LV"));

           //Clientes cliente = new Clientes("Sneyder", "Sneyder.marin8119@unaula.edu.co", "3014879875");

            //cliente.RegistrarCompra();

            

            Gerente gerente = new Gerente("Pipe", "Gerente Comercial", 6856098, 500000);
            Empleado empleado = new Empleado("Paola", "Aseo", 100000);
            Console.WriteLine($"La diferencia de salario entre la cajera y el gerente es de {gerente.CalcularSalarioTotal() - empleado.CalcularSalarioTotal()}");
            foreach (var m in listEmpleado)
            {
                Console.WriteLine($"El salario de {m.Nombre} es {m.CalcularSalarioTotal()}");
               // Console.WriteLine($"La diferencia de salario entre la cajera y el gerente es de {gerente.CalcularSalarioTotal() - m.CalcularSalarioTotal()}");
            }
            

           
            Console.ReadKey();

            do //el metodo funciona gracias al static, esto indica que no es necesario inicializar la clase para poder usar el metodo
            {
                Producto.ViewProduct(productos);

            } while (true);



        }

    }
}
