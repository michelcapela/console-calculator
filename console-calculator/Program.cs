using console_calculator;

Console.WriteLine("Hello, welcome to the calculator program!");


try
{

    Calculator.Calculate();

}
catch (Exception e)
{

    Console.WriteLine("Please enter a valid value.");
    Calculator.Calculate();
}





Console.ReadKey();
