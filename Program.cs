int sifra;
int a;


static void rnd()
{
    int a;
    Random rnd = new Random();
    int value = rnd.Next(0, 100);
    Console.WriteLine("Угадай число от 0 до 100");
    Console.WriteLine("Введите число");
    a = Convert.ToInt32(Console.ReadLine());
    while (a != value)
    {
        if (a < value)
        {
            Console.WriteLine("Больше");
            Console.WriteLine("Введите число");
            a = Convert.ToInt32(Console.ReadLine());
        }
        else if (a > value)
        {
            Console.WriteLine("Меньше");
            Console.WriteLine("Введите число");
            a = Convert.ToInt32(Console.ReadLine());
        }
    }
    Console.WriteLine("Угадал");
}
static void umn()
{
    int[,] myltiplytable = new int[10, 10];
    for (int i = 0; i < 10; i++)
        for (int j = 0; j < 10; j++)
            myltiplytable[i, j] = i * j;
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine();
        for (int j = 1; j < 10; j++)
            Console.Write("{0, 3}", myltiplytable[i, j]);
        Console.WriteLine();
    }
}
static void del()
{
    Console.WriteLine("Введите число");
    string b = Console.ReadLine();
    int c = Convert.ToInt32(b);
    int d = 0;
    while (d <= c)
    {
        d++;
        if (c % d == 0)
        {
            Console.WriteLine(d);
        }
        else if (c % d != 0)
        {
            continue;
        }
    }
}
do
{
    Console.WriteLine("Какую программу вы хотите запустить?");
    Console.WriteLine("1. Угадай число");
    Console.WriteLine("2. Таблица умножения");
    Console.WriteLine("3. Вывод делителей");
    Console.WriteLine("4. Выйти из программы");
    sifra = Convert.ToInt32(Console.ReadLine());
    if (sifra == 1)
    {
        rnd();
    }
    else if (sifra == 2)
    {
        umn();
    }
    else if (sifra == 3)
    {
        del();
    }
} while (sifra != 4);

