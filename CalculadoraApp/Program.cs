using System;


namespace CalculatorApp;


class Program{
    static void Main(string[] args) {
        
        // primero uso la interfaz para inyectar
        ICalculator calculator = new Calculator();


        bool continuar = true;  // Inicializamos en true, para que el bucle comience.

        while (continuar)  // Mientras continuar sea true, el bucle seguirá ejecutándose.
        {
            // Menú de selección de operaciones y lógica de cálculo...
            Console.WriteLine("Welcome to CalculatorApp");
            Console.WriteLine("Select one Option please");
            Console.WriteLine("1 - Sum");
            Console.WriteLine("2 - Subtract");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Divide");
            Console.WriteLine("5 - Exit");

            string option = Console.ReadLine();

            if (option == "5")
            {
                continuar = false;  // Cambiamos continuar a false para salir del bucle.
                break;
            }

            Console.WriteLine("Please enter the first number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the second number");

            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = 0;

            switch (option) {
                case "1":
                    result = calculator.Sum(num1, num2);
                    Console.WriteLine("Result of Sum is:" + result);
                    break;
                    case "2":
                    result = calculator.Subtract(num1, num2);
                    Console.WriteLine(" Result of Subtract is:" + result);
                    break;
                    case "3":
                    result = calculator.Multiply(num1, num2);
                    Console.WriteLine(" Result of Multiplication is:" + result);
                    break;
                    case "4":
                    if (num2 != 0)
                    {
                        result = calculator.Divide(num1, num2);
                        Console.WriteLine($"Result {num1} / {num2} is {result}");
                    }
                    else
                    {
                        Console.WriteLine("You can't divide 0.");
                    }
                    break;
                default:
                    Console.WriteLine("Incorrect Option");
                    break;
            }
            Console.WriteLine("Press a key to continue...");
            Console.ReadKey();
        }
    }
}