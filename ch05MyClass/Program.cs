
using System.Collections.Concurrent;
using System.Net.NetworkInformation;

class Program
    {
        static void Main(string[] args)
        {
        if (false)
        {


            //주차 클래스
            Parking[] carParking;

            //플레이어 클래스로 가자
            Player player;

            carParking = new Parking[100];
            player = new Player();


            Random random = new Random();

            for (int i = 0; i < 100; i++)
            {
                // 2~ 12 까지의 랜덤숫자
                //var randValue = random.Next(2,12 + 1);
                //Console.WriteLine(randValue);

                //0.0 ~ 1.0 미만
                var doubleValue = random.NextDouble();
                Console.WriteLine(doubleValue);
            }
        }

        // 배열은 정적 고정
        //if (false)
        //{

        //    // 몹 클래스로 가자
        //    Mob[] mobs;

        //    mobs = new Mob[10];
        //    for (int i = 0; i < mobs.Length; ++i)
        //    {
        //        mobs[i] = new Mob();
        //        mobs[i].Name = "몹 이름: " + i.ToString();
        //    }

        //    for (int i = 0; i < mobs.Length; ++i)
        //    {
        //        Console.WriteLine(mobs[i].Name);
        //    }
        //}

        //가변적 배열
        //일반화
        //컨테이너 상자를 생성
        //List <Mob> mobs;

        //mobs = new List<Mob>();

        //위와 같음
        List<Mob> mobs = new ();
        //--
        //add 함수를 사용해서 컨테이너에 객체 추가

        for(int i = 0; i< 10; ++i)
        {
            mobs.Add(new Mob());
            //객체에 이름부여
            mobs[i].Name = "몹 이름: " + i.ToString();
        }

        ////컨테이너의 내용 출력
        //foreach (var mob in mobs)
        //{
        //    Console.WriteLine(mob.Name);
        //}

        ////몹에서 5,6,7 제거(범위)
        //mobs.RemoveRange(5, 3);
        //foreach (var mob in mobs)
        //{
        //    Console.WriteLine(mob.Name);
        //}

        
        mobs.RemoveRange(5, 3);
        for (int i = 2; i <= 4; ++i)
        {
            mobs.Remove(mobs[i]);
        }
        foreach (var mob in mobs)
        {
            Console.WriteLine(mob.Name);
        }

        //// 전체 제거
        //mobs.Clear();
        //foreach (var mob in mobs)
        //{
        //    Console.WriteLine(mob.Name);
        //}

        //var v = -1000;
        //Console.WriteLine (Math.Abs(v));

        //var d = Math.PI;
        //Console.WriteLine(Math.Floor(d));
        //Console.WriteLine(Math.Ceiling(d));

    }
}
