public class ExampleClass
{
    private int _value;

    public int Value
    {
        get { return _value; }
        set { _value = value; }
    }

    public void MyMethod()
    {
        // Add input validation to prevent division by zero
        if (denominator != 0)
        {
            int result = numerator / denominator;
        }
        else
        {
            Console.WriteLine("Cannot divide by zero. Returning 0.");
            return 0; // Or throw a custom exception for better error handling
        }
    }

    public int MyMethodWithExceptionHandling(int numerator, int denominator)
    {
        try
        {
            return numerator / denominator;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Exception caught: {ex.Message}");
            // Handle the exception appropriately (log, return default value, etc.)
            return 0; // Or throw a custom exception
        }
        catch (Exception ex) // Catch other potential exceptions
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            // Log the error for debugging
            return 0; // Or throw a custom exception
        }
    }
}