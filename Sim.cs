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
		if (command == "talk") {
			return parrotImg.talk();
		} else if (command == "feed it food") {
			var feeder = new Feeder();
			var seed = feeder.generateSeed();
			return parrotImg.eat(seed);
		} else if (command == "feed it garbage") {
			var feeder = new Feeder();
			var trash = feeder.generateTrash();
			return parrotImg.eat(trash);
		} else if (command == "who are you") {
			var name = parrotImg.getName();
			return name;
		} else if (command == "bye bye") {
			Environment.Exit(0);
			return "abcdef"; // never reaches but needed
		} else {
			return "Unknown command.";
		}
	}
}
