﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MOBA_Manager.DataModel;

namespace MOBA_Manager.Game
{
    class PlayerGenerator : IPlayerFactory
    {
        private const int MAX_PLAYERS = 100;

        public List<Player> LoadPlayers()
        {
            return GenerateListOfPlayers(new List<Player>());
        }

        private List<Player> GenerateListOfPlayers(List<Player> listOfPlayers)
        {
            for(int i = 0; i<MAX_PLAYERS; i++)
            {
                listOfPlayers.Add(GenerateNewPlayer("GeneratedPlayer", i.ToString()));
            }
            return listOfPlayers;
        }

        private Player GenerateNewPlayer(String firstName, String lastName)
        {
            Player generatedPlayer = new Player(firstName, lastName);
            generatedPlayer.SetSkillset(new PlayerSkill().PopulateSkills(ControlledRandom.RandomNumber(0, 100)));
            return generatedPlayer;
        }
    }
}
