namespace Part2;

public class Calculator
{
    public double A { get; set; }
    public double B { get; set; }
    public string Operation { get; set; }
    
    public Calculator(double a, double b, string operation)
    {
        this.A = a;
        this.B = b;
        this.Operation = operation;
    }

    public double Calculate()
    {
        switch (Operation)
        {
            case "+":
                return A + B;
            case "-":
                return A - B;
            case "*":
                return A * B;
            case "/":
                if (B!=0) return (double)A / B;
                throw new DivideByZeroException("Division by zero");
            default:
                throw new ArgumentException("Invalid operation");
        }
    }
    
}