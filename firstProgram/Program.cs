// See https://aka.ms/new-console-template for more information

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