# Variables

There are different type of variable. We have **string**, **char**, **int**, **decimal**, **double**, **float**, **bool**

## Let us see how we declare a typed variable and assign a value.

| type    | name | = | value |
| --------| -----|---| ------|
| int     | age  | = | 23    |


```cs
int age // 1. declaration
age = 23; // 2. Assign a value to age

// OR
int age = 23;
```

## Discover more variables

```cs
string name = "John";
char letter = 'B';

int age = 23;

decimal x = 23.5234;
double y = 21.223;
float z = 48.3;
```

Note: 
- Simple quote is used for the **char** variable
- Double quote is used for the **string** variable

## Console our variables

```cs
string name = "John";

Console.WriteLine(name); // Displays "John"

// OR
Console.Write("Hello" );
Console.Write(name); // display "Hello John"
```

# $ Interpolation

>The $ character identifies a string literal as an >interpolated string. An interpolated string is a string >literal that might contain interpolation expressions. When an >interpolated string is resolved to a result string, items >with interpolation expressions are replaced by the string >representations of the expression results.

```cs
string name = "John";
int age = 23;

Console.WriteLine($"Hello {name}, you are { age } old");
```

# Parsing 

Sometimes, obtaining a result as a float, double, or decimal is crucial. It's essential to declare the appropriate variable type to ensure that the expected result aligns with the chosen variable type.

```cs
int x = 34;
int y = 6;

float n_1 = x / 6f;
double n_2 = x / 6d;
decimal n_3 = x / 6m;

float n_4 = (float) x / y;
double n_5 = (double) x / y;
decimal n_6 = (decimal) x / y;
```



