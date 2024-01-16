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

Notice: 
- Simple quote is used for the **char** variable
- Double quote is used for the **string** variable

## Console our variables

```cs
string name = "Pierre";

Console.WriteLine(name); // Displays "Pierre"
```

### Explanation

- Console : is a **class** in the dotnet framework (thanks)
- WriteLine() : is a **method** of the class **Console**


```cs
Console.WriteLine("Hello"); 
Console.WriteLine(name);

/*
Hello
Pierre
*/

// You can delete the "line" and call the method Write only, look

Console.Write("Hello "); 
Console.Write(name);

// Hello Pierre

```



