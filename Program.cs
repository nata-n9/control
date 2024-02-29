string[] array = { "poi", "teyurjf", "kjl",  "852", "52", "hello", "world", "56f"};
string[] newArray = new string[array.Length];
int newIndex = 0;

for (int i = 0; i < array.Length; i++)
{
if (array[i].Length <= 3)
{newArray[newIndex] = array[i];
newIndex++;
}
}

for (int i = 0; i < newIndex; i++)
{
Console.Write($"{newArray[i]} ");
}
Console.WriteLine();
