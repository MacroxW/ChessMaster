using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Chess_Cases
{
    public partial class reina : Pieza
    {

        public override void Mover(int xDest, int yDest, Pieza[,] tablero)
        {

        }
        public override List<Point> MostrarMov(Pieza[,] tablero, Point lugarEnElTablero)
        {
            List<Point> lista = new List<Point>();
            int i = 1;
            while (lugarEnElTablero.X + i < 8 && tablero[lugarEnElTablero.X + i, lugarEnElTablero.Y] == null)
            {
                Point pos = new Point(lugarEnElTablero.X + i, lugarEnElTablero.Y);
                lista.Add(pos);
                i++;
            }
            int z = 1;
            while (lugarEnElTablero.X - z >= 0 && tablero[lugarEnElTablero.X - z, lugarEnElTablero.Y] == null)
            {
                Point pos = new Point(lugarEnElTablero.X - z, lugarEnElTablero.Y);
                lista.Add(pos);
                z++;
            }


            i = 1;
            while (lugarEnElTablero.Y + i < 8 && tablero[lugarEnElTablero.X, lugarEnElTablero.Y + i] == null)
            {
                Point pos = new Point(lugarEnElTablero.X, lugarEnElTablero.Y + i);
                lista.Add(pos);
                i++;
            }
            z = 1;
            while (lugarEnElTablero.Y - z >= 0 && tablero[lugarEnElTablero.X, lugarEnElTablero.Y - z] == null)
            {
                Point pos = new Point(lugarEnElTablero.X, lugarEnElTablero.Y - z);
                lista.Add(pos);
                z++;
            }
            int x = 1;
            while (lugarEnElTablero.X + x < 8 && lugarEnElTablero.Y + x < 8 && tablero[lugarEnElTablero.X + x, lugarEnElTablero.Y + x] == null)
            {
                Point pos = new Point(lugarEnElTablero.X + x, lugarEnElTablero.Y + x);
                lista.Add(pos);
                x++;
            }
            x = 1;

            while (lugarEnElTablero.X - x >= 0 && lugarEnElTablero.Y + x < 8 && tablero[lugarEnElTablero.X - x, lugarEnElTablero.Y + x] == null)
            {
                Point pos = new Point(lugarEnElTablero.X - x, lugarEnElTablero.Y + x);
                lista.Add(pos);
                x++;
            }
            x = 1;
            while (lugarEnElTablero.Y - x >= 0 && lugarEnElTablero.X + x < 8 && tablero[lugarEnElTablero.X + x, lugarEnElTablero.Y - x] == null)
            {
                Point pos = new Point(lugarEnElTablero.X + x, lugarEnElTablero.Y - x);
                lista.Add(pos);
                x++;
            }
            x = 1;
            while (lugarEnElTablero.Y - x >= 0 && lugarEnElTablero.X - x >= 0 && tablero[lugarEnElTablero.X - x, lugarEnElTablero.Y - x] == null)
            {
                Point pos = new Point(lugarEnElTablero.X - x, lugarEnElTablero.Y - x);
                lista.Add(pos);
                x++;
            }
            return lista;

        }

        public override List<Point> MostrarComer(Pieza[,] tablero, Point lugarEnElTablero)
        {
            List<Point> lista = new List<Point>();
            int x = 1;
            bool encontro = false;
            //diagonal
            while (lugarEnElTablero.X + x < 8 && lugarEnElTablero.Y + x < 8 && encontro == false)
            {
                if (tablero[lugarEnElTablero.X + x, lugarEnElTablero.Y + x] != null)
                {
                    if (tablero[lugarEnElTablero.X + x, lugarEnElTablero.Y + x]._color != tablero[lugarEnElTablero.X, lugarEnElTablero.Y]._color)
                    {
                        encontro = true;
                        Point pos = new Point(lugarEnElTablero.X + x, lugarEnElTablero.Y + x);
                        lista.Add(pos);
                    }
                    else
                    {
                        encontro = true;
                    }
                }
                x++;
            }
            encontro = false;
            x = 1;
            while (lugarEnElTablero.X + x < 8 && lugarEnElTablero.Y - x >= 0 && encontro == false)
            {
                if (tablero[lugarEnElTablero.X + x, lugarEnElTablero.Y - x] != null)
                {
                    if (tablero[lugarEnElTablero.X + x, lugarEnElTablero.Y - x]._color != tablero[lugarEnElTablero.X, lugarEnElTablero.Y]._color)
                    {
                        encontro = true;
                        Point pos = new Point(lugarEnElTablero.X + x, lugarEnElTablero.Y - x);
                        lista.Add(pos);
                    }
                    else
                    {
                        encontro = true;
                    }
                }
                x++;
            }
            x = 1;
            while (lugarEnElTablero.X - x >= 0 && lugarEnElTablero.Y + x < 8 && encontro == false)
            {
                if (tablero[lugarEnElTablero.X - x, lugarEnElTablero.Y + x] != null)
                {
                    if (tablero[lugarEnElTablero.X - x, lugarEnElTablero.Y + x]._color != tablero[lugarEnElTablero.X, lugarEnElTablero.Y]._color)
                    {
                        encontro = true;
                        Point pos = new Point(lugarEnElTablero.X - x, lugarEnElTablero.Y + x);
                        lista.Add(pos);
                    }
                    else
                    {
                        encontro = true;
                    }
                }
                x++;
            }
            encontro = false;
            x = 1;
            while (lugarEnElTablero.X - x >= 0 && lugarEnElTablero.Y - x >= 0 && encontro == false)
            {
                if (tablero[lugarEnElTablero.X - x, lugarEnElTablero.Y - x] != null)
                {
                    if (tablero[lugarEnElTablero.X - x, lugarEnElTablero.Y - x]._color != tablero[lugarEnElTablero.X, lugarEnElTablero.Y]._color)
                    {
                        encontro = true;
                        Point pos = new Point(lugarEnElTablero.X - x, lugarEnElTablero.Y - x);
                        lista.Add(pos);
                    }
                    else
                    {
                        encontro = true;
                    }
                }
                x++;
            }
            // derecho
            encontro = false;
            x = 1;
            while (lugarEnElTablero.X + x < 8 && encontro == false)
            {
                if (tablero[lugarEnElTablero.X + x, lugarEnElTablero.Y] != null)
                {
                    if (tablero[lugarEnElTablero.X + x, lugarEnElTablero.Y]._color != tablero[lugarEnElTablero.X, lugarEnElTablero.Y]._color)
                    {
                        encontro = true;
                        Point pos = new Point(lugarEnElTablero.X + x, lugarEnElTablero.Y);
                        lista.Add(pos);
                    }
                    else
                    {
                        encontro = true;
                    }
                }
                x++;
            }
            encontro = false;
            x = 1;
            while (lugarEnElTablero.X - x >= 0  && encontro == false)
            {
                if (tablero[lugarEnElTablero.X - x, lugarEnElTablero.Y ] != null)
                {
                    if (tablero[lugarEnElTablero.X - x, lugarEnElTablero.Y ]._color != tablero[lugarEnElTablero.X, lugarEnElTablero.Y]._color)
                    {
                        encontro = true;
                        Point pos = new Point(lugarEnElTablero.X - x, lugarEnElTablero.Y);
                        lista.Add(pos);
                    }
                    else
                    {
                        encontro = true;
                    }
                }
                x++;
            }
            encontro = false;
            x = 1;
            while ( lugarEnElTablero.Y + x < 8 && encontro == false)
            {
                if (tablero[lugarEnElTablero.X, lugarEnElTablero.Y + x] != null)
                {
                    if (tablero[lugarEnElTablero.X, lugarEnElTablero.Y + x]._color != tablero[lugarEnElTablero.X, lugarEnElTablero.Y]._color)
                    {
                        encontro = true;
                        Point pos = new Point(lugarEnElTablero.X , lugarEnElTablero.Y + x);
                        lista.Add(pos);
                    }
                    else
                    {
                        encontro = true;
                    }
                }
                x++;
            }
            encontro = false;
            x = 1;
            while (lugarEnElTablero.Y - x >= 0 && encontro == false)
            {
                if (tablero[lugarEnElTablero.X , lugarEnElTablero.Y - x] != null)
                {
                    if (tablero[lugarEnElTablero.X , lugarEnElTablero.Y - x]._color != tablero[lugarEnElTablero.X, lugarEnElTablero.Y]._color)
                    {
                        encontro = true;
                        Point pos = new Point(lugarEnElTablero.X , lugarEnElTablero.Y - x);
                        lista.Add(pos);
                    }
                    else
                    {
                        encontro = true;
                    }
                }
                x++;
            }
            return lista;
        }

        public reina(int posY, int posX, char color, Image imagen, bool puede_saltar) : base(posY, posX, color, imagen, puede_saltar)
        {

        }


    }
}





