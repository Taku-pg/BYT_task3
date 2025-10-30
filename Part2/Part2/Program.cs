using Part2;

Calculator c1=new Calculator(3,5,"+");
Calculator c2=new Calculator(2,3,"-");
Calculator c3=new Calculator(3,9,"*");
Calculator c4=new Calculator(4,2, "/");

Console.WriteLine(c1.Calculate());
Console.WriteLine(c2.Calculate());
Console.WriteLine(c3.Calculate());
Console.WriteLine(c4.Calculate());

