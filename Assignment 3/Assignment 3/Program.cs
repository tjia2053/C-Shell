using Assignment_3;



//int[] numbers = Working_with_methods.GenerateNumber(10);

//Working_with_methods.Reverse(numbers);

//Working_with_methods.PrintNumbers(numbers);

//Console.WriteLine(Working_with_methods.Fibonacci(8));

Cycle a = new Cycle();
Point1 test = new Point1();
Console.WriteLine($"{test.X} {test.Y}");
Rectangle b = new Rectangle();
a.Center = test;
Console.WriteLine(b.Len);
a.area();
b.Len = 3;
b.area();
