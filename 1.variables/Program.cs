/*
Hello to an user
display the name, the age 
*/

string name = "John";
int age = 56;
Console.WriteLine($"Hello { name }, you are { age} old");

/*
Math
*/

int x = 34;
int y = 5;

Console.WriteLine($"{x} + {y} = { x + y }");
Console.WriteLine($"{x} * {y} = { x * y }");
Console.WriteLine($"{x} - {y} = { x - y }");
Console.WriteLine($"{x} / {y} = { (decimal) x / y }");

// Parsing
float n_1 = x / 6f;
double n_2 = x / 6d;
decimal n_3 = x / 6m;

Console.WriteLine(n_1);
Console.WriteLine(n_2);
Console.WriteLine(n_3);


// Go futher
string file = "c-sharp.pdf";
Console.WriteLine(@$"c:\user\{file}");