namespace InterfaceTest
{
    public class TallGuy
    {
        public string Name;
        public int Height;

        public void TalkAboutYourself()
        {
            Console.WriteLine($"Nazywam się {Name}. Mam {Height} cm wzrostu.");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            TallGuy tallGuy = new TallGuy() { Height = 170, Name = "Kamil" };
            tallGuy.TalkAboutYourself();
        }
    }
}