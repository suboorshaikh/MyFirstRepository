using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BASICPROJECT1
{
    public class PP1
    {
        public void Test()
        {
            IntegerArray();
            Pyramid();
        }
        public void IntegerArray()
        {
            int[] a = { 1, 2, 3 };
            int[] b = { 1, 2, };
            int[] c = a.Concat(b).ToArray();
            Console.WriteLine( string.Join(", ",c));
        }
        public void Pyramid()
        {
            int i,j,k, space;
            Console.Write("enter the numbers of rows of pyramid");
            i=Convert.ToInt32(Console.ReadLine());
            for (j = 1; j <= i; j++)
            {
                for (space=1 ; space<=i-j; space++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= 2*j-1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine( );
            }
            Console.WriteLine();
        }
    }
}
