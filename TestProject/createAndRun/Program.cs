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
string bessage = "hello fox!";
bool besult = bessage.Contains('e');
Console.WriteLine(besult);

/* if statement*/

if ((boll1 == boll2) || (boll2 == boll3))
{
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    botal += 2;
}
;

//Challenge: Improve renewal rate of subscriptions

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}


////////////////////////////////////////////////////////////////////////////

/*
4:Store and iterate through sequences of data using Arrays and the foreach statement
in C#
*/
string[] fraudulentOrderIDs = new string[3];
//could also be int[]

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";

//note both of the below are valid
string[] fraudulentOrderIDs2 = ["A123", "B456", "C789"];
string[] fraudulentOrderIDs3 = { "A123", "B456", "C789" };

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

//Fraudulent order challenge

string[] fraudArray = new string[]
{
    "B123",
    "C234",
    "A345",
    "C15",
    "B177",
    "G3003",
    "C235",
    "B179"
};
foreach (string ID in fraudArray) {
    if (ID.StartsWith("B")) {
        Console.WriteLine($"{ID} is a fraudulent order.");
    }
}

////////////////////////////////////////////////////////////////////////////

/*
5. Create readable code with conventions, whitespace, and comments in C#
*/
/*
char userOption;
int gameScore;
float particlesPerMillion;
bool processedCustomer;
*/
////////////////////////////////////////////////////////////////////////////

/* 6.
Guided project - Develop foreach and if-elseif-else 
structures to process array data in C#*/


// initialize variables - graded assignments 
// initialize variables - graded assignments 
int currentAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

int sophiaSum = 0;

decimal sophiaScore;

sophiaScore = (decimal)sophiaSum / currentAssignments;


foreach (int score in sophiaScores)
{
    sophiaSum += score;
}

sophiaScore = (decimal)sophiaSum / currentAssignments;


Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();










