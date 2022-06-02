using InterfaceTest;

namespace InterfaceTest
{
    

    }
public class Program
{
    static void Main(string[] args)
    {
        IClown fingersTheClown = new ScaryScary(14, "wielkie czerwone nosy");
        fingersTheClown.Honk();
        if (fingersTheClown is IScaryClown iScaryClownReference)
        {
            iScaryClownReference.ScareLittleChildren();
        }

    }
}