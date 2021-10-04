using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Chess_Cases
{
    public partial class rey : Pieza
    {
        public override void Mover(int xDest, int yDest, Pieza[,] tablero)
        {

        }
        public override List<Point> MostrarMov(Pieza[,] tablero, Point lugarEnElTablero)
        {
            List<Point> lista = new List<Point>();
           Point pos = new Point();
            if (lugarEnElTablero.X - 1 >= 0 && lugarEnElTablero.Y - 1 >= 0 && tablero[lugarEnElTablero.X - 1, lugarEnElTablero.Y - 1] == null)
            {
            pos = new Point(lugarEnElTablero.X - 1, lugarEnElTablero.Y - 1);
                lista.Add(pos);
            }
            if (lugarEnElTablero.X + 1 < 8 && lugarEnElTablero.Y - 1 >= 0 && tablero[lugarEnElTablero.X + 1, lugarEnElTablero.Y - 1] == null)
            {
                pos = new Point(lugarEnElTablero.X + 1, lugarEnElTablero.Y - 1);
                lista.Add(pos);
            }
            if (lugarEnElTablero.X - 1 >= 0 && lugarEnElTablero.Y + 1 < 8 && tablero[lugarEnElTablero.X - 1, lugarEnElTablero.Y + 1] == null)
            {
                pos = new Point(lugarEnElTablero.X - 1, lugarEnElTablero.Y + 1);
                lista.Add(pos);
            }
            if (lugarEnElTablero.X + 1 < 8 && lugarEnElTablero.Y + 1 < 8 && tablero[lugarEnElTablero.X + 1, lugarEnElTablero.Y + 1] == null)
            {
                pos = new Point(lugarEnElTablero.X + 1, lugarEnElTablero.Y + 1);
                lista.Add(pos);
            }
            if (lugarEnElTablero.X - 1 >= 0 && tablero[lugarEnElTablero.X - 1, lugarEnElTablero.Y] == null)
            {
                pos = new Point(lugarEnElTablero.X - 1, lugarEnElTablero.Y);
                lista.Add(pos);
            }
            if (lugarEnElTablero.X + 1 < 8 && tablero[lugarEnElTablero.X + 1, lugarEnElTablero.Y] == null)
            {
                pos = new Point(lugarEnElTablero.X + 1, lugarEnElTablero.Y);
                lista.Add(pos);
            }
            if (lugarEnElTablero.Y - 1 >= 0 && tablero[lugarEnElTablero.X, lugarEnElTablero.Y - 1] == null)
            {
                pos = new Point(lugarEnElTablero.X, lugarEnElTablero.Y - 1);
                lista.Add(pos);
            }
            if (lugarEnElTablero.Y + 1 < 8 && tablero[lugarEnElTablero.X , lugarEnElTablero.Y + 1] == null)
            {
                pos = new Point(lugarEnElTablero.X, lugarEnElTablero.Y + 1);
                lista.Add(pos);
            }
            return lista;

        }

        public override List<Point> MostrarComer(Pieza[,] tablero, Point lugarEnElTablero)
        {
            List<Point> lista = new List<Point>();
            Point pos = new Point();
            if (lugarEnElTablero.X - 1 >= 0 && lugarEnElTablero.Y - 1 >= 0 && tablero[lugarEnElTablero.X - 1, lugarEnElTablero.Y - 1] != null && tablero[lugarEnElTablero.X - 1, lugarEnElTablero.Y - 1]._color != tablero[lugarEnElTablero.X, lugarEnElTablero.Y]._color )
            {
                pos = new Point(lugarEnElTablero.X - 1, lugarEnElTablero.Y - 1);
                lista.Add(pos);
            }
            if (lugarEnElTablero.X + 1 < 8 && lugarEnElTablero.Y - 1 >= 0 && tablero[lugarEnElTablero.X + 1, lugarEnElTablero.Y - 1] != null && tablero[lugarEnElTablero.X + 1, lugarEnElTablero.Y - 1]._color != tablero[lugarEnElTablero.X, lugarEnElTablero.Y]._color)
            {
                pos = new Point(lugarEnElTablero.X + 1, lugarEnElTablero.Y - 1);
                lista.Add(pos);
            }
            if (lugarEnElTablero.X - 1 >= 0 && lugarEnElTablero.Y + 1 < 8 && tablero[lugarEnElTablero.X - 1, lugarEnElTablero.Y + 1] != null && tablero[lugarEnElTablero.X - 1, lugarEnElTablero.Y + 1]._color != tablero[lugarEnElTablero.X, lugarEnElTablero.Y]._color)
            {
                pos = new Point(lugarEnElTablero.X - 1, lugarEnElTablero.Y + 1);
                lista.Add(pos);
            }
            if (lugarEnElTablero.X + 1 < 8 && lugarEnElTablero.Y + 1 < 8 && tablero[lugarEnElTablero.X + 1, lugarEnElTablero.Y + 1] != null && tablero[lugarEnElTablero.X + 1, lugarEnElTablero.Y + 1]._color != tablero[lugarEnElTablero.X, lugarEnElTablero.Y]._color)
            {
                pos = new Point(lugarEnElTablero.X + 1, lugarEnElTablero.Y + 1);
                lista.Add(pos);
            }
            if (lugarEnElTablero.X - 1 >= 0 && tablero[lugarEnElTablero.X - 1, lugarEnElTablero.Y] != null && tablero[lugarEnElTablero.X - 1, lugarEnElTablero.Y ]._color != tablero[lugarEnElTablero.X, lugarEnElTablero.Y]._color)
            {
                pos = new Point(lugarEnElTablero.X - 1, lugarEnElTablero.Y);
                lista.Add(pos);
            }
            if (lugarEnElTablero.X + 1 < 8 && tablero[lugarEnElTablero.X + 1, lugarEnElTablero.Y] != null && tablero[lugarEnElTablero.X + 1, lugarEnElTablero.Y]._color != tablero[lugarEnElTablero.X, lugarEnElTablero.Y]._color)
            {
                pos = new Point(lugarEnElTablero.X + 1, lugarEnElTablero.Y);
                lista.Add(pos);
            }
            if (lugarEnElTablero.Y - 1 >= 0 && tablero[lugarEnElTablero.X, lugarEnElTablero.Y - 1] != null && tablero[lugarEnElTablero.X , lugarEnElTablero.Y - 1]._color != tablero[lugarEnElTablero.X, lugarEnElTablero.Y]._color)
            {
                pos = new Point(lugarEnElTablero.X, lugarEnElTablero.Y - 1);
                lista.Add(pos);
            }
            if (lugarEnElTablero.Y + 1 < 8 && tablero[lugarEnElTablero.X, lugarEnElTablero.Y + 1] != null && tablero[lugarEnElTablero.X , lugarEnElTablero.Y + 1]._color != tablero[lugarEnElTablero.X, lugarEnElTablero.Y]._color)
            {
                pos = new Point(lugarEnElTablero.X, lugarEnElTablero.Y + 1);
                lista.Add(pos);
            }
            return lista;
        }

        public rey(int posY, int posX, char color, Image imagen, bool puede_saltar) : base(posY, posX, color, imagen, puede_saltar)
        {

        }

    }
}
