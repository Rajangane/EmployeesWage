using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineCompProb_Uc2
{
    public class EqualCheck
    {
        public void CalEquCheck()
        {
            int x1, x2, y1, y2;
            Console.WriteLine("Enter coordinates for First line");
            Console.WriteLine("Enter values of the coordinates for first point(x1,y1)");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter values of the coordinates for second point(x2,y2)");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());

            float line1length;
            line1length = (float)(Math.Sqrt((Math.Pow(x2 - x1, 2)) + (Math.Pow(y2 - y1, 2))));
            Console.WriteLine("Length of the line1 is: " + line1length);

            int a1, a2, b1, b2;
            Console.WriteLine("Enter coordintes for Second Line");
            Console.WriteLine("Enter values of the coordinates for first point(a1,b1)");
            a1 = Convert.ToInt32(Console.ReadLine());
            b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter values of the coordinates for second point(a2,b2)");
            a2 = Convert.ToInt32(Console.ReadLine());
            b2 = Convert.ToInt32(Console.ReadLine());

            float line2length;
            line2length = (float)(Math.Sqrt((Math.Pow(a2 - a1, 2)) + (Math.Pow(b2 - b1, 2))));
            Console.WriteLine("Length of the line2 is: " + line2length);

            if (line1length.Equals(line2length))
            {
                Console.WriteLine("Value of both the lines are equal");
            }
            else
            {
                Console.WriteLine("Value of both the lines are not equal");
            }
        }

    }
}
