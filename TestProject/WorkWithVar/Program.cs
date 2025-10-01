// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//2 Discover value types and reference types
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

//3 Convert Data Types Using Casting and Conversion Techniques in C#

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