// See https://aka.ms/new-console-template for more information


////////////////////////////////////////////////////////////////////////////

/*2:Call Methods From the .NET Class Library Using C#*/




//There are stateless (static) and stateful (instance) methods.

//Creating an instance of a class
Random dice = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");

/*Next is a stateful method because it depends dice.Next() depends on the internal state of dice.*/
/*Random is the class, dice is the instance (object) of that class,
 and Next(1, 7) is the method called on that instance.*/

/*Your code uses the dice object like a variable that stores the state of
 the Random class. When you call the Next() method on the dice object, the
 method uses the state stored in the dice object to generate a random number.
*/

/*Code challenge: Implement a method of the Math class that returns the larger
 of two numbers*/

int firstValue = 500;
int secondValue = 600;
int largerValue = System.Math.Max(firstValue, secondValue);

Console.WriteLine(largerValue);

////////////////////////////////////////////////////////////////////////////
/*3:Add Decision Logic to Your Code Using if, else, and else if statements in C#
*/

Random bice = new Random();

int boll1 = bice.Next(1, 7);
int boll2 = bice.Next(1, 7);
int boll3 = bice.Next(1, 7); 

int botal = boll1 + boll2 + boll3;

Console.WriteLine($"Dice roll {boll1}, {boll2}, {boll3} is a total of {botal}.");

if (botal > 15)
{
    Console.WriteLine("You win");
}
else {
    Console.WriteLine("You lose");
}
/*booleans*/
string bessage = "hello fox";
bool besult = bessage.Contains('e');
Console.WriteLine(besult);