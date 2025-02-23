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
        // Simulate a potential exception
        try
        {
            // Some code that might throw an exception
            int result = 10 / 0;
        }
        catch (DivideByZeroException ex)
        {
            // Handle the exception
            Console.WriteLine("Exception caught: " + ex.Message);
        }
        finally
        {
            // Code that always executes, regardless of exception
            Console.WriteLine("Finally block executed");
        }
    }
}