using System;
using System.Collections.Generic;
using System.Text;

namespace PilA.ColA.tads.pc
{
    class pila
    {
        private int[] data = new int[5];

        public int[] DATA
        {
            get { return data; }
            set { data = value; }
        }
        private int cima = -1;

        public int CIMA
        {
            get { return cima; }
            set { cima = value; }
        }
        public void EliminarData()
        {
            if (CIMA == -1)
                throw new Exception("No hay datos en la Pila");
            else
                CIMA--;
        }
        public void Anadir(int numero)
        {
            if (CIMA < DATA.Length - 1)
            {
                CIMA++;
                DATA[CIMA] = numero;
            }



        }
    }
}
