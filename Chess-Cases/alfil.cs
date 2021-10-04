using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Chess_Cases
{
    public partial class alfil : Pieza
    {

        public override void Mover(int xDest, int yDest, Pieza[,] tablero)
        {

        }
        public override List<Point> MostrarMov(Pieza[,] tablero, Point lugarEnElTablero)
        {
            List<Point> lista = new List<Point>();
            int x = 1;
            while (lugarEnElTablero.X + x < 8 && lugarEnElTablero.Y + x < 8 && tablero[lugarEnElTablero.X + x, lugarEnElTablero.Y + x] == null )
            {
                Point pos = new Point(lugarEnElTablero.X + x, lugarEnElTablero.Y + x);
                lista.Add(pos);
                x++;
            }
            x = 1;

            while (lugarEnElTablero.X - x >= 0 &&  lugarEnElTablero.Y + x < 8 &&  tablero[lugarEnElTablero.X - x, lugarEnElTablero.Y + x] == null )
            {
                Point pos = new Point(lugarEnElTablero.X - x, lugarEnElTablero.Y + x);
                lista.Add(pos);
                x++;
            }
            x = 1;
            while ( lugarEnElTablero.Y - x >= 0 && lugarEnElTablero.X + x < 8 && tablero[lugarEnElTablero.X + x, lugarEnElTablero.Y - x] == null )
            {
                Point pos = new Point(lugarEnElTablero.X + x, lugarEnElTablero.Y - x);
                lista.Add(pos);
                x++;
            }
            x = 1;
            while ( lugarEnElTablero.Y - x >= 0  && lugarEnElTablero.X - x >= 0 && tablero[lugarEnElTablero.X - x, lugarEnElTablero.Y - x] == null)
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
            while (lugarEnElTablero.X + x < 8 && lugarEnElTablero.Y + x < 8 && encontro == false )
            {
                if (tablero[lugarEnElTablero.X + x, lugarEnElTablero.Y + x] != null) 
                {
                    if (tablero[lugarEnElTablero.X + x, lugarEnElTablero.Y + x]._color != tablero[lugarEnElTablero.X, lugarEnElTablero.Y]._color)
                    {
                        encontro = true;
                        Point pos = new Point(lugarEnElTablero.X + x, lugarEnElTablero.Y + x);
                        lista.Add(pos);
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
                }
                x++;
            }



            return lista;
        }

        public alfil(int posY, int posX, char color, Image imagen, bool puede_saltar) : base(posY, posX, color, imagen, puede_saltar)
        {

        }


    }
}
