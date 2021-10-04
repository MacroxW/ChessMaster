using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess_Cases;
using System.Drawing;
namespace Chess_Cases
{
    public partial class juegoAjedrez
    {
        private Pieza[,] _tablero = new Pieza[8, 8];
        private char _turno = 'b';
        private bool _fin;
        private Point _desde;
        private Point _hasta;
        public string PiezaSelected;

        
        public juegoAjedrez()
        {


        }

        public Pieza[,] tablero
        {
            get
            {
                return _tablero;
            }
            set
            {
                _tablero = value;
            }
        }

        public char Turno { get => _turno; set => _turno = value; }
        public bool Fin { get => _fin; set => _fin = value; }
        public Point Desde { get => _desde; set => _desde = value; }
        public Point Hasta { get => _hasta; set => _hasta = value; }

        public void agregar_pieza(Pieza unaPieza)
        {
            _tablero[unaPieza._posX, unaPieza._posY] = unaPieza;


        }

        private bool EsMovimientoValido()
        {
            bool retorno = false;
            List<Point> MovimientosValidos;
            List<Point> MovimientosValidosComer;
            Pieza pieza = tablero[Desde.X, Desde.Y];
            MovimientosValidos = pieza.MostrarMov(tablero, Desde);
            MovimientosValidosComer = pieza.MostrarComer(tablero, Desde);
            MovimientosValidos.AddRange(MovimientosValidosComer);
            int i = 0;
             
            if (MovimientosValidos.Count() != 0)
            {
                while (i < MovimientosValidos.Count() - 1 && MovimientosValidos[i] != Hasta)
                {
                    i++;
                }
                if (MovimientosValidos[i] == Hasta)
                {
                    //si el movimiento a dode se quiere mover esta en movimientos validos
                   
                    if(Turno == 'b' /*&& CheckJaqueReyBlanco() == false*/)
                    {
                        retorno = true;
                    }
                    if (Turno == 'n' /* && CheckJaqueReyNegro() == false*/)
                    {
                        retorno = true;
                    }

                }
            }
            return retorno;
        }
        private void CambiarJugador()
        {
            if (_turno == 'b')
            {
                _turno = 'n';
            }
            else
            {
                {
                    _turno = 'b';
                }
            }
        }
        private List<Point> BuscarPiezaJaqueBlanco()
        {
            Point p = new Point();
            Point posReyBlanco = new Point();
            List<Point> PiezaJaque = new List<Point>();
            List<Point> ListaMovNegra = new List<Point>();
            List<Point> ComNeg = new List<Point>();
            Pieza[,] tmpTablero = new Pieza[8, 8];
            int z = 0;

            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    tmpTablero[x, y] = tablero[x, y];

                }
            }
            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {

                    if (tmpTablero[x, y] != null)
                    {  
                        if (tmpTablero[x, y]._color == 'b')
                        {
                            if (tmpTablero[x, y] is rey)
                            {
                                posReyBlanco = new Point(x, y);
                            }
                            else
                            {

                            }

                        }

                    }

                }

            }
            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {

                    if (tmpTablero[x, y] != null)
                    {
                        if (tmpTablero[x, y]._color == 'n')
                        {
                            if (tmpTablero[x, y] is peon)
                            {
                                p = new Point(x, y);
                                Pieza pieza = tablero[p.X, p.Y];
                                ListaMovNegra = pieza.MostrarComer(tablero, p);
                            }
                            else
                            {
                                p = new Point(x, y);
                                Pieza pieza = tablero[p.X, p.Y];
                                ListaMovNegra = pieza.MostrarMov(tablero, p);
                                ComNeg = pieza.MostrarComer(tablero, p);
                                
                                while(ComNeg[z]!= null)
                                {
                                    ListaMovNegra.Add(ComNeg[z]);
                                    z++;
                                }
                            }
                        }
                    }
                    z = 0;
                    while(ListaMovNegra[z] != null)
                    {
                        if(ListaMovNegra[z] == posReyBlanco)
                        {
                            PiezaJaque.Add(p);
                        }
                    }
                }

            }

            return PiezaJaque;
        }
        private bool CheckJaqueReyBlanco()
        {
            Point p = new Point();
            bool Jaque = false;
            Point posReyBlanco = new Point();
            List<Point> comerNegras = new List<Point>();
            Pieza[,] tmpTablero = new Pieza[8, 8];
         
            
            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    tmpTablero[x, y] = tablero[x, y];

                }
            }

            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {

                    if (tmpTablero[x, y] != null)
                    {
                        if (tmpTablero[x, y]._color == 'n')
                        {
                             p = new Point(x, y);
                             comerNegras.AddRange(tmpTablero[x, y].MostrarComer(tmpTablero, p));
                     
                        }
                        if (tmpTablero[x, y]._color == 'b')
                        {
                            if (tmpTablero[x, y] is rey)
                            {
                                posReyBlanco = new Point(x, y);
                            }
                            else
                            {
                               
                            }

                        }

                    }

                }

            }


            if (comerNegras.Contains(posReyBlanco) && Turno == 'b')
            {
                Jaque = true;
            }
            return Jaque;
        }
        private bool CheckJaqueReyNegro()
        {
            Point p = new Point();
            bool Jaque = false;
            Point posReyNegro = new Point();
            List<Point> comerBlancas = new List<Point>();
            Pieza[,] tmpTablero = new Pieza[8, 8];
           
            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    tmpTablero[x, y] = tablero[x, y];

                }
            }
                    for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {

                    if (tmpTablero[x, y] != null)
                    {
                        if (tmpTablero[x, y]._color == 'b')
                        {
                            p = new Point(x, y);
                            comerBlancas.AddRange(tmpTablero[x, y].MostrarComer(tmpTablero, p));

                        }
                        if (tmpTablero[x, y]._color == 'n')
                        {
                            if (tmpTablero[x, y] is rey)
                            {
                                posReyNegro = new Point(x, y);
                            }
                            else
                            {

                            }

                        }

                    }

                }

            }




            if (comerBlancas.Contains(posReyNegro) && Turno == 'b')
            {
                Jaque = true;
            }
            return Jaque;
        }
        public bool PudeRealizarJugada()
        {
            //realiza la jugada
            bool pude = false;
            if (tablero[Desde.X, Desde.Y] != null && tablero[Desde.X,Desde.Y]._color == Turno)
            {
                if (EsMovimientoValido())
                {
                    //la pieza se translada a la nueva pos y la anterior queda sin nada
                    _tablero[Hasta.X, Hasta.Y] = _tablero[Desde.X, Desde.Y];
                    _tablero[Desde.X, Desde.Y] = null;
                    pude = true;
                   // CheckJaque();
                    CambiarJugador();
                }
              

            }
         
            return pude;
        }

        public char JaqueMate()
        {
            char equipo = ' ';
            bool negro = true, blanco = true;
            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    if (tablero[x, y] != null)
                    {
                        if(tablero[x, y] is rey)
                        {
                            if (tablero[x, y]._color == 'n')
                            {
                                negro = false;
                                equipo = 'n';
                            }
                            else
                            {
                                blanco = false;
                                equipo = 'b';
                            }
                        }
                       
                    }

                }
            }
            if(negro == false && blanco == false)
            {
                return ' ';
            }

            return equipo;
        }
    }
}
