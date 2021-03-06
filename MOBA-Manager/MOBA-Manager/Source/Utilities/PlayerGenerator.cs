﻿using MOBA_Manager.DataModel;
using MOBA_Manager.Source.DataModel;
using RandomNameGeneratorLibrary;
using System;
using System.Collections.Generic;
using System.Windows.Media.Imaging;

namespace MOBA_Manager.Game
{
    internal class PlayerGenerator : IPlayerFactory
    {
        private const int MAX_PLAYERS = 100;
        private int assignedID = 0;
        private PersonNameGenerator _g;

        public PlayerGenerator()
        {
            _g = new PersonNameGenerator();
        }

        public List<Player> LoadPlayers()
        {
            return GenerateListOfPlayers();
        }

        public List<Player> GenerateListOfPlayers()
        {
            List<Player> listOfPlayers = new List<Player>();
            for (int i = 0; i < MAX_PLAYERS; i++)
            {
                listOfPlayers.Add(GenerateNewPlayer());
            }
            return listOfPlayers;
        }

        public List<Player> GeneratePlayers(int numberOfPlayers)
        {
            List<Player> playerList = new List<Player>();
            for (int i = 0; i < numberOfPlayers; i++)
            {
                playerList.Add(GenerateNewPlayer());
            }
            return playerList;
        }

        public Player GenerateNewPlayer()
        {
            int number = ControlledRandom.RandomNumber(0, 10);
            if (number < 5)
            {
                return GenerateNewPlayer(_g.GenerateRandomMaleFirstName(), "", _g.GenerateRandomLastName(), true);
            }
            else
            {
                return GenerateNewPlayer(_g.GenerateRandomFemaleFirstName(), "", _g.GenerateRandomLastName(), false);
            }
        }

        private int GetPlayerID()
        {
            return assignedID++;
        }

        public Player GenerateNewPlayer(String firstName, String middleName, String lastName, bool gender)
        {
            Player generatedPlayer = new Player(firstName, middleName, lastName);
            generatedPlayer.Age = ControlledRandom.RandomNumber(16, 26);
            generatedPlayer.PopulateSkills(ControlledRandom.RandomNumber(1, 200));
            generatedPlayer.IconIndex = GetPlayerPortrait(gender);
            generatedPlayer.ID = GetPlayerID();
            generatedPlayer.PlayerRole = GetPlayerRole();
            return generatedPlayer;
        }

        private ROLE GetPlayerRole()
        {
            return (ROLE)ControlledRandom.RandomNumber(0, 4);
        }

        public static BitmapImage GetPlayerPortrait(bool male)
        {
            BitmapImage bi = new BitmapImage();
            bi.BeginInit();
            int number = ControlledRandom.RandomNumber(0, 15);
            var myString = number < 10 ? "0" + number : number.ToString();
            var gender = male ? "male" : "female";
            bi.UriSource = new Uri(@"\Assets\Pixel Portraits\" + gender + "_" + myString + ".png", UriKind.RelativeOrAbsolute);
            bi.EndInit();
            return bi;
        }
    }
}