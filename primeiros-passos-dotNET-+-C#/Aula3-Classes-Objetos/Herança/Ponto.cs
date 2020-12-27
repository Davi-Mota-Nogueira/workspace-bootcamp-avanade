using System;

namespace Classes_Objetos.Herança
{
    public class Ponto
    {
        public int x, y;
        private int distancia;
        public Ponto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        protected void CalcularDistancia()
        {
            distancia = x - y;
            if (distancia < 0)
                distancia *= -1;
            Console.WriteLine($"A distancia entre x e y é de {distancia}");
        }

        private void CalcularDistancia2()
        {
            //Faz alguma outra coisa
        }
        public virtual void CalcularDistancia3()
        {
            //Faz alguma outra coisa
        }
    }
}