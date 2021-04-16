using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Expendedora.Libreria.Entidades;
using Expendedora.Libreria.Excepciones;

namespace Expendedora.Libreria.Entidades
{
    public class Expendedora
    {

        private bool _encendida = false;
        private List<Lata> _latas;
        private string _proveedor;
        private int _capacidad; 
        private double _dinero;
        

        public Expendedora()
        {

            _latas = new List<Lata>();
            _proveedor ="";
            _capacidad = 50;
            _dinero = 0;
        }

        public void AgregarLata(Lata L)
        {

        }
        public void ExtraerLata(Lata L, double vuelto)
        {

        }

        public string GetBalance()
        {
            string msg = "";
            return msg;
        }
        public int GetCapacidadRestante()
        {
            int i = 0;
            return i;
        }
        public void EncenderMaquina()
        {
            try
            {
            _encendida = true;

            }
            catch (YaEncendida ya)
            {
                
            }

        }
        public bool EstaVacia()
        {
            bool flag = true;
            return flag;
        }

        public string ListarLatas()
        {
            string msg = "";
            foreach (Lata L in _latas)
            {
                msg += L.Codigo + ")" + L.Nombre + "[" + L.Cantidad + "]";
            }
            return msg;
        }

        public bool MaquinaEncendida()
        {
            if (_encendida)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
