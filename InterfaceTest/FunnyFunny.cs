﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest
{
    public class FunnyFunny : IClown
    {
        private string funnyThingIHave;
        public FunnyFunny(string funnyThingIHave)
        {
            this.funnyThingIHave = funnyThingIHave;
        }
        
        public void Honk()
        {
            Console.WriteLine($"Cześć dzieciaki! Mam {funnyThingIHave}.");
        }

        
    }
}
