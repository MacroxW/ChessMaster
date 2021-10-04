using Chess_Cases;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ChessMaster
{

    public partial class FormTablero : Form
    {
        public char color;
        public string ficha;
        // 

        juegoAjedrez juego = new juegoAjedrez();

        public FormTablero()
        {
            InitializeComponent();
        }



        private void inicializarJuego()
        {
            btnJugar.Enabled = false;

            juego.Turno = 'b';
            juego.Fin = false;

            if (juego.Turno == 'b')
            {
                lblTurno.Text = "Blancas";
            }
            else
            {
                lblTurno.Text = "Negras";
            }

            //----------------agregando piezas Negras------------


            juego.agregar_pieza(new torre(0, 7, 'n', Properties.Resources.nTorre, false));
            juego.agregar_pieza(new caballo(1, 7, 'n', Properties.Resources.nCaballo, true));
            juego.agregar_pieza(new alfil(2, 7, 'n', Properties.Resources.nAlfil, false));
            juego.agregar_pieza(new reina(3, 7, 'n', Properties.Resources.nReina, false));
            juego.agregar_pieza(new rey(4, 7, 'n', Properties.Resources.nRey, false));
            juego.agregar_pieza(new alfil(5, 7, 'n', Properties.Resources.nAlfil, false));
            juego.agregar_pieza(new caballo(6, 7, 'n', Properties.Resources.nCaballo, true));
            juego.agregar_pieza(new torre(7, 7, 'n', Properties.Resources.nTorre, false));


            for (int i = 0; i < 8; i++)
            {
                juego.agregar_pieza(new peon(i, 6, 'n', Properties.Resources.nPeon, false));
            }


            // Negras: Asignando imagenes a la imagen de la pieza que está en esa posicion 
            
            A8.Image = juego.tablero[0, 7]._imagen;
            B8.Image = juego.tablero[1, 7]._imagen;
            C8.Image = juego.tablero[2, 7]._imagen;
            D8.Image = juego.tablero[3, 7]._imagen;
            E8.Image = juego.tablero[4, 7]._imagen;
            F8.Image = juego.tablero[5, 7]._imagen;
            G8.Image = juego.tablero[6, 7]._imagen;
            H8.Image = juego.tablero[7, 7]._imagen;

            A7.Image = juego.tablero[0, 6]._imagen;
            B7.Image = juego.tablero[1, 6]._imagen;
            C7.Image = juego.tablero[2, 6]._imagen;
            D7.Image = juego.tablero[3, 6]._imagen;
            E7.Image = juego.tablero[4, 6]._imagen;
            F7.Image = juego.tablero[5, 6]._imagen;
            G7.Image = juego.tablero[6, 6]._imagen;
            H7.Image = juego.tablero[7, 6]._imagen;

            //----------------agregando piezas Blancas------------

            juego.agregar_pieza(new torre(0, 0, 'b', Properties.Resources.bTorre, false));
            juego.agregar_pieza(new caballo(1, 0, 'b', Properties.Resources.bCaballo, true));
            juego.agregar_pieza(new alfil(2, 0, 'b', Properties.Resources.bAlfil, false));
            juego.agregar_pieza(new reina(3, 0, 'b', Properties.Resources.bReina, false));
            juego.agregar_pieza(new rey(4, 0, 'b', Properties.Resources.bRey, false));
            juego.agregar_pieza(new alfil(5, 0, 'b', Properties.Resources.bAlfil, false));
            juego.agregar_pieza(new caballo(6, 0, 'b', Properties.Resources.bCaballo, true));
            juego.agregar_pieza(new torre(7, 0, 'b', Properties.Resources.bTorre, false));

            for (int i = 0; i < 8; i++)
            {
                juego.agregar_pieza(new peon(i, 1, 'b', Properties.Resources.bPeon, false));
            }

            // Blancas: Asignando imagenes a la imagen de la pieza que está en esa posicion 

            A1.Image = juego.tablero[0, 0]._imagen;
            B1.Image = juego.tablero[1, 0]._imagen;
            C1.Image = juego.tablero[2, 0]._imagen;
            D1.Image = juego.tablero[3, 0]._imagen;
            E1.Image = juego.tablero[4, 0]._imagen;
            F1.Image = juego.tablero[5, 0]._imagen;
            G1.Image = juego.tablero[6, 0]._imagen;
            H1.Image = juego.tablero[7, 0]._imagen;

            A2.Image = juego.tablero[0, 1]._imagen;
            B2.Image = juego.tablero[1, 1]._imagen;
            C2.Image = juego.tablero[2, 1]._imagen;
            D2.Image = juego.tablero[3, 1]._imagen;
            E2.Image = juego.tablero[4, 1]._imagen;
            F2.Image = juego.tablero[5, 1]._imagen;
            G2.Image = juego.tablero[6, 1]._imagen;
            H2.Image = juego.tablero[7, 1]._imagen;

        }
        private void CambiarTurno()
        {
            if (juego.Turno == 'b')
            {
                lblTurno.Text = "Blancas";
            }
            else
            {
                lblTurno.Text = "Negras";
            }
        }
        private void LimpiarImagen(int X, int Y)
        {
            PictureBox pb = TraerPictuboxDelTablero(X, Y);
            pb.Image = null;
            pb.BackColor = Color.Transparent;
           
        }
        private void BackGroundTransparent(int X, int Y)
        {
            PictureBox pb = TraerPictuboxDelTablero(X, Y);
            pb.BackColor = Color.Transparent;
        }
        private void ActualizarImagen(Point dest)
        {
            PictureBox pb = TraerPictuboxDelTablero(dest.X, dest.Y);
            pb.Image = juego.tablero[dest.X, dest.Y]._imagen;
            pb.Tag = null;
         
        }
        private void RealizarJugada(Point anterior, Point dest)
        {
            LimpiarImagen(anterior.X, anterior.Y);
            ActualizarImagen(dest);

        }

        private void BtnJugar_Click(object sender, EventArgs e)
        {
            inicializarJuego();
            lblTituloTurno.Text = "Turno:";

        }


        public int BuscarNum(string letra)
        {
            int numDevolver;
            switch (letra)
            {
                case "A":
                    numDevolver = 0;
                    break;
                case "B":
                    numDevolver = 1;
                    break;
                case "C":
                    numDevolver = 2;
                    break;
                case "D":
                    numDevolver = 3;
                    break;
                case "E":
                    numDevolver = 4;
                    break;
                case "F":
                    numDevolver = 5;
                    break;
                case "G":
                    numDevolver = 6;
                    break;
                case "H":
                    numDevolver = 7;
                    break;
                default:
                    MessageBox.Show("error interno. codigo BNUM");
                    numDevolver = 0;
                    break;
            }
            return numDevolver;
        }
        private Point ObtenerCoordXImagen(string nomImg)
        {

            string xStr;//una letra..
            int x, y;
            xStr = nomImg.Substring(0, 1).ToUpper();

            y = Convert.ToInt32(nomImg.Substring(1, 1));
            y = y - 1 + 1 - 1;
            x = BuscarNum(xStr);
            Point devolver = new Point(x, y);
            return devolver;

        }

        List<Point> movimientosCache = new List<Point>();
        private void MostrarPosiblesMovimientos(bool mostrar)
        {
            List<Point> movimientos = new List<Point>();
            Image imagen = null;
            int algo = 0;

            if (mostrar)
            {
                algo = 1;
                imagen = ChessMaster.Properties.Resources.punto;
                movimientos = juego.tablero[juego.Desde.X, juego.Desde.Y].MostrarMov(juego.tablero, juego.Desde);
                movimientosCache = new List<Point>(movimientos);
            }
            else if (!mostrar)
            {
                algo = 0;
                imagen = null;
                movimientos = new List<Point>(movimientosCache);

                movimientos.Remove(juego.Hasta);
            }

            for (int i = 0; i < movimientos.Count(); i++)
            {
                PictureBox pb = TraerPictuboxDelTablero(movimientos[i].Y, movimientos[i].Y);
                pb.Image = imagen;
                pb.Tag = algo;
                
            }

        }

        List<Point> comerCache = new List<Point>();
        private void MostrarPosibleComer(bool mostrar = true)
        {
            List<Point> movimientos = new List<Point>();
            var imagen = Color.Transparent;

            if (mostrar)
            {
                imagen = Color.GreenYellow;
                movimientos = juego.tablero[juego.Desde.X, juego.Desde.Y].MostrarComer(juego.tablero, juego.Desde);
                comerCache = new List<Point>(movimientos);
            }
            else if (!mostrar)
            {
                movimientos = new List<Point>(comerCache);
            }

            for (int i = 0; i < movimientos.Count(); i++)
            {
                PictureBox pb = TraerPictuboxDelTablero(movimientos[i].Y, movimientos[i].Y);
                pb.BackColor = imagen;
            }

        }
        bool selected = false;

        private void pb_click(object sender, EventArgs e)
        {
            char jaque = ' ';
            //seleccionar una foto
            if (!selected)
            {
                if (((PictureBox)sender).Image != null)
                {

                    juego.Desde = ObtenerCoordXImagen(((PictureBox)sender).Name.ToString());
                    if (juego.tablero[juego.Desde.X, juego.Desde.Y]._color == juego.Turno)
                    {
                        ((PictureBox)sender).BackColor = Color.Chocolate;
                        selected = true;
                        MostrarPosiblesMovimientos(true);
                        MostrarPosibleComer(true);
                    }

                }

            }
            else
            {
                //if - deseleccionar una foto
                if (((PictureBox)sender).BackColor == Color.Chocolate)
                {
                    selected = false;
                    ((PictureBox)sender).BackColor = Color.Transparent;
                    MostrarPosiblesMovimientos(false);
                    MostrarPosibleComer(false);

                }//cambiar ficha
                if (((PictureBox)sender).Tag == null && ((PictureBox)sender).BackColor == Color.Transparent)
                {
                    Point cosa = new Point();
                    cosa = ObtenerCoordXImagen(((PictureBox)sender).Name);
                    if (juego.tablero[cosa.X, cosa.Y] != null)
                    {

                        MostrarPosiblesMovimientos(false);
                        MostrarPosibleComer(false);
                        BackGroundTransparent(juego.Desde.X, juego.Desde.Y);

                        juego.Desde = ObtenerCoordXImagen(((PictureBox)sender).Name.ToString());

                        if (juego.tablero[juego.Desde.X, juego.Desde.Y]._color == juego.Turno)
                        {
                            ((PictureBox)sender).BackColor = Color.Chocolate;
                            selected = true;
                            MostrarPosiblesMovimientos(true);
                            MostrarPosibleComer(true);
                        }
                    }

                }
                else
                {
                    //realiza jugada
                    juego.Hasta = ObtenerCoordXImagen(((PictureBox)sender).Name.ToString());

                    if (juego.PudeRealizarJugada())
                    {
                        selected = false;
                        RealizarJugada(juego.Desde, juego.Hasta);
                        MostrarPosiblesMovimientos(false);
                        MostrarPosibleComer(false);

                        jaque = juego.JaqueMate();
                        if (jaque == ' ')
                        {
                            if (juego.Hasta.Y == 7 && juego.tablero[juego.Hasta.X, juego.Hasta.Y] is peon && juego.tablero[juego.Hasta.X, juego.Hasta.Y]._color == 'b')
                            {
                                while (juego.PiezaSelected == null)
                                {
                                    Form3 form3 = new Form3('b');
                                    form3.ShowDialog();
                                    juego.PiezaSelected = form3.piezaSelected;
                                }
                                if (juego.PiezaSelected == "Caballo")
                                {
                                    Pieza bCaballo = new caballo(juego.Hasta.X, juego.Hasta.Y, 'b', Properties.Resources.bCaballo, true);
                                    juego.agregar_pieza(bCaballo);
                                    ((PictureBox)sender).Image = Properties.Resources.bCaballo;
                                }
                                if (juego.PiezaSelected == "Reina")
                                {
                                    Pieza bReina = new reina(juego.Hasta.X, juego.Hasta.Y, 'b', Properties.Resources.bReina, true);
                                    juego.agregar_pieza(bReina);
                                    ((PictureBox)sender).Image = Properties.Resources.bReina;
                                }
                                if (juego.PiezaSelected == "Alfil")
                                {
                                    Pieza bAlfil = new alfil(juego.Hasta.X, juego.Hasta.Y, 'b', Properties.Resources.bAlfil, true);
                                    juego.agregar_pieza(bAlfil);
                                    ((PictureBox)sender).Image = Properties.Resources.bAlfil;
                                }
                                if (juego.PiezaSelected == "Torre")
                                {
                                    Pieza bTorre = new torre(juego.Hasta.X, juego.Hasta.Y, 'b', Properties.Resources.bTorre, true);
                                    juego.agregar_pieza(bTorre);
                                    ((PictureBox)sender).Image = Properties.Resources.bTorre;
                                }
                                juego.PiezaSelected = null;
                            }
                            if (juego.Hasta.Y == 0 && juego.tablero[juego.Hasta.X, juego.Hasta.Y] is peon && juego.tablero[juego.Hasta.X, juego.Hasta.Y]._color == 'n')
                            {
                                while (juego.PiezaSelected == null)
                                {
                                    Form3 form3 = new Form3('n');
                                    form3.ShowDialog();
                                    juego.PiezaSelected = form3.piezaSelected;
                                }
                                //
                                if (juego.PiezaSelected == "Caballo")
                                {
                                    Pieza nCaballo = new caballo(juego.Hasta.X, juego.Hasta.Y, 'n', Properties.Resources.nCaballo, true);
                                    juego.agregar_pieza(nCaballo);
                                    ((PictureBox)sender).Image = Properties.Resources.nCaballo;
                                }
                                if (juego.PiezaSelected == "Reina")
                                {
                                    Pieza nReina = new reina(juego.Hasta.X, juego.Hasta.Y, 'n', Properties.Resources.nReina, true);
                                    juego.agregar_pieza(nReina);
                                    ((PictureBox)sender).Image = Properties.Resources.nReina;
                                }
                                if (juego.PiezaSelected == "Alfil")
                                {
                                    Pieza nAlfil = new alfil(juego.Hasta.X, juego.Hasta.Y, 'n', Properties.Resources.nAlfil, true);
                                    juego.agregar_pieza(nAlfil);
                                    ((PictureBox)sender).Image = Properties.Resources.nAlfil;
                                }
                                if (juego.PiezaSelected == "Torre")
                                {
                                    Pieza nTorre = new torre(juego.Hasta.X, juego.Hasta.Y, 'n', Properties.Resources.nTorre, true);
                                    juego.agregar_pieza(nTorre);
                                    ((PictureBox)sender).Image = Properties.Resources.nTorre;
                                }
                                juego.PiezaSelected = null;
                            }
                            CambiarTurno();
                        }
                        else
                        {
                            if (jaque == ' ')
                            {
                                MessageBox.Show("Jaque Mate! Gano el Blanco");
                            }
                            else
                            {
                                MessageBox.Show("Jaque Mate! Gano el Negro");
                            }
                        }
                    }

                }

            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            juego = new juegoAjedrez();

            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    LimpiarImagen(x, y);
                }

            }
            inicializarJuego();
            btnJugar.Enabled = true;
        }
        private PictureBox TraerPictuboxDelTablero(int X, int Y)
        {
            PictureBox pb = new PictureBox();
            
            switch (X)
            {
                case 0:
                    switch (Y)
                    {
                        case 0:
                            pb = A1;
                            break;
                        case 1:

                            pb = A2;
                            break;
                        case 2:

                            pb = A3;
                            break;
                        case 3:

                            pb = A4;
                            break;
                        case 4:

                            pb = A5;
                            break;
                        case 5:

                            pb = A6;
                            break;
                        case 6:

                            pb = A7;
                            break;
                        case 7:

                            pb = A8;
                            break;

                    }
                    break;
                case 1:
                    switch (Y)
                    {
                        case 0:

                            pb = B1;
                            break;
                        case 1:

                            pb = B2;
                            break;
                        case 2:

                            pb = B3;
                            break;
                        case 3:

                            pb = B4;
                            break;
                        case 4:

                            pb = B5;
                            break;
                        case 5:

                            pb = B6;
                            break;
                        case 6:

                            pb = B7;
                            break;
                        case 7:
                            pb = B8;

                            break;
                    }
                    break;
                case 2:
                    switch (Y)
                    {
                        case 0:

                            pb = C1;
                            break;
                        case 1:

                            pb = C2;
                            break;
                        case 2:

                            pb = C3;
                            break;
                        case 3:

                            pb = C4;
                            break;
                        case 4:

                            pb = C5;
                            break;
                        case 5:

                            pb = C6;
                            break;
                        case 6:

                            pb = C7;
                            break;
                        case 7:

                            pb = C8;
                            break;
                    }
                    break;
                case 3:
                    switch (Y)
                    {
                        case 0:

                            pb = D1;
                            break;
                        case 1:

                            pb = D2;
                            break;
                        case 2:

                            pb = D3;
                            break;
                        case 3:

                            pb = D4;
                            break;
                        case 4:

                            pb = D5;
                            break;
                        case 5:

                            pb = D6;
                            break;
                        case 6:

                            pb = D7;
                            break;
                        case 7:

                            pb = D8;
                            break;
                    }
                    break;
                case 4:
                    switch (Y)
                    {
                        case 0:

                            pb = E1;
                            break;
                        case 1:

                            pb = E2;
                            break;
                        case 2:

                            pb = E3;
                            break;
                        case 3:

                            pb = E4;
                            break;
                        case 4:

                            pb = E5;
                            break;
                        case 5:

                            pb = E6;
                            break;
                        case 6:

                            pb = E7;
                            break;
                        case 7:

                            pb = E8;
                            break;
                    }
                    break;
                case 5:
                    switch (Y)
                    {
                        case 0:

                            pb = F1;
                            break;
                        case 1:

                            pb = F2;
                            break;
                        case 2:

                            pb = F3;
                            break;
                        case 3:

                            pb = F4;
                            break;
                        case 4:

                            pb = F5;
                            break;
                        case 5:

                            pb = F6;
                            break;
                        case 6:

                            pb = F7;
                            break;
                        case 7:

                            pb = F8;
                            break;
                    }
                    break;
                case 6:
                    switch (Y)
                    {
                        case 0:

                            pb = G1;
                            break;
                        case 1:

                            pb = G2;
                            break;
                        case 2:

                            pb = G3;
                            break;
                        case 3:

                            pb = G4;
                            break;
                        case 4:

                            pb = G5;
                            break;
                        case 5:

                            pb = G6;
                            break;
                        case 6:

                            pb = G7;
                            break;
                        case 7:

                            pb = G8;
                            break;
                    }
                    break;
                case 7:
                    switch (Y)
                    {
                        case 0:

                            pb = H1;
                            break;
                        case 1:

                            pb = H2;
                            break;
                        case 2:

                            pb = H3;
                            break;
                        case 3:

                            pb = H4;
                            break;
                        case 4:

                            pb = H5;
                            break;
                        case 5:

                            pb = H6;
                            break;
                        case 6:

                            pb = H7;
                            break;
                        case 7:

                            pb = H8;
                            break;
                    }
                   break;
            }

            return pb;
        
        }
    }
}
