// See https://aka.ms/new-console-template for more information
class Program
{
    public const int IS_PART_TIME = 1;
    public const int IS_FULL_TIME = 2;
    public const int EMP_RATE_PER_HOUR = 20;
    public const int NUM_OF_WORKING_DAYS = 2;
    public const int MAX_HRS_IN_MONTH = 10;

    public static void Main(string[] args)
      {
        //variables
        int empHrs = 0;
        int totalempHrs = 0;
        int totalworking_days = 0;
        //computation
        while(totalempHrs <= MAX_HRS_IN_MONTH && totalworking_days < NUM_OF_WORKING_DAYS) 
        { 
            totalworking_days++;
            Random random = new Random();
            int empcheck = random.Next(0, 3);
            switch (empcheck)
            {
                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            totalempHrs += empHrs;
            Console.WriteLine("Days:" + totalworking_days + " emp hrs : " + empHrs);
        }
        int totalempWage = totalempHrs * EMP_RATE_PER_HOUR;
        Console.WriteLine("total emp wage : " + totalempWage);
    }
}

