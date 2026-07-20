using System;
using Feeding;

namespace Basic;
class Parrot {
	private string name;
	public Parrot(string name) {
		this.name = name;
		Console.WriteLine("CHIRP CHIRP!");
		Console.WriteLine("Your parrot has been born.");
		Console.Beep(300, 300);
	}
	public string getName() {
		return this.name;
	}
	public string talk() {
		return "Chirp-chirp!";
	}
	public string eat(object item) {
		if (item is Seed) {
			return "Nom nom nom!!!";
		} else {
			return "What is that? I don't want that!";
		}
	}
}