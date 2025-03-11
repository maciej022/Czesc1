class Algorytm
{
    static void Main(string[] args)
    {
        Console.WriteLine("Wprowadź a");
        int a=int.Parse(Console.ReadLine());
        Console.WriteLine("Wprowadź b");
        int b=int.Parse(Console.ReadLine());
        if (a != b)
        {
            if (a > b)
            {
                a /= a - b;
                Console.WriteLine(a);
            }
            else
            {
                b /= b - a;
                Console.WriteLine(b);   
            }
        }
        else
        {
            Console.WriteLine(a);
            
        }
    }
}