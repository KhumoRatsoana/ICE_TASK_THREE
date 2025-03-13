namespace ICE_TASK_THREE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(23);
            c.Display();
            c.CalculateArea();

            Console.WriteLine();

            Rectangle rec = new Rectangle(23,45);
            rec.Display();
            rec.CalculateArea();

            Console.ReadKey();
        }
    }
}
