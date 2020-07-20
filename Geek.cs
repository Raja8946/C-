// C# Program to illustrate calling of 
// parameterized constructor. 
using System; 
namespace ParameterizedConstructorExample { 

class Geek { 

	// data members of the class. 
	String name; 
	int id; 

	// parameterized constructor would 
	// initialized data members with 
	// the values of passed arguments 
	// while object of that class created. 
	Geek(String name, int id) 
	{ 
		this.name = name; 
		this.id = id; 
	} 

	// Main Method 
	public static void Main() 
	{ 

		// This will invoke parameterized 
		// constructor. 
		Geek geek1 = new Geek("GFG", 1); 
		Console.WriteLine("GeekName = " + geek1.name + 
    						" and GeekId = " + geek1.id); 
	} 
} 
} 
