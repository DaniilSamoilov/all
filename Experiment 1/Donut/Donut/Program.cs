int x = 1, y = 2, z = ((++y + ++x) > 6) ? 5 : ++x + 2;
Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(z);