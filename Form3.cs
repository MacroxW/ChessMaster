using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ChessMaster
{
    public partial class Form3 : Form
    {
        public string piezaSelected;
        char colorp;
        public Form3(char color)
        {
            InitializeComponent();
            colorp = color;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Enabled = true;
            if(colorp == 'b')
            {
                pbCaballo.Image = ChessMaster.Properties.Resources.bCaballo;
                pbAlfil.Image = Properties.Resources.bAlfil;
                pbReina.Image = Properties.Resources.bReina;
                pbTorre.Image = Properties.Resources.bTorre;
            }
            if (colorp == 'n')
            { 
                pbCaballo.Image = Properties.Resources.nCaballo;
                pbAlfil.Image = Properties.Resources.nAlfil;
                pbReina.Image = Properties.Resources.nReina;
                pbTorre.Image = Properties.Resources.nTorre;
            }
        }

        private void pb_Click(object sender, EventArgs e)
        {
            if(((PictureBox)sender).Name == "pbCaballo")
            {
                piezaSelected = "Caballo";
                
            }
            if (((PictureBox)sender).Name == "pbReina")
            {
                piezaSelected = "Reina";
            }
            if (((PictureBox)sender).Name == "pbTorre")
            {
                piezaSelected = "Torre";
            }
            if (((PictureBox)sender).Name == "pbAlfil")
            {
                piezaSelected = "Alfil";
            }
            Enabled = false;
            this.Hide();
        }
    }
}
