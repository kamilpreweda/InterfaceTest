namespace InterfaceTest
{
    public class TallGuy : IClown
    {
        public string Name;
        public int Height;
        public string FunnyThingIHave { get { return "wielkie buty"; } }

        public void TalkAboutYourself()
        {
            Console.WriteLine($"Nazywam się {Name}. Mam {Height} cm wzrostu.");
        }

        public void Honk()
        {
            Console.WriteLine("Bip, bip!");
        }

       
        
    }
    public class Program
    {
        static void Main(string[] args)
        {
            TallGuy tallGuy = new TallGuy() { Height = 170, Name = "Kamil" };
            tallGuy.TalkAboutYourself();
            Console.WriteLine($"Ten wysoki gość ma {tallGuy.FunnyThingIHave}.");
            tallGuy.Honk();
        }
    }
}