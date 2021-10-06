using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraCola
{
    class ColaCircular
    {
        public int maxcola = 5;
        public int primero;
        public int ultimo;
        public String[] lista;

        public ColaCircular()
        {
            primero = -1;
            ultimo = -1;
            lista = new String[maxcola];
        }

        private bool vacia()
        {
            if (primero == -1 && ultimo == -1)
                return true;
            else
                return false;
        }

        private bool llena()
        {
            if ((ultimo == maxcola - 1 && primero == 0) || (ultimo + 1 == primero))
                return true;
            else
                return false;
        }

        public void insertar(String elemento)
        {
            if (llena())
                MessageBox.Show("la cola esta llena, no se puede insertar elementos");
            else
            {
                if (ultimo == maxcola - 1)
                    ultimo = 0;
                else
                    ultimo++;
                lista[ultimo] = elemento;
                if (primero == -1)
                    primero++;
            }
        }

        public void eliminar()
        {
            if (vacia())
                MessageBox.Show("la cola esta vacia, no se puede eliminar elementos");
            else
            {
                MessageBox.Show("el elemento eliminado es: "+lista[primero]);
                lista[primero] = "";
                if(primero == ultimo)
                {
                    primero = -1;
                    ultimo = -1;
                }
                else
                {
                    if (primero == maxcola - 1)
                        primero = 0;
                    else
                        primero++;
                }
            }
        }
    }
}
