﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOBA_Manager.Game
{
    class Session
    {
        public Session() 
        {
        }

        public void LoadGameEntities()
        {
            Console.WriteLine("Entities loaded KEEEK");
            IPlayerFactory hello = new PlayerGenerator();
            hello.DoIt();
        }
    }
}
