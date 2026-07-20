using System;
using Basic;
using Feeding;

namespace Sim;

class ParrotSim {
	public void run() {
		Console.WriteLine("Welcome to Parrot Simulator!");
		Console.Write("Your parrot's name: ");
		var name = Console.ReadLine();
		var parrot = new Parrot(name);
		Console.WriteLine($"Meet your new parrot {name}!");
		gameLoop(parrot);
	}
	public void gameLoop(Parrot parrotImage) {
		while(true) {
			Console.Write("> ");
			var command = Console.ReadLine();
			var result = parse(command, parrotImage);
			Console.WriteLine($"Parrot says: {result}");
		}
	}
	public string parse(string command, Parrot parrotImg) {
		if (command == "t") {
			return parrotImg.Talk();
		} else if (command == "ff") {
			var feeder = new Feeder();
			var seed = feeder.generateSeed();
			return parrotImg.Eat(seed);
		} else if (command == "fg") {
			var feeder = new Feeder();
			var trash = feeder.generateTrash();
			return parrotImg.Eat(trash);
		} else if (command == "n") {
			var name = parrotImg.GetName();
			return name;
		} else if (command == "ghu")
		{
			var hu = parrotImg.GetHu();
			return hu.ToString();
		} else if (command == "gha")
		{
			var ha = parrotImg.GetHa();
			return ha.ToString();
		} else if (command == "h") {
			return parrotImg.Help();
		} else if (command == "q") {
			Environment.Exit(0);
			return "abcdef"; // never reaches but needed
		} else {
			return "Unknown command.";
		}
	}
}
