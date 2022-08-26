Console.WriteLine("Enter array's length");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];
for (int i = 0; i < length; i++)
{
    array[i] = new Random().Next(-10, 11);
}
Console.WriteLine($"[{String.Join(", ", array)}]");
int buffer;
for (int k = 0; k < length / 2; k++)
{
    buffer = array[k];
    array[k] = array[length - k - 1];
    array[length - k - 1] = buffer;
}
Console.WriteLine($"[{String.Join(", ", array)}]");