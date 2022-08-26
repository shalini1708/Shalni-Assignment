//Players and Team-Requirement
//Phase-I

//ABC Cricket Academy decided to create a solution to maintain information about team players for one day game with below functionalities:
//1.User will be able to add player in the team with details Id, Name and Age.
//2.	User will be able to remove player from team by passing player id.
//3.	User will be able to get player details by passing player id.
//4.	User will be able to get player details by passing player name.
//5.	User will be able to get all player details.
//6.	User will not be able to add more than 11 players in the team.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhaseEndProject
{
    internal class Program
    {
        static void Main()
        {
            OneDayTeam team1 = new OneDayTeam();
start:     Console.Write("Enter 1:To Add Player 2:To Remove Player by Id 3.Get Player By Id 4.Get Player by Name 5.Get All Players:");
            int choice=int.Parse(Console.ReadLine());
           
            switch (choice)
            {
                case 1:
                    Console.Write("Enter Player Id:");
                    int id= int.Parse(Console.ReadLine());
                    Console.Write("Enter Player Name:");
                    string name= Console.ReadLine();
                    Console.Write("Enter Player Age:");
                    int age= int.Parse(Console.ReadLine());
                    var newPlayer = new Player { PlayerId = id, PlayerName = name, PlayerAge = age };
                    team1.Add(newPlayer);
                    Console.WriteLine("Player is added successfully");                             
                    break;
                case 2:
                    Console.Write("Enter Player Id to Remove:");
                    int idToRemove = int.Parse(Console.ReadLine());
                    team1.Remove(idToRemove);
                    Console.WriteLine("Player is removed successfully");
                    break;
                case 3:
                    Console.Write("Enter Player Id:");
                    int idToGet = int.Parse(Console.ReadLine());
                   var playerById= team1.GetPlayerById(idToGet);
                    Console.WriteLine($"{playerById.PlayerId}\t{playerById.PlayerName}\t{playerById.PlayerAge}");
                    break;
                case 4:
                    Console.Write("Enter Player Name:");
                    string nameToGet = Console.ReadLine();
                    var playerByName = team1.GetPlayerByName(nameToGet);
                    Console.WriteLine($"{playerByName.PlayerId}\t{playerByName.PlayerName}\t{playerByName.PlayerAge}");
                    break;
                case 5:
                    var allPlayers = team1.GetAllPlayers();
                    foreach (var player in allPlayers)
                    {
                        Console.WriteLine($"{player.PlayerId}\t{player.PlayerName}\t{player.PlayerAge}");
                    }
                    break;
            }
            Console.Write("Do you want to continue (yes/no)?:");
            string response = Console.ReadLine();
            if (response.ToLowerInvariant()=="yes")
            {
                goto start;
            }
            Console.ReadLine();
        }
    }
}
