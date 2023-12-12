using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMÁFARO
{
    internal class Semaforo
    {

        private byte estado;
       
        public Semaforo()
        {
            this.estado = 0;
        }

        public void setVerde(int rua)
        {
            if (rua == 1)
            {
                this.estado = (byte)((int)this.estado | (int)Math.Pow(2, 0));
            }
            if (rua == 2)
            {
                this.estado = (byte)((int)this.estado | (int)Math.Pow(2, 5));
            }
        }

        public void setAmarelo(int rua)
        {
            if (rua == 1)
            {
                this.estado = (byte)((int)this.estado | (int)Math.Pow(2, 1));
            }
            if (rua == 2)
            {
                this.estado = (byte)((int)this.estado | (int)Math.Pow(2, 6));
            }
        }

        public void setVermelho(int rua)
        {
            if (rua == 1)
            {
                this.estado = (byte)((int)this.estado | (int)Math.Pow(2, 2));
            }
            if (rua == 2)
            {
                this.estado = (byte)((int)this.estado | (int)Math.Pow(2, 7));
            }
        }

        public byte getEstado()
        {
            return this.estado;
        }

        public int getEstado(int rua)
        {
            byte aux;
            aux = 0;

            if (rua == 1) 
            {
                if (this.estado == 1)
                { 
                    aux = 1;
                }
                if (this.estado == 2)
                {
                    aux = 2;
                }
                if (this.estado == 4)
                {
                    aux = 3;
                }                
            }

            if (rua == 2)
            {
                if (this.estado == 32)
                {
                    aux = 1;
                }
                if (this.estado == 64)
                {
                    aux = 2;
                }
                if (this.estado == 128)
                {
                    aux = 3;
                }
            }

            return aux;
        }
    }
}
