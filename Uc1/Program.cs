class Program
{
     static void Main(String [] args)
    {
        //constatnts
        int IS_FULL_TIME = 1;
        Random random = new Random();
        //computation
        int empcheck = random.Next(0, 2);
        if (empcheck == IS_FULL_TIME)
        {
            Console.WriteLine("employee is present");

        }
        else
        {
            Console.WriteLine("employee is not present");
        }

    }
}