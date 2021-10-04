using Chess_Cases;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ChessMaster
{
    
    public partial class Form1 : Form
    {
        public char color;
        public string ficha;
        // 

        juegoAjedrez juego = new juegoAjedrez();

        public Form1()
        {
            InitializeComponent();
        }

        

        private void inicializarJuego()
        {
            btnJugar.Enabled = false;

            Pieza nTorre = new torre(0, 7, 'n', Properties.Resources.nTorre, false);
            juego.agregar_pieza(nTorre);
            Pieza nCaballo = new caballo(1, 7, 'n', Properties.Resources.nCaballo, true);
            juego.agregar_pieza(nCaballo);
            Pieza nAlfil = new alfil(2, 7, 'n', Properties.Resources.nAlfil, false);
            juego.agregar_pieza(nAlfil);
            Pieza nReina = new reina(3, 7, 'n', Properties.Resources.nReina, false);
            juego.agregar_pieza(nReina);
            Pieza nRey = new rey(4, 7, 'n', Properties.Resources.nRey, false);
            juego.agregar_pieza(nRey);
            Pieza nAlfil1 = new alfil(5, 7, 'n', Properties.Resources.nAlfil, false);
            juego.agregar_pieza(nAlfil1);
            Pieza nCaballo1 = new caballo(6, 7, 'n', Properties.Resources.nCaballo, true);
            juego.agregar_pieza(nCaballo1);
            Pieza nTorre1 = new torre(7, 7, 'n', Properties.Resources.nTorre, false);
            juego.agregar_pieza(nTorre1);


            Pieza nPeoin0 = new peon(0, 6, 'n', Properties.Resources.nPeon, false);
            Pieza nPeoin1 = new peon(1, 6, 'n', Properties.Resources.nPeon, false);
            Pieza nPeoin2 = new peon(2, 6, 'n', Properties.Resources.nPeon, false);
            Pieza nPeoin3 = new peon(3, 6, 'n', Properties.Resources.nPeon, false);
            Pieza nPeoin4 = new peon(4, 6, 'n', Properties.Resources.nPeon, false);
            Pieza nPeoin5 = new peon(5, 6, 'n', Properties.Resources.nPeon, false);
            Pieza nPeoin6 = new peon(6, 6, 'n', Properties.Resources.nPeon, false);
            Pieza nPeoin7 = new peon(7, 6, 'n', Properties.Resources.nPeon, false);

            juego.agregar_pieza(nPeoin0);
            juego.agregar_pieza(nPeoin1);
            juego.agregar_pieza(nPeoin2);
            juego.agregar_pieza(nPeoin3);
            juego.agregar_pieza(nPeoin4);
            juego.agregar_pieza(nPeoin5);
            juego.agregar_pieza(nPeoin6);
            juego.agregar_pieza(nPeoin7);



            //----------------------------




            Pieza bTorre = new torre(0, 0, 'b', Properties.Resources.bTorre, false);
            juego.agregar_pieza(bTorre);
            Pieza bCaballo = new caballo(1, 0, 'b', Properties.Resources.bCaballo, true);
            juego.agregar_pieza(bCaballo);
            Pieza bAlfil = new alfil(2, 0, 'b', Properties.Resources.bAlfil, false);
            juego.agregar_pieza(bAlfil);
            Pieza bReina = new reina(3, 0, 'b', Properties.Resources.bReina, false);
            juego.agregar_pieza(bReina);
            Pieza bRey = new rey(4, 0, 'b', Properties.Resources.bRey, false);
            juego.agregar_pieza(bRey);
            Pieza bAlfil1 = new alfil(5, 0, 'b', Properties.Resources.bAlfil, false);
            juego.agregar_pieza(bAlfil1);
            Pieza bCaballo1 = new caballo(6, 0, 'b', Properties.Resources.bCaballo, true);
            juego.agregar_pieza(bCaballo1);
            Pieza bTorre1 = new torre(7, 0, 'b', Properties.Resources.bTorre, false);
            juego.agregar_pieza(bTorre1);


            Pieza bPeoin0 = new peon(0, 1, 'b', Properties.Resources.bPeon, false);
            Pieza bPeoin1 = new peon(1, 1, 'b', Properties.Resources.bPeon, false);
            Pieza bPeoin2 = new peon(2, 1, 'b', Properties.Resources.bPeon, false);
            Pieza bPeoin3 = new peon(3, 1, 'b', Properties.Resources.bPeon, false);
            Pieza bPeoin4 = new peon(4, 1, 'b', Properties.Resources.bPeon, false);
            Pieza bPeoin5 = new peon(5, 1, 'b', Properties.Resources.bPeon, false);
            Pieza bPeoin6 = new peon(6, 1, 'b', Properties.Resources.bPeon, false);
            Pieza bPeoin7 = new peon(7, 1, 'b', Properties.Resources.bPeon, false);

            juego.agregar_pieza(bPeoin0);
            juego.agregar_pieza(bPeoin1);
            juego.agregar_pieza(bPeoin2);
            juego.agregar_pieza(bPeoin3);
            juego.agregar_pieza(bPeoin4);
            juego.agregar_pieza(bPeoin5);
            juego.agregar_pieza(bPeoin6);
            juego.agregar_pieza(bPeoin7);


            juego.Turno = 'b';
            juego.Fin = false;


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

            // negras 
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




            if (juego.Turno == 'b')
            {
                lblTurno.Text = "Blancas";
            }
            else
            {
                lblTurno.Text = "Negras";
            }
        }
        private void CambiarTurno()
        {
            if(juego.Turno == 'b')
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
            switch (X)
            {
                case 0:
                    switch (Y)
                    {
                        case 0:
                            A1.Image = null;
                            A1.BackColor = Color.Transparent;
                            break;
                        case 1:
                            A2.Image = null;
                            A2.BackColor = Color.Transparent;
                            break;
                        case 2:
                            A3.Image = null;
                            A3.BackColor = Color.Transparent;
                            break;
                        case 3:
                            A4.Image = null;
                            A4.BackColor = Color.Transparent;
                            break;
                        case 4:
                            A5.Image = null;
                            A5.BackColor = Color.Transparent;
                            break;
                        case 5:
                            A6.Image = null;
                            A6.BackColor = Color.Transparent;
                            break;
                        case 6:
                            A7.Image = null;
                            A7.BackColor = Color.Transparent;
                            break;
                        case 7:
                            A8.Image = null;
                            A8.BackColor = Color.Transparent;
                            break;

                    }
                    break;
                case 1:
                    switch (Y)
                    {
                        case 0:
                            B1.Image = null;
                            B1.BackColor = Color.Transparent;
                            break;
                        case 1:
                            B2.Image = null;
                            B2.BackColor = Color.Transparent;
                            break;
                        case 2:
                            B3.Image = null;
                            B3.BackColor = Color.Transparent;
                            break;
                        case 3:
                            B4.Image = null;
                            B4.BackColor = Color.Transparent;
                            break;
                        case 4:
                            B5.Image = null;
                            B5.BackColor = Color.Transparent;
                            break;
                        case 5:
                            B6.Image = null;
                            B6.BackColor = Color.Transparent;
                            break;
                        case 6:
                            B7.Image = null;
                            B7.BackColor = Color.Transparent;
                            break;
                        case 7:
                            B8.BackColor = Color.Transparent;
                            B8.Image = null;
                            break;
                    }
                    break;
                case 2:
                    switch (Y)
                    {
                        case 0:
                            C1.Image = null;
                            C1.BackColor = Color.Transparent;
                            break;
                        case 1:
                            C2.Image = null;
                            C2.BackColor = Color.Transparent;
                            break;
                        case 2:
                            C3.Image = null;
                            C3.BackColor = Color.Transparent;
                            break;
                        case 3:
                            C4.Image = null;
                            C4.BackColor = Color.Transparent;
                            break;
                        case 4:
                            C5.Image = null;
                            C5.BackColor = Color.Transparent;
                            break;
                        case 5:
                            C6.Image = null;
                            C6.BackColor = Color.Transparent;
                            break;
                        case 6:
                            C7.Image = null;
                            C7.BackColor = Color.Transparent;
                            break;
                        case 7:
                            C8.Image = null;
                            C8.BackColor = Color.Transparent;
                            break;
                    }
                    break;
                case 3:
                    switch (Y)
                    {
                        case 0:
                            D1.Image = null;
                            D1.BackColor = Color.Transparent;
                            break;
                        case 1:
                            D2.Image = null;
                            D2.BackColor = Color.Transparent;
                            break;
                        case 2:
                            D3.Image = null;
                            D3.BackColor = Color.Transparent;
                            break;
                        case 3:
                            D4.Image = null;
                            D4.BackColor = Color.Transparent;
                            break;
                        case 4:
                            D5.Image = null;
                            D5.BackColor = Color.Transparent;
                            break;
                        case 5:
                            D6.Image = null;
                            D6.BackColor = Color.Transparent;
                            break;
                        case 6:
                            D7.Image = null;
                            D7.BackColor = Color.Transparent;
                            break;
                        case 7:
                            D8.Image = null;
                            D8.BackColor = Color.Transparent;
                            break;
                    }
                    break;
                case 4:
                    switch (Y)
                    {
                        case 0:
                            E1.Image = null;
                            E1.BackColor = Color.Transparent;
                            break;
                        case 1:
                            E2.Image = null;
                            E2.BackColor = Color.Transparent;
                            break;
                        case 2:
                            E3.Image = null;
                            E3.BackColor = Color.Transparent;
                            break;
                        case 3:
                            E4.Image = null;
                            E4.BackColor = Color.Transparent;
                            break;
                        case 4:
                            E5.Image = null;
                            E5.BackColor = Color.Transparent;
                            break;
                        case 5:
                            E6.Image = null;
                            E6.BackColor = Color.Transparent;
                            break;
                        case 6:
                            E7.Image = null;
                            E7.BackColor = Color.Transparent;
                            break;
                        case 7:
                            E8.Image = null;
                            E8.BackColor = Color.Transparent;
                            break;
                    }
                    break;
                case 5:
                    switch (Y)
                    {
                        case 0:
                            F1.Image = null;
                            F1.BackColor = Color.Transparent;
                            break;
                        case 1:
                            F2.Image = null;
                            F2.BackColor = Color.Transparent;
                            break;
                        case 2:
                            F3.Image = null;
                            F3.BackColor = Color.Transparent;
                            break;
                        case 3:
                            F4.Image = null;
                            F4.BackColor = Color.Transparent;
                            break;
                        case 4:
                            F5.Image = null;
                            F5.BackColor = Color.Transparent;
                            break;
                        case 5:
                            F6.Image = null;
                            F6.BackColor = Color.Transparent;
                            break;
                        case 6:
                            F7.Image = null;
                            F7.BackColor = Color.Transparent;
                            break;
                        case 7:
                            F8.Image = null;
                            F8.BackColor = Color.Transparent;
                            break;
                    }
                    break;
                case 6:
                    switch (Y)
                    {
                        case 0:
                            G1.Image = null;
                            G1.BackColor = Color.Transparent;
                            break;
                        case 1:
                            G2.Image = null;
                            G2.BackColor = Color.Transparent;
                            break;
                        case 2:
                            G3.Image = null;
                            G3.BackColor = Color.Transparent;
                            break;
                        case 3:
                            G4.Image = null;
                            G4.BackColor = Color.Transparent;
                            break;
                        case 4:
                            G5.Image = null;
                            G5.BackColor = Color.Transparent;
                            break;
                        case 5:
                            G6.Image = null;
                            G6.BackColor = Color.Transparent;
                            break;
                        case 6:
                            G7.Image = null;
                            G7.BackColor = Color.Transparent;
                            break;
                        case 7:
                            G8.Image = null;
                            G8.BackColor = Color.Transparent;
                            break;
                    }
                    break;
                case 7:
                    switch (Y)
                    {
                        case 0:
                            H1.Image = null;
                            H1.BackColor = Color.Transparent;
                            break;
                        case 1:
                            H2.Image = null;
                            H2.BackColor = Color.Transparent;
                            break;
                        case 2:
                            H3.Image = null;
                            H3.BackColor = Color.Transparent;
                            break;
                        case 3:
                            H4.Image = null;
                            H4.BackColor = Color.Transparent;
                            break;
                        case 4:
                            H5.Image = null;
                            H5.BackColor = Color.Transparent;
                            break;
                        case 5:
                            H6.Image = null;
                            H6.BackColor = Color.Transparent;
                            break;
                        case 6:
                            H7.Image = null;
                            H7.BackColor = Color.Transparent;
                            break;
                        case 7:
                            H8.Image = null;
                            H8.BackColor = Color.Transparent;
                            break;
                    }
                    break;
            }
        }
        private void BackGroundTransparent(int X, int Y)
        {
            switch (X)
            {
                case 0:
                    switch (Y)
                    {
                        case 0:
                            
                            A1.BackColor = Color.Transparent;
                            break;
                        case 1:
                           
                            A2.BackColor = Color.Transparent;
                            break;
                        case 2:
                      
                            A3.BackColor = Color.Transparent;
                            break;
                        case 3:
                  
                            A4.BackColor = Color.Transparent;
                            break;
                        case 4:
                       
                            A5.BackColor = Color.Transparent;
                            break;
                        case 5:
                          
                            A6.BackColor = Color.Transparent;
                            break;
                        case 6:
                           
                            A7.BackColor = Color.Transparent;
                            break;
                        case 7:
                       
                            A8.BackColor = Color.Transparent;
                            break;

                    }
                    break;
                case 1:
                    switch (Y)
                    {
                        case 0:
                        
                            B1.BackColor = Color.Transparent;
                            break;
                        case 1:
                         
                            B2.BackColor = Color.Transparent;
                            break;
                        case 2:
                          
                            B3.BackColor = Color.Transparent;
                            break;
                        case 3:
                     
                            B4.BackColor = Color.Transparent;
                            break;
                        case 4:
                            
                            B5.BackColor = Color.Transparent;
                            break;
                        case 5:
                          
                            B6.BackColor = Color.Transparent;
                            break;
                        case 6:
                           
                            B7.BackColor = Color.Transparent;
                            break;
                        case 7:
                            B8.BackColor = Color.Transparent;
                         
                            break;
                    }
                    break;
                case 2:
                    switch (Y)
                    {
                        case 0:
                       
                            C1.BackColor = Color.Transparent;
                            break;
                        case 1:
                          
                            C2.BackColor = Color.Transparent;
                            break;
                        case 2:
                    
                            C3.BackColor = Color.Transparent;
                            break;
                        case 3:
                       
                            C4.BackColor = Color.Transparent;
                            break;
                        case 4:
                           
                            C5.BackColor = Color.Transparent;
                            break;
                        case 5:
                          
                            C6.BackColor = Color.Transparent;
                            break;
                        case 6:
                     
                            C7.BackColor = Color.Transparent;
                            break;
                        case 7:
                        
                            C8.BackColor = Color.Transparent;
                            break;
                    }
                    break;
                case 3:
                    switch (Y)
                    {
                        case 0:
                          
                            D1.BackColor = Color.Transparent;
                            break;
                        case 1:
                          
                            D2.BackColor = Color.Transparent;
                            break;
                        case 2:
                           
                            D3.BackColor = Color.Transparent;
                            break;
                        case 3:
                          
                            D4.BackColor = Color.Transparent;
                            break;
                        case 4:
                         
                            D5.BackColor = Color.Transparent;
                            break;
                        case 5:
                        
                            D6.BackColor = Color.Transparent;
                            break;
                        case 6:
                      
                            D7.BackColor = Color.Transparent;
                            break;
                        case 7:
                         
                            D8.BackColor = Color.Transparent;
                            break;
                    }
                    break;
                case 4:
                    switch (Y)
                    {
                        case 0:
                      
                            E1.BackColor = Color.Transparent;
                            break;
                        case 1:
              
                            E2.BackColor = Color.Transparent;
                            break;
                        case 2:
                  
                            E3.BackColor = Color.Transparent;
                            break;
                        case 3:
                  
                            E4.BackColor = Color.Transparent;
                            break;
                        case 4:
                  
                            E5.BackColor = Color.Transparent;
                            break;
                        case 5:
         
                            E6.BackColor = Color.Transparent;
                            break;
                        case 6:
          
                            E7.BackColor = Color.Transparent;
                            break;
                        case 7:
                  
                            E8.BackColor = Color.Transparent;
                            break;
                    }
                    break;
                case 5:
                    switch (Y)
                    {
                        case 0:
                
                            F1.BackColor = Color.Transparent;
                            break;
                        case 1:
                 
                            F2.BackColor = Color.Transparent;
                            break;
                        case 2:
                
                            F3.BackColor = Color.Transparent;
                            break;
                        case 3:
                 
                            F4.BackColor = Color.Transparent;
                            break;
                        case 4:
                 
                            F5.BackColor = Color.Transparent;
                            break;
                        case 5:
                   
                            F6.BackColor = Color.Transparent;
                            break;
                        case 6:
           
                            F7.BackColor = Color.Transparent;
                            break;
                        case 7:
                  
                            F8.BackColor = Color.Transparent;
                            break;
                    }
                    break;
                case 6:
                    switch (Y)
                    {
                        case 0:
              
                            G1.BackColor = Color.Transparent;
                            break;
                        case 1:
              
                            G2.BackColor = Color.Transparent;
                            break;
                        case 2:
                 
                            G3.BackColor = Color.Transparent;
                            break;
                        case 3:
                  
                            G4.BackColor = Color.Transparent;
                            break;
                        case 4:
              
                            G5.BackColor = Color.Transparent;
                            break;
                        case 5:
               
                            G6.BackColor = Color.Transparent;
                            break;
                        case 6:
                
                            G7.BackColor = Color.Transparent;
                            break;
                        case 7:
                
                            G8.BackColor = Color.Transparent;
                            break;
                    }
                    break;
                case 7:
                    switch (Y)
                    {
                        case 0:

                            H1.BackColor = Color.Transparent;
                            break;
                        case 1:

                            H2.BackColor = Color.Transparent;
                            break;
                        case 2:

                            H3.BackColor = Color.Transparent;
                            break;
                        case 3:

                            H4.BackColor = Color.Transparent;
                            break;
                        case 4:

                            H5.BackColor = Color.Transparent;
                            break;
                        case 5:

                            H6.BackColor = Color.Transparent;
                            break;
                        case 6:
        
                            H7.BackColor = Color.Transparent;
                            break;
                        case 7:
             
                            H8.BackColor = Color.Transparent;
                            break;
                    }
                    break;
            }
        }
        private void ActualizarImagen(Point dest)
        {
            switch (dest.X)
            {
                case 0:
                    switch (dest.Y)
                    {
                        case 0:
                            A1.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            A1.Tag = null;
                            break;
                        case 1:
                            A2.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            A2.Tag = null;
                            break;
                        case 2:
                            A3.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            A3.Tag = null;
                            break;
                        case 3:
                            A4.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            A4.Tag = null;
                            break;
                        case 4:
                            A5.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            A5.Tag = null;
                            break;
                        case 5:
                            A6.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            A6.Tag = null;
                            break;
                        case 6:
                            A7.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            A7.Tag = null;
                            break;
                        case 7:
                            A8.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            A8.Tag = null;
                            break;
                    }
                    break;
                case 1:
                    switch (dest.Y)
                    {
                        case 0:
                            B1.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            B1.Tag = null;
                            break;
                        case 1:
                            B2.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            B2.Tag = null;
                            break;
                        case 2:
                            B3.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            B3.Tag = null;
                            break;
                        case 3:
                            B4.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            B4.Tag = null;
                            break;
                        case 4:
                            B5.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            B5.Tag = null;
                            break;
                        case 5:
                            B6.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            B6.Tag = null;
                            break;
                        case 6:
                            B7.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            B7.Tag = null;
                            break;
                        case 7:
                            B8.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            B8.Tag = null;
                            break;
                    }
                    break;
                case 2:
                    switch (dest.Y)
                    {
                        case 0:
                            C1.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            C1.Tag = null;
                            break;
                        case 1:
                            C2.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            C2.Tag = null;
                            break;
                        case 2:
                            C3.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            C3.Tag = null;
                            break;
                        case 3:
                            C4.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            C4.Tag = null;
                            break;
                        case 4:
                            C5.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            C5.Tag = null;
                            break;
                        case 5:
                            C6.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            C6.Tag = null;
                            break;
                        case 6:
                            C7.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            C7.Tag = null;
                            break;
                        case 7:
                            C8.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            C8.Tag = null;
                            break;
                    }
                    break;
                case 3:
                    switch (dest.Y)
                    {
                        case 0:
                            D1.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            D1.Tag = null;
                            break;
                        case 1:
                            D2.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            D2.Tag = null;
                            break;
                        case 2:
                            D3.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            D3.Tag = null;
                            break;
                        case 3:
                            D4.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            D4.Tag = null;
                            break;
                        case 4:
                            D5.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            D5.Tag = null;
                            break;
                        case 5:
                            D6.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            D6.Tag = null;
                            break;
                        case 6:
                            D7.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            D7.Tag = null;
                            break;
                        case 7:
                            D8.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            D8.Tag = null;
                            break;
                    }
                    break;
                case 4:
                    switch (dest.Y)
                    {
                        case 0:
                            E1.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            E1.Tag = null;
                            break;
                        case 1:
                            E2.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            E2.Tag = null;
                            break;
                        case 2:
                            E3.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            E3.Tag = null;
                            break;
                        case 3:
                            E4.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            E4.Tag = null;
                            break;
                        case 4:
                            E5.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            E5.Tag = null;
                            break;
                        case 5:
                            E6.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            E6.Tag = null;
                            break;
                        case 6:
                            E7.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            E7.Tag = null;
                            break;
                        case 7:
                            E8.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            E8.Tag = null;
                            break;
                    }
                    break;
                case 5:
                    switch (dest.Y)
                    {
                        case 0:
                            F1.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            F1.Tag = null;
                            break;
                        case 1:
                            F2.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            F2.Tag = null;
                            break;
                        case 2:
                            F3.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            F3.Tag = null;
                            break;
                        case 3:
                            F4.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            F4.Tag = null;
                            break;
                        case 4:
                            F5.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            F5.Tag = null;
                            break;
                        case 5:
                            F6.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            F6.Tag = null;
                            break;
                        case 6:
                            F7.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            F7.Tag = null;
                            break;
                        case 7:
                            F8.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            F8.Tag = null;
                            break;
                    }
                    break;
                case 6:
                    switch (dest.Y)
                    {
                        case 0:
                            G1.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            G1.Tag = null;
                            break;
                        case 1:
                            G2.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            G2.Tag = null;
                            break;
                        case 2:
                            G3.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            G3.Tag = null;
                            break;
                        case 3:
                            G4.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            G4.Tag = null;
                            break;
                        case 4:
                            G5.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            G5.Tag = null;
                            break;
                        case 5:
                            G6.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            G6.Tag = null;
                            break;
                        case 6:
                            G7.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            G7.Tag = null;
                            break;
                        case 7:
                            G8.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            G8.Tag = null;
                            break;
                    }
                    break;
                case 7:
                    switch (dest.Y)
                    {
                        case 0:
                            H1.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            H1.Tag = null;
                            break;
                        case 1:
                            H2.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            H2.Tag = null;
                            break;
                        case 2:
                            H3.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            H3.Tag = null;
                            break;
                        case 3:
                            H4.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            H4.Tag = null;
                            break;
                        case 4:
                            H5.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            H5.Tag = null;
                            break;
                        case 5:
                            H6.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            H6.Tag = null;
                            break;
                        case 6:
                            H7.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            H7.Tag = null;
                            break;
                        case 7:
                            H8.Image = juego.tablero[dest.X, dest.Y]._imagen;
                            H8.Tag = null;
                            break;
                    }
                    break;
            }
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

                switch (movimientos[i].X)
                {
                    case 0:
                        switch (movimientos[i].Y)
                        {
                            case 0:
                                A1.Image = imagen;
                                A1.Tag = algo;
                                break;
                            case 1:
                                A2.Image = imagen;
                                A2.Tag = algo;
                                break;
                            case 2:
                                A3.Image = imagen;
                                A3.Tag = algo;
                                break;
                            case 3:
                                A4.Image = imagen;
                                A4.Tag = algo;
                                break;
                            case 4:
                                A5.Image = imagen;
                                A5.Tag = algo;
                                break;
                            case 5:
                                A6.Image = imagen;
                                A6.Tag = algo;
                                break;
                            case 6:
                                A7.Image = imagen;
                                A7.Tag = algo;
                                break;
                            case 7:
                                A8.Image = imagen;
                                A8.Tag = algo;
                                break;
                        }
                        break;
                    case 1:
                        switch (movimientos[i].Y)
                        {
                            case 0:
                                B1.Image = imagen;
                                B1.Tag = algo;
                                break;
                            case 1:
                                B2.Image = imagen;
                                B2.Tag = algo;
                                break;
                            case 2:
                                B3.Image = imagen;
                                B3.Tag = algo;
                                break;
                            case 3:
                                B4.Image = imagen;
                                B4.Tag = algo;
                                break;
                            case 4:
                                B5.Image = imagen;
                                B5.Tag = algo;
                                break;
                            case 5:
                                B6.Image = imagen;
                                B6.Tag = algo;
                                break;
                            case 6:
                                B7.Image = imagen;
                                B7.Tag = algo;
                                break;
                            case 7:
                                B8.Image = imagen;
                                B8.Tag = algo;
                                break;
                        }
                        break;
                    case 2:
                        switch (movimientos[i].Y)
                        {
                            case 0:
                                C1.Image = imagen;
                                C1.Tag = algo;
                                break;
                            case 1:
                                C2.Image = imagen;
                                C2.Tag = algo;
                                break;
                            case 2:
                                C3.Image = imagen;
                                C3.Tag = algo;
                                break;
                            case 3:
                                C4.Image = imagen;
                                C4.Tag = algo;
                                break;
                            case 4:
                                C5.Image = imagen;
                                C5.Tag = algo;
                                break;
                            case 5:
                                C6.Image = imagen;
                                C6.Tag = algo;
                                break;
                            case 6:
                                C7.Image = imagen;
                                C7.Tag = algo;
                                break;
                            case 7:
                                C8.Image = imagen;
                                C8.Tag = algo;
                                break;
                        }
                        break;
                    case 3:
                        switch (movimientos[i].Y)
                        {
                            case 0:
                                D1.Image = imagen;
                                D1.Tag = algo;
                                break;
                            case 1:
                                D2.Image = imagen;
                                D2.Tag = algo;
                                break;
                            case 2:
                                D3.Image = imagen;
                                D3.Tag = algo;
                                break;
                            case 3:
                                D4.Image = imagen;
                                D4.Tag = algo;
                                break;
                            case 4:
                                D5.Image = imagen;
                                D5.Tag = algo;
                                break;
                            case 5:
                                D6.Image = imagen;
                                D6.Tag = algo;
                                break;
                            case 6:
                                D7.Image = imagen;
                                D7.Tag = algo;
                                break;
                            case 7:
                                D8.Image = imagen;
                                D8.Tag = algo;
                                break;
                        }
                        break;
                    case 4:
                        switch (movimientos[i].Y)
                        {
                            case 0:
                                E1.Image = imagen;
                                E1.Tag = algo;
                                break;
                            case 1:
                                E2.Image = imagen;
                                E2.Tag = algo;
                                break;
                            case 2:
                                E3.Image = imagen;
                                E3.Tag = algo;
                                break;
                            case 3:
                                E4.Image = imagen;
                                E4.Tag = algo;
                                break;
                            case 4:
                                E5.Image = imagen;
                                E5.Tag = algo;
                                break;
                            case 5:
                                E6.Image = imagen;
                                E6.Tag = algo;
                                break;
                            case 6:
                                E7.Image = imagen;
                                E7.Tag = algo;
                                break;
                            case 7:
                                E8.Image = imagen;
                                E8.Tag = algo;
                                break;
                        }
                        break;
                    case 5:
                        switch (movimientos[i].Y)
                        {
                            case 0:
                                F1.Image = imagen;
                                F1.Tag = algo;
                                break;
                            case 1:
                                F2.Image = imagen;
                                F2.Tag = algo;
                                break;
                            case 2:
                                F3.Image = imagen;
                                F3.Tag = algo;
                                break;
                            case 3:
                                F4.Image = imagen;
                                F4.Tag = algo;
                                break;
                            case 4:
                                F5.Image = imagen;
                                F5.Tag = algo;
                                break;
                            case 5:
                                F6.Image = imagen;
                                F6.Tag = algo;
                                break;
                            case 6:
                                F7.Image = imagen;
                                F7.Tag = algo;
                                break;
                            case 7:
                                F8.Image = imagen;
                                F8.Tag = algo;
                                break;
                        }
                        break;
                    case 6:
                        switch (movimientos[i].Y)
                        {
                            case 0:
                                G1.Image = imagen;
                                G1.Tag = algo;
                                break;
                            case 1:
                                G2.Image = imagen;
                                G2.Tag = algo;
                                break;
                            case 2:
                                G3.Image = imagen;
                                G3.Tag = algo;
                                break;
                            case 3:
                                G4.Image = imagen;
                                G4.Tag = algo;
                                break;
                            case 4:
                                G5.Image = imagen;
                                G5.Tag = algo;
                                break;
                            case 5:
                                G6.Image = imagen;
                                G6.Tag = algo;
                                break;
                            case 6:
                                G7.Image = imagen;
                                G7.Tag = algo;
                                break;
                            case 7:
                                G8.Image = imagen;
                                G8.Tag = algo;
                                break;
                        }
                        break;
                    case 7:
                        switch (movimientos[i].Y)
                        {
                            case 0:
                                H1.Image = imagen;
                                H1.Tag = algo;
                                break;
                            case 1:
                                H2.Image = imagen;
                                H2.Tag = algo;
                                break;
                            case 2:
                                H3.Image = imagen;
                                H3.Tag = algo;
                                break;
                            case 3:
                                H4.Image = imagen;
                                H4.Tag = algo;
                                break;
                            case 4:
                                H5.Image = imagen;
                                H5.Tag = algo;
                                break;
                            case 5:
                                H6.Image = imagen;
                                H6.Tag = algo;
                                break;
                            case 6:
                                H7.Image = imagen;
                                H7.Tag = algo;
                                break;
                            case 7:
                                H8.Image = imagen;
                                H8.Tag = algo;
                                break;
                        }
                        break;
                }
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

                switch (movimientos[i].X)
                {
                    case 0:
                        switch (movimientos[i].Y)
                        {
                            case 0:
                                A1.BackColor = imagen;
                                break;
                            case 1:
                                A2.BackColor = imagen;
                                break;
                            case 2:
                                A3.BackColor = imagen;
                                break;
                            case 3:
                                A4.BackColor = imagen;
                                break;
                            case 4:
                                A5.BackColor = imagen;
                                break;
                            case 5:
                                A6.BackColor = imagen;
                                break;
                            case 6:
                                A7.BackColor = imagen;
                                break;
                            case 7:
                                A8.BackColor = imagen;
                                break;
                        }
                        break;
                    case 1:
                        switch (movimientos[i].Y)
                        {
                            case 0:
                                B1.BackColor = imagen;
                                break;
                            case 1:
                                B2.BackColor = imagen;
                                break;
                            case 2:
                                B3.BackColor = imagen;
                                break;
                            case 3:
                                B4.BackColor = imagen;
                                break;
                            case 4:
                                B5.BackColor = imagen;
                                break;
                            case 5:
                                B6.BackColor = imagen;
                                break;
                            case 6:
                                B7.BackColor = imagen;
                                break;
                            case 7:
                                B8.BackColor = imagen;
                                break;
                        }
                        break;
                    case 2:
                        switch (movimientos[i].Y)
                        {
                            case 0:
                                C1.BackColor = imagen;
                                break;
                            case 1:
                                C2.BackColor = imagen;
                                break;
                            case 2:
                                C3.BackColor = imagen;
                                break;
                            case 3:
                                C4.BackColor = imagen;
                                break;
                            case 4:
                                C5.BackColor = imagen;
                                break;
                            case 5:
                                C6.BackColor = imagen;
                                break;
                            case 6:
                                C7.BackColor = imagen;
                                break;
                            case 7:
                                C8.BackColor = imagen;
                                break;
                        }
                        break;
                    case 3:
                        switch (movimientos[i].Y)
                        {
                            case 0:
                                D1.BackColor = imagen;
                                break;
                            case 1:
                                D2.BackColor = imagen;
                                break;
                            case 2:
                                D3.BackColor = imagen;
                                break;
                            case 3:
                                D4.BackColor = imagen;
                                break;
                            case 4:
                                D5.BackColor = imagen;
                                break;
                            case 5:
                                D6.BackColor = imagen;
                                break;
                            case 6:
                                D7.BackColor = imagen;
                                break;
                            case 7:
                                D8.BackColor = imagen;
                                break;
                        }
                        break;
                    case 4:
                        switch (movimientos[i].Y)
                        {
                            case 0:
                                E1.BackColor = imagen;
                                break;
                            case 1:
                                E2.BackColor = imagen;
                                break;
                            case 2:
                                E3.BackColor = imagen;
                                break;
                            case 3:
                                E4.BackColor = imagen;
                                break;
                            case 4:
                                E5.BackColor = imagen;
                                break;
                            case 5:
                                E6.BackColor = imagen;
                                break;
                            case 6:
                                E7.BackColor = imagen;
                                break;
                            case 7:
                                E8.BackColor = imagen;
                                break;
                        }
                        break;
                    case 5:
                        switch (movimientos[i].Y)
                        {
                            case 0:
                                F1.BackColor = imagen;
                                break;
                            case 1:
                                F2.BackColor = imagen;
                                break;
                            case 2:
                                F3.BackColor = imagen;
                                break;
                            case 3:
                                F4.BackColor = imagen;
                                break;
                            case 4:
                                F5.BackColor = imagen;
                                break;
                            case 5:
                                F6.BackColor = imagen;
                                break;
                            case 6:
                                F7.BackColor = imagen;
                                break;
                            case 7:
                                F8.BackColor = imagen;
                                break;
                        }
                        break;
                    case 6:
                        switch (movimientos[i].Y)
                        {
                            case 0:
                                G1.BackColor = imagen;
                                break;
                            case 1:
                                G2.BackColor = imagen;
                                break;
                            case 2:
                                G3.BackColor = imagen;
                                break;
                            case 3:
                                G4.BackColor = imagen;
                                break;
                            case 4:
                                G5.BackColor = imagen;
                                break;
                            case 5:
                                G6.BackColor = imagen;
                                break;
                            case 6:
                                G7.BackColor = imagen;
                                break;
                            case 7:
                                G8.BackColor = imagen;
                                break;
                        }
                        break;
                    case 7:
                        switch (movimientos[i].Y)
                        {
                            case 0:
                                H1.BackColor = imagen;
                                break;
                            case 1:
                                H2.BackColor = imagen;
                                break;
                            case 2:
                                H3.BackColor = imagen;
                                break;
                            case 3:
                                H4.BackColor = imagen;
                                break;
                            case 4:
                                H5.BackColor = imagen;
                                break;
                            case 5:
                                H6.BackColor = imagen;
                                break;
                            case 6:
                                H7.BackColor = imagen;
                                break;
                            case 7:
                                H8.BackColor = imagen;
                                break;
                        }
                        break;
                }
            }


        }
        bool selected = false;

        private void pb_click(object sender, EventArgs e)
        {
            bool JaqueAlBlanco = false, JaqueAlNegro = false;
            //seleccionar una foto
            if (!selected)
            {
                if (((PictureBox)sender).Image != null )
                {
                    
                    juego.Desde = ObtenerCoordXImagen(((PictureBox)sender).Name.ToString());
                    

                   if(juego.tablero[juego.Desde.X,juego.Desde.Y]._color == juego.Turno)
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
                   { Point cosa = new Point();
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
                       
                        JaqueAlBlanco = juego.JaqueMateBlanco();
                        JaqueAlNegro = juego.JaqueMateNegro();
                        if (JaqueAlBlanco == false && JaqueAlNegro == false)
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
                            if(JaqueAlBlanco == true)
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


        private void Form1_Load(object sender, EventArgs e)
        {
            btnReiniciar.Enabled = false;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            juego = new juegoAjedrez();
            
            for (int x = 0; x < 8; x++)
            {
                  for (int y = 0; y < 8; y++)
                     {
                      LimpiarImagen(x,y);
                 }
            
            }
         inicializarJuego();
            btnJugar.Enabled = true;
        }
    }
}
