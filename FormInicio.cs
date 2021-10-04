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
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void btn_Local_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTablero form1 = new FormTablero();
            form1.Show();

        }

        private void btn_Online_Click(object sender, EventArgs e)
        {
            //   10.128.8.16

            this.Hide();
            FormLobby frmLobby = new FormLobby();
            frmLobby.Show();


        }
    }
}
