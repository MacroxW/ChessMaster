using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Chess_Cases
{
    public partial class peon : Pieza
    {

        public override void Mover(int xDest, int yDest, Pieza[,] tablero)
        {

        }
        public override List<Point> MostrarMov(Pieza[,] tablero, Point lugarEnElTablero)
        {
            List<Point> lista = new List<Point>();

            if(tablero[lugarEnElTablero.X,lugarEnElTablero.Y]._color == 'b')
            {
                if(lugarEnElTablero.Y+1 < 7 && tablero[lugarEnElTablero.X, lugarEnElTablero.Y+1] == null)
                {
                    Point pos = new Point(lugarEnElTablero.X, lugarEnElTablero.Y+1);
                    lista.Add(pos);
                }
                if(lugarEnElTablero.Y == 1)
                {
                    if(tablero[lugarEnElTablero.X, lugarEnElTablero.Y + 2 ] == null && tablero[lugarEnElTablero.X, lugarEnElTablero.Y + 1] == null)
                    {
                     Point pos = new Point(lugarEnElTablero.X, lugarEnElTablero.Y + 2);
                    lista.Add(pos);
                    }
                   
                }
            }
            else
            {
                if (lugarEnElTablero.Y > 0 && tablero[lugarEnElTablero.X, lugarEnElTablero.Y - 1] == null)
                {
                    Point pos = new Point(lugarEnElTablero.X, lugarEnElTablero.Y - 1);
                    lista.Add(pos);
                }
                if (lugarEnElTablero.Y == 6)
                {
                    if (tablero[lugarEnElTablero.X, lugarEnElTablero.Y - 2] == null && tablero[lugarEnElTablero.X, lugarEnElTablero.Y - 1] == null)
                    {
                        Point pos = new Point(lugarEnElTablero.X, lugarEnElTablero.Y - 2);
                        lista.Add(pos);
                    }

                }
            }


            return lista;
        }

        public override List<Point> MostrarComer(Pieza[,] tablero, Point lugarEnElTablero)
        {
            List<Point> lista = new List<Point>();
            List<Point> lista_de_Movimientos = new List<Point>(MostrarMov(tablero,lugarEnElTablero));
            //arriba a la izquierda
            if (tablero[lugarEnElTablero.X, lugarEnElTablero.Y]._color == 'b')
            {//arriba derecha
                if (lugarEnElTablero.Y < 7 && lugarEnElTablero.X < 7 && tablero[lugarEnElTablero.X+1,lugarEnElTablero.Y+1] != null && tablero[lugarEnElTablero.X + 1, lugarEnElTablero.Y + 1]._color != tablero[lugarEnElTablero.X, lugarEnElTablero.Y]._color)
                {
                    Point p = new Point(lugarEnElTablero.X + 1, lugarEnElTablero.Y + 1);
                    lista.Add(p);
                }
                //arriba izq
                if (lugarEnElTablero.Y < 7 && lugarEnElTablero.X > 0 && tablero[lugarEnElTablero.X -1, lugarEnElTablero.Y + 1] != null && tablero[lugarEnElTablero.X - 1, lugarEnElTablero.Y + 1]._color != tablero[lugarEnElTablero.X, lugarEnElTablero.Y]._color)
                {
                    Point p = new Point(lugarEnElTablero.X - 1, lugarEnElTablero.Y + 1);
                    lista.Add(p);
                }
            }
            else
            {
                if (lugarEnElTablero.Y > 0 && lugarEnElTablero.X < 7 && tablero[lugarEnElTablero.X + 1, lugarEnElTablero.Y - 1] != null && tablero[lugarEnElTablero.X + 1, lugarEnElTablero.Y- 1]._color != tablero[lugarEnElTablero.X, lugarEnElTablero.Y]._color)
                {
                    Point p = new Point(lugarEnElTablero.X + 1, lugarEnElTablero.Y - 1);
                    lista.Add(p);
                }
                //arriba izq
                if (lugarEnElTablero.Y > 0 && lugarEnElTablero.X > 0 && tablero[lugarEnElTablero.X - 1, lugarEnElTablero.Y - 1] != null && tablero[lugarEnElTablero.X - 1, lugarEnElTablero.Y - 1]._color != tablero[lugarEnElTablero.X, lugarEnElTablero.Y]._color)
                {
                    Point p = new Point(lugarEnElTablero.X - 1, lugarEnElTablero.Y - 1);
                    lista.Add(p);
                }
            }
            return lista;
        }

        public peon(int posY, int posX, char color, Image imagen, bool puede_saltar) : base(posY, posX, color, imagen, puede_saltar)
        {

        }


    }
}
