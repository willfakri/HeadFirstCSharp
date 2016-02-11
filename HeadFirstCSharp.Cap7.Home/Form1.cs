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
        private Opponent _oponent;
        private int _movimentos = 0;

        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            MoveToNewLocation(_currentLocation);
        }

        private void CreateObjects()
        {
            OutsideWithDoor quintalFrente = new OutsideWithDoor(false, "Quintal da Frente", "");
            OutsideWithHidingPlace jardim = new OutsideWithHidingPlace(false, "Jardim", "galpão");
            OutsideWithDoor quintalFundo = new OutsideWithDoor(true, "Quintal dos Fundos", "");
            RoomWithDoor salaEstar = new RoomWithDoor("Porta de entrada da frente", "Carpete Antigo", "Sala de Estar", "");
            Room salaJantar = new Room("Candelabro de Cristal", "Sala de Jantar");
            RoomWithDoor cozinha = new RoomWithDoor("Porta com Tela para fundos", "Detalhes em Aço Inox", "Cozinha", "");
            
            RoomWithDoor escadas = new RoomWithDoor("Escadas para Hall Superior", "Corrimão de Madeira", "Escadas", "");
            RoomWithDoor hallway = new RoomWithDoor("Escadas para sala de estar", "quadro de cachorro pulguento e armário", "Hall Superior", "");
            RoomWithHidingPlace quartoPrincipal = new RoomWithHidingPlace("cama grande", "Quarto Principal", "debaixo da cama");
            RoomWithHidingPlace quartoSecundario = new RoomWithHidingPlace("cama pequena", "Segundo quarto", "debaixo da cama");
            RoomWithHidingPlace banheiro = new RoomWithHidingPlace("pia e vaso sanitário", "Banheiro", "chuveiro");
            OutsideWithHidingPlace calcada = new OutsideWithHidingPlace(false, "Calçada", "garagem");

            quintalFrente.Exits = new Location[] { salaEstar, jardim, calcada };
            quintalFrente.DoorLocation = salaEstar;

            jardim.Exits = new Location[] { quintalFrente, quintalFundo };

            quintalFundo.Exits = new Location[] { cozinha, jardim, calcada };
            quintalFundo.DoorLocation = cozinha;

            calcada.Exits = new Location[] { quintalFrente, quintalFundo };

            salaEstar.Exits = new Location[] { quintalFrente, salaJantar, escadas };
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

            _oponent = new Opponent(_currentLocation);
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
            NameCheckButton();
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
        
        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (_oponent.Check(_currentLocation))
            {
                MessageBox.Show("Ganhou do trouxa que não sabe se esconder!");
            }
            else
            {
                _oponent.Move();
                _movimentos++;
            }

            if (_movimentos == 10)
            {
                MessageBox.Show("Perdeu, otário que não sabe procurar!");
            }
        }

        private void MoveStart()
        {
            for (int i = 0; i < 10; i++)
            {
                _oponent.Move();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            MoveStart();
            
            for (int i = 10; i > 0; i--)
            {                
                txtDescription.Text = $"{i}...";
                Application.DoEvents();
                System.Threading.Thread.Sleep(350);
            }
            txtDescription.Text = "Pronto ou não, ai vou eu!";
            NameCheckButton();
        }

        public void NameCheckButton()
        {
            if (_currentLocation is IHidingPlace)
            {
                btnCheck.Visible = true;
                btnCheck.Text = $"Procurar em {((IHidingPlace)_currentLocation).PlaceToHiding}";
            }
            else
            {
                btnCheck.Visible = false;
            }
        }
    }
}