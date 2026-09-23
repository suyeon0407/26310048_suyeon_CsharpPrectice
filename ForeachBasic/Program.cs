namespace ForeachBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //변수선언
            string[] array = { "사과","배","포도","딸기","바나나" };

            //반복 수행
            foreach (var n in array)
            {
                Console.WriteLine(n);
            }

        }
    }
}
