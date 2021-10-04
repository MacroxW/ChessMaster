using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessMaster
{
    public partial class Lobby
    {
        public string lobby;
        public char ColorJug1;
        public char ColorJug2;
        public Lobby()
        {
            
        }

        public Lobby(string lobby, char colorJug1, char colorJug2)
        {
            this.lobby = lobby;
            ColorJug1 = colorJug1;
            ColorJug2 = colorJug2;
        }
    }
}
