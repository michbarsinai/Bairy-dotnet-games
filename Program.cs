// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Actor joe = new Actor("Joe T. Moe", "M", 2);

Console.WriteLine(joe);

joe.Name = "Josephine";
joe.Gender = "F";
joe.AddMovie();
Console.WriteLine(joe.MovieCount);

Movie mv = new Movie( "Blues Brothers");
Actor jb = new Actor( "John Belushi", "M", 0);
Actor de = new Actor( "Dan Aykroyd", "M", 0);

jb.joinAsStar(mv);
de.joinAsSupporting(mv);

Console.WriteLine("Star: " + mv.MainStar.Name);

// joe.Gender = "11";