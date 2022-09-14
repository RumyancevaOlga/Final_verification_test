string [] array = new string [10];

string [] FillStringArray(string [] array)
{
    for(int i = 0; i < array.Length; i = i + 2)
    {
        int temp = new Random().Next(-100, 100);
        array[i] = Convert.ToString(temp);
    }
    for(int i = 1; i < array.Length; i = i + 2)
    {
       System.Random temp = new Random(Guid.NewGuid().GetHashCode());
       array[i] = Convert.ToString(Convert.ToChar(Convert.ToInt32(Math.Floor(26 * temp.NextDouble() + 65))));
    }
    return array;
}

void PrintArray(string [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

FillStringArray(array);
PrintArray(array);
