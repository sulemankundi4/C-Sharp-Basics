// See https://aka.ms/new-console-template for more information

using System.ComponentModel;

Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World This is my first program");


string firstName = "Muhammad";
string lastName = "Suleman";


int age = 25;

age = 30;


Console.WriteLine("Hello, " + firstName + " " + lastName);
Console.WriteLine("Hello, " + firstName + " " + lastName + " " + age);

int add = 5+10;
int sub = 20-10;
int mul = 5*10;
int div = 20/12;

// template literals something like this!
Console.WriteLine($"addition: {add}");

float res = 20/12f ;

bool isTrue = true;

DateTime today = DateTime.Now;
DateOnly todayDate = new DateOnly(2024,1,22);
TimeOnly todayTime = new TimeOnly(12, 30, 30);

Console.WriteLine($"DateTime: {today}");
Console.WriteLine($"DateOnly: {todayDate}");
Console.WriteLine($"TimeOnly: {todayTime}");

// Implicit type casting
int num = 10;
double myDouble = num;

Console.WriteLine($"Implicit type casting: {myDouble}");

// Explicit type casting
double myDouble2 = 10.5;
int num2 = (int)myDouble2;

Console.WriteLine($"Explicit type casting: {num2}");

// PARSING

string str = "0.5";
float num3 = float.Parse(str);

Console.WriteLine($"Parsing: {num3}");

if(true){
   Console.WriteLine("this is the true block");
}

int number = 10;

string message = number > 10 ? "Number is greater than 10" : "Number is less than 10";

Console.WriteLine(message);


int marks = 0;

// switch (marks)
// {
//    case marks > 90:
//       Console.WriteLine("A+");
//       break;
//    case marks > 80:
//       Console.WriteLine("A");
//       break;
//    default:
// }


string grade = marks switch {
   > 90 => "A+",
   > 80 => "A",
   _ => "Fail"
};

Console.WriteLine(grade);




/////////////////////////////COLLECTIONS/////////////////////////////

int[] numbers = new int[5];

numbers[0] = 10;
numbers[1] = 20;
numbers[2] = 30;

// How to declare arrays

int[] arr1 = new int[] { 1, 2, 3, 4, 5 };

int[] arr2 = { 1, 2, 3, 4, 5 };

int[] arr3 = [ 1, 2, 3, 4, 5 ];

int length = numbers.Length;

Console.WriteLine($"Length of array: {length}");


// LISTS///////

List<int> demo = new List<int>();

demo.Add(10);
demo.Add(20);
demo.AddRange(new int[] { 30, 40, 50 });

demo.Insert(2, 25);

foreach(int item in demo){
   Console.WriteLine(item);
}

int lengthOfList = demo.Count;

Console.WriteLine($"Length of list: {lengthOfList}");


// ////////////////////////////////////////DICTIONARIES/////////////////////////////

Dictionary<int, string> demoDict = new Dictionary<int, string>();

Dictionary<int, string> demoDictInit = new Dictionary<int, string>{{1, "one"}, {2,"Two"}, {3, "Three"}};

foreach(KeyValuePair<int, string> item in demoDictInit){
   Console.WriteLine($"Key : {item.Key} Value: {item.Value}");
}

// string value = demoDictInit[5]; // Accesses the value associated with key 1

// Console.WriteLine($"Value: {value}");
bool containsKey = demoDictInit.ContainsKey(3); // Checks if the dictionary contains key 3

Console.WriteLine($"Contains key: {containsKey}");

int[] numberArr = [1, 2, 3, 4, 5];

for(int i = 0; i<numberArr.Length; i++){
   Console.WriteLine(numberArr[i]);
}

int sum(int a, int b){
   return a + b;
}

int answer = sum(10, 20);
Console.WriteLine($"sum is: {answer}");