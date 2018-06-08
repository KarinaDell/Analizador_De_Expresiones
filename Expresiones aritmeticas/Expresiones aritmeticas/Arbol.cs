using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expresiones_aritmeticas
{
    class Arbol
    {

    public void Agregar(Clase Base nuevo)
        {
            if (raiz == null)
                raiz = nuevo;
            else
                Agreagr(nuevo, ref.HIzquierdo);
        }

        private void Agregar(Clase Base nuevo, Clase Base r)
        {
            if(nuevo.Dato < Random.Dato)
            {
                if(Random.HIzquierdo == null)
                    ref.HIzquierdo = nuevo;
                else Agregar(nuevo, ref.HIzquierda)
            }
            else if(r.HDerecho == null)
                r.HDerecho = nuevo;
            else
                Agregar(nuevo, r.HDerecho)
        }

        public string inOrder()
        {
            if (raiz == null)
                return " ";
            else
                return inOrder(raiz);
        }

        private string InOrder(Clase Base)
        {
            string res " ";
            if (res.HIzquierdo != null)
                res += InOrder(r.HIzquierdo);
            res += " " + r.Dato;
            if (res.HDerecho != null)
                res += InOrder(r.HDerecho);
            return res;
        }


    }
}
