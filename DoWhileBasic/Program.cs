namespace DoWhileBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {

            if (false)
            {
                //1~100 더하기
                var sum = 0;
                for (var i = 1; i <= 100; ++i)
                    sum += i;
                Console.WriteLine($"{sum}");
            }
            if (false)
            {
                var pactorial = 1UL;
                for (var i = 1UL; i <= 10; ++i)
                {
                    pactorial *= i;

                    Console.WriteLine($"{i}:{pactorial}");
                }
            }
            if (true)
            {
                for (var c ='가'; c <='힣'; ++c)
                {
                    Console.Write($"{c}");
                }
            }

            if (false)
            {
                var start = DateTime.Now.Ticks;
                var count = 0L;
                while(start + 10000000 > DateTime.Now.Ticks)
                {
                    ++count;

                    start = DateTime.Now.Ticks;
                    Console.WriteLine($"{count}");
                }
            }

        }
    }
}
