// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Actor joe = new Actor("Joe T. Moe", "M", 2);

Console.WriteLine(joe);

joe.Name = "Josephine";
joe.Gender = "F";
joe.AddMovie();
Console.WriteLine(joe.MovieCount);

joe.Gender = "X";