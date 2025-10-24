
// CHALLENGE 6
/*
🧮 Challenge 6: Calculator Reborn (150 XP)
Concepts: methods, parameters, return values, branching.
Create a console calculator that:
Asks for two numbers
Asks for an operation (+, -, *, /)
Uses a method per operation to perform the math
Prints the result
Bonus: prevent division by zero gracefully.
*/

Console.Write("Enter first number: ");
int first = int.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
int second = int.Parse(Console.ReadLine());
Console.Write("Enter operator (+, -, *, /, %): ");
string sign = Console.ReadLine();

int GetSum(int a, int b) => a + b;
int GetSubtraction(int a, int b) => a - b;
int GetProduct(int a, int b) => a * b;
decimal GetDivision(decimal a, decimal b)
{
    if (a == 0 || b == 0)
    {
        Console.WriteLine("Cannot divide a number by 0!");
        return 0;
    }
    else
    {
        return a / b;
    }
};
int GetRemainder(int a, int b) => a % b;

switch (sign) {
    case "+":
        Console.WriteLine($"{first} + {second} = {GetSum(first, second)}");
        break;
    case "-":
        Console.WriteLine($"{first} - {second} = {GetSubtraction(first, second)}");
        break;
    case "*":
        Console.WriteLine($"{first} * {second} = {GetProduct(first, second)}");
        break;
    case "/":
        Console.WriteLine($"{first} / {second} = {GetDivision(first, second)}");
        break;
    case "%":
        Console.WriteLine($"{first} % {second} = {GetRemainder(first, second)}");
        break;
    default:
        Console.WriteLine("Invalid operator!");
        break;
}


//CHALLENGE 5
/*
 🔣 Challenge 5: The Codeword Guesser (125 XP)
   Concepts: loops, conditionals, string comparison.
   Let the player guess a secret codeword (e.g., "shadow").
   Keep looping until they guess correctly.
   Print the number of attempts taken.
*/

string secret = "shadow";
string secretCode;
int trialCount = 0;
do
{
    Console.Write("Guess the secret codeword: ");
    secretCode = Console.ReadLine().Trim().ToLower();
    trialCount++;
} while (secretCode != secret);

if (secretCode == secret)
    Console.WriteLine("The secret codeword was correct!");
Console.WriteLine($"{trialCount} trials");


// CHALLENGE 4
/*
 * 📦 Challenge 4: Inventory Counter (100 XP)
   Concepts: arrays or lists, loops, user input.
   Create an inventory program that lets the user enter the names of 5 items.
   Then display all of them back numbered 1–5.
   Bonus XP: let the user specify how many items they want to enter instead of hardcoding 5.
 */
Console.WriteLine("How many items do you want to add?: ");
int capacity = int.Parse(Console.ReadLine());

List<string> items = new List<string>(capacity);

do
{
    Console.Write("What would you like to add?");
    string item = Console.ReadLine();
    
    items.Add(item);
} while (items.Count != capacity);

foreach (string item in items)
    Console.WriteLine($"{items.IndexOf(item) + 1}: {item}");



// CHALLENGE 3
/*
 * 🔁 Challenge 3: Countdown Commander (75 XP)
   Concepts: loops, decrementing, basic flow control.
   Ask the user for a number n.
   Count down from n to 0, printing each number.
   At the end, print "Liftoff!".
 */
int number;
do
{
    Console.Write("Enter a number from 1-10: ");
    number = Convert.ToInt32(Console.ReadLine());
} while (number < 1 || number > 10);

for (int i = number; i >= 0 ; i--)
    Console.WriteLine(i == 0 ? "LiftOff!!" : i);


// CHALLENGE 2
/*
 * ⚖️ Challenge 2: The Age Oracle (75 XP)
   Concepts: conditionals, comparison, input parsing.
   Ask the user for their name and age.
   If their age is under 18, tell them they’re too young to enter.
   Between 18 and 40, greet them with enthusiasm.
   Over 40, greet them respectfully.
 */
Console.Write("What is your name? ");
string name = Console.ReadLine();
Console.Write("What is your age? ");
int age = int.Parse(Console.ReadLine());

if (age < 18)
    Console.WriteLine($"You are too young to enter.");
else if (age >= 18 && age <= 40)
    Console.WriteLine($"Welcome {name}, you are in your prime.");
else
    Console.WriteLine($"Welcome old man.");



// CHALLENGE 1
/*
 * 🧠 Challenge 1: The Arithmetic Master (50 XP)
   Concepts: variables, console input/output, arithmetic, type casting.
   Write a program that asks the user for two numbers.
   Then display:
   Their sum
   Their product
   The result of dividing the first by the second (rounded to two decimal places)
   The remainder
 */
// Console.Write("Enter first number: " );
// int first = int.Parse(Console.ReadLine());
// Console.Write("Enter second number: ");
// int second = int.Parse(Console.ReadLine());
//
// int GetSum(int a, int b) => a + b;
// int GetProduct(int a, int b) => a * b;
// decimal GetDivision(decimal a, decimal b) => a / b;
// int GetRemainder(int a, int b) => a % b;
//
// Console.WriteLine($"Sum: {GetSum(first, second)} \n" +
//                   $"Product: {GetProduct(first, second)} \n" +
//                   $"Division: {GetDivision(first, second)} \n" +
//                   $"Remainder: {GetRemainder(first, second)} \n");
