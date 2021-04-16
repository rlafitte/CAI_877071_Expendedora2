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
            _latas.Add(L);
        }
        public void RetirarLata(string s)
        {
            var aux = _latas.FirstOrDefault(i => i.Codigo == s);
            if (aux != null)
            {
                aux.Cantidad--;
            }

            
            //_latas.Remove
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
                if (L.Cantidad > 0)
                {
                    msg += L.Codigo + ")" + L.Nombre + "[" + L.Cantidad + "]" + Environment.NewLine;
                }
                else
                {
                    msg += L.Codigo + ")" + L.Nombre + "[" + L.Cantidad + "] --- SIN STOCK" + Environment.NewLine;
                }
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
        public string ListadoCompleto()
        {
            string msg = "";
            foreach(Lata L in _latas)
            {
                msg += L.ToString() + Environment.NewLine;
            }
            return msg;
        }
    }
}
