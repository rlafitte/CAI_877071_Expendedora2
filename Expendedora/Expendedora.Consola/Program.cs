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

        static void Main(string[] args)
        {
            Expendedora.Libreria.Entidades.Expendedora E = new Expendedora.Libreria.Entidades.Expendedora();
            E.EncenderMaquina();
            
        }

        static void IngresarLata()
        {

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
