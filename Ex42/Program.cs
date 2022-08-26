Console.Write("Введите число: ");
int num= Convert.ToInt32(Console.ReadLine());
int res= num;
int remainder = 0;
int count = 0;

int[] arr = new int[10];

while (num >= 1)
{
    remainder = num % 2;
    arr[count] = remainder;
    count++;
    num = num / 2;
};
Array.Resize( ref arr, count);
int buffer;
for (int k = 0; k < count / 2; k++)
{
    buffer = arr[k];
    arr[k] = arr[count - k - 1];
    arr[count - k - 1] = buffer;
}
Console.WriteLine($"Число {res} в двоичной системе: {String.Join("", arr)}");