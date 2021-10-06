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
        //PictureBox[,] matrizPB = new PictureBox[8, 8];
        public FormTablero()
        {
            InitializeComponent();
            
        }

        private void inicializarJuego()
        {
            juego = new juegoAjedrez();
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
                juego.agregar_pieza(new peon(i, 6, 'n', Properties.Resources.nPeon, false));
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
        private void MoverPieza(Point anterior, Point dest)
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
        private void MostrarPosiblesMovimientos(bool mostrar, bool mostrarComer = false)
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
            MostrarPosibleComer(mostrarComer);
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

        private void seleccionar_pieza(Point pos, PictureBox pb, Color color, bool mostrarMovs, bool mostrarComer)
        {
            pb.BackColor = color;
            MostrarPosiblesMovimientos(mostrarMovs,mostrarComer);
        }

        private void PedirCambioCoronacion(char color)
        {
            while (juego.PiezaSelected == null)
            {
                Form3 form3 = new Form3(color);
                form3.ShowDialog();
                juego.PiezaSelected = form3.piezaSelected;
            }
        }

        private void pb_click(object sender, EventArgs e)
        {
            if(juego.state == "terminado")
            {
                return;
            }

            char jaqueMate = ' ';
      
            if ( !pbSelected  && ((PictureBox)sender).Image != null)      //seleccionar una foto
            {
                
                juego.Desde = ObtenerCoordImagen(((PictureBox)sender).Name.ToString());
                if (juego.PiezaTurnoJugador(juego.Desde))
                {
                    seleccionar_pieza(juego.Desde, ((PictureBox)sender), Color.Chocolate, true, true);
                    pbSelected = true;
                }
            }
            else if(pbSelected) 
            {
              
                if (((PictureBox)sender).BackColor == Color.Chocolate)  //deseleccionar una foto
                {
                    seleccionar_pieza(juego.Desde, ((PictureBox)sender), Color.Transparent, false, false);
                    pbSelected = false;

                }
                else if (((PictureBox)sender).Tag == null && ((PictureBox)sender).BackColor == Color.Transparent) //cambiar ficha
                {
                    Point coord_img = new Point();
                    coord_img = ObtenerCoordImagen(((PictureBox)sender).Name);
                    if (juego.tablero[coord_img.X, coord_img.Y] != null)
                    {

                        MostrarPosiblesMovimientos(false,false);
                        SetBackGroundTransparent(juego.Desde.X, juego.Desde.Y);

                        juego.Desde = ObtenerCoordImagen(((PictureBox)sender).Name.ToString());

                        if (juego.PiezaTurnoJugador(juego.Desde))
                        {
                            seleccionar_pieza(juego.Desde, ((PictureBox)sender), Color.Chocolate, true, true);
                            pbSelected = true;
                        }
                    }

                }
                else //realiza jugada
                {        
                    juego.Hasta = ObtenerCoordImagen(((PictureBox)sender).Name.ToString());

                    if (juego.RealizarJugada())
                    {
                        pbSelected = false;
                        MoverPieza(juego.Desde, juego.Hasta);
                        MostrarPosiblesMovimientos(false,false);

                        jaqueMate = juego.JaqueMate();
                        if (jaqueMate != ' ') // hay jaquemate
                        {
                            if (jaqueMate == 'b')
                                MessageBox.Show("Jaque Mate! Gano el Negro");
                            else
                                MessageBox.Show("Jaque Mate! Gano el Blanco");
                            juego.state = "terminado";
                            btnReiniciar.Enabled = true;
                        }
                        else
                        {
                            char color_peon = juego.EvaluarConvertirPeon();
                            if (color_peon != ' ')
                            {
                                PedirCambioCoronacion(color_peon);
                                object imgPieza = Properties.Resources.ResourceManager.GetObject(color_peon + juego.PiezaSelected);
                                switch (juego.PiezaSelected)
                                {
                                    case "Caballo":
                                        juego.agregar_pieza(new caballo(juego.Hasta.X, juego.Hasta.Y, color_peon, (Image)imgPieza, true));
                                        ((PictureBox)sender).Image = (Image)imgPieza;
                                        break;
                                    case "Reina":
                                        juego.agregar_pieza(new reina(juego.Hasta.X, juego.Hasta.Y, color_peon, (Image)imgPieza, true));
                                        ((PictureBox)sender).Image = (Image)imgPieza;
                                        break;
                                    case "Alfil":
                                        juego.agregar_pieza(new alfil(juego.Hasta.X, juego.Hasta.Y, color_peon, (Image)imgPieza, true));
                                        ((PictureBox)sender).Image = (Image)imgPieza;
                                        break;
                                    case "Torre":
                                        juego.agregar_pieza(new torre(juego.Hasta.X, juego.Hasta.Y, color_peon, (Image)imgPieza, true));
                                        ((PictureBox)sender).Image = (Image)imgPieza;
                                        break;
                                    default:
                                        break;
                                }
                                juego.PiezaSelected = null;
                            }
                            CambiarTurno();
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

        private void FormTablero_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
