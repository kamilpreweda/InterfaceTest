using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest
{
    public class ScaryScary : FunnyFunny, IScaryClown
    {
        private int scaryThingCount;

        public string ScaryThingIHave { get { return $"pająki - {scaryThingCount}"; } }


        public ScaryScary(int scaryThingCount, string funnyThing) : base(funnyThing)
        {
            this.scaryThingCount = scaryThingCount;
            
        }

        public void ScareLittleChildren()
        {
            Console.WriteLine($"Ha! Mam was! Zobaczcie moje {ScaryThingIHave}.");
        }
    }
}
