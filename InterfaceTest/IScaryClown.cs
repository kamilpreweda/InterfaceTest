using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest
{
    public interface IScaryClown : IClown
    {
        public string ScaryThingIHave { get; }
        public void ScareLittleChildren();

        public void ScareAdults()
        {
            Console.WriteLine($@"Jestem pradawnym złem prześladującym cię we snach.
Spójrz na mój przerażający naszyjnik z {random.Next(4, 10)} palcami moich ofair.
A, byłbym zapomniał...");
            ScareLittleChildren();
        }
    }


}
