class Algorytm
{
    static void Main(string[] args)
    {
        Console.WriteLine("Wprowadź a");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Wprowadź b");
        int b = int.Parse(Console.ReadLine());
        while (a != b)
        {
            if (a > b)
            {
                a -= b;
                Console.WriteLine($"NWD Wynosi:" +$"{a}");
                break;
            }
            else
            {
                b -= a;
                Console.WriteLine($"NWD Wynosi:" + $"{a}");
                break;
            }
        }
        if(a==b)
        {
            Console.WriteLine($"NWD Wynosi:" + $"{a}");
        }
    }
}
       
       
 