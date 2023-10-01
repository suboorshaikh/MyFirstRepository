namespace HOMEWORK;

public class Concatenation
{
    public static void FunctionA()
    {
        Console.WriteLine("-----------Concatenation------------");
        string fullName = "SUBOOR" + " " + "SHAIKH";
        Console.WriteLine(fullName);
        Console.WriteLine("Enter your name");
        string name = Console.ReadLine();
        Console.WriteLine("Enter your surname");
        string surname = Console.ReadLine();

        Console.WriteLine(surname + " " + name);//Associativity is Left to Right

    }

}
public class Placeholdermethod
{
    public static void FunctionB()
    {
        Console.WriteLine("-----------Placeholder method----------");
        Console.WriteLine("address line 1");
        string line1 = Console.ReadLine();
        Console.WriteLine("address line 2");
        string line2 = Console.ReadLine();
        Console.WriteLine("address line 3");
        string line3 = Console.ReadLine();
        Console.WriteLine("pin code");
        string pincode = Console.ReadLine();
        Console.WriteLine("{0} {1} {2} {3}", line1, line2, line3, pincode);


    }
}
public class InterpolationMethod
{
    public static void FunctionC()
    {
        Console.WriteLine("-----------Interpolation method----------");
        Console.WriteLine("Mobile no");
        string Mobileno = Console.ReadLine();
        Console.WriteLine("G mail");
        string gmail = Console.ReadLine();
        Console.WriteLine("Reffer Name");
        string reffername = Console.ReadLine();
        Console.WriteLine($"Mobile no={Mobileno} G mail={gmail} reffer name = {reffername}");
    }
}