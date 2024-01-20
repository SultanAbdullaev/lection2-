int[] array = {1,2,4,5,6,8,3,12,9,35};
int i = 0;
while (i < array.Length)
{
    if (array[i]%2==0)
    {
        Console.Write($"{array[i]} ");
    }
    i++;
}
