using System.Globalization;
using System;

namespace EstruFilaCircular
{
    public class FilaCircular {
        private Object[] Stack;
        private int frente;
        private int tras;
        private int StackMaxSize;
        public FilaCircular (int MaxSize)
        {
            this.Stack = new Object[MaxSize];
            this.frente = 0;
            this.tras = 0;
            this.StackMaxSize = MaxSize;
        }

        public bool IsFilaCircularEmpty()
        {
            if (this.frente == this.tras)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Enqueue(Object Element)
        {
            //Verificar Aritimetica modular
            if ((this.tras +1) % StackMaxSize == this.frente)
            {
                throw new Exception("A lista esta cheia");
            }
            else
            {
                this.Stack[this.tras] = Element;
                this.tras = (this.tras + 1) % StackMaxSize;
            }
        }

        public Object Dequeue ()
        {
            if (IsFilaCircularEmpty())
            {
                throw new Exception ("A fila esta vazia");
            }
            else
            {
                Object savepoint = this.Stack[this.frente];
                this.frente = (this.frente + 1) % StackMaxSize;
                return savepoint;
            }
        }
    }
}