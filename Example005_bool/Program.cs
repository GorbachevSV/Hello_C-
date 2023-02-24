Console.Write("Type Username: ");
string username = Console.ReadLine();

if (username.ToLower() == "masha")
    {
        Console.WriteLine("YEAPPY, IT IS MASHA!");
    }
else
    {
        Console.Write("You are not Masha, go AWAY,");
        Console.WriteLine(username);
    }