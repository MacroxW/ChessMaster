using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Chess_Cases
{
    public abstract class Pieza
    {
        public int _posX;
        public int _posY;

        // 'b' , 'n'
        public char _color;
        public Image _imagen;
        public bool _puede_saltar;

        protected Pieza(int posX, int posY, char color, Image imagen, bool puede_saltar)
        {
            _posY = posY;
            _posX = posX;
            _color = color;
            _imagen = imagen;
            _puede_saltar = puede_saltar;
        }

        public abstract List<Point> MostrarComer(Pieza[,] tablero, Point lugarEnElTablero);
        public abstract void Mover(int xDest, int yDest, Pieza[,] tablero);
        public abstract List<Point> MostrarMov(Pieza[,] tablero, Point lugarEnElTablero);
    }
}
