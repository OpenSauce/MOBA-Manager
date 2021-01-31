﻿using MOBA_Manager.Game;
using MOBA_Manager.UI.InGameUI;
using System.Windows;
using System.Windows.Controls;

namespace MOBA_Manager.UI
{
    /// <summary>
    /// Interaction logic for MainGame.xaml
    /// </summary>
    public partial class MainGame : Page
    {
        private MainGameEngine gameEngine;

        public MainGame()
        {
            InitializeComponent();
        }

        public MainGame(MainGameEngine gameEngine)
        {
            this.gameEngine = gameEngine;
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
            FullNameLabel.Content = gameEngine.PlayerSession.GetUserFullName();
            CashLabel.Content = gameEngine.PlayerSession.GetCash();
        }

        private void AllPlayerButton_Click(object sender, RoutedEventArgs e)
        {
            InMainGameFrame.Navigate(new AllPlayersPage(this.gameEngine.PlayerSession.GetPlayerList()));
        }

        private void BuyPlayersButton_Click(object sender, RoutedEventArgs e)
        {
            InMainGameFrame.Navigate(new BuyPlayersPage(this.gameEngine.PlayerSession.GetPlayerList()));
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            InMainGameFrame.Navigate(new HomeScreenPage());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.gameEngine.ProceedGame();
            SetupUI();
            InMainGameFrame.Navigate(new MOBA_Manager.UI.InGameUI.HomeScreenPage());
        }

        private void AllTeamsButton_Click(object sender, RoutedEventArgs e)
        {
            InMainGameFrame.Navigate(new AllTeamsPage(this.gameEngine.PlayerSession.GetTeamList()));
        }
    }
}