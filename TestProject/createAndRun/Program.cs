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
// initialize variables - graded assignments 

//Begins here

/*
int currentAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] studentScores = new int[10];

// Write the Report Header to the console
Console.WriteLine("Student\t\tGrade\n");

foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;

    // initialize/reset the sum of scored assignments
    int sumAssignmentScores = 0;

    // initialize/reset the calculated average of exam + extra credit scores
    decimal currentStudentGrade = 0;

    foreach (int score in studentScores)
    {
        // add the exam score to the sum
        sumAssignmentScores += score;
    }

    currentStudentGrade = (decimal)(sumAssignmentScores) / currentAssignments;

    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t?");
}

//Ends here
*/


/* 7.
Challenge Project - Develop foreach and if-elseif-else
Structures to Process Array Data in C#
*/



/* 
This C# console application is designed to:
- Use arrays to store student names and assignment scores.
- Use a `foreach` statement to iterate through the student names as an outer program loop.
- Use an `if` statement within the outer loop to identify the current student name and access that student's assignment scores.
- Use a `foreach` statement within the outer loop to iterate though the assignment scores array and sum the values.
- Use an algorithm within the outer loop to calculate the average exam score for each student.
- Use an `if-elseif-else` construct within the outer loop to evaluate the average exam score and assign a letter grade automatically.
- Integrate extra credit scores when calculating the student's final score and letter grade as follows:
    - detects extra credit assignments based on the number of elements in the student's scores array.
    - divides the values of extra credit assignments by 10 before adding extra credit scores to the sum of exam scores.
- use the following report format to report student grades: 

    Student         Grade

    Sophia:         92.2    A-
    Andrew:         89.6    B+
    Emma:           85.6    B
    Logan:          91.2    A-
*/
int examAssignments = 5;

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

// display the header row for scores/grades
Console.Clear();
Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");

/*
The outer foreach loop is used to:
- iterate through student names 
- assign a student's grades to the studentScores array
- sum assignment scores (inner foreach loop)
- calculate numeric and letter grade
- write the score report information
*/
foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;

    int sumAssignmentScores = 0;

    decimal overallGrade = 0;

    decimal examScore = 0;

    decimal extra = 0;
    decimal credit = 0;

    int gradedAssignments = 0;

    /* 
    the inner foreach loop sums assignment scores
    extra credit assignments are worth 10% of an exam score
    */
    foreach (int score in studentScores)
    {
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
        {
            sumAssignmentScores += score;
            examScore += score;
        }

        else
            extra += score;
            sumAssignmentScores += score / 10;
    }
    credit = extra / 50;
    extra = extra / (gradedAssignments - examAssignments);


    examScore = examScore / examAssignments;

    overallGrade = examScore + credit;

    if (overallGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (overallGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (overallGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (overallGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (overallGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (overallGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (overallGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (overallGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (overallGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (overallGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (overallGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (overallGrade >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";

    // Student         Grade
    // Sophia:         92.2    A-
    
    Console.WriteLine($"{currentStudent}\t\t{examScore}\t\t{overallGrade}\t{currentStudentLetterGrade}\t{extra} ({credit} pts)");
}

// required for running in VS Code (keeps the Output windows open to view results)
Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();
