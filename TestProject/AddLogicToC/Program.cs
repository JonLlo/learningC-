//1. Evaluate Boolean Expressions to Make Decisions in C#



Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue = "a";
Console.WriteLine(myValue == "a");

string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));

// These two lines of code will create the same output

Console.WriteLine(pangram.Contains("fox") == false);
Console.WriteLine(!pangram.Contains("fox"));

//conditional operator
//<evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>
int saleAmount = 1001;
// int discount = saleAmount > 1000 ? 100 : 50;

Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

//Code challenge: write code to display the result of a coin flip


Random coin = new Random() ;
Console.WriteLine(coin.Next(0,2) == 1 ? "heads" : "tails");


//Decision logic challenge
string permission = "Admin";
int level = 55;
if (permission.Contains("Admin"))
{
    Console.WriteLine(level > 55 ? "Welcome, Super Admin user." : "Welcome, Admin User.");

}
else if (permission.Contains("Manager"))
{
    Console.WriteLine(level >= 20 ? "Contact an admin for access." : "You do not have sufficient privileges");

}
else
{
    Console.WriteLine("You do not have sufficient privileges");
}


//2 Control Variable Scope and Logic Using Code Blocks in C#
int[] numbers = { 4, 8, 15, 16, 23, 42 };
bool found = false;
int total = 0;

foreach (int number in numbers)
{
    

    total += number;

    if (number == 42)
    {
       found = true;

    }

}

if (found) 
{
    Console.WriteLine("Set contains 42");

}

Console.WriteLine($"Total: {total}");

//3 Branch the Flow of Code Using the switch-case Construct in C#

//switch statements
//example1
int employeeLevel = 200;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}");
//challenge: Convert the following IF statement to a SWITCH statment:

// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";


switch (product[0])
{
    case "01":
        type = "Sweat shirt";
        break;
    case "02":
        type = "T-shirt";
        break;
    case "03":
        type = "Sweat pants";
        break;
    default:
        type = "other";
        break;
}


switch (product[1])
{
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Maroon";
        break;
    default:
        color = "other";
        break;
}
switch (product[2])
{
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "One size fits all";
        break;
}




Console.WriteLine($"Product: {size} {color} {type}");

//4. Iterate Through a Code Block Using the for Statement in C#
//example
string[] names = { "Alex", "Eddie", "David", "Michael" };

for (int i = 0; i < names.Length; i++)
{
    if (names[i] == "David")
    {
        names[i] = "Sammy";
    }
}

foreach (var name in names)
{
    Console.WriteLine(name);
}
//challenge - FizzBuzz

/*Here are the FizzBuzz rules that you need to implement in your code project:

Output values from 1 to 100, one number per line, inside the code block of an iteration statement.
When the current value is divisible by 3, print the term Fizz next to the number.
When the current value is divisible by 5, print the term Buzz next to the number.
When the current value is divisible by both 3 and 5, print the term FizzBuzz next to the number.*/

//can uncomment if you want to see it:
/*for (int i = 1; i < 101; i++)
{
    string result = (i % 5 == 0 && i % 3 == 0) ? "FizzBuzz" : i % 3 == 0 ? "Fizz" : i % 5 == 0 ? "Buzz" : "";
    Console.WriteLine($"{i} - {result}");
}
*/

//5:Add Looping Logic to Your Code Using the do-while and while Statements in C#
//do vs while
Random random = new Random();
int current = random.Next(1, 11);

do
{
    current = random.Next(1, 11);

    if (current >= 8) continue; //continue just takes you out this part* of the loop but carries on

    Console.WriteLine(current); //here*
} while (current != 7);

/*
while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");
*/

//Exercise - Role playing game battle challenge
/*Here are the rules for the battle game that you need to implement in your code project:

You must use either the do-while statement or the while statement as an outer game loop.
The hero and the monster start with 10 health points.
All attacks are a value between 1 and 10.
The hero attacks first.
Print the amount of health the monster lost and their remaining health.
If the monster's health is greater than 0, it can attack the hero.
Print the amount of health the hero lost and their remaining health.
Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
Print the winner.*/

Random r = new Random();
int heroAttack = 0;
int monsterAttack = 0;
int monsterHealth = 10;
int heroHealth = 10;

do
{
    monsterAttack = r.Next(1, 11);
    heroHealth = heroHealth - monsterAttack;


    Console.WriteLine($"Hero was damaged and lost {monsterAttack} health and now has {heroHealth} health");




    ; //continue just takes you out this part* of the loop but carries on
    if (heroHealth <= 0) continue;

        heroAttack = r.Next(1, 11);
        monsterHealth = monsterHealth - heroAttack;



        Console.WriteLine($"Monster was damaged and lost {heroAttack} health and now has {monsterHealth} health");


    
} while (heroHealth > 0 && monsterHealth > 0);

if (heroHealth <= 0)
{
    Console.WriteLine($"Winner is monster");
}
else if (monsterHealth <= 0)
{
    Console.WriteLine($"Winner is Hero");
}

/*NOTE

if (true) continue;
Console.WriteLine('hello');

is equivalent to:

if (false) {
    Console.WriteLine('hello');
}
*/


//Exercise - Complete a challenge activity to differentiate between do and while iteration statements

//example:
/*
string? readResult;
bool validEntry = false;
Console.WriteLine("Enter a string containing at least three characters:");
do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (readResult.Length >= 3)
        {
            validEntry = true;
        }
        else
        {
            Console.WriteLine("Your input is invalid, please try again.");
        }
    }
} while (validEntry == false);
*/
/*

//Note - the below 2 examples allow you to check if something is a string or int or something and return true if so......
                    // capture user input in a string variable named readResult example 1:

                    string readResult1 = "123";
                    int numericValue1;
                    bool validNumber1;

                    validNumber1 = int.TryParse(readResult1, out numericValue1);

                    // After this:
                    Console.WriteLine(validNumber1); // true
                    Console.WriteLine(numericValue1); // 123

                    // capture user input in a string variable named readResult example 2:

                    string readResult2 = "abc";
                    int numericValue2;
                    bool validNumber2;

                    validNumber2 = int.TryParse(readResult2, out numericValue2);

                    // After this:
                    Console.WriteLine(validNumber2); // false
                    Console.WriteLine(numericValue2); // 0


*/

/*
//Code project 1 - write code that validates integer input

string? readResponse;
int readValue = 0;
bool entry = false;
Console.WriteLine("Enter an integer between 5 and 10");
do
{
    readResponse = Console.ReadLine();
    if (readResponse != null && int.TryParse(readResponse, out readValue))
    {
        if (readValue <= 10 && readValue >=5)
        {
            entry = true;
        }
        else
        {
            Console.WriteLine("Your input is invalid, please try again.");
        }
    }
} while (!entry);
Console.WriteLine($"You entered a valid number. Namely, {readValue}");
/*
*/
//Code project 2 - write code that validates string input
/*
string? readResponse2;
bool entry2 = false;


Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
do
{
    readResponse2 = Console.ReadLine();
    if (readResponse2 == "Administrator" || readResponse2 == "Manager" || readResponse2 == "User")
    {

        entry2 = true;
    }

    else
    {
        Console.WriteLine($"Your input ({readResponse2}) has NOT been accepted. Try again");

    }
    }  while (!entry2);

Console.WriteLine($"Your input ({readResponse2}) has been accepted");
*/
//Code project 3 - Write code that processes the contents of a string array

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    // extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {

        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }
 
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}



///IndexOf → find the next split point

//Remove → get the part before it

//Substring → get the part after it

//6:Guided Project - Develop Conditional Branching and Looping Structures in C#

