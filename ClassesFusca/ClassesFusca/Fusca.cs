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
        private string tipoVidro;

        public Fusca(string placa, int aro, string cor, string corParachoque, string tipoVidro)
        {
            this.placa = placa;
            this.aro = aro;
            this.cor = cor;
            this.corParachoque = corParachoque;
            this.tipoVidro = tipoVidro;
        }

        public int acelarar(int velocidade)
        {
            if((velocidade + 5) >= 100)
            {
                return velocidade = 100;
            }
            return velocidade+=5;
        }
        public int freiar(int velocidade)
        {
            if ((velocidade - 3) < 0)
            {
                return velocidade;
            }
            return velocidade -= 3;
        }
        public int subirMarcha(int marcha)
        {
            if ((marcha + 1) == 5)
            {
                return marcha;
            }
            return marcha += 1;
        }
        public int descerMarcha(int marcha)
        {
            if ((marcha - 1) < 0)
            {
                return marcha = -1;
            }
            return marcha -= 1;
        }
    }
    }
