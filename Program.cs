﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManStarterKit
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p = new ABCplayer();
            Player p2 = new RandomPlayer();
            //Need to add in how to handle multi letter words like apple
            HangmanGame hg = new HangmanGame(p2);
        }
    }
}
