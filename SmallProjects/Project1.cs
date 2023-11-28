namespace SmallProjects;

public  class Project1
{
    public void Test()
    {
        TestMenu();
    }
    public void TestMenu()
    {
        bool continueprogram = true;
        while (continueprogram)
        {
            Console.Clear();
            Console.WriteLine("Welcome in college Menu ");
            Console.WriteLine("1.Academic");
            Console.WriteLine("2.Campus Facilities");
            Console.WriteLine("3.Faculty & staff");
            Console.WriteLine("4.Student Life");
            Console.WriteLine("5.Resources");
            Console.WriteLine("6.Technology");
            Console.WriteLine("7.Regulations and Policies");
            Console.WriteLine("8 Exit");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            char key = keyInfo.KeyChar;
            Console.Clear();
            switch (key)
            {
                case '1':
                    Academic();
                    break;
                case '2':
                    Campus_Facilities();
                    break;
                case '3':
                    Facultystaff();
                    break;
                case '4':
                    StudentLife();
                    break;
                case '5':
                    Resources();
                    break;
                case '6':
                    Technology();
                    break;
                case '7':
                    RegulationsAndPolicies();
                    break;
                case '8':
                    continueprogram = false;
                    break;
                default:
                    Console.WriteLine("you press incorrct key. press the correct key.");
                    break;
            }
            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();
        }
        Console.WriteLine("Thank you ");
    }
    public void Academic()
    {
        Console.WriteLine("* Engineering");
        Console.WriteLine("* Managment");
        Console.WriteLine("* Science");
    }
    public void Campus_Facilities()
    {
        Console.WriteLine("* Classrooms");
        Console.WriteLine("* Lecture Hall");
        Console.WriteLine("* Laboratories");
        Console.WriteLine("* Libraries");
        Console.WriteLine("* Study Rooms");
        Console.WriteLine("* Sports Facilities");
    }
    public void Facultystaff()
    {
        try
        {
            Console.WriteLine("* Professors");
            Console.WriteLine("* Instructors");
            Console.WriteLine("* Teaching Assistants");
            Console.WriteLine("* Administrative");
            Console.WriteLine("* Support Staff");

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }



    }
    public void StudentLife()
    {
        try
        {

            Console.WriteLine("* Student Organisation");
            Console.WriteLine("* Events");
            Console.WriteLine("* Activite");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
    public void Resources()
    {
        try
        {
            Console.WriteLine("* Textbooks");
            Console.WriteLine("* Resurch Material");
            Console.WriteLine("* Career Service");
            Console.WriteLine("* counseling");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void Technology()
    {
        try
        {
            Console.WriteLine("* Computers");
            Console.WriteLine("* labs");
            Console.WriteLine("* Online Learning Platform");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void RegulationsAndPolicies()
    {
        try
        {
            Console.WriteLine("* Academic policies");
            Console.WriteLine("* Campus Regulations");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}
