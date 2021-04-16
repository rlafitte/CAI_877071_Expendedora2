using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expendedora.Libreria.Excepciones
{
    public class Excepciones : Exception
    {
    }
    public class CapacidadInsuficienteException : Exception
    {

    }
    public class DineroInsuficienteException : Exception
    {

    }
    public class SinStockException : Exception
    {

    }
    public class CodigoInvalidoException : Exception
    {

    }
    public class OperacionInvalida : Exception
    {
        public OperacionInvalida() : base("La opción no es válida.") { }
    }
    public class MaquinaApagada : Exception
    {
        public MaquinaApagada() : base("La expendedora está apagada.") { }
    }
    public class CodigoYaExistente : Exception
    {

    }
    public class YaEncendida : Exception
    {
        public YaEncendida() : base("La expendedora ya está encendida.") { }
    }
}
