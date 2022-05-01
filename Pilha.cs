using System.Net.NetworkInformation;
using System;


namespace EstruPilha
{
    public class Pilha {
        private Object[] Stack;

        private int topo;
        private int StackMaxSize;
        public Pilha(int MaxSize)
        {
            this.Stack = new Object[MaxSize];
            topo = 0;
            this.StackMaxSize = MaxSize;
        }


        public bool IsPilhaEmpty()
        {
            if (topo == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Push (Object Element) 

        {
            if (topo == StackMaxSize)
            {
                throw new Exception("A pilha esta cheia");
            }
            else
            {
                topo = topo + 1;
                this.Stack[topo] = Element;
            }
            
        }

        public Object Pop ()
        {
            if (IsPilhaEmpty() == true)
            {
                throw new Exception("A pilha esta Vazia");
            }
            else
            {
                topo = topo - 1;
                return Stack[topo + 1];
            }
        }

        public int StackSize()
        {
            return StackMaxSize;
        }

        public int HowManyElements()
        {
            return topo;
        }
    }
}