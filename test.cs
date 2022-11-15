using System.IO;
using System;
using System.Collections.Generic;
class Player 
{

    public string rank ;
    public string name;
    public string title;
    public string country;
    public string rating;
    public string games;
    public string yearOfBorn;
    
}
public class Program
{

    static void Main(string[] args)
    {
        var players = new List<Player>();
        
        using (var rd = new StreamReader("data.csv"))
        {
            while (!rd.EndOfStream)
            {
                Player p = new Player();
                var splits = rd.ReadLine().Split(';');

               p.rank=splits[0];
               p.name=splits[1];
                p.title=splits[2];
                p.country=splits[3];
                p.rating=splits[4];
                p.games=splits[5];
                p.yearOfBorn = splits[6];
                players.Add(p);
                
                
            }
        }
      
        int count=1;
        Console.WriteLine("Sr. No" + "\t\t\t" + "Player Name" + "\t\t\t\t\t\t\t" + "Born Year");
        foreach (Player  element in players)
        {
            if ((element.yearOfBorn == "1980") && (count <= 10))
            {
                Console.WriteLine(count + "\t\t\t" + element.name + "\t\t\t\t\t\t\t" + element.yearOfBorn);
                count++;
            }
        }

        System.Console.ReadKey();
        

        

    }

}