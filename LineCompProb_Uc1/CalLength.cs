using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineCompProb_Uc1
{
    public class CalLength
    {
        
        public void CalculateLength()
        {
            
                int x1, x2, y1, y2;
                Console.WriteLine("Enter values of the coordinates for first point(x1,y1)");
                x1 = Convert.ToInt32(Console.ReadLine());
                y1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter values of the coordinates for second point(x2,y2)");
                x2 = Convert.ToInt32(Console.ReadLine());
                y2 = Convert.ToInt32(Console.ReadLine());
                float length;
                length = (float)(Math.Sqrt((Math.Pow(x2 - x1, 2)) + (Math.Pow(y2 - y1, 2))));
                Console.WriteLine("Length of the line is: " + length);
            

        }
    }
}
