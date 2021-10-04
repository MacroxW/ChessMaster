using System;
using System.Text;
using System.Windows.Forms;

namespace ChessMaster
{
    public partial class FormLobby : Form
    {
        public FormLobby()
        {
            InitializeComponent();
            lblCodigo.Text = "";
            rbtnJug2Blancas.Enabled = false;
            rbtnBlancas.Enabled = true;
            rbtnJug1Negras.Enabled = true;
            rbtnJug2Negras.Enabled = false;
        }
        private string GenerarCodigo()
        {

            int longitud = 5;
            const string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            StringBuilder token = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < longitud; i++)
            {
                int indice = rnd.Next(alfabeto.Length);
                token.Append(alfabeto[indice]);
            }

            while (BD.ValidarCodigo(token.ToString()) == false)
            {
                for (int i = 0; i < longitud; i++)
                {
                    int indice = rnd.Next(alfabeto.Length);
                    token.Append(alfabeto[indice]);
                }
            }
            return token.ToString();
        }
        private void btnCrearLobby_Click(object sender, EventArgs e)
        {
            btnUnirse.Enabled = false;
            string codigo = GenerarCodigo();
            char colorJug1;
            char colorJug2;
            rbtnBlancas.Enabled = false;
            rbtnJug1Negras.Enabled = false;
            lblCodigo.Text = codigo;
            btnCrearLobby.Enabled = false;

            if (rbtnBlancas.Checked == true)
            {
                colorJug1 = 'b';
                colorJug2 = 'n';
            }
            else
            {
                colorJug1 = 'n';
                colorJug2 = 'b';
            }



            BD.CrearLobby(codigo, colorJug1, colorJug2);

        }

        private void FormLobby_Load(object sender, EventArgs e)
        {

        }

        private void rbtnBlancas_CheckedChanged(object sender, EventArgs e)
        {

            rbtnJug2Negras.Checked = true;
        }


        private void rbtnJug1Negras_CheckedChanged(object sender, EventArgs e)
        {
            rbtnJug2Blancas.Checked = true;
        }

        private void rbtnJug2Blancas_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnJug2Negras_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnUnirse_Click(object sender, EventArgs e)
        {
            Lobby miLobby = new Lobby();
            miLobby = BD.UnirseAlLobby(textBox1.Text.ToUpper().ToString());
            rbtnBlancas.Enabled = false;
            rbtnJug1Negras.Enabled = false;
            if (miLobby != null)
            {
                if (miLobby.ColorJug1 == 'b')
                {
                    rbtnBlancas.Checked = true;
                }
                else
                {
                    rbtnJug1Negras.Checked = true;
                }

            }
            else
            {
                MessageBox.Show("no se encontró la lobby");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //crear 

    }
}
