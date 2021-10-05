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
        juegoAjedrez juego;
        public FormTablero()
        {
            InitializeComponent();
            juego = new juegoAjedrez();
        }

        private void inicializarJuego()
        {
            CambiarTurno();

            //Blancas: ----------------agregando piezas Negras------------


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

            //Asignando imagenes a la imagen de la pieza que está en esa posicion 
            for (int y = 0; y < 2; y++)
            {
                for (int x = 0; x < 8; x++)
                {
                    PictureBox pb = TraerPBDelTablero(x, y);

                    pb.Image = juego.tablero[x, y]._imagen;   //Blancas
                    pb = new PictureBox();
                    pb = TraerPBDelTablero(x, 7 - y);
                    pb.Image = juego.tablero[x, 7-y]._imagen; //Negras
                }
            }

        }
        
        
        private void CambiarTurno()
        {
            if (juego.Turno == 'b')
                lblTurno.Text = "Blancas";
            else
                lblTurno.Text = "Negras";
        }
        private void LimpiarImagen(int X, int Y)
        {
            PictureBox pb = TraerPBDelTablero(X, Y);
            pb.Image = null;
            pb.BackColor = Color.Transparent;
        }
        private void SetBackGroundTransparent(int X, int Y)
        {
            TraerPBDelTablero(X, Y).BackColor = Color.Transparent;
        }
        private void SetImagen(Point dest)
        {
            PictureBox pb = TraerPBDelTablero(dest.X, dest.Y);
            pb.Image = juego.tablero[dest.X, dest.Y]._imagen;
            pb.Tag = null;

        }
        private void RealizarJugada(Point anterior, Point dest)
        {
            LimpiarImagen(anterior.X, anterior.Y);
            SetImagen(dest);

        }
        private void BtnJugar_Click(object sender, EventArgs e)
        {
            inicializarJuego();
            lblTituloTurno.Text = "Turno:";
            btnJugar.Enabled = false;
        }

        private Point ObtenerCoordImagen(string nomImg)
        {
            //Ingresa el nombre de una imagen( A2, F3) y devuelve
            // las coordenadas en el tablero x,y
            string letrasTablero = "ABCDEFGH";
            int x, y;
            y = Convert.ToInt32(nomImg.Substring(1, 1)) - 1;
            x = letrasTablero.IndexOf(nomImg.Substring(0, 1));

            return new Point(x, y);
        }

        List<Point> movimientosCache = new List<Point>();
        private void MostrarPosiblesMovimientos(bool mostrar)
        {
            List<Point> posiblesMovimiento = new List<Point>();
            Image imgPunto = null;
            int bHayAlgo = 0;

            if (mostrar)
            {
                bHayAlgo = 1;
                imgPunto = Properties.Resources.punto;

                //seleccionamos pieza y la pieza devuelve a donde se puede mover
                posiblesMovimiento = juego.tablero[juego.Desde.X, juego.Desde.Y].MostrarMov(juego.tablero, juego.Desde);
                movimientosCache = new List<Point>(posiblesMovimiento);
            }
            else //!mostrar
            {
                posiblesMovimiento = new List<Point>(movimientosCache);
                posiblesMovimiento.Remove(juego.Hasta);
            }
            //pintamos por donde se puede mover
            for (int i = 0; i < posiblesMovimiento.Count(); i++)
            {
                PictureBox pb = TraerPBDelTablero(posiblesMovimiento[i]);
                pb.Image = imgPunto;
                pb.Tag = bHayAlgo;
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
                TraerPBDelTablero(movimientos[i]).BackColor = imagen;
            }

        }
        bool pbSelected = false;

        private void pb_click(object sender, EventArgs e)
        {
            char jaque = ' ';
            //seleccionar una foto
            if (!pbSelected)
            {
                if (((PictureBox)sender).Image != null)
                {

                    juego.Desde = ObtenerCoordImagen(((PictureBox)sender).Name.ToString());
                    if (juego.tablero[juego.Desde.X, juego.Desde.Y]._color == juego.Turno)
                    {
                        ((PictureBox)sender).BackColor = Color.Chocolate;
                        pbSelected = true;
                        MostrarPosiblesMovimientos(true);
                        MostrarPosibleComer(true);
                    }

                }

            }
            else if(pbSelected)
            {
                //if - deseleccionar una foto
                if (((PictureBox)sender).BackColor == Color.Chocolate)
                {
                    pbSelected = false;
                    ((PictureBox)sender).BackColor = Color.Transparent;
                    MostrarPosiblesMovimientos(false);
                    MostrarPosibleComer(false);

                }//cambiar ficha
                if (((PictureBox)sender).Tag == null && ((PictureBox)sender).BackColor == Color.Transparent)
                {
                    Point coord_img = new Point();
                    coord_img = ObtenerCoordImagen(((PictureBox)sender).Name);
                    if (juego.tablero[coord_img.X, coord_img.Y] != null)
                    {

                        MostrarPosiblesMovimientos(false);
                        MostrarPosibleComer(false);
                        SetBackGroundTransparent(juego.Desde.X, juego.Desde.Y);

                        juego.Desde = ObtenerCoordImagen(((PictureBox)sender).Name.ToString());

                        if (juego.tablero[juego.Desde.X, juego.Desde.Y]._color == juego.Turno)
                        {
                            ((PictureBox)sender).BackColor = Color.Chocolate;
                            pbSelected = true;
                            MostrarPosiblesMovimientos(true);
                            MostrarPosibleComer(true);
                        }
                    }

                }
                else
                {
                    //realiza jugada
                    juego.Hasta = ObtenerCoordImagen(((PictureBox)sender).Name.ToString());

                    if (juego.PudeRealizarJugada())
                    {
                        pbSelected = false;
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
                                    juego.agregar_pieza(new caballo(juego.Hasta.X, juego.Hasta.Y, 'b', Properties.Resources.bCaballo, true));
                                    ((PictureBox)sender).Image = Properties.Resources.bCaballo;
                                }
                                else if(juego.PiezaSelected == "Reina")
                                {
                                    juego.agregar_pieza(new reina(juego.Hasta.X, juego.Hasta.Y, 'b', Properties.Resources.bReina, true));
                                    ((PictureBox)sender).Image = Properties.Resources.bReina;
                                }
                                else if(juego.PiezaSelected == "Alfil")
                                {
                                    juego.agregar_pieza(new alfil(juego.Hasta.X, juego.Hasta.Y, 'b', Properties.Resources.bAlfil, true));
                                    ((PictureBox)sender).Image = Properties.Resources.bAlfil;
                                }
                                else if(juego.PiezaSelected == "Torre")
                                {
                                    juego.agregar_pieza(new torre(juego.Hasta.X, juego.Hasta.Y, 'b', Properties.Resources.bTorre, true));
                                    ((PictureBox)sender).Image = Properties.Resources.bTorre;
                                }
                                juego.PiezaSelected = null;
                            }
                            if (juego.Hasta.Y == 0 && juego.tablero[juego.Hasta.X, juego.Hasta.Y] is peon && juego.tablero[juego.Hasta.X, juego.Hasta.Y]._color == 'n')
                            {
                                while (juego.PiezaSelected == null)
                                {
                                    Form3 form3 = new Form3(color = 'n');
                                    form3.ShowDialog();
                                    juego.PiezaSelected = form3.piezaSelected;
                                }
                                //
                                if (juego.PiezaSelected == "Caballo")
                                {
                                    object imgSrc = Properties.Resources.ResourceManager.GetObject("nCaballo");
                                    juego.agregar_pieza( new caballo(juego.Hasta.X, juego.Hasta.Y, 'n', (Image)imgSrc, true));
                                    ((PictureBox)sender).Image = Properties.Resources.nCaballo;
                                }
                                else if (juego.PiezaSelected == "Reina")
                                {
                                    juego.agregar_pieza( new reina(juego.Hasta.X, juego.Hasta.Y, 'n', Properties.Resources.nReina, true));
                                    ((PictureBox)sender).Image = Properties.Resources.nReina;
                                }
                                else if(juego.PiezaSelected == "Alfil")
                                {
                                    juego.agregar_pieza( new alfil(juego.Hasta.X, juego.Hasta.Y, 'n', Properties.Resources.nAlfil, true));
                                    ((PictureBox)sender).Image = Properties.Resources.nAlfil;
                                }
                                else if(juego.PiezaSelected == "Torre")
                                {
                                    juego.agregar_pieza( new torre(juego.Hasta.X, juego.Hasta.Y, 'n', Properties.Resources.nTorre, true));
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

        private PictureBox TraerPBDelTablero(int X, int Y)
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
        private PictureBox TraerPBDelTablero(Point punto)
        {
            return TraerPBDelTablero(punto.X, punto.Y);
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Se borrará el juego, estás seguro?", "Advertencia", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                this.Hide();
                FormInicio formInicio = new FormInicio();
                formInicio.Show();

            }

          
        }
    }
}
