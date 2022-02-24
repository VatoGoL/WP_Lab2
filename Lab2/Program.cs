using Lab2;

public class Program
{
    public static void Main(string[] args)
    {
        ushort i = 32511;
        RomanNumber Uno = new RomanNumber(i);
        RomanNumber Two = new RomanNumber((ushort)(i - 30000));
        RomanNumber? Tree = null;
        Console.WriteLine(i+" : "+Uno.ToString());
        Console.WriteLine(i-30000 + " : " + Two.ToString());

        try
        {
            RomanNumber result = RomanNumber.Div(Uno, Tree); // /
            Console.WriteLine("Result : " + result.ToString());
        }
        catch (ArgumentNullException e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            try
            {
                RomanNumber result = RomanNumber.Add(Uno, Two); //+
                Console.WriteLine("Result : " + result.ToString());
            }catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Test End)");
            }
            
        }
    }
}

