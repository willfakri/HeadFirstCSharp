using HeadFirstCSharp.Cap7.Home.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeadFirstCSharp.Cap7.Home
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateObjects();
        }

        private void CreateObjects()
        {
            OutsideWithDoor quintalFrente = new OutsideWithDoor(false, "Quintal da Frente");
            Outside jardim = new Outside(false, "Jardim");
            OutsideWithDoor quintalFundo = new OutsideWithDoor(true, "Quintal dos Fundos");
            RoomWithDoor salaEstar = new RoomWithDoor("Porta de entrada da frente", "Carpete Antigo", "Sala de Estar");
            Room salaJantar = new Room("Candelabro de Cristal", "Sala de Jantar");
            RoomWithDoor cozinha = new RoomWithDoor("Porta com Tela para fundos", "Detalhes em Aço Inox", "Cozinha");

            quintalFrente.Exits = new Location[] { salaEstar, jardim };
            quintalFrente.DoorLocation = salaEstar;

            jardim.Exits = new Location[] { quintalFrente, quintalFundo };

            quintalFundo.Exits = new Location[] { cozinha, jardim };
            quintalFundo.DoorLocation = cozinha;

            salaEstar.Exits = new Location[] { quintalFrente, salaJantar };
            salaEstar.DoorLocation = quintalFrente;

            salaJantar.Exits = new Location[] { salaEstar, cozinha };

            cozinha.Exits = new Location[] { salaJantar, quintalFundo };
            cozinha.DoorLocation = quintalFundo;
        }
    }
}
