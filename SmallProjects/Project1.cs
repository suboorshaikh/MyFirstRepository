namespace SmallProjects;

public class Project1
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
                    FacultyStaff();
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
        bool continueprogram = true;
        while (continueprogram)
        {
            Console.WriteLine("--ACADEMICS--");
            Console.WriteLine("1. Engineering");
            Console.WriteLine("2. Businesss");
            Console.WriteLine("3. Social Science ");
            Console.WriteLine("4. Exit");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            char key = keyInfo.KeyChar;
            Console.Clear();
            switch (key)
            {
                case'1':
                    Engineering();
                    break;
                case '2':
                    BusniessManagement();
                    break;
                case '3':
                    Social_Science();
                    break;
                case '4':
                    continueprogram = false;
                    break;
                default:
                    Console.WriteLine("you press incorrct key. press the correct key.");
                    break;
            }
            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();
        }
        Console.WriteLine("Thank you");
    }

    
    public void Campus_Facilities()
    {
        Console.WriteLine("----CAMPUS FACILITIES---");
        Console.WriteLine("1. Classrooms");
        Console.WriteLine("2. Lecture Hall");
        Console.WriteLine("3. Laboratories");
        Console.WriteLine("4. Libraries");
        Console.WriteLine("5. Study Rooms");
        Console.WriteLine("6. Sports Facilities");
        Console.WriteLine("7. Exit");
    }
    public void FacultyStaff()
    {
        Console.WriteLine("---FACULTY STAFF---");
        Console.WriteLine("1. Professors");
        Console.WriteLine("2. Instructors");
        Console.WriteLine("3. Teaching Assistants");
        Console.WriteLine("4. Administrative");
        Console.WriteLine("5. Support Staff");
        Console.WriteLine("7. Exit");
    }
    public void StudentLife()
    {
        Console.WriteLine("1. Student Organisation");
        Console.WriteLine("2. Events");
        Console.WriteLine("3. Activite");
        Console.WriteLine("7. Exit");
    }
    public void Resources()
    {
        Console.WriteLine("1. Textbooks");
        Console.WriteLine("2. Resurch Material");
        Console.WriteLine("3. Career Service");
        Console.WriteLine("4. counseling");
        Console.WriteLine("5. Exit");
    }
    public void Technology()
    {
        Console.WriteLine("1. Computers");
        Console.WriteLine("2. labs");
        Console.WriteLine("3. Online Learning Platform");
        Console.WriteLine("4. Exit");
    }
    public void RegulationsAndPolicies()
    {
        Console.WriteLine("1. Academic policies");
        Console.WriteLine("2. Campus Regulations");
        Console.WriteLine("3. Exit");
    }
    public void Engineering()
    {
        Console.WriteLine( "ENGINEERING COURSES");
        Console.WriteLine("1. Civil Engineering");
        Console.WriteLine("2. Mechanical Engineering");
        Console.WriteLine("3. Electrical Engineering");
        Console.WriteLine("4. Computer Science and Engineering");
        Console.WriteLine("5. Chemical Engineering");
        Console.WriteLine("6. Automobile Engineering");
        Console.WriteLine("7. Aerospace Engineering");
    }
    public void BusniessManagement()
    {
        Console.WriteLine( "BUSINESS MANAGEMENT COURSES");
        Console.WriteLine("1. Bachelor of Business Administration (BBA)");
        Console.WriteLine("2. Bachelor of Management Studies (BMS)");
        Console.WriteLine("3. Integrated BBA + MBA Programs");
        Console.WriteLine("4. Master of Business Administration (MBA)");
        Console.WriteLine("5. Post Graduate Diploma in Management (PGDM)");
        Console.WriteLine("6. Master of Management Studies (MMS)");
        Console.WriteLine("7. Certificate Programs in Management");
        Console.WriteLine("8. Specialized MBA Programs");
        Console.WriteLine("9. Online MBA Programs");
    }
    public void Social_Science()
    {
        Console.WriteLine( "SOCIAL SCIENCES COURSES");
        Console.WriteLine("1. Bachelor of Arts (B.A.) in Social Sciences");
        Console.WriteLine("2. Bachelor of Social Work (BSW)");
        Console.WriteLine("3. Bachelor of Science (B.Sc.) in Social Sciences");
        Console.WriteLine("4. Bachelor of Social Sciences (Hons.)");
        Console.WriteLine("5. Master of Arts (M.A.) in Social Sciences");
        Console.WriteLine("6. Master of Social Work (MSW)");
        Console.WriteLine("7. Master of Science (M.Sc.) in Social Sciences");
        Console.WriteLine("8. Master of Social Sciences (M.Soc.Sc.)");
        Console.WriteLine("9. Master of Philosophy (M.Phil) in Social Sciences");
        Console.WriteLine("10. Doctor of Philosophy (Ph.D.) in Social Sciences");
        Console.WriteLine("11. Integrated M.A.-Ph.D. Programs");
        Console.WriteLine("12. Post Graduate Diploma in Social Work (PGDSW)");
    }

}
