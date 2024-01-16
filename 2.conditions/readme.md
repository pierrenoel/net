# Conditions

The conditions are always the same in every programming language. 

```cs
bool flag = true;

if(flag)
{
    Console.WriteLine("You have access");
}
else {
    Console.WriteLine("You don't have access");
}
```

But, if you have one statement, you can remove the bracket

```cs
bool flag = true;

if(flag)
    Console.WriteLine("You have access");

else 
    Console.WriteLine("You don't have access");

```

And even more, you can use ternary condition

```cs
bool flag = true;
Console.WriteLine($"{ (flag ? "You have access" : "You don't have acess") }");

// Or
string accessibility = flag ? "You have access" : "You don't have access";
Console.log(accessibility);
```

## Else if 

Else if also exists in c#

```cs
Random random = new Random();
int n = random.Next(1,10);

if(n >= 1 && n <= 4) Console.WriteLine("1 to 4");
else if(n >= 5 && n <= 8) Console.WriteLine("5 to 8");
else Console.WriteLine("9 to 10");
```

## Switch

If there are more than 1 else if, using the switch is a best chose

```cs

string name = "John";
string grade = "Manager";

switch(grade)
{
    case "Manager":
        Console.WriteLine("You are a manager");
        break;
    case "CTO":
        Console.WriteLine("You're a cto");
        break;
    //...
    default:
        Console.log("You're an employee");
        break;
}

```
