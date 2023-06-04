namespace QNNUTYUN_1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            for (int i = 50; i < 70; i++)
            {
                int number = 0;
                number = i;

                do
                {

                    if (number % 2 == 0)
                    {
                        number /= 2;
                    }
                    else
                    {
                        number = ((number * 3) + 1) / 2;

                    }
                }
                while (number != 1);
                Console.WriteLine(number);

            }
        }      

        
    }
}