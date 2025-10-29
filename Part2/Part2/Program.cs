using Part2;

Calculator c1=new Calculator(0, Double.Epsilon,"+");
Calculator c2=new Calculator(2,3,"-");
Calculator c3=new Calculator(3,Double.PositiveInfinity,"*");
Calculator c4=new Calculator(4,Double.NegativeInfinity, "/");

Console.WriteLine(c1.Calculate());
Console.WriteLine(c2.Calculate());
Console.WriteLine(c3.Calculate());
Console.WriteLine(c4.Calculate());

