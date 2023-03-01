using System.Xml.Schema;

public class program
{
    public static void Main()
    {
        pattern1();
        pattern2();
            
        static void pattern1()
        {
            for(int i =1; i <= 10; i++) // rows
            {
                for (int j = 1; j <= 10; j++) // coloum
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void pattern2()
        {
            for(int i = 1; i<= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }


    }
}