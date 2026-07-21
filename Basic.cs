using System;
using Feeding;

namespace Basic;
class Parrot {
	private string name;
	private int happiness;
	private int hunger;
    private int position;
	public Parrot(string name) {
		this.name = name;
		Console.WriteLine("🗣️ CHIRP CHIRP!");
		Console.WriteLine("👶 Your parrot has been born.");
        Console.Beep(300, 300);
    }
    public string Perch(int toLocation)
    {
        this.position = toLocation;
        return $"🦵 Perched to: {toLocation.ToString()}";
    }
    
    public string GetName()
    {
        return this.name;
    }

    public int GetHa()
    {
        return this.happiness;
    }

    public int GetHu()
    {
        return this.hunger;
    }

    public int GetPos()
    {
        return this.position;
    }
    public string Talk()
	{
        if (this.position != this.hunger)
        {
            return "😭 This perch doesn't match my weight! (perch snaps)";
        } else {
            if (happiness >= 100)
            {
                return "🤪 CRAZY PARROT! (flying into walls, squeaking at 3 AM) Talk trash to it!";
            } else {
		        this.happiness += 20;
		        return "🦜 Chirp chirp!";
            }
        }
	}
    public string TrashTalk()
    {
        this.happiness -= 30;
        return "😭 Oh no! Your parrot is sad!";
    }
    public string Help()
    {
        return "Commands: m = MOVE, tt = TRASHTALK, t = TALK, ff = FEED FOOD, fg = FEED GARBAGE, n = NAME, q = QUIT, h = HELP, ghu = GET HUNGER, gha = GET HAPPINESS";
    }

    public string Eat(object item) {
        ArgumentNullException.ThrowIfNull(item);
        if (item is Seed) {
            if (this.hunger >= 100)
            {
                return "🫃 OBESE PARROT! Feed it garbage!";
            } else {
			    this.hunger += 30;
			    return "😋 Nom nom nom!!!";
            }
		} else {
			this.hunger -= 20;
			return "🤔 What is that? I don't want that!";
		}
	}
}
