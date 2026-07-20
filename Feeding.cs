using System;

namespace Feeding;
class Seed {
	public Seed() {
		Console.WriteLine("A seed has materialized.");
	}
}
class Trash {
	public Trash() {
		Console.WriteLine("This is trash. It smells like skunks and bad life decisions.");
	}
}
class Feeder {
	public Feeder() {
		Console.WriteLine("A kind feeder approaches your parrot...");
	}
	public Seed generateSeed() {
		Console.WriteLine("The feeder approaches with a seed...");
		return new Seed();
	}
	public Trash generateTrash() {
		Console.WriteLine("The feeder approaches with... trash.");
		return new Trash();
	}
}