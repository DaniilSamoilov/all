using System.Data.Common;

class Program
{
    class basic
    {
        public int value1;
        public void metod()
        {
            Console.WriteLine("Метод класса 'basic' выполнен");
        }

        public static implicit operator basic(int a)
        {
            return new basic { value1 = a };
        }

        public static implicit operator int(basic bas)
        {
            return bas.value1;
        }

        public static explicit operator byte(basic bas)
        {
            if(bas.value1 > byte.MaxValue)
            {
                return byte.MaxValue;
            }
            else
            {
                return (byte)bas.value1;
            }
        }
    }
    class naslednik : basic
    {
        public new void metod()
        {
            Console.WriteLine("Метод класса 'naslednik' выполнен");
        }
    }
    class naslednik_naslednika : naslednik
    {
        public new void metod()
        {
            Console.WriteLine("Метод класса 'naslednik_naslednika' выполнен");
        }
    }
    static void Main(string[] args)
    {

        // Пункт 1 Неявное преобразование
        Console.WriteLine("Пункт 1 Неявное преобразование");
        char ch = 'a';
        Console.WriteLine(ch);
        int i_1 = ch;
        Console.WriteLine(i_1);
        float f_1 = i_1;
        Console.WriteLine(f_1);
        double d_1 = f_1;
        Console.WriteLine(d_1);

        naslednik nas = new naslednik();
        basic bas = nas;

        // Пункт 2 Явное преобразование
        Console.WriteLine("\nПункт 2 Явное преобразование");
        float a = 1.15f;
        Console.WriteLine(a);
        int b = (int)a;
        Console.WriteLine(b);
        char c = (char)b;
        Console.WriteLine(c);

        //basic bas_2 = new basic();
        //naslednik nas_2 = (naslednik)bas_2;

        // Пункт 3 Вызвать и обработать исключение преобразования типов;
        Console.WriteLine("\nПункт 3 Вызвать и обработать исключение преобразования типов");
        try
        {
            dynamic dyn_3 = 1.3;
            float f_3 = dyn_3;
        }
        catch
        {
            Console.WriteLine("Преобразование невозможно");
        }
        // Пункт 4 Безопасное приведение ссылочных типов с помощью операторов as и is; 
        Console.WriteLine("\nПункт 4 Безопасное приведение ссылочных типов с помощью оператора is");
        naslednik nas_4 = new naslednik();
        if (nas_4 is naslednik)
        {
            Console.WriteLine("Преобразованеи в 'naslednik' возможно");
        }
        if (nas_4 is basic)
        {
            Console.WriteLine("Преобразованеи в 'basic' возможно");
        }
        if (nas_4 is naslednik_naslednika)
        {
            Console.WriteLine("Преобразованеи в 'naslednik_naslednika' возможно");
        }


        Console.WriteLine("...с помощью оператора as");

        void TestForBasic(object o)
        {
            var m = o as basic;
            if (m != null)
            {
                m.metod();
            }
            else
            {
                Console.WriteLine("Преобразованеи в 'basic' не возможно");
            }
        }
        void TestForNaslednik_naslednika(object o)
        {
            var m = o as naslednik_naslednika;
            if (m != null)
            {
                m.metod();
            }
            else
            {
                Console.WriteLine("Преобразованеи в 'naslednik_naslednika' не возможно");
            }
        }

        TestForBasic(nas_4);
        TestForNaslednik_naslednika(nas_4);

        // Пункт 5 Пользовательское преобразование типов Implicit, Explicit;
        Console.WriteLine("\nПункт 5 Пользовательское преобразование типов Implicit, Explicit");
        basic bas_5 = 256;
        int i_5 = bas_5;
        byte b_5 = (byte)bas_5;
        Console.WriteLine($"bas_5.value1: {bas_5.value1}; i_5: {i_5}; b_5: {b_5}");

        // Пункт 6 Преобразование с помощью класса Convert и преобразование строки в число
        Console.WriteLine("\nПункт 6 Преобразование с помощью класса Convert");
        string str_6 = "3";
        int i_6 = Convert.ToInt32(str_6);
        Console.WriteLine(i_6);
        bool b_6 = true;
        double d_6 = Convert.ToDouble(b_6);
        Console.WriteLine(d_6);

        try
        {
            i_6 = Int32.Parse(str_6);
        }
        catch
        {
            Console.WriteLine("Число не может быть преобазовано в int");
        }


        if (!Double.TryParse(str_6, out d_6))
        {
            Console.WriteLine("Не удалось преобразовать переменную");
        }
        else
        {
            Console.WriteLine(d_6);
        }
        // Пункт 7	Написать программу, позволяющую ввод в текстовое поле TextBox только символов, задающих правильный формат вещественного числа со знаком.
        Console.WriteLine("\nПункт 7");
        Console.WriteLine("\nВведите строку - вещественное число со знаком");
        string? str_7 = Console.ReadLine();
        double value_7;
        if (!Double.TryParse(str_7, out value_7))
        {
            Console.WriteLine("Неверно задано значение!");
        }
        else
        {
            Console.WriteLine(value_7);
        }
    }
}

/* Таблица неявных преобразований
sbyte => short , int, long, float, double или decimal
byte => short, ushort, int, uint, long, float, double или decimal
short => int , long, float, double или decimal
ushort => int , uint, long, ulong, float, double или decimal
int => long , float, double или decimal
uint => long , ulong, float, double или decimal
long => float , double или decimal
char => ushort , int, uint, long, ulong, float, double или decimal
float => double
ulong => float , double или decimal
Объект - наследник => Объект базового класса
 */

/* Таблица явных преобразований
sbyte => byte , ushort, uint, ulong или char 
byte => Sbyte или char 
short => sbyte , byte, ushort, uint, ulong или char 
ushort => sbyte , byte, short или char
int => sbyte , byte, short, ushort, uint, ulong или char
uint => sbyte , byte, short, ushort, int или char 
long => sbyte , byte, short, ushort, int, uint, ulong или char 
ulong => sbyte , byte, short, ushort, int, uint, long или char 
char => sbyte , byte или short 
float => sbyte , byte, short, ushort, int, uint, long, ulong, char или decimal 
double => sbyte , byte, short, ushort, int, uint, long, ulong, char, float или decimal 
decimal => sbyte , byte, short, ushort, int, uint, long, ulong, char, float или double 
Объект базового класса => Объект - наследник
 */