using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesFusca
{
    internal class Fusca
    {
        private string placa;
        private int aro;
        private string cor;
        private string corParachoque;
        
        public Fusca(string placa, int aro, string cor, string corParachoque)
        {
            this.placa = placa;
            this.aro = aro;
            this.cor = cor;
            this.corParachoque = corParachoque;
        }

        public int acelarar(int velocidade)
        {
            return velocidade+=1;
        }
        public int freiar(int velocidade)
        {
            if ((velocidade - 1) < 0)
            {
                return velocidade;
            }
            return velocidade -= 1;
        }
        public int subirMarcha(int marcha)
        {
            if ((marcha + 1) == 6)
            {
                return marcha;
            }
            return marcha += 1;
        }
        public int descerMarcha(int marcha)
        {
            if ((marcha - 1) < 0)
            {
                return marcha = 0;
            }
            return marcha -= 1;
        }
    }
    }
