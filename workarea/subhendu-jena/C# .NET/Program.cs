using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
internal class Program
{

//implementing both array params and return types.
public static int add(params int[] ListNumbers)
{
int total = 0;

// foreach loop 
foreach (int i in ListNumbers)
{
total += i;
}
return total;
}
//overloaded methods
static int PlusMethod(int x, int y)
{
return x + y;
}

static double PlusMethod(double x, double y)
{
return x + y;
}


static void Main(string[] args)
{   //initial practice
Console.WriteLine("Hello World");
Console.WriteLine("I am Subhendu Kumar Jena");
char a = '@';
int bat = 23;
bool c = false;
double dates = 8.7;
decimal tre = 3.45454M;
string name = "Subhendu";
Console.WriteLine(name + " " + bat+ " " + dates + " " + c+"\n");

//from Microsoft learn module (String interpolation)
Console.WriteLine("Strings and interpolation:");
string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

int gradeA = 4;
int gradeB = 3;

int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;

int totalCreditHours = 0;
totalCreditHours += course1Credit;
totalCreditHours += course2Credit;
totalCreditHours += course3Credit;
totalCreditHours += course4Credit;
totalCreditHours += course5Credit;

int totalGradePoints = 0;
totalGradePoints += course1Credit * course1Grade;
totalGradePoints += course2Credit * course2Grade;
totalGradePoints += course3Credit * course3Grade;
totalGradePoints += course4Credit * course4Grade;
totalGradePoints += course5Credit * course5Grade;

Console.WriteLine($"{totalGradePoints} {totalCreditHours}");

Console.WriteLine($"{course1Name} {course1Grade} {course1Credit}");
Console.WriteLine($"{course2Name} {course2Grade} {course2Credit}");
Console.WriteLine($"{course3Name} {course3Grade} {course3Credit}");
Console.WriteLine($"{course4Name} {course4Grade} {course4Credit}");
Console.WriteLine($"{course5Name} {course5Grade} {course5Credit}"+"\n");

//for each
Console.WriteLine("For-each:");
int[] a_array = new int[] { 1, 2, 3, 4, 5, 6, 7 };
foreach (int items in a_array)
{
Console.Write(items+" ");
}
Console.WriteLine("\n");

//type conversions
Console.WriteLine("Type Conversions:");
int i = 75;
float f = 53.005f;
double d = 2345.7652;
bool b = true;

Console.WriteLine(i.ToString());
Console.WriteLine(f.ToString());
Console.WriteLine(d.ToString());
Console.WriteLine(b.ToString());
Console.WriteLine("\n");

//Switch Case
Console.WriteLine("Switch Case:");
int day =5;
switch (day)
{
case 1:
Console.WriteLine("Monday");
break;
case 2:
Console.WriteLine("Tuesday");
break;
case 3:
Console.WriteLine("Wednesday");
break;
case 4:
Console.WriteLine("Thursday");
break;
case 5:
Console.WriteLine("Friday");
break;
case 6:
Console.WriteLine("Saturday");
break;
case 7:
Console.WriteLine("Sunday");
break;
}
Console.WriteLine("\n");

//Multi-dimensional Arrays
Console.WriteLine("Multidimensional array:");
int[,,] cube = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } };

Console.WriteLine(cube[0, 1, 2]); 

Console.WriteLine(cube[1, 0, 1]); 
Console.WriteLine("\n");

// Creating a jagged array
Console.WriteLine("Jagged Arrays: ");
int[][] jaggedArray = new int[3][];
jaggedArray[0] = new int[] { 1, 2, 3 };
jaggedArray[1] = new int[] { 4, 5 };
jaggedArray[2] = new int[] { 6, 7, 8, 9 };

// Accessing elements of the jagged array
Console.WriteLine(jaggedArray[0][0]); 
Console.WriteLine(jaggedArray[1][1]); 
Console.WriteLine(jaggedArray[2][3]); 

//param arrays implementation
Console.WriteLine("Params array:");
int sum;
// passing three parameters
sum = Program.add(1, 2, 3);
Console.WriteLine("Sum of 1,2,3 is:\t{0}", sum);

// passing five parameters
sum = Program.add(3, 5, 2, 6, 2);
Console.WriteLine("Sum of 3,5,2,6,2 is:\t{0}", sum);
Console.WriteLine("\n");


//Arraylist implementation
Console.WriteLine("ArrayList: ");
ArrayList myList = new ArrayList();
// Adding elements to ArrayList 
myList.Add("Hello");
myList.Add("World");
myList.Add("A");
myList.Add("B");
myList.Add("C");
myList.Add("D");
myList.Add("E");
myList.Add("F");

Console.WriteLine("Count : " + myList.Count);
Console.WriteLine("Capacity : " + myList.Capacity);

Console.WriteLine("\n");

//Hashtable implementation
Console.WriteLine("HashTable: ");
Hashtable my_hashtable1 = new Hashtable();
my_hashtable1.Add("A1", "Welcome");
my_hashtable1.Add("A2", "to");
my_hashtable1.Add("A3", "GeeksforGeeks");

Console.WriteLine("Key and Value pairs from my_hashtable1:");

foreach (DictionaryEntry ele1 in my_hashtable1)
{
Console.WriteLine("{0} and {1} ", ele1.Key, ele1.Value);
}

Hashtable my_hashtable2 = new Hashtable() {
{1, "hello"},
{2, 234},
{3, 230.45},
{4, null}};

Console.WriteLine("Key and Value pairs from my_hashtable2:");

foreach (var ele2 in my_hashtable2.Keys)
{
Console.WriteLine("{0} and {1}", ele2,
my_hashtable2[ele2]);
}
Console.WriteLine("\n");

//SortedList Implementations
Console.WriteLine("SortedList(add and remove and clear):");
SortedList my_slist = new SortedList();
// Adding key/value pairs in SortedList
my_slist.Add(1.02, "This");
my_slist.Add(1.07, "Is");
my_slist.Add(1.04, "SortedList");
my_slist.Add(1.01, "Tutorial");

foreach (DictionaryEntry pair in my_slist)
{
Console.WriteLine("{0} and {1}",
pair.Key, pair.Value);
}
Console.WriteLine();

// Remove value having 1.07 key
my_slist.Remove(1.07);

// After Remove() method
foreach (DictionaryEntry pair in my_slist)
{
Console.WriteLine("{0} and {1}",
pair.Key, pair.Value);
}
Console.WriteLine();

// Remove element at index 2
my_slist.RemoveAt(2);

// After RemoveAt() method
foreach (DictionaryEntry pair in my_slist)
{
Console.WriteLine("{0} and {1}",
pair.Key, pair.Value);
}
Console.WriteLine();

// Remove all key/value pairs
my_slist.Clear();
Console.WriteLine("The total number of key/value pairs" +
" present in my_slist:{0}", my_slist.Count);
Console.WriteLine();

//exception handling
Console.WriteLine("Exception Handling:");
try
{
int[] myNumbers = { 1, 2, 3 };
Console.WriteLine(myNumbers[10]);
}
catch (Exception e)
{
Console.WriteLine(e);
Console.WriteLine(e.Message);
//throw e;
}

finally//optional usage
{
Console.WriteLine();
}

int myNum1 = PlusMethod(8, 5);
double myNum2 = PlusMethod(4.3, 6.26);
Console.WriteLine("Int: " + myNum1);
Console.WriteLine("Double: " + myNum2);
Console.WriteLine();


Console.ReadLine();
}
}
}
