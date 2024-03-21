using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BASICPROJECT1
{
    public class IFNELSE
    {
        public void TestIfElse()
        {
            Console.WriteLine("COMPARISION OF TWO NUMBER");
            int value1=Convert.ToInt32(Console.ReadLine()); 
            int value2=Convert.ToInt32(Console.ReadLine());
            if (value1 > value2)
            {
                Console.WriteLine("VALUE1 IS GREATER");
            }
            else
            {
                Console.WriteLine("VALUE2 IS GREATER");
            }
        }
    }
}
