//output is
/*
    ----*
    ---**
    --***
    -****
    *****
 */



namespace Pattern3
{
    class Program
    { 
        public static void Main(string[] args) 
        {
            for (int i =1; i <= 5; i++)
            {
                for (int j =i; j <=5; j++)
                {
                    Console.Write(" ");
                }
               
                for (int k = 1; k <=i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}