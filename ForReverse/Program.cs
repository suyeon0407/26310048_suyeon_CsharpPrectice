namespace ForReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //배열을 생성
            //동일한 자료형의 연속된 메모리 공간
            //힙에 생성 --> 힙 동적 메모리공간
            //힙에 개체를 생성하는데 --> new
            //배열의 선언과 동시에 초기화는 new 생략가능

            //배열의 선언
            //자료형[]
            //int[] intArray1;
            //Player[] intArray1;
            //intArray1 = new Player[100];

            //int[] intArray2;
            //intArray2 = new[] { 52, 273, 32, 65, 103 };

            //int[] intArray3;
            //
            //intArray3= { 52, 273, 32, 65, 103 }; <-이거는 안됨

            //요소(Element) 출력
            //foreach (var elem in intArray1) //아래 for 문보다 간단하게 만들수있음
            // for (var i = 0; i < intArray1.Length; ++i) //for 와 while 같음, for가 먼저나옴
            //var i = 0;
            //while (i < intArray1.Length)
            //{
            //    Console.Write($"{i} :");
            //    if(intArray1[i] == null)
            //        Console.WriteLine($"null");
            //    else
            //        Console.WriteLine($"{intArray1[i] == null ?}");
            //    ++i;
            //}

            //배열 생성
            int [] intArray = new int[100];

            //foreach 는 역순으로 불가, for  만 역순으로 만들수있음

            for (var i = 0; i < intArray.Length;i++)
            {
                intArray[i] = i +1;
            }
            for (var i = intArray . Length - 1; i>= 0; --i)
            {
                Console.WriteLine(intArray);
            }
        }
    }
}
