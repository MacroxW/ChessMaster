using System.Collections.Generic;
using System.Drawing;

namespace Chess_Cases
{
    public partial class caballo : Pieza
    {

        public override void Mover(int xDest, int yDest, Pieza[,] tablero)
        {

        }
        public override List<Point> MostrarMov(Pieza[,] tablero, Point lugarEnElTablero)
        {
            List<Point> lista = new List<Point>();
            Point pos = new Point();
            if (lugarEnElTablero.X - 2 >= 0 && lugarEnElTablero.Y - 1 >= 0  && tablero[lugarEnElTablero.X-2  , lugarEnElTablero.Y - 1] == null)
            {
                pos = new Point(lugarEnElTablero.X - 2, lugarEnElTablero.Y - 1);
                lista.Add(pos);
            }
            if (lugarEnElTablero.X - 2 >= 0 && lugarEnElTablero.Y + 1 < 8 && tablero[lugarEnElTablero.X - 2, lugarEnElTablero.Y + 1] == null)
            {
                pos = new Point(lugarEnElTablero.X - 2, lugarEnElTablero.Y + 1);
                lista.Add(pos);
            }
            if (lugarEnElTablero.X - 1 >= 0 && lugarEnElTablero.Y + 2 < 8 && tablero[lugarEnElTablero.X - 1, lugarEnElTablero.Y + 2] == null)
            {
                pos = new Point(lugarEnElTablero.X - 1, lugarEnElTablero.Y + 2);
                lista.Add(pos);
            }
            if (lugarEnElTablero.X + 1 < 8 && lugarEnElTablero.Y + 2 < 8 && tablero[lugarEnElTablero.X + 1, lugarEnElTablero.Y + 2] == null)
            {
                pos = new Point(lugarEnElTablero.X  + 1 , lugarEnElTablero.Y + 2);
                lista.Add(pos);
            }
            if (lugarEnElTablero.X + 2 < 8 && lugarEnElTablero.Y + 1 < 8 && tablero[lugarEnElTablero.X + 2, lugarEnElTablero.Y + 1] == null)
            {
                pos = new Point(lugarEnElTablero.X + 2, lugarEnElTablero.Y + 1);
                lista.Add(pos);
            }
            if (lugarEnElTablero.X + 2 < 8 && lugarEnElTablero.Y - 1 >= 0 && tablero[lugarEnElTablero.X + 2, lugarEnElTablero.Y - 1] == null)
            {
                pos = new Point(lugarEnElTablero.X + 2, lugarEnElTablero.Y - 1);
                lista.Add(pos);
            }
            if (lugarEnElTablero.X + 1 < 8 && lugarEnElTablero.Y - 2 >= 0 && tablero[lugarEnElTablero.X + 1, lugarEnElTablero.Y - 2] == null)
            {
                pos = new Point(lugarEnElTablero.X + 1, lugarEnElTablero.Y - 2);
                lista.Add(pos);
            }
            if (lugarEnElTablero.X - 1 >= 0 && lugarEnElTablero.Y - 2 >= 0 && tablero[lugarEnElTablero.X - 1, lugarEnElTablero.Y - 2] == null)
            {
                pos = new Point(lugarEnElTablero.X - 1, lugarEnElTablero.Y - 2);
                lista.Add(pos);

            }
            return lista;

        }

        public override List<Point> MostrarComer(Pieza[,] tablero, Point lugarEnElTablero)
        {
            List<Point> lista = new List<Point>();
            Point pos = new Point();
            if (lugarEnElTablero.X - 2 >= 0 && lugarEnElTablero.Y - 1 >= 0)
            {
                if (tablero[lugarEnElTablero.X - 2, lugarEnElTablero.Y - 1] != null)
                {
                    if (tablero[lugarEnElTablero.X - 2, lugarEnElTablero.Y - 1]._color != tablero[lugarEnElTablero.X, lugarEnElTablero.Y]._color)
                    {
                        pos = new Point(lugarEnElTablero.X - 2, lugarEnElTablero.Y - 1);
                        lista.Add(pos);
                    }
                }
            }
            if (lugarEnElTablero.X - 2 >= 0 && lugarEnElTablero.Y + 1 < 8)
            {
                if (tablero[lugarEnElTablero.X - 2, lugarEnElTablero.Y + 1] != null)
                {
                    if (tablero[lugarEnElTablero.X - 2, lugarEnElTablero.Y + 1]._color != tablero[lugarEnElTablero.X, lugarEnElTablero.Y]._color)
                    {
                        pos = new Point(lugarEnElTablero.X - 2, lugarEnElTablero.Y + 1);
                        lista.Add(pos);
                    }
                }
            }
            if (lugarEnElTablero.X - 1 >= 0 && lugarEnElTablero.Y + 2 < 8)
            {
                if (tablero[lugarEnElTablero.X - 1, lugarEnElTablero.Y + 2] != null)
                {
                    if (tablero[lugarEnElTablero.X - 1, lugarEnElTablero.Y + 2]._color != tablero[lugarEnElTablero.X, lugarEnElTablero.Y]._color)
                    {
                        pos = new Point(lugarEnElTablero.X - 1, lugarEnElTablero.Y + 2);
                        lista.Add(pos);
                    }
                }
            }
            if (lugarEnElTablero.X + 1 < 8 && lugarEnElTablero.Y + 2 < 8)
            {
                if (tablero[lugarEnElTablero.X + 1, lugarEnElTablero.Y + 2] != null)
                {
                    if (tablero[lugarEnElTablero.X + 1, lugarEnElTablero.Y + 2]._color != tablero[lugarEnElTablero.X, lugarEnElTablero.Y]._color)
                    {
                        pos = new Point(lugarEnElTablero.X + 1, lugarEnElTablero.Y + 2);
                        lista.Add(pos);
                    }
                }
            }
            if (lugarEnElTablero.X + 2 < 8 && lugarEnElTablero.Y + 1 < 8) 
                {
                if (tablero[lugarEnElTablero.X + 2, lugarEnElTablero.Y + 1] != null)
                {
                    if (tablero[lugarEnElTablero.X + 2, lugarEnElTablero.Y + 1]._color != tablero[lugarEnElTablero.X, lugarEnElTablero.Y]._color)
                    {
                        pos = new Point(lugarEnElTablero.X + 2, lugarEnElTablero.Y + 1);
                        lista.Add(pos);
                    }
                }
            }
            if (lugarEnElTablero.X + 2 < 8 && lugarEnElTablero.Y - 1 >= 0)
            {
                if (tablero[lugarEnElTablero.X + 2, lugarEnElTablero.Y - 1] != null)
                {
                    if (tablero[lugarEnElTablero.X + 2, lugarEnElTablero.Y - 1]._color != tablero[lugarEnElTablero.X, lugarEnElTablero.Y]._color)
                    {
                        pos = new Point(lugarEnElTablero.X + 2, lugarEnElTablero.Y - 1);
                        lista.Add(pos);
                    }
                }
            }
            if (lugarEnElTablero.X + 1 < 8 && lugarEnElTablero.Y - 2 >= 0)
            {
                if(tablero[lugarEnElTablero.X + 1, lugarEnElTablero.Y - 2] != null)
                {
                    if (tablero[lugarEnElTablero.X + 1, lugarEnElTablero.Y - 2]._color != tablero[lugarEnElTablero.X, lugarEnElTablero.Y]._color)
                    {
                        pos = new Point(lugarEnElTablero.X + 1, lugarEnElTablero.Y - 2);
                        lista.Add(pos);
                    }
                }
            }
            if (lugarEnElTablero.X - 1 >= 0 && lugarEnElTablero.Y - 2 >= 0 )
            {
                if (tablero[lugarEnElTablero.X - 1, lugarEnElTablero.Y - 2] != null)
                {
                    if (tablero[lugarEnElTablero.X - 1, lugarEnElTablero.Y - 2]._color != tablero[lugarEnElTablero.X, lugarEnElTablero.Y]._color)
                    {
                        pos = new Point(lugarEnElTablero.X - 1, lugarEnElTablero.Y - 2);
                        lista.Add(pos);
                    }
                }
            }
            return lista;
        }

        public caballo(int posY, int posX, char color, Image imagen, bool puede_saltar) : base(posY, posX, color, imagen, puede_saltar)
        {

        }


    }
}
