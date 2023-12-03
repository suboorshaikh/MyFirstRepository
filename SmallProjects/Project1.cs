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
        bool continueprogram = true;
        while (continueprogram)
        {
            Console.WriteLine("----CAMPUS FACILITIES---");
            Console.WriteLine("1. Classrooms");
            Console.WriteLine("2. Lecture Hall");
            Console.WriteLine("3. Laboratories");
            Console.WriteLine("4. Libraries");
            Console.WriteLine("5. Study Rooms");
            Console.WriteLine("6. Sports Facilities");
            Console.WriteLine("7. Exit");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            char key = keyInfo.KeyChar;
            Console.Clear();
            switch (key)
            {
                case'1':
                    Classrooms(); 
                    break;
                case '2':
                    Lecture_Hall();
                    break;
                case '3':
                    Laboratories();
                    break;
                case '4':
                    Libraries();
                    break;
                case '5':
                    Study_Rooms();
                    break;
                case '6':
                    Sports_Facilities();
                    break;
                case '7':
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

    public void FacultyStaff()
    {
        bool continueprogram = true;
        while (continueprogram)
        {
            Console.WriteLine("---FACULTY STAFF---");
            Console.WriteLine("1. Professors");
            Console.WriteLine("2. Instructors");
            Console.WriteLine("3. Teaching Assistants");
            Console.WriteLine("4. Administrative");
            Console.WriteLine("5. Support Staff");
            Console.WriteLine("7. Exit");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            char key = keyInfo.KeyChar;
            Console.Clear();
            switch (key)
            {
                case '1':
                    Professors();
                    break;
                case '2':
                    Instructors();
                    break;
                case '3':
                    Teaching_Assistants();
                    break;
                case '4':
                    Administrative();
                    break;
                case '5':
                    Support_Staff();
                    break;
                case '6':
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
    public void Support_Staff()
    {
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
    }
    public void Administrative()
    {
        Console.WriteLine("--ADMINISTRATIVE--");
        Console.WriteLine("1. Admissions Office");
        Console.WriteLine("2. Financial Aid Office");
        Console.WriteLine("3. Human Resources (HR) Department");
        Console.WriteLine("4. Facilities Management");
        Console.WriteLine("5. Information Technology (IT) Department");
        Console.WriteLine("6. Student Affairs Office");
        Console.WriteLine("7.Alumni Relations Office");
        Console.WriteLine("8. Legal Affairs Office");
    }
    public void Teaching_Assistants()
    {
        Console.WriteLine("--TEACHING ASSISTANTS--");
        Console.WriteLine("1. Assisting with Instruction");
        Console.WriteLine("2. Grading Assignments");
        Console.WriteLine("3. Leading Discussion Sections");
        Console.WriteLine("4. Providing Support for Lab Work");
        Console.WriteLine("5. Assisting in Course Preparation");
       
    }
    public void Instructors()
    {
        Console.WriteLine("--INSTRUCTORS--");
        Console.WriteLine("1. Teaching");
        Console.WriteLine("2. Curriculum Development");
        Console.WriteLine("3. Research and Scholarship");
        Console.WriteLine("4. Participation in Committees");
        Console.WriteLine("5. Technology Integration");
       
    }
    public void Professors()
    {
        Console.WriteLine("--PROFESSORS--");
        Console.WriteLine("1. Professional Associations");
        Console.WriteLine("2. Community Engagement");
        Console.WriteLine("3. Lectures, Seminars, and Workshops");
        Console.WriteLine("4. Specializations");
        Console.WriteLine("5. Teaching Responsibilities");
        
    }
    public void StudentLife()
    {
        Console.WriteLine("---STUDENT LIFE---");
        Console.WriteLine("1. Student Organisation");
        Console.WriteLine("2. Events");
        Console.WriteLine("3. Activite");
        Console.WriteLine("7. Exit");
    }
    public void Resources()
    {
        Console.WriteLine("---RESOURCES---");
        Console.WriteLine("1. Textbooks");
        Console.WriteLine("2. Resurch Material");
        Console.WriteLine("3. Career Service");
        Console.WriteLine("4. counseling");
        Console.WriteLine("5. Exit");
    }
    public void Technology()
    {
        Console.WriteLine("---TECHNOLOGY---");
        Console.WriteLine("1. Computers");
        Console.WriteLine("2. labs");
        Console.WriteLine("3. Online Learning Platform");
        Console.WriteLine("4. Exit");
    }
    public void RegulationsAndPolicies()
    {
        Console.WriteLine("--REGULATION AND POLICIES--");
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
    public void Sports_Facilities()
    {
        Console.WriteLine("--SPORTS FACILITIES DETAILS--");
        Console.WriteLine("1.  Athletic Fields");
        Console.WriteLine("2.  Track and Field Facilities");
        Console.WriteLine("3.  Basketball Courts");
        Console.WriteLine("4.  Tennis Courts");
        Console.WriteLine("5.  Volleyball Courts");
        Console.WriteLine("6.  Swimming Pools");
        Console.WriteLine("7.  Gymnasiums");
        Console.WriteLine("8.  Weight Rooms and Fitness Centers");
        Console.WriteLine("9.  Athletic Training Rooms");
        Console.WriteLine("10. Locker Rooms");
        Console.WriteLine("11. Outdoor Recreation Spaces");
        Console.WriteLine("12. Scoreboards and Seating");
        Console.WriteLine("13. Sports Complex");
        Console.WriteLine("14. Indoor Running Tracks");
        Console.WriteLine("15. Sports Medicine and Rehabilitation Facilities");
        Console.WriteLine("16. Sports Science Laboratories");
        Console.WriteLine("17. Meeting and Coaching Rooms");
        Console.WriteLine("18. Intramural and Recreational Sports Areas");
        Console.WriteLine("19. Access Control and Security");
        Console.WriteLine("");
    }
    public void Study_Rooms()
    {
        Console.WriteLine("--STUDYROOMS DETAILS--");
        Console.WriteLine("1.  Quiet Environment");
        Console.WriteLine("2.  Individual Study Spaces");
        Console.WriteLine("3.  Group Study Areas");
        Console.WriteLine("4.  Whiteboards or Chalkboards");
        Console.WriteLine("5.  Power Outlets");
        Console.WriteLine("6.  Wi-Fi Access");
        Console.WriteLine("7.  Natural Lighting");
        Console.WriteLine("8.  Artificial Lighting");
        Console.WriteLine("9.  Comfortable Seating");
        Console.WriteLine("10. Lockers or Storage Space");
        Console.WriteLine("11  Curtains or Blinds");
        Console.WriteLine("12. Reservable Spaces");
        Console.WriteLine("13. Temperature Control");
        Console.WriteLine("14. Accessibility Features");
        Console.WriteLine("15. Security Systems");
        Console.WriteLine("16. Collaborative Technologies");
        Console.WriteLine("17. Bulletin Boards or Information Displays");

    }
    public void Libraries()
    {
        Console.WriteLine("--LIBRARIES DETAILS--");
        Console.WriteLine("1.  Collection of Books");
        Console.WriteLine("2.  Electronic Resources");
        Console.WriteLine("3.  Study Spaces");
        Console.WriteLine("4.  Computer and Printing Facilities");
        Console.WriteLine("5.  Librarians and Research Assistance");
        Console.WriteLine("6.  Periodicals and Journals");
        Console.WriteLine("7.  Special Collections");
        Console.WriteLine("8.  Audio-Visual Materials");
        Console.WriteLine("9.  Meeting Rooms and Seminar Spaces");
        Console.WriteLine("10. Café or Lounge Area");
        Console.WriteLine("11. Wi-Fi and Internet Access");
        Console.WriteLine("12. Thesis and Dissertation Collection");
        Console.WriteLine("13. Interlibrary Loan Services");
        Console.WriteLine("14. Library Catalog and Online Catalog");
        Console.WriteLine("15. Accessibility Features");
        Console.WriteLine("16. Security Systems");
        Console.WriteLine("17. Events and Exhibitions");

    }
    public void Laboratories()
    {
        Console.WriteLine("--LABORATORIES DETAILS--");
        Console.WriteLine("1.  Workstations");
        Console.WriteLine("2.  Laboratory Equipment:");
        Console.WriteLine("3.  Safety Equipment");
        Console.WriteLine("4.  Fume Hoods");
        Console.WriteLine("5.  Sinks and Water Supply");
        Console.WriteLine("6.  Storage Cabinets");
        Console.WriteLine("7.  Ventilation Systems");
        Console.WriteLine("8.  Whiteboards or Chalkboards");
        Console.WriteLine("9.  Computers and Data Analysis Tools");
        Console.WriteLine("10. Computers and Data Analysis Tools");
        Console.WriteLine("11. Waste Disposal");
        Console.WriteLine("12. Emergency Equipment");
        Console.WriteLine("13. Audio-Visual Equipment");
        Console.WriteLine("14. Microbiology Safety Cabinets");
        Console.WriteLine("15. Electrical Outlets");
        Console.WriteLine("16. Projector or Display Screens");
        Console.WriteLine("17. Flexible Layout");
    }
    public void Lecture_Hall()
    {
        Console.WriteLine("--LACTURE HALL DETAILS--");
        Console.WriteLine("1.  Tiered Seating");
        Console.WriteLine("2.  Aisles and Walkways");
        Console.WriteLine("3.  Platform or Stage");
        Console.WriteLine("4.  Audio-Visual Equipment");
        Console.WriteLine("5.  Whiteboards or Chalkboards");
        Console.WriteLine("6.  Technology Integration");
        Console.WriteLine("7.  Internet Connectivity");
        Console.WriteLine("8.  Lighting and Acoustics");
        Console.WriteLine("9.  Seating Capacity");
        Console.WriteLine("10. Accessibility Features");
        Console.WriteLine("11. Recording Equipment");
        Console.WriteLine("12. Classroom Control System");
        Console.WriteLine("13. Emergency Exits");
        Console.WriteLine("14. Wireless Connectivity");
    }
    public void Classrooms()
    {
        Console.WriteLine("--CLASSROOM DETAILS--");
        Console.WriteLine("1. Seating Arrangements");
        Console.WriteLine("2.  Technology Integration");
        Console.WriteLine("3.  Professor's Podium");
        Console.WriteLine("4.  Whiteboards or Blackboards");
        Console.WriteLine("5.  Internet Connectivity");
        Console.WriteLine("6.  Comfortable Seating");
        Console.WriteLine("7.  Lighting and Ventilation");
        Console.WriteLine("8.  Classroom Size");
        Console.WriteLine("9.  Accessibility Features");
        Console.WriteLine("10. Recording Equipment");
        Console.WriteLine("11. Discussion Areas");
        Console.WriteLine("12. Resource Materials");
    }
}
