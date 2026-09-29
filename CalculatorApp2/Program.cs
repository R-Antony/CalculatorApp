void CalculatorApp()
{

    try
    {
        Console.WriteLine("Enter your first number");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter your second number");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        
        Console.WriteLine("Enter the operation (+, -, *, /)");
        var operation = Convert.ToChar(Console.ReadLine());
        int result = 0;

        switch (operation)
        {
            case '+':
                result = firstNumber + secondNumber;
                break;
            case '-':
                result = firstNumber - secondNumber;
                break;
            case '*':
                result = firstNumber * secondNumber;
                break;
            case '/':
                result = firstNumber / secondNumber;
                break;
        }

        Console.WriteLine($"Result: {result}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}. Please enter a valid operation.");
        
    }
}

CalculatorApp();
