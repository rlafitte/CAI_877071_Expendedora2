using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Expendedora.Libreria;
using Expendedora.Libreria.Entidades;
using Expendedora.Libreria.Excepciones;

namespace Expendedora.Consola
{
    public class Program
    {

        static private Expendedora.Libreria.Entidades.Expendedora E = new Expendedora.Libreria.Entidades.Expendedora();
        static void Main(string[] args)
        {
            bool flag = true;
            E.EncenderMaquina();
            
            while (flag)
            {
                Menu();

                try
                {
                    OpcionSeleccionada(LeerOpcion(), out flag);
                }
                catch (OperacionInvalida op)
                {
                    Console.WriteLine(op.Message);
                }
            }
            
        }

        static void Menu()
        {
            Console.WriteLine("Bienvenido. Ingrese la opción deseada: ");
            Console.WriteLine("1 - Listar latas disponibles" + Environment.NewLine +
                "2 - Insertar lata" + Environment.NewLine +
                "3 - Comprar lata" + Environment.NewLine +
                "4 - Consultar saldo" + Environment.NewLine +
                "5 - Listar latas disponibles - detalle completo" + Environment.NewLine +
                "99 - Salir" + Environment.NewLine)
                ;
        }
        static int LeerOpcion()
        {
            int opcion;
            Console.Write("Ingresar opción: ");
            int.TryParse(Console.ReadLine(), out opcion);
            return opcion;
        }

        static void OpcionSeleccionada(int i, out bool fin)
        {
            fin = true;
            switch (i)
            {
                case 1:
                    E.ListarLatas();
                    break;
                case 2: break;
                case 3: break;
                case 4: break;
                case 5: break;
                case 99: break;
                default: break;

            }
        }

        static void PedirDatosLata(Lata L)
        {
            Console.WriteLine("Ingrese código de lata: ");
            L.Codigo = Console.ReadLine();
            Console.WriteLine("Ingrese nombre de lata: ");
            L.Nombre= Console.ReadLine();
            Console.WriteLine("Ingrese sabor de lata: ");
            L.Sabor= Console.ReadLine();
            Console.WriteLine("Ingrese precio de lata: ");
            L.Precio= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese volumen de lata: ");
            L.Volumen= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad de lata: ");
            L.Cantidad= Convert.ToInt32(Console.ReadLine());

        }
        static void IngresarLata()
        {
            if (E.MaquinaEncendida())
            {
                
                Lata L = new Lata();
                PedirDatosLata(L);
                E.AgregarLata(L);
            }
            else
            {
                Console.WriteLine("La máquina no está encendida.");
            }
        }

        static void ExtraerLata()
        {

        }

        static void ObtenerBalance()
        {

        }
        static void MostrarStock()
        {

        }
    }
}
