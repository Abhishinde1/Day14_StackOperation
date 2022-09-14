namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            UC1 uc1 = new UC1();
            uc1.push(70);
            uc1.push(30);
            uc1.push(56);
            uc1.Display();
        }
    }
}