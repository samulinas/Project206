using System.Text;
using bint = System.Numerics.BigInteger;

namespace Project206;
internal class Program
{
    static void Basics()
    {
        Console.WriteLine("=================Типи даних============================");
        // [тип даних] [назва змінної];
        // [тип даних] [назва змінної] = [значення];
        bool bo1 = true; // 1 байт | System.Boolean | true, false

        byte by1 = 100; //  1 байт | System.Byte | 0 ... 255
        sbyte sb1 = -100; //  1 байт | System.SByte | -128 ... 127
        short sh1 = -30000; // 2 байти | System.Int16 | -32768 ... 32 767
        ushort us1 = 30000; // 2 байти | System.UInt16 | 0 ... 65 535
        int in1 = -10000000; // 4 байти | System.Int32 | -2 147 483 648 ... 2 147 483 647
        uint ui1 = 10000000U; // 4 байти | System.UInt32 | 0 ... 4 294 967 295
        long lo1 = -9223372036854L; // 8 байти | System.Int64 | -9 223 372 036 854 775 808 ... 9 223 372 036 854 775 807
        ulong ul1 = 9223372036854UL; // 8 байти | System.UInt64 | 0 ... 18 446 744 073 709 551 615

        bint bi1 = bint.Parse("184467440737095516150000001");
        bint bi2 = bint.Parse("184467440737095516150000001");
        Console.WriteLine(bi1 + bi2);
        bint bi3 = bint.Pow(bi1, 2);

        float fl1 = -5.56F; // 4 байти | System.Single | -3.4 * 10^38 ... 3.4 * 10^38
        double do1 = -5.56; // 8 байт | System.Double | +-5.0 * 10^-324 ... +-1.7 * 10^308
        decimal de1 = -5.56M; // 16 байт | System.Decimal | +-1.0 * 10^-28 ... +-7.9228 * 10^28

        char ch1 = 'a'; // 2 байти | System.Char | 1 cимвол з Unicode 0 ... 65 536
        string st1 = "Hello World"; // 2 байти * к-ть симв. | System.String | Символи з Unicode

        object ob1 = "Hello"; // 8 байт | System.Object | Значення будь-якого типу
        object ob2 = true;

        Console.WriteLine($"{bo1} {by1} {sb1} {sh1} {us1} {in1} {ui1} {lo1} {ul1} {bi3} {fl1} {do1} {de1} {ch1} {st1} {ob1} {ob2}");

        Console.WriteLine("============Конвертація типів даних===============");

        int in2 = int.Parse("76876656");
        double do2 = double.Parse("5,65");
        Console.WriteLine($"{in2} {do2}");

        int in3 = Convert.ToInt32("76876656");
        Console.WriteLine($"{in3}");

        Console.WriteLine("================== Операції =======================");
        //Арифметичні операції
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int r1 = a + b;
        int r2 = a - b;
        double r3 = (double)a / b;
        int r4 = a * b;
        int r5 = a % b;
        Console.WriteLine($"{r1} {r2} {r3} {r4} {r5}");

        //Операції присвоювання
        r1 += a; // r1 = r1 + a;
        r2 -= a;
        r3 /= a;
        r4 *= a;
        r5 %= a;
        Console.WriteLine($"{r1} {r2} {r3} {r4} {r5}");

        //Унарні операції
        Console.WriteLine(++a); // a + 1
        Console.WriteLine(a++);
        Console.WriteLine(--a);
        Console.WriteLine(a--);
        Console.WriteLine(a);

        //Умовні операції
        bool bo2 = a == b;
        bool bo3 = a != b;
        bool bo4 = a > b;
        bool bo5 = a < b;
        bool bo6 = a >= b;
        bool bo7 = a <= b;
        Console.WriteLine($"{bo2} {bo3} {bo4} {bo5} {bo6} {bo7}");

        //Логічні операції
        bool bo8 = bo2 && bo3;
        bool bo9 = bo2 || bo3;
        bool bo10 = !bo2;
        Console.WriteLine($"{bo8} {bo9} {bo10}");

        Console.WriteLine("================== Умовні конструкції =======================");
        // Конструкція if ... else
        if (a != b) Console.WriteLine("Спрацював блок if");
        else if (a == b) Console.WriteLine("Спрацював блок else if");
        else Console.WriteLine("Спрацював блок else");

        //Тернарна операція
        Console.WriteLine((a != b) ? "Спрацював блок if" : "Спрацював блок else");

        //Конструкція switch ... case
        string? st3 = Console.ReadLine();
        switch (st3)
        {
            case "1": Console.WriteLine("Cпрацював перший випадок!"); break;
            case "2": Console.WriteLine("Cпрацював другий випадок!"); break;
            default: Console.WriteLine("Спрацював випадок за замовчуванням"); break;
        }

        Console.WriteLine("===================== Цикли ==========================");
        //Цикл for
        for (int i = 0; i < 5; i++)
        {
            if (i == 3) continue;
            Console.Write($"{i} ");
        }
        Console.WriteLine();
        //Цикл while
        int j = 0;
        while (j < 5)
        {
            Console.Write($"{j} ");
            j++;
        }
        Console.WriteLine();
        //do ... while
        j = 0;
        do
        {
            Console.Write($"{j} ");
            j++;
        }
        while (j < 5);
        Console.WriteLine();
        //foreach
        foreach (char k in "01234")
        {
            Console.Write($"{k} ");
        }
        Console.WriteLine();

        Console.WriteLine("===================== Масиви ==========================");
        // тип_даних[вимірність_масиву_знак_коми] назва_масиву = new тип_даних[розмірніть] {елемент_1, елемент_2};
        int[] arr1 = new int[4] { 2, 4, 6, 8 };
        int[] arr2 = new int[] { 2, 4, 6, 8 };
        int[] arr3 = new[] { 2, 4, 6, 8 };
        int[] arr4 = { 2, 4, 6, 8 };
        Console.Write($"{arr1[0]} {arr1[1]} {arr1[2]} {arr1[3]}");
        Console.WriteLine();
        foreach (int k in arr2)
        {
            Console.Write($"{k} ");
        }
        Console.WriteLine();
        for (int k = 0; k < arr3.Length; k++)
        {
            Console.Write($"{arr3[k]} ");
        }
        Console.WriteLine();
        int SIZE = Convert.ToInt32(Console.ReadLine());
        int[] arr5 = new int[SIZE];
        for (int k = 0; k < arr5.Length; k++)
        {
            arr5[k] = Convert.ToInt32(Console.ReadLine());
        }
        int[,] arr6 = new int[2, 3]
        {
            { 2, 4, 6 },
            { 8, 10, 12 }
        };
        Console.Write($"{arr6[0, 0]} {arr6[0, 1]} {arr6[0, 2]} {arr6[1, 0]} {arr6[1, 1]} {arr6[1, 2]}");
        Console.WriteLine();
        for (int i = 0; i <= arr6.GetUpperBound(0); i++)
        {
            for (int k = 0; k <= arr6.GetUpperBound(1); k++)
            {
                Console.Write($"{arr6[i, k]} ");
            }
        }
        Console.WriteLine();

        int[][] arr7 = { new int[] { 1, 2 }, new int[] { 1, 2, 3, 4 } };

        Console.WriteLine($"{arr7[0][0]} {arr7[0][1]} {arr7[1][0]} {arr7[1][1]} {arr7[1][2]} {arr7[1][3]}");

        for (int i = 0; i < arr7.Length; i++)
        {
            for (int k = 0; k < arr7.Length; k++)
            {
                Console.Write($"{arr7[i][k]} ");
            }
        }
        Console.WriteLine();

        Console.WriteLine("===================== Функції ==========================");
        // [Модифікатор] Тип_повертаючого_значення Назва_функції([параметр1],[параметр2]) { [Тіло функції] }
        void SayHello1()
        {
            Console.WriteLine("Привітання!");
        }
        SayHello1();
        SayHello1();

        void SayHello2(string hello = "Привітання!")
        {
            Console.WriteLine(hello);
        }
        SayHello2("Вітаємо!");
        SayHello2("Привіт!");
        SayHello2();

        int Sub(int x, int y)
        {
            return x - y;
        }
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Sub(x, y));
        Console.WriteLine(Sub(y: x, x: y));

        int in4 = 5;
        //Функція з переданими параметрами по значенню
        void Increase1(int inc)
        {
            inc += 2;
            Console.WriteLine(inc);
        }
        Increase1(in4);
        Console.WriteLine(in4);

        //Функція з переданими параметрами за посиланням (модифікатор ref)
        void Increase2(ref int inc)
        {
            inc += 2;
            Console.WriteLine(inc);
        }
        Increase2(ref in4);
        Console.WriteLine(in4);

        //Функція з вихідними параметрами (модифікатор out)
        int Multiply1(int x, int y, out int res)
        {
            x += 10;
            res = x * y;
            return x * x;
        }
        int res2;
        int res1 = Multiply1(x, y, out res2);
        Console.WriteLine($"{res1} {res2}");

        //Функція з вхідними параметрами (модифікатор in)
        int Multiply2(in int x, in int y, out int res)
        {
            //x += 10;
            res = x * y;
            return x * x;
        }
        res1 = Multiply2(x, y, out res2);
        Console.WriteLine($"{res1} {res2}");

        //Функція з масивом параметрів (ключове слово params)
        int Sum(params int[] nums)
        {
            int count = 0;
            foreach (int n in nums)
            {
                count += n;
            }
            return count;
        }
        Console.WriteLine(Sum(1, 2, 3, 4, 5));
        Console.WriteLine(Sum(1, 2, 3));

        //Рекурсивна функція з обчислення факторіалу числа
        ulong Factorial(byte n)
        {
            if (n == 1) return 1;
            return n * Factorial(--n);
        }
        byte n = Convert.ToByte(Console.ReadLine());
        Console.WriteLine(Factorial(n));
    }
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        //Basics();
        Console.WriteLine("===================== Переліки =====================");
        void DoOperation(int a, int b, Operation op)
        {
            switch (op)
            {
                case Operation.Exit: break;
                case Operation.Add: Console.WriteLine(a + b); break;
                case Operation.Sub: Console.WriteLine(a - b); break;
                case Operation.Mult: Console.WriteLine(a * b); break;
                case Operation.Div: Console.WriteLine(a / b); break;
                default: Console.WriteLine("Операція задана некоректно!"); break;
            }
        }
        int o1 = Convert.ToInt32(Console.ReadLine());
        int o2 = Convert.ToInt32(Console.ReadLine());
        Operation o3 = Operation.None;
        while (o3 != Operation.Exit)
        {
            o3 = (Operation)Convert.ToInt32(Console.ReadLine());
            DoOperation(o1, o2, o3);
        }
        Console.WriteLine("===================== Структури =====================");
        Person person = new Person("Ivan", 30);
        //person._name = "Ivan";
        person.PersonInfo();

    }
    enum Operation : sbyte
    {
        None = -1, Exit = 0, Add, Sub, Mult, Div
    }
    struct Person
    {
        //Поля структури
        private string _name = "Undefined";
        private int _age = 0;

        //Конструктор
        public Person(string name, int age)
        {
            _name = name;
            _age = age;
        }

        //Метод
        public void PersonInfo() 
        {
            Console.WriteLine($"{_name} {_age}");
        }
    }
}
