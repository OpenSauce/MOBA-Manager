﻿using MOBA_Manager.src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MOBA_Manager
{
    /// <summary>
    /// Interaction logic for SquadPage.xaml
    /// </summary>
    public partial class PlayerSearchPage : Page
    {
        private MainGame _window;

        public PlayerSearchPage()
        {
            InitializeComponent();
        }

        public PlayerSearchPage(MainGame window)
        {
            this._window = window;
            InitializeComponent();
        }

        public void PopulateSquadBox(List<MOBAPlayer> playerList)
        {
            foreach (var MOBAPlayer in playerList)
            {
                var row = new {Name = MOBAPlayer.Nickname, Age = MOBAPlayer.Age, Role = MOBAPlayer.Role, Salary = MOBAPlayer.Salary};
                SquadListView.Items.Add(row);
            }
        }

        private void SquadListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine(SquadListView.Items.IndexOf(SquadListView.SelectedItem));
            MOBAPlayer player = _window.GetSession().GetPlayerIndex(SquadListView.Items.IndexOf(SquadListView.SelectedItem));
            _window.SetSquadFrame(new PlayerPage(this, player));
        }

        public void ReturnPage()
        {
            _window.SetSquadFrame(this);
        }
    }
}