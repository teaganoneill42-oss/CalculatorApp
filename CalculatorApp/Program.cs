void CalculatorApp()
{
	try
	{
		Console.WriteLine("enter the first number");
		int firstNumber = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("enter the second number");
		int SecondNumber = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("enter the operation (+, -, *, /)");
		char opperation = Convert.ToChar(Console.ReadLine());
		int result = 0;
        switch (opperation) 

		{
			case '+':
             result = firstNumber + SecondNumber;
                break;	
				case '-':
                result = firstNumber - SecondNumber;
                break;
           case '*':
				result = firstNumber * SecondNumber;
                break;
           case '/':
				result = firstNumber / SecondNumber;
                break;	
	}

		Console.WriteLine($"result: {result}");



    }
	catch (Exception ex)

	{
Console.WriteLine($"Error: {ex.Message}. Please enter a vaild opperation");

        
	}
}
CalculatorApp();