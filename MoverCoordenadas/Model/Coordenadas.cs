using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoverCoordenadas.Model
{
    public class Coordenadas
    {
        private int posicaoX;
        private int posicaoY;
        private Direcao direcao;
        private List<Coordenadas> logCoordenadas;

        public Coordenadas(int posicaoX, int posicaoY)
        {
            this.posicaoX = posicaoX;
            this.posicaoY = posicaoY;
            logCoordenadas = new List<Coordenadas>();
        }

        public List<Coordenadas> LogCoordenadas { get => logCoordenadas; }
        public string getCoordenadas { get => "(" + posicaoX.ToString() + ", " + posicaoY.ToString() + ")"; }
        public Direcao Direcao { get => direcao; }


        public void Mover(Direcao direcao, int intencidade)
        {
            if (direcao == Direcao.Norte)
                posicaoY += intencidade;
            if (direcao == Direcao.Sul)
                posicaoY -= intencidade;
            if (direcao == Direcao.Leste)
                posicaoX += intencidade;
            if (direcao == Direcao.Oeste)
                posicaoX -= intencidade;
            GravarLog();
        }

        private void GravarLog()
        {
            Coordenadas coordenadas = new Coordenadas(posicaoX, posicaoY);
            logCoordenadas.Add(coordenadas);
        }
    }
}
