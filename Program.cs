using System;
using Sim;

namespace Program;
class Program {
	public static void Main(string[] args) {
		Console.OutputEncoding = System.Text.Encoding.GetEncoding(1200);
		var sim = new ParrotSim();
		sim.run();
	}
}