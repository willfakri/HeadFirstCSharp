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
        private Location _currentLocation;

        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            MoveToNewLocation(_currentLocation);
        }

        private void CreateObjects()
        {
            OutsideWithDoor quintalFrente = new OutsideWithDoor(false, "Quintal da Frente");
            Outside jardim = new Outside(false, "Jardim");
            OutsideWithDoor quintalFundo = new OutsideWithDoor(true, "Quintal dos Fundos");
            RoomWithDoor salaEstar = new RoomWithDoor("Porta de entrada da frente", "Carpete Antigo", "Sala de Estar");
            Room salaJantar = new Room("Candelabro de Cristal", "Sala de Jantar");
            RoomWithDoor cozinha = new RoomWithDoor("Porta com Tela para fundos", "Detalhes em Aço Inox", "Cozinha");

            RoomWithDoor escadas = new RoomWithDoor("Escadas para Hall Superior", "Corrimão de Madeira", "Escadas");
            RoomWithDoor hallway = new RoomWithDoor("Escadas para sala de estar", "quadro de cachorro pulguento e armário", "Hall Superior");
            Room quartoPrincipal = new Room("cama grande", "Quarto Principal");
            Room quartoSecundario = new Room("cama pequena", "Segundo quarto");
            Room banheiro = new Room("pia e vaso sanitário", "Banheiro");

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

            quartoPrincipal.Exits = new Location[] { hallway };

            quartoSecundario.Exits = new Location[] { hallway };

            escadas.Exits = new Location[] { hallway, salaEstar };
            escadas.DoorLocation = hallway;

            hallway.Exits = new Location[] { quartoPrincipal, quartoSecundario, banheiro, escadas };
            hallway.DoorLocation = escadas;

            _currentLocation = quintalFrente;
        }

        private void MoveToNewLocation(Location currentLocation)
        {
            _currentLocation = currentLocation;

            ddlExits.Items.Clear();

            for (int i = 0; i < _currentLocation.Exits.Length; i++)
            {
                ddlExits.Items.Add(_currentLocation.Exits[i].Name);
            }
            ddlExits.SelectedIndex = 0;

            txtDescription.Text = _currentLocation.Description;

            if (_currentLocation is IHasExteriorDoor)
            {
                btnGoThroughtTheDoor.Visible = true;
            }
            else
            {
                btnGoThroughtTheDoor.Visible = false;
            }
        }

        private void btnGoHere_Click(object sender, EventArgs e)
        {
            MoveToNewLocation(_currentLocation.Exits[ddlExits.SelectedIndex]);           
        }

        private void btnGoThroughtTheDoor_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor exteriorLocation = _currentLocation as IHasExteriorDoor;
            MoveToNewLocation(exteriorLocation.DoorLocation);
        }
    }
}
