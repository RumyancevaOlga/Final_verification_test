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

string [] FillStringArrayAvailableValues(string [] array, int N)
{
    string [] result = new string [N];
    for(int i = 0; i < N; i++)
    {
        int j = new Random().Next(0, array.Length);
        result[i] = array[j];
    }
    return result;
}

FillStringArray(array);
PrintArray(array);

int N = new Random().Next(0, 4);
Console.WriteLine(N);

string [] newArray = FillStringArrayAvailableValues(array, N);
PrintArray(newArray);
