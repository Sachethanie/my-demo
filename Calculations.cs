namespace myDemo
{
    internal class Calculations
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(20, 10);
            Square square = new Square(10);


            double CalculationAreaR = rectangle.CalculationArea();
            Console.WriteLine(CalculationAreaR);

            double CalculationAreaS = square.CalculationsArea();
            Console.WriteLine(CalculationAreaS);

            double CalculationPerimeterR = rectangle.CalculationsPerimeter();
            Console.WriteLine(CalculationPerimeterR);

            double CalculationPerimeterS = square.CalculationsPerimeter();
            Console.WriteLine(CalculationPerimeterS);




        }
    }
}
