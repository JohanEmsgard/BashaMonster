Console.WriteLine("Look out a Eggman is here");


Monster s2 = new();   
Player s1 = new ();

Console.WriteLine($"{s1.name} is up against {s2.enemyname}");


Console.WriteLine($"{s1.name} used speed break on {s2.enemyname}. {s2.enemyname} lost all his HP");
s2.hp -= 200;
Console.WriteLine(s2.hp);

Console.WriteLine($"{s1.name} gained more speed");
Console.WriteLine(s1.Speed);
s1.Speed += 10;

System.Console.WriteLine("Press Enter to Contuine");

Console.ReadLine();
