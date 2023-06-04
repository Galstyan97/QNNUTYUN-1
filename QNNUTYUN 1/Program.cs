namespace QNNUTYUN_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            while (number >=50 && number <= 70)
            {
                while (number != 1)
                {



                    if (number % 2 == 0)
                    {
                        number /= 2;

                    }
                    else
                    {
                        number = ((number * 3) + 1) / 2;
                    }

                    Console.WriteLine(number);


                }
                
                
                    
                
            }
            
            
            

        }
    }
}