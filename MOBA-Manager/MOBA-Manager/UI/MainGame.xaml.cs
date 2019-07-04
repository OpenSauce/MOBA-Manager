﻿using MOBA_Manager.Game;
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
        }
    }
}