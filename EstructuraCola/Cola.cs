using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraCola
{
    class Cola
    {
        static int maxcola = 5;
        public int primero;
        public int ultimo;
        public int[] lista;

        public Cola()
        {
            primero = 0;
            ultimo = -1;
            lista = new int[maxcola];

        }

        private bool vacia()
        {
            if (ultimo < primero)
                return true;
            else
                return false;
        }

        private bool llena()
        {
            if (ultimo == maxcola - 1)
                return true;
            else
                return false;
        }

        public void insertar_inicio(int elemento)
        {

        }

        public void insertar_final(int elemento)
        {
            if (llena())
                MessageBox.Show("la cola esta llena, no se puede insertar mas elementos");
            else
            {
                ultimo++;
                lista[ultimo] = elemento;
            }
        }

        public void eliminar_inicio()
        {
            if (vacia())
                MessageBox.Show("la cola esta vacia, no se puede eliminar mas elementos");
            else
            {
                MessageBox.Show("el elemento eliminado es: " + lista[primero]);
                for(int i=0; i<=ultimo-1; i++)
                {
                    lista[i] = lista[i + 1];
                }
                ultimo--;
            }
        }

        public void eliminar_final()
        {
            if (vacia())
                MessageBox.Show("la cola esta vacia, no se puede eliminar mas elementos");
            else
            {
                MessageBox.Show("el elemento eliminado es: "+lista[ultimo]);
                ultimo--;
            }
        }
        
    }
}
