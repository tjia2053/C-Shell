using Assignment_4;

MyList<int> test2 = new MyList<int>();
for (int i = 0; i < 10; i++)
    test2.Add(i*5);
test2.Add(70);
test2.Romove(10);
Console.WriteLine(test2.Contaion(20));
Console.WriteLine(test2.Find(3));
test2.InsertAT(100, 2);
test2.DeleteAT(5);
Console.WriteLine(test2.Find(7));
test2.Clear();

