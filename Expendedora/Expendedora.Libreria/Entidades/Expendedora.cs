using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expendedora.Libreria.Entidades
{
    public class Expendedora
    {
        
        private bool _encendida = false;
        private List<Lata> _latas = new List<Lata>();
        private string _proveedor;
        private int _capacidad = 50; //arbitrariamente determinamos capacidad máxima en 50 latas en total
        private double _dinero;
        public Expendedora()
        {
            _encendida = true;
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
            Expendedora E = new Expendedora();
        }
        public bool EstaVacia()
        {
            bool flag = true;
            return flag;
        }

    }
}
