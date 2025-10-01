// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//1 Discover value types and reference types
//decimal to binary: 116 -> 01110100
//text to binary: a = 97, b = 98, A = 65, B =66 -> same process
//number of bits allow up to 2^n -1. e.g. 128 is 8 bits so allows 0-255


//Exercise - Discover integral types


//signed: negative and positive
//unsigned: only positive but roughly the same range as signed.

//signed integral types
Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

//Unsigned integral types

Console.WriteLine("");
Console.WriteLine("Unsigned integral types:");

Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

//floating points
//A floating-point type is a simple value data type that can hold fractional numbers.

Console.WriteLine("");
Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)"); //less acccurate, more range
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)"); //in between
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)"); //more accurate, less range

//Exercise - Discover reference types
/*
-------Value Types (store actual data)

Numeric types: byte, sbyte, short, ushort, int, uint, long, ulong, float, double, decimal

Boolean: bool (true / false)

Character: char

Structs: user-defined or built-in structs (DateTime, TimeSpan)

Enumerations: enum

--------Reference Types (store reference to data)

String: string

Arrays: int[], string[], etc.

Classes: built-in or user-defined (class Person { })

Interfaces: IEnumerable, IDisposable, etc.

Delegates: Action, Func<>, custom delegates

Objects: object
*/


/* heap vs stack
Value types → stack (data stored directly)

Reference types → heap (data stored in heap; reference stored in stack)
*/




int[] data = new int[3];
//Value Type (int)
int val_A = 2;
int val_B = val_A;
val_B = 5;

Console.WriteLine("--Value Types--");
Console.WriteLine($"val_A: {val_A}");
Console.WriteLine($"val_B: {val_B}");

//Reference Type (array): In this example, ref_A and ref_B are array reference types.
int[] ref_A= new int[1];
ref_A[0] = 2;
int[] ref_B = ref_A;
ref_B[0] = 5;

Console.WriteLine("--Reference Types--");
Console.WriteLine($"ref_A[0]: {ref_A[0]}");
Console.WriteLine($"ref_B[0]: {ref_B[0]}");

//basically when you say ref_b = ref_a then change ref_b, that changes ref_a as well. 
//ref_A and ref_B both point to the same array in memory.
//like two remote controls pointing to the same TV:

//2 Convert Data Types Using Casting and Conversion Techniques in C#

//note the below works as we can convert an integer and a bool into a string. 
int first = 2;
bool yes = true;
string second = "4";
string result = first + second + yes;
Console.WriteLine(result);
//However can't convert string into integer!


//CASTING
// note the below is a narrowing CASTING
decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

int myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}");
//whereas the below is a widening CASTING

int jonInteger = 5;
Console.WriteLine($"Int: {jonInteger}");

decimal jonDecimal = (decimal)jonInteger;
Console.WriteLine($"Dec: {jonDecimal}");



//Performing Data Conversions
//CONVERTING

//Use ToString() to convert a number to a string
int a = 5;
int b = 7;
string message = a.ToString() + b.ToString();
Console.WriteLine(message);
//Convert a string to an int using the Parse() helper method
string c = "5";
string d = "7";
int sum = int.Parse(c) + int.Parse(d);
Console.WriteLine(sum);
//Convert a string to a int using the Convert class
string value1 = "5";
string value2 = "7";
int res = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(res);

//Compare casting and converting a decimal into an int
int value = (int)1.5m; // casting truncates
Console.WriteLine(value);

int v2 = Convert.ToInt32(1.3m); // converting rounds 
Console.WriteLine(v2);

//Exercise - Examine the TryParse() method
string value3 = "102";
int result_3 = 0;
if (int.TryParse(value3, out result_3))
{
   Console.WriteLine($"Measurement: {result_3}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}
Console.WriteLine($"Measurement (w/ offset): {50 + result_3}");


string input4 = "101.5";
decimal decimal4 = 0;
Console.WriteLine(decimal4);
Console.WriteLine(decimal.TryParse(input4, out decimal4)); //This is Boolean as is true. also does the thing inside.
Console.WriteLine(decimal4);

/*Exercise - Complete a challenge to combine string array
values as strings and as integers*/
string[] values = {"12.3", "45", "ABC", "11", "DEF"};
string myMessage = "";
decimal total = 0;
foreach (string myValue in values)
{
    if (decimal.TryParse(myValue, out decimal decimalValue))
    {
        total += decimalValue;

    }
    else
    {
        myMessage += myValue;
    }
}
Console.WriteLine($"Message: {myMessage}");
Console.WriteLine($"Total: {total}");


/* Exercise - Complete a challenge to output math operations as
 specific numbertypes */
int thing1 = 11;
decimal thing2 = 6.2m;
float thing3 = 4.3f;

// Your code here to set result1



int result1 = Convert.ToInt32(thing1 / thing2);


//Convert.ToInt32(1.3m)

// Hint: You need to round the result to nearest integer (don't just truncate)
Console.WriteLine($"Divide thing1 by thing2, display the result as an int: {result1}");

// Your code here to set result2
decimal result2 =  thing2 / (decimal) thing3;

Console.WriteLine($"Divide thing2 by thing3, display the result as a decimal: {result2}");

// Your code here to set result3
//don't need the below because it gets implicitly converted:
//float result3 =  thing3 / (float) thing1;
//Can just have below instead:
float result3 =  thing3 / thing1;





Console.WriteLine($"Divide thing3 by thing1, display the result as a float: {result3}");


//3 Perform Operations on Arrays Using Helper Methods in C#

//Sort, Reverse
string[] pallets = [ "B14", "A11", "B12", "A13" ];

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

//Clear
string[] slabs = [ "B14", "A11", "B12", "A13" ];
Console.WriteLine("");

Console.WriteLine($"Before: {slabs[0].ToLower()}");
Array.Clear(slabs, 0, 2);

if (slabs[0] == null) {
    Console.WriteLine($"After: {slabs[0]}");


    }
else {
    Console.WriteLine($"After: {slabs[0].ToLower()}");

};

Console.WriteLine($"Clearing 2 ... count: {slabs.Length}");
foreach (var pallet in slabs)
{
    Console.WriteLine($"-- {pallet}");
};


//Resize
Array.Resize(ref slabs, 7);
slabs[5] = "C01";


Console.WriteLine($"Clearing 2 ... count: {slabs.Length}");
foreach (var pallet in slabs)
{
    Console.WriteLine($"-- {pallet}");
};

//split and join

//Use the ToCharArray() to reverse a string 
//Reverse, then combine the char array into a new string
        string Value = "abc123";
        char[] ValueArray = Value.ToCharArray();
        Array.Reverse(ValueArray);
        string Result = new string(ValueArray);
        Console.WriteLine(Result);

//Combine all of the chars into a new comma-separated-value string using Join()
        string vAlue = "abc123";
        char[] vAlueArray = vAlue.ToCharArray();
        Array.Reverse(vAlueArray);
        // string result = new string(valueArray);
        string rEsult = String.Join(",", vAlueArray);
        Console.WriteLine(rEsult);


//Split() the comma-separated-value string into an array of strings
        string vaLue = "abc123";
        char[] vaLueArray = vaLue.ToCharArray();
        Array.Reverse(vaLueArray);
        // string result = new string(valueArray);
        string reSult = String.Join(",", vaLueArray);
        Console.WriteLine(reSult);

        string[] items = reSult.Split(',');
        foreach (string item in items)
        {
            Console.WriteLine(item);
        }

//Exercise - Complete a challenge to reverse words in a sentence
string pangram = "The quick brown fox jumps over the lazy dog";
string[] pItems = pangram.Split(' ');
string[] revItemsArray = new string[pItems.Length];

for (int i = 0; i < pItems.Length; i++)
{
    char[] chars = pItems[i].ToCharArray();
    Array.Reverse(chars);
    revItemsArray[i] = new string(chars);
    Console.WriteLine(revItemsArray[i]); // prints each reversed word
}

string revResult = String.Join(" ", revItemsArray);
Console.WriteLine(revResult); // prints the full sentence with reversed words

//Exercise - Complete a challenge to parse a string of orders, sort the orders and tag possible errors


/*the below was my first try, but realised I didn't actually need to convert the string items to character strings,
as we werent changing them like before*/

/*
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] orderItems = orderStream.Split(',');
Array.Sort(orderItems);


for (int i = 0; i < orderItems.Length; i++)
{
    char[] charz = orderItems[i].ToCharArray();
        if (charz.Length == 4)
    {
        Console.WriteLine(orderItems[i]);
    }
    else
    {
        Console.WriteLine($"{orderItems[i]} \t \t - \t error");

    }

}
*/

//here is my second try (the answer)
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] orderItems = orderStream.Split(',');
Array.Sort(orderItems);
foreach (var item in orderItems)
{
    if (item.Length == 4)
    {
        Console.WriteLine($"{item}  \t\t\t - Error");
    }
    else {
        Console.WriteLine($"{item}");

    }

}


//4 Format alphanumeric data for presentation in C#
            //Exercise - Investigate string formatting basics

string First = "Hello";
string Second = "World";
string Answer = string.Format("{0} {1}!", First, Second);
Console.WriteLine(Answer);

string fIrst = "Hello";
string sEcond = "World";
Console.WriteLine("{1} {0}!", fIrst, sEcond);
Console.WriteLine("{0} {0} {0}!", fIrst, sEcond);


string fiRst = "Hello";
string seCond = "World";
Console.WriteLine($"{fiRst} {seCond}!");
Console.WriteLine($"{seCond} {fiRst}!");
Console.WriteLine($"{fiRst} {fiRst} {fiRst}!");

//formatting currency:
decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");
//Formatting numbers
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");
Console.WriteLine($"Measurement: {measurement:N4} units");
//Formatting percentages
decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");
//Combining formatting approaches
decimal Price = 67.55m;
decimal SalePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (Price - SalePrice), Price);

yourDiscount += $"A discount of {((Price - SalePrice)/Price):P2}!"; //inserted
Console.WriteLine(yourDiscount);
            //Exercise - Explore string interpolation


int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal Total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"   Shares: {productShares:N3} Product");
Console.WriteLine($"     Sub Total: {subtotal:C}");
Console.WriteLine($"           Tax: {taxPercentage:P2}");
Console.WriteLine($"     Total Billed: {Total:C}");
//Next unit: Exercise - Discover padding and alignment
//padding
string input = "Pad this";
Console.WriteLine(input.PadLeft(12));
Console.WriteLine(input.PadRight(12));
Console.WriteLine(input.PadLeft(12, '-'));
Console.WriteLine(input.PadRight(12, '-'));
//Working with padded strings:
 string paymentId = "769C";
 string payeeName = "Mr. Stephen Ortega";
 string paymentAmount = "$5,000.00";

 var formattedLine = paymentId.PadRight(4);
 formattedLine += payeeName.PadRight(24);
 formattedLine += paymentAmount.PadLeft(10);

 Console.WriteLine("1234567890123456789012345678901234567890");
 Console.WriteLine(formattedLine);

//Exercise - Complete a challenge to apply string interpolation to a form letter
string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here

Console.WriteLine("Here's a quick comparison:\n");



// Your logic here


Console.WriteLine($"Dear {customerName}, \n ");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return \n");
Console.WriteLine($"Currently, you own {currentShares:N2} shares at a return of {currentReturn:P2} \n");
Console.WriteLine($"Our new product, Glorious Future offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be {newProfit:C}. \n");
Console.WriteLine("Here's a quick comparison: \n"); 

string comparisonMessage = "";
string comparisonMessage2 = "";


comparisonMessage = currentProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(20);
comparisonMessage += String.Format("{0:C}", currentProfit);

comparisonMessage2 = newProduct.PadRight(20);
comparisonMessage2 += String.Format("{0:P}", newReturn).PadRight(20);
comparisonMessage2 += String.Format("{0:C}", newProfit);

///////NOTE!!! The String.Format is being used here to format numbers (decimals) as percentages or currency, because PadRight() only works on strings. 


Console.WriteLine(comparisonMessage);
Console.WriteLine(comparisonMessage2);



//5 Modify the Content of Strings Using Built-In String Data Type Methods in C#
