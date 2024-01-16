# Arrays

## Different ways of declaring arrays
If your desire is to store one value per variable, you can't unless you use arrays. Here is how you can declare and use them:

```cs
String[] names = new string[2]; // only declare the arrays
int[] numbers = new int[2];
bool[] flags = new bool[];
// ...
```

## Assign data to arrays

```cs
// First example
String[] names = new string[2];
names[0] = "John";
names[1] = "James";

// Second example
int[] numbers = new int[2]{1,3};

// Third example
int[] numbers_two = {2,4};
```

## Loop each item in array
If you want to loop through an array, here are some example

```cs
// First example
String[] names = new string[2]{"John","James"};

foreach(string name in names)
{
    Console.WriteLine($"hello { name }");
}
```


