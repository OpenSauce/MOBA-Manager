﻿using MOBA_Manager.DataModel;
using MOBA_Manager.Source.UI.InGame;
using System.Collections.Generic;
using System.Windows.Controls;

namespace MOBA_Manager.UI.InGame
{
    /// <summary>
    /// Interaction logic for BuyPlayersPage.xaml
    /// </summary>
    public partial class BuyPlayersPage : Page
    {
        public BuyPlayersPage(List<Player> playerList)
        {
            //List<Player> playerList;
            InitializeComponent();

            foreach (Player p in playerList)
            {
                BuyPlayerStackPanel.Children.Add(new BuyPlayerControl(p));
            }
        }
    }
}