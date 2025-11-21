using System.Collections.Concurrent;

Console.WriteLine("Hello, World!");

// Zapis funkcyjny
// f(x) = x + 2     x nalezy do zbioru liczb calkowitych


// x -> x + 2

// Wyrazenie lambda (zapis deklaratywny)
var f = (int x) => x + 2;
var g = () => DateTime.Now.Microsecond;
var h = (int x, int y) => x + y;

Console.WriteLine(f(7));

Console.WriteLine(g());

Console.WriteLine(h(2, 4));



